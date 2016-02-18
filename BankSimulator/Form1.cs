using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSimulator {
    public partial class Form1 : Form {

        ADODB.Connection Cn;
        ADODB.Recordset RecSetUser;
        ADODB.Recordset RecSetAccount;
        ADODB.Recordset RecSetTranscript;
        private String clientId;
        private String passWord;

        private enum AccountType : byte {
            Checking = 1, Saving, Visa
        }

        private enum TransactionType : byte {
            Withdraw = 1, Deposit, Transfer
        }

        public Form1() {
            InitializeComponent();
            UserInitializeTaks();
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void loginBtn_Click(object sender, EventArgs e) {
            if (doLogin(loginIdTxt.Text, loginPwdTxt.Text)) {

                //groupBox1.Visible = false;
                //groupBox2.Visible = false;
                //groupBox3.Visible = false;
                logoutBtn.Visible = true;

                //login succeeded
                //Tab Control
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.TabPages.Add(tabPage3);
                tabControl1.TabPages.Add(tabPage4);

                //MessageBox.Show("Success login");

                editInfomationTab();
                pwdChangeBtn.Enabled = false;

                editTransactionTab();

                editHistoryTab();

            } else {
                //login failed
                MessageBox.Show("Fails login");
            }
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e) {
            pwdChangeBtn.Enabled = true;
        }

        private void pwdChangeBtn_Click(object sender, EventArgs e) {
            RecSetUser.Fields["password"].Value = pwdTxt.Text;
            RecSetUser.Update();
            if (pwdTxt.Text == RecSetUser.Fields["password"].Value.ToString()) {
                MessageBox.Show("Passwrod changnig succeeded!");
                pwdChangeBtn.Enabled = false;
            } else {
                MessageBox.Show("Passwrod changnig failed!Try again!");
            }


        }

        private void withCombo_SelectedIndexChanged(object sender, EventArgs e) {
            RecSetAccount.MoveFirst();
            while (!RecSetAccount.EOF) {
                String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                if (withCombo.Text == acountTypeString) {
                    withBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();
                }
                RecSetAccount.MoveNext();
            }

        }

        private void depCombo_SelectedIndexChanged(object sender, EventArgs e) {
            RecSetAccount.MoveFirst();
            while (!RecSetAccount.EOF) {
                String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                if (depCombo.Text == acountTypeString) {
                    depBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();
                }
                RecSetAccount.MoveNext();
            }
        }

        private void transFromCombo_SelectedIndexChanged(object sender, EventArgs e) {
            RecSetAccount.MoveFirst();
            while (!RecSetAccount.EOF) {
                String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                if (transFromCombo.Text == acountTypeString) {
                    transFromBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();
                }
                RecSetAccount.MoveNext();
            }
        }

        private void transToCombo_SelectedIndexChanged(object sender, EventArgs e) {
            RecSetAccount.MoveFirst();
            while (!RecSetAccount.EOF) {
                String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                if (transToCombo.Text == acountTypeString) {
                    transToBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();
                }
                RecSetAccount.MoveNext();
            }
        }

        private void withComfirmBtn_Click(object sender, EventArgs e) {
            if (withAmountTxt.Text != "" && withAmountTxt.Text != "0") {
                RecSetTranscript = new ADODB.Recordset();
                String Sqlstr = "select * from Transcript";
                RecSetTranscript.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                RecSetAccount.MoveFirst();
                while (!RecSetAccount.EOF) {
                    String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                    if (withCombo.Text == acountTypeString) {
                        int balance = Int32.Parse(RecSetAccount.Fields["Balance"].Value.ToString()) - Int32.Parse(withAmountTxt.Text);
                        RecSetAccount.Fields["Balance"].Value = balance.ToString();
                        RecSetUser.Update();
                        MessageBox.Show("Withdraw succeeded!");
                        withBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();

                        String branch = RecSetAccount.Fields["branch_number"].Value.ToString();
                        String amount = withAmountTxt.Text;
                        withAmountTxt.Text = "";

                        RecSetTranscript.AddNew();
                        saveTranscript(branch, (int)TransactionType.Withdraw, amount);
                        RecSetTranscript.Update();
                        MessageBox.Show("Record saved succesfully!");
                    }
                    RecSetAccount.MoveNext();
                }

            } else {
                MessageBox.Show("Type withdraw amount!");
            }
        }

        private void depConfirmBtn_Click(object sender, EventArgs e) {
            if (depAmountTxt.Text != "" && depAmountTxt.Text != "0") {
                RecSetTranscript = new ADODB.Recordset();
                String Sqlstr = "select * from Transcript";
                RecSetTranscript.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                RecSetAccount.MoveFirst();

                while (!RecSetAccount.EOF) {
                    String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                    if (depCombo.Text == acountTypeString) {
                        int balance = Int32.Parse(RecSetAccount.Fields["Balance"].Value.ToString()) + Int32.Parse(depAmountTxt.Text);
                        RecSetAccount.Fields["Balance"].Value = balance.ToString();
                        RecSetUser.Update();
                        MessageBox.Show("Deposit succeeded!");
                        depBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();

                        String branch = RecSetAccount.Fields["branch_number"].Value.ToString();
                        String amount = depAmountTxt.Text;
                        depAmountTxt.Text = "";

                        RecSetTranscript.AddNew();
                        saveTranscript(branch, (int)TransactionType.Deposit, amount);
                        RecSetTranscript.Update();
                        MessageBox.Show("Record saved succesfully!");
                    }
                    RecSetAccount.MoveNext();
                }

            } else {
                MessageBox.Show("Type deposit amount!");
            }
        }

        private void transConfirmBtn_Click(object sender, EventArgs e) {
            if (transAmountTxt.Text != "" && transAmountTxt.Text != "0") {
                if (transFromCombo.Text != transToCombo.Text) {
                    RecSetTranscript = new ADODB.Recordset();

                    String Sqlstr = "select * from Transcript";
                    RecSetTranscript.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    RecSetAccount.MoveFirst();
                    //From
                    while (!RecSetAccount.EOF) {
                        String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());     
                        if (transFromCombo.Text == acountTypeString) {
                            int balance = Int32.Parse(RecSetAccount.Fields["Balance"].Value.ToString()) - Int32.Parse(transAmountTxt.Text);
                            RecSetAccount.Fields["Balance"].Value = balance.ToString();
                            RecSetUser.Update();
                            MessageBox.Show("Trasfer From succeeded!");
                            transFromBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();

                            String branch = RecSetAccount.Fields["branch_number"].Value.ToString();
                            String amount = transAmountTxt.Text;
                            
                            RecSetTranscript.AddNew();
                            saveTranscript(branch, (int)TransactionType.Transfer, amount);
                            RecSetTranscript.Update();
                            MessageBox.Show("Record saved succesfully!");
                        }
                        RecSetAccount.MoveNext();
                    }
                    //To
                    RecSetAccount.MoveFirst();
                    while (!RecSetAccount.EOF) {
                        String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                        //To
                        if (transToCombo.Text == acountTypeString) {
                            int balance = Int32.Parse(RecSetAccount.Fields["Balance"].Value.ToString()) + Int32.Parse(transAmountTxt.Text);
                            RecSetAccount.Fields["Balance"].Value = balance.ToString();
                            RecSetUser.Update();
                            MessageBox.Show("Transfer To succeeded!");
                            transToBalanceLbl.Text = RecSetAccount.Fields["Balance"].Value.ToString();
                            transAmountTxt.Text = "";
                        }
                        RecSetAccount.MoveNext();
                    }

                } else {
                    MessageBox.Show("You need to change acount!It's same.");
                }
            } else {
                MessageBox.Show("Type transfer amount!");
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e) {
            editHistoryTab();
        }

        private void logoutBtn_Click(object sender, EventArgs e) {
            tabControl1.TabPages.Add(tabPage1);
            loginIdTxt.Text = "";
            loginPwdTxt.Text = "";
            logoutBtn.Visible = false;
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
        }

        //------------------------------------------------------------------------------------------


        private void UserInitializeTaks() {
            //Disable LogoutBtn
            logoutBtn.Visible = false;

            //Disable Tabs
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);

            //Creating Objects so I can use them 
            Cn = new ADODB.Connection();
            
            //setting up objects
            Cn.Provider = "Microsoft.Jet.Oledb.4.0";
            Cn.ConnectionString = "\\\\Mac\\Home\\Documents\\Visual Studio 2015\\Projects\\BankSimulator\\Database1.mdb";
            Cn.Open();

        }

        private bool doLogin(String id, String pwd) {

            RecSetUser = new ADODB.Recordset();
            String Sqlstr = "select * from [User] where client_id = " + id + ";";
            RecSetUser.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            if (RecSetUser.EOF == false) {
                RecSetUser.MoveFirst();
                clientId = RecSetUser.Fields["client_id"].Value.ToString();
                passWord = RecSetUser.Fields["password"].Value.ToString();
                if (passWord == pwd) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        private void editInfomationTab() {
            RecSetAccount = new ADODB.Recordset();
            clientIdLbl.Text = clientId.ToString();
            pwdTxt.Text = passWord;
            String Sqlstr = "select * from Account where client_id = " + clientId + ";";
            RecSetAccount.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            if (RecSetAccount.EOF == false) {
                RecSetAccount.MoveFirst();
                Control[] cs;
                int i = 1;
                while (!RecSetAccount.EOF) {
                    //GroupBox
                    //cs = this.Controls.Find("groupBox" + i.ToString(), true);
                    //if (0 < cs.Length) {
                    //    ((GroupBox)cs[0]).Visible = true;
                    //}
                    //AccountNum
                    cs = this.Controls.Find("accountNumLbl" + i.ToString(), true);
                    if (0 < cs.Length) {
                        ((Label)cs[0]).Text = RecSetAccount.Fields["account_number"].Value.ToString();
                    }
                    //AccountName
                    cs = this.Controls.Find("accountNameLbl" + i.ToString(), true);
                    if (0 < cs.Length) {
                        String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                        ((Label)cs[0]).Text = acountTypeString;
                    }
                    //Branch Number
                    cs = this.Controls.Find("branchNumLbl" + i.ToString(), true);
                    if (0 < cs.Length) {
                        ((Label)cs[0]).Text = RecSetAccount.Fields["branch_number"].Value.ToString();
                    }
                    //Balance
                    cs = this.Controls.Find("balanceLbl" + i.ToString(), true);
                    if (0 < cs.Length) {
                        ((Label)cs[0]).Text = RecSetAccount.Fields["Balance"].Value.ToString();
                    }
                    //Credit Limit
                    cs = this.Controls.Find("creditLimitLbl" + i.ToString(), true);
                    if (0 < cs.Length) {
                        ((Label)cs[0]).Text = RecSetAccount.Fields["credit_limit"].Value.ToString();
                    }
                    RecSetAccount.MoveNext();
                    i++;
                }
            } else {

            }
        }

        private void editTransactionTab() {
            //withdraw account
            RecSetAccount.MoveFirst();
            while (!RecSetAccount.EOF) {
                String acountTypeString = convertAccountNumToType(RecSetAccount.Fields["account_type"].Value.ToString());
                withCombo.Items.Add(acountTypeString);
                depCombo.Items.Add(acountTypeString);
                transFromCombo.Items.Add(acountTypeString);
                transToCombo.Items.Add(acountTypeString);

                RecSetAccount.MoveNext();
            }
        }

        private String convertAccountNumToType(String accountNum) {
            int dbValue = Int32.Parse(accountNum);
            return ((AccountType)dbValue).ToString();
        }

        private String convertTransactionNumToType(String transactionNum) {
            int dbValue = Int32.Parse(transactionNum);
            return ((TransactionType)dbValue).ToString();
        }

        private void saveTranscript(String branch, int type, String amount) {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.Month + "/");
            Console.WriteLine(dt.Day + "/");
            Console.WriteLine(dt.Year);

            DateTime time = DateTime.Now;
            Console.WriteLine(dt.Hour + ":");
            Console.WriteLine(dt.Minute + ":");
            Console.WriteLine(dt.Second);

            RecSetTranscript.Fields["client_id"].Value = clientId.ToString();
            RecSetTranscript.Fields["Date"].Value = dt;
            RecSetTranscript.Fields["Time"].Value = time;
            RecSetTranscript.Fields["branch_number"].Value = branch;
            RecSetTranscript.Fields["transaction_type"].Value = type;
            RecSetTranscript.Fields["Amount"].Value = Int32.Parse(amount);
        }

        private int getNumberFromAccountType(String type) {
            if (type == AccountType.Checking.ToString()) {
                return (int)AccountType.Checking;
            } else if (type == AccountType.Saving.ToString()) {
                return (int)AccountType.Saving; ;
            } else if (type == AccountType.Visa.ToString()) {
                return (int)AccountType.Visa; ;
            } else {
                //just in case
                return 0;
            }

        }

        private void editHistoryTab() {
            this.dataGridView1.Rows.Clear();
            RecSetTranscript = new ADODB.Recordset();
            String Sqlstr = "select * from Transcript where client_id = " + clientId.ToString();
            RecSetTranscript.Open(Sqlstr, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            RecSetTranscript.MoveLast();
            while (!RecSetTranscript.BOF) {
                String client = RecSetTranscript.Fields["client_id"].Value.ToString();
                String date = RecSetTranscript.Fields["Date"].Value.ToShortDateString();
                String time = RecSetTranscript.Fields["Time"].Value.ToLongTimeString();
                String branch = RecSetTranscript.Fields["branch_number"].Value.ToString();
                String transaction_type = RecSetTranscript.Fields["transaction_type"].Value.ToString();
                String amount = RecSetTranscript.Fields["Amount"].Value.ToString();
                this.dataGridView1.Rows.Add(date, time, convertTransactionNumToType(transaction_type), amount, branch);
                //RecSetTranscript.MoveNext();
                RecSetTranscript.MovePrevious();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'database1DataSet.Transcript' table. You can move, or remove it, as needed.
            this.transcriptTableAdapter.Fill(this.database1DataSet.Transcript);

        }

       
    }
}
