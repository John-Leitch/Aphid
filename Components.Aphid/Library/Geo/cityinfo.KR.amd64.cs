
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
                                    public const string Country = "KR";
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
                            
                                        var cur = (Math.Abs(36.10945 - lat) + Math.Abs(129.34517 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(36.35389 - lat) + Math.Abs(127.33667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99526 - lat) + Math.Abs(129.35162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18447 - lat) + Math.Abs(128.46821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82167 - lat) + Math.Abs(128.63083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27814 - lat) + Math.Abs(126.51181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.175 - lat) + Math.Abs(127.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41366 - lat) + Math.Abs(129.37 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9675 - lat) + Math.Abs(128.93083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88953 - lat) + Math.Abs(126.98778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10113 - lat) + Math.Abs(127.07727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29583 - lat) + Math.Abs(127.63389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67756 - lat) + Math.Abs(126.84272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6574 - lat) + Math.Abs(128.45514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.34199 - lat) + Math.Abs(129.03358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48972 - lat) + Math.Abs(127.49056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83311 - lat) + Math.Abs(127.06169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10583 - lat) + Math.Abs(127.98944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.35139 - lat) + Math.Abs(127.94528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84509 - lat) + Math.Abs(127.14752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99251 - lat) + Math.Abs(128.39785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53722 - lat) + Math.Abs(129.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7415 - lat) + Math.Abs(127.0474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20159 - lat) + Math.Abs(129.08477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07 - lat) + Math.Abs(127.13028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89444 - lat) + Math.Abs(126.62972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31889 - lat) + Math.Abs(126.98389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9714 - lat) + Math.Abs(126.4542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34913 - lat) + Math.Abs(127.38493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87028 - lat) + Math.Abs(128.59111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34931 - lat) + Math.Abs(126.59772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1759 - lat) + Math.Abs(128.9889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29111 - lat) + Math.Abs(127.00889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9505 - lat) + Math.Abs(127.48784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.566 - lat) + Math.Abs(126.9784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78167 - lat) + Math.Abs(126.45222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24083 - lat) + Math.Abs(128.2975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91556 - lat) + Math.Abs(127.13139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20701 - lat) + Math.Abs(128.59181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71871 - lat) + Math.Abs(126.23304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45361 - lat) + Math.Abs(127.43111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23734 - lat) + Math.Abs(127.72248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41528 - lat) + Math.Abs(128.16056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.72423 - lat) + Math.Abs(127.98521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44056 - lat) + Math.Abs(129.17083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37028 - lat) + Math.Abs(128.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27472 - lat) + Math.Abs(126.90906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10168 - lat) + Math.Abs(129.03004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49889 - lat) + Math.Abs(126.78306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72806 - lat) + Math.Abs(126.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84897 - lat) + Math.Abs(127.34052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02917 - lat) + Math.Abs(129.36481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84902 - lat) + Math.Abs(126.87533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14029 - lat) + Math.Abs(126.603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15222 - lat) + Math.Abs(127.07056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78361 - lat) + Math.Abs(127.00417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3012 - lat) + Math.Abs(127.568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37881 - lat) + Math.Abs(128.4676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20389 - lat) + Math.Abs(127.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41 - lat) + Math.Abs(127.38583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0292 - lat) + Math.Abs(126.7175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85944 - lat) + Math.Abs(126.785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.59458 - lat) + Math.Abs(128.19946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73528 - lat) + Math.Abs(128.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99014 - lat) + Math.Abs(126.47899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81282 - lat) + Math.Abs(126.39181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49333 - lat) + Math.Abs(128.74889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12725 - lat) + Math.Abs(126.83149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82333 - lat) + Math.Abs(128.73778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84278 - lat) + Math.Abs(129.21167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97528 - lat) + Math.Abs(127.58917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41 - lat) + Math.Abs(127.25722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15472 - lat) + Math.Abs(126.91556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67463 - lat) + Math.Abs(127.27065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.98994 - lat) + Math.Abs(129.55377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20944 - lat) + Math.Abs(127.46444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5986 - lat) + Math.Abs(127.1394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23472 - lat) + Math.Abs(128.57278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97861 - lat) + Math.Abs(126.71139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.10306 - lat) + Math.Abs(127.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1136 - lat) + Math.Abs(128.336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65639 - lat) + Math.Abs(126.835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97631 - lat) + Math.Abs(128.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45556 - lat) + Math.Abs(127.12472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85028 - lat) + Math.Abs(128.58861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81083 - lat) + Math.Abs(127.79472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43333 - lat) + Math.Abs(126.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80167 - lat) + Math.Abs(126.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23417 - lat) + Math.Abs(128.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12176 - lat) + Math.Abs(128.11981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24417 - lat) + Math.Abs(129.21389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83101 - lat) + Math.Abs(127.51059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75266 - lat) + Math.Abs(128.87239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74722 - lat) + Math.Abs(126.48556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80538 - lat) + Math.Abs(129.5011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.94389 - lat) + Math.Abs(126.95444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45646 - lat) + Math.Abs(126.70515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61306 - lat) + Math.Abs(127.27944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27917 - lat) + Math.Abs(127.4425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.69557 - lat) + Math.Abs(128.44608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06125 - lat) + Math.Abs(126.98746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.20682 - lat) + Math.Abs(126.8169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10705 - lat) + Math.Abs(127.70632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6009 - lat) + Math.Abs(126.665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.6918 - lat) + Math.Abs(127.8857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.91333 - lat) + Math.Abs(128.82 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97411 - lat) + Math.Abs(127.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.57111 - lat) + Math.Abs(126.59889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21712 - lat) + Math.Abs(127.9919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87472 - lat) + Math.Abs(127.73417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20917 - lat) + Math.Abs(127.2175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82194 - lat) + Math.Abs(127.14889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45156 - lat) + Math.Abs(126.80365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43351 - lat) + Math.Abs(129.057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34655 - lat) + Math.Abs(127.79366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7355 - lat) + Math.Abs(127.4174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02596 - lat) + Math.Abs(127.07021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.63722 - lat) + Math.Abs(127.48972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8065 - lat) + Math.Abs(127.1522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19278 - lat) + Math.Abs(128.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.30029 - lat) + Math.Abs(127.31719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85667 - lat) + Math.Abs(127.44333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.79167 - lat) + Math.Abs(127.42528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06132 - lat) + Math.Abs(126.20753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.50972 - lat) + Math.Abs(126.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.22806 - lat) + Math.Abs(128.68111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.64842 - lat) + Math.Abs(127.51523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29778 - lat) + Math.Abs(126.78444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23904 - lat) + Math.Abs(127.01792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68164 - lat) + Math.Abs(126.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31296 - lat) + Math.Abs(129.24244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3925 - lat) + Math.Abs(126.92694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01083 - lat) + Math.Abs(127.27028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32361 - lat) + Math.Abs(126.82194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56636 - lat) + Math.Abs(128.72275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.46444 - lat) + Math.Abs(126.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8825 - lat) + Math.Abs(128.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24613 - lat) + Math.Abs(127.61964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76062 - lat) + Math.Abs(127.66215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9414 - lat) + Math.Abs(127.69569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85258 - lat) + Math.Abs(126.48952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28401 - lat) + Math.Abs(126.42038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.39587 - lat) + Math.Abs(126.44531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12944 - lat) + Math.Abs(127.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54389 - lat) + Math.Abs(129.10694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.19797 - lat) + Math.Abs(129.33911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97046 - lat) + Math.Abs(129.41222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.264 - lat) + Math.Abs(129.23349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29167 - lat) + Math.Abs(127.50778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43861 - lat) + Math.Abs(127.13778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54 - lat) + Math.Abs(127.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.6525 - lat) + Math.Abs(127.3075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63667 - lat) + Math.Abs(127.21417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.40611 - lat) + Math.Abs(129.16861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58972 - lat) + Math.Abs(127.22028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24972 - lat) + Math.Abs(128.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80167 - lat) + Math.Abs(128.50083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47722 - lat) + Math.Abs(126.86639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83278 - lat) + Math.Abs(126.81694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8262 - lat) + Math.Abs(126.10863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.25333 - lat) + Math.Abs(126.56181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5445 - lat) + Math.Abs(126.9837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6309 - lat) + Math.Abs(127.33344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.58362 - lat) + Math.Abs(127.39679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56782 - lat) + Math.Abs(127.03012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12911 - lat) + Math.Abs(129.2636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2948 - lat) + Math.Abs(127.1409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35339 - lat) + Math.Abs(126.95233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3414 - lat) + Math.Abs(126.893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27549 - lat) + Math.Abs(126.88418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.44445 - lat) + Math.Abs(127.58033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33055 - lat) + Math.Abs(127.53366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.27887 - lat) + Math.Abs(127.52689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2844 - lat) + Math.Abs(127.6199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.39435 - lat) + Math.Abs(127.66031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3568 - lat) + Math.Abs(127.67282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.397 - lat) + Math.Abs(127.73201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3272 - lat) + Math.Abs(127.75978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1678 - lat) + Math.Abs(127.5274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43387 - lat) + Math.Abs(127.37587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2324 - lat) + Math.Abs(127.9083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2603 - lat) + Math.Abs(127.8285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.44874 - lat) + Math.Abs(127.90601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68185 - lat) + Math.Abs(127.68774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.55344 - lat) + Math.Abs(127.63557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53236 - lat) + Math.Abs(127.54372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53064 - lat) + Math.Abs(127.68155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61365 - lat) + Math.Abs(128.47165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54145 - lat) + Math.Abs(128.49506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7636 - lat) + Math.Abs(126.46577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77419 - lat) + Math.Abs(126.41226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79872 - lat) + Math.Abs(126.408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70306 - lat) + Math.Abs(126.32136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71223 - lat) + Math.Abs(126.48439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71646 - lat) + Math.Abs(126.55429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71953 - lat) + Math.Abs(126.63107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69191 - lat) + Math.Abs(126.59855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78272 - lat) + Math.Abs(126.28117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78055 - lat) + Math.Abs(126.85004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71727 - lat) + Math.Abs(126.94122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8024 - lat) + Math.Abs(126.71598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82566 - lat) + Math.Abs(126.98349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70353 - lat) + Math.Abs(127.3258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81735 - lat) + Math.Abs(127.71656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84747 - lat) + Math.Abs(127.76164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7119 - lat) + Math.Abs(128.18713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72722 - lat) + Math.Abs(127.18992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69834 - lat) + Math.Abs(127.20579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.28634 - lat) + Math.Abs(128.13774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25679 - lat) + Math.Abs(128.55968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18561 - lat) + Math.Abs(127.10819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15921 - lat) + Math.Abs(127.24935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2088 - lat) + Math.Abs(127.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20135 - lat) + Math.Abs(128.04327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94036 - lat) + Math.Abs(128.71665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.59245 - lat) + Math.Abs(127.29223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50533 - lat) + Math.Abs(126.72202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77148 - lat) + Math.Abs(127.07996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.60004 - lat) + Math.Abs(126.91699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70846 - lat) + Math.Abs(127.6134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77247 - lat) + Math.Abs(127.88668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7128 - lat) + Math.Abs(128.04605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78566 - lat) + Math.Abs(126.14288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86689 - lat) + Math.Abs(126.31279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83394 - lat) + Math.Abs(126.35133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.90444 - lat) + Math.Abs(126.65175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84601 - lat) + Math.Abs(126.64367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81951 - lat) + Math.Abs(126.69688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92007 - lat) + Math.Abs(126.7494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86348 - lat) + Math.Abs(126.74895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86886 - lat) + Math.Abs(126.60706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80059 - lat) + Math.Abs(126.69669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72899 - lat) + Math.Abs(128.95419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78006 - lat) + Math.Abs(127.33384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91406 - lat) + Math.Abs(127.53764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87479 - lat) + Math.Abs(127.45159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88231 - lat) + Math.Abs(127.57861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79346 - lat) + Math.Abs(127.63243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71904 - lat) + Math.Abs(128.8799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80247 - lat) + Math.Abs(126.83899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87676 - lat) + Math.Abs(126.97029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92966 - lat) + Math.Abs(127.17236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80915 - lat) + Math.Abs(127.24754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9142 - lat) + Math.Abs(127.27727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87102 - lat) + Math.Abs(127.18702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9903 - lat) + Math.Abs(127.69875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9791 - lat) + Math.Abs(127.75807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96449 - lat) + Math.Abs(127.79025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08337 - lat) + Math.Abs(127.77696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02117 - lat) + Math.Abs(127.71976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0117 - lat) + Math.Abs(127.58128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01766 - lat) + Math.Abs(127.61925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93944 - lat) + Math.Abs(127.45523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01532 - lat) + Math.Abs(127.3897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07733 - lat) + Math.Abs(127.23496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97504 - lat) + Math.Abs(127.26377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03069 - lat) + Math.Abs(127.03837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00782 - lat) + Math.Abs(127.09621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79802 - lat) + Math.Abs(127.07073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80134 - lat) + Math.Abs(127.08749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89322 - lat) + Math.Abs(127.13128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82987 - lat) + Math.Abs(127.15181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.068 - lat) + Math.Abs(127.75147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11073 - lat) + Math.Abs(126.29458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.21831 - lat) + Math.Abs(126.37194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18122 - lat) + Math.Abs(126.60102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11447 - lat) + Math.Abs(126.60908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20946 - lat) + Math.Abs(126.50768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20248 - lat) + Math.Abs(126.13757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08457 - lat) + Math.Abs(126.11105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.44487 - lat) + Math.Abs(126.49517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.52448 - lat) + Math.Abs(126.55107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.46144 - lat) + Math.Abs(126.53914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24032 - lat) + Math.Abs(126.4528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25851 - lat) + Math.Abs(126.47516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3627 - lat) + Math.Abs(126.4462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37825 - lat) + Math.Abs(126.51141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.34168 - lat) + Math.Abs(126.60327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25755 - lat) + Math.Abs(126.54315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30183 - lat) + Math.Abs(126.57748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50202 - lat) + Math.Abs(127.00283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41261 - lat) + Math.Abs(127.14135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.4536 - lat) + Math.Abs(127.10232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53034 - lat) + Math.Abs(127.16357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.44168 - lat) + Math.Abs(127.24264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53497 - lat) + Math.Abs(126.87661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.60319 - lat) + Math.Abs(126.99342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Heunghae", "14", 36.10945, 129.34517);
case 1: return new CityInfo("Yuseong", "19", 36.35389, 127.33667);
case 2: return new CityInfo("Yeonil", "14", 35.99526, 129.35162);
case 3: return new CityInfo("Neietsu", "06", 37.18447, 128.46821);
case 4: return new CityInfo("Eisen", "14", 36.82167, 128.63083);
case 5: return new CityInfo("Yeonggwang", "16", 35.27814, 126.51181);
case 6: return new CityInfo("Yeongdong", "05", 36.175, 127.77639);
case 7: return new CityInfo("Yeongdeok", "14", 36.41366, 129.37);
case 8: return new CityInfo("Eisen", "14", 35.9675, 128.93083);
case 9: return new CityInfo("Iyang", "16", 34.88953, 126.98778);
case 10: return new CityInfo("Yeoncheon", "13", 38.10113, 127.07727);
case 11: return new CityInfo("Yeoju", "13", 37.29583, 127.63389);
case 12: return new CityInfo("Yesan", "17", 36.67756, 126.84272);
case 13: return new CityInfo("Yecheon", "14", 36.6574, 128.45514);
case 14: return new CityInfo("Yangsan", "20", 35.34199, 129.03358);
case 15: return new CityInfo("Yangp'yŏng", "13", 37.48972, 127.49056);
case 16: return new CityInfo("Yangju", "13", 37.83311, 127.06169);
case 17: return new CityInfo("Yanggu", "06", 38.10583, 127.98944);
case 18: return new CityInfo("Wŏnju", "06", 37.35139, 127.94528);
case 19: return new CityInfo("Wanju", "03", 35.84509, 127.14752);
case 20: return new CityInfo("Waegwan", "14", 35.99251, 128.39785);
case 21: return new CityInfo("Ulsan", "21", 35.53722, 129.31667);
case 22: return new CityInfo("Uijeongbu-si", "13", 37.7415, 127.0474);
case 23: return new CityInfo("Dongnae", "10", 35.20159, 129.08477);
case 24: return new CityInfo("Dongbok", "16", 35.07, 127.13028);
case 25: return new CityInfo("Tangjin", "17", 36.89444, 126.62972);
case 26: return new CityInfo("Damyang", "16", 35.31889, 126.98389);
case 27: return new CityInfo("Taesal-li", "17", 36.9714, 126.4542);
case 28: return new CityInfo("Daejeon", "19", 36.34913, 127.38493);
case 29: return new CityInfo("Daegu", "15", 35.87028, 128.59111);
case 30: return new CityInfo("Boryeong", "17", 36.34931, 126.59772);
case 31: return new CityInfo("T’aebaek", "06", 37.1759, 128.9889);
case 32: return new CityInfo("Suwon", "13", 37.29111, 127.00889);
case 33: return new CityInfo("Suncheon", "16", 34.9505, 127.48784);
case 34: return new CityInfo("Seoul", "11", 37.566, 126.9784);
case 35: return new CityInfo("Seosan", "17", 36.78167, 126.45222);
case 36: return new CityInfo("Jenzan", "14", 36.24083, 128.2975);
case 37: return new CityInfo("Seonghwan", "17", 36.91556, 127.13139);
case 38: return new CityInfo("Sokcho", "06", 38.20701, 128.59181);
case 39: return new CityInfo("Seogeom-ri", "12", 37.71871, 126.23304);
case 40: return new CityInfo("Sintansin", "19", 36.45361, 127.43111);
case 41: return new CityInfo("Simcheon", "05", 36.23734, 127.72248);
case 42: return new CityInfo("Sangju", "14", 36.41528, 128.16056);
case 43: return new CityInfo("Sangju", "20", 34.72423, 127.98521);
case 44: return new CityInfo("Santyoku", "06", 37.44056, 129.17083);
case 45: return new CityInfo("Pyeongchang", "06", 37.37028, 128.39306);
case 46: return new CityInfo("Buyeo", "17", 36.27472, 126.90906);
case 47: return new CityInfo("Busan", "10", 35.10168, 129.03004);
case 48: return new CityInfo("Bucheon-si", "13", 37.49889, 126.78306);
case 49: return new CityInfo("Puan", "03", 35.72806, 126.73194);
case 50: return new CityInfo("Beolgyo", "16", 34.84897, 127.34052);
case 51: return new CityInfo("Pohang", "14", 36.02917, 129.36481);
case 52: return new CityInfo("Beobwon", "13", 37.84902, 126.87533);
case 53: return new CityInfo("Biin", "17", 36.14029, 126.603);
case 54: return new CityInfo("Osan", "13", 37.15222, 127.07056);
case 55: return new CityInfo("Asan", "17", 36.78361, 127.00417);
case 56: return new CityInfo("Okcheon", "05", 36.3012, 127.568);
case 57: return new CityInfo("Kosong", "06", 38.37881, 128.4676);
case 58: return new CityInfo("Nonsan", "17", 36.20389, 127.08472);
case 59: return new CityInfo("Nangen", "03", 35.41, 127.38583);
case 60: return new CityInfo("Naju", "16", 35.0292, 126.7175);
case 61: return new CityInfo("Munsan", "13", 37.85944, 126.785);
case 62: return new CityInfo("Mungyeong", "14", 36.59458, 128.19946);
case 63: return new CityInfo("Mungyeong", "14", 36.73528, 128.10833);
case 64: return new CityInfo("Muan", "16", 34.99014, 126.47899);
case 65: return new CityInfo("Mokpo", "16", 34.81282, 126.39181);
case 66: return new CityInfo("Miryang", "20", 35.49333, 128.74889);
case 67: return new CityInfo("Masan", "18", 35.12725, 126.83149);
case 68: return new CityInfo("Gyeongsan-si", "14", 35.82333, 128.73778);
case 69: return new CityInfo("Gyeongju", "14", 35.84278, 129.21167);
case 70: return new CityInfo("Kwangyang", "16", 34.97528, 127.58917);
case 71: return new CityInfo("Gwangju", "13", 37.41, 127.25722);
case 72: return new CityInfo("Gwangju", "18", 35.15472, 126.91556);
case 73: return new CityInfo("Gwanchon", "03", 35.67463, 127.27065);
case 74: return new CityInfo("Guryongpo", "14", 35.98994, 129.55377);
case 75: return new CityInfo("Kurye", "16", 35.20944, 127.46444);
case 76: return new CityInfo("Guri-si", "13", 37.5986, 127.1394);
case 77: return new CityInfo("Kunwi", "14", 36.23472, 128.57278);
case 78: return new CityInfo("Gunsan", "03", 35.97861, 126.71139);
case 79: return new CityInfo("Kinzan", "17", 36.10306, 127.48889);
case 80: return new CityInfo("Gumi", "14", 36.1136, 128.336);
case 81: return new CityInfo("Goyang-si", "13", 37.65639, 126.835);
case 82: return new CityInfo("Goseong", "20", 34.97631, 128.32361);
case 83: return new CityInfo("Gongju", "17", 36.45556, 127.12472);
case 84: return new CityInfo("Kyosai", "20", 34.85028, 128.58861);
case 85: return new CityInfo("Koesan", "05", 36.81083, 127.79472);
case 86: return new CityInfo("Koch'ang", "03", 35.43333, 126.7);
case 87: return new CityInfo("Kimje", "03", 35.80167, 126.88889);
case 88: return new CityInfo("Kimhae", "20", 35.23417, 128.88111);
case 89: return new CityInfo("Gimcheon", "14", 36.12176, 128.11981);
case 90: return new CityInfo("Gijang", "10", 35.24417, 129.21389);
case 91: return new CityInfo("Gapyeong", "13", 37.83101, 127.51059);
case 92: return new CityInfo("Gangneung", "06", 37.75266, 128.87239);
case 93: return new CityInfo("Ganghwa-gun", "12", 37.74722, 126.48556);
case 94: return new CityInfo("Gampo", "14", 35.80538, 129.5011);
case 95: return new CityInfo("Iksan", "03", 35.94389, 126.95444);
case 96: return new CityInfo("Incheon", "12", 37.45646, 126.70515);
case 97: return new CityInfo("Imsil", "03", 35.61306, 127.27944);
case 98: return new CityInfo("Icheon-si", "13", 37.27917, 127.4425);
case 99: return new CityInfo("Hyeonpung", "15", 35.69557, 128.44608);
case 100: return new CityInfo("Hwasun", "16", 35.06125, 126.98746);
case 101: return new CityInfo("Hwaseong-si", "13", 37.20682, 126.8169);
case 102: return new CityInfo("Hwacheon", "06", 38.10705, 127.70632);
case 103: return new CityInfo("Hongseong", "17", 36.6009, 126.665);
case 104: return new CityInfo("Hongch’ŏn", "06", 37.6918, 127.8857);
case 105: return new CityInfo("Hayang", "14", 35.91333, 128.82);
case 106: return new CityInfo("Hancheolli", "16", 34.97411, 127.00028);
case 107: return new CityInfo("Haenam", "16", 34.57111, 126.59889);
case 108: return new CityInfo("Chupungnyeong", "05", 36.21712, 127.9919);
case 109: return new CityInfo("Chuncheon", "06", 37.87472, 127.73417);
case 110: return new CityInfo("Cheorwon", "06", 38.20917, 127.2175);
case 111: return new CityInfo("Jeonju", "03", 35.82194, 127.14889);
case 112: return new CityInfo("Cheongyang", "17", 36.45156, 126.80365);
case 113: return new CityInfo("Cheongsong gun", "14", 36.43351, 129.057);
case 114: return new CityInfo("Cheongsan", "05", 36.34655, 127.79366);
case 115: return new CityInfo("Cheongpyeong", "13", 37.7355, 127.4174);
case 116: return new CityInfo("Jeongok", "13", 38.02596, 127.07021);
case 117: return new CityInfo("Cheongju-si", "05", 36.63722, 127.48972);
case 118: return new CityInfo("Cheonan", "17", 36.8065, 127.1522);
case 119: return new CityInfo("Chinju", "20", 35.19278, 128.08472);
case 120: return new CityInfo("Jinjam", "19", 36.30029, 127.31719);
case 121: return new CityInfo("Chinch'ŏn", "05", 36.85667, 127.44333);
case 122: return new CityInfo("Jinan-gun", "03", 35.79167, 127.42528);
case 123: return new CityInfo("Jido", "16", 35.06132, 126.20753);
case 124: return new CityInfo("Jeju City", "01", 33.50972, 126.52194);
case 125: return new CityInfo("Changwon", "20", 35.22806, 128.68111);
case 126: return new CityInfo("Changsu", "03", 35.64842, 127.51523);
case 127: return new CityInfo("Jangseong", "16", 35.29778, 126.78444);
case 128: return new CityInfo("Changpyeong", "16", 35.23904, 127.01792);
case 129: return new CityInfo("Jangheung", "16", 34.68164, 126.90694);
case 130: return new CityInfo("Jangan", "10", 35.31296, 129.24244);
case 131: return new CityInfo("Anyang-si", "13", 37.3925, 126.92694);
case 132: return new CityInfo("Anseong", "13", 37.01083, 127.27028);
case 133: return new CityInfo("Ansan-si", "13", 37.32361, 126.82194);
case 134: return new CityInfo("Andong", "14", 36.56636, 128.72275);
case 135: return new CityInfo("Gaigeturi", "01", 33.46444, 126.31833);
case 136: return new CityInfo("Sinhyeon", "20", 34.8825, 128.62667);
case 137: return new CityInfo("Iwon", "05", 36.24613, 127.61964);
case 138: return new CityInfo("Yeosu", "16", 34.76062, 127.66215);
case 139: return new CityInfo("Gwangyang", "16", 34.9414, 127.69569);
case 140: return new CityInfo("Illo", "16", 34.85258, 126.48952);
case 141: return new CityInfo("Baeksu", "16", 35.28401, 126.42038);
case 142: return new CityInfo("Hongnong", "16", 35.39587, 126.44531);
case 143: return new CityInfo("Yŏnmu", "17", 36.12944, 127.1);
case 144: return new CityInfo("Tonghae", "06", 37.54389, 129.10694);
case 145: return new CityInfo("Cheongha", "14", 36.19797, 129.33911);
case 146: return new CityInfo("Ocheon", "14", 35.97046, 129.41222);
case 147: return new CityInfo("Ilgwang", "10", 35.264, 129.23349);
case 148: return new CityInfo("Pubal", "13", 37.29167, 127.50778);
case 149: return new CityInfo("Seongnam-si", "13", 37.43861, 127.13778);
case 150: return new CityInfo("Hanam", "13", 37.54, 127.20556);
case 151: return new CityInfo("Hwado", "13", 37.6525, 127.3075);
case 152: return new CityInfo("Namyangju", "13", 37.63667, 127.21417);
case 153: return new CityInfo("Ungsang", "20", 35.40611, 129.16861);
case 154: return new CityInfo("Wabu", "13", 37.58972, 127.22028);
case 155: return new CityInfo("Naesŏ", "20", 35.24972, 128.52);
case 156: return new CityInfo("Hwawŏn", "15", 35.80167, 128.50083);
case 157: return new CityInfo("Kwangmyŏng", "13", 37.47722, 126.86639);
case 158: return new CityInfo("Paju", "13", 37.83278, 126.81694);
case 159: return new CityInfo("Sinan", "16", 34.8262, 126.10863);
case 160: return new CityInfo("Seogwipo", "01", 33.25333, 126.56181);
case 161: return new CityInfo("Yongsan-dong", "11", 37.5445, 126.9837);
case 162: return new CityInfo("Seongsu", "03", 35.6309, 127.33344);
case 163: return new CityInfo("Sanseo", "03", 35.58362, 127.39679);
case 164: return new CityInfo("Sannae", "03", 35.56782, 127.03012);
case 165: return new CityInfo("Singwang", "14", 36.12911, 129.2636);
case 166: return new CityInfo("Sangwol", "17", 36.2948, 127.1409);
case 167: return new CityInfo("Cheongnam", "17", 36.35339, 126.95233);
case 168: return new CityInfo("Jangpyeong", "17", 36.3414, 126.893);
case 169: return new CityInfo("Gyuam", "17", 36.27549, 126.88418);
case 170: return new CityInfo("Hoenam", "05", 36.44445, 127.58033);
case 171: return new CityInfo("Gunbuk", "05", 36.33055, 127.53366);
case 172: return new CityInfo("Gunseo", "05", 36.27887, 127.52689);
case 173: return new CityInfo("Dongi", "05", 36.2844, 127.6199);
case 174: return new CityInfo("Annae", "05", 36.39435, 127.66031);
case 175: return new CityInfo("Annam", "05", 36.3568, 127.67282);
case 176: return new CityInfo("Samseung", "05", 36.397, 127.73201);
case 177: return new CityInfo("Cheongseong", "05", 36.3272, 127.75978);
case 178: return new CityInfo("Gunbuk", "17", 36.1678, 127.5274);
case 179: return new CityInfo("Songgangdong", "19", 36.43387, 127.37587);
case 180: return new CityInfo("Hwanggan", "05", 36.2324, 127.9083);
case 181: return new CityInfo("Yongsan", "05", 36.2603, 127.8285);
case 182: return new CityInfo("Hwanam", "14", 36.44874, 127.90601);
case 183: return new CityInfo("Seosang", "20", 35.68185, 127.68774);
case 184: return new CityInfo("Baekjeon", "20", 35.55344, 127.63557);
case 185: return new CityInfo("Beonam", "03", 35.53236, 127.54372);
case 186: return new CityInfo("Byeonggok", "20", 35.53064, 127.68155);
case 187: return new CityInfo("Daehap", "20", 35.61365, 128.47165);
case 188: return new CityInfo("Changnyeong", "20", 35.54145, 128.49506);
case 189: return new CityInfo("Songhae", "13", 37.7636, 126.46577);
case 190: return new CityInfo("Hajeom", "12", 37.77419, 126.41226);
case 191: return new CityInfo("Yangsa", "12", 37.79872, 126.408);
case 192: return new CityInfo("Samsan", "12", 37.70306, 126.32136);
case 193: return new CityInfo("Seonwon", "12", 37.71223, 126.48439);
case 194: return new CityInfo("Wolgot", "13", 37.71646, 126.55429);
case 195: return new CityInfo("Haseong", "13", 37.71953, 126.63107);
case 196: return new CityInfo("Tongjin", "13", 37.69191, 126.59855);
case 197: return new CityInfo("Gyodong", "12", 37.78272, 126.28117);
case 198: return new CityInfo("Gwangtan", "13", 37.78055, 126.85004);
case 199: return new CityInfo("Jangheung", "13", 37.71727, 126.94122);
case 200: return new CityInfo("Tanhyeon", "13", 37.8024, 126.71598);
case 201: return new CityInfo("Gwangjeok", "13", 37.82566, 126.98349);
case 202: return new CityInfo("Su-dong", "13", 37.70353, 127.3258);
case 203: return new CityInfo("Sindong", "06", 37.81735, 127.71656);
case 204: return new CityInfo("Dongnae", "06", 37.84747, 127.76164);
case 205: return new CityInfo("Seoseok", "06", 37.7119, 128.18713);
case 206: return new CityInfo("Jinjeop", "13", 37.72722, 127.18992);
case 207: return new CityInfo("Onam", "13", 37.69834, 127.20579);
case 208: return new CityInfo("Haean", "06", 38.28634, 128.13774);
case 209: return new CityInfo("Toseong", "06", 38.25679, 128.55968);
case 210: return new CityInfo("Sinseo", "13", 38.18561, 127.10819);
case 211: return new CityInfo("Gwanin", "06", 38.15921, 127.24935);
case 212: return new CityInfo("Bangsan", "06", 38.2088, 127.95028);
case 213: return new CityInfo("Dongmyeon", "06", 38.20135, 128.04327);
case 214: return new CityInfo("Oepo", "20", 34.94036, 128.71665);
case 215: return new CityInfo("Sejong", "22", 36.59245, 127.29223);
case 216: return new CityInfo("Bupyeong", "12", 37.50533, 126.72202);
case 217: return new CityInfo("Boseong", "16", 34.77148, 127.07996);
case 218: return new CityInfo("Jeongeup", "03", 35.60004, 126.91699);
case 219: return new CityInfo("Hwayang", "16", 34.70846, 127.6134);
case 220: return new CityInfo("Nammyeon", "20", 34.77247, 127.88668);
case 221: return new CityInfo("Mijo", "20", 34.7128, 128.04605);
case 222: return new CityInfo("Palgeum", "16", 34.78566, 126.14288);
case 223: return new CityInfo("Apae", "16", 34.86689, 126.31279);
case 224: return new CityInfo("Sinan", "16", 34.83394, 126.35133);
case 225: return new CityInfo("Bannam", "16", 34.90444, 126.65175);
case 226: return new CityInfo("Dopo", "16", 34.84601, 126.64367);
case 227: return new CityInfo("Deokjin", "16", 34.81951, 126.69688);
case 228: return new CityInfo("Seji", "16", 34.92007, 126.7494);
case 229: return new CityInfo("Geumjeong", "16", 34.86348, 126.74895);
case 230: return new CityInfo("Sijong", "16", 34.86886, 126.60706);
case 231: return new CityInfo("Yeongam", "16", 34.80059, 126.69669);
case 232: return new CityInfo("Gangdong", "06", 37.72899, 128.95419);
case 233: return new CityInfo("Donggang", "16", 34.78006, 127.33384);
case 234: return new CityInfo("Haeryong", "16", 34.91406, 127.53764);
case 235: return new CityInfo("Byeollyang", "16", 34.87479, 127.45159);
case 236: return new CityInfo("Yulchon", "16", 34.88231, 127.57861);
case 237: return new CityInfo("Sora", "16", 34.79346, 127.63243);
case 238: return new CityInfo("Gujeong", "06", 37.71904, 128.8799);
case 239: return new CityInfo("Yuchi", "16", 34.80247, 126.83899);
case 240: return new CityInfo("Cheongpung", "16", 34.87676, 126.97029);
case 241: return new CityInfo("Mundeok", "16", 34.92966, 127.17236);
case 242: return new CityInfo("Joseong", "16", 34.80915, 127.24754);
case 243: return new CityInfo("Oeseo", "16", 34.9142, 127.27727);
case 244: return new CityInfo("Yureo", "16", 34.87102, 127.18702);
case 245: return new CityInfo("Okgok", "16", 34.9903, 127.69875);
case 246: return new CityInfo("Jinwol", "16", 34.9791, 127.75807);
case 247: return new CityInfo("Geumseong", "20", 34.96449, 127.79025);
case 248: return new CityInfo("Jeongnyang", "20", 35.08337, 127.77696);
case 249: return new CityInfo("Jinsang", "16", 35.02117, 127.71976);
case 250: return new CityInfo("Bonggang", "16", 35.0117, 127.58128);
case 251: return new CityInfo("Ongnyong", "16", 35.01766, 127.61925);
case 252: return new CityInfo("Sangsa", "16", 34.93944, 127.45523);
case 253: return new CityInfo("Seungju", "16", 35.01532, 127.3897);
case 254: return new CityInfo("Juam", "16", 35.07733, 127.23496);
case 255: return new CityInfo("Songgwang", "16", 34.97504, 127.26377);
case 256: return new CityInfo("Dongmyeon", "16", 35.03069, 127.03837);
case 257: return new CityInfo("Nammyeon", "16", 35.00782, 127.09621);
case 258: return new CityInfo("Nodong", "16", 34.79802, 127.07073);
case 259: return new CityInfo("Miryeok", "16", 34.80134, 127.08749);
case 260: return new CityInfo("Bongnae", "16", 34.89322, 127.13128);
case 261: return new CityInfo("Gyeombaek", "16", 34.82987, 127.15181);
case 262: return new CityInfo("Hadong", "20", 35.068, 127.75147);
case 263: return new CityInfo("Haeje", "16", 35.11073, 126.29458);
case 264: return new CityInfo("Yeomsan", "16", 35.21831, 126.37194);
case 265: return new CityInfo("Haebo", "16", 35.18122, 126.60102);
case 266: return new CityInfo("Nasan", "16", 35.11447, 126.60908);
case 267: return new CityInfo("Bulgap", "16", 35.20946, 126.50768);
case 268: return new CityInfo("Nagwol", "16", 35.20248, 126.13757);
case 269: return new CityInfo("Imja", "16", 35.08457, 126.11105);
case 270: return new CityInfo("Sangha", "03", 35.44487, 126.49517);
case 271: return new CityInfo("Simwon", "03", 35.52448, 126.55107);
case 272: return new CityInfo("Haeri", "03", 35.46144, 126.53914);
case 273: return new CityInfo("Gunnam", "16", 35.24032, 126.4528);
case 274: return new CityInfo("Gunseo", "16", 35.25851, 126.47516);
case 275: return new CityInfo("Beopseong", "16", 35.3627, 126.4462);
case 276: return new CityInfo("Gongeum", "03", 35.37825, 126.51141);
case 277: return new CityInfo("Daesan", "03", 35.34168, 126.60327);
case 278: return new CityInfo("Myoryang", "16", 35.25755, 126.54315);
case 279: return new CityInfo("Daema", "16", 35.30183, 126.57748);
case 280: return new CityInfo("Ssangchi", "03", 35.50202, 127.00283);
case 281: return new CityInfo("Ingye", "03", 35.41261, 127.14135);
case 282: return new CityInfo("Gurim", "03", 35.4536, 127.10232);
case 283: return new CityInfo("Gangjin", "03", 35.53034, 127.16357);
case 284: return new CityInfo("Donggye", "03", 35.44168, 127.24264);
case 285: return new CityInfo("Paripark", "11", 37.53497, 126.87661);
default: return new CityInfo("Chilbo", "03", 35.60319, 126.99342);

                                    }                                        
                                }
                            
                        }
                    }
                