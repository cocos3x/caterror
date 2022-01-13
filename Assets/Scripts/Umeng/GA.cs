using UnityEngine;

namespace Umeng
{
    public class GA : Analytics
    {
        // Methods
        public static void SetUserLevel(int level)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(level != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(level == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = level;
            Umeng.Analytics.Agent.CallStatic(methodName:  "setPlayerLevel", args:  val_1);
        }
        public static void SetUserInfo(string userId, Umeng.GA.Gender gender, int age, string platform)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(userId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(userId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = userId;
            val_1[1] = age;
            val_1[2] = gender;
            val_1[3] = platform;
            Umeng.Analytics.Agent.CallStatic(methodName:  "setPlayerInfo", args:  val_1);
        }
        public static void StartLevel(string level)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(level != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(level == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = level;
            Umeng.Analytics.Agent.CallStatic(methodName:  "startLevel", args:  val_1);
        }
        public static void FinishLevel(string level)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(level != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(level == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = level;
            Umeng.Analytics.Agent.CallStatic(methodName:  "finishLevel", args:  val_1);
        }
        public static void FailLevel(string level)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(level != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(level == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = level;
            Umeng.Analytics.Agent.CallStatic(methodName:  "failLevel", args:  val_1);
        }
        public static void Pay(double cash, Umeng.GA.PaySource source, double coin)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(cash != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(cash == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = cash;
            val_1[1] = coin;
            val_1[2] = source;
            Umeng.Analytics.Agent.CallStatic(methodName:  "pay", args:  val_1);
        }
        public static void Pay(double cash, int source, double coin)
        {
            var val_4;
            if((source - 1) < 100)
            {
                    val_4 = null;
                val_4 = null;
                object[] val_2 = new object[3];
                val_2[0] = cash;
                val_2[1] = coin;
                val_2[2] = source;
                Umeng.Analytics.Agent.CallStatic(methodName:  "pay", args:  val_2);
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException();
        }
        public static void Pay(double cash, Umeng.GA.PaySource source, string item, int amount, double price)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(cash != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(cash == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = cash;
            val_1[1] = item;
            val_1[2] = amount;
            val_1[3] = price;
            val_1[4] = source;
            Umeng.Analytics.Agent.CallStatic(methodName:  "pay", args:  val_1);
        }
        public static void Buy(string item, int amount, double price)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(item != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(item == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = item;
            val_1[1] = amount;
            val_1[2] = price;
            Umeng.Analytics.Agent.CallStatic(methodName:  "buy", args:  val_1);
        }
        public static void Use(string item, int amount, double price)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(item != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(item == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = item;
            val_1[1] = amount;
            val_1[2] = price;
            Umeng.Analytics.Agent.CallStatic(methodName:  "use", args:  val_1);
        }
        public static void Bonus(double coin, Umeng.GA.BonusSource source)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(coin != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(coin == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = coin;
            val_1[1] = source;
            Umeng.Analytics.Agent.CallStatic(methodName:  "bonus", args:  val_1);
        }
        public static void Bonus(string item, int amount, double price, Umeng.GA.BonusSource source)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(item != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(item == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = item;
            val_1[1] = amount;
            val_1[2] = price;
            val_1[3] = source;
            Umeng.Analytics.Agent.CallStatic(methodName:  "bonus", args:  val_1);
        }
        public static void ProfileSignIn(string userId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(userId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(userId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = userId;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onProfileSignIn", args:  val_1);
        }
        public static void ProfileSignIn(string userId, string provider)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(provider != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(provider == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = provider;
            val_1[1] = userId;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onProfileSignIn", args:  val_1);
        }
        public static void ProfileSignOff()
        {
            null = null;
            Umeng.Analytics.Agent.CallStatic(methodName:  "onProfileSignOff", args:  System.Array.Empty<System.Object>());
        }
        public GA()
        {
            this = new System.Object();
        }
    
    }

}
