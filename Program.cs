using System; // 控制台類型;如果想增加控制台本身其他套件指令就要下行多打using System.XXXX;
using System.Collections.Generic; // Collections 收款公司 generic 普通的 增加控制台本身這方面的語法的指令 

namespace by_far_絕對
{
    class Program
    {
        static void Main(string[] args) //已經此範圍定義代表 這裡有人取命過了!
        {                               //圖標是藍色箱子代表有 這個變量
            Console.Title ="dog abuse chat 虐狗聊天室 ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 40;
            Console.WriteLine("you are fuking dog");
            Console.WriteLine("so fat dog,what do your name ");
            string userName = Console.ReadLine();   //string 類別
            Console.WriteLine( "hey! "+userName + "! im cat,im your employer so im adopt you.  do you understand?");
            Console.WriteLine("what dogshit do you want to eat ? ");
            string a = Console.ReadLine();
            Console.WriteLine("ok this your "+ a);
            Console.WriteLine("do you understand math?"); // 變量 影片how to program in C#2
            Console.WriteLine("ok, i will tell you. how to multiplication");//乘法而已 
            int num01;                            //int整數 num01 賦於
            int num02;
               Console.Write("tell me a number : ");
               num01 = Convert.ToInt32(Console.ReadLine() ); // num01賦於打出來的數字
               Console.Write("and then tell a second number : ");
               num02 = Convert.ToInt32( Console.ReadLine() );
               int result = num01* num02;
               Console.WriteLine("this is my amswer "+result );
            Console.WriteLine("do you understand? how to division ? ");//除法而已
            int nu1;                              //int 整數 nu1賦於
            int nu2;
               Console.Write("tell me a number : ");
               nu1 = Convert.ToInt32(Console.ReadLine() );  // nu1賦於打出來的數字
               Console.Write("tell me a second number : ");
               nu2 = Convert.ToInt32(Console.ReadLine() );
               int rt = nu1/nu2;
               Console.WriteLine("this is my amswer "+rt );
            Console.WriteLine(" more flot and more accurate " );//高精度乘法喔 
             double num1;
             double num2;
              Console.Write("tell me a number ");
              num1 = Convert.ToDouble( Console.ReadLine() );//ToDouble 和 ToInt32 差別
              Console.Write( "tell me a second number ");
              num2 = Convert.ToDouble (Console.ReadLine() );
              double rlt = num1*num2;
              Console.WriteLine(" do you want to know result "+rlt);
              Console.WriteLine("give me money! garbage");//      if 和 else 影片how to program in C#3
              int cash = Convert.ToInt32( Console.ReadLine());
              if(cash < 1000 )
              {
                  Console.WriteLine("this is not enough dog ");
                  }
               else if (cash == 1000)
               {
                   Console.WriteLine("nice guy");
               }
               else
               {
                   int change = cash -1000 ;
                   Console.WriteLine("here is your dog price "+ change + " you can buy whatever do you want.");
               }
                   Console.WriteLine("wait! let me check you weight and height! ");
                    int weight;
                    int height;
                    Console.Write("how ~ ( much ) ~ weight~?? ");////之後這句後面接下面的代碼
                    weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("so how short ???? ");//之後這句後面接下面的代碼     >大於 和 <小於
                    height = Convert.ToInt32(Console.ReadLine());
                    if ( weight >= 10 && height <= 10000) 
                    {
                         Console.WriteLine("oh my god! you are so fat.you have to less your weight");
                    }else 
                    {
                        Console.WriteLine("fuck you ghost.");
                    }
                        Console.Write(" a number betweem 1 ~ 5 給出隨機數字 "); // switch(開始) 和 case(執行) 和 break (結束) 
                        int god = Convert.ToInt32(Console.ReadLine());
                        switch(god){
                            case 1://                  這要注意加 : 不然是錯誤的
                               Console.WriteLine("1");
                               break;//                這注意要打break 完成一環
                            case 2:
                               Console.WriteLine("2");
                               break;//                 注意上面的
                            case 3:
                                Console.WriteLine("3");
                                break;
                            case 4:
                                Console.WriteLine("4");
                                break;
                             case 5:
                                Console.WriteLine("5");
                                break;
                            default:
                                 Console.WriteLine(" wrong !!!!!!!!!!!!"); // default 給你錯誤的時候
                                 break;
                          }
                        Console.WriteLine("then again ,this is 'for' loops course in C# 給您1~5");// 循環 影片how to program in C#4 非常重要// write 會導致數字並排 writeline 能讓指令換行
                         
                          for (int i = 0; i < 5; i++ ) //可手動點擊 for loop  //從1下降   i是0 i小於5  i<5
                          {
                      
                              Console.WriteLine(i+1); //當沒有+1 5就會被省略
                        
                          } 
                          Console.WriteLine("給出5~1");
                          for (int i = 5; i > 0; i--)//從5下降  //改變i ˊi是5 i大於0 i>0
                          {
                              Console.WriteLine(i);
                          }
                          Console.WriteLine("乘於 ! 乘於 在 乘於");      
                           for (int i = 1; i <= 5; i++)  //i小於5 所以只有4次 4個乘法  除非是i小於等於5                        
                           {
                              double result1 = Math.Pow(2,i);
                              Console.WriteLine(result1); 
                           } 
                           Console.WriteLine("交給我數字 我再給出乘數");
                            int count = Convert.ToInt32(Console.ReadLine()); //console.readline給你輸入
                            for (int i = 1; i <= count; i++) // 這很重要上面有寫//記得i要改1 不然從1開始
                            {
                                double result2 = Math.Pow(2,i);
                                Console.WriteLine (result2);
                            }  
                            Console.WriteLine("while loop訓練場,骰子遊戲");
                           Random num11 = new Random();// 第二種 while loop 循環 當我們要重複代碼的時候 只要滿足條件 就像擲骰子 比for簡單
                            int roll = 0;
                            int attempts = 0;
                            while(roll != 6){       // != 就叫不等於
                                roll = num11.Next(1,7); // 最小值和最大值 從最小直到頭到最大,但不等於7(大概是限制投出數字範圍八)
                                Console.WriteLine("you rolled:"+roll);
                                attempts++; //嘗試的意思
                            }
                             Console.WriteLine("我給出 "+ attempts +" 次機會到 6");
                             Console.WriteLine("這是給出點點骰子遊戲");

                             Random 數子 = new Random();
                              int 滾動 = 0;
                              int 嘗試 = 0;
                              Console.WriteLine("自行按enter到結束");
                               
                              while(滾動 != 6){
                                  Console.ReadKey();
                                  滾動 = 數子.Next(1,7);//                串聯詞記得大寫不然是錯的
                                  Console.WriteLine("滾到"+滾動);
                                  嘗試++;
                              }

                              Console.WriteLine("我給出 "+ attempts +" 次機會到 6");
                              Console.WriteLine("接下來是排列"); //      string 排列       影片how to program in C#5
                              string[] 動物 = {"吉娃娃","胖子狗","巴哥犬","胖喵","陳TD"};
                              for (int i = 0; i < 5; i++)
                              {
                                  Console.WriteLine(動物[i]);
                              }

                              Console.WriteLine("我只是給出一個層次上的排序,類似等級排行,誰最強");
                               string[] 家庭教師 = {"雲雀恭彌","阿鋼","獄赤準人","山本武","六道骸","笹川了平"};// string[] 後面記得多加空白鍵+人名
                               for (int i = 0; i < 家庭教師.Length; i++) // 當點for loop 記得把length 大寫
                               {
                                    int 排行 = i+1;
                                    Console.WriteLine(排行 +". " +家庭教師[i] ); // 就只是人名前加數字而已
                               }

                               string[] AttackonTitan = new string[4]; // 4作為索引 string 有長度限制
                               Console.WriteLine("type which one stronger one by one in Attack on Titan ");
                               AttackonTitan[0] = Console.ReadLine(); //   反正不會在終端機上顯示不需要太糾結如何打出Attack on Titan
                               AttackonTitan[1] = Console.ReadLine(); //  輸入完但事情沒有發只有存儲
                               Console.WriteLine("如上一個步驟一樣略有改變");

                               string[]attack2 = new string[4]; // 這算進階一點的2個for
                               Console.WriteLine("一個一個顯示誰比較強!");
                               for (int i = 0; i < attack2.Length; i++)
                               {
                                   attack2[i] = Console.ReadLine(); //跟上面相比 用for loop 減少大量麻煩,畢竟for loop自動化很方便
                               }
                               Console.WriteLine("\n字母排序給出 ");//'\r'是回車，'\n'是換行，前者使光標到行首，後者使光標下移一格。通常用的Enter是兩個加起來。
                               Array.Sort(attack2);// 將字母順序排下去
                               for (int i = 0; i < attack2.Length; i++) // i 小於 attack2.length
                               {
                                   Console.WriteLine(attack2[i]);// i 這裡做為索引
                               }
                                Console.WriteLine("要寫商品清單嗎?");//上去打 using 使用控制台套件
                                List<string> 商品清單 = new List<string>();
                                商品清單.Add("可變電阻");
                                商品清單.Add("電感");// 樓下可變電阻被移除 那麼這索引為0
                                商品清單.Add("電容");
                                商品清單.Add("LED二極體");
                                for (int i = 0; i < 商品清單.Count; i++)
                                {
                                    Console.WriteLine(商品清單[i]);
                                }
                                商品清單.Remove("可變電阻");//排除掉不會被算在removeat
                                商品清單.RemoveAt(0); //當這裡顯示0 所以電感是0 程式都是0~9開始算
                                Console.WriteLine("--------------");
                                for (int i = 0; i < 商品清單.Count; i++)
                                {
                                    Console.WriteLine(商品清單[i]);
                                }
                            //沒事 就只是用用看github

                               
                              
                                    
                                
                        

                    
                  Console.ReadKey();
            
        }
    }
}
