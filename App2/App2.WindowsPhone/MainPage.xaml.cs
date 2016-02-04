using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace App2
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            comboBox.Items.Add("GA-DE-RY-PO-LU-KI ");
            comboBox.Items.Add("PO-LI-TY-KA-RE-NU ");
            comboBox.Items.Add("ZA-BO-RE-CU-MY-KI ");
            comboBox.SelectedItem = "GA-DE-RY-PO-LU-KI ";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            string input = Box1.Text;
            string code = comboBox.SelectedValue.ToString();
            Text text = new Text(input, code);

            string output = text.encrypt();
            Box2.Text = output;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Box1.Text = "";
            Box2.Text = "";
        }

        private async void sms_Click(object sender, RoutedEventArgs e)
        {
            if(Box2.Text!="" && phone.Text!="" && Box2.Text != "Zaszyfruj coś!" && phone.Text != "Podaj numer!")
            {
                var msg = new Windows.ApplicationModel.Chat.ChatMessage();
                msg.Body = Box2.Text;
                msg.Recipients.Add(phone.Text);
                await Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(msg);
            }
            else
            {
                if(phone.Text == "")
                    phone.Text = "Podaj numer!";
                if (Box2.Text == "")
                    Box2.Text = "Zaszyfruj coś!";
            }
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            if(FindBox.Text=="") FindBox.Text = "Op ygz eylak Mkipsz oydzdsdm UPT zpstgł w ultrm 2013 ypil. Wtder wrapeną opsgeę epygecr w Spckété Aénéygud zgmkdnkł ng stpłdi oydzdsg uknkk uptnkczrch, itóyd stgłr ng siygjl bgniylctwg. Op ygz ipudjnr opegł skę ep ermksjk w opłpwkd lbkdałdap ypil. W pfkcjgunrm lzgsgenkdnkl opegł, żd wrczdyogłg skę jdap mksjg. Nkdpfkcjgunkd oyzrczrną brłr ypzbkdżnd olnitr wkezdnkg w soygwkd tdmog oygc mgjącrch epoypwgezkć ep oyrwgtrzgcjk oyzdwpźnkig.Mkipsz wczdśnkdj oygcpwgł mkęezr knnrmk w fkymkd epygeczdj Gytly Gnedysdn w Ogyrżl pygz Edupkttd w Opuscd. Brł tdż wkcdoydzdsdm Opusikdj Gadncjk Knfpymgcjk k Knwdstrcjk Zgaygnkcznrch pygz epygecą Spckété Aénéygud Cpyopygtd &Knvdstmdnt Bgnikna w Opuscd.Lipńczrł m.kn. oydstkżpwr KDO Ogyks.Sdywksl kntdyndtpwr dSIR sodcjgukzljd skę w soyzdegżr bkudtów uptnkczrch k knnrch oypelitów tlyrstrcznrch pnuknd. Ng jdap stypngch www mpżng zgilokć bkudtr opnge 700 uknkk uptnkczrch -zgyównp ydalugynrch, jgi k tgnkch, zgydzdywpwgć npcuda w buksip 450 trs.hptduk ng cgłrm śwkdckd, g tgiżd ilokć lbdzokdczdnkd opeyóżnd, bkudtr ipudjpwd ngjwkęiszrch dlypodjsikch oyzdwpźnkiów czr wrngjąć sgmpchóe.Soółig pe ikuil ugt oypwgezk slicdsrwną disognsję zgaygnkczną. Okdywszd zgaygnkcznd sdywksr ngudżącd ep aylor opwstgłr w Blłagykk k Ylmlnkk, ipudjnr - w Bygzrukk.W 2015 dSIR zgczął soyzdegwgć oypelitr tlyrstrcznd yównkdż w Mpłegwkk, Czdchgch, Tlycjk k Odyl.pwgnr pbkdit sopytpwr, stgyr ogwkupn, mkdszczącr ikderś igsr k szgtnkd iąokduksig, ezkskgj wrauąeg fgtgunkd. Wyęcz osljd dfdit npwdap stgekpnl Udakk. Ypzogegjącg skę ipnstylicjg, bphpmgzr k hgsłg wroksgnd ng śckgngch, ypbką bgyezp złd wygżdnkd.Epokdyp ng oyzdłpmkd mgycg k iwkdtnkg zedcrepwgnp p ypzbkóycd.Tgi, jgibr nkit wczdśnkdj tdap stgydap blernil nkd epstyzdagł. Optdm brłg nkdzbęeng knwdntgyrzgcjg, g tdygz nkd mg śypeiów ng wripngnkd ypzbkóyik.Nkit nkd zgougnpwgł tdj opzrcjk w bleżdckd.";

            string input = FindBox.Text.ToString().ToLower();
            string output= "";
            var dic = new SortedDictionary<char, int>();
            

            tabFreq tab = new tabFreq();
            int lettersCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsLetter(input[i]))
                {
                    lettersCount++;
                    if (!dic.ContainsKey(input[i]))
                    {
                        dic.Add(input[i], 1);
                        //output = output.Insert(output.Length, "input[" + input[i] + "] " + dic[input[i]]);
                    }
                    else
                    {
                        dic[input[i]] = dic[input[i]] + 1;
                        //output = output.Insert(output.Length, "input[" + input[i] + "] " + dic[input[i]]);
                    }
                }

            }
            var sortedDict = from entry in dic orderby entry.Value ascending select entry;
            foreach (KeyValuePair<char, int> entry in sortedDict)
            {
                string key = entry.Key.ToString();
                string value = entry.Value.ToString();
                double average = ((double)entry.Value / lettersCount)*100;
                output = output.Insert(output.Length, key + "-" + value) + " Av: " + average;
                if (tab.dic.ContainsKey(entry.Key))
                {
                    foreach (KeyValuePair<char, double> entry2 in tab.dic)
                    {
                        double diff = (entry2.Value - average);
                        if ((Math.Abs(diff)/entry2.Value)*100 < 10)
                        {
                                output = output.Insert(output.Length, "\n\tTyp:" + entry2.Key) + "(" + entry2.Value + ")";
   
                        }
                    }
                }
                output = output.Insert(output.Length, "\n" );
            }
            FindBox2.Text = output;       
        }

        private void Box2_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Box2.SelectAll();
        }
    }
}

