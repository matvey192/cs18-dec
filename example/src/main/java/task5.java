import org.joda.time.*;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

import java.util.*;

public class task5 {
    public static void main(String[] args) {
        DateTimeFormatter work = DateTimeFormat.forPattern("dd,MM");

        // ввод первой даты
        Scanner vvod = new Scanner(System.in);
        String vod = vvod.nextLine();
        DateTime vod1 = work.parseDateTime(vod);

        // ввод второй даты
        Scanner vvod1 = new Scanner(System.in);
        String vvod12 = vvod1.nextLine();
        DateTime vod12 = work.parseDateTime(vvod12);

        Duration difff = new Duration(vod1,vod12);
        long dif = difff.getStandardDays();

        // номер месяца и дня в нём
        int month = vod1.getMonthOfYear();
        int days = vod1.getDayOfMonth();

        int days1 = vod12.getDayOfMonth();

        int[] jan = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 19, 20, 26, 27}; //1
        int[] feb = new int[]{2, 3, 9, 10, 16, 17, 23, 24}; //2
        int[] march = new int[]{2, 3, 8, 9, 10, 16, 17, 23, 24, 30, 31}; //3
        int[] apr = new int[]{6, 7, 13, 14, 20, 21, 27, 28}; //4
        int[] may = new int[]{1, 2, 3, 4, 5, 9, 10, 11, 12, 18, 19, 25, 26}; //5
        int[] june = new int[]{1, 2, 8, 9, 12, 15, 16, 22, 23, 29, 30}; //6
        int[] july = new int[]{6, 7, 13, 14, 20, 21, 27, 28}; //7
        int[] aug = new int[]{3, 4, 10, 11, 17, 18, 24, 25, 31}; //8
        int[] sep = new int[]{1, 7, 8, 14, 15, 21, 22, 28, 29}; //9
        int[] okt = new int[]{5, 6, 12, 13, 19, 20, 26, 27}; //10
        int[] nov = new int[]{2, 3, 4, 9, 10, 16, 17, 23, 24, 30}; //11
        int[] dec = new int[]{1, 7, 8, 14, 15, 21, 22, 28, 29}; //12

        long res = 0; // ответ

        int i1 = 0;
        int work1 = 0; // выходные
        while (days!=days1)
        {
            if(month==1)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < jan.length)
                {
                    if (days == jan[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==2)
            {
                if (days>28)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < feb.length)
                {
                    if (days == feb[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==3)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < march.length)
                {
                    if (days == march[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==4)
            {
                if (days>30)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < apr.length)
                {
                    if (days == apr[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==5)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < may.length)
                {
                    if (days == may[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==6)
            {
                if (days>30)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < june.length)
                {
                    if (days == june[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==7)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < july.length)
                {
                    if (days == july[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==8)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < aug.length)
                {
                    if (days == aug[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==9)
            {
                if (days>30)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < sep.length)
                {
                    if (days == sep[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==10)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < okt.length)
                {
                    if (days == okt[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==11)
            {
                if (days>30)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < nov.length)
                {
                    if (days == nov[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            else if(month==12)
            {
                if (days>31)
                {
                    month++;
                    days=1;
                    continue;
                }
                while (i1 < dec.length)
                {
                    if (days == dec[i1])
                    {
                        work1++;
                    }
                    i1++;
                }
            }
            i1=0;
            days++;
            res = dif- work1;
        }
        System.out.println("Рабочих дней "+res);
    }
}
    //  Промышленный календарь создать его и считывать из него вводит 2 даты посчитать кол-во рабочих дней с учётом календаря

