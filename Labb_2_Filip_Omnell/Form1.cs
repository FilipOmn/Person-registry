using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_2_OOP
{
    public partial class Form1 : Form
    {
        List<Person> PersonList = new List<Person>();
        int SortingIndex;
        Timer ExceptionMessageTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            SortButton_2.Enabled = false;
            SortButton_2.Visible = false;

            PersonsListBox.SelectionMode = SelectionMode.MultiSimple;
            SortingIndex = 0;

            ExceptionLabel.Text = "";
            ExceptionMessageTimer.Interval = 3000;
            ExceptionMessageTimer.Tick += Timer_Tick;
        }

        //Funktion för att visa alla personer i personlistan i listboxen.
        void ShowList()
        {
            foreach (Person item in PersonList)
            {
                PersonsListBox.Items.Add(item.GetName());
            }
        }

        //Lägg till person knapp
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                ExceptionLabel.Text = "TextBoxes cannot be empty!";
                ExceptionMessageTimer.Start();
            }
            else
            {
                if (MaleRadioButton.Checked)
                {
                    PersonList.Add(new Male(FirstNameTextBox.Text, LastNameTextBox.Text));
                }

                if (FemaleRadioButton.Checked)
                {
                    PersonList.Add(new Female(FirstNameTextBox.Text, LastNameTextBox.Text));
                }

                PersonsListBox.Items.Clear();

                if (SortingIndex == 0)
                {
                    PersonList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
                }
                if (SortingIndex == 1)
                {
                    PersonList.Sort((x, y) => string.Compare(x.LastName, y.LastName));
                }

                ShowList();
            } 
        }

        //Ta bort personer knapp, tar bort personer som är markerade.
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            for (int x = PersonsListBox.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int px = PersonsListBox.SelectedIndices[x];
                PersonList.RemoveAt(px);
            }

            PersonsListBox.Items.Clear();

            ShowList();
        }

        //Sorterings, knapp, sorterar efter efternamn.
        private void SortButton_Click(object sender, EventArgs e)
        {
            SortButton.Enabled = false;
            SortButton.Visible = false;

            SortButton_2.Enabled = true;
            SortButton_2.Visible = true;

            //PersonList.Sort((x, y) => string.Compare(x.LastName, y.LastName));
            Person.ehhInt = 0;
            PersonList.Sort();
            PersonsListBox.Items.Clear();

            ShowList();

            SortingIndex = 1;
            SortingByLabel.Text = "Sorting by: Lastname";
        }

        //Sorteringsknapp nr 2, ändrar så att personer sorteras efter förnamn
        private void SortButton_2_Click(object sender, EventArgs e)
        {
            SortButton_2.Enabled = false;
            SortButton_2.Visible = false;

            SortButton.Enabled = true;
            SortButton.Visible = true;

            //PersonList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
            Person.ehhInt = 1;
            PersonList.Sort();
            PersonsListBox.Items.Clear();

            ShowList();

            SortingIndex = 0;
            SortingByLabel.Text = "Sorting by: Firstname";
        }

        List<Person> MergeList = new List<Person>();
        List<Male> Malelist = new List<Male>();
        List<Female> FemaleList = new List<Female>();

        //Mergar två personer av olika kön till ett child med förnamn från female och efternamn från male.
        private void MergeButton_Click(object sender, EventArgs e)
        {
            if (PersonsListBox.SelectedItems.Count == 2)
            {
                for (int x = PersonsListBox.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int px = PersonsListBox.SelectedIndices[x];
                    MergeList.Add(PersonList[px]);
                }

                if (MergeList[0] is Male && MergeList[1] is Male || MergeList[0] is Female && MergeList[1] is Female)
                {
                    ExceptionLabel.Text = "Two people of the same gender cannot be merged!";
                    ExceptionMessageTimer.Start();
                    MergeList.Clear();
                }

                if (MergeList.OfType<Child>().Any())
                {
                    ExceptionLabel.Text = "Cannot merge children!";
                    ExceptionMessageTimer.Start();
                    MergeList.Clear();
                }

                if(MergeList.Count != 0)
                {
                    if (MergeList[0] is Male && MergeList[1] is Female)
                    {
                        Malelist.Add(new Male(MergeList[0].FirstName, MergeList[0].LastName));
                        FemaleList.Add(new Female(MergeList[1].FirstName, MergeList[1].LastName));
                    }

                    if (MergeList[0] is Female && MergeList[1] is Male)
                    {
                        Malelist.Add(new Male(MergeList[1].FirstName, MergeList[1].LastName));
                        FemaleList.Add(new Female(MergeList[0].FirstName, MergeList[0].LastName));
                    }

                    var MergeChild = Malelist[0] + FemaleList[0];

                    PersonList.Add(MergeChild);
                    MergeList.Clear();
                    Malelist.Clear();
                    FemaleList.Clear();
                    PersonsListBox.Items.Clear();

                    if (SortingIndex == 0)
                    {
                        PersonList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
                    }
                    if (SortingIndex == 1)
                    {
                        PersonList.Sort((x, y) => string.Compare(x.LastName, y.LastName));
                    }

                    ShowList();
                }
            }
        }

        //Event för timer, gör så att felmeddelanden visas i tre sekunder.
        private void Timer_Tick(object sender, EventArgs e)
        {
            ExceptionLabel.Text = "";
            ExceptionMessageTimer.Stop();
        }

        //Sök funktion, söker listan av personer som matchar användarens input.
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                ShowList();
            }

            var SearchInput = SearchTextBox.Text;
            List<Person> SearchList = new List<Person>();

            SearchList = PersonList.Where(x => x.GetNameForSearch().ToUpper().Contains(SearchInput.ToUpper())).ToList();

            PersonsListBox.Items.Clear();
            foreach(Person p in SearchList)
            {
                PersonsListBox.Items.Add(p.GetName());
            }  
        }
    }
}
