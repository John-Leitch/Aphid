
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "PT";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(37.52799 - lat) + Math.Abs(-8.78483 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.17768 - lat) + Math.Abs(-9.31702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7777 - lat) + Math.Abs(-7.41793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15489 - lat) + Math.Abs(-9.11512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65646 - lat) + Math.Abs(-7.6767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.195 - lat) + Math.Abs(-7.41766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72377 - lat) + Math.Abs(-8.78278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46081 - lat) + Math.Abs(-8.43588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95525 - lat) + Math.Abs(-8.98966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30904 - lat) + Math.Abs(-7.15378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08317 - lat) + Math.Abs(-8.91144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67604 - lat) + Math.Abs(-8.14577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17219 - lat) + Math.Abs(-8.76658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.05919 - lat) + Math.Abs(-16.33371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86945 - lat) + Math.Abs(-8.93238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20995 - lat) + Math.Abs(-7.8005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36886 - lat) + Math.Abs(-9.04916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33458 - lat) + Math.Abs(-8.0044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87206 - lat) + Math.Abs(-9.07805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55271 - lat) + Math.Abs(-8.9979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12696 - lat) + Math.Abs(-9.08423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67706 - lat) + Math.Abs(-8.45792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.92365 - lat) + Math.Abs(-9.23178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19052 - lat) + Math.Abs(-8.72735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.30569 - lat) + Math.Abs(-8.62876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.06969 - lat) + Math.Abs(-7.69849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58432 - lat) + Math.Abs(-9.0229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.2283 - lat) + Math.Abs(-7.39856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81958 - lat) + Math.Abs(-9.12007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46411 - lat) + Math.Abs(-8.97743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16592 - lat) + Math.Abs(-8.25919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09064 - lat) + Math.Abs(-7.97196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45 - lat) + Math.Abs(-8.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67222 - lat) + Math.Abs(-9.23268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09109 - lat) + Math.Abs(-9.2586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47581 - lat) + Math.Abs(-8.54348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60199 - lat) + Math.Abs(-8.40924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70647 - lat) + Math.Abs(-9.28693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12734 - lat) + Math.Abs(-7.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84867 - lat) + Math.Abs(-8.83506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64961 - lat) + Math.Abs(-9.18977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91703 - lat) + Math.Abs(-9.02656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01958 - lat) + Math.Abs(-9.15081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80097 - lat) + Math.Abs(-9.37826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95622 - lat) + Math.Abs(-8.86979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18921 - lat) + Math.Abs(-8.43822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.1112 - lat) + Math.Abs(-9.3643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44451 - lat) + Math.Abs(-9.10149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5244 - lat) + Math.Abs(-8.8882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80205 - lat) + Math.Abs(-8.09589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45461 - lat) + Math.Abs(-9.17819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33291 - lat) + Math.Abs(-9.26843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94581 - lat) + Math.Abs(-7.59754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08771 - lat) + Math.Abs(-8.72649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64008 - lat) + Math.Abs(-9.10141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.82322 - lat) + Math.Abs(-17.10941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68176 - lat) + Math.Abs(-8.98231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53449 - lat) + Math.Abs(-8.16119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34946 - lat) + Math.Abs(-8.62221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79673 - lat) + Math.Abs(-17.04323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51282 - lat) + Math.Abs(-8.70708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.66667 - lat) + Math.Abs(-16.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.06983 - lat) + Math.Abs(-9.37174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43333 - lat) + Math.Abs(-8.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10932 - lat) + Math.Abs(-7.85638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51444 - lat) + Math.Abs(-9.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.6448 - lat) + Math.Abs(-16.93843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.361 - lat) + Math.Abs(-8.37764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71556 - lat) + Math.Abs(-8.66472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32268 - lat) + Math.Abs(-7.31106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81667 - lat) + Math.Abs(-16.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93944 - lat) + Math.Abs(-9.01892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82378 - lat) + Math.Abs(-9.09719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87376 - lat) + Math.Abs(-9.39842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70194 - lat) + Math.Abs(-9.34083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07203 - lat) + Math.Abs(-7.9465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1531 - lat) + Math.Abs(-7.88751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25648 - lat) + Math.Abs(-8.28672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27511 - lat) + Math.Abs(-9.27885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.72246 - lat) + Math.Abs(-16.81991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62561 - lat) + Math.Abs(-9.03043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85151 - lat) + Math.Abs(-9.13975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05532 - lat) + Math.Abs(-8.24414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06078 - lat) + Math.Abs(-8.7822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01693 - lat) + Math.Abs(-8.69475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96891 - lat) + Math.Abs(-8.02664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23333 - lat) + Math.Abs(-8.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8 - lat) + Math.Abs(-16.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45 - lat) + Math.Abs(-8.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10224 - lat) + Math.Abs(-7.66202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8411 - lat) + Math.Abs(-9.09908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68806 - lat) + Math.Abs(-16.79388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97106 - lat) + Math.Abs(-7.872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6796 - lat) + Math.Abs(-8.68679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10619 - lat) + Math.Abs(-7.96648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72035 - lat) + Math.Abs(-9.00471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93709 - lat) + Math.Abs(-8.87178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02788 - lat) + Math.Abs(-8.7935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93771 - lat) + Math.Abs(-7.77448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43186 - lat) + Math.Abs(-9.09479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00864 - lat) + Math.Abs(-8.94311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79202 - lat) + Math.Abs(-9.10801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67734 - lat) + Math.Abs(-9.00836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33732 - lat) + Math.Abs(-8.93906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76613 - lat) + Math.Abs(-9.32804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67483 - lat) + Math.Abs(-17.06288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44472 - lat) + Math.Abs(-8.5142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42529 - lat) + Math.Abs(-7.53494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29801 - lat) + Math.Abs(-7.39234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64872 - lat) + Math.Abs(-7.54708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80368 - lat) + Math.Abs(-9.1877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56753 - lat) + Math.Abs(-8.94228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75657 - lat) + Math.Abs(-9.25451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71925 - lat) + Math.Abs(-9.26255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06946 - lat) + Math.Abs(-8.10064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7522 - lat) + Math.Abs(-7.9239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75104 - lat) + Math.Abs(-17.20433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46667 - lat) + Math.Abs(-8.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67459 - lat) + Math.Abs(-9.16981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51046 - lat) + Math.Abs(-7.51765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8 - lat) + Math.Abs(-9.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86101 - lat) + Math.Abs(-9.06453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72293 - lat) + Math.Abs(-9.30473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.86681 - lat) + Math.Abs(-17.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60191 - lat) + Math.Abs(-8.81839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76667 - lat) + Math.Abs(-16.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85256 - lat) + Math.Abs(-8.79018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13856 - lat) + Math.Abs(-8.53775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30697 - lat) + Math.Abs(-7.70244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29379 - lat) + Math.Abs(-7.43122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12665 - lat) + Math.Abs(-8.40162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76771 - lat) + Math.Abs(-9.19935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14945 - lat) + Math.Abs(-8.8388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24964 - lat) + Math.Abs(-8.01009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.6798 - lat) + Math.Abs(-17.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81137 - lat) + Math.Abs(-17.24862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91674 - lat) + Math.Abs(-8.62847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83095 - lat) + Math.Abs(-8.79365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39212 - lat) + Math.Abs(-8.4341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63106 - lat) + Math.Abs(-8.91376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67005 - lat) + Math.Abs(-9.15852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85783 - lat) + Math.Abs(-9.32352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04345 - lat) + Math.Abs(-9.11099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12296 - lat) + Math.Abs(-8.34115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3558 - lat) + Math.Abs(-9.38112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98477 - lat) + Math.Abs(-7.91651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46146 - lat) + Math.Abs(-8.14955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91835 - lat) + Math.Abs(-8.1459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75898 - lat) + Math.Abs(-17.23025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66978 - lat) + Math.Abs(-8.9958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69282 - lat) + Math.Abs(-9.35412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13827 - lat) + Math.Abs(-8.51703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56902 - lat) + Math.Abs(-8.90126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56399 - lat) + Math.Abs(-8.46835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17935 - lat) + Math.Abs(-8.2015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69569 - lat) + Math.Abs(-9.29143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.6539 - lat) + Math.Abs(-8.22569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64167 - lat) + Math.Abs(-8.5919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.11199 - lat) + Math.Abs(-8.99105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79079 - lat) + Math.Abs(-9.16621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76994 - lat) + Math.Abs(-9.10674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09024 - lat) + Math.Abs(-8.19168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0286 - lat) + Math.Abs(-7.8411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91893 - lat) + Math.Abs(-7.9137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69105 - lat) + Math.Abs(-9.31085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79269 - lat) + Math.Abs(-9.1838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59798 - lat) + Math.Abs(-8.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36055 - lat) + Math.Abs(-9.1567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.66667 - lat) + Math.Abs(-16.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51499 - lat) + Math.Abs(-7.64908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0227 - lat) + Math.Abs(-7.81344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60289 - lat) + Math.Abs(-9.06836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41927 - lat) + Math.Abs(-9.19091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38356 - lat) + Math.Abs(-7.34189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1401 - lat) + Math.Abs(-7.44856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77929 - lat) + Math.Abs(-9.10222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94351 - lat) + Math.Abs(-8.16434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70675 - lat) + Math.Abs(-8.97388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8993 - lat) + Math.Abs(-8.83171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8521 - lat) + Math.Abs(-8.86349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64812 - lat) + Math.Abs(-8.21455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18192 - lat) + Math.Abs(-7.45225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70636 - lat) + Math.Abs(-9.40595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07771 - lat) + Math.Abs(-8.17044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48333 - lat) + Math.Abs(-8.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48333 - lat) + Math.Abs(-8.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46203 - lat) + Math.Abs(-8.7118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05318 - lat) + Math.Abs(-7.43689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31775 - lat) + Math.Abs(-8.55529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0836 - lat) + Math.Abs(-7.78763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02405 - lat) + Math.Abs(-8.03778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24825 - lat) + Math.Abs(-9.22355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65078 - lat) + Math.Abs(-8.99038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54315 - lat) + Math.Abs(-8.71505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51631 - lat) + Math.Abs(-8.68799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67322 - lat) + Math.Abs(-7.49765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94732 - lat) + Math.Abs(-9.19914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15858 - lat) + Math.Abs(-8.61487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64304 - lat) + Math.Abs(-7.6611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79443 - lat) + Math.Abs(-9.34284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08178 - lat) + Math.Abs(-9.03459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75279 - lat) + Math.Abs(-9.2811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39377 - lat) + Math.Abs(-7.37663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53622 - lat) + Math.Abs(-8.3118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31014 - lat) + Math.Abs(-8.66813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.0473 - lat) + Math.Abs(-8.70236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74769 - lat) + Math.Abs(-8.93228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16849 - lat) + Math.Abs(-7.51804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93213 - lat) + Math.Abs(-9.25779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93793 - lat) + Math.Abs(-9.32756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7007 - lat) + Math.Abs(-17.13542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57133 - lat) + Math.Abs(-8.44635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7162 - lat) + Math.Abs(-16.76758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68853 - lat) + Math.Abs(-8.89423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55573 - lat) + Math.Abs(-7.99421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09216 - lat) + Math.Abs(-7.70433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67984 - lat) + Math.Abs(-17.08657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24166 - lat) + Math.Abs(-9.31254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0039 - lat) + Math.Abs(-8.73736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83091 - lat) + Math.Abs(-9.16845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13772 - lat) + Math.Abs(-8.01968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71667 - lat) + Math.Abs(-9.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71446 - lat) + Math.Abs(-9.2422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74362 - lat) + Math.Abs(-8.80705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66808 - lat) + Math.Abs(-9.05204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06799 - lat) + Math.Abs(-7.8078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65599 - lat) + Math.Abs(-9.15376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10202 - lat) + Math.Abs(-8.67422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13535 - lat) + Math.Abs(-8.45319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92316 - lat) + Math.Abs(-7.24082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12959 - lat) + Math.Abs(-8.29963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17718 - lat) + Math.Abs(-8.56675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40474 - lat) + Math.Abs(-8.48625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46443 - lat) + Math.Abs(-7.93449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4108 - lat) + Math.Abs(-7.68365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05429 - lat) + Math.Abs(-7.74699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.66568 - lat) + Math.Abs(-16.92547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05629 - lat) + Math.Abs(-7.64868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43672 - lat) + Math.Abs(-9.21374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32494 - lat) + Math.Abs(-7.50057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60674 - lat) + Math.Abs(-8.23137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.84806 - lat) + Math.Abs(-9.43942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90413 - lat) + Math.Abs(-8.27511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36398 - lat) + Math.Abs(-9.31541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12926 - lat) + Math.Abs(-8.23759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69406 - lat) + Math.Abs(-8.29213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05 - lat) + Math.Abs(-8.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12474 - lat) + Math.Abs(-8.51915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17553 - lat) + Math.Abs(-8.56927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62071 - lat) + Math.Abs(-8.65237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14888 - lat) + Math.Abs(-7.94173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01869 - lat) + Math.Abs(-7.92716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78804 - lat) + Math.Abs(-9.21033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53642 - lat) + Math.Abs(-9.08308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77457 - lat) + Math.Abs(-17.23412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.78333 - lat) + Math.Abs(-16.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56667 - lat) + Math.Abs(-7.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.84432 - lat) + Math.Abs(-7.58585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73704 - lat) + Math.Abs(-17.18674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70571 - lat) + Math.Abs(-9.39773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14629 - lat) + Math.Abs(-8.48505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09503 - lat) + Math.Abs(-7.89445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.96275 - lat) + Math.Abs(-9.41563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46667 - lat) + Math.Abs(-8.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8815 - lat) + Math.Abs(-7.16282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.72029 - lat) + Math.Abs(-16.96993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16544 - lat) + Math.Abs(-7.8924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64458 - lat) + Math.Abs(-9.23556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95955 - lat) + Math.Abs(-8.52524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64004 - lat) + Math.Abs(-9.1508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47796 - lat) + Math.Abs(-8.33636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14789 - lat) + Math.Abs(-7.60426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38059 - lat) + Math.Abs(-8.78608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39997 - lat) + Math.Abs(-7.78112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79921 - lat) + Math.Abs(-9.44691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78351 - lat) + Math.Abs(-9.14348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62032 - lat) + Math.Abs(-9.19426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80129 - lat) + Math.Abs(-8.674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54075 - lat) + Math.Abs(-9.03449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70314 - lat) + Math.Abs(-9.27666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69828 - lat) + Math.Abs(-8.08581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22068 - lat) + Math.Abs(-7.4435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41624 - lat) + Math.Abs(-7.4568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.82219 - lat) + Math.Abs(-7.49087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99298 - lat) + Math.Abs(-8.97346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00717 - lat) + Math.Abs(-8.21048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69681 - lat) + Math.Abs(-9.42147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62472 - lat) + Math.Abs(-7.92325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09736 - lat) + Math.Abs(-8.46846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16022 - lat) + Math.Abs(-8.78741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02362 - lat) + Math.Abs(-8.97692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72706 - lat) + Math.Abs(-9.24671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69105 - lat) + Math.Abs(-9.32215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74619 - lat) + Math.Abs(-8.7074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66179 - lat) + Math.Abs(-9.20032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65078 - lat) + Math.Abs(-16.83749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73834 - lat) + Math.Abs(-16.73836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69465 - lat) + Math.Abs(-17.09867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81321 - lat) + Math.Abs(-9.22679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01774 - lat) + Math.Abs(-7.06497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19678 - lat) + Math.Abs(-9.23519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.66578 - lat) + Math.Abs(-17.03576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80358 - lat) + Math.Abs(-9.12809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65043 - lat) + Math.Abs(-16.97718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67919 - lat) + Math.Abs(-16.84462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.71667 - lat) + Math.Abs(-17.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40326 - lat) + Math.Abs(-9.13839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24298 - lat) + Math.Abs(-9.10327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00461 - lat) + Math.Abs(-9.00419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68638 - lat) + Math.Abs(-9.14938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76698 - lat) + Math.Abs(-9.29793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92401 - lat) + Math.Abs(-7.7929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15581 - lat) + Math.Abs(-9.06588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90193 - lat) + Math.Abs(-9.11885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80553 - lat) + Math.Abs(-7.45465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26723 - lat) + Math.Abs(-9.15795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13718 - lat) + Math.Abs(-8.1582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80774 - lat) + Math.Abs(-9.09925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58058 - lat) + Math.Abs(-8.66441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81846 - lat) + Math.Abs(-16.97268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05656 - lat) + Math.Abs(-7.98427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15583 - lat) + Math.Abs(-8.7352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4247 - lat) + Math.Abs(-8.96996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.97919 - lat) + Math.Abs(-8.80759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14325 - lat) + Math.Abs(-8.68717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75087 - lat) + Math.Abs(-9.20282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7767 - lat) + Math.Abs(-9.26353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01506 - lat) + Math.Abs(-7.86323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73327 - lat) + Math.Abs(-9.10335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66025 - lat) + Math.Abs(-8.82475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66314 - lat) + Math.Abs(-9.0724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13446 - lat) + Math.Abs(-6.97604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73245 - lat) + Math.Abs(-9.28 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1388 - lat) + Math.Abs(-8.77757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34877 - lat) + Math.Abs(-8.53005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.84119 - lat) + Math.Abs(-9.4583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07029 - lat) + Math.Abs(-8.86822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05391 - lat) + Math.Abs(-7.89156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13796 - lat) + Math.Abs(-8.89932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33814 - lat) + Math.Abs(-9.3263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45551 - lat) + Math.Abs(-7.87295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98411 - lat) + Math.Abs(-9.07746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12242 - lat) + Math.Abs(-7.28619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.625 - lat) + Math.Abs(-9.10151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95378 - lat) + Math.Abs(-9.13465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72363 - lat) + Math.Abs(-7.98478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10256 - lat) + Math.Abs(-8.35695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.71502 - lat) + Math.Abs(-17.14974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81387 - lat) + Math.Abs(-9.13225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91177 - lat) + Math.Abs(-8.43568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62961 - lat) + Math.Abs(-9.11557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80404 - lat) + Math.Abs(-8.85984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44296 - lat) + Math.Abs(-8.73358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75382 - lat) + Math.Abs(-9.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38224 - lat) + Math.Abs(-9.03674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12994 - lat) + Math.Abs(-8.59174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25611 - lat) + Math.Abs(-7.99158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.82256 - lat) + Math.Abs(-8.37999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1756 - lat) + Math.Abs(-7.50064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19741 - lat) + Math.Abs(-7.65893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25712 - lat) + Math.Abs(-8.58187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65665 - lat) + Math.Abs(-8.79214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51279 - lat) + Math.Abs(-8.06008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20837 - lat) + Math.Abs(-8.62635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.84485 - lat) + Math.Abs(-9.27315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08686 - lat) + Math.Abs(-8.03074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67902 - lat) + Math.Abs(-9.1569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87759 - lat) + Math.Abs(-8.16516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56715 - lat) + Math.Abs(-8.92925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31745 - lat) + Math.Abs(-8.80147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65486 - lat) + Math.Abs(-9.02368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.92732 - lat) + Math.Abs(-9.00864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79764 - lat) + Math.Abs(-9.3437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16301 - lat) + Math.Abs(-8.30359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70245 - lat) + Math.Abs(-9.22936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48333 - lat) + Math.Abs(-8.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49971 - lat) + Math.Abs(-9.10341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05315 - lat) + Math.Abs(-9.00928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23983 - lat) + Math.Abs(-7.32342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92603 - lat) + Math.Abs(-7.40804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61667 - lat) + Math.Abs(-9.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47432 - lat) + Math.Abs(-7.47228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20857 - lat) + Math.Abs(-8.95953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75534 - lat) + Math.Abs(-8.96086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55223 - lat) + Math.Abs(-8.97749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13044 - lat) + Math.Abs(-8.34623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29603 - lat) + Math.Abs(-8.65847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.459 - lat) + Math.Abs(-8.66892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41501 - lat) + Math.Abs(-8.82189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91642 - lat) + Math.Abs(-7.45655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37326 - lat) + Math.Abs(-8.51444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73366 - lat) + Math.Abs(-9.40928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08819 - lat) + Math.Abs(-8.2503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.702 - lat) + Math.Abs(-7.40309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36125 - lat) + Math.Abs(-7.53894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70143 - lat) + Math.Abs(-16.77874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32272 - lat) + Math.Abs(-9.04743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15237 - lat) + Math.Abs(-9.2972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14416 - lat) + Math.Abs(-9.01853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46667 - lat) + Math.Abs(-8.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72361 - lat) + Math.Abs(-8.11283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39096 - lat) + Math.Abs(-8.26389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38242 - lat) + Math.Abs(-8.24887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66101 - lat) + Math.Abs(-7.90971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83509 - lat) + Math.Abs(-7.00501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58473 - lat) + Math.Abs(-6.52767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22511 - lat) + Math.Abs(-7.60338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64729 - lat) + Math.Abs(-8.43715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50031 - lat) + Math.Abs(-8.68525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35955 - lat) + Math.Abs(-8.33123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30062 - lat) + Math.Abs(-7.74413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08974 - lat) + Math.Abs(-8.6211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47555 - lat) + Math.Abs(-8.65382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10574 - lat) + Math.Abs(-8.58622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81098 - lat) + Math.Abs(-8.85255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50018 - lat) + Math.Abs(-7.64383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85291 - lat) + Math.Abs(-7.72791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12401 - lat) + Math.Abs(-8.61241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08194 - lat) + Math.Abs(-7.14146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40797 - lat) + Math.Abs(-8.51978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18165 - lat) + Math.Abs(-8.15143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0717 - lat) + Math.Abs(-8.64146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94118 - lat) + Math.Abs(-8.7423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25116 - lat) + Math.Abs(-8.18397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53846 - lat) + Math.Abs(-8.63971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35326 - lat) + Math.Abs(-8.74516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55107 - lat) + Math.Abs(-8.71645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86667 - lat) + Math.Abs(-8.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51787 - lat) + Math.Abs(-8.48357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63292 - lat) + Math.Abs(-8.14252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29528 - lat) + Math.Abs(-7.78401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69323 - lat) + Math.Abs(-8.83287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51512 - lat) + Math.Abs(-8.584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60746 - lat) + Math.Abs(-7.31088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18883 - lat) + Math.Abs(-8.49857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61667 - lat) + Math.Abs(-8.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20171 - lat) + Math.Abs(-7.54547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03104 - lat) + Math.Abs(-8.64595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83629 - lat) + Math.Abs(-8.58061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8497 - lat) + Math.Abs(-8.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12921 - lat) + Math.Abs(-8.56199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14737 - lat) + Math.Abs(-7.9812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.3329 - lat) + Math.Abs(-8.66657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.556 - lat) + Math.Abs(-8.68175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4272 - lat) + Math.Abs(-8.29796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13115 - lat) + Math.Abs(-7.81019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33729 - lat) + Math.Abs(-8.5596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08125 - lat) + Math.Abs(-7.43512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43246 - lat) + Math.Abs(-8.09428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32357 - lat) + Math.Abs(-8.18687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78329 - lat) + Math.Abs(-7.35016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17454 - lat) + Math.Abs(-7.05364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51682 - lat) + Math.Abs(-8.08087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31308 - lat) + Math.Abs(-8.75339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.71769 - lat) + Math.Abs(-8.30888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31054 - lat) + Math.Abs(-8.11101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31448 - lat) + Math.Abs(-7.45759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48253 - lat) + Math.Abs(-8.48399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16692 - lat) + Math.Abs(-8.84568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01763 - lat) + Math.Abs(-7.77547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11615 - lat) + Math.Abs(-7.56793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.36207 - lat) + Math.Abs(-8.02936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98496 - lat) + Math.Abs(-8.62185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05989 - lat) + Math.Abs(-8.62605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52371 - lat) + Math.Abs(-7.80234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21041 - lat) + Math.Abs(-8.45488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07197 - lat) + Math.Abs(-8.08999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99205 - lat) + Math.Abs(-8.62567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73459 - lat) + Math.Abs(-8.36722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40502 - lat) + Math.Abs(-8.22926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05105 - lat) + Math.Abs(-8.61605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40128 - lat) + Math.Abs(-8.36888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26511 - lat) + Math.Abs(-8.42892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89871 - lat) + Math.Abs(-7.49342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04712 - lat) + Math.Abs(-8.58449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55364 - lat) + Math.Abs(-7.22594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18641 - lat) + Math.Abs(-8.65172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38739 - lat) + Math.Abs(-6.42625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55437 - lat) + Math.Abs(-8.46281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41938 - lat) + Math.Abs(-8.34599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4151 - lat) + Math.Abs(-7.70859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74177 - lat) + Math.Abs(-7.73285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87216 - lat) + Math.Abs(-8.47149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28544 - lat) + Math.Abs(-8.5632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40118 - lat) + Math.Abs(-7.71464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75537 - lat) + Math.Abs(-8.07265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30044 - lat) + Math.Abs(-8.16623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14331 - lat) + Math.Abs(-8.50033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33167 - lat) + Math.Abs(-8.46185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19183 - lat) + Math.Abs(-8.61105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95527 - lat) + Math.Abs(-8.55117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38722 - lat) + Math.Abs(-8.06783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14805 - lat) + Math.Abs(-7.40489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9007 - lat) + Math.Abs(-8.4902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86802 - lat) + Math.Abs(-8.60672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66268 - lat) + Math.Abs(-8.72948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03555 - lat) + Math.Abs(-8.62259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34257 - lat) + Math.Abs(-8.47746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21083 - lat) + Math.Abs(-8.14224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21805 - lat) + Math.Abs(-8.40523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31393 - lat) + Math.Abs(-7.88545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20991 - lat) + Math.Abs(-7.78386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21462 - lat) + Math.Abs(-8.67406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76007 - lat) + Math.Abs(-7.46834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39856 - lat) + Math.Abs(-8.1316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19985 - lat) + Math.Abs(-8.44018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48678 - lat) + Math.Abs(-8.46968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92979 - lat) + Math.Abs(-8.52563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03508 - lat) + Math.Abs(-8.507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.7019 - lat) + Math.Abs(-8.39246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.77632 - lat) + Math.Abs(-6.75698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73971 - lat) + Math.Abs(-8.5572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35127 - lat) + Math.Abs(-7.09104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26702 - lat) + Math.Abs(-7.57601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.89614 - lat) + Math.Abs(-8.6253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94722 - lat) + Math.Abs(-7.57548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44146 - lat) + Math.Abs(-8.38412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17872 - lat) + Math.Abs(-8.55953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95775 - lat) + Math.Abs(-8.57818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40422 - lat) + Math.Abs(-8.67994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05542 - lat) + Math.Abs(-8.36891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66596 - lat) + Math.Abs(-7.87781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36081 - lat) + Math.Abs(-8.56774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52147 - lat) + Math.Abs(-7.80237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39648 - lat) + Math.Abs(-8.38685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10582 - lat) + Math.Abs(-7.9665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62898 - lat) + Math.Abs(-8.40858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51318 - lat) + Math.Abs(-7.99517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15356 - lat) + Math.Abs(-8.41178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22405 - lat) + Math.Abs(-8.40669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35509 - lat) + Math.Abs(-8.42355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55841 - lat) + Math.Abs(-8.4433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60246 - lat) + Math.Abs(-8.46297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38344 - lat) + Math.Abs(-8.76364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.57599 - lat) + Math.Abs(-8.27008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14961 - lat) + Math.Abs(-8.61099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76719 - lat) + Math.Abs(-8.58393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80451 - lat) + Math.Abs(-8.41554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47057 - lat) + Math.Abs(-8.3299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21026 - lat) + Math.Abs(-8.25746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77403 - lat) + Math.Abs(-7.06675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19063 - lat) + Math.Abs(-7.54504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16318 - lat) + Math.Abs(-7.78901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06513 - lat) + Math.Abs(-8.58531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53075 - lat) + Math.Abs(-8.68982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18252 - lat) + Math.Abs(-8.2545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03333 - lat) + Math.Abs(-8.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98875 - lat) + Math.Abs(-7.39386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16895 - lat) + Math.Abs(-7.16987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20835 - lat) + Math.Abs(-8.28285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26884 - lat) + Math.Abs(-8.28237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1888 - lat) + Math.Abs(-8.58624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41103 - lat) + Math.Abs(-8.74897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.91013 - lat) + Math.Abs(-8.56094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20485 - lat) + Math.Abs(-8.33147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79925 - lat) + Math.Abs(-8.62598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46216 - lat) + Math.Abs(-8.68038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58382 - lat) + Math.Abs(-7.99408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16971 - lat) + Math.Abs(-7.76302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3358 - lat) + Math.Abs(-8.42738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0462 - lat) + Math.Abs(-7.95182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27657 - lat) + Math.Abs(-8.37617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97541 - lat) + Math.Abs(-8.5835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85862 - lat) + Math.Abs(-8.62513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60715 - lat) + Math.Abs(-8.59198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32305 - lat) + Math.Abs(-8.22367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3618 - lat) + Math.Abs(-7.86014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12466 - lat) + Math.Abs(-8.58463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5146 - lat) + Math.Abs(-8.49386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73357 - lat) + Math.Abs(-8.17481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84101 - lat) + Math.Abs(-8.47555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47819 - lat) + Math.Abs(-8.46965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05024 - lat) + Math.Abs(-8.54416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54264 - lat) + Math.Abs(-8.53856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0053 - lat) + Math.Abs(-8.59195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24246 - lat) + Math.Abs(-8.58685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53216 - lat) + Math.Abs(-7.85152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34946 - lat) + Math.Abs(-8.40145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43552 - lat) + Math.Abs(-8.61398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73695 - lat) + Math.Abs(-8.6377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.406 - lat) + Math.Abs(-7.45485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.86774 - lat) + Math.Abs(-8.39776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89843 - lat) + Math.Abs(-8.53196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39675 - lat) + Math.Abs(-8.23234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.3868 - lat) + Math.Abs(-8.3394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24756 - lat) + Math.Abs(-8.64788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.056 - lat) + Math.Abs(-8.38939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17287 - lat) + Math.Abs(-8.68616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.82357 - lat) + Math.Abs(-7.78971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03921 - lat) + Math.Abs(-7.11477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41157 - lat) + Math.Abs(-7.95441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01946 - lat) + Math.Abs(-7.74547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.07892 - lat) + Math.Abs(-8.48076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98383 - lat) + Math.Abs(-7.61765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34034 - lat) + Math.Abs(-6.71187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48739 - lat) + Math.Abs(-7.18695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49692 - lat) + Math.Abs(-6.27308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09318 - lat) + Math.Abs(-8.33261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42892 - lat) + Math.Abs(-8.73746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31527 - lat) + Math.Abs(-8.72124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92163 - lat) + Math.Abs(-8.46788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21478 - lat) + Math.Abs(-8.58837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58564 - lat) + Math.Abs(-7.74658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1598 - lat) + Math.Abs(-7.88954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58568 - lat) + Math.Abs(-8.46555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06989 - lat) + Math.Abs(-8.40091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24827 - lat) + Math.Abs(-8.25807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96635 - lat) + Math.Abs(-7.26163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37806 - lat) + Math.Abs(-8.44991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.70654 - lat) + Math.Abs(-8.79628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18207 - lat) + Math.Abs(-8.68908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52823 - lat) + Math.Abs(-8.67081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55906 - lat) + Math.Abs(-8.78297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36478 - lat) + Math.Abs(-8.19999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18389 - lat) + Math.Abs(-8.14864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4028 - lat) + Math.Abs(-7.53977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60425 - lat) + Math.Abs(-7.76115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23574 - lat) + Math.Abs(-8.6199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21616 - lat) + Math.Abs(-8.33451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44092 - lat) + Math.Abs(-8.63426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85939 - lat) + Math.Abs(-8.37338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53816 - lat) + Math.Abs(-6.9611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34081 - lat) + Math.Abs(-8.31715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38429 - lat) + Math.Abs(-8.37845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27822 - lat) + Math.Abs(-8.27993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11673 - lat) + Math.Abs(-8.24921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9842 - lat) + Math.Abs(-8.55142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25938 - lat) + Math.Abs(-8.31683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32513 - lat) + Math.Abs(-7.68952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37411 - lat) + Math.Abs(-8.38016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23451 - lat) + Math.Abs(-8.40297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98664 - lat) + Math.Abs(-8.48566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21201 - lat) + Math.Abs(-8.63422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.191 - lat) + Math.Abs(-8.70027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25935 - lat) + Math.Abs(-8.71849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09363 - lat) + Math.Abs(-8.82826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4762 - lat) + Math.Abs(-7.91793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28742 - lat) + Math.Abs(-8.47458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09741 - lat) + Math.Abs(-7.80991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50265 - lat) + Math.Abs(-8.4345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98597 - lat) + Math.Abs(-8.56923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03945 - lat) + Math.Abs(-7.81605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19242 - lat) + Math.Abs(-6.72689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62148 - lat) + Math.Abs(-8.41258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11102 - lat) + Math.Abs(-8.51903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43906 - lat) + Math.Abs(-8.40846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60188 - lat) + Math.Abs(-8.67021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08292 - lat) + Math.Abs(-8.62679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48264 - lat) + Math.Abs(-8.44564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44443 - lat) + Math.Abs(-8.29619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19748 - lat) + Math.Abs(-8.66899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45859 - lat) + Math.Abs(-8.62946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53733 - lat) + Math.Abs(-7.26575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02836 - lat) + Math.Abs(-8.58017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14454 - lat) + Math.Abs(-8.53223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.54158 - lat) + Math.Abs(-8.4557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15735 - lat) + Math.Abs(-8.11007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17104 - lat) + Math.Abs(-7.80303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65893 - lat) + Math.Abs(-8.3094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26766 - lat) + Math.Abs(-8.64515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52185 - lat) + Math.Abs(-8.76185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20116 - lat) + Math.Abs(-8.43376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56268 - lat) + Math.Abs(-8.57204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63621 - lat) + Math.Abs(-8.71338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61806 - lat) + Math.Abs(-8.73303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14025 - lat) + Math.Abs(-7.50135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5659 - lat) + Math.Abs(-8.45134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27226 - lat) + Math.Abs(-8.21572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06707 - lat) + Math.Abs(-7.22124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09033 - lat) + Math.Abs(-6.80648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28835 - lat) + Math.Abs(-8.33533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25866 - lat) + Math.Abs(-8.40014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36846 - lat) + Math.Abs(-8.59887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09668 - lat) + Math.Abs(-8.50184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15119 - lat) + Math.Abs(-8.67125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62807 - lat) + Math.Abs(-7.54064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51792 - lat) + Math.Abs(-8.67708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11968 - lat) + Math.Abs(-7.73009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.29922 - lat) + Math.Abs(-8.16779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89262 - lat) + Math.Abs(-6.9635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15085 - lat) + Math.Abs(-8.86179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99446 - lat) + Math.Abs(-8.52537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.631 - lat) + Math.Abs(-8.36363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35 - lat) + Math.Abs(-8.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26718 - lat) + Math.Abs(-8.34434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36806 - lat) + Math.Abs(-8.19396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92535 - lat) + Math.Abs(-8.54277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26876 - lat) + Math.Abs(-7.50465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48298 - lat) + Math.Abs(-8.67152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51194 - lat) + Math.Abs(-8.77288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16754 - lat) + Math.Abs(-8.52981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44318 - lat) + Math.Abs(-7.37752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45083 - lat) + Math.Abs(-8.17258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44944 - lat) + Math.Abs(-8.75166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75648 - lat) + Math.Abs(-8.57207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5361 - lat) + Math.Abs(-8.78201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51006 - lat) + Math.Abs(-8.41729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00763 - lat) + Math.Abs(-8.64125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92462 - lat) + Math.Abs(-8.57495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95773 - lat) + Math.Abs(-8.62753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64899 - lat) + Math.Abs(-8.62943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16626 - lat) + Math.Abs(-7.47305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21653 - lat) + Math.Abs(-8.55318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62758 - lat) + Math.Abs(-8.56922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68333 - lat) + Math.Abs(-8.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1053 - lat) + Math.Abs(-7.32097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87413 - lat) + Math.Abs(-8.50687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47964 - lat) + Math.Abs(-8.69785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28106 - lat) + Math.Abs(-7.50504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94883 - lat) + Math.Abs(-8.6213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11283 - lat) + Math.Abs(-8.49804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20564 - lat) + Math.Abs(-8.41955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.74019 - lat) + Math.Abs(-7.46879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45235 - lat) + Math.Abs(-8.60194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38714 - lat) + Math.Abs(-8.00101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63723 - lat) + Math.Abs(-7.39037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8984 - lat) + Math.Abs(-7.93381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20265 - lat) + Math.Abs(-8.33516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06301 - lat) + Math.Abs(-8.2647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30057 - lat) + Math.Abs(-8.3608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43333 - lat) + Math.Abs(-8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24247 - lat) + Math.Abs(-7.30721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2062 - lat) + Math.Abs(-8.6481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34671 - lat) + Math.Abs(-8.59419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12314 - lat) + Math.Abs(-8.64654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08333 - lat) + Math.Abs(-8.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42768 - lat) + Math.Abs(-8.32166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50012 - lat) + Math.Abs(-7.89874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55655 - lat) + Math.Abs(-8.13432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18516 - lat) + Math.Abs(-8.46493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71086 - lat) + Math.Abs(-7.91445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40361 - lat) + Math.Abs(-8.52967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67101 - lat) + Math.Abs(-8.38148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38212 - lat) + Math.Abs(-8.3089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48465 - lat) + Math.Abs(-8.3485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51431 - lat) + Math.Abs(-7.98942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47662 - lat) + Math.Abs(-7.97445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16604 - lat) + Math.Abs(-8.8768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45821 - lat) + Math.Abs(-8.36103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06287 - lat) + Math.Abs(-7.79245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76653 - lat) + Math.Abs(-8.48262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80582 - lat) + Math.Abs(-6.75719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55032 - lat) + Math.Abs(-8.42005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33979 - lat) + Math.Abs(-8.5518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68939 - lat) + Math.Abs(-7.66914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24696 - lat) + Math.Abs(-7.27594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3593 - lat) + Math.Abs(-7.34869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53215 - lat) + Math.Abs(-8.36572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39727 - lat) + Math.Abs(-8.72385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76427 - lat) + Math.Abs(-8.5611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35534 - lat) + Math.Abs(-8.29943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1539 - lat) + Math.Abs(-7.74897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49111 - lat) + Math.Abs(-8.73192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1741 - lat) + Math.Abs(-7.60813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53174 - lat) + Math.Abs(-8.61843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19272 - lat) + Math.Abs(-8.38768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40435 - lat) + Math.Abs(-8.62386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16273 - lat) + Math.Abs(-8.0347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19203 - lat) + Math.Abs(-8.54118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07651 - lat) + Math.Abs(-8.62468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29273 - lat) + Math.Abs(-7.90288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10711 - lat) + Math.Abs(-8.55131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37034 - lat) + Math.Abs(-8.4101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40607 - lat) + Math.Abs(-8.77958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52113 - lat) + Math.Abs(-8.46682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64427 - lat) + Math.Abs(-8.64554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80771 - lat) + Math.Abs(-8.5722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15895 - lat) + Math.Abs(-8.43167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33922 - lat) + Math.Abs(-8.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91565 - lat) + Math.Abs(-8.49657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93057 - lat) + Math.Abs(-8.24488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45553 - lat) + Math.Abs(-8.21419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10765 - lat) + Math.Abs(-7.69139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02541 - lat) + Math.Abs(-8.53885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37744 - lat) + Math.Abs(-8.72987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21826 - lat) + Math.Abs(-8.05403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.71779 - lat) + Math.Abs(-8.85707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06187 - lat) + Math.Abs(-8.63192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84668 - lat) + Math.Abs(-8.41905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52185 - lat) + Math.Abs(-8.42151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39629 - lat) + Math.Abs(-8.66685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44779 - lat) + Math.Abs(-8.44171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28627 - lat) + Math.Abs(-8.64999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62084 - lat) + Math.Abs(-8.64195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48512 - lat) + Math.Abs(-8.76413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26634 - lat) + Math.Abs(-8.62844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27161 - lat) + Math.Abs(-8.5209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43841 - lat) + Math.Abs(-8.43352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40503 - lat) + Math.Abs(-8.75046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63091 - lat) + Math.Abs(-8.35117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27271 - lat) + Math.Abs(-8.08245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49872 - lat) + Math.Abs(-8.00386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08944 - lat) + Math.Abs(-8.24643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27644 - lat) + Math.Abs(-7.47489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18607 - lat) + Math.Abs(-8.79057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23671 - lat) + Math.Abs(-8.52454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15057 - lat) + Math.Abs(-8.65326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34315 - lat) + Math.Abs(-6.96112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13905 - lat) + Math.Abs(-7.51694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69318 - lat) + Math.Abs(-8.47994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81726 - lat) + Math.Abs(-7.54431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5772 - lat) + Math.Abs(-8.44442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43116 - lat) + Math.Abs(-8.77844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21017 - lat) + Math.Abs(-8.57599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24972 - lat) + Math.Abs(-8.49285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52291 - lat) + Math.Abs(-8.427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58732 - lat) + Math.Abs(-8.39817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68137 - lat) + Math.Abs(-7.92102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.74892 - lat) + Math.Abs(-8.39208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71667 - lat) + Math.Abs(-25.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68182 - lat) + Math.Abs(-28.20909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65 - lat) + Math.Abs(-28.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85832 - lat) + Math.Abs(-25.79435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83333 - lat) + Math.Abs(-25.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81829 - lat) + Math.Abs(-25.66583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66584 - lat) + Math.Abs(-27.08976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51631 - lat) + Math.Abs(-28.30752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75418 - lat) + Math.Abs(-25.64127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6563 - lat) + Math.Abs(-27.26935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67491 - lat) + Math.Abs(-27.29349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55 - lat) + Math.Abs(-27.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45782 - lat) + Math.Abs(-31.12989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08577 - lat) + Math.Abs(-28.0058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69608 - lat) + Math.Abs(-27.33907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75 - lat) + Math.Abs(-25.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71667 - lat) + Math.Abs(-28.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66203 - lat) + Math.Abs(-27.18093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6 - lat) + Math.Abs(-27.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81667 - lat) + Math.Abs(-25.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.722 - lat) + Math.Abs(-25.41791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73333 - lat) + Math.Abs(-25.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51667 - lat) + Math.Abs(-28.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82175 - lat) + Math.Abs(-25.52141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71766 - lat) + Math.Abs(-25.40551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75271 - lat) + Math.Abs(-25.71848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81022 - lat) + Math.Abs(-25.58263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73333 - lat) + Math.Abs(-27.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05154 - lat) + Math.Abs(-27.97107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75 - lat) + Math.Abs(-25.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68146 - lat) + Math.Abs(-27.05835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64814 - lat) + Math.Abs(-27.11944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71667 - lat) + Math.Abs(-25.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89017 - lat) + Math.Abs(-25.81999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83247 - lat) + Math.Abs(-25.38976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53642 - lat) + Math.Abs(-28.5266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76352 - lat) + Math.Abs(-27.10336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39529 - lat) + Math.Abs(-28.2522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37744 - lat) + Math.Abs(-31.17847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74486 - lat) + Math.Abs(-25.57184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53737 - lat) + Math.Abs(-28.62615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77567 - lat) + Math.Abs(-25.31035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69201 - lat) + Math.Abs(-27.07942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65429 - lat) + Math.Abs(-27.14995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8249 - lat) + Math.Abs(-25.64229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85128 - lat) + Math.Abs(-25.32406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75 - lat) + Math.Abs(-25.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63551 - lat) + Math.Abs(-28.69438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52198 - lat) + Math.Abs(-28.71365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60186 - lat) + Math.Abs(-28.01792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52531 - lat) + Math.Abs(-28.32074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76667 - lat) + Math.Abs(-25.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7073 - lat) + Math.Abs(-27.05655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78333 - lat) + Math.Abs(-27.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53912 - lat) + Math.Abs(-28.46306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76667 - lat) + Math.Abs(-25.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52547 - lat) + Math.Abs(-28.63132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65483 - lat) + Math.Abs(-27.21734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72142 - lat) + Math.Abs(-25.5117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08728 - lat) + Math.Abs(-8.11701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17391 - lat) + Math.Abs(-7.53169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56528 - lat) + Math.Abs(-9.04316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79174 - lat) + Math.Abs(-9.12119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02418 - lat) + Math.Abs(-8.63474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73203 - lat) + Math.Abs(-9.2192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75328 - lat) + Math.Abs(-9.14397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43289 - lat) + Math.Abs(-8.77065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73952 - lat) + Math.Abs(-25.66874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7069 - lat) + Math.Abs(-9.15611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.0304 - lat) + Math.Abs(-8.1588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4953 - lat) + Math.Abs(-9.15625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13521 - lat) + Math.Abs(-7.60048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99593 - lat) + Math.Abs(-9.3994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51919 - lat) + Math.Abs(-9.0139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49274 - lat) + Math.Abs(-8.66024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zambujeira do Mar", "03", 37.52799, -8.78483);
case 1: return new CityInfo("Vimeiro", "14", 39.17768, -9.31702);
case 2: return new CityInfo("Vila Viçosa", "08", 38.7777, -7.41793);
case 3: return new CityInfo("Vila Verde", "14", 39.15489, -9.11512);
case 4: return new CityInfo("Vila Velha de Ródão", "06", 39.65646, -7.6767);
case 5: return new CityInfo("Vila Real de Santo António", "09", 37.195, -7.41766);
case 6: return new CityInfo("Vila Nova de Milfontes", "03", 37.72377, -8.78278);
case 7: return new CityInfo("Vila Nova da Barquinha", "18", 39.46081, -8.43588);
case 8: return new CityInfo("Vila Franca de Xira", "14", 38.95525, -8.98966);
case 9: return new CityInfo("Vila Flor", "05", 41.30904, -7.15378);
case 10: return new CityInfo("Vila do Bispo", "09", 37.08317, -8.91144);
case 11: return new CityInfo("Vila de Rei", "06", 39.67604, -8.14577);
case 12: return new CityInfo("Vila Chã de Ourique", "18", 39.17219, -8.76658);
case 13: return new CityInfo("Vila Baleira", "10", 33.05919, -16.33371);
case 14: return new CityInfo("Vieira de Leiria", "13", 39.86945, -8.93238);
case 15: return new CityInfo("Vidigueira", "03", 38.20995, -7.8005);
case 16: return new CityInfo("Vidais", "13", 39.36886, -9.04916);
case 17: return new CityInfo("Viana do Alentejo", "08", 38.33458, -8.0044);
case 18: return new CityInfo("Vialonga", "14", 38.87206, -9.07805);
case 19: return new CityInfo("Vestiaria", "13", 39.55271, -8.9979);
case 20: return new CityInfo("Ventosa", "14", 39.12696, -9.08423);
case 21: return new CityInfo("Vendas Novas", "08", 38.67706, -8.45792);
case 22: return new CityInfo("Venda do Pinheiro", "14", 38.92365, -9.23178);
case 23: return new CityInfo("Vale de Santarém", "18", 39.19052, -8.72735);
case 24: return new CityInfo("Vale de Figueira", "18", 39.30569, -8.62876);
case 25: return new CityInfo("Vale da Amoreira", "16", 39.06969, -7.69849);
case 26: return new CityInfo("Valado de Frades", "13", 39.58432, -9.0229);
case 27: return new CityInfo("Urra", "16", 39.2283, -7.39856);
case 28: return new CityInfo("Unhos", "14", 38.81958, -9.12007);
case 29: return new CityInfo("Turquel", "13", 39.46411, -8.97743);
case 30: return new CityInfo("Tunes", "09", 37.16592, -8.25919);
case 31: return new CityInfo("Trigaches", "03", 38.09064, -7.97196);
case 32: return new CityInfo("Tramagal", "18", 39.45, -8.25);
case 33: return new CityInfo("Trafaria", "19", 38.67222, -9.23268);
case 34: return new CityInfo("Torres Vedras", "14", 39.09109, -9.2586);
case 35: return new CityInfo("Torres Novas", "18", 39.47581, -8.54348);
case 36: return new CityInfo("Tomar", "18", 39.60199, -8.40924);
case 37: return new CityInfo("Terrugem", "14", 38.70647, -9.28693);
case 38: return new CityInfo("Tavira", "09", 37.12734, -7.64861);
case 39: return new CityInfo("Souto da Carpalhosa", "13", 39.84867, -8.83506);
case 40: return new CityInfo("Sobreda", "19", 38.64961, -9.18977);
case 41: return new CityInfo("Sobralinho", "14", 38.91703, -9.02656);
case 42: return new CityInfo("Sobral de Monte Agraço", "14", 39.01958, -9.15081);
case 43: return new CityInfo("Sintra", "14", 38.80097, -9.37826);
case 44: return new CityInfo("Sines", "19", 37.95622, -8.86979);
case 45: return new CityInfo("Silves", "09", 37.18921, -8.43822);
case 46: return new CityInfo("Silveira", "14", 39.1112, -9.3643);
case 47: return new CityInfo("Sesimbra", "19", 38.44451, -9.10149);
case 48: return new CityInfo("Setúbal", "19", 38.5244, -8.8882);
case 49: return new CityInfo("Sertã", "06", 39.80205, -8.09589);
case 50: return new CityInfo("Serra do Bouro", "13", 39.45461, -9.17819);
case 51: return new CityInfo("Serra de El-Rei", "13", 39.33291, -9.26843);
case 52: return new CityInfo("Serpa", "03", 37.94581, -7.59754);
case 53: return new CityInfo("Senhora da Luz", "09", 37.08771, -8.72649);
case 54: return new CityInfo("Seixal", "19", 38.64008, -9.10141);
case 55: return new CityInfo("Seixal", "10", 32.82322, -17.10941);
case 56: return new CityInfo("Sarilhos Pequenos", "19", 38.68176, -8.98231);
case 57: return new CityInfo("Sardoal", "18", 39.53449, -8.16119);
case 58: return new CityInfo("São Vicente do Paul", "18", 39.34946, -8.62221);
case 59: return new CityInfo("São Vicente", "10", 32.79673, -17.04323);
case 60: return new CityInfo("São Teotónio", "03", 37.51282, -8.70708);
case 61: return new CityInfo("São Roque", "10", 32.66667, -16.91667);
case 62: return new CityInfo("São Pedro da Cadeira", "14", 39.06983, -9.37174);
case 63: return new CityInfo("São Miguel de Rio Torto", "18", 39.43333, -8.21667);
case 64: return new CityInfo("São Matias", "03", 38.10932, -7.85638);
case 65: return new CityInfo("São Martinho do Porto", "13", 39.51444, -9.13111);
case 66: return new CityInfo("São Martinho", "10", 32.6448, -16.93843);
case 67: return new CityInfo("São Marcos da Serra", "09", 37.361, -8.37764);
case 68: return new CityInfo("São Luis", "03", 37.71556, -8.66472);
case 69: return new CityInfo("São Julião", "16", 39.32268, -7.31106);
case 70: return new CityInfo("São Jorge", "10", 32.81667, -16.9);
case 71: return new CityInfo("São João dos Montes", "14", 38.93944, -9.01892);
case 72: return new CityInfo("São João da Talha", "14", 38.82378, -9.09719);
case 73: return new CityInfo("São João das Lampas", "14", 38.87376, -9.39842);
case 74: return new CityInfo("São Domingos de Rana", "14", 38.70194, -9.34083);
case 75: return new CityInfo("São Brissos", "03", 38.07203, -7.9465);
case 76: return new CityInfo("São Brás de Alportel", "09", 37.1531, -7.88751);
case 77: return new CityInfo("São Bartolomeu de Messines", "09", 37.25648, -8.28672);
case 78: return new CityInfo("São Bartolomeu", "14", 39.27511, -9.27885);
case 79: return new CityInfo("Santo da Serra", "10", 32.72246, -16.81991);
case 80: return new CityInfo("Santo António da Charneca", "19", 38.62561, -9.03043);
case 81: return new CityInfo("Santo Antão do Tojal", "14", 38.85151, -9.13975);
case 82: return new CityInfo("Santo André", "16", 39.05532, -8.24414);
case 83: return new CityInfo("Santo André", "19", 38.06078, -8.7822);
case 84: return new CityInfo("Santiago do Cacém", "19", 38.01693, -8.69475);
case 85: return new CityInfo("Santa Vitória", "03", 37.96891, -8.02664);
case 86: return new CityInfo("Santarém", "18", 39.23333, -8.68333);
case 87: return new CityInfo("Santana", "10", 32.8, -16.88333);
case 88: return new CityInfo("Santa Margarida da Coutada", "18", 39.45, -8.31667);
case 89: return new CityInfo("Santa Luzia", "09", 37.10224, -7.66202);
case 90: return new CityInfo("Santa Iria da Azóia", "14", 38.8411, -9.09908);
case 91: return new CityInfo("Santa Cruz", "10", 32.68806, -16.79388);
case 92: return new CityInfo("Santa Clara de Louredo", "03", 37.97106, -7.872);
case 93: return new CityInfo("Santa Catarina da Serra", "13", 39.6796, -8.68679);
case 94: return new CityInfo("Santa Bárbara de Nexe", "09", 37.10619, -7.96648);
case 95: return new CityInfo("Samouco", "19", 38.72035, -9.00471);
case 96: return new CityInfo("Samora Correia", "18", 38.93709, -8.87178);
case 97: return new CityInfo("Salvaterra de Magos", "18", 39.02788, -8.7935);
case 98: return new CityInfo("Salvada", "03", 37.93771, -7.77448);
case 99: return new CityInfo("Salir de Matos", "13", 39.43186, -9.09479);
case 100: return new CityInfo("Sagres", "09", 37.00864, -8.94311);
case 101: return new CityInfo("Sacavém", "14", 38.79202, -9.10801);
case 102: return new CityInfo("Rosairinho", "19", 38.67734, -9.00836);
case 103: return new CityInfo("Rio Maior", "18", 39.33732, -8.93906);
case 104: return new CityInfo("Rio de Mouro", "14", 38.76613, -9.32804);
case 105: return new CityInfo("Ribeira Brava", "10", 32.67483, -17.06288);
case 106: return new CityInfo("Riachos", "18", 39.44472, -8.5142);
case 107: return new CityInfo("Reguengos de Monsaraz", "08", 38.42529, -7.53494);
case 108: return new CityInfo("Reguengo", "16", 39.29801, -7.39234);
case 109: return new CityInfo("Redondo", "08", 38.64872, -7.54708);
case 110: return new CityInfo("Ramada", "14", 38.80368, -9.1877);
case 111: return new CityInfo("Quinta do Anjo", "19", 38.56753, -8.94228);
case 112: return new CityInfo("Queluz", "14", 38.75657, -9.25451);
case 113: return new CityInfo("Queijas", "14", 38.71925, -9.26255);
case 114: return new CityInfo("Quarteira", "09", 37.06946, -8.10064);
case 115: return new CityInfo("Proença-a-Nova", "06", 39.7522, -7.9239);
case 116: return new CityInfo("Prazeres", "10", 32.75104, -17.20433);
case 117: return new CityInfo("Praia do Ribatejo", "18", 39.46667, -8.35);
case 118: return new CityInfo("Pragal", "19", 38.67459, -9.16981);
case 119: return new CityInfo("Póvoa e Meadas", "16", 39.51046, -7.51765);
case 120: return new CityInfo("Póvoa de Santo Adrião", "14", 38.8, -9.16667);
case 121: return new CityInfo("Póvoa de Santa Iria", "14", 38.86101, -9.06453);
case 122: return new CityInfo("Porto Salvo", "14", 38.72293, -9.30473);
case 123: return new CityInfo("Porto Moniz", "10", 32.86681, -17.16667);
case 124: return new CityInfo("Porto de Mós", "13", 39.60191, -8.81839);
case 125: return new CityInfo("Porto da Cruz", "10", 32.76667, -16.83333);
case 126: return new CityInfo("Porto Covo", "19", 37.85256, -8.79018);
case 127: return new CityInfo("Portimão", "09", 37.13856, -8.53775);
case 128: return new CityInfo("Portel", "08", 38.30697, -7.70244);
case 129: return new CityInfo("Portalegre", "16", 39.29379, -7.43122);
case 130: return new CityInfo("Porches", "09", 37.12665, -8.40162);
case 131: return new CityInfo("Pontinha", "14", 38.76771, -9.19935);
case 132: return new CityInfo("Pontével", "18", 39.14945, -8.8388);
case 133: return new CityInfo("Ponte de Sôr", "16", 39.24964, -8.01009);
case 134: return new CityInfo("Ponta do Sol", "10", 32.6798, -17.1);
case 135: return new CityInfo("Ponta do Pargo", "10", 32.81137, -17.24862);
case 136: return new CityInfo("Pombal", "13", 39.91674, -8.62847);
case 137: return new CityInfo("Poceirão", "18", 38.83095, -8.79365);
case 138: return new CityInfo("Pinheiro Grande", "18", 39.39212, -8.4341);
case 139: return new CityInfo("Pinhal Novo", "19", 38.63106, -8.91376);
case 140: return new CityInfo("Piedade", "19", 38.67005, -9.15852);
case 141: return new CityInfo("Pero Pinheiro", "14", 38.85783, -9.32352);
case 142: return new CityInfo("Pereiro da Palhacana", "14", 39.04345, -9.11099);
case 143: return new CityInfo("Pêra", "09", 37.12296, -8.34115);
case 144: return new CityInfo("Peniche", "13", 39.3558, -9.38112);
case 145: return new CityInfo("Penedo Gordo", "03", 37.98477, -7.91651);
case 146: return new CityInfo("Pego", "18", 39.46146, -8.14955);
case 147: return new CityInfo("Pedrógão Grande", "13", 39.91835, -8.1459);
case 148: return new CityInfo("Paul do Mar", "10", 32.75898, -17.23025);
case 149: return new CityInfo("Pataias", "13", 39.66978, -8.9958);
case 150: return new CityInfo("Parede", "14", 38.69282, -9.35412);
case 151: return new CityInfo("Parchal", "09", 37.13827, -8.51703);
case 152: return new CityInfo("Palmela", "19", 38.56902, -8.90126);
case 153: return new CityInfo("Paialvo", "18", 39.56399, -8.46835);
case 154: return new CityInfo("Paderne", "09", 37.17935, -8.2015);
case 155: return new CityInfo("Paço de Arcos", "14", 38.69569, -9.29143);
case 156: return new CityInfo("Ourique", "03", 37.6539, -8.22569);
case 157: return new CityInfo("Ourém", "18", 39.64167, -8.5919);
case 158: return new CityInfo("Ota", "14", 39.11199, -8.99105);
case 159: return new CityInfo("Olival do Basto", "14", 38.79079, -9.16621);
case 160: return new CityInfo("Olivais", "14", 38.76994, -9.10674);
case 161: return new CityInfo("Olhos de Água", "09", 37.09024, -8.19168);
case 162: return new CityInfo("Olhão", "09", 37.0286, -7.8411);
case 163: return new CityInfo("Oleiros", "06", 39.91893, -7.9137);
case 164: return new CityInfo("Oeiras", "14", 38.69105, -9.31085);
case 165: return new CityInfo("Odivelas", "14", 38.79269, -9.1838);
case 166: return new CityInfo("Odemira", "03", 37.59798, -8.63972);
case 167: return new CityInfo("Óbidos", "13", 39.36055, -9.1567);
case 168: return new CityInfo("Nossa Senhora do Monte", "10", 32.66667, -16.9);
case 169: return new CityInfo("Nisa", "16", 39.51499, -7.64908);
case 170: return new CityInfo("Neves", "03", 38.0227, -7.81344);
case 171: return new CityInfo("Nazaré", "13", 39.60289, -9.06836);
case 172: return new CityInfo("Nadadouro", "13", 39.41927, -9.19091);
case 173: return new CityInfo("Mourão", "08", 38.38356, -7.34189);
case 174: return new CityInfo("Moura", "03", 38.1401, -7.44856);
case 175: return new CityInfo("Moscavide e Portela", "14", 38.77929, -9.10222);
case 176: return new CityInfo("Mora", "08", 38.94351, -8.16434);
case 177: return new CityInfo("Montijo", "19", 38.70675, -8.97388);
case 178: return new CityInfo("Monte Redondo", "13", 39.8993, -8.83171);
case 179: return new CityInfo("Monte Real", "13", 39.8521, -8.86349);
case 180: return new CityInfo("Montemor-o-Novo", "08", 38.64812, -8.21455);
case 181: return new CityInfo("Monte Gordo", "09", 37.18192, -7.45225);
case 182: return new CityInfo("Monte Estoril", "14", 38.70636, -9.40595);
case 183: return new CityInfo("Montargil", "16", 39.07771, -8.17044);
case 184: return new CityInfo("Montalvo", "18", 39.48333, -8.3);
case 185: return new CityInfo("Montalvinho", "18", 39.48333, -8.3);
case 186: return new CityInfo("Monsanto", "18", 39.46203, -8.7118);
case 187: return new CityInfo("Monforte", "16", 39.05318, -7.43689);
case 188: return new CityInfo("Monchique", "09", 37.31775, -8.55529);
case 189: return new CityInfo("Moncarapacho", "09", 37.0836, -7.78763);
case 190: return new CityInfo("Mombeja", "03", 38.02405, -8.03778);
case 191: return new CityInfo("Moita dos Ferreiros", "14", 39.24825, -9.22355);
case 192: return new CityInfo("Moita", "19", 38.65078, -8.99038);
case 193: return new CityInfo("Mira", "13", 39.54315, -8.71505);
case 194: return new CityInfo("Minde", "18", 39.51631, -8.68799);
case 195: return new CityInfo("Minas de São Domingos", "03", 37.67322, -7.49765);
case 196: return new CityInfo("Milharado", "14", 38.94732, -9.19914);
case 197: return new CityInfo("Mexilhoeira Grande", "09", 37.15858, -8.61487);
case 198: return new CityInfo("Mértola", "03", 37.64304, -7.6611);
case 199: return new CityInfo("Mem Martins", "14", 38.79443, -9.34284);
case 200: return new CityInfo("Meca", "14", 39.08178, -9.03459);
case 201: return new CityInfo("Massamá", "14", 38.75279, -9.2811);
case 202: return new CityInfo("Marvão", "16", 39.39377, -7.37663);
case 203: return new CityInfo("Martinchel", "18", 39.53622, -8.3118);
case 204: return new CityInfo("Marmelete", "09", 37.31014, -8.66813);
case 205: return new CityInfo("Marinhais", "18", 39.0473, -8.70236);
case 206: return new CityInfo("Marinha Grande", "13", 39.74769, -8.93228);
case 207: return new CityInfo("Manta Rota", "09", 37.16849, -7.51804);
case 208: return new CityInfo("Malveira", "14", 38.93213, -9.25779);
case 209: return new CityInfo("Mafra", "14", 38.93793, -9.32756);
case 210: return new CityInfo("Madalena do Mar", "10", 32.7007, -17.13542);
case 211: return new CityInfo("Madalena", "18", 39.57133, -8.44635);
case 212: return new CityInfo("Machico", "10", 32.7162, -16.76758);
case 213: return new CityInfo("Maceira", "13", 39.68853, -8.89423);
case 214: return new CityInfo("Mação", "18", 39.55573, -7.99421);
case 215: return new CityInfo("Luz", "09", 37.09216, -7.70433);
case 216: return new CityInfo("Lugar de Baixo", "10", 32.67984, -17.08657);
case 217: return new CityInfo("Lourinhã", "14", 39.24166, -9.31254);
case 218: return new CityInfo("Louriçal", "13", 40.0039, -8.73736);
case 219: return new CityInfo("Loures", "14", 38.83091, -9.16845);
case 220: return new CityInfo("Loulé", "09", 37.13772, -8.01968);
case 221: return new CityInfo("Lisbon", "14", 38.71667, -9.13333);
case 222: return new CityInfo("Linda-a-Velha", "14", 38.71446, -9.2422);
case 223: return new CityInfo("Leiria", "13", 39.74362, -8.80705);
case 224: return new CityInfo("Lavradio", "19", 38.66808, -9.05204);
case 225: return new CityInfo("Laranjeiro", "09", 37.06799, -7.8078);
case 226: return new CityInfo("Laranjeira", "19", 38.65599, -9.15376);
case 227: return new CityInfo("Lagos", "09", 37.10202, -8.67422);
case 228: return new CityInfo("Lagoa", "09", 37.13535, -8.45319);
case 229: return new CityInfo("Idanha-a-Nova", "06", 39.92316, -7.24082);
case 230: return new CityInfo("Guia", "09", 37.12959, -8.29963);
case 231: return new CityInfo("Grândola", "19", 38.17718, -8.56675);
case 232: return new CityInfo("Golegã", "18", 39.40474, -8.48625);
case 233: return new CityInfo("Gavião", "16", 39.46443, -7.93449);
case 234: return new CityInfo("Gáfete", "16", 39.4108, -7.68365);
case 235: return new CityInfo("Fuzeta", "09", 37.05429, -7.74699);
case 236: return new CityInfo("Funchal", "10", 32.66568, -16.92547);
case 237: return new CityInfo("Fronteira", "16", 39.05629, -7.64868);
case 238: return new CityInfo("Foz do Arelho", "13", 39.43672, -9.21374);
case 239: return new CityInfo("Fortios", "16", 39.32494, -7.50057);
case 240: return new CityInfo("Fontes", "18", 39.60674, -8.23137);
case 241: return new CityInfo("Fontanelas", "14", 38.84806, -9.43942);
case 242: return new CityInfo("Figueiró dos Vinhos", "13", 39.90413, -8.27511);
case 243: return new CityInfo("Ferrel", "13", 39.36398, -9.31541);
case 244: return new CityInfo("Ferreiras", "09", 37.12926, -8.23759);
case 245: return new CityInfo("Ferreira do Zêzere", "18", 39.69406, -8.29213);
case 246: return new CityInfo("Ferreira do Alentejo", "03", 38.05, -8.03333);
case 247: return new CityInfo("Ferragudo", "09", 37.12474, -8.51915);
case 248: return new CityInfo("Fazendas de Almeirim", "18", 39.17553, -8.56927);
case 249: return new CityInfo("Fátima", "18", 39.62071, -8.65237);
case 250: return new CityInfo("Faro do Alentejo", "03", 38.14888, -7.94173);
case 251: return new CityInfo("Faro", "09", 37.01869, -7.92716);
case 252: return new CityInfo("Famões", "14", 38.78804, -9.21033);
case 253: return new CityInfo("Famalicão", "13", 39.53642, -9.08308);
case 254: return new CityInfo("Fajã da Ovelha", "10", 32.77457, -17.23412);
case 255: return new CityInfo("Faial", "10", 32.78333, -16.85);
case 256: return new CityInfo("Évora", "08", 38.56667, -7.9);
case 257: return new CityInfo("Estremoz", "08", 38.84432, -7.58585);
case 258: return new CityInfo("Estreito da Calheta", "10", 32.73704, -17.18674);
case 259: return new CityInfo("Estoril", "14", 38.70571, -9.39773);
case 260: return new CityInfo("Estômbar", "09", 37.14629, -8.48505);
case 261: return new CityInfo("Estói", "09", 37.09503, -7.89445);
case 262: return new CityInfo("Ericeira", "14", 38.96275, -9.41563);
case 263: return new CityInfo("Entroncamento", "18", 39.46667, -8.46667);
case 264: return new CityInfo("Elvas", "16", 38.8815, -7.16282);
case 265: return new CityInfo("Curral das Freiras", "10", 32.72029, -16.96993);
case 266: return new CityInfo("Cuba", "03", 38.16544, -7.8924);
case 267: return new CityInfo("Costa de Caparica", "19", 38.64458, -9.23556);
case 268: return new CityInfo("Coruche", "18", 38.95955, -8.52524);
case 269: return new CityInfo("Corroios", "19", 38.64004, -9.1508);
case 270: return new CityInfo("Constância", "18", 39.47796, -8.33636);
case 271: return new CityInfo("Conceição", "09", 37.14789, -7.60426);
case 272: return new CityInfo("Comporta", "19", 38.38059, -8.78608);
case 273: return new CityInfo("Comenda", "16", 39.39997, -7.78112);
case 274: return new CityInfo("Colares", "14", 38.79921, -9.44691);
case 275: return new CityInfo("Charneca", "14", 38.78351, -9.14348);
case 276: return new CityInfo("Charneca de Caparica", "19", 38.62032, -9.19426);
case 277: return new CityInfo("Cercal", "19", 37.80129, -8.674);
case 278: return new CityInfo("Cela", "13", 39.54075, -9.03449);
case 279: return new CityInfo("Caxias", "14", 38.70314, -9.27666);
case 280: return new CityInfo("Castro Verde", "03", 37.69828, -8.08581);
case 281: return new CityInfo("Castro Marim", "09", 37.22068, -7.4435);
case 282: return new CityInfo("Castelo de Vide", "16", 39.41624, -7.4568);
case 283: return new CityInfo("Castelo Branco", "06", 39.82219, -7.49087);
case 284: return new CityInfo("Castanheira do Ribatejo", "14", 38.99298, -8.97346);
case 285: return new CityInfo("Castanheira de Pêra", "13", 40.00717, -8.21048);
case 286: return new CityInfo("Cascais", "14", 38.69681, -9.42147);
case 287: return new CityInfo("Carvoeiro", "18", 39.62472, -7.92325);
case 288: return new CityInfo("Carvoeiro", "09", 37.09736, -8.46846);
case 289: return new CityInfo("Cartaxo", "18", 39.16022, -8.78741);
case 290: return new CityInfo("Carregado", "14", 39.02362, -8.97692);
case 291: return new CityInfo("Carnaxide", "14", 38.72706, -9.24671);
case 292: return new CityInfo("Carcavelos", "14", 38.69105, -9.32215);
case 293: return new CityInfo("Caranguejeira", "13", 39.74619, -8.7074);
case 294: return new CityInfo("Caparica", "19", 38.66179, -9.20032);
case 295: return new CityInfo("Caniço", "10", 32.65078, -16.83749);
case 296: return new CityInfo("Caniçal", "10", 32.73834, -16.73836);
case 297: return new CityInfo("Canhas", "10", 32.69465, -17.09867);
case 298: return new CityInfo("Caneças", "14", 38.81321, -9.22679);
case 299: return new CityInfo("Campo Maior", "16", 39.01774, -7.06497);
case 300: return new CityInfo("Campelos", "14", 39.19678, -9.23519);
case 301: return new CityInfo("Campanário", "10", 32.66578, -17.03576);
case 302: return new CityInfo("Camarate", "14", 38.80358, -9.12809);
case 303: return new CityInfo("Câmara de Lobos", "10", 32.65043, -16.97718);
case 304: return new CityInfo("Camacha", "10", 32.67919, -16.84462);
case 305: return new CityInfo("Calheta", "10", 32.71667, -17.18333);
case 306: return new CityInfo("Caldas da Rainha", "13", 39.40326, -9.13839);
case 307: return new CityInfo("Cadaval", "14", 39.24298, -9.10327);
case 308: return new CityInfo("Cadafais", "14", 39.00461, -9.00419);
case 309: return new CityInfo("Cacilhas", "19", 38.68638, -9.14938);
case 310: return new CityInfo("Cacém", "14", 38.76698, -9.29793);
case 311: return new CityInfo("Cabeça Gorda", "03", 37.92401, -7.7929);
case 312: return new CityInfo("Cabanas de Torres", "14", 39.15581, -9.06588);
case 313: return new CityInfo("Bucelas", "14", 38.90193, -9.11885);
case 314: return new CityInfo("Borba", "08", 38.80553, -7.45465);
case 315: return new CityInfo("Bombarral", "13", 39.26723, -9.15795);
case 316: return new CityInfo("Boliqueime", "09", 37.13718, -8.1582);
case 317: return new CityInfo("Bobadela", "14", 38.80774, -9.09925);
case 318: return new CityInfo("Boavista dos Pinheiros", "03", 37.58058, -8.66441);
case 319: return new CityInfo("Boaventura", "10", 32.81846, -16.97268);
case 320: return new CityInfo("Beringel", "03", 38.05656, -7.98427);
case 321: return new CityInfo("Bensafrim", "09", 37.15583, -8.7352);
case 322: return new CityInfo("Benedita", "13", 39.4247, -8.96996);
case 323: return new CityInfo("Benavente", "18", 38.97919, -8.80759);
case 324: return new CityInfo("Bemfica", "18", 39.14325, -8.68717);
case 325: return new CityInfo("Benfica", "14", 38.75087, -9.20282);
case 326: return new CityInfo("Belas", "14", 38.7767, -9.26353);
case 327: return new CityInfo("Beja", "03", 38.01506, -7.86323);
case 328: return new CityInfo("Beato António", "14", 38.73327, -9.10335);
case 329: return new CityInfo("Batalha", "13", 39.66025, -8.82475);
case 330: return new CityInfo("Barreiro", "19", 38.66314, -9.0724);
case 331: return new CityInfo("Barrancos", "03", 38.13446, -6.97604);
case 332: return new CityInfo("Barcarena", "14", 38.73245, -9.28);
case 333: return new CityInfo("Barão de São João", "09", 37.1388, -8.77757);
case 334: return new CityInfo("Azinhaga", "18", 39.34877, -8.53005);
case 335: return new CityInfo("Azenhas do Mar", "14", 38.84119, -9.4583);
case 336: return new CityInfo("Azambuja", "14", 39.07029, -8.86822);
case 337: return new CityInfo("Avis", "16", 39.05391, -7.89156);
case 338: return new CityInfo("Aveiras de Cima", "14", 39.13796, -8.89932);
case 339: return new CityInfo("Atouguia da Baleia", "13", 39.33814, -9.3263);
case 340: return new CityInfo("Atalaia", "16", 39.45551, -7.87295);
case 341: return new CityInfo("Arruda dos Vinhos", "14", 38.98411, -9.07746);
case 342: return new CityInfo("Arronches", "16", 39.12242, -7.28619);
case 343: return new CityInfo("Arrentela", "19", 38.625, -9.10151);
case 344: return new CityInfo("Arranhó", "14", 38.95378, -9.13465);
case 345: return new CityInfo("Arraiolos", "08", 38.72363, -7.98478);
case 346: return new CityInfo("Armação de Pêra", "09", 37.10256, -8.35695);
case 347: return new CityInfo("Arco da Calheta", "10", 32.71502, -17.14974);
case 348: return new CityInfo("Apelação", "14", 38.81387, -9.13225);
case 349: return new CityInfo("Ansião", "13", 39.91177, -8.43568);
case 350: return new CityInfo("Amora", "19", 38.62961, -9.11557);
case 351: return new CityInfo("Amor", "13", 39.80404, -8.85984);
case 352: return new CityInfo("Amiães de Baixo", "18", 39.44296, -8.73358);
case 353: return new CityInfo("Amadora", "14", 38.75382, -9.23083);
case 354: return new CityInfo("Alvorninha", "13", 39.38224, -9.03674);
case 355: return new CityInfo("Alvor", "09", 37.12994, -8.59174);
case 356: return new CityInfo("Alvito", "03", 38.25611, -7.99158);
case 357: return new CityInfo("Alvaiázere", "13", 39.82256, -8.37999);
case 358: return new CityInfo("Altura", "09", 37.1756, -7.50064);
case 359: return new CityInfo("Alter do Chão", "16", 39.19741, -7.65893);
case 360: return new CityInfo("Alpiarça", "18", 39.25712, -8.58187);
case 361: return new CityInfo("Almograve", "03", 37.65665, -8.79214);
case 362: return new CityInfo("Almodôvar", "03", 37.51279, -8.06008);
case 363: return new CityInfo("Almeirim", "18", 39.20837, -8.62635);
case 364: return new CityInfo("Almargem", "14", 38.84485, -9.27315);
case 365: return new CityInfo("Almancil", "09", 37.08686, -8.03074);
case 366: return new CityInfo("Almada", "19", 38.67902, -9.1569);
case 367: return new CityInfo("Aljustrel", "03", 37.87759, -8.16516);
case 368: return new CityInfo("Aljubarrota", "13", 39.56715, -8.92925);
case 369: return new CityInfo("Aljezur", "09", 37.31745, -8.80147);
case 370: return new CityInfo("Alhos Vedros", "19", 38.65486, -9.02368);
case 371: return new CityInfo("Alhandra", "14", 38.92732, -9.00864);
case 372: return new CityInfo("Algueirão", "14", 38.79764, -9.3437);
case 373: return new CityInfo("Algoz", "09", 37.16301, -8.30359);
case 374: return new CityInfo("Algés", "14", 38.70245, -9.22936);
case 375: return new CityInfo("Alferrarede", "18", 39.48333, -8.16667);
case 376: return new CityInfo("Alfeizerão", "13", 39.49971, -9.10341);
case 377: return new CityInfo("Alenquer", "14", 39.05315, -9.00928);
case 378: return new CityInfo("Alegrete", "16", 39.23983, -7.32342);
case 379: return new CityInfo("Aldeia Nova de São Bento", "03", 37.92603, -7.40804);
case 380: return new CityInfo("Aldeia de Paio Pires", "19", 38.61667, -9.08333);
case 381: return new CityInfo("Alcoutim", "09", 37.47432, -7.47228);
case 382: return new CityInfo("Alcoentre", "14", 39.20857, -8.95953);
case 383: return new CityInfo("Alcochete", "19", 38.75534, -8.96086);
case 384: return new CityInfo("Alcobaça", "13", 39.55223, -8.97749);
case 385: return new CityInfo("Alcantarilha", "09", 37.13044, -8.34623);
case 386: return new CityInfo("Alcanhões", "18", 39.29603, -8.65847);
case 387: return new CityInfo("Alcanena", "18", 39.459, -8.66892);
case 388: return new CityInfo("Alcanede", "18", 39.41501, -8.82189);
case 389: return new CityInfo("Alcains", "11", 39.91642, -7.45655);
case 390: return new CityInfo("Alcácer do Sal", "19", 38.37326, -8.51444);
case 391: return new CityInfo("Alcabideche", "14", 38.73366, -9.40928);
case 392: return new CityInfo("Albufeira", "09", 37.08819, -8.2503);
case 393: return new CityInfo("Alandroal", "08", 38.702, -7.40309);
case 394: return new CityInfo("Alagoa", "16", 39.36125, -7.53894);
case 395: return new CityInfo("Água de Pena", "10", 32.70143, -16.77874);
case 396: return new CityInfo("A dos Francos", "13", 39.32272, -9.04743);
case 397: return new CityInfo("A dos Cunhados", "14", 39.15237, -9.2972);
case 398: return new CityInfo("Abrigada", "14", 39.14416, -9.01853);
case 399: return new CityInfo("Abrantes", "18", 39.46667, -8.2);
case 400: return new CityInfo("Vouzela", "22", 40.72361, -8.11283);
case 401: return new CityInfo("Vizela", "04", 41.39096, -8.26389);
case 402: return new CityInfo("Vizela", "17", 41.38242, -8.24887);
case 403: return new CityInfo("Viseu", "22", 40.66101, -7.90971);
case 404: return new CityInfo("Vinhais", "05", 41.83509, -7.00501);
case 405: return new CityInfo("Vimioso", "05", 41.58473, -6.52767);
case 406: return new CityInfo("Vilela", "21", 41.22511, -7.60338);
case 407: return new CityInfo("Vila Verde", "04", 41.64729, -8.43715);
case 408: return new CityInfo("Vila Seca", "04", 41.50031, -8.68525);
case 409: return new CityInfo("Vilarinho", "17", 41.35955, -8.33123);
case 410: return new CityInfo("Vila Real", "21", 41.30062, -7.74413);
case 411: return new CityInfo("Vilar do Paraíso", "17", 41.08974, -8.6211);
case 412: return new CityInfo("Vilar de Figos", "04", 41.47555, -8.65382);
case 413: return new CityInfo("Vilar de Andorinho", "17", 41.10574, -8.58622);
case 414: return new CityInfo("Vila Praia de Âncora", "20", 41.81098, -8.85255);
case 415: return new CityInfo("Vila Pouca de Aguiar", "21", 41.50018, -7.64383);
case 416: return new CityInfo("Vila Nova de Paiva", "22", 40.85291, -7.72791);
case 417: return new CityInfo("Vila Nova de Gaia", "17", 41.12401, -8.61241);
case 418: return new CityInfo("Vila Nova de Foz Côa", "11", 41.08194, -7.14146);
case 419: return new CityInfo("Vila Nova de Famalicão", "04", 41.40797, -8.51978);
case 420: return new CityInfo("Vila Nova de Ceira", "07", 40.18165, -8.15143);
case 421: return new CityInfo("Vila Nova da Telha", "17", 41.0717, -8.64146);
case 422: return new CityInfo("Vila Nova de Cerveira", "20", 41.94118, -8.7423);
case 423: return new CityInfo("Vila Meã", "17", 41.25116, -8.18397);
case 424: return new CityInfo("Vila Frescainha", "04", 41.53846, -8.63971);
case 425: return new CityInfo("Vila do Conde", "17", 41.35326, -8.74516);
case 426: return new CityInfo("Vila Cova", "04", 41.55107, -8.71645);
case 427: return new CityInfo("Vila Chã", "02", 40.86667, -8.46667);
case 428: return new CityInfo("Vilaça", "04", 41.51787, -8.48357);
case 429: return new CityInfo("Vieira do Minho", "04", 41.63292, -8.14252);
case 430: return new CityInfo("Vide", "11", 40.29528, -7.78401);
case 431: return new CityInfo("Viana do Castelo", "20", 41.69323, -8.83287);
case 432: return new CityInfo("Várzea", "04", 41.51512, -8.584);
case 433: return new CityInfo("Valpaços", "21", 41.60746, -7.31088);
case 434: return new CityInfo("Valongo", "17", 41.18883, -8.49857);
case 435: return new CityInfo("Valongo", "02", 40.61667, -8.45);
case 436: return new CityInfo("Vales do Rio", "06", 40.20171, -7.54547);
case 437: return new CityInfo("Valença", "20", 42.03104, -8.64595);
case 438: return new CityInfo("Válega", "02", 40.83629, -8.58061);
case 439: return new CityInfo("Vale de Cambra", "02", 40.8497, -8.39389);
case 440: return new CityInfo("Valbom", "17", 41.12921, -8.56199);
case 441: return new CityInfo("Valadares", "17", 41.14737, -7.9812);
case 442: return new CityInfo("Vairão", "17", 41.3329, -8.66657);
case 443: return new CityInfo("Vagos", "02", 40.556, -8.68175);
case 444: return new CityInfo("Urgeses", "04", 41.4272, -8.29796);
case 445: return new CityInfo("Unhais-o-Velho", "07", 40.13115, -7.81019);
case 446: return new CityInfo("Trofa", "17", 41.33729, -8.5596);
case 447: return new CityInfo("Trevões", "22", 41.08125, -7.43512);
case 448: return new CityInfo("Treixedo", "22", 40.43246, -8.09428);
case 449: return new CityInfo("Travanca", "07", 40.32357, -8.18687);
case 450: return new CityInfo("Trancoso", "11", 40.78329, -7.35016);
case 451: return new CityInfo("Torre de Moncorvo", "05", 41.17454, -7.05364);
case 452: return new CityInfo("Tondela", "22", 40.51682, -8.08087);
case 453: return new CityInfo("Tocha", "07", 40.31308, -8.75339);
case 454: return new CityInfo("Terras de Bouro", "04", 41.71769, -8.30888);
case 455: return new CityInfo("Telões", "17", 41.31054, -8.11101);
case 456: return new CityInfo("Teixoso", "06", 40.31448, -7.45759);
case 457: return new CityInfo("Tebosa", "04", 41.48253, -8.48399);
case 458: return new CityInfo("Tavarede", "07", 40.16692, -8.84568);
case 459: return new CityInfo("Tarouca", "22", 41.01763, -7.77547);
case 460: return new CityInfo("Tabuaço", "22", 41.11615, -7.56793);
case 461: return new CityInfo("Tábua", "07", 40.36207, -8.02936);
case 462: return new CityInfo("Souto", "02", 40.98496, -8.62185);
case 463: return new CityInfo("Soure", "07", 40.05989, -8.62605);
case 464: return new CityInfo("Sobreira", "21", 41.52371, -7.80234);
case 465: return new CityInfo("Sobrado", "17", 41.21041, -8.45488);
case 466: return new CityInfo("Cinfães", "22", 41.07197, -8.08999);
case 467: return new CityInfo("Silvalde", "02", 40.99205, -8.62567);
case 468: return new CityInfo("Sever do Vouga", "02", 40.73459, -8.36722);
case 469: return new CityInfo("Serzedo", "04", 41.40502, -8.22926);
case 470: return new CityInfo("Serzedo", "17", 41.05105, -8.61605);
case 471: return new CityInfo("Serzedelo", "04", 41.40128, -8.36888);
case 472: return new CityInfo("Seroa", "17", 41.26511, -8.42892);
case 473: return new CityInfo("Sernancelhe", "22", 40.89871, -7.49342);
case 474: return new CityInfo("Sermonde", "17", 41.04712, -8.58449);
case 475: return new CityInfo("Sequeira", "11", 40.55364, -7.22594);
case 476: return new CityInfo("Senhora da Hora", "17", 41.18641, -8.65172);
case 477: return new CityInfo("Sendim", "05", 41.38739, -6.42625);
case 478: return new CityInfo("Semelhe", "04", 41.55437, -8.46281);
case 479: return new CityInfo("Selho", "04", 41.41938, -8.34599);
case 480: return new CityInfo("Seia", "11", 40.4151, -7.70859);
case 481: return new CityInfo("Sátão", "22", 40.74177, -7.73285);
case 482: return new CityInfo("São Roque", "02", 40.87216, -8.47149);
case 483: return new CityInfo("São Romão do Coronado", "17", 41.28544, -8.5632);
case 484: return new CityInfo("São Romão", "11", 40.40118, -7.71464);
case 485: return new CityInfo("São Pedro do Sul", "22", 40.75537, -8.07265);
case 486: return new CityInfo("São Pedro de Alva", "07", 40.30044, -8.16623);
case 487: return new CityInfo("São Pedro da Cova", "17", 41.14331, -8.50033);
case 488: return new CityInfo("São Miguel do Couto", "17", 41.33167, -8.46185);
case 489: return new CityInfo("São Mamede de Infesta", "17", 41.19183, -8.61105);
case 490: return new CityInfo("São João de Ver", "02", 40.95527, -8.55117);
case 491: return new CityInfo("São João de Areias", "22", 40.38722, -8.06783);
case 492: return new CityInfo("São João da Pesqueira", "22", 41.14805, -7.40489);
case 493: return new CityInfo("São João da Madeira", "02", 40.9007, -8.4902);
case 494: return new CityInfo("São João", "02", 40.86802, -8.60672);
case 495: return new CityInfo("São Jacinto", "02", 40.66268, -8.72948);
case 496: return new CityInfo("São Félix da Marinha", "17", 41.03555, -8.62259);
case 497: return new CityInfo("Santo Tirso", "17", 41.34257, -8.47746);
case 498: return new CityInfo("Santo Izidoro", "17", 41.21083, -8.14224);
case 499: return new CityInfo("Santo António dos Olivais", "07", 40.21805, -8.40523);
case 500: return new CityInfo("Santa Ovaia", "07", 40.31393, -7.88545);
case 501: return new CityInfo("Santa Marta de Penaguião", "21", 41.20991, -7.78386);
case 502: return new CityInfo("Santa Cruz do Bispo", "17", 41.21462, -8.67406);
case 503: return new CityInfo("Santa Cruz", "21", 41.76007, -7.46834);
case 504: return new CityInfo("Santa Comba Dão", "22", 40.39856, -8.1316);
case 505: return new CityInfo("Santa Clara", "07", 40.19985, -8.44018);
case 506: return new CityInfo("Sangalhos", "02", 40.48678, -8.46968);
case 507: return new CityInfo("Sanfins", "02", 40.92979, -8.52563);
case 508: return new CityInfo("Sandim", "17", 41.03508, -8.507);
case 509: return new CityInfo("Sande", "04", 41.7019, -8.39246);
case 510: return new CityInfo("Samil", "05", 41.77632, -6.75698);
case 511: return new CityInfo("Salreu", "02", 40.73971, -8.5572);
case 512: return new CityInfo("Sabugal", "11", 40.35127, -7.09104);
case 513: return new CityInfo("Sabrosa", "21", 41.26702, -7.57601);
case 514: return new CityInfo("Rubiãis", "20", 41.89614, -8.6253);
case 515: return new CityInfo("Rua", "22", 40.94722, -7.57548);
case 516: return new CityInfo("Ronfe", "04", 41.44146, -8.38412);
case 517: return new CityInfo("Rio Tinto", "17", 41.17872, -8.55953);
case 518: return new CityInfo("Rio Meão", "02", 40.95775, -8.57818);
case 519: return new CityInfo("Rio Mau", "17", 41.40422, -8.67994);
case 520: return new CityInfo("Rio Mau", "17", 41.05542, -8.36891);
case 521: return new CityInfo("Rio de Loba", "22", 40.66596, -7.87781);
case 522: return new CityInfo("Ribeirão", "04", 41.36081, -8.56774);
case 523: return new CityInfo("Ribeira de Pena", "21", 41.52147, -7.80237);
case 524: return new CityInfo("Riba de Ave", "04", 41.39648, -8.38685);
case 525: return new CityInfo("Resende", "22", 41.10582, -7.9665);
case 526: return new CityInfo("Rendufe", "04", 41.62898, -8.40858);
case 527: return new CityInfo("Refojos de Basto", "04", 41.51318, -7.99517);
case 528: return new CityInfo("Recarei", "17", 41.15356, -8.41178);
case 529: return new CityInfo("Rebordosa", "17", 41.22405, -8.40669);
case 530: return new CityInfo("Rebordões", "17", 41.35509, -8.42355);
case 531: return new CityInfo("Real", "04", 41.55841, -8.4433);
case 532: return new CityInfo("Prado", "04", 41.60246, -8.46297);
case 533: return new CityInfo("Póvoa de Varzim", "17", 41.38344, -8.76364);
case 534: return new CityInfo("Póvoa de Lanhoso", "04", 41.57599, -8.27008);
case 535: return new CityInfo("Porto", "17", 41.14961, -8.61099);
case 536: return new CityInfo("Ponte de Lima", "20", 41.76719, -8.58393);
case 537: return new CityInfo("Ponte da Barca", "20", 41.80451, -8.41554);
case 538: return new CityInfo("Ponte", "04", 41.47057, -8.3299);
case 539: return new CityInfo("Poiares", "07", 40.21026, -8.25746);
case 540: return new CityInfo("Pinhel", "11", 40.77403, -7.06675);
case 541: return new CityInfo("Pinhão", "21", 41.19063, -7.54504);
case 542: return new CityInfo("Peso da Régua", "21", 41.16318, -7.78901);
case 543: return new CityInfo("Perozinho", "17", 41.06513, -8.58531);
case 544: return new CityInfo("Perelhal", "04", 41.53075, -8.68982);
case 545: return new CityInfo("Perafita", "17", 41.18252, -8.2545);
case 546: return new CityInfo("Penela", "07", 40.03333, -8.38333);
case 547: return new CityInfo("Penedono", "22", 40.98875, -7.39386);
case 548: return new CityInfo("Penamacor", "06", 40.16895, -7.16987);
case 549: return new CityInfo("Penafiel", "17", 41.20835, -8.28285);
case 550: return new CityInfo("Penacova", "07", 40.26884, -8.28237);
case 551: return new CityInfo("Pedrouços", "17", 41.1888, -8.58624);
case 552: return new CityInfo("Pedroso", "17", 41.41103, -8.74897);
case 553: return new CityInfo("Paredes de Coura", "20", 41.91013, -8.56094);
case 554: return new CityInfo("Paredes", "17", 41.20485, -8.33147);
case 555: return new CityInfo("Pardilhó", "02", 40.79925, -8.62598);
case 556: return new CityInfo("Paradela", "04", 41.46216, -8.68038);
case 557: return new CityInfo("Parada de Gonta", "22", 40.58382, -7.99408);
case 558: return new CityInfo("São Jorge da Beira", "06", 40.16971, -7.76302);
case 559: return new CityInfo("Pampilhosa do Botão", "02", 40.3358, -8.42738);
case 560: return new CityInfo("Pampilhosa da Serra", "07", 40.0462, -7.95182);
case 561: return new CityInfo("Paços de Ferreira", "17", 41.27657, -8.37617);
case 562: return new CityInfo("Paços de Brandão", "02", 40.97541, -8.5835);
case 563: return new CityInfo("Ovar", "02", 40.85862, -8.62513);
case 564: return new CityInfo("Oliveirinha", "02", 40.60715, -8.59198);
case 565: return new CityInfo("Oliveira do Mondego", "07", 40.32305, -8.22367);
case 566: return new CityInfo("Oliveira do Hospital", "07", 40.3618, -7.86014);
case 567: return new CityInfo("Oliveira do Douro", "17", 41.12466, -8.58463);
case 568: return new CityInfo("Oliveira do Bairro", "02", 40.5146, -8.49386);
case 569: return new CityInfo("Oliveira de Frades", "22", 40.73357, -8.17481);
case 570: return new CityInfo("Oliveira de Azemeis", "02", 40.84101, -8.47555);
case 571: return new CityInfo("Oliveira", "04", 41.47819, -8.46965);
case 572: return new CityInfo("Olival", "17", 41.05024, -8.54416);
case 573: return new CityInfo("Oiã", "02", 40.54264, -8.53856);
case 574: return new CityInfo("Nogueira da Regedoura", "02", 41.0053, -8.59195);
case 575: return new CityInfo("Nogueira", "17", 41.24246, -8.58685);
case 576: return new CityInfo("Nelas", "22", 40.53216, -7.85152);
case 577: return new CityInfo("Negrelos", "17", 41.34946, -8.40145);
case 578: return new CityInfo("Negreiros", "04", 41.43552, -8.61398);
case 579: return new CityInfo("Murtosa", "02", 40.73695, -8.6377);
case 580: return new CityInfo("Murça", "21", 41.406, -7.45485);
case 581: return new CityInfo("Mozelos", "20", 41.86774, -8.39776);
case 582: return new CityInfo("Mosteirô", "02", 40.89843, -8.53196);
case 583: return new CityInfo("Mortágua", "22", 40.39675, -8.23234);
case 584: return new CityInfo("Moreira de Conegos", "04", 41.3868, -8.3394);
case 585: return new CityInfo("Moreira", "17", 41.24756, -8.64788);
case 586: return new CityInfo("Moreira", "17", 41.056, -8.38939);
case 587: return new CityInfo("Montemor-o-Velho", "07", 40.17287, -8.68616);
case 588: return new CityInfo("Montalegre", "21", 41.82357, -7.78971);
case 589: return new CityInfo("Monsanto", "06", 40.03921, -7.11477);
case 590: return new CityInfo("Mondim de Basto", "21", 41.41157, -7.95441);
case 591: return new CityInfo("Mondim da Beira", "22", 41.01946, -7.74547);
case 592: return new CityInfo("Monção", "20", 42.07892, -8.48076);
case 593: return new CityInfo("Moimenta da Beira", "22", 40.98383, -7.61765);
case 594: return new CityInfo("Mogadouro", "05", 41.34034, -6.71187);
case 595: return new CityInfo("Mirandela", "05", 41.48739, -7.18695);
case 596: return new CityInfo("Miranda do Douro", "05", 41.49692, -6.27308);
case 597: return new CityInfo("Miranda do Corvo", "07", 40.09318, -8.33261);
case 598: return new CityInfo("Mira", "07", 40.42892, -8.73746);
case 599: return new CityInfo("Mindelo", "17", 41.31527, -8.72124);
case 600: return new CityInfo("Milheirós de Poiares", "02", 40.92163, -8.46788);
case 601: return new CityInfo("Milheirós", "17", 41.21478, -8.58837);
case 602: return new CityInfo("Mesquitela", "22", 40.58564, -7.74658);
case 603: return new CityInfo("Mesão Frio", "21", 41.1598, -7.88954);
case 604: return new CityInfo("Merelim", "04", 41.58568, -8.46555);
case 605: return new CityInfo("Melres", "17", 41.06989, -8.40091);
case 606: return new CityInfo("Meinedo", "17", 41.24827, -8.25807);
case 607: return new CityInfo("Mêda", "11", 40.96635, -7.26163);
case 608: return new CityInfo("Mealhada", "02", 40.37806, -8.44991);
case 609: return new CityInfo("Meadela", "20", 41.70654, -8.79628);
case 610: return new CityInfo("Matosinhos", "17", 41.18207, -8.68908);
case 611: return new CityInfo("Mariz", "04", 41.52823, -8.67081);
case 612: return new CityInfo("Marinhas", "04", 41.55906, -8.78297);
case 613: return new CityInfo("Margaride", "17", 41.36478, -8.19999);
case 614: return new CityInfo("Marco de Canavezes", "17", 41.18389, -8.14864);
case 615: return new CityInfo("Manteigas", "11", 40.4028, -7.53977);
case 616: return new CityInfo("Mangualde", "22", 40.60425, -7.76115);
case 617: return new CityInfo("Maia", "17", 41.23574, -8.6199);
case 618: return new CityInfo("Madalena", "17", 41.21616, -8.33451);
case 619: return new CityInfo("Macieira de Rates", "04", 41.44092, -8.63426);
case 620: return new CityInfo("Macieira de Cambra", "02", 40.85939, -8.37338);
case 621: return new CityInfo("Macedo de Cavaleiros", "05", 41.53816, -6.9611);
case 622: return new CityInfo("Lustosa", "17", 41.34081, -8.31715);
case 623: return new CityInfo("Luso", "02", 40.38429, -8.37845);
case 624: return new CityInfo("Lousada", "17", 41.27822, -8.27993);
case 625: return new CityInfo("Lousã", "07", 40.11673, -8.24921);
case 626: return new CityInfo("Lourosa", "02", 40.9842, -8.55142);
case 627: return new CityInfo("Lorvão", "07", 40.25938, -8.31683);
case 628: return new CityInfo("Loriga", "11", 40.32513, -7.68952);
case 629: return new CityInfo("Lordelo", "04", 41.37411, -8.38016);
case 630: return new CityInfo("Lordelo", "17", 41.23451, -8.40297);
case 631: return new CityInfo("Lobão", "02", 40.98664, -8.48566);
case 632: return new CityInfo("Leça do Bailio", "17", 41.21201, -8.63422);
case 633: return new CityInfo("Leça da Palmeira", "17", 41.191, -8.70027);
case 634: return new CityInfo("Lavra", "17", 41.25935, -8.71849);
case 635: return new CityInfo("Lavos", "07", 40.09363, -8.82826);
case 636: return new CityInfo("Lapa do Lobo", "22", 40.4762, -7.91793);
case 637: return new CityInfo("Lamelas", "17", 41.28742, -8.47458);
case 638: return new CityInfo("Lamego", "22", 41.09741, -7.80991);
case 639: return new CityInfo("Lamas", "04", 41.50265, -8.4345);
case 640: return new CityInfo("Lamas", "02", 40.98597, -8.56923);
case 641: return new CityInfo("Lalim", "22", 41.03945, -7.81605);
case 642: return new CityInfo("Lagoaça", "05", 41.19242, -6.72689);
case 643: return new CityInfo("Lago", "04", 41.62148, -8.41258);
case 644: return new CityInfo("Jovim", "17", 41.11102, -8.51903);
case 645: return new CityInfo("Joane", "04", 41.43906, -8.40846);
case 646: return new CityInfo("Ílhavo", "02", 40.60188, -8.67021);
case 647: return new CityInfo("Gulpilhares", "17", 41.08292, -8.62679);
case 648: return new CityInfo("Guisande", "04", 41.48264, -8.44564);
case 649: return new CityInfo("Guimarães", "04", 41.44443, -8.29619);
case 650: return new CityInfo("Guifões", "17", 41.19748, -8.66899);
case 651: return new CityInfo("Gueral", "04", 41.45859, -8.62946);
case 652: return new CityInfo("Guarda", "11", 40.53733, -7.26575);
case 653: return new CityInfo("Grijó", "17", 41.02836, -8.58017);
case 654: return new CityInfo("Gondomar", "17", 41.14454, -8.53223);
case 655: return new CityInfo("Gondizalves", "04", 41.54158, -8.4557);
case 656: return new CityInfo("Góis", "07", 40.15735, -8.11007);
case 657: return new CityInfo("Godim", "21", 41.17104, -7.80303);
case 658: return new CityInfo("Goães", "04", 41.65893, -8.3094);
case 659: return new CityInfo("Gemunde", "17", 41.26766, -8.64515);
case 660: return new CityInfo("Gandra", "04", 41.52185, -8.76185);
case 661: return new CityInfo("Gandra", "17", 41.20116, -8.43376);
case 662: return new CityInfo("Galegos", "04", 41.56268, -8.57204);
case 663: return new CityInfo("Gafanha da Nazaré", "02", 40.63621, -8.71338);
case 664: return new CityInfo("Gafanha da Encarnação", "02", 40.61806, -8.73303);
case 665: return new CityInfo("Fundão", "06", 40.14025, -7.50135);
case 666: return new CityInfo("Frossos", "04", 41.5659, -8.45134);
case 667: return new CityInfo("Friumes", "07", 40.27226, -8.21572);
case 668: return new CityInfo("Freixo de Numão", "11", 41.06707, -7.22124);
case 669: return new CityInfo("Freixo de Espada à Cinta", "05", 41.09033, -6.80648);
case 670: return new CityInfo("Freamunde", "17", 41.28835, -8.33533);
case 671: return new CityInfo("Frazão", "17", 41.25866, -8.40014);
case 672: return new CityInfo("Fradelos", "04", 41.36846, -8.59887);
case 673: return new CityInfo("Foz do Sousa", "17", 41.09668, -8.50184);
case 674: return new CityInfo("Foz do Douro", "17", 41.15119, -8.67125);
case 675: return new CityInfo("Fornos de Algodres", "11", 40.62807, -7.54064);
case 676: return new CityInfo("Fornelos", "04", 41.51792, -8.67708);
case 677: return new CityInfo("Fontelo", "22", 41.11968, -7.73009);
case 678: return new CityInfo("Figueiró", "17", 41.29922, -8.16779);
case 679: return new CityInfo("Figueira de Castelo Rodrigo", "11", 40.89262, -6.9635);
case 680: return new CityInfo("Figueira da Foz", "07", 40.15085, -8.86179);
case 681: return new CityInfo("Fiães", "02", 40.99446, -8.52537);
case 682: return new CityInfo("Ferreiros", "04", 41.631, -8.36363);
case 683: return new CityInfo("Ferreiros", "04", 41.35, -8.55);
case 684: return new CityInfo("Ferreira", "17", 41.26718, -8.34434);
case 685: return new CityInfo("Felgueiras", "17", 41.36806, -8.19396);
case 686: return new CityInfo("Feira", "02", 40.92535, -8.54277);
case 687: return new CityInfo("Favaios", "21", 41.26876, -7.50465);
case 688: return new CityInfo("Faria", "04", 41.48298, -8.67152);
case 689: return new CityInfo("Apúlia e Fão", "04", 41.51194, -8.77288);
case 690: return new CityInfo("Fânzeres", "17", 41.16754, -8.52981);
case 691: return new CityInfo("Famalicão", "11", 40.44318, -7.37752);
case 692: return new CityInfo("Fafe", "04", 41.45083, -8.17258);
case 693: return new CityInfo("Estela", "17", 41.44944, -8.75166);
case 694: return new CityInfo("Estarreja", "02", 40.75648, -8.57207);
case 695: return new CityInfo("Esposende", "04", 41.5361, -8.78201);
case 696: return new CityInfo("Esporões", "04", 41.51006, -8.41729);
case 697: return new CityInfo("Espinho", "02", 41.00763, -8.64125);
case 698: return new CityInfo("Espargo", "02", 40.92462, -8.57495);
case 699: return new CityInfo("Esmoriz", "02", 40.95773, -8.62753);
case 700: return new CityInfo("Esgueira", "02", 40.64899, -8.62943);
case 701: return new CityInfo("Ervedosa do Douro", "22", 41.16626, -7.47305);
case 702: return new CityInfo("Ermesinde", "17", 41.21653, -8.55318);
case 703: return new CityInfo("Eixo", "02", 40.62758, -8.56922);
case 704: return new CityInfo("Darque", "20", 41.68333, -8.76667);
case 705: return new CityInfo("Custoias", "11", 41.1053, -7.32097);
case 706: return new CityInfo("Cucujães", "02", 40.87413, -8.50687);
case 707: return new CityInfo("Cristelo", "04", 41.47964, -8.69785);
case 708: return new CityInfo("Covilhã", "06", 40.28106, -7.50504);
case 709: return new CityInfo("Cortegaça", "02", 40.94883, -8.6213);
case 710: return new CityInfo("Condeixa-a-Nova", "07", 40.11283, -8.49804);
case 711: return new CityInfo("Coimbra", "07", 40.20564, -8.41955);
case 712: return new CityInfo("Chaves", "21", 41.74019, -7.46879);
case 713: return new CityInfo("Chavão", "04", 41.45235, -8.60194);
case 714: return new CityInfo("Celorico de Basto", "04", 41.38714, -8.00101);
case 715: return new CityInfo("Celorico da Beira", "11", 40.63723, -7.39037);
case 716: return new CityInfo("Castro Daire", "22", 40.8984, -7.93381);
case 717: return new CityInfo("Castelões de Cepeda", "17", 41.20265, -8.33516);
case 718: return new CityInfo("Castelo de Paiva", "02", 41.06301, -8.2647);
case 719: return new CityInfo("Carvalhosa", "17", 41.30057, -8.3608);
case 720: return new CityInfo("Carregal do Sal", "22", 40.43333, -8);
case 721: return new CityInfo("Carrazeda de Anciães", "05", 41.24247, -7.30721);
case 722: return new CityInfo("Carapinheira", "07", 40.2062, -8.6481);
case 723: return new CityInfo("Cantanhede", "07", 40.34671, -8.59419);
case 724: return new CityInfo("Canidelo", "17", 41.12314, -8.64654);
case 725: return new CityInfo("Canelas", "17", 41.08333, -8.6);
case 726: return new CityInfo("Candoso", "04", 41.42768, -8.32166);
case 727: return new CityInfo("Canas de Senhorim", "22", 40.50012, -7.89874);
case 728: return new CityInfo("Campo de Besteiros", "22", 40.55655, -8.13432);
case 729: return new CityInfo("Campo", "17", 41.18516, -8.46493);
case 730: return new CityInfo("Campo", "22", 40.71086, -7.91445);
case 731: return new CityInfo("Calendário", "04", 41.40361, -8.52967);
case 732: return new CityInfo("Caldelas", "04", 41.67101, -8.38148);
case 733: return new CityInfo("Caldas de Vizela", "04", 41.38212, -8.3089);
case 734: return new CityInfo("Caldas das Taipas", "04", 41.48465, -8.3485);
case 735: return new CityInfo("Cabeceiras de Basto", "04", 41.51431, -7.98942);
case 736: return new CityInfo("Cabanas de Viriato", "22", 40.47662, -7.97445);
case 737: return new CityInfo("Buarcos", "07", 40.16604, -8.8768);
case 738: return new CityInfo("Brito", "04", 41.45821, -8.36103);
case 739: return new CityInfo("Britiande", "22", 41.06287, -7.79245);
case 740: return new CityInfo("Branca", "02", 40.76653, -8.48262);
case 741: return new CityInfo("Bragança", "05", 41.80582, -6.75719);
case 742: return new CityInfo("Braga", "04", 41.55032, -8.42005);
case 743: return new CityInfo("Bougado", "17", 41.33979, -8.5518);
case 744: return new CityInfo("Boticas", "21", 41.68939, -7.66914);
case 745: return new CityInfo("Belver", "05", 41.24696, -7.27594);
case 746: return new CityInfo("Belmonte", "06", 40.3593, -7.34869);
case 747: return new CityInfo("Belazaima do Chão", "02", 40.53215, -8.36572);
case 748: return new CityInfo("Beiriz de Baixo", "17", 41.39727, -8.72385);
case 749: return new CityInfo("Beduido", "02", 40.76427, -8.5611);
case 750: return new CityInfo("Barrosas", "17", 41.35534, -8.29943);
case 751: return new CityInfo("Barroca Grande", "06", 40.1539, -7.74897);
case 752: return new CityInfo("Barqueiros", "04", 41.49111, -8.73192);
case 753: return new CityInfo("Barco", "06", 40.1741, -7.60813);
case 754: return new CityInfo("Barcelos", "04", 41.53174, -8.61843);
case 755: return new CityInfo("Baltar", "17", 41.19272, -8.38768);
case 756: return new CityInfo("Balazar", "17", 41.40435, -8.62386);
case 757: return new CityInfo("Baião", "17", 41.16273, -8.0347);
case 758: return new CityInfo("Baguim do Monte", "17", 41.19203, -8.54118);
case 759: return new CityInfo("Azenha", "17", 41.07651, -8.62468);
case 760: return new CityInfo("Avô", "07", 40.29273, -7.90288);
case 761: return new CityInfo("Avintes", "17", 41.10711, -8.55131);
case 762: return new CityInfo("Aves", "17", 41.37034, -8.4101);
case 763: return new CityInfo("Aver-o-Mar", "17", 41.40607, -8.77958);
case 764: return new CityInfo("Aveleda", "04", 41.52113, -8.46682);
case 765: return new CityInfo("Aveiro", "02", 40.64427, -8.64554);
case 766: return new CityInfo("Avanca", "02", 40.80771, -8.5722);
case 767: return new CityInfo("Assafarge", "07", 40.15895, -8.43167);
case 768: return new CityInfo("Árvore", "17", 41.33922, -8.71806);
case 769: return new CityInfo("Arrifana", "02", 40.91565, -8.49657);
case 770: return new CityInfo("Arouca", "02", 40.93057, -8.24488);
case 771: return new CityInfo("Arões", "04", 41.45553, -8.21419);
case 772: return new CityInfo("Armamar", "22", 41.10765, -7.69139);
case 773: return new CityInfo("Argoncilhe", "02", 41.02541, -8.53885);
case 774: return new CityInfo("Argivai", "17", 41.37744, -8.72987);
case 775: return new CityInfo("Arganil", "07", 40.21826, -8.05403);
case 776: return new CityInfo("Areosa", "20", 41.71779, -8.85707);
case 777: return new CityInfo("Arcozelo", "17", 41.06187, -8.63192);
case 778: return new CityInfo("Arcos de Valdevez", "20", 41.84668, -8.41905);
case 779: return new CityInfo("Arcos", "04", 41.52185, -8.42151);
case 780: return new CityInfo("Arcos", "17", 41.39629, -8.66685);
case 781: return new CityInfo("Arcos", "02", 40.44779, -8.44171);
case 782: return new CityInfo("Arazede", "07", 40.28627, -8.64999);
case 783: return new CityInfo("Aradas", "02", 40.62084, -8.64195);
case 784: return new CityInfo("Apúlia", "04", 41.48512, -8.76413);
case 785: return new CityInfo("Anta", "17", 41.26634, -8.62844);
case 786: return new CityInfo("Ançã", "07", 40.27161, -8.5209);
case 787: return new CityInfo("Anadia", "02", 40.43841, -8.43352);
case 788: return new CityInfo("Amorim", "17", 41.40503, -8.75046);
case 789: return new CityInfo("Amares", "04", 41.63091, -8.35117);
case 790: return new CityInfo("Amarante", "17", 41.27271, -8.08245);
case 791: return new CityInfo("Alvito", "04", 41.49872, -8.00386);
case 792: return new CityInfo("Alpendurada", "17", 41.08944, -8.24643);
case 793: return new CityInfo("Alijó", "21", 41.27644, -7.47489);
case 794: return new CityInfo("Alhadas", "07", 40.18607, -8.79057);
case 795: return new CityInfo("Alfena", "17", 41.23671, -8.52454);
case 796: return new CityInfo("Alfarelos", "07", 40.15057, -8.65326);
case 797: return new CityInfo("Alfândega da Fé", "05", 41.34315, -6.96112);
case 798: return new CityInfo("Aldeia de Joanes", "06", 40.13905, -7.51694);
case 799: return new CityInfo("Albergaria-a-Velha", "02", 40.69318, -8.47994);
case 800: return new CityInfo("Aguiar da Beira", "11", 40.81726, -7.54431);
case 801: return new CityInfo("Águeda", "02", 40.5772, -8.44442);
case 802: return new CityInfo("Aguçadoura", "17", 41.43116, -8.77844);
case 803: return new CityInfo("Águas Santas", "17", 41.21017, -8.57599);
case 804: return new CityInfo("Água Longa", "17", 41.24972, -8.49285);
case 805: return new CityInfo("Aguada de Cima", "02", 40.52291, -8.427);
case 806: return new CityInfo("Adaúfe", "04", 41.58732, -8.39817);
case 807: return new CityInfo("Abraveses", "22", 40.68137, -7.92102);
case 808: return new CityInfo("Aboim da Nóbrega", "04", 41.74892, -8.39208);
case 809: return new CityInfo("Vila Franca do Campo", "23", 37.71667, -25.43333);
case 810: return new CityInfo("Velas", "23", 38.68182, -28.20909);
case 811: return new CityInfo("Urzelina", "23", 38.65, -28.13333);
case 812: return new CityInfo("Sete Cidades", "23", 37.85832, -25.79435);
case 813: return new CityInfo("Senhora do Rosário", "23", 37.83333, -25.15);
case 814: return new CityInfo("São Vicente", "23", 37.81829, -25.66583);
case 815: return new CityInfo("São Sebastião", "23", 38.66584, -27.08976);
case 816: return new CityInfo("São Roque do Pico", "23", 38.51631, -28.30752);
case 817: return new CityInfo("São Roque", "23", 37.75418, -25.64127);
case 818: return new CityInfo("São Mateus", "23", 38.6563, -27.26935);
case 819: return new CityInfo("São Bartolomeu", "23", 38.67491, -27.29349);
case 820: return new CityInfo("Santo Antão", "23", 38.55, -27.8);
case 821: return new CityInfo("Santa Cruz das Flores", "23", 39.45782, -31.12989);
case 822: return new CityInfo("Santa Cruz da Graciosa", "23", 39.08577, -28.0058);
case 823: return new CityInfo("Santa Bárbara", "23", 38.69608, -27.33907);
case 824: return new CityInfo("Rosto de Cão", "23", 37.75, -25.65);
case 825: return new CityInfo("Rosais", "23", 38.71667, -28.25);
case 826: return new CityInfo("Ribeirinha", "23", 38.66203, -27.18093);
case 827: return new CityInfo("Ribeira Seca", "23", 38.6, -27.98333);
case 828: return new CityInfo("Ribeira Seca", "23", 37.81667, -25.53333);
case 829: return new CityInfo("Ribeira Seca", "23", 37.722, -25.41791);
case 830: return new CityInfo("Ribeira Quente", "23", 37.73333, -25.3);
case 831: return new CityInfo("Ribeira Grande", "23", 38.51667, -28.7);
case 832: return new CityInfo("Ribeira Grande", "23", 37.82175, -25.52141);
case 833: return new CityInfo("Ribeira das Tainhas", "23", 37.71766, -25.40551);
case 834: return new CityInfo("Relva", "23", 37.75271, -25.71848);
case 835: return new CityInfo("Rabo de Peixe", "23", 37.81022, -25.58263);
case 836: return new CityInfo("Praia da Vitória", "23", 38.73333, -27.06667);
case 837: return new CityInfo("Praia da Graciosa", "23", 39.05154, -27.97107);
case 838: return new CityInfo("Povoação", "23", 37.75, -25.25);
case 839: return new CityInfo("Porto Martins", "23", 38.68146, -27.05835);
case 840: return new CityInfo("Porto Judeu", "23", 38.64814, -27.11944);
case 841: return new CityInfo("Ponta Garça", "23", 37.71667, -25.36667);
case 842: return new CityInfo("Mosteiros", "23", 37.89017, -25.81999);
case 843: return new CityInfo("Maia", "23", 37.83247, -25.38976);
case 844: return new CityInfo("Madalena", "23", 38.53642, -28.5266);
case 845: return new CityInfo("Lajes", "23", 38.76352, -27.10336);
case 846: return new CityInfo("Lajes", "23", 38.39529, -28.2522);
case 847: return new CityInfo("Lajes das Flores", "23", 39.37744, -31.17847);
case 848: return new CityInfo("Lagoa", "23", 37.74486, -25.57184);
case 849: return new CityInfo("Horta", "23", 38.53737, -28.62615);
case 850: return new CityInfo("Furnas", "23", 37.77567, -25.31035);
case 851: return new CityInfo("Fonte Bastardo", "23", 38.69201, -27.07942);
case 852: return new CityInfo("Feteira", "23", 38.65429, -27.14995);
case 853: return new CityInfo("Fenais da Luz", "23", 37.8249, -25.64229);
case 854: return new CityInfo("Fenais da Ajuda", "23", 37.85128, -25.32406);
case 855: return new CityInfo("Fajã de Baixo", "23", 37.75, -25.65);
case 856: return new CityInfo("Cedros", "23", 38.63551, -28.69438);
case 857: return new CityInfo("Castelo Branco", "23", 38.52198, -28.71365);
case 858: return new CityInfo("Calheta", "23", 38.60186, -28.01792);
case 859: return new CityInfo("Cais do Pico", "23", 38.52531, -28.32074);
case 860: return new CityInfo("Cabouco", "23", 37.76667, -25.56667);
case 861: return new CityInfo("Cabo da Praia", "23", 38.7073, -27.05655);
case 862: return new CityInfo("Biscoitos", "23", 38.78333, -27.25);
case 863: return new CityInfo("Bandeiras", "23", 38.53912, -28.46306);
case 864: return new CityInfo("Arrifes", "23", 37.76667, -25.7);
case 865: return new CityInfo("Angústias", "23", 38.52547, -28.63132);
case 866: return new CityInfo("Angra do Heroísmo", "23", 38.65483, -27.21734);
case 867: return new CityInfo("Água de Pau", "23", 37.72142, -25.5117);
case 868: return new CityInfo("Vilamoura", "09", 37.08728, -8.11701);
case 869: return new CityInfo("Vila Nova De Cacela", "09", 37.17391, -7.53169);
case 870: return new CityInfo("Quinta Do Conde", "19", 38.56528, -9.04316);
case 871: return new CityInfo("Prior Velho", "14", 38.79174, -9.12119);
case 872: return new CityInfo("Valenza", "20", 42.02418, -8.63474);
case 873: return new CityInfo("Alfragide", "14", 38.73203, -9.2192);
case 874: return new CityInfo("Alvalade", "14", 38.75328, -9.14397);
case 875: return new CityInfo("Odeceixe", "09", 37.43289, -8.77065);
case 876: return new CityInfo("Ponta Delgada", "23", 37.73952, -25.66874);
case 877: return new CityInfo("Santos-o-Velho", "14", 38.7069, -9.15611);
case 878: return new CityInfo("Vila", "20", 42.0304, -8.1588);
case 879: return new CityInfo("Salir do Porto", "13", 39.4953, -9.15625);
case 880: return new CityInfo("Cabanas de Tavira", "09", 37.13521, -7.60048);
case 881: return new CityInfo("Santo Isidoro", "14", 38.99593, -9.3994);
case 882: return new CityInfo("Azeitão", "19", 38.51919, -9.0139);
default: return new CityInfo("Moitas Venda", "18", 39.49274, -8.66024);

                                    }                                        
                                }
                            
                        }
                    }
                