



        //    string s = "Sun 10:00-11:00\nFri 05:00-10:00\nFri 16:30-23:50\nSat 10:00-24:00\nSun 01:00-04:00\nSat 02:00-06:00\nTue 03:30-18:15\nTue 19:00-20:00\nWed 04:25-15:14\nWed 15:14-22:40\nThu 00:00-23:59\nMon 05:00-13:00\nMon 15:00-21:00";

        //    List<string> dayIndex = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        //    List<string> schedules = s.Split('\n').ToList();

        //    List<TimeStore> timeStores = new List<TimeStore>();

        //    foreach (var item in schedules)
        //    {
        //        var day = item.Substring(0, 3);


        //        TimeSpan minTime = new TimeSpan(int.Parse(item.Substring(4, 2)),
        //                               int.Parse(item.Substring(7, 2)),
        //                               0);
        //        TimeSpan maxTime = new TimeSpan(int.Parse(item.Substring(10, 2)),
        //                               int.Parse(item.Substring(13, 2)),
        //                               0);

        //        var timeStore = new TimeStore(day, minTime, maxTime);
        //        timeStores.Add(timeStore);
        //    }


        //    timeStores = timeStores.OrderBy(e => dayIndex.IndexOf(e.Day)).ThenBy(e => e.MinTime).ToList();

        //    double maxMinutes = 0;

        //    for (int i = 0; i < timeStores.Count - 1; i++)
        //    {
        //        var min = 0.0;
        //        var max = 0.0;
        //        var finalTemp = 0.0;

        //        if(i+1 == timeStores.Count -1)
        //        {
        //            min = timeStores[i + 1].MaxTime.TotalMinutes;

        //            max = timeStores[0].MinTime.TotalMinutes;

        //            finalTemp = max - min < 0
        //            ? max + (24 * 60) - min
        //            : max - min;
        //        }

        //        min = timeStores[i].MaxTime.TotalMinutes;

        //        max = timeStores[i + 1].MinTime.TotalMinutes;

        //        double temp = max - min < 0
        //            ? max + (24 * 60) - min
        //            : max- min;

        //        if (temp > maxMinutes) maxMinutes = temp;
        //        if (finalTemp > maxMinutes) maxMinutes = finalTemp;
        //    }

        //    Console.WriteLine(maxMinutes);
