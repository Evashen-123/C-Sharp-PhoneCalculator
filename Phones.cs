using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Exam2014
{
    public class Phones
    {
        //private attributes
        private string name;
        private string surname;
        private int num_apps;
        private decimal type;
        private decimal period;
        private decimal sms;
        private decimal data;
        private decimal airtime;
        
        //property structures
        public string propName
        {
            get { return name; }
            set { name = value; }
        }
        public string propSurname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int propNum_apps
        {
            get { return num_apps; }
            set { num_apps = value; }
        }
        public decimal propType
        {
            get { return type; }
            set { type = value; }
        }
        public decimal propPeriod
        {
            get { return period; }
            set { period = value; }
        }
        public decimal propSms
        {
            get { return sms; }
            set { sms = value; }
        }
        public decimal propData
        {
            get { return data; }
            set { data = value; }
        }
        public decimal propAirtime
        {
            get { return airtime; }
            set { airtime = value; }
        }

        //default constructor
        public Phones()
        {
            propName = "";
            propSurname = "";
            propNum_apps = 0;
            propAirtime = 0;
            propData = 0;
            propSms = 0;
            propPeriod = 0;
            propType = 0;
        }

        //parameterised constructor
          public Phones(string Name,string Surname,int apps,decimal airtime,decimal Data,decimal sms,decimal period,decimal type)
        {
            propName = Name;
            propSurname = Surname;
            propNum_apps = apps;
            propAirtime = airtime;
            propData = Data;
            propSms = sms;
            propPeriod = period;
            propType = type;
        }

        //methods
        public decimal calcBasicPremium()
          {
            return(propType/propPeriod);
          }

         public decimal calcAppCost()
        {
            if(propNum_apps==1)
            {
                return(Convert.ToDecimal(0.01)*calcBasicPremium());
            }
            else if (propNum_apps == 2)
            {
                return (Convert.ToDecimal(0.02) * calcBasicPremium());
            }
            else if (propNum_apps == 3)
            {
              return (Convert.ToDecimal(0.03) * calcBasicPremium());
            }
            else
            {
                return (0);
            }
        }

         public decimal calcExtrasCost()
         {
             return((propSms*calcBasicPremium())+(propAirtime*calcBasicPremium())+(propData*calcBasicPremium()));
         }

          public decimal calcMonthlyPremium()
         {
              return(calcBasicPremium()+calcAppCost()+calcExtrasCost());
         }

          public decimal calcTotalPremium()
          {
              return(calcMonthlyPremium()*propPeriod);
          }

          public void SaveData(string name, string code, string type,decimal period)
          {
              StreamWriter sw = new StreamWriter("C:\\Users\\evashen\\Desktop\\phone.txt", true);

              sw.WriteLine(name);
              sw.WriteLine(code);
              sw.WriteLine(type);
              sw.WriteLine(period);
              sw.Close();
          }

         public int GenerateCode()
        {
            int sum = 0;
         for(int i=1;i<=propPeriod;i++)
         {
             sum = sum + i;
         }
         return sum;
        }
    }
}