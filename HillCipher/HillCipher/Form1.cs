using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillCipher
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        
        

        

        public static int[] Str2mat(string txt)
        {
            string Alpha = "abcdefghijklmnopqrstuvwxyz";
            int[] matx;
            if (txt.Length % 2 == 1)
                txt += 'z';
            List<int> list=new List<int>();
            for(int i=0; i < txt.Length; i++)
            {
                for(int j = 0; j < Alpha.Length; j++)
                {
                    if (txt[i] == Alpha[j])                    
                        list.Add( j);

                    
                    
                }
            }
            matx=list.ToArray();
            return matx;
            
        }

        public static string Hill(int[] msg, int[] key, bool inv)
        {

            if (inv == true && Det(key)!=0)
            {
                key=Inversemat(key);
            }
            int[] res ;
            List<int> list = new List<int>();
            string Alpha = "abcdefghijklmnopqrstuvwxyz";
            string cipher="";
            

            for (int i=0;i<msg.Length;i=i+2)
            {
                
                list.Add((msg[i]*key[i%2]+ msg[i+1] * key[(i % 2)+1])%26);
                
                list.Add( (msg[i] * key[(i % 2)+2] + msg[i + 1] * key[(i % 2) + 3])%26);
            }
            res= list.ToArray();
            for(int i = 0; i < res.Length; i++)
            {
                cipher+=Alpha[res[i]];
            }
            return cipher;
        }

        private void Enbtn_Click(object sender, EventArgs e)
        {
            
            if (Det(Str2mat(keytext.Text.Trim())) != 0)
                 Ciphertext.Text= Hill(Str2mat(Plaintext.Text.ToLower().Trim()), Str2mat(keytext.Text.ToLower().Trim()), inverse.Checked);
            else
                Ciphertext.Text = "Det KeyMatrix is 0 plz change Key";
            MsgMat.Text = String.Join(" ",Str2mat(Plaintext.Text.Trim()).Select(p => p.ToString()).ToArray());
            invemat.Text = String.Join(" ", Inversemat(Str2mat(keytext.Text.Trim())).Select(p => p.ToString()).ToArray());
           KetMat.Text = String.Join(" ", Str2mat(keytext.Text.Trim()).Select(p => p.ToString()).ToArray()); 
            
        }
        public static int Det(int[] mat)
        {
            int det = mat[0] * mat[3] - mat[1] * mat[2];
            

            
            return Operdet(det);

        }
        public static int Operdet(int det)
        {
            if (-det > 26)
                det = -det % 26;
            else if (det < 0)
                det = det + 26;
            return det;

        }
        public static int []Inversemat(int[] mat)
        {
            
            int Detmat = Det(mat);
            
            int DetMatinv=0;

            int P;
            for ( P = 1; P < mat.Max() * 2; P++)
            {
                if (Detmat * P % 26 == 1)
                { 
                DetMatinv = P;
                break;
            }
                    }
            int tmp;
            tmp = mat[0];
            mat[0] = mat[3];
            mat[3] = tmp;
            mat[1] *= -1;
            mat[2] *= -1;
            for(int i = 0; i < 4; i++)
            {
                if (mat[i] < 0)
                    mat[i] = Operdet(mat[i]);
                mat[i] = mat[i] * DetMatinv;
            }
            for(int i = 0;i < 4; i++)
            {
                mat[i] = mat[(i)]%26;
            }
            return mat;
                    
        }
     

        private void inverse_CheckedChanged(object sender, EventArgs e)
        {
            if (inverse.Checked)
                Enbtn.Text = "Decrypt";
                
            else
                Enbtn.Text = "Encrypt";

        }
    }
}
