using MilkTea_TâyTây.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây.DAO
{
    public class CardDao
    {
        private static CardDao instance;

        //private string connectionSTR = @"Data Source=DESKTOP-G2GES0F;Initial Catalog=MilkTeaShop;Integrated Security=True";


        public static CardDao Instance
        {
            get { if (instance == null) instance = new CardDao(); return instance; }

            private set { instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;


        private CardDao() { }

        public List<Card> LoadCardList()
        {
            List<Card> cardList = new List<Card>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetCardList");
            foreach (DataRow item in data.Rows)
            {
                Card c = new Card(item);
                cardList.Add(c);
            }
            return cardList;
        }

        public List<Card> cardUpdate(int n)
        {
            List<Card> cardList = new List<Card>();
            DataTable data = DataProvider.Instance.ExcuteQuery("CardUpdate "+n);
            foreach (DataRow item in data.Rows)
            {
                Card c = new Card(item);
                cardList.Add(c);
            }
            return cardList;

        }

        public List<Card> cardRemove(int n)
        {
            List<Card> cardList = new List<Card>();
            DataTable data = DataProvider.Instance.ExcuteQuery("CardRemove " + n);
            foreach (DataRow item in data.Rows)
            {
                Card c = new Card(item);
                cardList.Add(c);
            }
            return cardList;

        }
    }
}
