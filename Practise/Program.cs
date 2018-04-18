using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Practise
{
    class Program
    {


        enum demo
        {
            monday = 1,
            saturday = 2,
            friday = 3,
            sunday = 4

        }

        static void Main(string[] args)
        {


            //HighVer hv = new HighVer();
            //Console.WriteLine(hv.main("1.2.2", "1.2.0"));
            //Console.WriteLine(hv.main("10", "9"));
            //Console.WriteLine(hv.main("4.3.22.1", "4.3.22.1"));
            //Console.WriteLine(hv.main("0", "0"));
            //Console.WriteLine(hv.main("1.0.5", "1.1.0"));

            //int a = 0,b=10000;
            //A(a,b);


            // void A(int no1,int no2)
            //{
            //    int i=1;
            //    while(i*i < no2)
            //    {
            //        if (i * i > no1)                    
            //            Console.WriteLine(i * i);
            //        i++;                    
            //    }
            //}

            //void B()
            //{

            //}



            //String address = "hadssi@gmadssa@iadssss@l.com";
            //List<char> ad = new List<char>();
            //int flag = 0, flag2 = 0;


            //for (int i = 0; i < address.Length; i++)
            //{
            //    if (address[i] == '@')
            //        flag2 = i;
            //}
            //for (int i = 0; i < address.Length; i++)
            //{
            //    if ((address[i] == '@') && flag2 == i)
            //    {
            //        if (flag == 0)
            //        {
            //            int ascii = (int)address[i + 1];
            //            if ((ascii >= 97 && ascii <= 122) || (ascii >= 48 && ascii <= 57) || (ascii == 46) || (ascii == 45))
            //            {
            //                flag = 1;

            //            }
            //        }

            //    }
            //    else if (flag == 1)
            //    {
            //        ad.Add(address[i]);
            //        Console.WriteLine(address[i]);
            //    }
            //}




            //String startTag = "<buasasdsaf dgasdsadas dfsdd";
            //int flag = 0;
            //List<char> res = new List<char>();
            //res.Add('<');
            //res.Add('/');


            //for (int i = 0; i < startTag.Length; i++)
            //{
            //    if ((startTag[i] == '<'))
            //    {
            //        if (flag == 0)
            //        {
            //            int ascii = (int)startTag[i + 1];
            //            if (((ascii >= 97 && ascii <= 122) || (ascii >= 48 && ascii <= 57) || (ascii==60)) && startTag[i] != ' ')
            //            {
            //                flag = 1;

            //            }
            //        }

            //    }
            //     else if (flag == 1 &&  i+1 < startTag.Length)
            //    {
            //        if (startTag[i] != ' ')
            //        {

            //            res.Add(startTag[i]);
            //            //Console.WriteLine(startTag[i]);
            //        }
            //        else
            //        {
            //            flag = 0;

            //        }


            //    }
            //}



            //res.Add('>');



            //String a = new String(res.ToArray());

            //Console.WriteLine(a);





            //String inputString = "02-03-04-05-06-07-";

            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    if ((i + 1) % 3 != 0)
            //    {
            //        int ascii = (int)inputString[i];
            //        if ((ascii < 65 || ascii > 70) && (ascii < 48 || ascii > 57))
            //            Console.WriteLine("false");
            //    }
            //    else
            //    {
            //        if (inputString[i] != '-')
            //            Console.WriteLine("false");

            //        if (i == inputString.Length - 1)
            //            Console.WriteLine("false");

            //    }
            //}


            //string a = "abc", b = "abccba";
            //int i = 0;
            //int count = 0, lenb = b.Length, lena = a.Length;
            //char[] bb = b.ToCharArray();
            //char[] aa = a.ToCharArray();
            //int flag = 0;

            //aaa:
            //for ( i = 0; i < lena; i++)
            //{

            //    for (int j = 0; j < lenb; j++)
            //    {
            //        if (aa[i] == bb[j])
            //        {
            //            bb[j] = '-';
            //            flag++;
            //            break;
            //        }
            //    }
            //    if (flag >= a.Length)
            //    {
            //        count++;
            //        flag = 0;
            //    }

            //    else if (flag == 0)
            //    {
            //        Console.WriteLine(count + "");
            //        //return count;
            //    }



            //}

            //if (flag != 0 && i == lena - 1)
            //    goto aaa;

            //// return count;


            //Console.WriteLine(count + "");










            //demo_delegate d1 = new demo_delegate(add);
            //demo_delegate d2 = new demo_delegate(B);
            //demo_delegate d3 = new demo_delegate(C);


            //D(d1);
            //D(d2);
            //D(d3);





            //C obj2 = new C();
            //obj2.Print();

            // List<int> a = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // List<int> evenNumbers = a.FindAll(x => (x % 2) == 0);

            //List<string> b = (List<string>)a.Select(e => e.ToString());



            //C c = new C();
            //c.Print();
            //c.Event1();


            //int n = 5;
            ////string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = { -4, 3 ,- 9 ,0 ,4 ,1 };
            //plusMinus(arr, n);



            //int n = 4;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - (i + 1); j++)
            //    {
            //        Console.Write("O");
            //    }

            //    for(int k=0;k<i+1;k++)
            //        Console.Write("#");


            //    Console.WriteLine("");
            //}



            //int[] arr = { 24, 58, 41, 78, 15, 45 };
            //int a = 0, tot = 0;
            //int min = int.MaxValue, max = 0;



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    tot += arr[i];

            //}
            //Console.WriteLine(tot + "");
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    int tot2 = tot;
            //    tot2 = tot - arr[j];
            //    Console.WriteLine(tot2 + "");

            //    if (tot2 < min)
            //        min = tot2;
            //    if (tot2 > max)
            //        max = tot2;

            //}

            //Console.WriteLine(min + " " + max + " ");


            //long[] arr = { 24, 58, 41, 78, 15, 45 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    long tmp = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            tmp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = tmp;
            //        }
            //    }
            //}


            //long min = 0, max = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i != arr.Length - 1)
            //        min += arr[i];
            //    if (i != 0)
            //        max += arr[i];
            //}
            // Console.WriteLine(min + "|" + max)




            //int n = 4; int[] ar = { 3, 2, 1, 3 };

            //int max = 0, count = 0; ;
            //for(int i=0;i<ar.Length;i++)
            //{
            //    if (ar[i] > max)
            //        max = ar[i];
            //}

            //for(int i=0;i<ar.Length;i++)
            //{
            //    if (ar[i] == max)
            //        count++;
            //}


            //return count;



            //String s = "12:45:54PM";
            //String s2 = "",s3="";
            //String type = "";


            //String nhh = "";

            //for(int i=0;i<2;i++)
            //{
            //    if (s[i] != ':' && s[i] != 'P' && s[i] != 'A' && s[i] != 'M')
            //        s2 += s[i];

            //}      


            //for(int i = 0; i < s.Length; i++)
            //{
            //    if ( s[i] == 'A' || s[i] == 'M' || s[i] == 'P')
            //        type += s[i];
            //}

            //int calc = int.Parse(s2);         

            //if(int.Parse(s2) != 12)
            //{
            //    if(type != "AM")
            //    {

            //        calc += 12;
            //        nhh = calc.ToString();
            //    }

            //    else
            //    {
            //        nhh = s2;
            //    }

            //}

            //else
            //{
            //    if(type == "AM")
            //    {
            //        nhh += "00";
            //    }
            //    else if(type == "PM")
            //    {
            //        nhh += "12";
            //    }
            //}

            //s3 += nhh.ToString();
            //for(int i=2;i<s.Length-2;i++)
            //{
            //    s3 += s[i];
            //}

            //Console.WriteLine(s3);




            //IDictionary<int, String> d = new Dictionary<int, String>();

            //d.Add(1, "vamshi");
            //d.Add(2, "Krishna");
            //d.Add(3, "pabba");


            //foreach (var d1 in d)
            //    Console.WriteLine(d1.Value +" "+d1.Key);


            //int? i = null;
            //int j = i ?? 0;

            //Console.WriteLine(i.GetValueOrDefault());



            //STRING FUNCTIONS
            //string strOriginal = "These functions will come handy";

            //char[] strOriginal2 = strOriginal.ToArray();
            //char[] s2 = strOriginal2.Reverse().ToArray();
            //Console.WriteLine(s2);


            //char[] delim = { ' ' };
            //string[] strArr = strOriginal.Split(delim);
            //foreach (string s in strArr)
            //{
            //    Console.WriteLine(s);
            //}


            //if (String.Compare(strOriginal2.ToString(), s2.ToString(), false) != 0)
            //    Console.WriteLine("not equal");
            //else
            //    Console.WriteLine("equal");

            //byte[] b = Encoding.Unicode.GetBytes(strOriginal);

            //foreach(var b1 in b)
            //Console.Write(b1+" ");



            //String strModified = strOriginal.Insert(26, "very ");
            //strModified = strModified.Replace("very", "ve ");
            //Console.WriteLine(strModified);




            //int n = 88;
            //    int n1;
            //    List<int> seq = new List<int>();
            //List<int> seq2 = new List<int>();
            //seq.Add(n);
            //    while (n != 0)
            //    {
            //        n1 = func(n);
            //        seq.Add(n1);
            //        //Console.WriteLine(n1);
            //        n = n1;
            //    }


            //for (int i = 0; i < seq.Count; i++)
            //{
            //    int a = func2(seq[i]);
            //    seq2.Add(a);
            //}

            //int[] freq = new int[17];

            //for (int i = 0; i < seq2.Count; i++)
            //{
            //    if(seq2[i] != 0)
            //    freq[seq2[i]] += 1;
            //}

            //int max = 0,index=0;
            //for (int k = freq.Length; k > 0; k--)
            //{
            //    if (max < freq[k-1])
            //    {
            //        max = freq[k - 1];
            //        index = k - 1;
            //    }


            //}



            //Console.WriteLine(max);



            //int func(int nn)
            //{
            //    int sum = 0, nnn=nn;
            //    while (nnn != 0)
            //    {
            //        sum += nnn % 10;
            //        nnn = nnn / 10;
            //    }
            //    return nn-sum;
            //}



            //int func2(int no)
            //{
            //    int sum2 = 0;
            //    while (no != 0)
            //    {
            //        sum2 += no % 10;
            //        no = no / 10;

            //    }
            //    //Console.WriteLine(sum2);
            //    return sum2;
            //}



            //string[] inputArray = { "aba", "aa", "ad", "vcd", "aba" };
            //List<String> aa = new List<string>();

            //int max = 0;

            //foreach(var a in inputArray)
            //{
            //    if (max < a.Length)
            //        max = a.Length;
            //}

            //foreach (var a in inputArray)
            //{
            //    if (max == a.Length)
            //        aa.Add(a);
            //}




            //int legs = 4;

            //int count = 0;
            //List<int> a = new List<int>();

            //if (legs % 4 == 0)
            //    a.Add(0);

            //while(legs>=2)
            //{
            //    legs -= 2;
            //    count++;
            //    if ((legs) % 4 ==0   )
            //    {                    
            //        a.Add(count);
            //    }


            //}

            //foreach (var aa in a)
            //    Console.WriteLine(aa);


            //int[] coins = { 1, 2, 10 };
            //int price = 28;


            //int count = 0, l = coins.Length - 1;

            //while (price > 0)
            //{
            //    while (l > 0)
            //    {
            //        int c = price - coins[l];
            //        if (price >= c  && c>=0)
            //        {
            //            price -= coins[l];
            //            count++;
            //        }
            //        else
            //            l--;
            //    }




            //}

            //Console.WriteLine(count+"");




            //string s1 = "Many characters. The quick brown fox jumps over the lazy dog";                        
            //string s2 = "fox";
            //bool b;
            //b = s1.Contains(s2);
            //int i;
            //i = s1.IndexOf(s2);


            //Console.WriteLine(b);
            //Console.WriteLine(i);






            //int[] a = {1,1,1,1,1};
            ////int[] b = new int[a.Length];

            //for(int i=0;i<a.Length;i++)
            //{
            //    if (a[i] == 1)
            //    {
            //        for (int j = i; j >= 0; j--)
            //        {

            //            if (a[j] == 0)
            //                a[j] = 1;
            //            else
            //                a[j] = 0;


            //        }
            //    }
            //}


            //foreach (var b in a)
            //    Console.WriteLine(b);



            //int maxLength = 4;
            //string text = "...";

            //int count = 0; 
            //String abcd = new string(text.Where(c => !char.IsPunctuation(c)).ToArray()); 
            // String[] abc = abcd.Split(' ');



            //foreach (var a in abc)
            //{
            //    Console.WriteLine(a);
            //    if (a.Length <= maxLength)
            //        count++;

            //}
            //Console.WriteLine(count);





            //int[] votes = { 2, 3, 5, 2 };
            //int k = 0;
            //int count = 0;
            //int max = votes.Max();

            //int count2 = 0;
            //if (k == 0)
            //{
            //    foreach (var bc in votes)
            //        if (max == bc)
            //        {
            //            count2++;
            //        }

            //}
            //foreach (var a in votes)
            //    if (a + k > max)
            //        count++;
            //Console.WriteLine(count);




            //int number = 1234;
            //int width = 2;
            //String b = number.ToString();
            //char[] c = b.ToCharArray();
            //int len = c.Length;
            //if (len > width)
            //{

            //    int extra = len - width;
            //    for (int i = 0; i < extra; i++)
            //        c[i] = ' ';

            //    String final = new String(c);
            //    final = final.Trim();
            //    Console.WriteLine(final);

            //}
            //else
            //{
            //    string final = new string(c);
            //    int extra = width - len;
            //    for (int i = 0; i < extra; i++)
            //        final = "0" + final;

            //    Console.WriteLine(final);

            //}
            //foreach (var d in c)
            //    Console.WriteLine(d);



            //Console.WriteLine("hello");
            //try
            //{
            //    int a = 0, b = 1;
            //    int c = b / a;
            //    Console.WriteLine(c);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //try
            //{
            //    throw (new IndexOutOfRangeException("demo "));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}



            //char symbol = '5';



            //if ((int)symbol >= 48 && (int)symbol <= 57)
            //{
            //    int sym = int.Parse(symbol.ToString());
            //    if (sym % 2 == 0)
            //        Console.WriteLine("even");
            //    else
            //        Console.WriteLine("odd");
            //}
            //else
            //    Console.WriteLine("not a digit ");



            //String inputString = "name";

            //char[] inp = inputString.ToCharArray();
            //String abc = String.Empty;

            //foreach (var var in inp)
            //{
            //    int ascii = (int)var;
            //    int diff1 = System.Math.Abs(97 - ascii); 
            //    int diff2 = System.Math.Abs(25 - diff1);
            //    int sum = 97 + diff2;

            //    char res = (char) sum;

            //    abc += res;
            //}

            //Console.WriteLine(abc);



            //char number = 'A';

            //Dictionary<int,char> dict =new Dictionary<int, char>();
            //List<String> res = new List<string>();
            //string[] res3;

            //for (int i = 65; i <=90; i++)
            //{
            //    dict.Add(i,(char)i);
            //}

            //int flag = 0;
            //int val = 65;
            //int no = (int)number;

            //while (flag == 0)
            //{
            //    char val1 = (char) val;
            //    char val2 = (char) no;

            //    String res2 = val1.ToString() +" + "+val2.ToString();
            //    res.Add(res2);

            //    dict[val] = '0';
            //    dict[no] = '0';

            //    if (val < 90)
            //    {
            //        val++;
            //         res3 = res.ToArray();

            //    }

            //    if (no > 65)
            //    {
            //        no--;
            //        res3 = res.ToArray();

            //    }

            //    if (dict[val] == '0' || dict[no] == '0')
            //    {
            //        flag = 1;
            //    }
            //}


            //res3= res.ToArray();








            //String message = "thisisencryptedmessage";



            //char[] msg = message.ToArray();
            //int sum = 0;
            //List<char> res = new List<char>();

            //int charr = 97;

            //for (int i = 0; i < message.Length; i++)
            //{
            //    char letter = (char)message[i];
            //    int lettervalue = (int)letter - 97;
            //    sum += lettervalue;
            //    sum = sum % 26;
            //    char resvalue = (char)(sum + 97);
            //    res.Add(resvalue);
            //}


            //Console.WriteLine(res.ToArray());


            //String note = "you'll n4v4r 6u4ss 8t: cdja";

            //char[] note2 = note.ToCharArray();


            //for(int i=0;i<note2.Length;i++)
            //{
            //    int ascii = (int) note2[i];
            //    if (ascii >= 48 && ascii <= 57)
            //    {
            //        char charr = (char)(note2[i]+97);
            //        note2[i] = charr;
            //    }
            //}

            //Console.WriteLine(note2);


            //String ver1 = "10" , ver2 = "9";
            //int val1 = 0, val2 = 0;
            //int flag = 100;

            //for (int i = 0; i < ver1.Length; i++)
            //{
            //    if (ver1[i] == '.')
            //    {
            //        flag = flag / 10;
            //    }


            //    else
            //    {

            //        val1 += int.Parse(ver1[i].ToString()) * flag;
            //    }
            //}

            //Console.WriteLine(val1);


            //flag = 100;
            //for (int i = 0; i < ver2.Length; i++)
            //{
            //    if (ver2[i] == '.')
            //    {
            //        flag = flag / 10;
            //    }


            //    else
            //    {

            //        val2 += int.Parse(ver2[i].ToString()) * flag;
            //    }
            //}
            //Console.WriteLine(val2);




            //var myLis = new SortedDictionary<string, pm>(StringComparer.InvariantCultureIgnoreCase)
            //{
            //     { "cc",new pm("c",1994)},
            //    { "bb",new pm("b",1992)},
            //    { "aa",new pm("a",1990)}

            //};

            ////foreach (var li in myLis)
            ////{
            ////    Console.WriteLine(li);
            ////}

            ////pm one = myLis["bb"];
            ////Console.WriteLine(one.Name+"  "+one.Year);

            //myLis["bb"] = new pm("bbb", 1992);
            //myLis["dd"] = new pm("d", 1996);
            //myLis.Add("ee", new pm("e", 1998));

            //foreach (var li in myLis)
            //{
            //    Console.WriteLine(li);
            //}


            //// Console.WriteLine(myLis["CC"]);



            //var myLis2 = new ReadOnlyDictionary<string, pm>(myLis);



            //var myLis = new MyDictionary()
            //{
            //    {new pm("c",1994)},
            //    { new pm("b",1992)},
            //    {new pm("a",1990)}

            //};

            ////foreach (var li in myLis)
            ////{
            ////    Console.WriteLine(li);
            ////}

            ////pm one = myLis["bb"];
            ////Console.WriteLine(one.Name+"  "+one.Year);


            //myLis.Add( new pm("e", 1998));


            //foreach (var li in myLis)
            //{
            //    Console.WriteLine(li);
            //}


            // Console.WriteLine(myLis["CC"]);


            //var BigCities = new HashSet<String>(StringComparer.InvariantCultureIgnoreCase)
            //{
            //    "Delhi","Hyderabad","Mumbai","Bangalore","Chennai","Kolkatta"
            //};

            //HashSet<String> BigCities2 = BigCities; 


            //string[] cities = {"Calcutta",
            //    "Bangalore",
            //    "Hyderabad",
            //    "Chennai",
            //    "Delhi",
            //    "Ahmadabad" };

            ////BigCities2.IntersectWith(cities);
            ////BigCities2.UnionWith(cities);
            ////BigCities2.SymmetricExceptWith(cities);
            ////BigCities2.ExceptWith(cities);

            //foreach (var VARIABLE in BigCities2)
            //{
            //    Console.WriteLine(VARIABLE);
            //}




            //List<int> abc = new List<int>();
            //abc.Add(1);
            //abc.Add(2);
            //abc.Add(3);
            //abc.Add(4);

            //IEnumerator enumerator = abc.GetEnumerator();
            //bool moreitems = enumerator.MoveNext();

            //while (moreitems)
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //    moreitems = enumerator.MoveNext();
            //}



            //var abcd = new List<char>{'d','e','f' };
            //DisplayEnumerator(abcd);


            //IEnumerator enumerator2 = abcd.GetEnumerator();

            //bool next = enumerator2.MoveNext();
            //while (next)
            //{
            //    var item = enumerator2.Current;
            //    Console.WriteLine(item);
            //    next = enumerator2.MoveNext();
            //}


            //foreach (var value in abcd)
            //{
            //    abcd[1] = 'a';
            //    Console.WriteLine(value);
            //}

            //for (int i = 0; i < abcd.Count; i++)
            //{
            //    abcd[2] = 'a';
            //    Console.WriteLine(abcd[i]);
            //}


            // var a = new List<Demo>();

            // Demo d1 = new Demo() {id = 1, name = "a"};
            // Demo d2 = new Demo() { id = 2, name = "ab" };

            // a.Add(d1);
            // a.Add(d2);

            // IEnumerator<Demo> enumerator2 = a.GetEnumerator();

            // bool next = enumerator2.MoveNext();
            // while (next)
            // {
            //     var value = enumerator2.Current;
            //     Console.WriteLine(value.id +" " + value.name);
            //     next = enumerator2.MoveNext();
            // }
            //enumerator2.Dispose();



            //String cipher = "10197115121";
            //String res = String.Empty;

            //string temp = String.Empty;
            //for(int i=0;i<cipher.Length;i++)
            //{
            //    temp += cipher[i];
            //    int tno = int.Parse(temp);
            //    if (tno >= 97 && tno <= 122)
            //    {
            //        res += (char) tno;
            //        temp = String.Empty;

            //    }
            //}


            //String s1 = "x11y012", s2 = "x011y13";

            //int z1 = 0, z2 = 0;
            //var s11 = new List<String>();
            //var s22 = new List<String>();
            //String temp1 = String.Empty;
            //String temp2 = String.Empty;
            //int val1 = 0, val2 = 0;
            //foreach (var var1 in s1)
            //{
            //    if ((int)var1 >= 48 && (int)var1 <= 57)
            //    {
            //        temp1 += var1;
            //    }
            //    else
            //    {
            //        if (temp1 != String.Empty)
            //        {
            //            s11.Add(temp1);
            //            temp1 = String.Empty;
            //        }

            //        s11.Add(var1.ToString());
            //    }
            //}
            //if (temp1 != String.Empty)
            //    s11.Add(temp1);

            //foreach (var var1 in s2)
            //{
            //    if ((int)var1 >= 48 && (int)var1 <= 57)
            //    {
            //        temp2 += var1;
            //    }
            //    else
            //    {
            //        if (temp2 != String.Empty)
            //        {
            //            s22.Add(temp2);
            //            temp2 = string.Empty;
            //        }

            //        s22.Add(var1.ToString());


            //    }
            //}
            //if (temp2 != String.Empty)
            //    s22.Add(temp2);



            //foreach (var var1 in s11)
            //{
            //    if (var1.Length == 1)
            //    {
            //        char[] c = var1.ToCharArray();
            //        int asc = (int)c[0];
            //        if (asc >= 97 && asc <= 122)
            //            val1 += asc;
            //        else
            //        {
            //            val1 += int.Parse(var1);

            //        }

            //    }
            //    else
            //    {
            //        val1 += int.Parse(var1);
            //    }

            //}

            //foreach (var var2 in s22)
            //{
            //    if (var2.Length == 1)
            //    {
            //        char[] c = var2.ToCharArray();
            //        int asc = (int)c[0];
            //        if (asc >= 97 && asc <= 122)
            //            val2 += asc;
            //        else
            //        {
            //            val2 += int.Parse(var2);

            //        }

            //    }
            //    else
            //    {
            //        val2 += int.Parse(var2);
            //    }

            //}


            //if (val1 < val2)
            //{
            //    //return true;
            //    Console.WriteLine("true");
            //}
            //else if (val1 > val2)
            //{
            //    //return false ;
            //    Console.WriteLine("false");
            //}

            //else
            //{
            //    z1 = s1.Split('0').Length - 1;
            //    z2 = s2.Split('0').Length - 1;

            //    if (z1 > z2)
            //    {
            //        //return true;
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        //return false ;
            //        Console.WriteLine("false");
            //    }
            //}



            //int [,] myarray  = new int[3,3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        myarray[i, j] = i + j;
            //    }
            //}






            //int[][] myarray2 = new int[3][];

            //for (int i = 0; i < 3; i++)
            //{
            //     myarray2[i] = new int[3];
            //    for (int j = 0; j < 3; j++)
            //    {
            //        myarray2[i][j] = i + j;
            //    }
            //}




            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(myarray2[i][j] + " ");
            //    }
            //    Console.WriteLine("");
            //}




            //string inputString = "aaabbc";

            //int count = 0;
            //char[] inputString2 = inputString.ToCharArray();

            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    char ch = inputString2[i];
            //    string temp = new string(inputString2);

            //    int count2 = temp.Split(ch).Length - 1;

            //    if (count2 % 2 == 0 && count2 > 1)
            //    {
            //        for (int j = 0; j < inputString.Length; j++)
            //        {
            //            if (inputString2[j] == ch)
            //                inputString2[j] = ' ';
            //        }
            //    }
            //    else if (count2 > 1)
            //    {
            //        int j = 0;
            //        while (count2 != 1 && j < inputString2.Length)
            //        {
            //            if (inputString2[j] == ch)
            //            {
            //                inputString2[j] = ' ';
            //                count2--;
            //            }
            //            j++;
            //        }
            //    }
            //}


            //foreach (var vari in inputString2)
            //{
            //    if (vari != ' ')
            //        count++;
            //}

            //if (count < 2)
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");




            //int[] inputArray = {10,11,13};
            //int max = 0;


            //for (int i = 0; i < inputArray.Length - 1; i++)
            //{
            //    if (System.Math.Abs(inputArray[i] - inputArray[i + 1] )> max)
            //        max = System.Math.Abs(inputArray[i] - inputArray[i + 1]);

            //}

            //int a = System.Math.Abs(-1);




            //string inputString = "172.316.254.1";

            //int count = 0;
            //string[] temp = inputString.Split('.');

            //if (temp.Length == 4)
            //{
            //    foreach (var s in temp)
            //    {
            //        int s1;
            //        bool res = int.TryParse(s, out s1);
            //        if (res)
            //        {
            //            if (s1 > 0 && s1 < 256)
            //            {
            //                count++;
            //            }
            //        }

            //    }
            //}



            //Square square = new Square(10);
            //Console.WriteLine("Perimeter is : " +square.CalculatePerimeter());
            //Console.WriteLine("Area is : " + square.CalculateArea());




            //int n = 642386;
            //char[] temp = n.ToString().ToCharArray();

            //foreach (var i in temp)
            //{
            //    if (i % 2 != 0)
            //        return false;
            //}

            //string inputString = "z";

            //char[] temp = inputString.ToCharArray();

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    int a = (int) temp[i];
            //    if (a == 122)
            //        a = 97;
            //    else
            //    {
            //        a++;

            //    }
            //    temp[i] = (char)a;
            //}

            //string res = new string(temp);
            //Console.WriteLine(res);


            //string cell1="A1",  cell2="C3";

            //char[] t1 = cell1.ToCharArray();
            //char[] t2 = cell2.ToCharArray();

            //int a1 = (int) t1[0];
            //int a2 = (int)t2[0];

            //int v1 = (a1 + t1[1]) % 2, v2 = (a2 + t2[1]) % 2;
            //if ((a1+t1[1] %2 )== (a2 + t2[1] % 2))
            //{ }


            //int n = 6, firstNumber = 3;

            //int half = n / 2;

            //if (half + firstNumber > n)
            //{
            //    int d = n - (half + firstNumber);

            //}


            //else
            //{

            //}


            //int deposit=100,  rate=20,  threshold=170;

            //int count = 0;
            //int tot = deposit;
            //int addition = (rate * tot) / 100;

            //while (tot < threshold)
            //{
            //    tot += addition;
            //    count++;
            //    addition = (rate * tot) / 100;
            //}


            //int[] a = {2, 4, 7};

            //int min = int.MaxValue;
            //int val;
            //foreach (var i in a )
            //{
            //    int temp = 0;
            //    foreach (var i1 in a)
            //    {
            //        temp += System.Math.Abs(i1 - i);
            //    }

            //    if (min > temp)
            //    {
            //        min = temp;
            //        val = i;
            //    }
            //}


            //string[] inputArray = { "aba", "bbb", "bab" };
            //Array.Sort(inputArray);
            //int[] ascii = new int[inputArray.Length];
            //int j = 0;
            //int flag = 0;
            //foreach (var i in inputArray)
            //{
            //    char[] temp = i.ToCharArray();
            //    int val = 0;
            //    foreach (var i2 in temp)
            //    {
            //        val += (int)i2;
            //    }
            //    ascii[j] = val;
            //    j++;
            //}

            //Array.Sort(ascii);

            //for (int i = 0; i < ascii.Length - 1; i++)
            //{

            //    if (ascii[i] != ascii[i + 1] - 1)
            //        flag = 1;

            //}



            //int[] inputArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //var res = new List<int>();
            //int k =3
            //int i = 1;
            //foreach (var i1 in inputArray)
            //{
            //    if (i % k != 0)
            //        res.Add(i1);
            //    i++;
            //}



            //String inputString = "var_1__Int";

            //foreach (var i in inputString)
            //{
            //    int aa;
            //    bool a = int.TryParse(i.ToString(), out aa);
            //    if (a == true)
            //    { }
            //}

            // String s = "cabca";


            //Dictionary<int,char> a = new Dictionary<int ,char>();

            //foreach (var i in s)
            //{
            //    int ascii = (int)i;
            //    a[ascii] = i;
            //}


            //int[] inputArray = {1,3,2,4};
            //int k = 3;
            //int max = 0;
            //int j , sum = 0,l;
            //for (int i = 0; i < inputArray.Length-(k-1); i++)
            //{
            //    j = 0;
            //    l = i;
            //    while (j <k)
            //    {
            //        sum += inputArray[l];
            //        l++;
            //        j++;
            //    }

            //    if (sum > max)
            //        max = sum;

            //    sum = 0;
            //}


            //IExplicit i1 = new ExplicitImplementation();
            //i1.A();

            //IExplicit2 i2 = new ExplicitImplementation();
            //i2.A();


            //IExplicit3 i3 = new Implementation2();
            //i3.A();
            //i3.C();


            //GrowingPlant g2 = new GrowingPlant();
            //Console.WriteLine(g2.growingPlant(10,9,4));


            //KnapsackLight k1 = new KnapsackLight();
            //Console.WriteLine(k1.knapsackLight(15,2,20,3,2));

            //LongestDigitsPrefix obj = new LongestDigitsPrefix();
            //Console.WriteLine(obj.longestDigitsPrefix(" 324"));

            //DigitDegree d1 = new DigitDegree();
            //Console.WriteLine(d1.digitDegree(91));

            //BishopAndPawn bishopAndPawn = new BishopAndPawn();
            //Console.WriteLine(bishopAndPawn.bishopAndPawn("a5","c3"));

            //IsBeautifulString isBeautifulString = new IsBeautifulString();
            //Console.WriteLine(isBeautifulString.isBeautifulString("zaa"));

            //BuildPalindrome buildPalindrome = new BuildPalindrome();
            //Console.WriteLine(buildPalindrome.buildPalindrome("abcdc"));


            //string[] data = System.IO.File.ReadAllLines("D:/demo.txt");
            //string[] res = new string[3];
            //string[,] res2 = new string[3,3];

            //for(int i =0;i<3;i++)
            //{
            //    res = data[i].Split(',');
            //    for (int j = 0; j < 3; j++)
            //    {
            //        res2[i, j] = res[j];
            //    }
            //}


            //LineEncoding lineEncoding = new LineEncoding();
            //Console.WriteLine(lineEncoding.lineEncoding("aabbbc"));

            //ChessKnight chessKnight = new ChessKnight();
            //Console.WriteLine(chessKnight.chessKnight("g6".ToUpper()));

            //DeleteDigit deleteDigit = new DeleteDigit();
            //Console.WriteLine(deleteDigit.deleteDigit(152));

            //LongestWord longestWord = new LongestWord();
            //Console.WriteLine(longestWord.longestWord("A!! AA[]z"));
            // Console.WriteLine(longestWord.validTime("25:20"));

            //int[] a = { 1,2,3,4,5,9,8 };
            //Sorting obj = new Sorting();
            //obj.BubbleSort(a);

            //SumUpNumbers sumUpNumbers = new SumUpNumbers();
            //Console.WriteLine(sumUpNumbers.sumUpNumbers("1$$2 a,3;s 4"));

            //DigitsProduct digitsProduct = new DigitsProduct();
            //Console.WriteLine(digitsProduct.digitsProduct(0));

            //FileNaming naming = new FileNaming();
            //string[] a = {"doc", "doc", "image", "doc(1)", "doc"};
            //naming.fileNaming(a);


            //MessageFromBinaryCode binaryCode =  new MessageFromBinaryCode();
            //Console.WriteLine(binaryCode.messageFromBinaryCode("010010000110010101101100011011000110111100100001"));

            //Sudoku sudoku = new Sudoku();
            //int[][] jaggedArray3 =
            //{
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5},
            //    new int[] {5,5,5,5,5,5,5,5,5}

            //};

            //AlphanumericLess alphanumericLess = new AlphanumericLess();
            //AlphanumericLess2 alphanumericLess = new AlphanumericLess2();
            //Console.WriteLine(alphanumericLess.alphanumericLess("x11y012", "x011y13"));


            //RoadRegister roadRegister = new RoadRegister();

            //bool[][] jaggedArray3 =
            //{
            //    new bool[] {false, true,  false},
            //    new bool[] {false, false, false},
            //    new bool[] { true, false, false }
            //};

            //roadRegister.newRoadSystem(jaggedArray3);


            //RoadsBuilding roadsBuilding = new RoadsBuilding();
            //int[][] jaggedArray3 = new int[1][];


            //roadsBuilding.roadsBuilding(1,jaggedArray3);


            EfficientRoadNetwork efficientRoadNetwork = new EfficientRoadNetwork();
            //int[][] jaggedArray3 =
            //{
            //    new int[] {3,0},
            //    new int[] {0,4},
            //    new int[] {5,0},
            //    new int[] {2,1},
            //    new int[] {1,4},
            //    new int[] {2,3},
            //    new int[] {5,2}

            //};

            //int[][] jaggedArray3 =
            //{

            //};
            //Console.WriteLine(efficientRoadNetwork.efficientRoadNetwork(6,jaggedArray3));

            //FinancialCrisis financialCrisis = new FinancialCrisis();

            //bool[][] jaggedArray3 =
            //{
            //    new bool[] {false, true, true, false},
            //    new bool[] {true, false, true, false},
            //    new bool[] { true, true, false,true },
            //    new bool[] { false, false, true, false }
            //};
            //financialCrisis.financialCrisis(jaggedArray3);

            // NamingRoads naming= new NamingRoads();

            // int[][] jaggedArray3 =
            //{
            //         new int[] {0,1,0},
            //         new int[] {4,1,2},
            //         new int[] {4,3,4},
            //         new int[] {2,3,1},
            //         new int[] {2,0,3}
            // };
            // Console.WriteLine(naming.namingRoads(jaggedArray3));

            //GreatRenaming greatRenaming = new GreatRenaming();
            //bool[][] jaggedArray3 =
            //{
            //    new bool[] {false, true, true, false},
            //    new bool[] {true, false, true, false},
            //    new bool[] { true, true, false,true },
            //    new bool[] { false, false, true, false }
            //};
            //greatRenaming.greatRenaming(jaggedArray3);

            // CitiesConquering cities = new CitiesConquering();

            // int[][] jaggedArray3 =
            //{
            //          new int[] {1,0},
            //          new int[] {1,2},
            //          new int[] {8,5},
            //          new int[] {9,7},
            //          new int[] {5,6},
            //    new int[] {5,4},
            //    new int[] {4,6},
            //    new int[] {6,7}
            //  };
            // cities.citiesConquering(10, jaggedArray3);


            //Demo2 d2 = new Demo2();
            ////Console.WriteLine(d2.demo());
            //d2.demo2();

            //NamesScores namesScores = new NamesScores();
            //namesScores.demo2();

            //FibonacciNumber f = new FibonacciNumber();
            //  f.generate();

            //DistinctPowers dis = new DistinctPowers();
            //dis.demo();



            //var no = new NumberSpiralDiagonals();
            //no.demo();


            //string str = "0123456789";
            //char[] arr = str.ToCharArray();
            //Program2.GetPer(arr);
            //Program2.print();


            //HighlyDivisibleTriangularNumber number = new HighlyDivisibleTriangularNumber();
            //number.demo();

            //LargeSum s = new LargeSum();
            //s.calculate();



            //AmicableNumbers numbers = new AmicableNumbers();
            //numbers.demo();


            //FifthPowers f= new FifthPowers();
            //f.Cal();

            //PanDigital p = new PanDigital();
            //p.demo();

            //DigitCancellingFractions d2 = new DigitCancellingFractions();
            //d2.Demo();

            //DigitFactorial d2 = new DigitFactorial();
            //d2.Demo();

            //CircularPrimes cp = new CircularPrimes();
            //cp.demo();

            //var d = new DoubleBasePalindromes();
            //d.demo();

            //var t = new TruncatablePrimes();
            //t.demo();


            //var i = new IntegerRightTriangles();
            //i.demo();

            //var c = new ChampernownesConstant();
            //c.demo();

            //var p = new PandigitalPrime();
            //p.demo();

            //var c = new CodedTriangleNumbers();
            //c.demo();

            //var s = new SubStringDivisibility();
            //s.demo();

            //var p = new PentagonNumbers();
            //p.demo();

            //var t = new TriangularPentagonalHexagonal();
            //t.demo();

            //var d = new DistinctPrimesFactors();
            //d.demo();

            //var s = new SelfPowers();
            //s.demo();

            //var a = new ArrayConversion();
            //int[] temp = {1, 2, 3, 4, 5, 6, 7, 8};
            //a.arrayConversion(temp);

            //var a = new ArrayPreviousLess();
            //int[] items = {3, 5, 2, 4, 5};
            //a.arrayPreviousLess(items);

            //var p = new PairOfShoes();
            //int[][] jaggedArray3 =
            //    {
            //              new int[] {0,21},
            //              new int[] {1,23},
            //              new int[] {1,21},
            //              new int[] {0,23}

            //      };

            //Console.WriteLine(p.pairOfShoes(jaggedArray3));

            //var s = new StringsCrossOver();
            //Console.WriteLine(s.stringsCrossover(new string[] {"a", "b", "c", "d", "e"}, "c"));

            //var r = new BeautifulText();
            //string s = "skspv iakqh ygzwz ntkmi xqhpj";
            //int l = 5, rr= 15;
            //Console.WriteLine(r.beautifulText(s, 3, 7));

            //var p = new PermutedMultiples();
            //p.Demo();

            //var l = new LychrelNumbers();
            //l.demo();

            //var p = new PowerfullDigitSum();
            //p.Demo();

            //var r = new  ReverseOnDiagonals();
            //int[][] jaggedArray3 =
            //        {
            //                  new int[] {1,2,3},
            //                  new int[] {4,5,6},
            //                  new int[] {7,8,9}

            //          };
            //r.reverseOnDiagonals(jaggedArray3);

            //var c = new CyclicalFigurateNumbers();
            //Console.WriteLine(c.isHeptagonal(1404));

            //var cc = new CubicPermutations();
            //cc.demo();
       


            //var v = new VolleyballPositions();
            //string[][] t = new string[][]
            //{
            //    new string[]{"empty",   "Player5", "empty"},
            //    new string[]{"Player4", "empty",   "Player2"},
            //    new string[]{"empty", "Player3", "empty"},
            //    new string[]{ "Player6", "empty",   "Player1"},
            //};

            // v.volleyballPositions(t, 10);

            var l = new LargestExponential();
            l.demo();


            //var p = new PrimeGeneratingIntegers();
            //p.demo();

            Console.ReadKey();
        }







        //static void plusMinus(int[] arr, int n)
        //{
        //    // Complete this function
        //    float p = 0, m = 0, z = 0;
        //    float p1, m1, z1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i] > 0)
        //            p++;
        //        else if (arr[i] < 0)
        //            m++;
        //        else
        //            z++;

        //    }

        //    p1 = p / n; m1 = m / n; z1 = z / n;
        //    Console.WriteLine((p1) + "");
        //    Console.WriteLine((m1) + "");
        //    Console.WriteLine((z1) + "");



        //}

        public static void DisplayEnumerator<T>(IEnumerable<T> coll)
        {

            using (IEnumerator<T> enumerator = coll.GetEnumerator())
            {
                bool next = enumerator.MoveNext();
                while (next)
                {
                    var value = enumerator.Current;
                    next = enumerator.MoveNext();
                    Console.WriteLine(value);
                }
            }




        }

        //public static void add(int a,int b)
        //{
        //    int c = a+b;
        //    Console.WriteLine(c + "");
        //}
        //public static void B(int a, int b)
        //{
        //    //int c = a + b;
        //    Console.WriteLine("c" );
        //}
        //public static void C(int a, int b)
        //{
        //    int c = a + b; Console.WriteLine("c");
        //}
        //public static void D(demo_delegate d)
        //{
        //    d(2,4);
        //}





    }
    class MyDictionary : KeyedCollection<int, pm>
    {
        protected override int GetKeyForItem(pm item)
        {
            return item.Year;
        }
    }
    public class Demo
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    class B
    {



        /*public B()
        {
            obj = new C();
            obj.Event1 += Handler;
        }*/





        public void Handler()
        {
            Console.WriteLine("handler");
        }


    }
    class C
    {
        public delegate void demo_delegate();
        public event demo_delegate Event1;

        B obj = new B();


        public void Print()
        {
            Event1 += obj.Handler;
            if (Event1 != null)
            {

                Console.WriteLine("In print method in C class");

                Event1();
            }
        }
    }









}
