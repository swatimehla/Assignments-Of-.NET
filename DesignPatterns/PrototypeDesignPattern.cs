using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Test
    {
        public string Name;
        public Test CloneMe(Test t)
        {
            return (Test)this.MemberwiseClone();
        }
    }

    class InvitationCard
    {
        public String To;
        public String Title;
        public String Content;
        public String SendBy;
        public DateTime Date;
        public String p_To
        {
            get { return To; }
            set { To = value; }
        }
        public String p_Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public String p_content
        {
            get { return Content; }
            set { Content = value; }
        }
        public String p_SendBy
        {
            get { return SendBy; }
            set { SendBy = value; }
        }
        public DateTime p_Date
        {
            get { return Date; }
            set { Date = value; }
        }
        public InvitationCard CloneMe(InvitationCard obj)
        {
            return (InvitationCard)this.MemberwiseClone();
        }
    }
    class PrototypeDesignPattern
    {
        static void Main(string[] args)
        {
            Test obj1 = new Test();
            obj1.Name = "This is First Object";
            Test obj2 = obj1; // Trying to make copy in obj2  
            obj2.Name = "This is Second Object";
            Console.WriteLine(obj1.Name);

            Test obj3 = new Test();
            obj3.Name = "This is object 3";
            Test obj4 = obj3.CloneMe(obj3);
            obj4.Name = "This is Object 4";
            Console.WriteLine(obj3.Name);

            Console.WriteLine("This is Invitation Card Usig Prototype Design Pattern\n");
            InvitationCard invitation = new InvitationCard();
            invitation.p_To = "Ram";
            invitation.p_Title = "My birthday invitation";
            invitation.p_content = "Hey guys !! I am throwing a cheers party in my home";
            invitation.SendBy = "Sourav";
            invitation.p_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //Here our first object has created  
            InvitationCard[] objList = new InvitationCard[5];
            String[] nameList = { "Ram", "Shyam", "Hari", "Tapan", "Sukant" };
            int i = 0;
            foreach (String name in nameList)
            {
                //objList[i] = new InvitationCard();  
                objList[i] = invitation.CloneMe(invitation);
                objList[i].p_To = nameList[i];
                i++;
            }
            // Print all Invitation Card here  
            foreach (InvitationCard obj in objList)
            {
                Console.WriteLine("To :- " + obj.p_To);
                Console.WriteLine("Title :- " + obj.p_Title);
                Console.WriteLine("Content :- " + obj.p_content);
                Console.WriteLine("Send By :- " + obj.p_SendBy);
                Console.WriteLine("Date :- " + obj.Date);
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
