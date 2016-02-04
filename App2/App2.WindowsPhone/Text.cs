using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Text
    {
        private string content;
        private string code;

        public string encrypt()
        {
            string content = this.content.ToString();
            string code = this.code.ToString();
            string codeLower = this.code.ToString().ToLower();
            string output = "";
            bool change = false;
            //output = output.Insert(output.Length, code);

            for (int i = 0; i < content.Length; i++)
            {
                change = false;
                for (int j = 0; j < code.Length - 1; j++)
                {
                    if (content[i] == code[j])
                    {
                        if (code[j + 1] == ' ' || code[j + 1] == '-')
                        {
                            output = output.Insert(output.Length, code[j - 1].ToString());
                            change = true;
                            break;
                        }
                        else
                        {
                            output = output.Insert(output.Length, code[j + 1].ToString());
                            change = true;
                            break;
                        }
                    }
                    else if (content[i] == codeLower[j])
                    {
                        if (codeLower[j + 1] == ' ' || codeLower[j + 1] == '-')
                        {
                            output = output.Insert(output.Length, codeLower[j - 1].ToString());
                            change = true;
                            break;
                        }
                        else
                        {
                            output = output.Insert(output.Length, codeLower[j + 1].ToString());
                            change = true;
                            break;
                        }
                    }

                }
                if (!change) output = output.Insert(output.Length, content[i].ToString());
            }
            return output;
        }

        public Text(string content, string code)
        {
            this.content = content;
            this.code = code;
        }
    }
}
