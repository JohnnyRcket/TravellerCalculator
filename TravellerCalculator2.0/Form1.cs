using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravellerCalculator2._0
{
    public partial class ttgForm : Form
    {
        public ttgForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.starportModifierTableAdapter.Fill(this.database1DataSet.starportModifier);
            this.popModifierTableAdapter.Fill(this.database1DataSet.popModifier);
            this.techLevelModifierTableAdapter.Fill(this.database1DataSet.techLevelModifier);
            sourceTechBox.SelectedItem = null;
            destinationStarportBox.SelectedItem = null;
            destinationTechBox.SelectedItem = null;
            destinationPopBox.SelectedItem = null;
            sourceStarportBox.SelectedItem = null;
            sourcePopBox.SelectedItem = null;
        }

        private void kofiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ko-fi.com/bizentine");
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            if (AllFilled())
            {
                Random roll = new Random();
                mailResultLabel.Text = "0 Tons";
                freightList.Items.Clear();
                int freightDM = Convert.ToInt32(freightDMNumber.Value);
                int passDM = Convert.ToInt32(passengerDMNumber.Value);
                int freightBonus = RollD(roll) + freightDM - 8;
                int passengerBonus = RollD(roll) + passDM - 8;
                int ppt = Convert.ToInt32(parsecNum.Value);
                IncidentalFreight(FreightTable(RollD(roll) + FreightModifier() + 2 + freightBonus), FreightPPT(ppt), roll);
                LineBreak();
                MinorFreight(FreightTable(RollD(roll) + FreightModifier() + freightBonus), FreightPPT(ppt), roll);
                LineBreak();
                MajorFreight(FreightTable(RollD(roll) + FreightModifier() - 4 + freightBonus), FreightPPT(ppt), roll);
                MailTonnage(FreightModifier(), roll);
                HighPassage(PassengerTable(RollD(roll)) + PassengerModifier() - 4 + passengerBonus, HighPPT(ppt), roll);
                MiddlePassage(PassengerTable(RollD(roll)) + PassengerModifier() + passengerBonus, MiddlePPT(ppt), roll);
                BasicPassage(PassengerTable(RollD(roll)) + PassengerModifier() + passengerBonus, BasicPPT(ppt), roll);
                LowPassage(PassengerTable(RollD(roll)) + PassengerModifier() + 1 + passengerBonus, LowPPT(ppt), roll);
                ttgTabControl.SelectedIndex = 1;
            }
            else
            {
                ErrorCatch(); 
            }
            }

            private void clearButton_Click(object sender, EventArgs e)
        {
            freightList.Items.Clear();
            sourceTechBox.SelectedItem = null;
            destinationStarportBox.SelectedItem = null;
            destinationTechBox.SelectedItem = null;
            destinationPopBox.SelectedItem = null;
            sourceStarportBox.SelectedItem = null;
            sourcePopBox.SelectedItem = null;
            destinationRedCheckBox.Checked = false;
            sourceRedCheckBox.Checked = false;
            destinationAmberCheckBox.Checked = false;
            sourceAmberCheckBox.Checked = false;
            freightDMNumber.Value = 0;
            passengerDMNumber.Value = 0;
            partyStewardNumber.Value = 0;
            partySocNumber.Value = 0;
            partyNSNumber.Value = 0;
            sellerDMNumber.Value = 0;
            parsecNum.Value = 1;
            isArmedCheckBox.Checked = false;
            highPassageResultLabel.Text = "0";
            middlePassageResultLabel.Text = "0";
            basicPassageResultLabel.Text = "0";
            lowPassageResultLabel.Text = "0";
            highPayResultLabel.Text = "0";
            middlePayResultLabel.Text = "0";
            basicPayResultLabel.Text = "0";
            lowPayResultLabel.Text = "0";
            mailResultLabel.Text = "0 Tons";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int RollD(Random roll)
        {
            int nr = roll.Next(1, 7) + roll.Next(1, 7);
            return nr;
        }

        private int Roll1(Random roll)
        {
            int nr = roll.Next(1, 7);
            return nr;
        }

        private void LineBreak()
        {
            ListViewItem item = new ListViewItem("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            freightList.Items.Add(item);
        }

        private int FreightModifier()
        {
            int freightModifier = 0;
            freightModifier += Convert.ToInt32(sourceTechBox.SelectedValue);
            freightModifier += Convert.ToInt32(destinationTechBox.SelectedValue);
            freightModifier += Convert.ToInt32(sourcePopBox.SelectedValue);
            freightModifier += Convert.ToInt32(destinationPopBox.SelectedValue);
            freightModifier += Convert.ToInt32(sourceStarportBox.SelectedValue);
            freightModifier += Convert.ToInt32(destinationStarportBox.SelectedValue);
            if (sourceAmberCheckBox.Checked)
            {
                freightModifier += -2;
            }
            if (destinationAmberCheckBox.Checked)
            {
                freightModifier += -2;
            }
            if (sourceRedCheckBox.Checked)
            {
                freightModifier += -6;
            }
            if (destinationRedCheckBox.Checked)
            {
                freightModifier += -6;
            }
            for (int i = Convert.ToInt32(parsecNum.Value); i > 1; i--)
            {
                freightModifier += -1;
            }
            return freightModifier;
        }



        private int FreightTable(int roll)
        {
            switch (roll)
            {
                case int i when i <= 1: return 0;
                case int i when i >= 2 && i <= 3: return 1;
                case int i when i >= 4 && i <= 5: return 2;
                case int i when i >= 6 && i <= 8: return 3;
                case int i when i >= 9 && i <= 11: return 4;
                case int i when i >= 12 && i <= 14: return 5;
                case int i when i >= 15 && i <= 16: return 6;
                case 17: return 7;
                case 18: return 8;
                case 19: return 9;
                case int i when i >= 20: return 10;
            }
            return 0;
        }

        private void IncidentalFreight(int rollnum, int ppt, Random roll)
        {
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll);
                int price = wr * ppt;
                string num = (i + 1).ToString();
                ListViewItem item = new ListViewItem(num);
                item.SubItems.Add("Incidental");
                item.SubItems.Add(wr.ToString());
                item.SubItems.Add(price.ToString("#,##0"));
                freightList.Items.Add(item);
            }
        }

        private void MinorFreight(int rollnum, int ppt, Random roll)
        {
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll) * 5;
                int price = wr * ppt;
                string num = (i + 1).ToString();
                ListViewItem item = new ListViewItem(num);
                item.SubItems.Add("Minor");
                item.SubItems.Add(wr.ToString());
                item.SubItems.Add(price.ToString("#,##0"));
                freightList.Items.Add(item);
            }
        }

        private void MajorFreight(int rollnum, int ppt, Random roll)
        {
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll) * 10;
                int price = wr * ppt;
                string num = (i + 1).ToString();
                ListViewItem item = new ListViewItem(num);
                item.SubItems.Add("Major");
                item.SubItems.Add(wr.ToString());
                item.SubItems.Add(price.ToString("#,##0"));
                freightList.Items.Add(item);
            }
        }

        private int FreightPPT(int parsecs)
        {
            switch (parsecs)
            {
                case 1: return 1000;
                case 2: return 1600;
                case 3: return 2600;
                case 4: return 4400;
                case 5: return 8500;
                case int i when i >= 6: return 32000;
            }
            return 0;
        }

        private void MailTonnage(int freightDM, Random roll)
        {
            int mailDM = 0;
            if (sourceTechBox.Text == "6 or less")
            {
                mailDM -= 4;
            }
            switch (freightDM)
            {
                case int i when i <= -10: mailDM -= 2; break;
                case int i when i >= -9 && i <= -5: mailDM -= 1; break;
                case int i when i >= -4 && i <= 4: break;
                case int i when i >= 5 && i <= 9: mailDM += 1; break;
                case int i when i >= 10: mailDM += 2; break;
            }
            if (isArmedCheckBox.Checked)
            {
                mailDM += 2;
            }
            mailDM += Convert.ToInt32(partySocNumber.Value) + Convert.ToInt32(partyNSNumber.Value);
            if (mailDM + RollD(roll) >= 12)
            {
                int num = Roll1(roll);
                mailResultLabel.Text = (num * 5).ToString() + " Tons";
            }
        }

        private int PassengerModifier()
        {
            int passengerModifier = 0;
            Console.WriteLine(destinationPopBox.SelectedText);
            passengerModifier += Convert.ToInt32(sourcePopBox.SelectedValue);
            passengerModifier += Convert.ToInt32(destinationPopBox.SelectedValue);
            passengerModifier += Convert.ToInt32(sourceStarportBox.SelectedValue);
            passengerModifier += Convert.ToInt32(destinationStarportBox.SelectedValue);
            if (destinationPopBox.Text == "6-7" || destinationPopBox.Text == "8 or more")
            {
                passengerModifier -= 1;
            }
            if (sourcePopBox.Text == "6-7" || sourcePopBox.Text == "8 or more")
            {
                passengerModifier -= 1;
            }
            if (sourceAmberCheckBox.Checked)
            {
                passengerModifier += 1;
            }
            if (destinationAmberCheckBox.Checked)
            {
                passengerModifier += 1;
            }
            if (sourceRedCheckBox.Checked)
            {
                passengerModifier += -4;
            }
            if (destinationRedCheckBox.Checked)
            {
                passengerModifier += -4;
            }
            for (int i = Convert.ToInt32(parsecNum.Value); i > 1; i--)
            {
                passengerModifier += -1;
            }
            return passengerModifier;
        }

        private int HighPPT(int parsecs)
        {
            switch (parsecs)
            {
                case 1: return 9000;
                case 2: return 14000;
                case 3: return 21000;
                case 4: return 34000;
                case 5: return 60000;
                case int i when i >= 6: return 210000;
            }
            return 0;
        }

        private int MiddlePPT(int parsecs)
        {
            switch (parsecs)
            {
                case 1: return 6500;
                case 2: return 10000;
                case 3: return 14000;
                case 4: return 23000;
                case 5: return 40000;
                case int i when i >= 6: return 130000;
            }
            return 0;
        }

        private int BasicPPT(int parsecs)
        {
            switch (parsecs)
            {
                case 1: return 2000;
                case 2: return 3000;
                case 3: return 5000;
                case 4: return 8000;
                case 5: return 14000;
                case int i when i >= 6: return 55000;
            }
            return 0;
        }

        private int LowPPT(int parsecs)
        {
            switch (parsecs)
            {
                case 1: return 700;
                case 2: return 1300;
                case 3: return 2200;
                case 4: return 3900;
                case 5: return 7200;
                case int i when i >= 6: return 27000;
            }
            return 0;
        }

        private int PassengerTable(int roll)
        {
            switch (roll)
            {
                case int i when i <= 1: return 0;
                case int i when i >= 2 && i <= 3: return 1;
                case int i when i >= 4 && i <= 6: return 2;
                case int i when i >= 7 && i <= 10: return 3;
                case int i when i >= 11 && i <= 13: return 4;
                case int i when i >= 14 && i <= 15: return 5;
                case 16: return 6;
                case 17: return 7;
                case 18: return 8;
                case 19: return 9;
                case int i when i >= 20: return 10;
            }
            return 0;
        }

        private void HighPassage(int rollnum, int ppt, Random roll)
        {
            int passnum = 0;
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll);
                passnum += wr;
            }
            highPassageResultLabel.Text = passnum.ToString();
            highPayResultLabel.Text = ppt.ToString("#,##0");
        }

        private void MiddlePassage(int rollnum, int ppt, Random roll)
        {
            int passnum = 0;
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll);
                passnum += wr;
            }
            middlePassageResultLabel.Text = passnum.ToString();
            middlePayResultLabel.Text = ppt.ToString("#,##0");
        }

        private void BasicPassage(int rollnum, int ppt, Random roll)
        {
            int passnum = 0;
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll);
                passnum += wr;
            }
            basicPassageResultLabel.Text = passnum.ToString();
            basicPayResultLabel.Text = ppt.ToString("#,##0");
        }

        private void LowPassage(int rollnum, int ppt, Random roll)
        {
            int passnum = 0;
            for (int i = 0; i < rollnum; i++)
            {
                int wr = Roll1(roll);
                passnum += wr;
            }
            lowPassageResultLabel.Text = passnum.ToString();
            lowPayResultLabel.Text = ppt.ToString("#,##0");
        }

        private bool AllFilled()
        {
            bool allFilled = false;
            if (sourceTechBox.SelectedItem != null &&
            destinationStarportBox.SelectedItem != null &&
            destinationTechBox.SelectedItem != null &&
            destinationPopBox.SelectedItem != null &&
            sourceStarportBox.SelectedItem != null &&
            sourcePopBox.SelectedItem != null)
            {
                allFilled = true;
            }
            return allFilled;
        }

        private void ErrorCatch() 
        {
            MessageBox.Show("One or more fields is empty!");
        }
    }
}
