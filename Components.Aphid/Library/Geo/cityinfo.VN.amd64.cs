
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
                                    public const string Country = "VN";
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
                            
                                        var cur = (Math.Abs(18.66667 - lat) + Math.Abs(105.66667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.99856 - lat) + Math.Abs(105.47116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.18396 - lat) + Math.Abs(106.06121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.11792 - lat) + Math.Abs(105.14159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.23693 - lat) + Math.Abs(106.18149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.23646 - lat) + Math.Abs(105.57297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.04584 - lat) + Math.Abs(104.30101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.72288 - lat) + Math.Abs(104.9113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85707 - lat) + Math.Abs(104.81199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95358 - lat) + Math.Abs(107.00589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.92615 - lat) + Math.Abs(107.40172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34599 - lat) + Math.Abs(107.08426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.09576 - lat) + Math.Abs(106.18548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.4642 - lat) + Math.Abs(105.44348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.18691 - lat) + Math.Abs(107.56025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78449 - lat) + Math.Abs(105.47012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.30891 - lat) + Math.Abs(105.60489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27441 - lat) + Math.Abs(104.89091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.50802 - lat) + Math.Abs(105.25747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10884 - lat) + Math.Abs(108.78381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25369 - lat) + Math.Abs(105.9722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.05438 - lat) + Math.Abs(105.61567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.32439 - lat) + Math.Abs(105.98006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34498 - lat) + Math.Abs(106.58056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.67337 - lat) + Math.Abs(105.69232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.32274 - lat) + Math.Abs(105.40198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.86516 - lat) + Math.Abs(106.53925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.69203 - lat) + Math.Abs(109.22069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.73514 - lat) + Math.Abs(105.77236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.9463 - lat) + Math.Abs(105.845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61945 - lat) + Math.Abs(108.99805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.03433 - lat) + Math.Abs(106.77049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82738 - lat) + Math.Abs(109.16651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09546 - lat) + Math.Abs(109.32094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.82356 - lat) + Math.Abs(105.21424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.26393 - lat) + Math.Abs(104.47232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08451 - lat) + Math.Abs(108.826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.83514 - lat) + Math.Abs(106.52496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4202 - lat) + Math.Abs(105.00073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94719 - lat) + Math.Abs(106.34225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96261 - lat) + Math.Abs(105.92168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.02987 - lat) + Math.Abs(106.35751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.46659 - lat) + Math.Abs(104.37966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33965 - lat) + Math.Abs(108.22065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.67001 - lat) + Math.Abs(105.56469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.69774 - lat) + Math.Abs(106.25834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25569 - lat) + Math.Abs(108.51722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.44645 - lat) + Math.Abs(105.77861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81166 - lat) + Math.Abs(106.19067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48819 - lat) + Math.Abs(108.30736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60232 - lat) + Math.Abs(106.40207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.90294 - lat) + Math.Abs(105.34723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.84863 - lat) + Math.Abs(106.77209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.9804 - lat) + Math.Abs(106.6519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.93133 - lat) + Math.Abs(105.52179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27213 - lat) + Math.Abs(105.5338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06522 - lat) + Math.Abs(105.55863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35584 - lat) + Math.Abs(105.09929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.76886 - lat) + Math.Abs(107.16504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.25525 - lat) + Math.Abs(106.47359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.95907 - lat) + Math.Abs(103.88001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.42838 - lat) + Math.Abs(105.74111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19867 - lat) + Math.Abs(105.17892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94827 - lat) + Math.Abs(106.51629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.82302 - lat) + Math.Abs(106.62965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.3881 - lat) + Math.Abs(106.43834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.8 - lat) + Math.Abs(105.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.77877 - lat) + Math.Abs(105.33356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.5619 - lat) + Math.Abs(105.48411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.59422 - lat) + Math.Abs(105.84817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.45 - lat) + Math.Abs(106.34002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.13053 - lat) + Math.Abs(105.67454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36788 - lat) + Math.Abs(105.86122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31004 - lat) + Math.Abs(106.09828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.06895 - lat) + Math.Abs(105.81053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19809 - lat) + Math.Abs(105.42217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99214 - lat) + Math.Abs(105.19602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.04756 - lat) + Math.Abs(105.26807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08421 - lat) + Math.Abs(107.68095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44905 - lat) + Math.Abs(106.34386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11709 - lat) + Math.Abs(105.28578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79832 - lat) + Math.Abs(105.23887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.53589 - lat) + Math.Abs(106.41366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.57364 - lat) + Math.Abs(108.47403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.39324 - lat) + Math.Abs(105.61441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.04811 - lat) + Math.Abs(106.00017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.4979 - lat) + Math.Abs(106.5669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15856 - lat) + Math.Abs(108.79582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.14053 - lat) + Math.Abs(105.50686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.04193 - lat) + Math.Abs(108.46973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.69676 - lat) + Math.Abs(105.39901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.3256 - lat) + Math.Abs(103.91882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.05091 - lat) + Math.Abs(103.74987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4556 - lat) + Math.Abs(109.22348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.59995 - lat) + Math.Abs(105.97193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.36647 - lat) + Math.Abs(103.23438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.6951 - lat) + Math.Abs(104.27857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.34023 - lat) + Math.Abs(103.84415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.29085 - lat) + Math.Abs(105.75635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.01245 - lat) + Math.Abs(105.08091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.8424 - lat) + Math.Abs(103.56608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.66192 - lat) + Math.Abs(106.32744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77648 - lat) + Math.Abs(109.22367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.32546 - lat) + Math.Abs(105.18251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.80459 - lat) + Math.Abs(105.97044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.55206 - lat) + Math.Abs(105.09387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.67356 - lat) + Math.Abs(108.2201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.60409 - lat) + Math.Abs(104.91903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.38481 - lat) + Math.Abs(105.10024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.9421 - lat) + Math.Abs(106.8027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.69499 - lat) + Math.Abs(106.44235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.75353 - lat) + Math.Abs(106.42355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.40438 - lat) + Math.Abs(106.64072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.12047 - lat) + Math.Abs(108.79232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.70495 - lat) + Math.Abs(107.6862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98333 - lat) + Math.Abs(108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.26331 - lat) + Math.Abs(104.64439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.43911 - lat) + Math.Abs(107.71438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.19682 - lat) + Math.Abs(108.69043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27314 - lat) + Math.Abs(105.87943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.39963 - lat) + Math.Abs(105.22221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21716 - lat) + Math.Abs(103.95929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.90964 - lat) + Math.Abs(108.91903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.71298 - lat) + Math.Abs(108.30148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.08333 - lat) + Math.Abs(105.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.77972 - lat) + Math.Abs(105.7338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.17182 - lat) + Math.Abs(109.04888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.54531 - lat) + Math.Abs(105.91221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.28035 - lat) + Math.Abs(107.85898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28333 - lat) + Math.Abs(106.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.23695 - lat) + Math.Abs(105.70483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.00316 - lat) + Math.Abs(109.05804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.54433 - lat) + Math.Abs(103.29776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.58321 - lat) + Math.Abs(107.36438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99753 - lat) + Math.Abs(105.6673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31918 - lat) + Math.Abs(104.18719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.51335 - lat) + Math.Abs(105.42411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63141 - lat) + Math.Abs(105.57815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.09054 - lat) + Math.Abs(106.08323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.92889 - lat) + Math.Abs(108.10208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.56432 - lat) + Math.Abs(108.98858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.10974 - lat) + Math.Abs(105.62318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.73738 - lat) + Math.Abs(106.15216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.91569 - lat) + Math.Abs(106.6744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.49187 - lat) + Math.Abs(109.12495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.73083 - lat) + Math.Abs(106.39789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.25809 - lat) + Math.Abs(105.97965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.98167 - lat) + Math.Abs(105.98486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.32279 - lat) + Math.Abs(105.75189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.72294 - lat) + Math.Abs(106.88341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.24507 - lat) + Math.Abs(109.19432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.69672 - lat) + Math.Abs(106.74032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62502 - lat) + Math.Abs(105.00854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.64995 - lat) + Math.Abs(105.95985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.28296 - lat) + Math.Abs(106.44347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.09189 - lat) + Math.Abs(105.36761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.40557 - lat) + Math.Abs(106.50365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.66206 - lat) + Math.Abs(105.75575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.77927 - lat) + Math.Abs(105.64597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.04568 - lat) + Math.Abs(108.77724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.00722 - lat) + Math.Abs(105.97044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.43082 - lat) + Math.Abs(105.99687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.6471 - lat) + Math.Abs(107.24577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.05639 - lat) + Math.Abs(106.6151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.43389 - lat) + Math.Abs(106.17729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.69799 - lat) + Math.Abs(105.49881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75899 - lat) + Math.Abs(104.99285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56006 - lat) + Math.Abs(105.98984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36004 - lat) + Math.Abs(106.35996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44267 - lat) + Math.Abs(105.69508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.44111 - lat) + Math.Abs(106.10238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.74889 - lat) + Math.Abs(107.83678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.19236 - lat) + Math.Abs(102.4579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.76141 - lat) + Math.Abs(104.12156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.52915 - lat) + Math.Abs(104.60138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.85125 - lat) + Math.Abs(104.08954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.52471 - lat) + Math.Abs(107.96619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95513 - lat) + Math.Abs(108.88586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.85199 - lat) + Math.Abs(104.62177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.13312 - lat) + Math.Abs(106.33519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90248 - lat) + Math.Abs(105.1595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93218 - lat) + Math.Abs(108.70328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.16411 - lat) + Math.Abs(105.40993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.38702 - lat) + Math.Abs(107.53508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38639 - lat) + Math.Abs(105.43518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78909 - lat) + Math.Abs(106.95029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61025 - lat) + Math.Abs(106.11881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.68141 - lat) + Math.Abs(105.57226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84476 - lat) + Math.Abs(106.59073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.75873 - lat) + Math.Abs(106.92335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.22095 - lat) + Math.Abs(106.18747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.22761 - lat) + Math.Abs(108.72366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.22328 - lat) + Math.Abs(106.79011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36161 - lat) + Math.Abs(105.51924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31377 - lat) + Math.Abs(103.86844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.48556 - lat) + Math.Abs(103.97066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.85264 - lat) + Math.Abs(106.76101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.53472 - lat) + Math.Abs(107.40202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.98479 - lat) + Math.Abs(105.23983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.15611 - lat) + Math.Abs(105.24223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28701 - lat) + Math.Abs(105.6617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.90512 - lat) + Math.Abs(106.69949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.93252 - lat) + Math.Abs(106.24756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65993 - lat) + Math.Abs(107.77206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.41086 - lat) + Math.Abs(108.17682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00405 - lat) + Math.Abs(108.41905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.39795 - lat) + Math.Abs(104.15239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06243 - lat) + Math.Abs(106.29832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.35451 - lat) + Math.Abs(108.00759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.98962 - lat) + Math.Abs(106.5551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.85265 - lat) + Math.Abs(105.76963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28624 - lat) + Math.Abs(104.64616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.62825 - lat) + Math.Abs(106.73884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.08935 - lat) + Math.Abs(104.25149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.91007 - lat) + Math.Abs(106.14771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.76743 - lat) + Math.Abs(105.98574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.5056 - lat) + Math.Abs(106.34459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.52539 - lat) + Math.Abs(107.4755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17669 - lat) + Math.Abs(105.70019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.27882 - lat) + Math.Abs(105.64697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.64637 - lat) + Math.Abs(106.05112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.4619 - lat) + Math.Abs(107.59546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.06836 - lat) + Math.Abs(107.0052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.64711 - lat) + Math.Abs(106.60586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.95045 - lat) + Math.Abs(107.07336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18462 - lat) + Math.Abs(104.92959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.87944 - lat) + Math.Abs(108.335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.8891 - lat) + Math.Abs(106.59533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.98764 - lat) + Math.Abs(108.13893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.64173 - lat) + Math.Abs(105.989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.36352 - lat) + Math.Abs(108.96476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.81717 - lat) + Math.Abs(105.33759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58224 - lat) + Math.Abs(108.11422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34282 - lat) + Math.Abs(105.90569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.3831 - lat) + Math.Abs(104.48753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.0245 - lat) + Math.Abs(105.84117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.68749 - lat) + Math.Abs(106.67004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.73871 - lat) + Math.Abs(108.35062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.86481 - lat) + Math.Abs(106.68345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.69347 - lat) + Math.Abs(107.25124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.94099 - lat) + Math.Abs(106.33302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.56302 - lat) + Math.Abs(105.00512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.82333 - lat) + Math.Abs(104.98357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.97136 - lat) + Math.Abs(105.77876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7332 - lat) + Math.Abs(105.27393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90974 - lat) + Math.Abs(105.31433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.9248 - lat) + Math.Abs(107.08438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00423 - lat) + Math.Abs(107.69074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.82898 - lat) + Math.Abs(108.25956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.73559 - lat) + Math.Abs(108.3733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.53957 - lat) + Math.Abs(105.58302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.81346 - lat) + Math.Abs(107.24433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81355 - lat) + Math.Abs(108.95931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.44957 - lat) + Math.Abs(107.62237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.37732 - lat) + Math.Abs(109.10807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.53495 - lat) + Math.Abs(106.88324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.27841 - lat) + Math.Abs(105.36291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.65701 - lat) + Math.Abs(106.57832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.42939 - lat) + Math.Abs(106.43194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.46885 - lat) + Math.Abs(106.62226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.81625 - lat) + Math.Abs(107.10031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.96961 - lat) + Math.Abs(105.05505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.62254 - lat) + Math.Abs(105.18462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.54633 - lat) + Math.Abs(107.09812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.58153 - lat) + Math.Abs(108.07641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.2549 - lat) + Math.Abs(109.09332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.97652 - lat) + Math.Abs(105.60034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.38602 - lat) + Math.Abs(103.02301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.88853 - lat) + Math.Abs(108.25447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.55832 - lat) + Math.Abs(106.56882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.90682 - lat) + Math.Abs(106.7694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2741 - lat) + Math.Abs(106.35879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49093 - lat) + Math.Abs(107.27014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.06778 - lat) + Math.Abs(108.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.94646 - lat) + Math.Abs(108.44193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.25518 - lat) + Math.Abs(107.60924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.88214 - lat) + Math.Abs(108.12092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66092 - lat) + Math.Abs(107.8389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.04998 - lat) + Math.Abs(108.97895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.97333 - lat) + Math.Abs(106.49325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.09377 - lat) + Math.Abs(105.42916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68641 - lat) + Math.Abs(106.60824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.04996 - lat) + Math.Abs(104.88124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.92375 - lat) + Math.Abs(105.70155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.37379 - lat) + Math.Abs(106.56649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.42821 - lat) + Math.Abs(106.63536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.88374 - lat) + Math.Abs(105.77281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55123 - lat) + Math.Abs(105.40441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26032 - lat) + Math.Abs(106.11892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15021 - lat) + Math.Abs(106.50606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34984 - lat) + Math.Abs(106.4634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.90724 - lat) + Math.Abs(105.64219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30845 - lat) + Math.Abs(109.21522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.49056 - lat) + Math.Abs(105.778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.14413 - lat) + Math.Abs(105.27277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7 - lat) + Math.Abs(105.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.8724 - lat) + Math.Abs(106.05497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.146 - lat) + Math.Abs(105.63089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.72779 - lat) + Math.Abs(107.04819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.38707 - lat) + Math.Abs(106.12931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46017 - lat) + Math.Abs(105.63294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.66568 - lat) + Math.Abs(106.25786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03711 - lat) + Math.Abs(105.78825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.41115 - lat) + Math.Abs(106.95474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.50966 - lat) + Math.Abs(106.60308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60857 - lat) + Math.Abs(106.67135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25029 - lat) + Math.Abs(106.00132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.20866 - lat) + Math.Abs(105.4695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.92144 - lat) + Math.Abs(109.15913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.01667 - lat) + Math.Abs(107.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.01004 - lat) + Math.Abs(107.27345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.80797 - lat) + Math.Abs(106.99405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17682 - lat) + Math.Abs(105.15242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25973 - lat) + Math.Abs(105.87044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0009 - lat) + Math.Abs(105.75095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94231 - lat) + Math.Abs(105.01411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17412 - lat) + Math.Abs(106.11051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48478 - lat) + Math.Abs(108.02982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66747 - lat) + Math.Abs(108.03775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.58436 - lat) + Math.Abs(106.53425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.42907 - lat) + Math.Abs(109.0156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.95486 - lat) + Math.Abs(106.80018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.07431 - lat) + Math.Abs(105.73974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.29776 - lat) + Math.Abs(108.76124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.96094 - lat) + Math.Abs(106.36448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18964 - lat) + Math.Abs(106.69149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.69541 - lat) + Math.Abs(106.59128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.07806 - lat) + Math.Abs(105.86028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.94469 - lat) + Math.Abs(106.82432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.24147 - lat) + Math.Abs(106.37585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.11051 - lat) + Math.Abs(106.17924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.04427 - lat) + Math.Abs(106.5902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7636 - lat) + Math.Abs(108.73223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.23429 - lat) + Math.Abs(104.47643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.54798 - lat) + Math.Abs(107.80772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.94924 - lat) + Math.Abs(105.68046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.93653 - lat) + Math.Abs(106.05711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.5175 - lat) + Math.Abs(104.02701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.43849 - lat) + Math.Abs(103.69 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.24626 - lat) + Math.Abs(104.43281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.89999 - lat) + Math.Abs(106.32077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.18608 - lat) + Math.Abs(106.07631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29414 - lat) + Math.Abs(105.72776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.53911 - lat) + Math.Abs(104.29305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.27307 - lat) + Math.Abs(106.1946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.14701 - lat) + Math.Abs(105.83481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.51271 - lat) + Math.Abs(106.50762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23333 - lat) + Math.Abs(106.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.29693 - lat) + Math.Abs(105.74435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.88579 - lat) + Math.Abs(109.10823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61241 - lat) + Math.Abs(108.8899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.86382 - lat) + Math.Abs(106.6133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.33465 - lat) + Math.Abs(106.84934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81532 - lat) + Math.Abs(105.06366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.27228 - lat) + Math.Abs(107.23385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7118 - lat) + Math.Abs(106.73643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.15635 - lat) + Math.Abs(105.91737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86989 - lat) + Math.Abs(106.34939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08416 - lat) + Math.Abs(106.78834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.34705 - lat) + Math.Abs(105.05739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.49881 - lat) + Math.Abs(105.14104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.4213 - lat) + Math.Abs(105.13374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.25487 - lat) + Math.Abs(105.2953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.4068 - lat) + Math.Abs(105.31228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.0655 - lat) + Math.Abs(105.0345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.86407 - lat) + Math.Abs(105.45905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.82968 - lat) + Math.Abs(105.49334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.41539 - lat) + Math.Abs(105.46081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44559 - lat) + Math.Abs(105.38622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26478 - lat) + Math.Abs(105.26676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44114 - lat) + Math.Abs(106.46793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.05938 - lat) + Math.Abs(106.17468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.01937 - lat) + Math.Abs(106.20044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19491 - lat) + Math.Abs(105.95471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.15328 - lat) + Math.Abs(106.15164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.06308 - lat) + Math.Abs(106.0857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.14388 - lat) + Math.Abs(106.02018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.18697 - lat) + Math.Abs(106.16076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03183 - lat) + Math.Abs(105.42115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56703 - lat) + Math.Abs(105.45019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43753 - lat) + Math.Abs(105.46217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23789 - lat) + Math.Abs(105.45524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28471 - lat) + Math.Abs(105.62916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57428 - lat) + Math.Abs(105.24005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.47679 - lat) + Math.Abs(106.12653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.30626 - lat) + Math.Abs(106.38673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.20048 - lat) + Math.Abs(106.24739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.27421 - lat) + Math.Abs(106.10069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.35505 - lat) + Math.Abs(105.98344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.61206 - lat) + Math.Abs(105.66707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.15777 - lat) + Math.Abs(105.59559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48557 - lat) + Math.Abs(107.21226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.56815 - lat) + Math.Abs(107.12999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.76172 - lat) + Math.Abs(103.09783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.85771 - lat) + Math.Abs(103.3426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.29673 - lat) + Math.Abs(103.22009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.2596 - lat) + Math.Abs(103.0344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31812 - lat) + Math.Abs(103.62619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.39644 - lat) + Math.Abs(103.45824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.38067 - lat) + Math.Abs(102.82011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.0674 - lat) + Math.Abs(104.98926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.66762 - lat) + Math.Abs(104.98191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.62486 - lat) + Math.Abs(104.95988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.41509 - lat) + Math.Abs(104.80682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.73223 - lat) + Math.Abs(105.37145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.74085 - lat) + Math.Abs(104.67956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.40989 - lat) + Math.Abs(104.57949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.7841 - lat) + Math.Abs(105.9832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.90243 - lat) + Math.Abs(106.07737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.82898 - lat) + Math.Abs(106.32335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.8665 - lat) + Math.Abs(106.76833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.1436 - lat) + Math.Abs(105.27192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.56252 - lat) + Math.Abs(104.5948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.75585 - lat) + Math.Abs(104.82768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.11075 - lat) + Math.Abs(104.76748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.34917 - lat) + Math.Abs(105.38241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06821 - lat) + Math.Abs(105.82221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.81591 - lat) + Math.Abs(105.09038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59236 - lat) + Math.Abs(105.35573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.6036 - lat) + Math.Abs(107.054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.54311 - lat) + Math.Abs(103.88989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19733 - lat) + Math.Abs(104.10595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.72948 - lat) + Math.Abs(105.78273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.62403 - lat) + Math.Abs(105.64941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.25909 - lat) + Math.Abs(104.94521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66327 - lat) + Math.Abs(105.42854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.85797 - lat) + Math.Abs(105.85482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.34803 - lat) + Math.Abs(105.22881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.91444 - lat) + Math.Abs(105.88615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.81913 - lat) + Math.Abs(105.60392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.97153 - lat) + Math.Abs(105.65106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.01285 - lat) + Math.Abs(105.85322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.81906 - lat) + Math.Abs(105.73279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.88659 - lat) + Math.Abs(105.67879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.87714 - lat) + Math.Abs(105.25417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.61441 - lat) + Math.Abs(105.27948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.39472 - lat) + Math.Abs(105.6224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.67264 - lat) + Math.Abs(105.53625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.87148 - lat) + Math.Abs(105.52568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.88668 - lat) + Math.Abs(105.35244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.70446 - lat) + Math.Abs(105.32063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.34697 - lat) + Math.Abs(105.83615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.29905 - lat) + Math.Abs(105.95198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.16245 - lat) + Math.Abs(106.00697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.29227 - lat) + Math.Abs(106.33275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.20145 - lat) + Math.Abs(106.29578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.32773 - lat) + Math.Abs(106.01208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.33335 - lat) + Math.Abs(106.07826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.33322 - lat) + Math.Abs(106.17754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.32336 - lat) + Math.Abs(106.26584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.58064 - lat) + Math.Abs(105.87266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.5602 - lat) + Math.Abs(106.02812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.49121 - lat) + Math.Abs(106.00955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.47398 - lat) + Math.Abs(105.95268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.5904 - lat) + Math.Abs(106.22445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.43671 - lat) + Math.Abs(106.29116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.55651 - lat) + Math.Abs(106.35532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49629 - lat) + Math.Abs(107.16841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.58992 - lat) + Math.Abs(103.42179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.51993 - lat) + Math.Abs(103.22294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.82294 - lat) + Math.Abs(106.55575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.72464 - lat) + Math.Abs(106.55391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.75078 - lat) + Math.Abs(106.66894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.4506 - lat) + Math.Abs(107.75592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.03141 - lat) + Math.Abs(106.99101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.97268 - lat) + Math.Abs(107.76578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.78714 - lat) + Math.Abs(106.24623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.99205 - lat) + Math.Abs(106.33613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.86783 - lat) + Math.Abs(106.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.81914 - lat) + Math.Abs(106.40661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.89816 - lat) + Math.Abs(106.42612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.96278 - lat) + Math.Abs(106.5095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.73847 - lat) + Math.Abs(105.70388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.46014 - lat) + Math.Abs(105.97814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.62384 - lat) + Math.Abs(105.84168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.17548 - lat) + Math.Abs(105.28388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.3201 - lat) + Math.Abs(105.29156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.1831 - lat) + Math.Abs(105.72041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.2165 - lat) + Math.Abs(105.51249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.37525 - lat) + Math.Abs(105.54256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.94301 - lat) + Math.Abs(105.93119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.88557 - lat) + Math.Abs(106.0356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.83912 - lat) + Math.Abs(105.97755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.74003 - lat) + Math.Abs(106.05998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.81835 - lat) + Math.Abs(106.09118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.72952 - lat) + Math.Abs(106.17971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.7011 - lat) + Math.Abs(106.11751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.05723 - lat) + Math.Abs(105.57919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.10345 - lat) + Math.Abs(105.54551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.08902 - lat) + Math.Abs(105.65901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.06953 - lat) + Math.Abs(105.70646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.99019 - lat) + Math.Abs(105.64088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.86874 - lat) + Math.Abs(105.86125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.74549 - lat) + Math.Abs(105.91363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.68667 - lat) + Math.Abs(105.74471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.25782 - lat) + Math.Abs(105.84894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.13962 - lat) + Math.Abs(105.84926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.03929 - lat) + Math.Abs(105.76659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.01951 - lat) + Math.Abs(105.93694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.03228 - lat) + Math.Abs(105.80073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.99472 - lat) + Math.Abs(105.79977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.02009 - lat) + Math.Abs(105.83097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.02857 - lat) + Math.Abs(105.85064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.01341 - lat) + Math.Abs(105.84772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.67165 - lat) + Math.Abs(105.62882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38385 - lat) + Math.Abs(105.5059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45119 - lat) + Math.Abs(105.77969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.88389 - lat) + Math.Abs(106.02536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.68906 - lat) + Math.Abs(106.8874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.1691 - lat) + Math.Abs(107.71793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.57452 - lat) + Math.Abs(107.51066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.0706 - lat) + Math.Abs(108.19102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01771 - lat) + Math.Abs(108.20381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.06068 - lat) + Math.Abs(108.23256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.07272 - lat) + Math.Abs(108.15815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01618 - lat) + Math.Abs(108.25335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.92438 - lat) + Math.Abs(107.64814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.44508 - lat) + Math.Abs(107.79337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43194 - lat) + Math.Abs(108.65946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.55473 - lat) + Math.Abs(108.41142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16948 - lat) + Math.Abs(108.35998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.37198 - lat) + Math.Abs(109.11891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08642 - lat) + Math.Abs(107.73577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.41377 - lat) + Math.Abs(107.79339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51345 - lat) + Math.Abs(107.92102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.50717 - lat) + Math.Abs(108.2473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60064 - lat) + Math.Abs(108.29088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99501 - lat) + Math.Abs(108.11207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.14453 - lat) + Math.Abs(108.59908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77532 - lat) + Math.Abs(108.52558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53361 - lat) + Math.Abs(108.45529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.40025 - lat) + Math.Abs(108.43503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69153 - lat) + Math.Abs(108.08023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75684 - lat) + Math.Abs(107.88624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80507 - lat) + Math.Abs(107.6961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.96242 - lat) + Math.Abs(107.84484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10005 - lat) + Math.Abs(107.96896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03886 - lat) + Math.Abs(108.25011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.97908 - lat) + Math.Abs(108.89732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.06616 - lat) + Math.Abs(107.88546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2045 - lat) + Math.Abs(108.21029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.9517 - lat) + Math.Abs(108.34425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.81965 - lat) + Math.Abs(108.07738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.80816 - lat) + Math.Abs(108.44901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5045 - lat) + Math.Abs(108.33288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.74624 - lat) + Math.Abs(108.74281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28355 - lat) + Math.Abs(108.9047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00582 - lat) + Math.Abs(108.94868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05398 - lat) + Math.Abs(109.16004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.58904 - lat) + Math.Abs(107.89578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45789 - lat) + Math.Abs(107.86246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78624 - lat) + Math.Abs(108.24282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.76165 - lat) + Math.Abs(108.49473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.62836 - lat) + Math.Abs(107.83508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.57981 - lat) + Math.Abs(107.36518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.51148 - lat) + Math.Abs(107.49092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84104 - lat) + Math.Abs(108.90316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77521 - lat) + Math.Abs(108.7848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.52696 - lat) + Math.Abs(108.92996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.59105 - lat) + Math.Abs(109.04052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.22158 - lat) + Math.Abs(108.50707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.07297 - lat) + Math.Abs(108.12997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.85004 - lat) + Math.Abs(107.87864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.5166 - lat) + Math.Abs(108.93292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.27221 - lat) + Math.Abs(107.43655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08901 - lat) + Math.Abs(107.03516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95055 - lat) + Math.Abs(107.14571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.92655 - lat) + Math.Abs(107.24783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.45119 - lat) + Math.Abs(106.86811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55202 - lat) + Math.Abs(106.17245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.54441 - lat) + Math.Abs(106.01161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31167 - lat) + Math.Abs(106.0295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28696 - lat) + Math.Abs(106.12936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.0885 - lat) + Math.Abs(106.26346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.38414 - lat) + Math.Abs(106.23078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83476 - lat) + Math.Abs(105.66135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89067 - lat) + Math.Abs(105.78495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60666 - lat) + Math.Abs(106.04714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65744 - lat) + Math.Abs(106.18081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89221 - lat) + Math.Abs(106.30614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89434 - lat) + Math.Abs(106.39695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47711 - lat) + Math.Abs(106.19256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.31906 - lat) + Math.Abs(106.71128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61144 - lat) + Math.Abs(104.9465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.87016 - lat) + Math.Abs(105.46583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.19281 - lat) + Math.Abs(106.01229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.63497 - lat) + Math.Abs(106.49237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30122 - lat) + Math.Abs(106.35701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22263 - lat) + Math.Abs(105.39841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.75129 - lat) + Math.Abs(105.53448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81371 - lat) + Math.Abs(105.82096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92303 - lat) + Math.Abs(105.80542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92402 - lat) + Math.Abs(105.62964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.67314 - lat) + Math.Abs(106.14874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7007 - lat) + Math.Abs(105.90202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.63537 - lat) + Math.Abs(105.81165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.41286 - lat) + Math.Abs(104.97353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.07713 - lat) + Math.Abs(104.97914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65724 - lat) + Math.Abs(105.06021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79156 - lat) + Math.Abs(106.74948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.8397 - lat) + Math.Abs(106.77093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.76684 - lat) + Math.Abs(106.70574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7468 - lat) + Math.Abs(106.64903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.75567 - lat) + Math.Abs(106.66745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78069 - lat) + Math.Abs(106.69944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79475 - lat) + Math.Abs(106.6763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78379 - lat) + Math.Abs(106.63704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.76383 - lat) + Math.Abs(106.64355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.76823 - lat) + Math.Abs(106.66632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.77494 - lat) + Math.Abs(106.68628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.80325 - lat) + Math.Abs(106.69666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.33052 - lat) + Math.Abs(103.82485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.66657 - lat) + Math.Abs(112.72541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25616 - lat) + Math.Abs(105.5928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yên Vinh", "58", 18.66667, 105.66667);
case 1: return new CityInfo("Yên Thành", "58", 18.99856, 105.47116);
case 2: return new CityInfo("Yên Ninh", "59", 20.18396, 106.06121);
case 3: return new CityInfo("Thị Trấn Yên Minh", "50", 23.11792, 105.14159);
case 4: return new CityInfo("Yến Lạc", "72", 22.23693, 106.18149);
case 5: return new CityInfo("Yên Lạc", "86", 21.23646, 105.57297);
case 6: return new CityInfo("Yên Châu", "32", 21.04584, 104.30101);
case 7: return new CityInfo("Yên Bái", "70", 21.72288, 104.9113);
case 8: return new CityInfo("Cai Doi Vam", "77", 8.85707, 104.81199);
case 9: return new CityInfo("Trảng Bom", "43", 10.95358, 107.00589);
case 10: return new CityInfo("Gia Ray", "43", 10.92615, 107.40172);
case 11: return new CityInfo("Vũng Tàu", "45", 10.34599, 107.08426);
case 12: return new CityInfo("Vũng Liêm", "69", 10.09576, 106.18548);
case 13: return new CityInfo("Vụ Bản", "53", 20.4642, 105.44348);
case 14: return new CityInfo("Võ Xu", "47", 11.18691, 107.56025);
case 15: return new CityInfo("Vị Thanh", "93", 9.78449, 105.47012);
case 16: return new CityInfo("Vĩnh Yên", "86", 21.30891, 105.60489);
case 17: return new CityInfo("Thị Trấn Vĩnh Tuy", "50", 22.27441, 104.89091);
case 18: return new CityInfo("Vĩnh Thuận", "21", 9.50802, 105.25747);
case 19: return new CityInfo("Vĩnh Thạnh", "46", 14.10884, 108.78381);
case 20: return new CityInfo("Vĩnh Long", "69", 10.25369, 105.9722);
case 21: return new CityInfo("Vĩnh Lộc", "34", 20.05438, 105.61567);
case 22: return new CityInfo("Vĩnh Châu", "65", 9.32439, 105.98006);
case 23: return new CityInfo("Vĩnh Bình", "37", 10.34498, 106.58056);
case 24: return new CityInfo("Vinh", "58", 18.67337, 105.69232);
case 25: return new CityInfo("Việt Trì", "83", 21.32274, 105.40198);
case 26: return new CityInfo("Văn Quan", "39", 21.86516, 106.53925);
case 27: return new CityInfo("Vạn Giã", "54", 12.69203, 109.22069);
case 28: return new CityInfo("Vân Đình", "44", 20.73514, 105.77236);
case 29: return new CityInfo("Văn Điển", "44", 20.9463, 105.845);
case 30: return new CityInfo("Vân Canh", "46", 13.61945, 108.99805);
case 31: return new CityInfo("Thành Phố Uông Bí", "30", 21.03433, 106.77049);
case 32: return new CityInfo("Tuy Phước", "46", 13.82738, 109.16651);
case 33: return new CityInfo("Tuy Hòa", "61", 13.09546, 109.32094);
case 34: return new CityInfo("Tuyên Quang", "68", 21.82356, 105.21424);
case 35: return new CityInfo("Hòa Bình", "58", 19.26393, 104.47232);
case 36: return new CityInfo("Tư Nghĩa", "63", 15.08451, 108.826);
case 37: return new CityInfo("Thị Trấn Trùng Khánh", "05", 22.83514, 106.52496);
case 38: return new CityInfo("Tri Tôn", "01", 10.4202, 105.00073);
case 39: return new CityInfo("Trà Vinh", "67", 9.94719, 106.34225);
case 40: return new CityInfo("Trà Ôn", "69", 9.96261, 105.92168);
case 41: return new CityInfo("Trảng Bàng", "33", 11.02987, 106.35751);
case 42: return new CityInfo("Thị Trấn Trạm Tấu", "70", 21.46659, 104.37966);
case 43: return new CityInfo("Trà My", "84", 15.33965, 108.22065);
case 44: return new CityInfo("Tràm Chim", "09", 10.67001, 105.56469);
case 45: return new CityInfo("Trà Cú", "67", 9.69774, 106.25834);
case 46: return new CityInfo("Trà Bồng", "63", 15.25569, 108.51722);
case 47: return new CityInfo("Tĩnh Gia", "34", 19.44645, 105.77861);
case 48: return new CityInfo("Tiểu Cần", "67", 9.81166, 106.19067);
case 49: return new CityInfo("Tiên Phước", "84", 15.48819, 108.30736);
case 50: return new CityInfo("Thủ Thừa", "24", 10.60232, 106.40207);
case 51: return new CityInfo("Thường Xuân", "34", 19.90294, 105.34723);
case 52: return new CityInfo("Thủ Đức", "20", 10.84863, 106.77209);
case 53: return new CityInfo("Thủ Dầu Một", "75", 10.9804, 106.6519);
case 54: return new CityInfo("Thọ Xuân", "34", 19.93133, 105.52179);
case 55: return new CityInfo("Thốt Nốt", "87", 10.27213, 105.5338);
case 56: return new CityInfo("Thới Lai", "87", 10.06522, 105.55863);
case 57: return new CityInfo("Thới Bình", "77", 9.35584, 105.09929);
case 58: return new CityInfo("Ái Tử", "64", 16.76886, 107.16504);
case 59: return new CityInfo("Thị Trấn Thất Khê", "39", 22.25525, 106.47359);
case 60: return new CityInfo("Than Uyên", "89", 21.95907, 103.88001);
case 61: return new CityInfo("Phú Lộc", "65", 9.42838, 105.74111);
case 62: return new CityInfo("Thanh Sơn", "83", 21.19867, 105.17892);
case 63: return new CityInfo("Thạnh Phú", "03", 9.94827, 106.51629);
case 64: return new CityInfo("Ho Chi Minh City", "20", 10.82302, 106.62965);
case 65: return new CityInfo("Thanh Nê", "35", 20.3881, 106.43834);
case 66: return new CityInfo("Thanh Hóa", "34", 19.8, 105.76667);
case 67: return new CityInfo("Thanh Chương", "58", 18.77877, 105.33356);
case 68: return new CityInfo("Thanh Bình", "09", 10.5619, 105.48411);
case 69: return new CityInfo("Thái Nguyên", "85", 21.59422, 105.84817);
case 70: return new CityInfo("Thái Bình", "35", 20.45, 106.34002);
case 71: return new CityInfo("Kim Tân", "34", 20.13053, 105.67454);
case 72: return new CityInfo("Thạch Hà", "52", 18.36788, 105.86122);
case 73: return new CityInfo("Tây Ninh", "33", 11.31004, 106.09828);
case 74: return new CityInfo("Tây Hồ", "44", 21.06895, 105.81053);
case 75: return new CityInfo("Tây Đằng", "44", 21.19809, 105.42217);
case 76: return new CityInfo("Đầm Dơi", "77", 8.99214, 105.19602);
case 77: return new CityInfo("Tân Kỳ", "58", 19.04756, 105.26807);
case 78: return new CityInfo("Tánh Linh", "47", 11.08421, 107.68095);
case 79: return new CityInfo("Tân Hiệp", "37", 10.44905, 106.34386);
case 80: return new CityInfo("Tân Hiệp", "21", 10.11709, 105.28578);
case 81: return new CityInfo("Tân Châu", "01", 10.79832, 105.23887);
case 82: return new CityInfo("Tân An", "24", 10.53589, 106.41366);
case 83: return new CityInfo("Tam Kỳ", "84", 15.57364, 108.47403);
case 84: return new CityInfo("Trai Ngau", "86", 21.39324, 105.61441);
case 85: return new CityInfo("Tam Bình", "69", 10.04811, 106.00017);
case 86: return new CityInfo("Thị Trấn Tà Lùng", "05", 22.4979, 106.5669);
case 87: return new CityInfo("Sơn Tịnh", "63", 15.15856, 108.79582);
case 88: return new CityInfo("Sơn Tây", "44", 21.14053, 105.50686);
case 89: return new CityInfo("Sơn Hà", "63", 15.04193, 108.46973);
case 90: return new CityInfo("Sơn Dương", "68", 21.69676, 105.39901);
case 91: return new CityInfo("Sơn La", "32", 21.3256, 103.91882);
case 92: return new CityInfo("Sông Mã", "32", 21.05091, 103.74987);
case 93: return new CityInfo("Sông Cầu", "61", 13.4556, 109.22348);
case 94: return new CityInfo("Sóc Trăng", "65", 9.59995, 105.97193);
case 95: return new CityInfo("Thị Trấn Sìn Hồ", "89", 22.36647, 103.23438);
case 96: return new CityInfo("Si Ma Cai", "90", 22.6951, 104.27857);
case 97: return new CityInfo("Sa Pa", "90", 22.34023, 103.84415);
case 98: return new CityInfo("Sa Dec", "09", 10.29085, 105.75635);
case 99: return new CityInfo("Rạch Giá", "21", 10.01245, 105.08091);
case 100: return new CityInfo("Mường Chiên", "32", 21.8424, 103.56608);
case 101: return new CityInfo("Quỳnh Côi", "35", 20.66192, 106.32744);
case 102: return new CityInfo("Qui Nhon", "46", 13.77648, 109.22367);
case 103: return new CityInfo("Quỳ Hợp", "58", 19.32546, 105.18251);
case 104: return new CityInfo("Oui Dat", "62", 17.80459, 105.97044);
case 105: return new CityInfo("Quỳ Châu", "58", 19.55206, 105.09387);
case 106: return new CityInfo("Quế Sơn", "84", 15.67356, 108.2201);
case 107: return new CityInfo("Kim Sơn", "58", 19.60409, 104.91903);
case 108: return new CityInfo("Quan Hóa", "34", 20.38481, 105.10024);
case 109: return new CityInfo("Quảng Yên", "30", 20.9421, 106.8027);
case 110: return new CityInfo("Thị Trấn Quảng Uyên", "05", 22.69499, 106.44235);
case 111: return new CityInfo("Ba Đồn", "62", 17.75353, 106.42355);
case 112: return new CityInfo("Quán Hàu", "62", 17.40438, 106.64072);
case 113: return new CityInfo("Quảng Ngãi", "63", 15.12047, 108.79232);
case 114: return new CityInfo("Plei Kần", "55", 14.70495, 107.6862);
case 115: return new CityInfo("Pleiku", "49", 13.98333, 108);
case 116: return new CityInfo("Phù Yên", "32", 21.26331, 104.64439);
case 117: return new CityInfo("Phú Vang", "66", 16.43911, 107.71438);
case 118: return new CityInfo("Phú Túc", "49", 13.19682, 108.69043);
case 119: return new CityInfo("Phủ Thông", "72", 22.27314, 105.87943);
case 120: return new CityInfo("Phú Thọ", "83", 21.39963, 105.22221);
case 121: return new CityInfo("Dương Đông", "21", 10.21716, 103.95929);
case 122: return new CityInfo("Phú Phong", "46", 13.90964, 108.91903);
case 123: return new CityInfo("Phước An", "88", 12.71298, 108.30148);
case 124: return new CityInfo("Phù Ninh", "15", 21.08333, 105.95);
case 125: return new CityInfo("Phụng Hiệp", "93", 9.77972, 105.7338);
case 126: return new CityInfo("Phù Mỹ", "46", 14.17182, 109.04888);
case 127: return new CityInfo("Phủ Lý", "80", 20.54531, 105.91221);
case 128: return new CityInfo("Phú Lộc", "66", 16.28035, 107.85898);
case 129: return new CityInfo("Phú Khương", "33", 11.28333, 106.13333);
case 130: return new CityInfo("Phúc Yên", "86", 21.23695, 105.70483);
case 131: return new CityInfo("Phù Cát", "46", 14.00316, 109.05804);
case 132: return new CityInfo("Phong Thổ", "89", 22.54433, 103.29776);
case 133: return new CityInfo("Phong Điền", "66", 16.58321, 107.36438);
case 134: return new CityInfo("Phong Điền", "87", 9.99753, 105.6673);
case 135: return new CityInfo("Thị Trấn Phố Lu", "90", 22.31918, 104.18719);
case 136: return new CityInfo("Phố Châu", "52", 18.51335, 105.42411);
case 137: return new CityInfo("Bến Sung", "34", 19.63141, 105.57815);
case 138: return new CityInfo("Phát Diệm", "59", 20.09054, 106.08323);
case 139: return new CityInfo("Phan Thiết", "47", 10.92889, 108.10208);
case 140: return new CityInfo("Phan Rang-Tháp Chàm", "60", 11.56432, 108.98858);
case 141: return new CityInfo("Ô Môn", "87", 10.10974, 105.62318);
case 142: return new CityInfo("Thị Trấn Nước Hai", "05", 22.73738, 106.15216);
case 143: return new CityInfo("Núi Đèo", "13", 20.91569, 106.6744);
case 144: return new CityInfo("Ninh Hòa", "54", 12.49187, 109.12495);
case 145: return new CityInfo("Ninh Giang", "79", 20.73083, 106.39789);
case 146: return new CityInfo("Ninh Bình", "59", 20.25809, 105.97965);
case 147: return new CityInfo("Như Quỳnh", "81", 20.98167, 105.98486);
case 148: return new CityInfo("Nho Quan", "59", 20.32279, 105.75189);
case 149: return new CityInfo("Nhơn Trạch", "43", 10.72294, 106.88341);
case 150: return new CityInfo("Nha Trang", "54", 12.24507, 109.19432);
case 151: return new CityInfo("Nhà Bè", "20", 10.69672, 106.74032);
case 152: return new CityInfo("Nhà Bàng", "01", 10.62502, 105.00854);
case 153: return new CityInfo("Thị Trấn Nguyên Bình", "05", 22.64995, 105.95985);
case 154: return new CityInfo("Ngô Đồng", "82", 20.28296, 106.44347);
case 155: return new CityInfo("Ngọc Lặc", "34", 20.09189, 105.36761);
case 156: return new CityInfo("Tiền Hải", "35", 20.40557, 106.50365);
case 157: return new CityInfo("Nghi Xuân", "52", 18.66206, 105.75575);
case 158: return new CityInfo("Quán Hành", "58", 18.77927, 105.64597);
case 159: return new CityInfo("Nghĩa Hành", "63", 15.04568, 108.77724);
case 160: return new CityInfo("Nga Sơn", "34", 20.00722, 105.97044);
case 161: return new CityInfo("Vân Tùng", "72", 22.43082, 105.99687);
case 162: return new CityInfo("Thị Trấn Ngải Giao", "45", 10.6471, 107.24577);
case 163: return new CityInfo("Thị Trấn Na Sầm", "39", 22.05639, 106.6151);
case 164: return new CityInfo("Nam Định", "82", 20.43389, 106.17729);
case 165: return new CityInfo("Nam Đàn", "58", 18.69799, 105.49881);
case 166: return new CityInfo("Năm Căn", "77", 8.75899, 104.99285);
case 167: return new CityInfo("Mỹ Xuyên", "65", 9.56006, 105.98984);
case 168: return new CityInfo("Mỹ Tho", "37", 10.36004, 106.35996);
case 169: return new CityInfo("Mỹ Thọ", "09", 10.44267, 105.69508);
case 170: return new CityInfo("Mỹ Lộc", "82", 20.44111, 106.10238);
case 171: return new CityInfo("Thạnh Mỹ", "84", 15.74889, 107.83678);
case 172: return new CityInfo("Mường Nhé", "92", 22.19236, 102.4579);
case 173: return new CityInfo("Thị Trấn Mường Khương", "90", 22.76141, 104.12156);
case 174: return new CityInfo("Mường Lát", "34", 20.52915, 104.60138);
case 175: return new CityInfo("Mù Cang Chải", "70", 21.85125, 104.08954);
case 176: return new CityInfo("Móng Cái", "30", 21.52471, 107.96619);
case 177: return new CityInfo("Mộ Đức", "63", 14.95513, 108.88586);
case 178: return new CityInfo("Mộc Châu", "32", 20.85199, 104.62177);
case 179: return new CityInfo("Mỏ Cày", "03", 10.13312, 106.33519);
case 180: return new CityInfo("Minh Lương", "21", 9.90248, 105.1595);
case 181: return new CityInfo("Minh Long", "63", 14.93218, 108.70328);
case 182: return new CityInfo("Thị Trấn Mèo Vạc", "50", 23.16411, 105.40993);
case 183: return new CityInfo("Ma Đa Gui", "23", 11.38702, 107.53508);
case 184: return new CityInfo("Long Xuyên", "01", 10.38639, 105.43518);
case 185: return new CityInfo("Long Thành", "43", 10.78909, 106.95029);
case 186: return new CityInfo("Long Phú", "65", 9.61025, 106.11881);
case 187: return new CityInfo("Long Mỹ", "93", 9.68141, 105.57226);
case 188: return new CityInfo("Lộc Ninh", "76", 11.84476, 106.59073);
case 189: return new CityInfo("Lộc Bình", "39", 21.75873, 106.92335);
case 190: return new CityInfo("Lien De", "82", 20.22095, 106.18747);
case 191: return new CityInfo("Liên Hương", "47", 11.22761, 108.72366);
case 192: return new CityInfo("Kiến Giang", "62", 17.22328, 106.79011);
case 193: return new CityInfo("Lấp Vò", "09", 10.36161, 105.51924);
case 194: return new CityInfo("Lao Chải", "90", 22.31377, 103.86844);
case 195: return new CityInfo("Lào Cai", "90", 22.48556, 103.97066);
case 196: return new CityInfo("Lạng Sơn", "39", 21.85264, 106.76101);
case 197: return new CityInfo("Thị Trấn Phước Bửu", "45", 10.53472, 107.40202);
case 198: return new CityInfo("Lũng Hồ", "50", 22.98479, 105.23983);
case 199: return new CityInfo("Lang Chánh", "34", 20.15611, 105.24223);
case 200: return new CityInfo("Lai Vung", "09", 10.28701, 105.6617);
case 201: return new CityInfo("Lái Thiêu", "75", 10.90512, 106.69949);
case 202: return new CityInfo("Lai Cách", "79", 20.93252, 106.24756);
case 203: return new CityInfo("La Gi", "47", 10.65993, 107.77206);
case 204: return new CityInfo("Lắk", "88", 12.41086, 108.17682);
case 205: return new CityInfo("Lạc Dương", "23", 12.00405, 108.41905);
case 206: return new CityInfo("Mường Xén", "58", 19.39795, 104.15239);
case 207: return new CityInfo("Kỳ Anh", "52", 18.06243, 106.29832);
case 208: return new CityInfo("Kon Tum", "55", 14.35451, 108.00759);
case 209: return new CityInfo("Kinh Môn", "79", 20.98962, 106.5551);
case 210: return new CityInfo("Kim Bài", "44", 20.85265, 105.76963);
case 211: return new CityInfo("Kiên Lương", "21", 10.28624, 104.64616);
case 212: return new CityInfo("Khe Sanh", "64", 16.62825, 106.73884);
case 213: return new CityInfo("Thị Trấn Khánh Yên", "90", 22.08935, 104.25149);
case 214: return new CityInfo("Kẻ Sặt", "79", 20.91007, 106.14771);
case 215: return new CityInfo("Kế Sách", "65", 9.76743, 105.98574);
case 216: return new CityInfo("Hữu Lũng", "39", 21.5056, 106.34459);
case 217: return new CityInfo("Hương Trà", "66", 16.52539, 107.4755);
case 218: return new CityInfo("Hương Khê", "52", 18.17669, 105.70019);
case 219: return new CityInfo("Hương Canh", "86", 21.27882, 105.64697);
case 220: return new CityInfo("Hưng Yên", "81", 20.64637, 106.05112);
case 221: return new CityInfo("Huế", "66", 16.4619, 107.59546);
case 222: return new CityInfo("Hồ Xá", "64", 17.06836, 107.0052);
case 223: return new CityInfo("Bình Long", "76", 11.64711, 106.60586);
case 224: return new CityInfo("Hạ Long", "30", 20.95045, 107.07336);
case 225: return new CityInfo("Ngoc Hon Doc", "21", 10.18462, 104.92959);
case 226: return new CityInfo("Hội An", "84", 15.87944, 108.335);
case 227: return new CityInfo("Hóc Môn", "20", 10.8891, 106.59533);
case 228: return new CityInfo("Hòa Vang", "78", 15.98764, 108.13893);
case 229: return new CityInfo("Hòa Mạc", "80", 20.64173, 105.989);
case 230: return new CityInfo("Hoài Ân", "46", 14.36352, 108.96476);
case 231: return new CityInfo("Hòa Bình", "53", 20.81717, 105.33759);
case 232: return new CityInfo("Doug An", "84", 15.58224, 108.11422);
case 233: return new CityInfo("Hà Tĩnh", "52", 18.34282, 105.90569);
case 234: return new CityInfo("Hà Tiên", "21", 10.3831, 104.48753);
case 235: return new CityInfo("Hanoi", "44", 21.0245, 105.84117);
case 236: return new CityInfo("Thị Trấn Thanh Nhật", "05", 22.68749, 106.67004);
case 237: return new CityInfo("Hà Lam", "84", 15.73871, 108.35062);
case 238: return new CityInfo("Haiphong", "13", 20.86481, 106.68345);
case 239: return new CityInfo("Hải Lăng", "64", 16.69347, 107.25124);
case 240: return new CityInfo("Hải Dương", "79", 20.94099, 106.33302);
case 241: return new CityInfo("Hạ Hòa", "83", 21.56302, 105.00512);
case 242: return new CityInfo("Hà Giang", "50", 22.82333, 104.98357);
case 243: return new CityInfo("Hà Đông", "44", 20.97136, 105.77876);
case 244: return new CityInfo("Gò Quao", "21", 9.7332, 105.27393);
case 245: return new CityInfo("Giồng Riềng", "21", 9.90974, 105.31433);
case 246: return new CityInfo("Gio Linh", "64", 16.9248, 107.08438);
case 247: return new CityInfo("Gia Nghĩa", "91", 12.00423, 107.69074);
case 248: return new CityInfo("Duy Xuyên", "84", 15.82898, 108.25956);
case 249: return new CityInfo("Đưc Trọng", "23", 11.73559, 108.3733);
case 250: return new CityInfo("Đức Thọ", "52", 18.53957, 105.58302);
case 251: return new CityInfo("Đức Phong", "76", 11.81346, 107.24433);
case 252: return new CityInfo("Pho Duc", "63", 14.81355, 108.95931);
case 253: return new CityInfo("Tram de Dak Mil", "91", 12.44957, 107.62237);
case 254: return new CityInfo("La Hai", "61", 13.37732, 109.10807);
case 255: return new CityInfo("Don Luan", "76", 11.53495, 106.88324);
case 256: return new CityInfo("Thị Trấn Đồng Văn", "50", 23.27841, 105.36291);
case 257: return new CityInfo("Đồng Mỏ", "39", 21.65701, 106.57832);
case 258: return new CityInfo("Thị Trấn Đông Khê", "05", 22.42939, 106.43194);
case 259: return new CityInfo("Kwang Binh", "62", 17.46885, 106.62226);
case 260: return new CityInfo("Ðông Hà", "64", 16.81625, 107.10031);
case 261: return new CityInfo("Anh Son", "58", 18.96961, 105.05505);
case 262: return new CityInfo("Đoan Hùng", "83", 21.62254, 105.18462);
case 263: return new CityInfo("Đình Lập", "39", 21.54633, 107.09812);
case 264: return new CityInfo("Di Linh", "23", 11.58153, 108.07641);
case 265: return new CityInfo("Diên Khánh", "54", 12.2549, 109.09332);
case 266: return new CityInfo("Diễn Châu", "58", 18.97652, 105.60034);
case 267: return new CityInfo("Dien Bien Phu", "92", 21.38602, 103.02301);
case 268: return new CityInfo("Quang Nam", "84", 15.88853, 108.25447);
case 269: return new CityInfo("Giemdiem", "35", 20.55832, 106.56882);
case 270: return new CityInfo("Dĩ An", "75", 10.90682, 106.7694);
case 271: return new CityInfo("Dầu Tiếng", "75", 11.2741, 106.35879);
case 272: return new CityInfo("Phuoc Tho", "45", 10.49093, 107.27014);
case 273: return new CityInfo("Da Nang", "78", 16.06778, 108.22083);
case 274: return new CityInfo("Ðà Lạt", "23", 11.94646, 108.44193);
case 275: return new CityInfo("Đắk Song", "91", 12.25518, 107.60924);
case 276: return new CityInfo("Đại Lộc", "84", 15.88214, 108.12092);
case 277: return new CityInfo("Đắk Tô", "55", 14.66092, 107.8389);
case 278: return new CityInfo("Củng Sơn", "61", 13.04998, 108.97895);
case 279: return new CityInfo("Củ Chi", "20", 10.97333, 106.49325);
case 280: return new CityInfo("Cờ Đỏ", "87", 10.09377, 105.42916);
case 281: return new CityInfo("Côn Sơn", "45", 8.68641, 106.60824);
case 282: return new CityInfo("Con Cuông", "58", 19.04996, 104.88124);
case 283: return new CityInfo("Chúc Sơn", "44", 20.92375, 105.70155);
case 284: return new CityInfo("Chũ", "71", 21.37379, 106.56649);
case 285: return new CityInfo("Chơn Thành", "76", 11.42821, 106.63536);
case 286: return new CityInfo("Chợ Mới", "72", 21.88374, 105.77281);
case 287: return new CityInfo("Chợ Mới", "01", 10.55123, 105.40441);
case 288: return new CityInfo("Chợ Lách", "03", 10.26032, 106.11892);
case 289: return new CityInfo("Giồng Trôm", "03", 10.15021, 106.50606);
case 290: return new CityInfo("Chợ Gạo", "37", 10.34984, 106.4634);
case 291: return new CityInfo("Chợ Chu", "85", 21.90724, 105.64219);
case 292: return new CityInfo("Chí Thạnh", "61", 13.30845, 109.21522);
case 293: return new CityInfo("Chi Nê", "53", 20.49056, 105.778);
case 294: return new CityInfo("Huyện Chiêm Hóa", "68", 22.14413, 105.27277);
case 295: return new CityInfo("Cho Dok", "01", 10.7, 105.11667);
case 296: return new CityInfo("Cầu Kè", "67", 9.8724, 106.05497);
case 297: return new CityInfo("Cầu Giát", "58", 19.146, 105.63089);
case 298: return new CityInfo("Cát Bà", "13", 20.72779, 107.04819);
case 299: return new CityInfo("Cao Thượng", "71", 21.38707, 106.12931);
case 300: return new CityInfo("Cao Lãnh", "09", 10.46017, 105.63294);
case 301: return new CityInfo("Cao Bằng", "05", 22.66568, 106.25786);
case 302: return new CityInfo("Cần Thơ", "87", 10.03711, 105.78825);
case 303: return new CityInfo("Cần Giờ", "20", 10.41115, 106.95474);
case 304: return new CityInfo("Cần Đước", "24", 10.50966, 106.60308);
case 305: return new CityInfo("Cần Giuộc", "24", 10.60857, 106.67135);
case 306: return new CityInfo("Cẩm Xuyên", "52", 18.25029, 106.00132);
case 307: return new CityInfo("Cẩm Thủy", "34", 20.20866, 105.4695);
case 308: return new CityInfo("Cam Ranh", "54", 11.92144, 109.15913);
case 309: return new CityInfo("Cẩm Phả Mines", "30", 21.01667, 107.3);
case 310: return new CityInfo("Cẩm Phả", "30", 21.01004, 107.27345);
case 311: return new CityInfo("Cam Lộ", "64", 16.80797, 106.99405);
case 312: return new CityInfo("Cà Mau", "77", 9.17682, 105.15242);
case 313: return new CityInfo("Cái Tàu Hạ", "09", 10.25973, 105.87044);
case 314: return new CityInfo("Cái Răng", "87", 10.0009, 105.75095);
case 315: return new CityInfo("Cái Nước", "77", 8.94231, 105.01411);
case 316: return new CityInfo("Cái Nhum", "69", 10.17412, 106.11051);
case 317: return new CityInfo("Buôn Trấp", "88", 12.48478, 108.02982);
case 318: return new CityInfo("Buôn Ma Thuột", "88", 12.66747, 108.03775);
case 319: return new CityInfo("Hoàn Lão", "62", 17.58436, 106.53425);
case 320: return new CityInfo("Bồng Sơn", "46", 14.42907, 109.0156);
case 321: return new CityInfo("Bù Đốp", "76", 11.95486, 106.80018);
case 322: return new CityInfo("Bình Thủy", "87", 10.07431, 105.73974);
case 323: return new CityInfo("Bình Sơn", "63", 15.29776, 108.76124);
case 324: return new CityInfo("Bình Gia", "39", 21.96094, 106.36448);
case 325: return new CityInfo("Bình Đại", "03", 10.18964, 106.69149);
case 326: return new CityInfo("Tân Túc", "20", 10.69541, 106.59128);
case 327: return new CityInfo("Bỉm Sơn", "34", 20.07806, 105.86028);
case 328: return new CityInfo("Biên Hòa", "43", 10.94469, 106.82432);
case 329: return new CityInfo("Bến Tre", "03", 10.24147, 106.37585);
case 330: return new CityInfo("Bến Cầu", "33", 11.11051, 106.17924);
case 331: return new CityInfo("Ba Tri", "03", 10.04427, 106.5902);
case 332: return new CityInfo("Ba Tơ", "63", 14.7636, 108.73223);
case 333: return new CityInfo("Thị Trấn Phố Ràng", "90", 22.23429, 104.47643);
case 334: return new CityInfo("Bảo Lộc", "23", 11.54798, 107.80772);
case 335: return new CityInfo("Thị Trấn Bảo Lạc", "05", 22.94924, 105.68046);
case 336: return new CityInfo("Bẩn Yên Nhân", "81", 20.93653, 106.05711);
case 337: return new CityInfo("Ít Ong", "32", 21.5175, 104.02701);
case 338: return new CityInfo("Thị Trấn Thuận Châu", "32", 21.43849, 103.69);
case 339: return new CityInfo("Bắc Yên", "32", 21.24626, 104.43281);
case 340: return new CityInfo("Bắc Sơn", "39", 21.89999, 106.32077);
case 341: return new CityInfo("Bắc Ninh", "74", 21.18608, 106.07631);
case 342: return new CityInfo("Bạc Liêu", "73", 9.29414, 105.72776);
case 343: return new CityInfo("Bắc Hà", "90", 22.53911, 104.29305);
case 344: return new CityInfo("Bắc Giang", "71", 21.27307, 106.1946);
case 345: return new CityInfo("Bắc Kạn", "72", 22.14701, 105.83481);
case 346: return new CityInfo("Tân Trụ", "24", 10.51271, 106.50762);
case 347: return new CityInfo("Ấp Tân Ngãi", "03", 10.23333, 106.28333);
case 348: return new CityInfo("An Hòa", "09", 10.29693, 105.74435);
case 349: return new CityInfo("An Nhơn", "46", 13.88579, 109.10823);
case 350: return new CityInfo("An Lão", "46", 14.61241, 108.8899);
case 351: return new CityInfo("An Dương", "13", 20.86382, 106.6133);
case 352: return new CityInfo("An Châu", "71", 21.33465, 106.84934);
case 353: return new CityInfo("An Biên", "21", 9.81532, 105.06366);
case 354: return new CityInfo("A Lưới", "66", 16.27228, 107.23385);
case 355: return new CityInfo("Quận Bảy", "20", 10.7118, 106.73643);
case 356: return new CityInfo("Tam Điệp", "59", 20.15635, 105.91737);
case 357: return new CityInfo("Châu Thành", "67", 9.86989, 106.34939);
case 358: return new CityInfo("Uyen Hung", "49", 11.08416, 106.78834);
case 359: return new CityInfo("Yên Lập", "83", 21.34705, 105.05739);
case 360: return new CityInfo("Thanh Ba", "83", 21.49881, 105.14104);
case 361: return new CityInfo("Sông Thao", "83", 21.4213, 105.13374);
case 362: return new CityInfo("Hưng Hóa", "83", 21.25487, 105.2953);
case 363: return new CityInfo("Phong Châu", "83", 21.4068, 105.31228);
case 364: return new CityInfo("Thị Trấn Tân Yên", "68", 22.0655, 105.0345);
case 365: return new CityInfo("Tân Việt", "05", 22.86407, 105.45905);
case 366: return new CityInfo("Pác Miầu", "05", 22.82968, 105.49334);
case 367: return new CityInfo("Lập Thạch", "86", 21.41539, 105.46081);
case 368: return new CityInfo("An Châu", "01", 10.44559, 105.38622);
case 369: return new CityInfo("Núi Sập", "01", 10.26478, 105.26676);
case 370: return new CityInfo("Tầm Vu", "24", 10.44114, 106.46793);
case 371: return new CityInfo("Gia Bình", "74", 21.05938, 106.17468);
case 372: return new CityInfo("Thứa", "74", 21.01937, 106.20044);
case 373: return new CityInfo("Chờ", "74", 21.19491, 105.95471);
case 374: return new CityInfo("Phố Mới", "74", 21.15328, 106.15164);
case 375: return new CityInfo("Hồ", "74", 21.06308, 106.0857);
case 376: return new CityInfo("Lim", "74", 21.14388, 106.02018);
case 377: return new CityInfo("Cung Kiệm", "74", 21.18697, 106.16076);
case 378: return new CityInfo("Thị Trấn Gành Hào", "73", 9.03183, 105.42115);
case 379: return new CityInfo("Thị Trấn Ngan Dừa", "73", 9.56703, 105.45019);
case 380: return new CityInfo("Thị Trấn Phước Long", "73", 9.43753, 105.46217);
case 381: return new CityInfo("Thị Trấn Giá Rai", "73", 9.23789, 105.45524);
case 382: return new CityInfo("Thị Trấn Hòa Bình", "73", 9.28471, 105.62916);
case 383: return new CityInfo("Cái Dầu", "01", 10.57428, 105.24005);
case 384: return new CityInfo("Cầu Gồ", "71", 21.47679, 106.12653);
case 385: return new CityInfo("Đồi Ngô", "71", 21.30626, 106.38673);
case 386: return new CityInfo("Neo", "71", 21.20048, 106.24739);
case 387: return new CityInfo("Bích Động", "71", 21.27421, 106.10069);
case 388: return new CityInfo("Thắng", "71", 21.35505, 105.98344);
case 389: return new CityInfo("Bộc Bố", "72", 22.61206, 105.66707);
case 390: return new CityInfo("Bằng Lũng", "72", 22.15777, 105.59559);
case 391: return new CityInfo("Thị Trấn Long Điền", "45", 10.48557, 107.21226);
case 392: return new CityInfo("Thị Xã Phú Mỹ", "45", 10.56815, 107.12999);
case 393: return new CityInfo("Mường Chà", "92", 21.76172, 103.09783);
case 394: return new CityInfo("Thị Trấn Tủa Chùa", "92", 21.85771, 103.3426);
case 395: return new CityInfo("Điện Biên Đông", "92", 21.29673, 103.22009);
case 396: return new CityInfo("Thị Trấn Điện Biên", "92", 21.2596, 103.0344);
case 397: return new CityInfo("Tam Đường", "89", 22.31812, 103.62619);
case 398: return new CityInfo("Lai Châu", "89", 22.39644, 103.45824);
case 399: return new CityInfo("Thị Trấn Mường Tè", "89", 22.38067, 102.82011);
case 400: return new CityInfo("Thị Trấn Tam Sơn", "50", 23.0674, 104.98926);
case 401: return new CityInfo("Thị Trấn Vị Xuyên", "50", 22.66762, 104.98191);
case 402: return new CityInfo("Thị Trấn Việt Lâm", "50", 22.62486, 104.95988);
case 403: return new CityInfo("Thị Trấn Việt Quang", "50", 22.41509, 104.80682);
case 404: return new CityInfo("Yên Phú", "50", 22.73223, 105.37145);
case 405: return new CityInfo("Thị Trấn Vinh Quang", "50", 22.74085, 104.67956);
case 406: return new CityInfo("Yên Bình", "50", 22.40989, 104.57949);
case 407: return new CityInfo("Thị Trấn Thông Nông", "05", 22.7841, 105.9832);
case 408: return new CityInfo("Thị Trấn Xuân Hoà", "05", 22.90243, 106.07737);
case 409: return new CityInfo("Thị Trấn Hùng Quốc", "05", 22.82898, 106.32335);
case 410: return new CityInfo("Thị Trấn Cao Lộc", "39", 21.8665, 106.76833);
case 411: return new CityInfo("Thị Trấn Vĩnh Lộc", "68", 22.1436, 105.27192);
case 412: return new CityInfo("Sơn Thịnh", "70", 21.56252, 104.5948);
case 413: return new CityInfo("Cổ Phúc", "70", 21.75585, 104.82768);
case 414: return new CityInfo("Thị Trấn Yên Thế", "70", 22.11075, 104.76748);
case 415: return new CityInfo("Thị Trấn Na Hang", "68", 22.34917, 105.38241);
case 416: return new CityInfo("Bình Minh", "69", 10.06821, 105.82221);
case 417: return new CityInfo("An Phú", "01", 10.81591, 105.09038);
case 418: return new CityInfo("Phú Mỹ", "01", 10.59236, 105.35573);
case 419: return new CityInfo("Thị Trấn Phú Mỹ", "45", 10.6036, 107.054);
case 420: return new CityInfo("Bát Xát", "90", 22.54311, 103.88989);
case 421: return new CityInfo("Hát Lót", "32", 21.19733, 104.10595);
case 422: return new CityInfo("Quảng Xương", "34", 19.72948, 105.78273);
case 423: return new CityInfo("Nông Cống", "34", 19.62403, 105.64941);
case 424: return new CityInfo("Quan Sơn", "34", 20.25909, 104.94521);
case 425: return new CityInfo("Yên Cát", "34", 19.66327, 105.42854);
case 426: return new CityInfo("Bút Sơn", "34", 19.85797, 105.85482);
case 427: return new CityInfo("Cành Nàng", "34", 20.34803, 105.22881);
case 428: return new CityInfo("Hậu Lộc", "34", 19.91444, 105.88615);
case 429: return new CityInfo("Triệu Sơn", "34", 19.81913, 105.60392);
case 430: return new CityInfo("Quán Lào", "34", 19.97153, 105.65106);
case 431: return new CityInfo("Hà Trung", "34", 20.01285, 105.85322);
case 432: return new CityInfo("Rừng Thông", "34", 19.81906, 105.73279);
case 433: return new CityInfo("Vạn Hà", "34", 19.88659, 105.67879);
case 434: return new CityInfo("Đà Bắc", "53", 20.87714, 105.25417);
case 435: return new CityInfo("Mường Khến", "53", 20.61441, 105.27948);
case 436: return new CityInfo("Hàng Trạm", "53", 20.39472, 105.6224);
case 437: return new CityInfo("Bo", "53", 20.67264, 105.53625);
case 438: return new CityInfo("Lương Sơn", "53", 20.87148, 105.52568);
case 439: return new CityInfo("Kỳ Sơn", "53", 20.88668, 105.35244);
case 440: return new CityInfo("Cao Phong", "53", 20.70446, 105.32063);
case 441: return new CityInfo("Me", "59", 20.34697, 105.83615);
case 442: return new CityInfo("Thiên Tồn", "59", 20.29905, 105.95198);
case 443: return new CityInfo("Yên Thịnh", "59", 20.16245, 106.00697);
case 444: return new CityInfo("Xuân Trường", "82", 20.29227, 106.33275);
case 445: return new CityInfo("Yên Định", "82", 20.20145, 106.29578);
case 446: return new CityInfo("Lâm", "82", 20.32773, 106.01208);
case 447: return new CityInfo("Gôi", "82", 20.33335, 106.07826);
case 448: return new CityInfo("Nam Giang", "82", 20.33322, 106.17754);
case 449: return new CityInfo("Cổ Lễ", "82", 20.32336, 106.26584);
case 450: return new CityInfo("Quế", "80", 20.58064, 105.87266);
case 451: return new CityInfo("Vĩnh Trụ", "80", 20.5602, 106.02812);
case 452: return new CityInfo("Bình Mỹ", "80", 20.49121, 106.00955);
case 453: return new CityInfo("Thanh Lưu", "80", 20.47398, 105.95268);
case 454: return new CityInfo("Hưng Hà", "35", 20.5904, 106.22445);
case 455: return new CityInfo("Vũ Thư", "35", 20.43671, 106.29116);
case 456: return new CityInfo("Đông Hưng", "35", 20.55651, 106.35532);
case 457: return new CityInfo("Thành Phố Bà Rịa", "45", 10.49629, 107.16841);
case 458: return new CityInfo("Thị Trấn Tuần Giáo", "92", 21.58992, 103.42179);
case 459: return new CityInfo("Mường Ảng", "92", 21.51993, 103.22294);
case 460: return new CityInfo("An Lão", "13", 20.82294, 106.55575);
case 461: return new CityInfo("Tiên Lãng", "13", 20.72464, 106.55391);
case 462: return new CityInfo("Núi Đối", "13", 20.75078, 106.66894);
case 463: return new CityInfo("Quảng Hà", "30", 21.4506, 107.75592);
case 464: return new CityInfo("Trới", "30", 21.03141, 106.99101);
case 465: return new CityInfo("Cô Tô", "30", 20.97268, 107.76578);
case 466: return new CityInfo("Thanh Miện", "79", 20.78714, 106.24623);
case 467: return new CityInfo("Nam Sách", "79", 20.99205, 106.33613);
case 468: return new CityInfo("Gia Lộc", "79", 20.86783, 106.3);
case 469: return new CityInfo("Tứ Kỳ", "79", 20.81914, 106.40661);
case 470: return new CityInfo("Thanh Hà", "79", 20.89816, 106.42612);
case 471: return new CityInfo("Phú Thái", "79", 20.96278, 106.5095);
case 472: return new CityInfo("Đu", "85", 21.73847, 105.70388);
case 473: return new CityInfo("Hương Sơn", "85", 21.46014, 105.97814);
case 474: return new CityInfo("Chùa Hang", "85", 21.62384, 105.84168);
case 475: return new CityInfo("Thanh Thủy", "83", 21.17548, 105.28388);
case 476: return new CityInfo("Lâm Thao", "83", 21.3201, 105.29156);
case 477: return new CityInfo("Mê Linh", "44", 21.1831, 105.72041);
case 478: return new CityInfo("Vĩnh Tường", "86", 21.2165, 105.51249);
case 479: return new CityInfo("Hợp Hòa", "86", 21.37525, 105.54256);
case 480: return new CityInfo("Văn Giang", "81", 20.94301, 105.93119);
case 481: return new CityInfo("Yên Mỹ", "81", 20.88557, 106.0356);
case 482: return new CityInfo("Khoái Châu", "81", 20.83912, 105.97755);
case 483: return new CityInfo("Lương Bằng", "81", 20.74003, 106.05998);
case 484: return new CityInfo("Ân Thi", "81", 20.81835, 106.09118);
case 485: return new CityInfo("Trần Cao", "81", 20.72952, 106.17971);
case 486: return new CityInfo("Vương", "81", 20.7011, 106.11751);
case 487: return new CityInfo("Liên Quan", "44", 21.05723, 105.57919);
case 488: return new CityInfo("Phúc Thọ", "44", 21.10345, 105.54551);
case 489: return new CityInfo("Phùng", "44", 21.08902, 105.65901);
case 490: return new CityInfo("Trôi", "44", 21.06953, 105.70646);
case 491: return new CityInfo("Quốc Oai", "44", 20.99019, 105.64088);
case 492: return new CityInfo("Thường Tín", "44", 20.86874, 105.86125);
case 493: return new CityInfo("Phú Xuyên", "44", 20.74549, 105.91363);
case 494: return new CityInfo("Đại Nghĩa", "44", 20.68667, 105.74471);
case 495: return new CityInfo("Sóc Sơn", "44", 21.25782, 105.84894);
case 496: return new CityInfo("Đông Anh", "44", 21.13962, 105.84926);
case 497: return new CityInfo("Cầu Diễn", "44", 21.03929, 105.76659);
case 498: return new CityInfo("Trâu Quỳ", "44", 21.01951, 105.93694);
case 499: return new CityInfo("Cầu Giấy", "44", 21.03228, 105.80073);
case 500: return new CityInfo("Thanh Xuân", "44", 20.99472, 105.79977);
case 501: return new CityInfo("Đống Đa", "44", 21.02009, 105.83097);
case 502: return new CityInfo("Hoàn Kiếm", "44", 21.02857, 105.85064);
case 503: return new CityInfo("Hai BàTrưng", "44", 21.01341, 105.84772);
case 504: return new CityInfo("Hưng Nguyên", "58", 18.67165, 105.62882);
case 505: return new CityInfo("Vũ Quang", "52", 18.38385, 105.5059);
case 506: return new CityInfo("Nghèn", "52", 18.45119, 105.77969);
case 507: return new CityInfo("Đồng Lê", "62", 17.88389, 106.02536);
case 508: return new CityInfo("Krông Klang", "64", 16.68906, 106.8874);
case 509: return new CityInfo("Khe Tre", "66", 16.1691, 107.71793);
case 510: return new CityInfo("Sịa", "66", 16.57452, 107.51066);
case 511: return new CityInfo("Thanh Khê", "78", 16.0706, 108.19102);
case 512: return new CityInfo("Cẩm Lệ", "78", 16.01771, 108.20381);
case 513: return new CityInfo("Sơn Trà", "78", 16.06068, 108.23256);
case 514: return new CityInfo("Liên Chiểu", "78", 16.07272, 108.15815);
case 515: return new CityInfo("Ngũ Hành Sơn", "78", 16.01618, 108.25335);
case 516: return new CityInfo("Prao", "84", 15.92438, 107.64814);
case 517: return new CityInfo("Khâm Đức", "84", 15.44508, 107.79337);
case 518: return new CityInfo("Núi Thành", "84", 15.43194, 108.65946);
case 519: return new CityInfo("Phú Ninh", "84", 15.55473, 108.41142);
case 520: return new CityInfo("Tây Trà", "63", 15.16948, 108.35998);
case 521: return new CityInfo("Lý Sơn", "63", 15.37198, 109.11891);
case 522: return new CityInfo("Đắk Glei", "55", 15.08642, 107.73577);
case 523: return new CityInfo("Sa Thầy", "55", 14.41377, 107.79339);
case 524: return new CityInfo("Đắk Hà", "55", 14.51345, 107.92102);
case 525: return new CityInfo("Đắk Rve", "55", 14.50717, 108.2473);
case 526: return new CityInfo("Măng Đen", "55", 14.60064, 108.29088);
case 527: return new CityInfo("Đăk Đoa", "49", 13.99501, 108.11207);
case 528: return new CityInfo("K Bang", "49", 14.14453, 108.59908);
case 529: return new CityInfo("Kông Chro", "49", 13.77532, 108.52558);
case 530: return new CityInfo("Ia Pa", "49", 13.53361, 108.45529);
case 531: return new CityInfo("A Yun Pa", "49", 13.40025, 108.43503);
case 532: return new CityInfo("Chư Sê", "49", 13.69153, 108.08023);
case 533: return new CityInfo("Chư Prông", "49", 13.75684, 107.88624);
case 534: return new CityInfo("Chư Ty", "49", 13.80507, 107.6961);
case 535: return new CityInfo("Ia Kha", "49", 13.96242, 107.84484);
case 536: return new CityInfo("Phú Hòa", "49", 14.10005, 107.96896);
case 537: return new CityInfo("Kon Dơng", "49", 14.03886, 108.25011);
case 538: return new CityInfo("Hai Riêng", "61", 12.97908, 108.89732);
case 539: return new CityInfo("Ea Súp", "88", 13.06616, 107.88546);
case 540: return new CityInfo("Ea Drăng", "88", 13.2045, 108.21029);
case 541: return new CityInfo("Krông Năng", "88", 12.9517, 108.34425);
case 542: return new CityInfo("Quảng Phú", "88", 12.81965, 108.07738);
case 543: return new CityInfo("Ea Kar", "88", 12.80816, 108.44901);
case 544: return new CityInfo("Krông Kmar", "88", 12.5045, 108.33288);
case 545: return new CityInfo("M’Đrăk", "88", 12.74624, 108.74281);
case 546: return new CityInfo("Khánh Vĩnh", "54", 12.28355, 108.9047);
case 547: return new CityInfo("Tô Hạp", "54", 12.00582, 108.94868);
case 548: return new CityInfo("Cam Lâm", "54", 12.05398, 109.16004);
case 549: return new CityInfo("Ea T’ling", "91", 12.58904, 107.89578);
case 550: return new CityInfo("Đắk Mâm", "91", 12.45789, 107.86246);
case 551: return new CityInfo("Đinh Văn", "23", 11.78624, 108.24282);
case 552: return new CityInfo("Thạnh Mỹ", "23", 11.76165, 108.49473);
case 553: return new CityInfo("Lộc Thắng", "23", 11.62836, 107.83508);
case 554: return new CityInfo("Đồng Nai", "23", 11.57981, 107.36518);
case 555: return new CityInfo("Đạ Tẻh", "23", 11.51148, 107.49092);
case 556: return new CityInfo("Bác Ái", "60", 11.84104, 108.90316);
case 557: return new CityInfo("Tân Sơn", "60", 11.77521, 108.7848);
case 558: return new CityInfo("Phước Dân", "60", 11.52696, 108.92996);
case 559: return new CityInfo("Khánh Hải", "60", 11.59105, 109.04052);
case 560: return new CityInfo("Chợ Lầu", "47", 11.22158, 108.50707);
case 561: return new CityInfo("Ma Lâm", "47", 11.07297, 108.12997);
case 562: return new CityInfo("Thuận Nam", "47", 10.85004, 107.87864);
case 563: return new CityInfo("Phú Quý", "47", 10.5166, 108.93292);
case 564: return new CityInfo("Tân Phú", "43", 11.27221, 107.43655);
case 565: return new CityInfo("Vĩnh An", "43", 11.08901, 107.03516);
case 566: return new CityInfo("Thống Nhất", "43", 10.95055, 107.14571);
case 567: return new CityInfo("Long Khánh", "43", 10.92655, 107.24783);
case 568: return new CityInfo("Tân Phú", "76", 11.45119, 106.86811);
case 569: return new CityInfo("Tân Châu", "33", 11.55202, 106.17245);
case 570: return new CityInfo("Tân Biên", "33", 11.54441, 106.01161);
case 571: return new CityInfo("Châu Thành", "33", 11.31167, 106.0295);
case 572: return new CityInfo("Hòa Thành", "33", 11.28696, 106.12936);
case 573: return new CityInfo("Gò Dầu", "33", 11.0885, 106.26346);
case 574: return new CityInfo("Dương Minh Châu", "33", 11.38414, 106.23078);
case 575: return new CityInfo("Tân Hưng", "24", 10.83476, 105.66135);
case 576: return new CityInfo("Vĩnh Hưng", "24", 10.89067, 105.78495);
case 577: return new CityInfo("Tân Thạnh", "24", 10.60666, 106.04714);
case 578: return new CityInfo("Thạnh Hóa", "24", 10.65744, 106.18081);
case 579: return new CityInfo("Đông Thành", "24", 10.89221, 106.30614);
case 580: return new CityInfo("Hậu Nghĩa", "24", 10.89434, 106.39695);
case 581: return new CityInfo("Mỹ Phước", "37", 10.47711, 106.19256);
case 582: return new CityInfo("Tân Hòa", "37", 10.31906, 106.71128);
case 583: return new CityInfo("Thứ Mười Một", "21", 9.61144, 104.9465);
case 584: return new CityInfo("Sa Rài", "09", 10.87016, 105.46583);
case 585: return new CityInfo("Long Hồ", "69", 10.19281, 106.01229);
case 586: return new CityInfo("Duyên Hải", "67", 9.63497, 106.49237);
case 587: return new CityInfo("Châu Thành", "03", 10.30122, 106.35701);
case 588: return new CityInfo("Vĩnh Thạnh", "87", 10.22263, 105.39841);
case 589: return new CityInfo("Nàng Mau", "93", 9.75129, 105.53448);
case 590: return new CityInfo("Ngã Bảy", "93", 9.81371, 105.82096);
case 591: return new CityInfo("Ngã Sáu", "93", 9.92303, 105.80542);
case 592: return new CityInfo("Một Ngàn", "93", 9.92402, 105.62964);
case 593: return new CityInfo("Cù Lao Dung", "65", 9.67314, 106.14874);
case 594: return new CityInfo("Châu Thành", "65", 9.7007, 105.90202);
case 595: return new CityInfo("Huỳnh Hữu Nghĩa", "65", 9.63537, 105.81165);
case 596: return new CityInfo("U Minh", "77", 9.41286, 104.97353);
case 597: return new CityInfo("Trần Văn Thời", "77", 9.07713, 104.97914);
case 598: return new CityInfo("Ngọc Hiển", "77", 8.65724, 105.06021);
case 599: return new CityInfo("Quận Hai", "20", 10.79156, 106.74948);
case 600: return new CityInfo("Quận Chín", "20", 10.8397, 106.77093);
case 601: return new CityInfo("Quận Bốn", "20", 10.76684, 106.70574);
case 602: return new CityInfo("Quận Sáu", "20", 10.7468, 106.64903);
case 603: return new CityInfo("Quận Năm", "20", 10.75567, 106.66745);
case 604: return new CityInfo("Quận Một", "20", 10.78069, 106.69944);
case 605: return new CityInfo("Quận Phú Nhuận", "20", 10.79475, 106.6763);
case 606: return new CityInfo("Quận Tân Phú", "20", 10.78379, 106.63704);
case 607: return new CityInfo("Quận Mười Một", "20", 10.76383, 106.64355);
case 608: return new CityInfo("Quận Mười", "20", 10.76823, 106.66632);
case 609: return new CityInfo("Quận Ba", "20", 10.77494, 106.68628);
case 610: return new CityInfo("Quận Bình Thạnh", "20", 10.80325, 106.69666);
case 611: return new CityInfo("Cát Cát", "90", 22.33052, 103.82485);
case 612: return new CityInfo("Hoàng Sa", "78", 16.66657, 112.72541);
default: return new CityInfo("Thị Trấn Tân Thành", "09", 10.25616, 105.5928);

                                    }                                        
                                }
                            
                        }
                    }
                