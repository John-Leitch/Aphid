
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
                                    public const string Country = "LT";
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
                            
                                        var cur = (Math.Abs(54.80725 - lat) + Math.Abs(24.44073 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(55.35941 - lat) + Math.Abs(21.70364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73225 - lat) + Math.Abs(26.25115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.36149 - lat) + Math.Abs(23.25094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.59678 - lat) + Math.Abs(26.43984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.62858 - lat) + Math.Abs(22.82272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.68916 - lat) + Math.Abs(25.2798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.04609 - lat) + Math.Abs(23.58552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.65167 - lat) + Math.Abs(23.03222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.76667 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23598 - lat) + Math.Abs(22.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.15079 - lat) + Math.Abs(24.57384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19162 - lat) + Math.Abs(22.69528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1011 - lat) + Math.Abs(23.69614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.74435 - lat) + Math.Abs(22.37251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.21546 - lat) + Math.Abs(24.57538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.98151 - lat) + Math.Abs(24.74828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.78264 - lat) + Math.Abs(22.65142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.49764 - lat) + Math.Abs(25.59918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.25 - lat) + Math.Abs(24.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.62345 - lat) + Math.Abs(23.17162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.63783 - lat) + Math.Abs(24.93433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.98139 - lat) + Math.Abs(22.24722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.25222 - lat) + Math.Abs(22.28972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0261 - lat) + Math.Abs(21.08411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.135 - lat) + Math.Abs(26.159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.16163 - lat) + Math.Abs(26.00177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.07567 - lat) + Math.Abs(22.58363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.27057 - lat) + Math.Abs(21.53208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.41387 - lat) + Math.Abs(22.60894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.61398 - lat) + Math.Abs(25.39573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.044 - lat) + Math.Abs(24.95446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.382 - lat) + Math.Abs(23.646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34889 - lat) + Math.Abs(21.48306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4898 - lat) + Math.Abs(22.18692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.93333 - lat) + Math.Abs(23.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.609 - lat) + Math.Abs(24.98 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7493 - lat) + Math.Abs(23.7561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16854 - lat) + Math.Abs(22.09071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.94933 - lat) + Math.Abs(23.88316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.30864 - lat) + Math.Abs(25.38677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0565 - lat) + Math.Abs(21.5689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.95339 - lat) + Math.Abs(23.04779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.2982 - lat) + Math.Abs(21.3712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.51609 - lat) + Math.Abs(24.83084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.95867 - lat) + Math.Abs(25.59466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.72708 - lat) + Math.Abs(21.92343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.37973 - lat) + Math.Abs(23.12386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.514 - lat) + Math.Abs(24.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.9483 - lat) + Math.Abs(24.0305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.81667 - lat) + Math.Abs(23.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.636 - lat) + Math.Abs(23.94585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.55427 - lat) + Math.Abs(21.31903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.91139 - lat) + Math.Abs(21.84417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.04657 - lat) + Math.Abs(21.81615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.05944 - lat) + Math.Abs(24.40361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73333 - lat) + Math.Abs(24.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0265 - lat) + Math.Abs(25.2264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9175 - lat) + Math.Abs(21.06861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97889 - lat) + Math.Abs(23.85508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.13793 - lat) + Math.Abs(21.91378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.981 - lat) + Math.Abs(25.761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.73333 - lat) + Math.Abs(25.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.96895 - lat) + Math.Abs(25.15648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.3086 - lat) + Math.Abs(20.99651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.37194 - lat) + Math.Abs(21.06472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.84776 - lat) + Math.Abs(25.46992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.31667 - lat) + Math.Abs(22.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.68691 - lat) + Math.Abs(24.15369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.22469 - lat) + Math.Abs(25.41688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.31667 - lat) + Math.Abs(22.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.55991 - lat) + Math.Abs(23.35412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.08596 - lat) + Math.Abs(23.97061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.64364 - lat) + Math.Abs(25.05162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.23326 - lat) + Math.Abs(23.51466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.706 - lat) + Math.Abs(25.643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.63858 - lat) + Math.Abs(22.76316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.00318 - lat) + Math.Abs(22.93662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.84027 - lat) + Math.Abs(24.97976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.94212 - lat) + Math.Abs(23.64218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.77353 - lat) + Math.Abs(22.86138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.8888 - lat) + Math.Abs(21.24448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7068 - lat) + Math.Abs(21.13912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63009 - lat) + Math.Abs(22.9349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.28782 - lat) + Math.Abs(23.97275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.749 - lat) + Math.Abs(23.49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.434 - lat) + Math.Abs(24.928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.90272 - lat) + Math.Abs(23.90961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.97055 - lat) + Math.Abs(24.06182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.417 - lat) + Math.Abs(23.223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.86528 - lat) + Math.Abs(24.46815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93321 - lat) + Math.Abs(23.71605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.07556 - lat) + Math.Abs(22.76416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.087 - lat) + Math.Abs(25.607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53727 - lat) + Math.Abs(21.11802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23939 - lat) + Math.Abs(23.61541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.08333 - lat) + Math.Abs(24.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.59937 - lat) + Math.Abs(24.17593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34063 - lat) + Math.Abs(26.16049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.68333 - lat) + Math.Abs(25.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.07688 - lat) + Math.Abs(22.97699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.82139 - lat) + Math.Abs(23.8713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70951 - lat) + Math.Abs(21.39441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.88315 - lat) + Math.Abs(23.60396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.78544 - lat) + Math.Abs(24.66302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.17414 - lat) + Math.Abs(24.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.74635 - lat) + Math.Abs(25.84562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.522 - lat) + Math.Abs(26.321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.01573 - lat) + Math.Abs(23.98703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.36832 - lat) + Math.Abs(23.88408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.36667 - lat) + Math.Abs(24.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(24.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.608 - lat) + Math.Abs(24.034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.60002 - lat) + Math.Abs(25.19318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.57946 - lat) + Math.Abs(24.52683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.262 - lat) + Math.Abs(23.477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.52557 - lat) + Math.Abs(25.10264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.39635 - lat) + Math.Abs(24.04142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.88037 - lat) + Math.Abs(23.90842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.25 - lat) + Math.Abs(22.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.91525 - lat) + Math.Abs(23.96831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.75792 - lat) + Math.Abs(23.92848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.92911 - lat) + Math.Abs(23.88599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93133 - lat) + Math.Abs(23.93243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8964 - lat) + Math.Abs(23.82411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.88737 - lat) + Math.Abs(23.84771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.81998 - lat) + Math.Abs(23.84462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.73429 - lat) + Math.Abs(25.21912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.69981 - lat) + Math.Abs(25.18393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.71664 - lat) + Math.Abs(25.2174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.70972 - lat) + Math.Abs(25.25053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.66815 - lat) + Math.Abs(25.20684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.66969 - lat) + Math.Abs(25.2477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.67951 - lat) + Math.Abs(25.26855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.67877 - lat) + Math.Abs(25.31173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Žiežmariai", "57", 54.80725, 24.44073);
case 1: return new CityInfo("Žemaičių Naumiestis", "58", 55.35941, 21.70364);
case 2: return new CityInfo("Zarasai", "64", 55.73225, 26.25115);
case 3: return new CityInfo("Žagarė", "61", 56.36149, 23.25094);
case 4: return new CityInfo("Visaginas", "64", 55.59678, 26.43984);
case 5: return new CityInfo("Virbalis", "59", 54.62858, 22.82272);
case 6: return new CityInfo("Vilnius", "65", 54.68916, 25.2798);
case 7: return new CityInfo("Vilkija", "57", 55.04609, 23.58552);
case 8: return new CityInfo("Vilkaviskis", "59", 54.65167, 23.03222);
case 9: return new CityInfo("Vievis", "65", 54.76667, 24.8);
case 10: return new CityInfo("Viekšniai", "63", 56.23598, 22.51667);
case 11: return new CityInfo("Vepriai", "65", 55.15079, 24.57384);
case 12: return new CityInfo("Venta", "61", 56.19162, 22.69528);
case 13: return new CityInfo("Veisiejai", "56", 54.1011, 23.69614);
case 14: return new CityInfo("Varniai", "63", 55.74435, 22.37251);
case 15: return new CityInfo("Varėna", "56", 54.21546, 24.57538);
case 16: return new CityInfo("Vabalninkas", "60", 55.98151, 24.74828);
case 17: return new CityInfo("Užventis", "61", 55.78264, 22.65142);
case 18: return new CityInfo("Utena", "64", 55.49764, 25.59918);
case 19: return new CityInfo("Ukmerge", "65", 55.25, 24.75);
case 20: return new CityInfo("Tytuvėnėliai", "61", 55.62345, 23.17162);
case 21: return new CityInfo("Trakai", "65", 54.63783, 24.93433);
case 22: return new CityInfo("Telsiai", "63", 55.98139, 22.24722);
case 23: return new CityInfo("Taurage", "62", 55.25222, 22.28972);
case 24: return new CityInfo("Šventoji", "58", 56.0261, 21.08411);
case 25: return new CityInfo("Švenčionys", "65", 55.135, 26.159);
case 26: return new CityInfo("Švenčionėliai", "65", 55.16163, 26.00177);
case 27: return new CityInfo("Smalininkai", "62", 55.07567, 22.58363);
case 28: return new CityInfo("Skuodas", "58", 56.27057, 21.53208);
case 29: return new CityInfo("Būgai", "62", 55.41387, 22.60894);
case 30: return new CityInfo("Skaidiškės", "65", 54.61398, 25.39573);
case 31: return new CityInfo("Širvintos", "65", 55.044, 24.95446);
case 32: return new CityInfo("Simnas", "56", 54.382, 23.646);
case 33: return new CityInfo("Silute", "58", 55.34889, 21.48306);
case 34: return new CityInfo("Šilalė", "62", 55.4898, 22.18692);
case 35: return new CityInfo("Šiauliai", "61", 55.93333, 23.31667);
case 36: return new CityInfo("Senieji Trakai", "65", 54.609, 24.98);
case 37: return new CityInfo("Šeduva", "61", 55.7493, 23.7561);
case 38: return new CityInfo("Seda", "63", 56.16854, 22.09071);
case 39: return new CityInfo("Sargėnai", "57", 54.94933, 23.88316);
case 40: return new CityInfo("Šalčininkai", "65", 54.30864, 25.38677);
case 41: return new CityInfo("Salantai", "58", 56.0565, 21.5689);
case 42: return new CityInfo("Šakiai", "59", 54.95339, 23.04779);
case 43: return new CityInfo("Rusnė", "58", 55.2982, 21.3712);
case 44: return new CityInfo("Rūdiškės", "65", 54.51609, 24.83084);
case 45: return new CityInfo("Rokiškis", "60", 55.95867, 25.59466);
case 46: return new CityInfo("Rietavas", "63", 55.72708, 21.92343);
case 47: return new CityInfo("Raseiniai", "57", 55.37973, 23.12386);
case 48: return new CityInfo("Ramygala", "60", 55.514, 24.3);
case 49: return new CityInfo("Ramučiai", "57", 54.9483, 24.0305);
case 50: return new CityInfo("Radviliskis", "61", 55.81667, 23.53333);
case 51: return new CityInfo("Prienai", "57", 54.636, 23.94585);
case 52: return new CityInfo("Priekulė", "58", 55.55427, 21.31903);
case 53: return new CityInfo("Plunge", "63", 55.91139, 21.84417);
case 54: return new CityInfo("Plateliai", "63", 56.04657, 21.81615);
case 55: return new CityInfo("Pasvalys", "60", 56.05944, 24.40361);
case 56: return new CityInfo("Panevėžys", "60", 55.73333, 24.35);
case 57: return new CityInfo("Pandėlys", "00", 56.0265, 25.2264);
case 58: return new CityInfo("Palanga", "58", 55.9175, 21.06861);
case 59: return new CityInfo("Pakruojis", "61", 55.97889, 23.85508);
case 60: return new CityInfo("Pagėgiai", "62", 55.13793, 21.91378);
case 61: return new CityInfo("Pabradė", "65", 54.981, 25.761);
case 62: return new CityInfo("Fabijoniškės", "65", 54.73333, 25.24167);
case 63: return new CityInfo("Obeliai", "60", 55.96895, 25.15648);
case 64: return new CityInfo("Nida", "58", 55.3086, 20.99651);
case 65: return new CityInfo("Neringa", "58", 55.37194, 21.06472);
case 66: return new CityInfo("Nemenčinė", "65", 54.84776, 25.46992);
case 67: return new CityInfo("Naujoji Akmene", "61", 56.31667, 22.9);
case 68: return new CityInfo("Naujamiestis", "60", 55.68691, 24.15369);
case 69: return new CityInfo("Molėtai", "64", 55.22469, 25.41688);
case 70: return new CityInfo("Mazeikiai", "63", 56.31667, 22.33333);
case 71: return new CityInfo("Marijampolė", "59", 54.55991, 23.35412);
case 72: return new CityInfo("Linkuva", "61", 56.08596, 23.97061);
case 73: return new CityInfo("Lentvaris", "65", 54.64364, 25.05162);
case 74: return new CityInfo("Lazdijai", "56", 54.23326, 23.51466);
case 75: return new CityInfo("Lavoriškės", "00", 54.706, 25.643);
case 76: return new CityInfo("Kybartai", "59", 54.63858, 22.76316);
case 77: return new CityInfo("Kuršėnai", "61", 56.00318, 22.93662);
case 78: return new CityInfo("Kupiskis", "60", 55.84027, 24.97976);
case 79: return new CityInfo("Kulautuva", "57", 54.94212, 23.64218);
case 80: return new CityInfo("Kudirkos Naumiestis", "59", 54.77353, 22.86138);
case 81: return new CityInfo("Kretinga", "58", 55.8888, 21.24448);
case 82: return new CityInfo("Klaipėda", "58", 55.7068, 21.13912);
case 83: return new CityInfo("Kelmė", "61", 55.63009, 22.9349);
case 84: return new CityInfo("Kėdainiai", "57", 55.28782, 23.97275);
case 85: return new CityInfo("Kazlų Rūda", "59", 54.749, 23.49);
case 86: return new CityInfo("Kavarskas", "64", 55.434, 24.928);
case 87: return new CityInfo("Kaunas", "57", 54.90272, 23.90961);
case 88: return new CityInfo("Karmėlava", "57", 54.97055, 24.06182);
case 89: return new CityInfo("Kalvarija", "59", 54.417, 23.223);
case 90: return new CityInfo("Kaišiadorys", "57", 54.86528, 24.46815);
case 91: return new CityInfo("Kačerginė", "57", 54.93321, 23.71605);
case 92: return new CityInfo("Jurbarkas", "62", 55.07556, 22.76416);
case 93: return new CityInfo("Juodupė", "60", 56.087, 25.607);
case 94: return new CityInfo("Juodkrantė", "58", 55.53727, 21.11802);
case 95: return new CityInfo("Joniškis", "61", 56.23939, 23.61541);
case 96: return new CityInfo("Jonava", "57", 55.08333, 24.28333);
case 97: return new CityInfo("Jieznas", "57", 54.59937, 24.17593);
case 98: return new CityInfo("Ignalina", "64", 55.34063, 26.16049);
case 99: return new CityInfo("Grigiškės", "65", 54.68333, 25.08333);
case 100: return new CityInfo("Gelgaudiškis", "59", 55.07688, 22.97699);
case 101: return new CityInfo("Garliava", "57", 54.82139, 23.8713);
case 102: return new CityInfo("Gargždai", "58", 55.70951, 21.39441);
case 103: return new CityInfo("Ežerėlis", "57", 54.88315, 23.60396);
case 104: return new CityInfo("Elektrėnai", "65", 54.78544, 24.66302);
case 105: return new CityInfo("Eišiškės", "65", 54.17414, 24.99917);
case 106: return new CityInfo("Dusetos", "64", 55.74635, 25.84562);
case 107: return new CityInfo("Dūkštas", "64", 55.522, 26.321);
case 108: return new CityInfo("Druskininkai", "56", 54.01573, 23.98703);
case 109: return new CityInfo("Dotnuva", "57", 55.36832, 23.88408);
case 110: return new CityInfo("Daugai", "56", 54.36667, 24.33333);
case 111: return new CityInfo("Birzai", "60", 56.2, 24.75);
case 112: return new CityInfo("Birštonas", "57", 54.608, 24.034);
case 113: return new CityInfo("Baltoji Vokė", "65", 54.60002, 25.19318);
case 114: return new CityInfo("Aukstadvaris", "65", 54.57946, 24.52683);
case 115: return new CityInfo("Ariogala", "57", 55.262, 23.477);
case 116: return new CityInfo("Anykščiai", "64", 55.52557, 25.10264);
case 117: return new CityInfo("Alytus", "56", 54.39635, 24.04142);
case 118: return new CityInfo("Aleksotas", "57", 54.88037, 23.90842);
case 119: return new CityInfo("Akmenė", "61", 56.25, 22.75);
case 120: return new CityInfo("Dainava (Kaunas)", "57", 54.91525, 23.96831);
case 121: return new CityInfo("Linksmakalnis", "57", 54.75792, 23.92848);
case 122: return new CityInfo("Šilainiai", "57", 54.92911, 23.88599);
case 123: return new CityInfo("Eiguliai", "57", 54.93133, 23.93243);
case 124: return new CityInfo("Akademija (Kaunas)", "57", 54.8964, 23.82411);
case 125: return new CityInfo("Noreikiškės", "57", 54.88737, 23.84771);
case 126: return new CityInfo("Mastaiciai", "57", 54.81998, 23.84462);
case 127: return new CityInfo("Pašilaičiai", "65", 54.73429, 25.21912);
case 128: return new CityInfo("Pilaitė", "65", 54.69981, 25.18393);
case 129: return new CityInfo("Justiniškės", "65", 54.71664, 25.2174);
case 130: return new CityInfo("Šeškinė", "65", 54.70972, 25.25053);
case 131: return new CityInfo("Lazdynai", "65", 54.66815, 25.20684);
case 132: return new CityInfo("Vilkpėdė", "65", 54.66969, 25.2477);
case 133: return new CityInfo("Naujamiestis", "65", 54.67951, 25.26855);
default: return new CityInfo("Rasos", "65", 54.67877, 25.31173);

                                    }                                        
                                }
                            
                        }
                    }
                