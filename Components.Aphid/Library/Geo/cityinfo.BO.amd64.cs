
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
                                    public const string Country = "BO";
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
                            
                                        var cur = (Math.Abs(-18.28333 - lat) + Math.Abs(-59.81667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-16.36667 - lat) + Math.Abs(-58.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.33473 - lat) + Math.Abs(-59.76142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78333 - lat) + Math.Abs(-57.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.71828 - lat) + Math.Abs(-65.39544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.18929 - lat) + Math.Abs(-65.12329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.01643 - lat) + Math.Abs(-63.67753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5163 - lat) + Math.Abs(-63.16778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.95 - lat) + Math.Abs(-67.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.08659 - lat) + Math.Abs(-65.59422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4 - lat) + Math.Abs(-63.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.12489 - lat) + Math.Abs(-64.32343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.15861 - lat) + Math.Abs(-65.26417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.26235 - lat) + Math.Abs(-63.46903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.72278 - lat) + Math.Abs(-64.88478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.48923 - lat) + Math.Abs(-64.10609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.45967 - lat) + Math.Abs(-66.82503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.39286 - lat) + Math.Abs(-62.94661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.44345 - lat) + Math.Abs(-65.71875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.83333 - lat) + Math.Abs(-64.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.49587 - lat) + Math.Abs(-66.8738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.72662 - lat) + Math.Abs(-65.1932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.18333 - lat) + Math.Abs(-64.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.58333 - lat) + Math.Abs(-67.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.33801 - lat) + Math.Abs(-66.21579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.55228 - lat) + Math.Abs(-68.67953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53549 - lat) + Math.Abs(-64.72956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.60898 - lat) + Math.Abs(-66.02135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.18168 - lat) + Math.Abs(-64.91517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.03332 - lat) + Math.Abs(-65.26274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.34 - lat) + Math.Abs(-64.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.77305 - lat) + Math.Abs(-68.64973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.45 - lat) + Math.Abs(-66.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.93333 - lat) + Math.Abs(-63.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.98674 - lat) + Math.Abs(-63.38118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.10916 - lat) + Math.Abs(-63.59514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16667 - lat) + Math.Abs(-66.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.96667 - lat) + Math.Abs(-63.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.55 - lat) + Math.Abs(-64.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78629 - lat) + Math.Abs(-63.18117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.91667 - lat) + Math.Abs(-66.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.74406 - lat) + Math.Abs(-65.42688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.28333 - lat) + Math.Abs(-64.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.61667 - lat) + Math.Abs(-64.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.23717 - lat) + Math.Abs(-68.85063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.21667 - lat) + Math.Abs(-68.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78333 - lat) + Math.Abs(-62.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.48333 - lat) + Math.Abs(-63.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.26667 - lat) + Math.Abs(-65.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.36667 - lat) + Math.Abs(-60.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.71667 - lat) + Math.Abs(-64.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4 - lat) + Math.Abs(-63.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.18005 - lat) + Math.Abs(-63.87552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.88333 - lat) + Math.Abs(-64.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.39799 - lat) + Math.Abs(-66.03825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.44125 - lat) + Math.Abs(-67.52781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58333 - lat) + Math.Abs(-63.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.00654 - lat) + Math.Abs(-66.06312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2952 - lat) + Math.Abs(-67.33624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.98333 - lat) + Math.Abs(-67.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.39228 - lat) + Math.Abs(-66.27838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.54234 - lat) + Math.Abs(-65.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.23333 - lat) + Math.Abs(-65.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.65 - lat) + Math.Abs(-62.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.92944 - lat) + Math.Abs(-64.93917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.58361 - lat) + Math.Abs(-65.75306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.00556 - lat) + Math.Abs(-65.52861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35168 - lat) + Math.Abs(-63.39282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.38026 - lat) + Math.Abs(-66.96695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.83333 - lat) + Math.Abs(-65.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.75 - lat) + Math.Abs(-65.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.95 - lat) + Math.Abs(-64.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88333 - lat) + Math.Abs(-62.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.2358 - lat) + Math.Abs(-67.92169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.65 - lat) + Math.Abs(-62.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.30878 - lat) + Math.Abs(-64.30273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.98333 - lat) + Math.Abs(-67.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.23333 - lat) + Math.Abs(-62.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.33866 - lat) + Math.Abs(-63.2505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.79989 - lat) + Math.Abs(-63.95461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.91667 - lat) + Math.Abs(-65.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.7641 - lat) + Math.Abs(-64.61978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.94101 - lat) + Math.Abs(-65.34016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.11876 - lat) + Math.Abs(-63.231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.04611 - lat) + Math.Abs(-65.42861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.25 - lat) + Math.Abs(-68.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.11919 - lat) + Math.Abs(-63.95965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.17251 - lat) + Math.Abs(-67.02099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.73333 - lat) + Math.Abs(-63.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.42426 - lat) + Math.Abs(-66.58388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.76667 - lat) + Math.Abs(-65.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.03104 - lat) + Math.Abs(-63.40523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.25 - lat) + Math.Abs(-65.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.2084 - lat) + Math.Abs(-65.20988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.5 - lat) + Math.Abs(-68.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.37054 - lat) + Math.Abs(-67.67501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93333 - lat) + Math.Abs(-64.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.55 - lat) + Math.Abs(-63.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.05514 - lat) + Math.Abs(-63.42821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.03574 - lat) + Math.Abs(-69.14843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.71667 - lat) + Math.Abs(-66.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.08389 - lat) + Math.Abs(-66.81804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.16972 - lat) + Math.Abs(-65.32611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2 - lat) + Math.Abs(-68.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.01667 - lat) + Math.Abs(-65.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2 - lat) + Math.Abs(-68.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.289 - lat) + Math.Abs(-66.83583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.6 - lat) + Math.Abs(-64.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.79298 - lat) + Math.Abs(-68.26157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.8258 - lat) + Math.Abs(-65.3581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.49756 - lat) + Math.Abs(-67.88332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.52661 - lat) + Math.Abs(-64.17299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.86667 - lat) + Math.Abs(-68.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.82358 - lat) + Math.Abs(-64.94492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.81667 - lat) + Math.Abs(-63.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.74959 - lat) + Math.Abs(-62.83442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.19386 - lat) + Math.Abs(-67.72998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.3 - lat) + Math.Abs(-67.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.43333 - lat) + Math.Abs(-60.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.91537 - lat) + Math.Abs(-64.53163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.38918 - lat) + Math.Abs(-67.12671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.70031 - lat) + Math.Abs(-66.00397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35 - lat) + Math.Abs(-65.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.3 - lat) + Math.Abs(-66.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.31667 - lat) + Math.Abs(-66.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.3895 - lat) + Math.Abs(-66.1568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.02671 - lat) + Math.Abs(-68.76918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.58777 - lat) + Math.Abs(-65.93253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.81667 - lat) + Math.Abs(-65.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.40855 - lat) + Math.Abs(-67.5294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.99417 - lat) + Math.Abs(-65.1533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.01667 - lat) + Math.Abs(-65.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.79151 - lat) + Math.Abs(-63.19864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.90208 - lat) + Math.Abs(-66.77048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.75 - lat) + Math.Abs(-63.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.71113 - lat) + Math.Abs(-66.26082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03849 - lat) + Math.Abs(-63.51833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.98333 - lat) + Math.Abs(-63.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.64064 - lat) + Math.Abs(-65.20893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4583 - lat) + Math.Abs(-63.67126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.43227 - lat) + Math.Abs(-63.28147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.55293 - lat) + Math.Abs(-65.45395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73206 - lat) + Math.Abs(-64.33724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.36667 - lat) + Math.Abs(-67.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.3 - lat) + Math.Abs(-68.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10613 - lat) + Math.Abs(-64.41398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93515 - lat) + Math.Abs(-66.22139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.7 - lat) + Math.Abs(-63.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.56854 - lat) + Math.Abs(-65.76883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.77934 - lat) + Math.Abs(-67.50753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.23675 - lat) + Math.Abs(-68.98462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.20408 - lat) + Math.Abs(-65.18068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.05 - lat) + Math.Abs(-68.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.88279 - lat) + Math.Abs(-63.38026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.68587 - lat) + Math.Abs(-65.13912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.88395 - lat) + Math.Abs(-68.41989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.89299 - lat) + Math.Abs(-63.18855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.90818 - lat) + Math.Abs(-63.03955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.80623 - lat) + Math.Abs(-62.89536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.663 - lat) + Math.Abs(-62.81227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.85195 - lat) + Math.Abs(-66.74954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("San Pedro", "08", -18.28333, -59.81667);
case 1: return new CityInfo("San Matías", "08", -16.36667, -58.4);
case 2: return new CityInfo("Roboré", "08", -18.33473, -59.76142);
case 3: return new CityInfo("Puerto Quijarro", "08", -17.78333, -57.76667);
case 4: return new CityInfo("Nueva Manoa", "06", -9.71828, -65.39544);
case 5: return new CityInfo("Yamparáez", "01", -19.18929, -65.12329);
case 6: return new CityInfo("Yacuiba", "09", -22.01643, -63.67753);
case 7: return new CityInfo("Warnes", "08", -17.5163, -63.16778);
case 8: return new CityInfo("Viloco", "04", -16.95, -67.55);
case 9: return new CityInfo("Villazón", "07", -22.08659, -65.59422);
case 10: return new CityInfo("Villa Yapacaní", "08", -17.4, -63.83333);
case 11: return new CityInfo("Villa Serrano", "01", -19.12489, -64.32343);
case 12: return new CityInfo("Yotala", "01", -19.15861, -65.26417);
case 13: return new CityInfo("Villamontes", "09", -21.26235, -63.46903);
case 14: return new CityInfo("Villa Charcas", "01", -20.72278, -64.88478);
case 15: return new CityInfo("Vallegrande", "08", -18.48923, -64.10609);
case 16: return new CityInfo("Uyuni", "07", -20.45967, -66.82503);
case 17: return new CityInfo("Urubichá", "08", -15.39286, -62.94661);
case 18: return new CityInfo("Tupiza", "07", -21.44345, -65.71875);
case 19: return new CityInfo("Trinidad", "03", -14.83333, -64.9);
case 20: return new CityInfo("Totoral", "05", -18.49587, -66.8738);
case 21: return new CityInfo("Totora", "02", -17.72662, -65.1932);
case 22: return new CityInfo("Tomina", "01", -19.18333, -64.53333);
case 23: return new CityInfo("Eucaliptus", "04", -17.58333, -67.51667);
case 24: return new CityInfo("Tiquipaya", "02", -17.33801, -66.21579);
case 25: return new CityInfo("Tiahuanaco", "04", -16.55228, -68.67953);
case 26: return new CityInfo("Tarija", "09", -21.53549, -64.72956);
case 27: return new CityInfo("Tarata", "02", -17.60898, -66.02135);
case 28: return new CityInfo("Tarabuco", "01", -19.18168, -64.91517);
case 29: return new CityInfo("Sucre", "01", -19.03332, -65.26274);
case 30: return new CityInfo("Sotomayor", "01", -19.34, -64.99917);
case 31: return new CityInfo("Sorata", "04", -15.77305, -68.64973);
case 32: return new CityInfo("Sipe Sipe", "02", -17.45, -66.38333);
case 33: return new CityInfo("Sapirangui", "01", -19.93333, -63.78333);
case 34: return new CityInfo("Santiago del Torno", "08", -17.98674, -63.38118);
case 35: return new CityInfo("Santa Rosa del Sara", "08", -17.10916, -63.59514);
case 36: return new CityInfo("Santa Rosa", "03", -14.16667, -66.88333);
case 37: return new CityInfo("Santa Rita", "08", -17.96667, -63.35);
case 38: return new CityInfo("Santa Elena", "01", -20.55, -64.78333);
case 39: return new CityInfo("Santa Cruz de la Sierra", "08", -17.78629, -63.18117);
case 40: return new CityInfo("Santa Bárbara", "07", -20.91667, -66.05);
case 41: return new CityInfo("Santa Ana de Yacuma", "03", -13.74406, -65.42688);
case 42: return new CityInfo("San Ramón", "03", -13.28333, -64.71667);
case 43: return new CityInfo("San Pedro", "01", -19.61667, -64.5);
case 44: return new CityInfo("San Pedro", "04", -16.23717, -68.85063);
case 45: return new CityInfo("San Pablo", "04", -16.21667, -68.83333);
case 46: return new CityInfo("San Julian", "08", -17.78333, -62.86667);
case 47: return new CityInfo("San Juan del Surutú", "08", -17.48333, -63.7);
case 48: return new CityInfo("San Juan", "01", -21.26667, -65.3);
case 49: return new CityInfo("San Ignacio de Velasco", "08", -16.36667, -60.95);
case 50: return new CityInfo("San Francisco", "01", -20.71667, -64.7);
case 51: return new CityInfo("San Carlos", "08", -17.4, -63.75);
case 52: return new CityInfo("Samaipata", "08", -18.18005, -63.87552);
case 53: return new CityInfo("Salitre", "01", -20.88333, -64.91667);
case 54: return new CityInfo("Sacaba", "02", -17.39799, -66.03825);
case 55: return new CityInfo("Rurrenabaque", "03", -14.44125, -67.52781);
case 56: return new CityInfo("Rosario del Ingre", "01", -20.58333, -63.9);
case 57: return new CityInfo("Riberalta", "03", -11.00654, -66.06312);
case 58: return new CityInfo("Reyes", "03", -14.2952, -67.33624);
case 59: return new CityInfo("Quime", "04", -16.98333, -67.21667);
case 60: return new CityInfo("Quillacollo", "02", -17.39228, -66.27838);
case 61: return new CityInfo("Punata", "02", -17.54234, -65.83472);
case 62: return new CityInfo("Pulqui", "01", -19.23333, -65.21667);
case 63: return new CityInfo("Puesto de Pailas", "08", -17.65, -62.8);
case 64: return new CityInfo("Presto", "01", -18.92944, -64.93917);
case 65: return new CityInfo("Potosí", "07", -19.58361, -65.75306);
case 66: return new CityInfo("Potolo", "01", -19.00556, -65.52861);
case 67: return new CityInfo("Portachuelo", "08", -17.35168, -63.39282);
case 68: return new CityInfo("Poopó", "05", -18.38026, -66.96695);
case 69: return new CityInfo("Pocpo", "01", -18.83333, -65.36667);
case 70: return new CityInfo("Piocera", "01", -18.75, -65.4);
case 71: return new CityInfo("Pilaya", "01", -20.95, -64.75);
case 72: return new CityInfo("Paurito", "08", -17.88333, -62.96667);
case 73: return new CityInfo("Patacamaya", "04", -17.2358, -67.92169);
case 74: return new CityInfo("Pailón", "08", -17.65, -62.75);
case 75: return new CityInfo("Padilla", "01", -19.30878, -64.30273);
case 76: return new CityInfo("Oruro", "05", -17.98333, -67.15);
case 77: return new CityInfo("Okinawa Número Uno", "08", -17.23333, -62.81667);
case 78: return new CityInfo("Montero", "08", -17.33866, -63.2505);
case 79: return new CityInfo("Monteagudo", "01", -19.79989, -63.95461);
case 80: return new CityInfo("Mojotoro", "01", -18.91667, -65.06667);
case 81: return new CityInfo("Mojocoya", "01", -18.7641, -64.61978);
case 82: return new CityInfo("Mizque", "02", -17.94101, -65.34016);
case 83: return new CityInfo("Mineros", "08", -17.11876, -63.231);
case 84: return new CityInfo("Maragua", "01", -19.04611, -65.42861);
case 85: return new CityInfo("Mapiri", "04", -15.25, -68.16667);
case 86: return new CityInfo("Mairana", "08", -18.11919, -63.95965);
case 87: return new CityInfo("Machacamarca", "05", -18.17251, -67.02099);
case 88: return new CityInfo("Los Negros", "08", -17.73333, -63.43333);
case 89: return new CityInfo("Llallagua", "07", -18.42426, -66.58388);
case 90: return new CityInfo("Lintaca", "01", -20.76667, -65.33333);
case 91: return new CityInfo("Limoncito", "08", -18.03104, -63.40523);
case 92: return new CityInfo("Las Carreras", "01", -21.25, -65.28333);
case 93: return new CityInfo("Las Carreras", "01", -21.2084, -65.20988);
case 94: return new CityInfo("La Paz", "04", -16.5, -68.15);
case 95: return new CityInfo("Lahuachaca", "04", -17.37054, -67.67501);
case 96: return new CityInfo("La Cueva", "01", -20.93333, -64.9);
case 97: return new CityInfo("La Bélgica", "08", -17.55, -63.21667);
case 98: return new CityInfo("Jorochito", "08", -18.05514, -63.42821);
case 99: return new CityInfo("Yumani", "04", -16.03574, -69.14843);
case 100: return new CityInfo("Irpa Irpa", "02", -17.71667, -66.26667);
case 101: return new CityInfo("Independencia", "02", -17.08389, -66.81804);
case 102: return new CityInfo("Huayllas", "01", -19.16972, -65.32611);
case 103: return new CityInfo("Huatajata", "04", -16.2, -68.68333);
case 104: return new CityInfo("Huata", "01", -19.01667, -65.25);
case 105: return new CityInfo("Huarina", "04", -16.2, -68.63333);
case 106: return new CityInfo("Huanuni", "05", -18.289, -66.83583);
case 107: return new CityInfo("Huajlaya", "01", -20.6, -64.55);
case 108: return new CityInfo("Huachacalla", "05", -18.79298, -68.26157);
case 109: return new CityInfo("Guayaramerín", "03", -10.8258, -65.3581);
case 110: return new CityInfo("Guanay", "04", -15.49756, -67.88332);
case 111: return new CityInfo("Entre Ríos", "09", -21.52661, -64.17299);
case 112: return new CityInfo("Curahuara de Carangas", "04", -17.86667, -68.43333);
case 113: return new CityInfo("Culpina", "01", -20.82358, -64.94492);
case 114: return new CityInfo("Cotoca", "08", -17.81667, -63.05);
case 115: return new CityInfo("Cotoca", "08", -17.74959, -62.83442);
case 116: return new CityInfo("Coroico", "04", -16.19386, -67.72998);
case 117: return new CityInfo("Coripata", "04", -16.3, -67.6);
case 118: return new CityInfo("Concepción", "08", -16.43333, -60.9);
case 119: return new CityInfo("Comarapa", "08", -17.91537, -64.53163);
case 120: return new CityInfo("Colquiri", "04", -17.38918, -67.12671);
case 121: return new CityInfo("Colquechaca", "07", -18.70031, -66.00397);
case 122: return new CityInfo("Colomi", "02", -17.35, -65.86667);
case 123: return new CityInfo("Colchani", "07", -20.3, -66.93333);
case 124: return new CityInfo("Colchani", "02", -17.31667, -66.71667);
case 125: return new CityInfo("Cochabamba", "02", -17.3895, -66.1568);
case 126: return new CityInfo("Cobija", "06", -11.02671, -68.76918);
case 127: return new CityInfo("Cliza", "02", -17.58777, -65.93253);
case 128: return new CityInfo("Chuqui Chuqui", "01", -18.81667, -65.06667);
case 129: return new CityInfo("Chulumani", "04", -16.40855, -67.5294);
case 130: return new CityInfo("Chimoré", "02", -16.99417, -65.1533);
case 131: return new CityInfo("Chaunaca", "01", -19.01667, -65.46667);
case 132: return new CityInfo("Charagua", "08", -19.79151, -63.19864);
case 133: return new CityInfo("Challapata", "05", -18.90208, -66.77048);
case 134: return new CityInfo("Carandayti", "01", -20.75, -63.06667);
case 135: return new CityInfo("Capinota", "02", -17.71113, -66.26082);
case 136: return new CityInfo("Camiri", "08", -20.03849, -63.51833);
case 137: return new CityInfo("Camatindi", "01", -20.98333, -63.43333);
case 138: return new CityInfo("Camargo", "01", -20.64064, -65.20893);
case 139: return new CityInfo("Buena Vista", "08", -17.4583, -63.67126);
case 140: return new CityInfo("Boyuibe", "08", -20.43227, -63.28147);
case 141: return new CityInfo("Betanzos", "07", -19.55293, -65.45395);
case 142: return new CityInfo("Bermejo", "09", -22.73206, -64.33724);
case 143: return new CityInfo("Belen", "04", -17.36667, -67.55);
case 144: return new CityInfo("Batallas", "04", -16.3, -68.53333);
case 145: return new CityInfo("Azurduy", "01", -20.10613, -64.41398);
case 146: return new CityInfo("Atocha", "07", -20.93515, -66.22139);
case 147: return new CityInfo("Ascensión", "08", -15.7, -63.08333);
case 148: return new CityInfo("Arani", "02", -17.56854, -65.76883);
case 149: return new CityInfo("Andamarca", "05", -18.77934, -67.50753);
case 150: return new CityInfo("Amarete", "04", -15.23675, -68.98462);
case 151: return new CityInfo("Aiquile", "02", -18.20408, -65.18068);
case 152: return new CityInfo("Achacachi", "04", -16.05, -68.68333);
case 153: return new CityInfo("Abapó", "08", -18.88279, -63.38026);
case 154: return new CityInfo("Cañada Hornillos", "02", -17.68587, -65.13912);
case 155: return new CityInfo("Cruz de Machacamarca", "05", -18.88395, -68.41989);
case 156: return new CityInfo("Ascención de Guarayos", "08", -15.89299, -63.18855);
case 157: return new CityInfo("Santa Fe", "08", -17.90818, -63.03955);
case 158: return new CityInfo("San Julian", "08", -17.80623, -62.89536);
case 159: return new CityInfo("Puearto Pailas", "08", -17.663, -62.81227);
default: return new CityInfo("San Borja", "03", -14.85195, -66.74954);

                                    }                                        
                                }
                            
                        }
                    }
                