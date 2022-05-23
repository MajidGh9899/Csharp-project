using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additivecipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[] s = new int[10] ;
        public static void Getshift(int[] shi)
        {
            for (int i=0;i<10; i++)
                s[i] = shi[i];
        }
        
        public static string[] Analyse(string c)
        {
            String ENFREQ = "ETAOINSHRDLCUMWFGYPBVKJQXZ";
            int[] freq = new int[26];
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(c);
            
            foreach (var value in c)
            {
                
                freq[((int)value)-65]++;
                
            }
            int mx = freq.Max();
            int indexmx = 0;
            for (int i=0;i<26;i++ )
            {
                if (freq[i] == mx)
                { indexmx = i;
                    break;
                 }


            }
            string[] plaintext = new string []{ "", "", "", "", "", "", "", "", "", "" };
            int[] shift=new int[10];
            for(int i = 0; i < 10; i++)
            {
                int p;
                
                p=(indexmx+65)-(int)ENFREQ[i];
                if (p >= 0)
                    shift[i] = p;
                else
                    shift[i] = (p + 26) % 26;
            for(int j = 0; j < c.Length; j++)
                {
                    int idx=65;
                    if (((int)c[j] - shift[i]) < 65)
                        idx = ((int)c[j] - shift[i]) + 26;

                
                    else
                        idx = (int)c[j] - shift[i];



                        plaintext[i] += (char)(idx);
                }

                
                
            }
            Getshift(shift);
            return plaintext;
            
        }
            private void Find_Click(object sender, EventArgs e)
        {
            string cipher=input.Text;
            output.Text = "";
            for(int i = 0; i < 10; i++)
            {
                output.AppendText( Analyse(cipher.ToUpper()).ToArray()[i].ToString()+"-->shift :"+ s[i]+ Environment.NewLine);
                output.AppendText(Environment.NewLine);
            }
            

        }
    }
}
