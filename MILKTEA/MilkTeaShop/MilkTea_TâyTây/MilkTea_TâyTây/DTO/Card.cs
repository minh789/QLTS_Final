using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea_TâyTây.DTO
{
   public class Card
    {
        public Card(int cardID, string cardName, int cardStatus)
        {
            this.Id = cardID;
            this.Name = cardName;
            this.Status = cardStatus;
        }

        //chuyển từ datable dạng lấy cột thành list table dạng lấy đối tượng    
        public Card(DataRow row)
        {
            this.Id = (int)row["CardID"];
            this.Name = (string)row["CardName"];
            this.Status = (int)row["CardStatus"];
        }
     

        private int cardId;

        public int Id
        {
            get { return cardId; }
            set { cardId = value; }
        }

        private string cardName;

        public string Name
        {
            get { return cardName; }
            set { cardName = value; }
        }

        private int cardStatus;

        public int Status
        {
            get { return cardStatus; }
            set { cardStatus = value; }
        }
    }
}
