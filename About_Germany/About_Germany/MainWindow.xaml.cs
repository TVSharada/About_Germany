using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace About_Germany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    public class ListBox_touristplaces
    {
        public string listItemimgpath { get; set; }
        public string listItemName { get; set; }
    }

    public class ListBox_about_germans
    {
        public string listItemimgpath_1 { get; set; }
        public string listItemName_1 { get; set; }
    }

    public class ListBox_quiz
    {
        public string listItemName_2 { get; set; }
    }
    public class combobox_states
    {
        public string cb_statename { get; set; }
    }

    public class Answers
    {
        public string atext { get; set; }
        public bool isCorrect { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ListBox_touristplaces> list_tourist = new List<ListBox_touristplaces>();
            /* Creating List Items */

            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "./Images/top1_berlin.png", listItemName = "Berlin" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top2_munich.png", listItemName = "Munich" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top3_neuschwanstein.png", listItemName = "Neuschwanstein" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top4_heidelberg.png", listItemName = "Heidelberg" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top5_lubeck.png", listItemName = "Lubeck" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top6_dresden.png", listItemName = "Dresden" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top7_cologne.png", listItemName = "Cologne" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top8_romantic_rhine.png", listItemName = "Romantic Rhine" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top9_rugen_island.png", listItemName = "Rugen Island" });
            list_tourist.Add(new ListBox_touristplaces() { listItemimgpath = "Images/top10_rothenburg_ob_der_tauber.png", listItemName = "Rothenburg ob der Tauber" });

            /* linking ItemSource to Restaurant ListBox*/
            tourist_places_listbox.ItemsSource = list_tourist;

            //List<combobox_states> cb_state_list = new List<combobox_states>(); 

            states_filter.Items.Add("Baden-Wuerttemberg");
            states_filter.Items.Add("Bayern (Bavaria)");
            states_filter.Items.Add("Berlin");
            states_filter.Items.Add("Brandenburg");
            states_filter.Items.Add("Bremen");
            states_filter.Items.Add("Hamburg");
            states_filter.Items.Add("Hessen");
            states_filter.Items.Add("Niedersachsen (Lower Saxony)");
            states_filter.Items.Add("Mecklenburg-Vorpommern");
            states_filter.Items.Add("Nordrhein-Westfalen");
            states_filter.Items.Add("Rheinland-Pfalz");
            states_filter.Items.Add("Saarland");
            states_filter.Items.Add("Sachsen(Saxony)");
            states_filter.Items.Add("Sachsen-Anhalt (Saxony-Anhalt)");
            states_filter.Items.Add("Schleswig-Holstein");
            states_filter.Items.Add("Thüringen");


            List<ListBox_about_germans> list_about_germans = new List<ListBox_about_germans>();
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_love_rules_img.png", listItemName_1 = "Germans Love Rules, Organization" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_football_img.png", listItemName_1 = "Football is a religion" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_no_shopping_img.png", listItemName_1 = "No Shopping on Sunday" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_punctual_img.png", listItemName_1 = "Germans are Punctual" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_insurance_img.png", listItemName_1 = "Germans Are Well-insured" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_love_beer_img.png", listItemName_1 = "Germans love Beer" });
            list_about_germans.Add(new ListBox_about_germans() { listItemimgpath_1 = "Images/ag_bread_img.png", listItemName_1 = "German bread is AMAZING" });

            about_germans.ItemsSource = list_about_germans;


            List<ListBox_quiz> list_quiz_questions = new List<ListBox_quiz>();

            list_quiz_questions.Add(new ListBox_quiz() { listItemName_2 = "What is the capital of Hessen?" });
            list_quiz_questions.Add(new ListBox_quiz() { listItemName_2 = "October fest happens in which city?" });
            list_quiz_questions.Add(new ListBox_quiz() { listItemName_2 = "Dresden is the capital of which state?" });
            list_quiz_questions.Add(new ListBox_quiz() { listItemName_2 = "Which is the northmost state of germany?" });
            list_quiz_questions.Add(new ListBox_quiz() { listItemName_2 = "To which state the city 'Kiel' belongs to? " });

            lb_quiz.ItemsSource = list_quiz_questions;

            List<Answers> list_quiz_a1 = new List<Answers>();

            list_quiz_a1.Add(new Answers() { atext = "a.) Munich", isCorrect = false });
            list_quiz_a1.Add(new Answers() { atext = "b.) Berlin", isCorrect = false });
            list_quiz_a1.Add(new Answers() { atext = "c.) Stuttgart", isCorrect = false });
            list_quiz_a1.Add(new Answers() { atext = "d.) Wiesbaden", isCorrect = true });

            quiz_a1.ItemsSource = list_quiz_a1;


            List<Answers> list_quiz_a2 = new List<Answers>();

            list_quiz_a2.Add(new Answers() { atext = "a.) Hamburg", isCorrect = false });
            list_quiz_a2.Add(new Answers() { atext = "b.) Munich", isCorrect = true });
            list_quiz_a2.Add(new Answers() { atext = "c.) Stuttgart", isCorrect = false });
            list_quiz_a2.Add(new Answers() { atext = "d.) Frankfurt", isCorrect = true });

            quiz_a2.ItemsSource = list_quiz_a2;

            List<Answers> list_quiz_a3 = new List<Answers>();

            list_quiz_a3.Add(new Answers() { atext = "a.) Bayern", isCorrect = false });
            list_quiz_a3.Add(new Answers() { atext = "b.) Sachsen(Saxony)", isCorrect = true });
            list_quiz_a3.Add(new Answers() { atext = "c.) Thüringen", isCorrect = false });
            list_quiz_a3.Add(new Answers() { atext = "d.) Baden-wuerttemberg", isCorrect = false });

            quiz_a3.ItemsSource = list_quiz_a3;

            List<Answers> list_quiz_a4 = new List<Answers>();

            list_quiz_a4.Add(new Answers() { atext = "a.) Schleswig-Holstein", isCorrect = true });
            list_quiz_a4.Add(new Answers() { atext = "b.) Bayern", isCorrect = false });
            list_quiz_a4.Add(new Answers() { atext = "c.) Nordrhein-Westfalen", isCorrect = false });
            list_quiz_a4.Add(new Answers() { atext = "d.) Mecklenburg-Vorpommern", isCorrect = false });

            quiz_a4.ItemsSource = list_quiz_a4;

            List<Answers> list_quiz_a5 = new List<Answers>();

            list_quiz_a5.Add(new Answers() { atext = "a.) Bayern", isCorrect = false });
            list_quiz_a5.Add(new Answers() { atext = "b.) Mecklenburg-Vorpommern", isCorrect = false });
            list_quiz_a5.Add(new Answers() { atext = "c.) Saarland", isCorrect = false });
            list_quiz_a5.Add(new Answers() { atext = "d.) Bremen", isCorrect = true });

            quiz_a5.ItemsSource = list_quiz_a5;
        }
        /* Button click for 'states' */
        private void Button_Click_States(object sender, RoutedEventArgs e)
        {
            germany_map.Visibility = Visibility.Visible;
            tourist_places.Visibility = Visibility.Collapsed;
            things_to_know.Visibility = Visibility.Collapsed;
            quiz.Visibility = Visibility.Collapsed;
            states_filter.Visibility = Visibility.Visible;
            back_button.Visibility = Visibility.Visible;
            tourist_places_listbox.Visibility = Visibility.Collapsed;
            germany_text.Visibility = Visibility.Collapsed;
        }

        /* Button click for 'Top 10 tourist places in Germany' */
        private void Button_Click_touristplaces(object sender, RoutedEventArgs e)

        {
            tourist_places.Margin = new Thickness(59, 40, 0, 0);

            germany_map.Visibility = Visibility.Collapsed;
            tourist_places_listbox.Visibility = Visibility.Visible;
            states.Visibility = Visibility.Collapsed;
            tourist_places.Visibility = Visibility.Visible;
            things_to_know.Visibility = Visibility.Collapsed;
            quiz.Visibility = Visibility.Collapsed;
            back_button.Visibility = Visibility.Visible;
            germany_text.Visibility = Visibility.Collapsed;

            bw.Visibility = Visibility.Collapsed;
            by.Visibility = Visibility.Collapsed;
            be.Visibility = Visibility.Collapsed;
            bb.Visibility = Visibility.Collapsed;
            hb.Visibility = Visibility.Collapsed;
            hh.Visibility = Visibility.Collapsed;
            he.Visibility = Visibility.Collapsed;
            ni.Visibility = Visibility.Collapsed;
            mv.Visibility = Visibility.Collapsed;
            nw.Visibility = Visibility.Collapsed;
            rp.Visibility = Visibility.Collapsed;
            sl.Visibility = Visibility.Collapsed;
            sn.Visibility = Visibility.Collapsed;
            st.Visibility = Visibility.Collapsed;
            sh.Visibility = Visibility.Collapsed;
            th.Visibility = Visibility.Collapsed;
        }

        /* Button click for 'Quiz' */
        private void Button_Click_quiz(object sender, RoutedEventArgs e)
        {
            quiz.Margin = new Thickness(59, 40, 0, 0);

            germany_map.Visibility = Visibility.Collapsed;
            states.Visibility = Visibility.Collapsed;
            tourist_places.Visibility = Visibility.Collapsed;
            things_to_know.Visibility = Visibility.Collapsed;
            quiz.Visibility = Visibility.Visible;
            lb_quiz.Visibility = Visibility.Visible;
            back_button.Visibility = Visibility.Visible;
            tourist_places_listbox.Visibility = Visibility.Collapsed;
            germany_text.Visibility = Visibility.Collapsed;

            bw.Visibility = Visibility.Collapsed;
            by.Visibility = Visibility.Collapsed;
            be.Visibility = Visibility.Collapsed;
            bb.Visibility = Visibility.Collapsed;
            hb.Visibility = Visibility.Collapsed;
            hh.Visibility = Visibility.Collapsed;
            he.Visibility = Visibility.Collapsed;
            ni.Visibility = Visibility.Collapsed;
            mv.Visibility = Visibility.Collapsed;
            nw.Visibility = Visibility.Collapsed;
            rp.Visibility = Visibility.Collapsed;
            sl.Visibility = Visibility.Collapsed;
            sn.Visibility = Visibility.Collapsed;
            st.Visibility = Visibility.Collapsed;
            sh.Visibility = Visibility.Collapsed;
            th.Visibility = Visibility.Collapsed;
        }

        /* Button click for 'Things to know about Germans' */
        private void Button_Click_things_to_know(object sender, RoutedEventArgs e)
        {
            things_to_know.Margin = new Thickness(59, 40, 0, 0);

            germany_map.Visibility = Visibility.Collapsed;
            states.Visibility = Visibility.Collapsed;
            tourist_places.Visibility = Visibility.Collapsed;
            things_to_know.Visibility = Visibility.Visible;
            about_germans.Visibility = Visibility.Visible;
            quiz.Visibility = Visibility.Collapsed;
            back_button.Visibility = Visibility.Visible;
            tourist_places_listbox.Visibility = Visibility.Collapsed;
            germany_text.Visibility = Visibility.Collapsed;

            bw.Visibility = Visibility.Collapsed;
            by.Visibility = Visibility.Collapsed;
            be.Visibility = Visibility.Collapsed;
            bb.Visibility = Visibility.Collapsed;
            hb.Visibility = Visibility.Collapsed;
            hh.Visibility = Visibility.Collapsed;
            he.Visibility = Visibility.Collapsed;
            ni.Visibility = Visibility.Collapsed;
            mv.Visibility = Visibility.Collapsed;
            nw.Visibility = Visibility.Collapsed;
            rp.Visibility = Visibility.Collapsed;
            sl.Visibility = Visibility.Collapsed;
            sn.Visibility = Visibility.Collapsed;
            st.Visibility = Visibility.Collapsed;
            sh.Visibility = Visibility.Collapsed;
            th.Visibility = Visibility.Collapsed;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            germany_map.Visibility = Visibility.Visible;
            tourist_places.Visibility = Visibility.Visible;
            things_to_know.Visibility = Visibility.Visible;
            about_germans.Visibility = Visibility.Collapsed;
            quiz.Visibility = Visibility.Visible;
            lb_quiz.Visibility = Visibility.Collapsed;
            states.Visibility = Visibility.Visible;
            germany_text.Visibility = Visibility.Visible;
            states_filter.Visibility = Visibility.Collapsed;
            back_button.Visibility = Visibility.Collapsed;
            tourist_places_listbox.Visibility = Visibility.Collapsed;

            tourist_places.Margin = new Thickness(211, 40, 0, 0);
            quiz.Margin = new Thickness(565, 40, 0, 0);
            things_to_know.Margin = new Thickness(386, 40, 0, 0);

            top1_berlin_img.Visibility = Visibility.Collapsed;
            top1_berlin_text.Visibility = Visibility.Collapsed;
            top2_munich_img.Visibility = Visibility.Collapsed;
            top2_munich_text.Visibility = Visibility.Collapsed;
            top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
            top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
            top4_heidelberg_text.Visibility = Visibility.Collapsed;
            top4_heidelberg_img.Visibility = Visibility.Collapsed;
            top5_lubeck_img.Visibility = Visibility.Collapsed;
            top5_lubeck_text.Visibility = Visibility.Collapsed;
            top6_dresden_img.Visibility = Visibility.Collapsed;
            top6_dresden_text.Visibility = Visibility.Collapsed;
            top7_cologne_img.Visibility = Visibility.Collapsed;
            top7_cologne_text.Visibility = Visibility.Collapsed;
            top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
            top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
            top9_rugen_island_img.Visibility = Visibility.Collapsed;
            top9_rugen_island_text.Visibility = Visibility.Collapsed;
            top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
            top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;

            bw_state_text.Visibility = Visibility.Collapsed;
            bw_state_flag.Visibility = Visibility.Collapsed;
            by_state_text.Visibility = Visibility.Collapsed;
            by_state_flag.Visibility = Visibility.Collapsed;
            be_state_text.Visibility = Visibility.Collapsed;
            be_state_flag.Visibility = Visibility.Collapsed;
            bb_state_text.Visibility = Visibility.Collapsed;
            bb_state_flag.Visibility = Visibility.Collapsed;
            hb_state_text.Visibility = Visibility.Collapsed;
            hb_state_flag.Visibility = Visibility.Collapsed;
            hh_state_text.Visibility = Visibility.Collapsed;
            hh_state_flag.Visibility = Visibility.Collapsed;
            he_state_text.Visibility = Visibility.Collapsed;
            he_state_flag.Visibility = Visibility.Collapsed;
            ni_state_text.Visibility = Visibility.Collapsed;
            ni_state_flag.Visibility = Visibility.Collapsed;
            mv_state_text.Visibility = Visibility.Collapsed;
            mv_state_flag.Visibility = Visibility.Collapsed;
            nw_state_text.Visibility = Visibility.Collapsed;
            nw_state_flag.Visibility = Visibility.Collapsed;
            rp_state_text.Visibility = Visibility.Collapsed;
            rp_state_flag.Visibility = Visibility.Collapsed;
            sl_state_text.Visibility = Visibility.Collapsed;
            sl_state_flag.Visibility = Visibility.Collapsed;
            sn_state_text.Visibility = Visibility.Collapsed;
            sn_state_flag.Visibility = Visibility.Collapsed;
            st_state_text.Visibility = Visibility.Collapsed;
            st_state_flag.Visibility = Visibility.Collapsed;
            sh_state_text.Visibility = Visibility.Collapsed;
            sh_state_flag.Visibility = Visibility.Collapsed;
            th_state_text.Visibility = Visibility.Collapsed;
            th_state_flag.Visibility = Visibility.Collapsed;

            ag_love_rules_img.Visibility = Visibility.Collapsed;
            ag_love_rules_text.Visibility = Visibility.Collapsed;
            ag_football_img.Visibility = Visibility.Collapsed;
            ag_football_text.Visibility = Visibility.Collapsed;
            ag_no_shopping_img.Visibility = Visibility.Collapsed;
            ag_no_shopping_text.Visibility = Visibility.Collapsed;
            ag_direct_img.Visibility = Visibility.Collapsed;
            ag_direct_text.Visibility = Visibility.Collapsed;
            ag_punctual_img.Visibility = Visibility.Collapsed;
            ag_punctual_text.Visibility = Visibility.Collapsed;
            ag_insurance_img.Visibility = Visibility.Collapsed;
            ag_insurance_text.Visibility = Visibility.Collapsed;
            ag_beer_img.Visibility = Visibility.Collapsed;
            ag_beer_text.Visibility = Visibility.Collapsed;
            ag_bread_img.Visibility = Visibility.Collapsed;
            ag_bread_text.Visibility = Visibility.Collapsed;

            bw.Visibility = Visibility.Collapsed;
            by.Visibility = Visibility.Collapsed;
            be.Visibility = Visibility.Collapsed;
            bb.Visibility = Visibility.Collapsed;
            hb.Visibility = Visibility.Collapsed;
            hh.Visibility = Visibility.Collapsed;
            he.Visibility = Visibility.Collapsed;
            ni.Visibility = Visibility.Collapsed;
            mv.Visibility = Visibility.Collapsed;
            nw.Visibility = Visibility.Collapsed;
            rp.Visibility = Visibility.Collapsed;
            sl.Visibility = Visibility.Collapsed;
            sn.Visibility = Visibility.Collapsed;
            st.Visibility = Visibility.Collapsed;
            sh.Visibility = Visibility.Collapsed;
            th.Visibility = Visibility.Collapsed;

            quiz_question1.Visibility = Visibility.Collapsed;
            quiz_a1.Visibility = Visibility.Collapsed;
            quiz_question2.Visibility = Visibility.Collapsed;
            quiz_a2.Visibility = Visibility.Collapsed;
            quiz_question3.Visibility = Visibility.Collapsed;
            quiz_a3.Visibility = Visibility.Collapsed;
            quiz_question4.Visibility = Visibility.Collapsed;
            quiz_a4.Visibility = Visibility.Collapsed;
            quiz_question5.Visibility = Visibility.Collapsed;
            quiz_a5.Visibility = Visibility.Collapsed;
        }

        private void tourist_places_listbox_Click(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = this.tourist_places_listbox.SelectedIndex;
                if (index != -1)
                {

                    if (index == 0)
                    {
                        top1_berlin_img.Visibility = Visibility.Visible;
                        top1_berlin_text.Visibility = Visibility.Visible;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;

                    }
                    else if (index == 1)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Visible;
                        top2_munich_text.Visibility = Visibility.Visible;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;


                    }
                    else if (index == 2)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Visible;
                        top3_neuschwanstein_text.Visibility = Visibility.Visible;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;

                    }
                    else if (index == 3)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Visible;
                        top4_heidelberg_img.Visibility = Visibility.Visible;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;
                    }
                    else if (index == 4)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Visible;
                        top5_lubeck_text.Visibility = Visibility.Visible;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;
                    }
                    else if (index == 5)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Visible;
                        top6_dresden_text.Visibility = Visibility.Visible;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;
                    }
                    else if (index == 6)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Visible;
                        top7_cologne_text.Visibility = Visibility.Visible;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;



                    }
                    else if (index == 7)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Visible;
                        top8_romantic_rhine_text.Visibility = Visibility.Visible;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;

                    }
                    else if (index == 8)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Visible;
                        top9_rugen_island_text.Visibility = Visibility.Visible;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Collapsed;

                    }
                    else if (index == 9)
                    {
                        top1_berlin_img.Visibility = Visibility.Collapsed;
                        top1_berlin_text.Visibility = Visibility.Collapsed;
                        top2_munich_img.Visibility = Visibility.Collapsed;
                        top2_munich_text.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_img.Visibility = Visibility.Collapsed;
                        top3_neuschwanstein_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_text.Visibility = Visibility.Collapsed;
                        top4_heidelberg_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_img.Visibility = Visibility.Collapsed;
                        top5_lubeck_text.Visibility = Visibility.Collapsed;
                        top6_dresden_img.Visibility = Visibility.Collapsed;
                        top6_dresden_text.Visibility = Visibility.Collapsed;
                        top7_cologne_img.Visibility = Visibility.Collapsed;
                        top7_cologne_text.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_img.Visibility = Visibility.Collapsed;
                        top8_romantic_rhine_text.Visibility = Visibility.Collapsed;
                        top9_rugen_island_img.Visibility = Visibility.Collapsed;
                        top9_rugen_island_text.Visibility = Visibility.Collapsed;
                        top10_rothenburg_ob_der_tauber_img.Visibility = Visibility.Visible;
                        top10_rothenburg_ob_der_tauber_text.Visibility = Visibility.Visible;
                        
                    }
                }


            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }
        private void state_selected(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    var state_name = this.states_filter.SelectedItem.ToString();
                    if (state_name != null)
                    {

                        if (state_name == "Baden-Wuerttemberg")
                        {
                            bw_state_text.Visibility = Visibility.Visible;
                            bw_state_flag.Visibility = Visibility.Visible;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Visible;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Bayern (Bavaria)")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Visible;
                            by_state_flag.Visibility = Visibility.Visible;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Visible;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Berlin")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Visible;
                            be_state_flag.Visibility = Visibility.Visible;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Visible;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Brandenburg")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Visible;
                            bb_state_flag.Visibility = Visibility.Visible;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Visible;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Bremen")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Visible;
                            hb_state_flag.Visibility = Visibility.Visible;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Visible;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;

                        }
                        else if (state_name == "Hamburg")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Visible;
                            hh_state_flag.Visibility = Visibility.Visible;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Visible;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;

                        }
                        else if (state_name == "Hessen")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Visible;
                            he_state_flag.Visibility = Visibility.Visible;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Visible;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Niedersachsen (Lower Saxony)")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Visible;
                            ni_state_flag.Visibility = Visibility.Visible;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Visible;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Mecklenburg-Vorpommern")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Visible;
                            mv_state_flag.Visibility = Visibility.Visible;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Visible;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Nordrhein-Westfalen")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Visible;
                            nw_state_flag.Visibility = Visibility.Visible;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Visible;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Rheinland-Pfalz")
                        {

                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Visible;
                            rp_state_flag.Visibility = Visibility.Visible;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Visible;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Saarland")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Visible;
                            sl_state_flag.Visibility = Visibility.Visible;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Visible;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;

                        }
                        else if (state_name == "Sachsen(Saxony)")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Visible;
                            sn_state_flag.Visibility = Visibility.Visible;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Visible;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;

                        }
                        else if (state_name == "Sachsen-Anhalt (Saxony-Anhalt)")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Visible;
                            st_state_flag.Visibility = Visibility.Visible;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Visible;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Schleswig-Holstein")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Visible;
                            sh_state_flag.Visibility = Visibility.Visible;
                            th_state_text.Visibility = Visibility.Collapsed;
                            th_state_flag.Visibility = Visibility.Collapsed;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Visible;
                            th.Visibility = Visibility.Collapsed;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }
                        else if (state_name == "Thüringen")
                        {
                            bw_state_text.Visibility = Visibility.Collapsed;
                            bw_state_flag.Visibility = Visibility.Collapsed;
                            by_state_text.Visibility = Visibility.Collapsed;
                            by_state_flag.Visibility = Visibility.Collapsed;
                            be_state_text.Visibility = Visibility.Collapsed;
                            be_state_flag.Visibility = Visibility.Collapsed;
                            bb_state_text.Visibility = Visibility.Collapsed;
                            bb_state_flag.Visibility = Visibility.Collapsed;
                            hb_state_text.Visibility = Visibility.Collapsed;
                            hb_state_flag.Visibility = Visibility.Collapsed;
                            hh_state_text.Visibility = Visibility.Collapsed;
                            hh_state_flag.Visibility = Visibility.Collapsed;
                            he_state_text.Visibility = Visibility.Collapsed;
                            he_state_flag.Visibility = Visibility.Collapsed;
                            ni_state_text.Visibility = Visibility.Collapsed;
                            ni_state_flag.Visibility = Visibility.Collapsed;
                            mv_state_text.Visibility = Visibility.Collapsed;
                            mv_state_flag.Visibility = Visibility.Collapsed;
                            nw_state_text.Visibility = Visibility.Collapsed;
                            nw_state_flag.Visibility = Visibility.Collapsed;
                            rp_state_text.Visibility = Visibility.Collapsed;
                            rp_state_flag.Visibility = Visibility.Collapsed;
                            sl_state_text.Visibility = Visibility.Collapsed;
                            sl_state_flag.Visibility = Visibility.Collapsed;
                            sn_state_text.Visibility = Visibility.Collapsed;
                            sn_state_flag.Visibility = Visibility.Collapsed;
                            st_state_text.Visibility = Visibility.Collapsed;
                            st_state_flag.Visibility = Visibility.Collapsed;
                            sh_state_text.Visibility = Visibility.Collapsed;
                            sh_state_flag.Visibility = Visibility.Collapsed;
                            th_state_text.Visibility = Visibility.Visible;
                            th_state_flag.Visibility = Visibility.Visible;

                            bw.Visibility = Visibility.Collapsed;
                            by.Visibility = Visibility.Collapsed;
                            be.Visibility = Visibility.Collapsed;
                            bb.Visibility = Visibility.Collapsed;
                            hb.Visibility = Visibility.Collapsed;
                            hh.Visibility = Visibility.Collapsed;
                            he.Visibility = Visibility.Collapsed;
                            ni.Visibility = Visibility.Collapsed;
                            mv.Visibility = Visibility.Collapsed;
                            nw.Visibility = Visibility.Collapsed;
                            rp.Visibility = Visibility.Collapsed;
                            sl.Visibility = Visibility.Collapsed;
                            sn.Visibility = Visibility.Collapsed;
                            st.Visibility = Visibility.Collapsed;
                            sh.Visibility = Visibility.Collapsed;
                            th.Visibility = Visibility.Visible;
                            bw.Fill = Brushes.Transparent;
                            by.Fill = Brushes.Transparent;
                            be.Fill = Brushes.Transparent;
                            bb.Fill = Brushes.Transparent;
                            hb.Fill = Brushes.Transparent;
                            hh.Fill = Brushes.Transparent;
                            he.Fill = Brushes.Transparent;
                            ni.Fill = Brushes.Transparent;
                            mv.Fill = Brushes.Transparent;
                            nw.Fill = Brushes.Transparent;
                            rp.Fill = Brushes.Transparent;
                            sl.Fill = Brushes.Transparent;
                            sn.Fill = Brushes.Transparent;
                            st.Fill = Brushes.Transparent;
                            sh.Fill = Brushes.Transparent;
                            th.Fill = Brushes.Transparent;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void about_germans_listbox_Click(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                int index = this.about_germans.SelectedIndex;
                if (index != -1)
                {

                    if (index == 0)
                    {
                        ag_love_rules_img.Visibility = Visibility.Visible;
                        ag_love_rules_text.Visibility = Visibility.Visible;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }


                    if (index == 1)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Visible;
                        ag_football_text.Visibility = Visibility.Visible;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }

                    if (index == 2)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Visible;
                        ag_no_shopping_text.Visibility = Visibility.Visible;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }
                    if (index == 3)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Visible;
                        ag_direct_text.Visibility = Visibility.Visible;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }
                    if (index == 3)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Visible;
                        ag_punctual_text.Visibility = Visibility.Visible;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }
                    if (index == 4)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Visible;
                        ag_insurance_text.Visibility = Visibility.Visible;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }
                    if (index == 5)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Visible;
                        ag_beer_text.Visibility = Visibility.Visible;
                        ag_bread_img.Visibility = Visibility.Collapsed;
                        ag_bread_text.Visibility = Visibility.Collapsed;
                    }
                    if (index == 6)
                    {
                        ag_love_rules_img.Visibility = Visibility.Collapsed;
                        ag_love_rules_text.Visibility = Visibility.Collapsed;
                        ag_football_img.Visibility = Visibility.Collapsed;
                        ag_football_text.Visibility = Visibility.Collapsed;
                        ag_no_shopping_img.Visibility = Visibility.Collapsed;
                        ag_no_shopping_text.Visibility = Visibility.Collapsed;
                        ag_direct_img.Visibility = Visibility.Collapsed;
                        ag_direct_text.Visibility = Visibility.Collapsed;
                        ag_punctual_img.Visibility = Visibility.Collapsed;
                        ag_punctual_text.Visibility = Visibility.Collapsed;
                        ag_insurance_img.Visibility = Visibility.Collapsed;
                        ag_insurance_text.Visibility = Visibility.Collapsed;
                        ag_beer_img.Visibility = Visibility.Collapsed;
                        ag_beer_text.Visibility = Visibility.Collapsed;
                        ag_bread_img.Visibility = Visibility.Visible;
                        ag_bread_text.Visibility = Visibility.Visible;

                    }
                }
            }
            catch 
            { 

            }
        }

        private void quiz_listbox_click(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = this.lb_quiz.SelectedIndex;
                if (index != -1)
                {

                    if (index == 0)
                    {
                        quiz_question1.Visibility = Visibility.Visible;
                        quiz_a1.Visibility = Visibility.Visible;
                        quiz_question2.Visibility = Visibility.Collapsed;
                        quiz_a2.Visibility = Visibility.Collapsed;
                        quiz_question3.Visibility = Visibility.Collapsed;
                        quiz_a3.Visibility = Visibility.Collapsed;
                        quiz_question4.Visibility = Visibility.Collapsed;
                        quiz_a4.Visibility = Visibility.Collapsed;
                        quiz_question5.Visibility = Visibility.Collapsed;
                        quiz_a5.Visibility = Visibility.Collapsed;
                    }
                    if (index == 1)
                    {
                        quiz_question1.Visibility = Visibility.Collapsed;
                        quiz_a1.Visibility = Visibility.Collapsed;
                        quiz_question2.Visibility = Visibility.Visible;
                        quiz_a2.Visibility = Visibility.Visible;
                        quiz_question3.Visibility = Visibility.Collapsed;
                        quiz_a3.Visibility = Visibility.Collapsed;
                        quiz_question4.Visibility = Visibility.Collapsed;
                        quiz_a4.Visibility = Visibility.Collapsed;
                        quiz_question5.Visibility = Visibility.Collapsed;
                        quiz_a5.Visibility = Visibility.Collapsed;
                    }
                    if (index == 2)
                    {
                        quiz_question1.Visibility = Visibility.Collapsed;
                        quiz_a1.Visibility = Visibility.Collapsed;
                        quiz_question2.Visibility = Visibility.Collapsed;
                        quiz_a2.Visibility = Visibility.Collapsed;
                        quiz_question3.Visibility = Visibility.Visible;
                        quiz_a3.Visibility = Visibility.Visible;
                        quiz_question4.Visibility = Visibility.Collapsed;
                        quiz_a4.Visibility = Visibility.Collapsed;
                        quiz_question5.Visibility = Visibility.Collapsed;
                        quiz_a5.Visibility = Visibility.Collapsed;
                    }
                    if (index == 3)
                    {
                        quiz_question1.Visibility = Visibility.Collapsed;
                        quiz_a1.Visibility = Visibility.Collapsed;
                        quiz_question2.Visibility = Visibility.Collapsed;
                        quiz_a2.Visibility = Visibility.Collapsed;
                        quiz_question3.Visibility = Visibility.Collapsed;
                        quiz_a3.Visibility = Visibility.Collapsed;
                        quiz_question4.Visibility = Visibility.Visible;
                        quiz_a4.Visibility = Visibility.Visible;
                        quiz_question5.Visibility = Visibility.Collapsed;
                        quiz_a5.Visibility = Visibility.Collapsed;
                     }
                    if (index == 4)
                    {
                        quiz_question1.Visibility = Visibility.Collapsed;
                        quiz_a1.Visibility = Visibility.Collapsed;
                        quiz_question2.Visibility = Visibility.Collapsed;
                        quiz_a2.Visibility = Visibility.Collapsed;
                        quiz_question3.Visibility = Visibility.Collapsed;
                        quiz_a3.Visibility = Visibility.Collapsed;
                        quiz_question4.Visibility = Visibility.Collapsed;
                        quiz_a4.Visibility = Visibility.Collapsed;
                        quiz_question5.Visibility = Visibility.Visible;
                        quiz_a5.Visibility = Visibility.Visible;
                    }
                }
            }
            catch
            {

            }
        }

        private void quiz_a1_click(object sender, SelectionChangedEventArgs e)
        {
            var answer = (sender as ListBox).SelectedItem as Answers;
            if (answer.isCorrect)
                MessageBox.Show("Great!! Correct answer!!");
            else
                MessageBox.Show("Oops!!Its Wrong Answer.Try Again!");
        }

        private void quiz_a2_click(object sender, SelectionChangedEventArgs e)
        {
            var answer = (sender as ListBox).SelectedItem as Answers;
            if (answer.isCorrect)
                MessageBox.Show("Great!! Correct answer!!");
            else
                MessageBox.Show("Oops!!Its Wrong Answer.Try Again!");
        }

        private void quiz_a3_click(object sender, SelectionChangedEventArgs e)
        {
            var answer = (sender as ListBox).SelectedItem as Answers;
            if (answer.isCorrect)
                MessageBox.Show("Great!! Correct answer!!");
            else
                MessageBox.Show("Oops!!Its Wrong Answer.Try Again!");
        }

        private void quiz_a4_click(object sender, SelectionChangedEventArgs e)
        {
            var answer = (sender as ListBox).SelectedItem as Answers;
            if (answer.isCorrect)
                MessageBox.Show("Great!! Correct answer!!");
            else
                MessageBox.Show("Oops!!Its Wrong Answer.Try Again!");
        }

        private void quiz_a5_click(object sender, SelectionChangedEventArgs e)
        {
            var answer = (sender as ListBox).SelectedItem as Answers;
            if (answer.isCorrect)
                MessageBox.Show("Great!! Correct answer!!");
            else
                MessageBox.Show("Oops!!Its Wrong Answer.Try Again!");
        }
    }
}
