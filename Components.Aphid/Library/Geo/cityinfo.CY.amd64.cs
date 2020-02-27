
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
                                    public const string Country = "CY";
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
                            
                                        var cur = (Math.Abs(35.0125 - lat) + Math.Abs(34.05833 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(34.72887 - lat) + Math.Abs(33.33779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68797 - lat) + Math.Abs(32.96191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92416 - lat) + Math.Abs(32.47469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75581 - lat) + Math.Abs(32.44915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1056 - lat) + Math.Abs(33.41977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01627 - lat) + Math.Abs(33.7435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97743 - lat) + Math.Abs(33.84894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07307 - lat) + Math.Abs(33.32344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98138 - lat) + Math.Abs(33.65648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83862 - lat) + Math.Abs(32.47499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03263 - lat) + Math.Abs(33.61551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28628 - lat) + Math.Abs(33.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73177 - lat) + Math.Abs(32.51613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85408 - lat) + Math.Abs(33.54739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83632 - lat) + Math.Abs(32.43097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88784 - lat) + Math.Abs(32.48134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71189 - lat) + Math.Abs(32.8634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95523 - lat) + Math.Abs(33.38997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.59719 - lat) + Math.Abs(34.37916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74167 - lat) + Math.Abs(33.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00469 - lat) + Math.Abs(33.68907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0625 - lat) + Math.Abs(33.2625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94478 - lat) + Math.Abs(33.46072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10439 - lat) + Math.Abs(33.02982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16037 - lat) + Math.Abs(32.54574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03403 - lat) + Math.Abs(32.4255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88613 - lat) + Math.Abs(32.50712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66942 - lat) + Math.Abs(32.70132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04121 - lat) + Math.Abs(33.92242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88385 - lat) + Math.Abs(32.38188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82894 - lat) + Math.Abs(33.58272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12928 - lat) + Math.Abs(33.07858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04167 - lat) + Math.Abs(33.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0335 - lat) + Math.Abs(33.25413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89597 - lat) + Math.Abs(32.96817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74583 - lat) + Math.Abs(33.15833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03945 - lat) + Math.Abs(33.98181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77679 - lat) + Math.Abs(32.42451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70559 - lat) + Math.Abs(32.99269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91954 - lat) + Math.Abs(32.63155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81667 - lat) + Math.Abs(33.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75743 - lat) + Math.Abs(32.85725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07778 - lat) + Math.Abs(33.26584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74504 - lat) + Math.Abs(33.00578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77874 - lat) + Math.Abs(32.79355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10123 - lat) + Math.Abs(33.09357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17531 - lat) + Math.Abs(33.3642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.72022 - lat) + Math.Abs(33.10066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95322 - lat) + Math.Abs(33.42518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19869 - lat) + Math.Abs(32.99338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04267 - lat) + Math.Abs(33.12401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81529 - lat) + Math.Abs(32.45627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80888 - lat) + Math.Abs(32.46196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86075 - lat) + Math.Abs(33.59314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98816 - lat) + Math.Abs(32.50665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80364 - lat) + Math.Abs(33.48947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96349 - lat) + Math.Abs(33.33627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75735 - lat) + Math.Abs(33.35657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17604 - lat) + Math.Abs(33.20435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95105 - lat) + Math.Abs(33.29777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99889 - lat) + Math.Abs(33.46175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95515 - lat) + Math.Abs(33.62734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00885 - lat) + Math.Abs(33.89256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68406 - lat) + Math.Abs(33.03794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.46892 - lat) + Math.Abs(34.13886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80863 - lat) + Math.Abs(32.4079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2598 - lat) + Math.Abs(33.73189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11199 - lat) + Math.Abs(32.84997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92291 - lat) + Math.Abs(33.6233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33823 - lat) + Math.Abs(33.17368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33634 - lat) + Math.Abs(33.31729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93815 - lat) + Math.Abs(32.97551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70987 - lat) + Math.Abs(32.57331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92221 - lat) + Math.Abs(33.39587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04108 - lat) + Math.Abs(32.88737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82427 - lat) + Math.Abs(33.39133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78516 - lat) + Math.Abs(32.459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66865 - lat) + Math.Abs(32.93375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74858 - lat) + Math.Abs(32.46565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15303 - lat) + Math.Abs(33.19966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02004 - lat) + Math.Abs(33.17806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84898 - lat) + Math.Abs(33.57523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82279 - lat) + Math.Abs(32.40131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79836 - lat) + Math.Abs(32.40653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79747 - lat) + Math.Abs(33.33519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17897 - lat) + Math.Abs(32.686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08489 - lat) + Math.Abs(33.27558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7584 - lat) + Math.Abs(33.30798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98768 - lat) + Math.Abs(32.90468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99699 - lat) + Math.Abs(32.8993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12489 - lat) + Math.Abs(33.94135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04136 - lat) + Math.Abs(32.90229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.69406 - lat) + Math.Abs(32.76263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67766 - lat) + Math.Abs(32.91815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04259 - lat) + Math.Abs(33.24578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.807 - lat) + Math.Abs(32.42406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87551 - lat) + Math.Abs(33.58684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06484 - lat) + Math.Abs(33.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02294 - lat) + Math.Abs(33.42195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.72606 - lat) + Math.Abs(33.13872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98213 - lat) + Math.Abs(34.00183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03615 - lat) + Math.Abs(33.83918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05515 - lat) + Math.Abs(33.78388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06183 - lat) + Math.Abs(33.54166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14096 - lat) + Math.Abs(33.03793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05365 - lat) + Math.Abs(33.24292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06586 - lat) + Math.Abs(32.49226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94779 - lat) + Math.Abs(33.58813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04844 - lat) + Math.Abs(33.1961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74057 - lat) + Math.Abs(32.53375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82435 - lat) + Math.Abs(33.46357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86099 - lat) + Math.Abs(33.4943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98898 - lat) + Math.Abs(33.39887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10022 - lat) + Math.Abs(33.86155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13341 - lat) + Math.Abs(33.12873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91784 - lat) + Math.Abs(33.01811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10945 - lat) + Math.Abs(33.14474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76091 - lat) + Math.Abs(32.44844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8343 - lat) + Math.Abs(32.45363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Protaras", "01", 35.0125, 34.05833);
case 1: return new CityInfo("Zýgi", "03", 34.72887, 33.33779);
case 2: return new CityInfo("Ýpsonas", "05", 34.68797, 32.96191);
case 3: return new CityInfo("Giólou", "06", 34.92416, 32.47469);
case 4: return new CityInfo("Geroskípou (quarter)", "06", 34.75581, 32.44915);
case 5: return new CityInfo("Géri", "04", 35.1056, 33.41977);
case 6: return new CityInfo("Xylotymbou", "03", 35.01627, 33.7435);
case 7: return new CityInfo("Xylofágou", "03", 34.97743, 33.84894);
case 8: return new CityInfo("Tséri", "04", 35.07307, 33.32344);
case 9: return new CityInfo("Voróklini", "03", 34.98138, 33.65648);
case 10: return new CityInfo("Tsáda", "06", 34.83862, 32.47499);
case 11: return new CityInfo("Troúlloi", "03", 35.03263, 33.61551);
case 12: return new CityInfo("Tríkomo", "01", 35.28628, 33.89167);
case 13: return new CityInfo("Tími", "06", 34.73177, 32.51613);
case 14: return new CityInfo("Tersefánou", "03", 34.85408, 33.54739);
case 15: return new CityInfo("Tála", "06", 34.83632, 32.43097);
case 16: return new CityInfo("Stroumpí", "06", 34.88784, 32.48134);
case 17: return new CityInfo("Sotíra", "05", 34.71189, 32.8634);
case 18: return new CityInfo("Siá", "04", 34.95523, 33.38997);
case 19: return new CityInfo("Rizokárpaso", "01", 35.59719, 34.37916);
case 20: return new CityInfo("Pyrgos", "05", 34.74167, 33.18333);
case 21: return new CityInfo("Pýla", "03", 35.00469, 33.68907);
case 22: return new CityInfo("Psimolofou", "04", 35.0625, 33.2625);
case 23: return new CityInfo("Psevdás", "03", 34.94478, 33.46072);
case 24: return new CityInfo("Potámi", "04", 35.10439, 33.02982);
case 25: return new CityInfo("Pomós", "06", 35.16037, 32.54574);
case 26: return new CityInfo("Pólis", "06", 35.03403, 32.4255);
case 27: return new CityInfo("Polémi", "06", 34.88613, 32.50712);
case 28: return new CityInfo("Pissoúri", "05", 34.66942, 32.70132);
case 29: return new CityInfo("Frénaros", "01", 35.04121, 33.92242);
case 30: return new CityInfo("Pégeia", "06", 34.88385, 32.38188);
case 31: return new CityInfo("Perivólia", "03", 34.82894, 33.58272);
case 32: return new CityInfo("Peristeróna", "04", 35.12928, 33.07858);
case 33: return new CityInfo("Pérgamos", "03", 35.04167, 33.70833);
case 34: return new CityInfo("Péra", "04", 35.0335, 33.25413);
case 35: return new CityInfo("Peléndri", "05", 34.89597, 32.96817);
case 36: return new CityInfo("Parekklisha", "05", 34.74583, 33.15833);
case 37: return new CityInfo("Paralímni", "01", 35.03945, 33.98181);
case 38: return new CityInfo("Paphos", "06", 34.77679, 32.42451);
case 39: return new CityInfo("Páno Polemídia", "05", 34.70559, 32.99269);
case 40: return new CityInfo("Pano Panagia", "06", 34.91954, 32.63155);
case 41: return new CityInfo("Páno Léfkara", "03", 34.81667, 33.28333);
case 42: return new CityInfo("Páno Kivídes", "05", 34.75743, 32.85725);
case 43: return new CityInfo("Páno Defterá", "04", 35.07778, 33.26584);
case 44: return new CityInfo("Palodeia", "05", 34.74504, 33.00578);
case 45: return new CityInfo("Páchna", "05", 34.77874, 32.79355);
case 46: return new CityInfo("Oroúnta", "04", 35.10123, 33.09357);
case 47: return new CityInfo("Nicosia", "04", 35.17531, 33.3642);
case 48: return new CityInfo("Mouttagiáka", "05", 34.72022, 33.10066);
case 49: return new CityInfo("Mosfilotí", "03", 34.95322, 33.42518);
case 50: return new CityInfo("Mórfou", "04", 35.19869, 32.99338);
case 51: return new CityInfo("Mitseró", "04", 35.04267, 33.12401);
case 52: return new CityInfo("Mesógi", "06", 34.81529, 32.45627);
case 53: return new CityInfo("Mesa Chorio", "06", 34.80888, 32.46196);
case 54: return new CityInfo("Meneou", "03", 34.86075, 33.59314);
case 55: return new CityInfo("Meládeia", "06", 34.98816, 32.50665);
case 56: return new CityInfo("Mazotós", "03", 34.80364, 33.48947);
case 57: return new CityInfo("Mathiátis", "04", 34.96349, 33.33627);
case 58: return new CityInfo("Maróni", "03", 34.75735, 33.35657);
case 59: return new CityInfo("Mámmari", "04", 35.17604, 33.20435);
case 60: return new CityInfo("Lythrodóntas", "04", 34.95105, 33.29777);
case 61: return new CityInfo("Lýmpia", "04", 34.99889, 33.46175);
case 62: return new CityInfo("Livádia", "03", 34.95515, 33.62734);
case 63: return new CityInfo("Liopétri", "01", 35.00885, 33.89256);
case 64: return new CityInfo("Limassol", "05", 34.68406, 33.03794);
case 65: return new CityInfo("Leonárisso", "01", 35.46892, 34.13886);
case 66: return new CityInfo("Lempa", "06", 34.80863, 32.4079);
case 67: return new CityInfo("Lefkónoiko", "01", 35.2598, 33.73189);
case 68: return new CityInfo("Léfka", "04", 35.11199, 32.84997);
case 69: return new CityInfo("Larnaca", "03", 34.92291, 33.6233);
case 70: return new CityInfo("Lápithos", "02", 35.33823, 33.17368);
case 71: return new CityInfo("Kyrenia", "02", 35.33634, 33.31729);
case 72: return new CityInfo("Kyperoúnta", "05", 34.93815, 32.97551);
case 73: return new CityInfo("Kouklia", "06", 34.70987, 32.57331);
case 74: return new CityInfo("Kórnos", "03", 34.92221, 33.39587);
case 75: return new CityInfo("Korákou", "04", 35.04108, 32.88737);
case 76: return new CityInfo("Kofínou", "03", 34.82427, 33.39133);
case 77: return new CityInfo("Konia", "06", 34.78516, 32.459);
case 78: return new CityInfo("Kolossi", "03", 34.66865, 32.93375);
case 79: return new CityInfo("Koloni", "06", 34.74858, 32.46565);
case 80: return new CityInfo("Kokkinotrimithiá", "04", 35.15303, 33.19966);
case 81: return new CityInfo("Klírou", "04", 35.02004, 33.17806);
case 82: return new CityInfo("Kíti", "03", 34.84898, 33.57523);
case 83: return new CityInfo("Kissonerga", "06", 34.82279, 32.40131);
case 84: return new CityInfo("Chlórakas", "06", 34.79836, 32.40653);
case 85: return new CityInfo("Choirokoitía", "03", 34.79747, 33.33519);
case 86: return new CityInfo("Káto Pýrgos", "04", 35.17897, 32.686);
case 87: return new CityInfo("Káto Defterá", "04", 35.08489, 33.27558);
case 88: return new CityInfo("Kalavasos", "03", 34.7584, 33.30798);
case 89: return new CityInfo("Kakopetriá", "04", 34.98768, 32.90468);
case 90: return new CityInfo("Galáta", "04", 34.99699, 32.8993);
case 91: return new CityInfo("Famagusta", "01", 35.12489, 33.94135);
case 92: return new CityInfo("Evrýchou", "04", 35.04136, 32.90229);
case 93: return new CityInfo("Avdímou", "05", 34.69406, 32.76263);
case 94: return new CityInfo("Erími", "05", 34.67766, 32.91815);
case 95: return new CityInfo("Episkopeió", "04", 35.04259, 33.24578);
case 96: return new CityInfo("Emba", "06", 34.807, 32.42406);
case 97: return new CityInfo("Dhromolaxia", "03", 34.87551, 33.58684);
case 98: return new CityInfo("Derýneia", "01", 35.06484, 33.96083);
case 99: return new CityInfo("Dáli", "04", 35.02294, 33.42195);
case 100: return new CityInfo("Ágios Týchon", "03", 34.72606, 33.13872);
case 101: return new CityInfo("Ayia Napa", "01", 34.98213, 34.00183);
case 102: return new CityInfo("Avgórou", "01", 35.03615, 33.83918);
case 103: return new CityInfo("Áchna", "01", 35.05515, 33.78388);
case 104: return new CityInfo("Athíenou", "03", 35.06183, 33.54166);
case 105: return new CityInfo("Astromerítis", "04", 35.14096, 33.03793);
case 106: return new CityInfo("Ergátes", "04", 35.05365, 33.24292);
case 107: return new CityInfo("Argáka", "06", 35.06586, 32.49226);
case 108: return new CityInfo("Aradíppou", "03", 34.94779, 33.58813);
case 109: return new CityInfo("Aredioú", "04", 35.04844, 33.1961);
case 110: return new CityInfo("Anaríta", "06", 34.74057, 32.53375);
case 111: return new CityInfo("Anafotída", "03", 34.82435, 33.46357);
case 112: return new CityInfo("Alethrikó", "03", 34.86099, 33.4943);
case 113: return new CityInfo("Alámpra", "04", 34.98898, 33.39887);
case 114: return new CityInfo("Acherítou", "01", 35.10022, 33.86155);
case 115: return new CityInfo("Akáki", "04", 35.13341, 33.12873);
case 116: return new CityInfo("Agrós", "05", 34.91784, 33.01811);
case 117: return new CityInfo("Méniko", "04", 35.10945, 33.14474);
case 118: return new CityInfo("Geroskipou", "06", 34.76091, 32.44844);
default: return new CityInfo("Tsada - Tremithousa - Tala (Borders)", "06", 34.8343, 32.45363);

                                    }                                        
                                }
                            
                        }
                    }
                