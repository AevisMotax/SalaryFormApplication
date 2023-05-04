using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //Using files, editing\reading files.

namespace SalaryFormApplication
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double TotalHours = 0;
            double HourlyRate = 0;
            double nEarnings = 0;

            // Allow user to input
            if (HoursWorked.Text.Length == 0 || Dollars.Text.Length == 0)
            {
                MessageBox.Show("Please input data in the Hours Worked and Hourly Rate box.");

                return; 
            }
           
            TotalHours = Convert.ToDouble(HoursWorked.Text);
            HourlyRate = Convert.ToDouble(Dollars.Text);

            // Calculated Pay Slip
            nEarnings = HourlyRate * TotalHours;
            string sT = longname.Text;
            Results.Text = string.Format("{0} salary is ", sT) + nEarnings.ToString() + "$.";
            string Answers=string.Format("{0}'s calculated salary is ", sT)+ nEarnings.ToString() + "$.";
            AddOneLine(Answers);
            //Results.Text = nEarnings.ToString();

            ///string Sstring1 = FullName.Text;
            //string Sstring2 = "{0} salary is {2}. ", ;

            // Display the number of a certain letter from EditBox List.           
            /*int iA = 0;
            string sA = textShow.Text;
            
            foreach (char a in sA)
            {
                if (a == 'a')
                {
                    iA++;
                }
            }
            int A = iA;   
            
            // What we will get in EditBox after clicking the Button           
            string sA2=string.Format("The letter a has been repeated ")+ A.ToString() + "times";
            MessageBox.Show(sA2); */


        }

        private void HoursWorked_LostFocus(object sender, EventArgs e)
        {

        }

        private void HoursWorked_TextChanged(object sender, EventArgs e)
        {
            string sToValid = HoursWorked.Text;
            bool bValid = true;
            string sBadCharacter = ""; 
            
            // only numeric characters allowed in the boxes "Hours Worked" and "Hourly rate"
            bValid = IsStringValid(sToValid);
            
            if (bValid ==false)
            {
                MessageBox.Show("You have input an invalid character. Please enter only a Number!");

                String sNew = sToValid;
                int nLength2 = sNew.Length;

                sNew = sNew.Substring(0, nLength2-1);

                HoursWorked.Text = sNew; // Important

                // This will tell the user that he inputed a wrong character in the boxes where only numbers are allowed.
                string slastOne = "";
                slastOne = string.Format(":  {0}.", sToValid[nLength2-1]);
                sBadCharacter=string.Format("{0} entered a wrong character",longname.Text) + slastOne;
                AddOneLine(sBadCharacter);

                

            }
        }


        public bool IsStringValid(string sToValid)
        {
            bool bRet = true;

            char chArc = ' ';
            int  nLength = sToValid.Length;

            for (int i = 0; i < nLength; i++)
            {
                 switch (chArc=sToValid[i])                     //chArc = sToValid[i];

                 {
                     case '0':

                         break;
                     case '1':

                         break;
                     case '2':

                         break;
                     case '3':
                         
                         break;
                     case '4':

                         break;
                     case '5':

                         break;
                     case '6':

                         break;
                     case '7':

                         break;
                     case '8':

                         break;
                     case '9':

                         break;

                     case '.':
                        
                         break;
                     default:
                        bRet=false;
                         break;

                 }
                     
                     
                     
                     /*
                if (chArc == '0')
                {
                    bRet = true;
                }
                else if (chArc == '1')
                {
                    bRet = true;
                }
                else if (chArc == '2')
                {
                    bRet = true;
                }
                else if (chArc == '3')
                {
                    bRet = true;
                }
                else if (chArc == '4')
                {
                    bRet = true;
                }
                else if (chArc == '5')
                {
                    bRet = true;
                }
                else if (chArc == '6')
                {
                    bRet = true;
                }
                else if (chArc == '7')
                {
                    bRet = true;
                }
                else if (chArc == '8')
                {
                    bRet = true;
                }
                else if (chArc == '9')
                {
                    bRet = true;
                }
                else if (chArc == '.')
                {
                    bRet = true;
                }
                else
                {
                    bRet = false;
                } */
            } 


            return bRet;
        }

        private void Dollars_TextChanged(object sender, EventArgs e)
        {
            string sToValid = Dollars.Text;
            int nLength3 = sToValid.Length;            
            bool bValid=true;

            bValid = IsStringValid(sToValid);
            
                       
            if (bValid == false)
            {
                MessageBox.Show("CHARACTER NOT RECOGNIZED, ONLY NUMBERS AVAILABLE");
                string sNew="0";
                int nLength4=sToValid.Length;

                sNew = sToValid.Substring(0, nLength4-1); //NEVER USE "nlength4--" just use "-1".

                Dollars.Text = sNew;
                string sBadCharacter = "";

                string slastOne = "";
                slastOne = string.Format(":  {0}.", sToValid[nLength4 - 1]);
                sBadCharacter = string.Format("{0} entered a wrong character", longname.Text) + slastOne;
                AddOneLine(sBadCharacter);
            }
            


           
        }

        private void ListRecord1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddOneLine(String sNewLine)
        {
          // This function represents the time done by things
            String sCurrentDate = DateTime.Now.ToString();

            String sToUpdate = sCurrentDate + ":  " + sNewLine + "\r\n";
           
           // t.Text += sToUpdate;
            textShow.Text += sToUpdate;
            //;
            //textShow.Cursor = textShow.Text.Length;
            //ListRecord1.;
             
        }

        private void textShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* string sMyStr = "ABCD"; //

            // The first Character in this string will be
            char ch1 =  sMyStr[0];                            valuable information
            // The second Character in this string will be
            char ch2 =  sMyStr[1];
            // The 4th Character in this string will be
            char ch4 =  sMyStr[3]; */

            

            int iA = 0;
            string sA = textShow.Text.ToUpper(); // <<<< RE-ASSIGN BACK.
           // textShow.Text = textShow.Text.ToUpper();
           // textShow.Text = sA;

            if (CharacterBox.Text.Length != 0)
            {
                foreach (char a in sA)
                {
                    if (a == CharacterBox.Text.ToUpper()[0])
                    {
                        iA++;
                    }
                }
                int A = iA;

                // What we will get in EditBox after clicking the Button           
                string sA2 = string.Format("This character has been repeated ") + A.ToString() + " times";
                MessageBox.Show(sA2);
            }
            if (CharacterBox.Text.Length == 0)
            {
                MessageBox.Show("please input a character in the corresponding box.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Define a button to remove all events in EditBox "What Happened"
            // string Clear = textShow.Text;
            textShow.Text = "";
        }

        private void CharacterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostChar_Click(object sender, EventArgs e)
        {
            const int ARRAY_SIZE = 40;
           int [] nCharacter = new int[ARRAY_SIZE];
           // const int ARRAY_SIZE = 256;
          //  int[] nCharacter = new int[ARRAY_SIZE];

           for (int Index = 0; Index < ARRAY_SIZE; Index++)
           {
               nCharacter[Index] = 0;

           }
            /*
            nCharacter[0] = 0;// save appearance of 'A', intially put 0,  no appearance <<IMPORTANT
            nCharacter[1] = 0;
            nCharacter[2] = 0;
            nCharacter[3] = 0; //save appearance of 'D', initially put 0, no appearance 
            nCharacter[4] = 0;
            nCharacter[5] = 0;
            nCharacter[6] = 0;
            nCharacter[7] = 0;
            nCharacter[8] = 0;
            nCharacter[9] = 0;
            nCharacter[10] = 0;
            nCharacter[11] = 0;
            nCharacter[12] = 0;
            nCharacter[13] = 0; // << nCharacter[13]='N' <<  Index value, not array
            nCharacter[14] = 0;
            nCharacter[15] = 0;
            nCharacter[16] = 0;
            nCharacter[17] = 0;
            nCharacter[18] = 0;
            nCharacter[19] = 0;
            nCharacter[20] = 0;
            nCharacter[21] = 0;
            nCharacter[22] = 0;
            nCharacter[23] = 0; //save appearance W, initially put 0, no appearance
            nCharacter[24] = 0;
            nCharacter[25] = 0;
            nCharacter[26] = 0;  // '0';
            nCharacter[27] = 0;// '1';
            nCharacter[28] = 0;// '2';
            nCharacter[29] = 0;// '3';
            nCharacter[30] = 0;// '4';
            nCharacter[31] = 0;// '5';
            nCharacter[32] = 0;// '6';
            nCharacter[33] = 0;// '7';
            nCharacter[34] = 0;// '8';
            nCharacter[35] = 0;// '9';
            nCharacter[36] = 0;// '.';
            nCharacter[37] = 0;// '/';
            nCharacter[38] = 0;// ':';
            nCharacter[39] = 0; // '
             * */

            string sNew = textShow.Text.ToUpper();
            sNew = sNew.Replace(" ", string.Empty); //<<< IMPORTANT IF WE DO NOT COUNT SPACE

            if (sNew.Length != 0) //<< NOT WHILE BECAUSE IT WILL ENDLESSLY CONTINUE (DEAD LOOP) FOREVER.
            {

                for (int i = 0; i < sNew.Length; i++)
                {

                    if (sNew[i] >= 'A' && sNew[i] <= 'Z')
                    {
                        nCharacter[sNew[i] - 'A']++;
                    }

                    else if (sNew[i] >= '0' && sNew[i] <= '9')
                    {
                        nCharacter[26 + sNew[i] - '0']++;
                    }
                    else if (sNew[i] == '.')
                    {
                        nCharacter[36]++;
                    }
                    else if (sNew[i] == '/')
                    {
                        nCharacter[37]++;
                    }
                    else if (sNew[i] == ':')
                    {
                        nCharacter[38]++;
                    }

                    /*  switch (sNew[i])
                      {
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'C':
                              nCharacter[0]++;
                              break;
                          case 'D':
                              nCharacter[1]++;
                              break;
                          case 'E':
                              nCharacter[0]++;
                              break;
                          case 'F':
                              nCharacter[1]++;
                              break;
                          case 'G':
                              nCharacter[0]++;
                              break;
                          case 'H':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                          case 'A':
                              nCharacter[0]++;
                              break;
                          case 'B':
                              nCharacter[1]++;
                              break;
                     } */




                    //  nCharacter[sNew[i]]++;  //<<< [sNew[i]] gives a value. Then, that value is considered by nCharacter and it inputs that value in the corresponding 'array" that the vallue is located."
                }
                //make new variables for maxValue nad the most reoccuring character
                int maxValue = 0;
                int maxIndex = 0;
                char chAll = ' ';

                //find index of arry which holds  the Max chacrter
                for (int i = 0; i < ARRAY_SIZE; i++)
                {

                    if (nCharacter[i] > maxValue)
                    {
                        maxValue = nCharacter[i];
                        maxIndex = i;
                    }

                }

                // translate to the character which shows up maxmum
                if (maxIndex >= 0 && maxIndex <= 25)
                {
                    chAll = (char)((int)'A' + maxIndex);
                }
                else if (maxIndex >= 26 && maxIndex <= 35)
                {
                    chAll = (char)((int)'0' + maxIndex - 26);
                }
                else if (maxIndex == 36)
                {
                    chAll = '.';
                }
                else if (maxIndex == 37)
                {
                    chAll = '/';
                }
                else if (maxIndex == 38)
                {
                    chAll = ':';
                }
                /*   switch (maxIndex)
                {
                } */

                MessageBox.Show("The character that reoccurs the most is " + chAll + "\n as it appears " + maxValue + "times.");
            }

            if (sNew.Length == 0)
            {
                MessageBox.Show("NOTHING IS ON THE SCREEN");
            }

           // char chAll = '\0';




            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sNew = textShow.Text.ToUpper();
            sNew = sNew.Replace(" ", string.Empty);
            //const int ARRAY_SIZE = 40;
            const int ARRAY_SIZE = 5;
            int[] nAll = new int[ARRAY_SIZE];
            int ValueNum = 0;
            int ValueLetters = 0;
            int ValueOthers = 0;
           /* char a = 'A';
            char z = 'Z';
            char chZero = '0';
            char chNine = '9'; */

            // Define all elements with zero as their initial value.
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                nAll[i] = 0;
            }

            // Define each boxes with their own value. 
            if (sNew.Length != 0)
            {
                for (int nI = 0; nI < sNew.Length; nI++)
                {

                    if (sNew[nI] >= 'A' && sNew[nI] <= 'Z')
                    {
                        //nAll[sNew[nI] - 'A']++;
                        ValueLetters = nAll[0]++;
                    }


                    else if (sNew[nI] >= '0' && sNew[nI] <= '9')
                    {
                       // nAll[sNew[nI] - '0' + 26]++;
                        ValueNum = nAll[1]++;
                    }

                    else if (sNew[nI] == '.' || sNew[nI] =='/' || sNew[nI] == ':')
                    {
                      ValueOthers = nAll[2]++;
                    }
                 /*   else if (sNew[nI] == '/')
                    {
                        nAll[37]++;
                    }
                    else if (sNew[nI] == ':')
                    {
                        nAll[38]++;
                    }    */                 
                }
               // int nTotal = 1;
               /* int ValueNum = 0;
                int ValueLetters = 0;
                int ValueOthers = 0; */
              /*  int maxIndex = 0;
                char chNum= ' ';
                char chLetters = ' ';
                char chOthers = ' '; */

                // Redistribute the values (nAll[snew[nI]]) to their corresponding boxes

             /*   for (int i = 0; i <=25; i++)
                {
                    ValueLetters +=nAll[i];
                }

                for (int i = 26; i <= 35; i++)
                {
                    ValueNum += nAll[i];
                }

                for (int i = 36; i <= 38; i++)
                {
                    ValueOthers += nAll[i];
                }

                /*   foreach (int i in nAll)
                {
                    if (nAll[i] >= 0 && nAll[i] <= 25)
                    {
                        ValueNum += nAll[i];
                    }

                    else if (nAll[i] >= 26 && nAll[i] <= 35)
                    {
                        ValueLetters += nAll[i];
                    }
                    else if (nAll[i] >= 36 && nAll[i] <= 38)
                    {
                        ValueOthers +=nAll[i];
                    } 
                } */


                // Translate each value to their respetive characteristics
                    MessageBox.Show("There are " + 
                        ValueNum + " numbers, " + ValueLetters + " letters and " +ValueOthers + " other characters."); 

            }

            if (sNew.Length == 0)
            {
                MessageBox.Show("NOTHING IS ON THE SCREEN");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Change label title of What Happened Box
            Record1.Text = "Initiating..."; 

            // Record # of rows in the What Happened Box.
            string sNew = textShow.Text;
           // int nLines = textShow.Lines.Count();
          // nLines -= 1; // for some reason, it starts with 2 lines. 

            char chLines = '\n'; // \n represnts a new row everytime.
            int numLines = 0;

            foreach (char a in sNew)
            {
                if (a == chLines)
                {
                    numLines++;
                }

            }
 
            if (sNew.Length != 0)
            {
                MessageBox.Show( numLines + " lines in the What Happened Box.");
            }
            if (sNew.Length == 0)
            {
                MessageBox.Show("Nothing is on the screen.");
            }


          

        }



        public bool IsLineValid() //VERY USEFUL TO SAVE TIME.
        {
            bool bReturn = true; //<< May also just say "return true";


          /*  bool bVerify = true;
            while (bVerify)
            {
                int nStart = 0;
                string sNewtextBoxNumber = TextBoxNumber.Text.ToUpper();
                nStart++;

                if (sNewtextBoxNumber[nStart] >= 'A' && sNewtextBoxNumber[nStart] <= 'Z')
                {
                    MessageBox.Show("Character non valid.");
                  //  return bVerify;                   
                }

                if (sNewtextBoxNumber[nStart] >= '0' && sNewtextBoxNumber[nStart] <= '9')
                {
                    bVerify = false;
                }
            } */

            // int iLine = int.Parse(TextBoxNumber.Text);

            if (TextBoxNumber.Text == "")
            {
                MessageBox.Show("No numbers have been inputed.");
                bReturn = false;
            }

            string sLine = TextBoxNumber.Text;
            int iLine = 0;
            Int32.TryParse(sLine, out iLine); //If the string starts with an alphanumeric character or only 
            // contains alphanumeric characters, 0 is returned.

            string sNew = textShow.Text;

            if (iLine <= 0 || iLine > textShow.Lines.Count() - 1)
            {
                MessageBox.Show("Error: Number non valid.");
                bReturn = false;
            }

            if (sNew.Length == 0)
            {
                MessageBox.Show("Error: Nothing is on the screen.");
                bReturn =  false;
                
            }


            return bReturn;


        }

        private void Get_Click(object sender, EventArgs e)
        {
            string sNew = textShow.Text;
            string[] sLines = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            if (!IsLineValid())   // <<<<< A public class always needs () at the end. + if IsLineValid already true, no need to add it.
            {
                return;
            }

          /*  string sLine = TextBoxNumber.Text;
            int iLine = 0;
            Int32.TryParse(sLine, out iLine);  */
            
            int iLine = int.Parse(TextBoxNumber.Text);
         //   int[] Lines = new int[textShow.Lines.Count()];
          //  int n = 1;
         /*   if (iLine <= 0 || iLine > textShow.Lines.Count() - 1)
            {
                MessageBox.Show("Error: Number non valid.");
                return;
            }

            if (sNew.Length == 0)
            {
                MessageBox.Show("Error: Nothing is on the screen.");
                return;
            } */



                    TextBoxContent.Text = sLines[iLine-1];
          //  for (int i = 0; i < textShow.Lines.Count(); i++)
           // {
              //  Lines[i] = n++; //<< n++ starts at the initial value.

               // if (Lines[i] == iLine)
               // {

               // }
          //  }



        }


        //_______________________________________________________________________________________

        private void Add_Click(object sender, EventArgs e)
        {

            textShow.Text += TextBoxContent.Text + "\r\n";

        }
        //_________________________________________________________________________________________

        private void Insert_Click(object sender, EventArgs e)
        {
            string sNew = textShow.Text;
            string sAdd = TextBoxContent.Text;
            string s1 = "";
            string s2 = "";
            if (!IsLineValid())
            {
                return;
            }
           //  int[] nLines = new int[textShow.Lines.Count()];
           // int n = 1;
            
             int iLine = int.Parse(TextBoxNumber.Text);
            int nPosition = 0;
            int nLine = 0; //<<<nLine =1 = on line 3, not after.

            char chAll = ' ';
            char chLookFor = '\n';
            bool bContinue = true;


            if (true)
            {
                string[] sLines = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                string sA = "";
                List<string> list = new List<string>(sLines);

                list.Insert(iLine, sAdd);
                sLines = list.ToArray();

                foreach (string s in sLines)
                {
                    sA += s;
                    sA += "\r\n";
                }
                textShow.Text = sA;
            }

            else
            {

                while (bContinue)
                {
                    chAll = sNew[nPosition++];

                    if (chAll == chLookFor)
                    {
                        nLine++;

                        if (iLine == nLine)
                        {
                            bContinue = false;
                        }
                    }
                }

                s1 = sNew.Substring(0, nPosition);
                s2 = sNew.Substring(nPosition);

                textShow.Text = s1 + sAdd + "\r\n" + s2;
            }
            /* for (int Index = 0; Index < textShow.Lines.Count(); Index++)
             {
                 nLines[Index] = n++;

                 if (nLines[Index] == iLine)
                 {
                    
                    
                     
                     
                     //textShow.Text.Replace(sLines[Index], "");
                     // textShow.Lines = textShow.Lines.Skip(i).ToArray();
                     //string clean = textShow.Text.Replace(sLines[i], "");

                 }

             } */
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sNew = textShow.Text;
            string[] sLines = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //string [] sLines =new string [textShow.Lines.Count()];


            if (!IsLineValid())   // <<<<< A public class always needs () at the end. + if IsLineValid already true, no need to add it.
            {
                return;
            }

            int iLine = int.Parse(TextBoxNumber.Text);



            if (true)
            {
                // use string [] array.
                List<string> list = new List<string>(sLines);

                list.RemoveAt(iLine -1); 

                string[] sLinesNew = list.ToArray();
                string sNew2 = "";
                foreach (string s in sLinesNew)
                {
                    if (s != "")
                    {
                        sNew2 += s;
                        sNew2 += "\r\n";
                    }

                }
                textShow.Text = sNew2;
            }
            else
            {
            // use string
                string s1 = "";
                string s2 = "";
                bool bContinue = true;
                char chTemp = ' ';
                char chLookFor = '\n';
                int nStart = 0;
                int nCurrentLine = 1; // iLine != 0 ???????????????????????????????????????????????????????????????????????????????
                // int nCurrentLine2 = 0; USELESS
                int nPosition1 = 1;
                int nPosition2 = 0;



                /* if (iLine == 1)
                 {
                     nPosition1 = 0;
                 } */

                while (bContinue)
                {
                    // Find s1:
                    chTemp = sNew[nStart++];


                    if (chTemp == chLookFor)
                    {

                        nCurrentLine++;       //<< This starts at the initial value, not immediatelly addition.       

                        if (nCurrentLine == iLine)
                        {
                            nPosition1 = nStart;
                        }
                        else if (nCurrentLine == iLine + 1) //<< The next line, so next Position \n
                        {
                            nPosition2 = nStart;
                            bContinue = false; //<< We've found the end of the line.
                        }

                    }

                    // nStart++; <<<< Show that it's a cycle.
                }

                s1 = sNew.Substring(0, nPosition1);
                s2 = sNew.Substring(nPosition2); //<<< We do not need to specify the int length if we wish to take the rest of all text.

                textShow.Text = s1 + s2;







            }

        }
        

        private void Replace_Click(object sender, EventArgs e)
        {

            if (!IsLineValid())   // <<<<< A public class always needs () at the end. + if IsLineValid already true, no need to add it.
            {
                return;
            }

            
            string sNew = textShow.Text;
            string sAdd = TextBoxContent.Text;
            string s1 = " ";
            string s2 = " ";
            int iLine = int.Parse(TextBoxNumber.Text);
            int nBeginning = 0;
            int nPosition1 = 0;
            int nPosition2 = 0;
            int nLine = 1;
           // int[] nLines = new int[textShow.Lines.Count()];
           // int n = 1;
            char chAll = ' ';
            char chLookFor = '\n';
            bool bContinue = true;

            if (true)
            {
                string[] sLines = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);

                List<string> list = new List<string>(sLines);

                list.RemoveAt(iLine-1);
                list.Insert(iLine-1, sAdd);

                sLines = list.ToArray();
                string sA = "";

                foreach (string s in sLines) //<<< If you use list, it adds an  element after the last line.
                {
                    sA += s;
                    sA += "\r\n";
                }

                textShow.Text = sA;
            }
            else
            {

                while (bContinue)
                {
                    chAll = sNew[nBeginning++];

                    if (chAll == chLookFor)
                    {
                        nLine++;

                        if (iLine == nLine)
                        {
                            nPosition1 = nBeginning;
                            //  bContinue = false; << Or else, it will exit the loop

                        }

                        if (iLine + 1 == nLine)
                        {

                            bContinue = false;
                            nPosition2 = nBeginning;
                        }
                    }

                }

                s1 = sNew.Substring(0, nPosition1);
                s2 = sNew.Substring(nPosition2);
                textShow.Text = s1 + sAdd + "\r\n" + s2;
            }

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            string[] sLines = textShow.Text.Split( new string [] {"\r\n"} , StringSplitOptions.None);

            List<string> list = new List<string>(sLines);

            list.Sort();  //<< Puts the elements in textshow.Text in alphabetical order.
            string sA = "";
            foreach (string s in list)
            {
                sA += s;
                sA += "\r\n";
            }
            textShow.Text = sA.ToUpper();
        }

        private void SearchString_Click(object sender, EventArgs e)
        {
            string sNew = textShow.Text.ToUpper();
            string sSearch = TextBoxContent.Text.ToUpper();
            int nStart = 0;
            int nObtained = 0;
            int iLine = 1; //Also, the row.
            int nColumn = 1; //Also, the column
            int nLast = 0; 
            char chAll = ' ';
            char chLookFor = '\n';
            bool bContinue = true;
           // string[] sLines = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);


           nObtained = sNew.IndexOf(sSearch); //IndexOf Allows user to find the first Index (integer) of the specified string.

           if (nObtained == -1)
           {
               MessageBox.Show("Not found.");
               return;
           }


            while (bContinue)
            {
                chAll = sNew[nStart++];

                if (chAll == chLookFor)
                {
                    iLine++;
                    nLast =nStart; //To find the Index of the previous \n.
                }

                if (nObtained == nStart) //Integer == integer ALWAYS, lol ++ 
                    // if this function was inside the chAll == chLookFor,nStart will never land, since its only ionterested in \n.
                {
                    bContinue = false;
                }
            }


            nColumn = (nObtained - nLast)+1;
          /*  for (int i = 0; i < nObtained; i++)  FOR LOOP WAY BETTER THAN WHILE. 
            {
                chAll = sNew[nStart++];

                if (chAll == chLookFor)
                {
                    iLine++;
                    nlast = nStart
                }
            } */

            string sA = String.Format("The first occurence of {0} is on row {1} and on column {2}.", sSearch, iLine, nColumn);
            MessageBox.Show(sA);
          //  MessageBox.Show("The first occurence of {0} is on row ",sSearch + iLine + "and on column " + nObtained +".");
            // {0}, Name ====== ALWAYS ON STRING.FORMAT != MESSAGEBOX.


            
        }




        public bool DoSave() // DoSave == beast for file necessities. Meanwhile, other titles would be weird and incoherent.  
        {
            bool bReturn = true; //In this scheme, it can also be a void, since we do not return a value.


            SaveFileDialog dlgSaved = new SaveFileDialog();

            dlgSaved.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            dlgSaved.RestoreDirectory = true;

            //  dlgSaved.InitialDirectory = "C:\work\C#" (Example);

            if (dlgSaved.ShowDialog() == DialogResult.OK) // Either OK or cancel. OK means user wants to save.
            {
                string Filename = dlgSaved.FileName;
                string[] sData = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                int nlastLines = 0;
                StreamWriter swFile = new StreamWriter(Filename);

                foreach (string s in sData)
                {
                    nlastLines++;

                    if (s != "" || sData.Length != nlastLines)
                    {
                        swFile.WriteLine(s); //It will save each "line" (WriteLine) on the new file
                    }
                }
                swFile.Close(); //CLose means that it's finished/ We need it if we want to add text on a file.


                //____________________________________________________________________________________________________
                TextSave.Text = Filename; // Fengming wanta to put the Filename in the editBox
            }

            return bReturn;  //Always return value. ALWAYS
            // No need for a return false value because we only want this to execute this.

        }


        private void Save_Click(object sender, EventArgs e)
        {

            DoSave();
            /* SaveFileDialog dlgSaved = new SaveFileDialog();

            dlgSaved.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            dlgSaved.RestoreDirectory = true;

            //  dlgSaved.InitialDirectory = "C:\work\C#" (Example);

            if (dlgSaved.ShowDialog() == DialogResult.OK) // Either OK or cancel. OK means user wants to save.
            {
                string Filename = dlgSaved.FileName;
                string [] sData = textShow.Text.Split( new string[] {"\r\n"}, StringSplitOptions.None       );

                StreamWriter swFile = new StreamWriter(Filename);

                foreach (string s in sData)
                {
                    swFile.WriteLine(s); //It will save each "line" (WriteLine) on the new file
                }
                swFile.Close(); //CLose means that it's finished/ We need it if we want to add text on a file.


            } */

        }

        public void DoOpen()
        {
            //bool bReturn = true;
            string sA = "";
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            opfile.RestoreDirectory = true;
            //  opfile.InitialDirectory = "C:\work\C#"; (Example)

            if (opfile.ShowDialog() == DialogResult.OK)
            {
                string Filename = opfile.FileName;
                //string Filename2 = opfile.OpenFile();
                //  var FileOpen = opfile.OpenFile(); <<< THIS ALSO WORKS

                StreamReader srFile = new StreamReader(Filename); // FROM STATEMENT ABOVE, USE FileOpen
                sA = srFile.ReadToEnd();
                TextSave.Text = Filename;
                srFile.Close();
            }

            if (AppendFile.Checked == true) // Much simpler
            {
                textShow.Text += sA;
            }
            else
            {
                textShow.Text = sA;
            }
            textShow.Focus();

        }


        private void Open_Click(object sender, EventArgs e)
        {

            DoOpen();
            /*  string sA = "";
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            opfile.RestoreDirectory = true; 
          //  opfile.InitialDirectory = "C:\work\C#"; (Example)

            if (opfile.ShowDialog() == DialogResult.OK)
            {                
                string Filename = opfile.FileName;
                //string Filename2 = opfile.OpenFile();
              //  var FileOpen = opfile.OpenFile(); <<< THIS ALSO WORKS

                StreamReader srFile = new StreamReader(Filename); // FROM STATEMENT ABOVE, USE FileOpen
                sA = srFile.ReadToEnd();
            }

            textShow.Text = sA; */
        }




        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No or yes?", "oh", MessageBoxButtons.YesNo);
           // MessageBox.Show(title, text, messageboxbuttons.yes / no);
        }

        private void TextSave_TextChanged(object sender, EventArgs e)
        {
            // If put read-only =true, then the line box becomes gray, so its encrypted. 
        }

        private void Save2_Click(object sender, EventArgs e)
        {

            string sFile = TextSave.Text; //sFile >> sInfo(More accurate)

            if (sFile.Length == 0)
            {
               // return Save_Click;
                DoSave();
            }
            else
            {
                
                //StreamWriter swFile = new StreamWriter(sFile);
                string[] sData = textShow.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                int nLines = 0;
                StreamWriter swFile = new StreamWriter(sFile); //sFile is the string name, no need for savefiledialog.

                foreach (string s in sData)
                {
                    nLines++;

                    if (s != "" || sData.Length != nLines)
                    {
                        swFile.WriteLine(s); //It will save each "line" (WriteLine) on the new file
                    }
                }
                swFile.Close(); //CLose means that it's finished/ We need it if we want to add text on a file.
            }




        }

        private void OpenFrom2_Click_1(object sender, EventArgs e)
        {

            string sFile = TextSave.Text;

            if (sFile.Length == 0)
            {
                DoOpen();
            }
            else
            {
                StreamReader srFile = new StreamReader(sFile);

              /*  do
                {
                    textShow.Text = srFile.ReadToEnd();

                    if (srFile.ReadLine() == "")
                    {
                        continue;
                    }

                    if (srFile.ReadLine() == null)
                    {
                        return;
                    }
                } while (srFile.ReadLine() != ""); */
                string sB = "";
                sB = srFile.ReadToEnd(); //textSHow must be change to crush the old version. or else, we're going in cirxcles.


                // Never use a variable to be used by another variable. For example, textshow.text = srFile.ReadToEnd(); From experience, it isn't pretty.



                 string[] sLines = sB.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                 int nLines = 0;

                 string sA = "";
                 foreach (string s in sLines)
                 {
                     nLines++;

                     if (nLines != sLines.Length || s != "") // To avoid empty space
                     {
                        sA += s;
                        sA += "\r\n";
                     }

                    /* if (s != "")
                     {
                         sA += s;
                         sA += "\r\n";
                     } */
                 }


                 if (AppendFile.Checked == true) // Much simpler
                 {
                     textShow.Text += sA;
                 }
                 else
                 {
                     textShow.Text = sA;
                 }
                 srFile.Close(); //ALWAYS CLOSE ONCE WE OPEN


                // srFile.ReadToEnd(); //Also use string sA = ..... but perhaps not necessary

                // textShow.Text = srFile.ReadToEnd(); <<For some reason, it addas an empty line at the end.

                // textShow.Text = srFile.ReadLine(); << ReadLine only first line

            }

        }

        private void AppendFile_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
