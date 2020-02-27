
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
                                    public const string Country = "NO";
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
                            
                                        var cur = (Math.Abs(70.37048 - lat) + Math.Abs(31.11066 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(70.17278 - lat) + Math.Abs(28.55598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.07348 - lat) + Math.Abs(29.74943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.76783 - lat) + Math.Abs(21.02466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.03114 - lat) + Math.Abs(20.97141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.60407 - lat) + Math.Abs(20.53272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.23936 - lat) + Math.Abs(22.3507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(71.04137 - lat) + Math.Abs(27.85133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.57629 - lat) + Math.Abs(20.21887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.05133 - lat) + Math.Abs(24.97182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.50271 - lat) + Math.Abs(23.97974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.94574 - lat) + Math.Abs(27.3465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.72706 - lat) + Math.Abs(30.04578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.01247 - lat) + Math.Abs(23.04116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.47187 - lat) + Math.Abs(25.51122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.98209 - lat) + Math.Abs(25.97037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.99634 - lat) + Math.Abs(24.66217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.66336 - lat) + Math.Abs(23.68209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.93804 - lat) + Math.Abs(22.05205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.66745 - lat) + Math.Abs(29.98722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.85778 - lat) + Math.Abs(29.08636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.63428 - lat) + Math.Abs(29.7175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.96887 - lat) + Math.Abs(23.27165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.64126 - lat) + Math.Abs(23.67213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.1893 - lat) + Math.Abs(7.92826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.07955 - lat) + Math.Abs(8.01602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46175 - lat) + Math.Abs(5.43265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.62869 - lat) + Math.Abs(6.41474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.146 - lat) + Math.Abs(6.07108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35657 - lat) + Math.Abs(5.23812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.59496 - lat) + Math.Abs(9.75134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.08707 - lat) + Math.Abs(6.57914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.63759 - lat) + Math.Abs(6.09133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.96838 - lat) + Math.Abs(9.99107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.31254 - lat) + Math.Abs(12.16734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.57103 - lat) + Math.Abs(5.68182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.08437 - lat) + Math.Abs(7.30497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.6978 - lat) + Math.Abs(12.43706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09991 - lat) + Math.Abs(6.58696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.60511 - lat) + Math.Abs(10.75233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.79332 - lat) + Math.Abs(11.4817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.26856 - lat) + Math.Abs(7.97314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.55826 - lat) + Math.Abs(6.61708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.6181 - lat) + Math.Abs(5.65702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09812 - lat) + Math.Abs(6.69184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.17057 - lat) + Math.Abs(17.73416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.76667 - lat) + Math.Abs(5.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.21259 - lat) + Math.Abs(7.53559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.29782 - lat) + Math.Abs(7.26374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67122 - lat) + Math.Abs(11.83477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.47685 - lat) + Math.Abs(5.7407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.04349 - lat) + Math.Abs(5.52274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.87505 - lat) + Math.Abs(9.09671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3057 - lat) + Math.Abs(4.8862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.933 - lat) + Math.Abs(5.86339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56791 - lat) + Math.Abs(6.91645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.34317 - lat) + Math.Abs(5.84869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28245 - lat) + Math.Abs(9.26548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.00402 - lat) + Math.Abs(5.52876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33204 - lat) + Math.Abs(5.48981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.11631 - lat) + Math.Abs(6.55906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37404 - lat) + Math.Abs(5.75952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.08553 - lat) + Math.Abs(10.09702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.27594 - lat) + Math.Abs(10.78241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.23366 - lat) + Math.Abs(8.12199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.62203 - lat) + Math.Abs(8.93147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.31484 - lat) + Math.Abs(12.26374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.43049 - lat) + Math.Abs(10.39506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.6489 - lat) + Math.Abs(18.95508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.53335 - lat) + Math.Abs(13.40631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02064 - lat) + Math.Abs(8.5202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.31423 - lat) + Math.Abs(10.30066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.8085 - lat) + Math.Abs(10.26114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66263 - lat) + Math.Abs(6.71694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26754 - lat) + Math.Abs(10.40762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.6591 - lat) + Math.Abs(10.99487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.58118 - lat) + Math.Abs(6.93106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.40898 - lat) + Math.Abs(10.99883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.54275 - lat) + Math.Abs(10.56138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.1109 - lat) + Math.Abs(10.3933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.59623 - lat) + Math.Abs(4.84449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3757 - lat) + Math.Abs(7.2197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.087 - lat) + Math.Abs(12.37148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06481 - lat) + Math.Abs(5.9225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09781 - lat) + Math.Abs(7.81529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.31667 - lat) + Math.Abs(10.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.93618 - lat) + Math.Abs(5.5741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.55 - lat) + Math.Abs(6.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.89303 - lat) + Math.Abs(10.29105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23803 - lat) + Math.Abs(5.45285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.23417 - lat) + Math.Abs(14.56834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.6137 - lat) + Math.Abs(10.40872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.76976 - lat) + Math.Abs(5.29544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.5419 - lat) + Math.Abs(5.35178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.7 - lat) + Math.Abs(11.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.67519 - lat) + Math.Abs(8.56327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06269 - lat) + Math.Abs(10.30728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.90259 - lat) + Math.Abs(6.7179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.34769 - lat) + Math.Abs(15.60493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.87163 - lat) + Math.Abs(11.29617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.6888 - lat) + Math.Abs(14.47205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.30864 - lat) + Math.Abs(6.93717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.69723 - lat) + Math.Abs(15.44949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.24081 - lat) + Math.Abs(19.23437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.40478 - lat) + Math.Abs(14.5286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.09485 - lat) + Math.Abs(5.22705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.56462 - lat) + Math.Abs(14.91075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22255 - lat) + Math.Abs(10.30055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.4681 - lat) + Math.Abs(10.92618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.78389 - lat) + Math.Abs(6.47065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.01487 - lat) + Math.Abs(11.49537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59 - lat) + Math.Abs(10.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.97005 - lat) + Math.Abs(5.73332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.55224 - lat) + Math.Abs(5.73632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71803 - lat) + Math.Abs(11.19417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.13013 - lat) + Math.Abs(13.84933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.61709 - lat) + Math.Abs(11.08559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18333 - lat) + Math.Abs(11.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.91904 - lat) + Math.Abs(11.43291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21611 - lat) + Math.Abs(5.38722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.98621 - lat) + Math.Abs(11.24154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.69569 - lat) + Math.Abs(15.40498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.66564 - lat) + Math.Abs(12.69784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43608 - lat) + Math.Abs(4.96642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.11667 - lat) + Math.Abs(12.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.88854 - lat) + Math.Abs(5.65285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23885 - lat) + Math.Abs(9.92806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09328 - lat) + Math.Abs(7.78294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.22575 - lat) + Math.Abs(7.10178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.2457 - lat) + Math.Abs(12.37779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.93333 - lat) + Math.Abs(10.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.19608 - lat) + Math.Abs(10.82466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.78074 - lat) + Math.Abs(10.49701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92746 - lat) + Math.Abs(10.4475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.14945 - lat) + Math.Abs(5.25913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65257 - lat) + Math.Abs(10.93564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.98281 - lat) + Math.Abs(12.12825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38613 - lat) + Math.Abs(10.41077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.70374 - lat) + Math.Abs(11.19262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.71327 - lat) + Math.Abs(10.25356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.50468 - lat) + Math.Abs(6.69322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50273 - lat) + Math.Abs(5.58687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.21148 - lat) + Math.Abs(11.19025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02526 - lat) + Math.Abs(11.03685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.20962 - lat) + Math.Abs(9.60897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.71949 - lat) + Math.Abs(10.83576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.25149 - lat) + Math.Abs(10.05236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25391 - lat) + Math.Abs(11.68485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.73288 - lat) + Math.Abs(5.93762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.44456 - lat) + Math.Abs(17.29832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.46747 - lat) + Math.Abs(11.75643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.87363 - lat) + Math.Abs(17.84706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.64069 - lat) + Math.Abs(11.31591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.48263 - lat) + Math.Abs(6.81376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.72523 - lat) + Math.Abs(8.83318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.42068 - lat) + Math.Abs(6.66218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28843 - lat) + Math.Abs(9.71 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.64373 - lat) + Math.Abs(15.51157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.86099 - lat) + Math.Abs(18.34857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25 - lat) + Math.Abs(11.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2823 - lat) + Math.Abs(10.33004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56645 - lat) + Math.Abs(10.26004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48477 - lat) + Math.Abs(8.63017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.0444 - lat) + Math.Abs(5.34739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.23333 - lat) + Math.Abs(10.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.65059 - lat) + Math.Abs(6.35415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28391 - lat) + Math.Abs(11.10962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.46377 - lat) + Math.Abs(13.59125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.89073 - lat) + Math.Abs(10.52774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.02166 - lat) + Math.Abs(12.63158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.85244 - lat) + Math.Abs(5.73521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.54441 - lat) + Math.Abs(5.86229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.13118 - lat) + Math.Abs(10.21665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.32511 - lat) + Math.Abs(5.79773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.58679 - lat) + Math.Abs(10.20809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.77277 - lat) + Math.Abs(6.21496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.3922 - lat) + Math.Abs(11.5403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.78139 - lat) + Math.Abs(5.38996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26667 - lat) + Math.Abs(5.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.68129 - lat) + Math.Abs(10.52749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.79415 - lat) + Math.Abs(5.7097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.40974 - lat) + Math.Abs(8.63844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.37762 - lat) + Math.Abs(10.75034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.81559 - lat) + Math.Abs(5.26822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.88394 - lat) + Math.Abs(13.56256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.74724 - lat) + Math.Abs(10.38832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25342 - lat) + Math.Abs(12.05225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.05707 - lat) + Math.Abs(10.86135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.51754 - lat) + Math.Abs(12.1176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.98589 - lat) + Math.Abs(6.01157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.86185 - lat) + Math.Abs(11.23969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.57468 - lat) + Math.Abs(11.3842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.98431 - lat) + Math.Abs(9.29644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.10021 - lat) + Math.Abs(15.39086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.58236 - lat) + Math.Abs(6.12462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.29093 - lat) + Math.Abs(10.61585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.87891 - lat) + Math.Abs(8.59411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.72057 - lat) + Math.Abs(9.23422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.05547 - lat) + Math.Abs(9.21151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.13222 - lat) + Math.Abs(11.37156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67977 - lat) + Math.Abs(10.62175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.09843 - lat) + Math.Abs(7.82026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.93249 - lat) + Math.Abs(13.08955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.72604 - lat) + Math.Abs(10.6133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.98501 - lat) + Math.Abs(5.13796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.49447 - lat) + Math.Abs(11.94912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.99955 - lat) + Math.Abs(5.61871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.08991 - lat) + Math.Abs(13.22989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42513 - lat) + Math.Abs(11.34535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.27513 - lat) + Math.Abs(11.17901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.04343 - lat) + Math.Abs(9.6352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.09773 - lat) + Math.Abs(9.05866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.14054 - lat) + Math.Abs(9.6561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38825 - lat) + Math.Abs(6.19251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.3085 - lat) + Math.Abs(7.79694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.7712 - lat) + Math.Abs(9.53529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18385 - lat) + Math.Abs(5.4638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.91273 - lat) + Math.Abs(10.74609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.49647 - lat) + Math.Abs(11.22326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.86878 - lat) + Math.Abs(13.70579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.30668 - lat) + Math.Abs(9.85025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48023 - lat) + Math.Abs(11.66016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.59431 - lat) + Math.Abs(9.6912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.8286 - lat) + Math.Abs(6.03687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.60437 - lat) + Math.Abs(5.80799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06912 - lat) + Math.Abs(6.54565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.55936 - lat) + Math.Abs(9.25853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37089 - lat) + Math.Abs(6.14562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.17985 - lat) + Math.Abs(9.62411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18578 - lat) + Math.Abs(11.26302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.9122 - lat) + Math.Abs(5.98557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.15517 - lat) + Math.Abs(7.83576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.19817 - lat) + Math.Abs(13.01844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56809 - lat) + Math.Abs(9.10274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.51108 - lat) + Math.Abs(5.71694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.43838 - lat) + Math.Abs(17.4272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.92886 - lat) + Math.Abs(13.15954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.46624 - lat) + Math.Abs(11.49572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66546 - lat) + Math.Abs(5.63788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.55354 - lat) + Math.Abs(11.32578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.10588 - lat) + Math.Abs(15.96308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.74921 - lat) + Math.Abs(8.86254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.69919 - lat) + Math.Abs(5.38585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43403 - lat) + Math.Abs(10.65771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.83599 - lat) + Math.Abs(13.19076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.00601 - lat) + Math.Abs(14.5743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.73752 - lat) + Math.Abs(7.15912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.18343 - lat) + Math.Abs(8.0921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.31278 - lat) + Math.Abs(14.14278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.45674 - lat) + Math.Abs(6.55184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.13043 - lat) + Math.Abs(18.61226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.93333 - lat) + Math.Abs(10.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81625 - lat) + Math.Abs(5.80575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.75075 - lat) + Math.Abs(10.02477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.67387 - lat) + Math.Abs(6.67412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.41406 - lat) + Math.Abs(11.74298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22394 - lat) + Math.Abs(10.33616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.28555 - lat) + Math.Abs(10.27806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.50246 - lat) + Math.Abs(14.79962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.2583 - lat) + Math.Abs(11.03192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.79887 - lat) + Math.Abs(5.30418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.64145 - lat) + Math.Abs(5.04136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.0274 - lat) + Math.Abs(7.45342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.43333 - lat) + Math.Abs(10.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.93535 - lat) + Math.Abs(5.11362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.07534 - lat) + Math.Abs(11.22398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.95092 - lat) + Math.Abs(12.20151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.90994 - lat) + Math.Abs(10.63545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.1376 - lat) + Math.Abs(7.07002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.29832 - lat) + Math.Abs(9.10268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.15216 - lat) + Math.Abs(10.28555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81941 - lat) + Math.Abs(11.34209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.01976 - lat) + Math.Abs(11.23003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.31343 - lat) + Math.Abs(14.44934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.52556 - lat) + Math.Abs(5.49563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.83772 - lat) + Math.Abs(8.56842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.12582 - lat) + Math.Abs(9.70518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.79553 - lat) + Math.Abs(11.46597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.33263 - lat) + Math.Abs(6.66167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.41373 - lat) + Math.Abs(15.99626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.30055 - lat) + Math.Abs(14.73852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.03831 - lat) + Math.Abs(11.12421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73639 - lat) + Math.Abs(5.16102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.95597 - lat) + Math.Abs(11.04918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.24879 - lat) + Math.Abs(8.3778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.11514 - lat) + Math.Abs(10.46628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.31216 - lat) + Math.Abs(6.9618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.74644 - lat) + Math.Abs(11.29963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27119 - lat) + Math.Abs(10.7461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.51389 - lat) + Math.Abs(9.80611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67391 - lat) + Math.Abs(10.81317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.06406 - lat) + Math.Abs(12.94325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.1 - lat) + Math.Abs(11.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.77977 - lat) + Math.Abs(5.50051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.99682 - lat) + Math.Abs(11.08746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.97006 - lat) + Math.Abs(9.29488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.50061 - lat) + Math.Abs(10.89396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.05328 - lat) + Math.Abs(10.03517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.20282 - lat) + Math.Abs(5.57729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33196 - lat) + Math.Abs(10.66687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.44085 - lat) + Math.Abs(6.19137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.60726 - lat) + Math.Abs(5.2343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.00071 - lat) + Math.Abs(9.74876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.08769 - lat) + Math.Abs(9.8046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.10001 - lat) + Math.Abs(7.47374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.29057 - lat) + Math.Abs(9.08909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40223 - lat) + Math.Abs(8.49267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.19241 - lat) + Math.Abs(9.96886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.665 - lat) + Math.Abs(9.68773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.40099 - lat) + Math.Abs(9.50062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.11045 - lat) + Math.Abs(7.72795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.14671 - lat) + Math.Abs(7.9956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.8693 - lat) + Math.Abs(9.41494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.07662 - lat) + Math.Abs(13.8216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.57219 - lat) + Math.Abs(11.04659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28354 - lat) + Math.Abs(5.30669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.28529 - lat) + Math.Abs(7.35598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.19049 - lat) + Math.Abs(11.99772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.66858 - lat) + Math.Abs(9.65017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.86549 - lat) + Math.Abs(11.60465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65033 - lat) + Math.Abs(10.74489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.81056 - lat) + Math.Abs(10.80389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5453 - lat) + Math.Abs(5.28208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62424 - lat) + Math.Abs(11.03274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37906 - lat) + Math.Abs(5.05602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07407 - lat) + Math.Abs(11.13805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40844 - lat) + Math.Abs(5.2276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.09696 - lat) + Math.Abs(16.37416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4579 - lat) + Math.Abs(12.05855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.89159 - lat) + Math.Abs(9.30078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.18453 - lat) + Math.Abs(7.24252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35195 - lat) + Math.Abs(10.87226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.21066 - lat) + Math.Abs(14.47554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.17204 - lat) + Math.Abs(5.87617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.02251 - lat) + Math.Abs(6.04078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.27186 - lat) + Math.Abs(8.50675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.27561 - lat) + Math.Abs(6.25229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23979 - lat) + Math.Abs(10.38709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14151 - lat) + Math.Abs(11.17515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.39273 - lat) + Math.Abs(10.56155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30038 - lat) + Math.Abs(11.2205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.55519 - lat) + Math.Abs(5.26942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.03353 - lat) + Math.Abs(14.02663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7757 - lat) + Math.Abs(11.22725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.38631 - lat) + Math.Abs(6.55094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.17109 - lat) + Math.Abs(5.29603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51028 - lat) + Math.Abs(5.35444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48572 - lat) + Math.Abs(10.01173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.55523 - lat) + Math.Abs(9.94069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.22348 - lat) + Math.Abs(6.08471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.10552 - lat) + Math.Abs(10.22378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56045 - lat) + Math.Abs(7.3567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.6987 - lat) + Math.Abs(10.35193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41721 - lat) + Math.Abs(10.48343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.46539 - lat) + Math.Abs(8.01437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.16804 - lat) + Math.Abs(10.25647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.41083 - lat) + Math.Abs(10.79424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48761 - lat) + Math.Abs(10.31761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.65139 - lat) + Math.Abs(5.16139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.54902 - lat) + Math.Abs(16.39218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.77077 - lat) + Math.Abs(9.90987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.55281 - lat) + Math.Abs(12.02192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.7805 - lat) + Math.Abs(7.49277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.10351 - lat) + Math.Abs(9.56195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.18461 - lat) + Math.Abs(6.85016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.86293 - lat) + Math.Abs(8.55337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.22489 - lat) + Math.Abs(13.61643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.72085 - lat) + Math.Abs(11.45524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.47818 - lat) + Math.Abs(5.8782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.44582 - lat) + Math.Abs(10.90093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.69973 - lat) + Math.Abs(11.29813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.46384 - lat) + Math.Abs(11.11516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.14383 - lat) + Math.Abs(9.06942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.28333 - lat) + Math.Abs(14.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41378 - lat) + Math.Abs(5.268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.34361 - lat) + Math.Abs(6.28121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.79833 - lat) + Math.Abs(16.54165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.37041 - lat) + Math.Abs(6.02902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.07562 - lat) + Math.Abs(4.84111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.96701 - lat) + Math.Abs(19.62752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.77927 - lat) + Math.Abs(17.17179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7945 - lat) + Math.Abs(11.06798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.27143 - lat) + Math.Abs(10.18451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.12478 - lat) + Math.Abs(11.38754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.40521 - lat) + Math.Abs(17.30832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18076 - lat) + Math.Abs(5.40146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38778 - lat) + Math.Abs(5.77056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38767 - lat) + Math.Abs(9.1724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.5013 - lat) + Math.Abs(10.25224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.36304 - lat) + Math.Abs(17.05284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25701 - lat) + Math.Abs(10.66222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.46459 - lat) + Math.Abs(12.31601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.64385 - lat) + Math.Abs(8.72465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3405 - lat) + Math.Abs(8.59343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.11832 - lat) + Math.Abs(13.55339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.65 - lat) + Math.Abs(17.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.52408 - lat) + Math.Abs(6.7194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7014 - lat) + Math.Abs(8.94572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.81663 - lat) + Math.Abs(13.94404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.67683 - lat) + Math.Abs(11.96218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.19691 - lat) + Math.Abs(8.03107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.79574 - lat) + Math.Abs(10.69155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.88083 - lat) + Math.Abs(9.01861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.48333 - lat) + Math.Abs(6.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53369 - lat) + Math.Abs(8.20539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.02463 - lat) + Math.Abs(11.10284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51321 - lat) + Math.Abs(5.24252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2181 - lat) + Math.Abs(10.9298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.20213 - lat) + Math.Abs(10.14384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.81984 - lat) + Math.Abs(11.48657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22218 - lat) + Math.Abs(11.69928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.34194 - lat) + Math.Abs(5.63396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.45217 - lat) + Math.Abs(5.85717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.21581 - lat) + Math.Abs(10.28498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.13246 - lat) + Math.Abs(9.9968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.59957 - lat) + Math.Abs(5.0328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.29705 - lat) + Math.Abs(6.66069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.82951 - lat) + Math.Abs(11.15345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43021 - lat) + Math.Abs(9.46197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.79414 - lat) + Math.Abs(10.60691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.91803 - lat) + Math.Abs(5.31674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.22959 - lat) + Math.Abs(17.98114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.60638 - lat) + Math.Abs(8.96961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3782 - lat) + Math.Abs(8.67601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92463 - lat) + Math.Abs(11.15711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7789 - lat) + Math.Abs(4.71485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.25883 - lat) + Math.Abs(15.39181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09479 - lat) + Math.Abs(6.80468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.73746 - lat) + Math.Abs(10.59404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.98584 - lat) + Math.Abs(9.23236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.26667 - lat) + Math.Abs(13.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.58569 - lat) + Math.Abs(7.80363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.58283 - lat) + Math.Abs(16.57203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.66528 - lat) + Math.Abs(5.93708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38249 - lat) + Math.Abs(5.4657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.88191 - lat) + Math.Abs(11.56231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.98133 - lat) + Math.Abs(5.07497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.62864 - lat) + Math.Abs(10.59863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.24175 - lat) + Math.Abs(5.74433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39833 - lat) + Math.Abs(5.36389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.3311 - lat) + Math.Abs(11.26264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.77656 - lat) + Math.Abs(8.0655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4675 - lat) + Math.Abs(7.07193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.91735 - lat) + Math.Abs(7.44669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.45133 - lat) + Math.Abs(5.9997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.66333 - lat) + Math.Abs(10.62975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.74389 - lat) + Math.Abs(10.20449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.9875 - lat) + Math.Abs(9.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.07554 - lat) + Math.Abs(9.12785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.835 - lat) + Math.Abs(10.07362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.44499 - lat) + Math.Abs(8.00492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.77534 - lat) + Math.Abs(9.49454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.36353 - lat) + Math.Abs(5.40036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.58639 - lat) + Math.Abs(5.81888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.8285 - lat) + Math.Abs(7.79616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.90706 - lat) + Math.Abs(6.91409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.73536 - lat) + Math.Abs(5.64766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.88095 - lat) + Math.Abs(10.93948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.88781 - lat) + Math.Abs(9.64143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.47487 - lat) + Math.Abs(12.21285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.79284 - lat) + Math.Abs(5.17226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.68697 - lat) + Math.Abs(9.66541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.59991 - lat) + Math.Abs(6.44426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.76484 - lat) + Math.Abs(9.80863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.77261 - lat) + Math.Abs(16.17115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.09394 - lat) + Math.Abs(11.21292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.52647 - lat) + Math.Abs(16.9928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.28 - lat) + Math.Abs(14.40501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.41299 - lat) + Math.Abs(9.0693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.8191 - lat) + Math.Abs(10.4645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.88357 - lat) + Math.Abs(11.56396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.54917 - lat) + Math.Abs(17.55709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.88333 - lat) + Math.Abs(8.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33091 - lat) + Math.Abs(8.23229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.82496 - lat) + Math.Abs(10.01177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.54994 - lat) + Math.Abs(10.38641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.39299 - lat) + Math.Abs(5.32415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.37618 - lat) + Math.Abs(17.59596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.89463 - lat) + Math.Abs(7.67251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31859 - lat) + Math.Abs(10.38963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.39232 - lat) + Math.Abs(11.39688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.07431 - lat) + Math.Abs(13.54515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.34283 - lat) + Math.Abs(16.83145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.20962 - lat) + Math.Abs(6.53608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.82249 - lat) + Math.Abs(9.55207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7774 - lat) + Math.Abs(4.9323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92763 - lat) + Math.Abs(11.44275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.2679 - lat) + Math.Abs(8.52913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.92443 - lat) + Math.Abs(9.41488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.0345 - lat) + Math.Abs(11.36046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.78333 - lat) + Math.Abs(6.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.58326 - lat) + Math.Abs(11.16286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83333 - lat) + Math.Abs(10.43721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07131 - lat) + Math.Abs(11.0362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.34938 - lat) + Math.Abs(10.46948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.05 - lat) + Math.Abs(11.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.66472 - lat) + Math.Abs(10.79465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.7061 - lat) + Math.Abs(10.51092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.96114 - lat) + Math.Abs(10.22601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.12237 - lat) + Math.Abs(11.47005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.41768 - lat) + Math.Abs(5.47087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.46151 - lat) + Math.Abs(8.77253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.23581 - lat) + Math.Abs(7.7037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.08926 - lat) + Math.Abs(10.86998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.06554 - lat) + Math.Abs(18.51552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.31428 - lat) + Math.Abs(16.11939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.56749 - lat) + Math.Abs(7.68709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.63333 - lat) + Math.Abs(8.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.56974 - lat) + Math.Abs(7.98871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.76566 - lat) + Math.Abs(8.48392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43274 - lat) + Math.Abs(6.43164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.10766 - lat) + Math.Abs(10.63073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.76417 - lat) + Math.Abs(5.85253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.47225 - lat) + Math.Abs(6.15492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.84185 - lat) + Math.Abs(11.3013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.63024 - lat) + Math.Abs(8.56071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26053 - lat) + Math.Abs(5.18689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40306 - lat) + Math.Abs(5.01927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.79653 - lat) + Math.Abs(11.30883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.96068 - lat) + Math.Abs(10.22468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35607 - lat) + Math.Abs(5.31962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.22474 - lat) + Math.Abs(5.15093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.91318 - lat) + Math.Abs(8.20526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.08522 - lat) + Math.Abs(15.60942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.92556 - lat) + Math.Abs(5.85104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.09754 - lat) + Math.Abs(5.6979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.18321 - lat) + Math.Abs(10.45743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42278 - lat) + Math.Abs(10.38417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.914 - lat) + Math.Abs(15.07843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.77741 - lat) + Math.Abs(4.93274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.86244 - lat) + Math.Abs(10.66308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4 - lat) + Math.Abs(5.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.19983 - lat) + Math.Abs(6.12904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.375 - lat) + Math.Abs(10.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.29483 - lat) + Math.Abs(5.21874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.62544 - lat) + Math.Abs(7.08696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.08967 - lat) + Math.Abs(11.47222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.05387 - lat) + Math.Abs(11.37411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.10696 - lat) + Math.Abs(11.3687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.12159 - lat) + Math.Abs(11.33926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37567 - lat) + Math.Abs(6.71948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92105 - lat) + Math.Abs(10.68017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5715 - lat) + Math.Abs(6.4791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.30504 - lat) + Math.Abs(5.28236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.30323 - lat) + Math.Abs(5.28554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.46803 - lat) + Math.Abs(10.91776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.5891 - lat) + Math.Abs(10.7423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.05712 - lat) + Math.Abs(6.57806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.22908 - lat) + Math.Abs(7.09674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.7497 - lat) + Math.Abs(11.8112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.47453 - lat) + Math.Abs(11.16083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.4921 - lat) + Math.Abs(10.87432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.62401 - lat) + Math.Abs(10.9508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.9033 - lat) + Math.Abs(6.1048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92626 - lat) + Math.Abs(11.06527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.76452 - lat) + Math.Abs(11.14492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.93098 - lat) + Math.Abs(10.95373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.22069 - lat) + Math.Abs(11.0176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43518 - lat) + Math.Abs(11.06707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61318 - lat) + Math.Abs(12.01088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.89126 - lat) + Math.Abs(11.07769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.75904 - lat) + Math.Abs(11.95937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.11837 - lat) + Math.Abs(8.86424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.88406 - lat) + Math.Abs(8.26665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.52965 - lat) + Math.Abs(10.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.22819 - lat) + Math.Abs(10.22255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.08802 - lat) + Math.Abs(8.98141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.12529 - lat) + Math.Abs(8.5729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07706 - lat) + Math.Abs(10.27908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.86114 - lat) + Math.Abs(8.56537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61511 - lat) + Math.Abs(8.29398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.78651 - lat) + Math.Abs(10.24447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83486 - lat) + Math.Abs(9.57912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.26722 - lat) + Math.Abs(8.94721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.3724 - lat) + Math.Abs(10.26308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30592 - lat) + Math.Abs(10.17653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22629 - lat) + Math.Abs(10.40745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.6161 - lat) + Math.Abs(8.93755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.5046 - lat) + Math.Abs(8.64648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.45909 - lat) + Math.Abs(7.91692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.19344 - lat) + Math.Abs(7.52431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.61523 - lat) + Math.Abs(7.41391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.77423 - lat) + Math.Abs(5.62936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23692 - lat) + Math.Abs(6.17907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48468 - lat) + Math.Abs(6.25109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06227 - lat) + Math.Abs(5.40249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23062 - lat) + Math.Abs(5.43524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42408 - lat) + Math.Abs(5.44553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25512 - lat) + Math.Abs(5.10161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.36131 - lat) + Math.Abs(5.12199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.90578 - lat) + Math.Abs(7.18706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.40472 - lat) + Math.Abs(7.29458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.34673 - lat) + Math.Abs(5.06224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.96921 - lat) + Math.Abs(6.52418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.10059 - lat) + Math.Abs(5.55788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.38203 - lat) + Math.Abs(6.98629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.39594 - lat) + Math.Abs(6.5875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.5007 - lat) + Math.Abs(6.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.805 - lat) + Math.Abs(6.88722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.85426 - lat) + Math.Abs(7.13769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.05259 - lat) + Math.Abs(7.63416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.97397 - lat) + Math.Abs(8.72472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.12249 - lat) + Math.Abs(8.31587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.58368 - lat) + Math.Abs(9.95989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.17269 - lat) + Math.Abs(10.22898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.29875 - lat) + Math.Abs(10.51284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.04721 - lat) + Math.Abs(9.71337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.0391 - lat) + Math.Abs(10.28501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.32672 - lat) + Math.Abs(10.0692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.29762 - lat) + Math.Abs(10.48261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.23034 - lat) + Math.Abs(11.03099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.67274 - lat) + Math.Abs(10.6232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.22186 - lat) + Math.Abs(11.22319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.62887 - lat) + Math.Abs(12.30206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.6591 - lat) + Math.Abs(11.26535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.9832 - lat) + Math.Abs(12.28856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.59736 - lat) + Math.Abs(13.98791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.41887 - lat) + Math.Abs(12.84248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.50159 - lat) + Math.Abs(12.09645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.71367 - lat) + Math.Abs(13.28711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.77548 - lat) + Math.Abs(15.01545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.14746 - lat) + Math.Abs(13.61151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.7471 - lat) + Math.Abs(17.80621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.14527 - lat) + Math.Abs(18.15292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.08873 - lat) + Math.Abs(17.69489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.27072 - lat) + Math.Abs(19.95944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.58877 - lat) + Math.Abs(22.28712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.19909 - lat) + Math.Abs(28.19039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.34338 - lat) + Math.Abs(5.84385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.87548 - lat) + Math.Abs(10.4823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.04634 - lat) + Math.Abs(7.14143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.51384 - lat) + Math.Abs(6.13166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.73539 - lat) + Math.Abs(5.73615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vardø", "54", 70.37048, 31.11066);
case 1: return new CityInfo("Vuonnabahta", "54", 70.17278, 28.55598);
case 2: return new CityInfo("Vadsø", "54", 70.07348, 29.74943);
case 3: return new CityInfo("Storslett", "54", 69.76783, 21.02466);
case 4: return new CityInfo("Skjervøy", "54", 70.03114, 20.97141);
case 5: return new CityInfo("Olderdalen", "54", 69.60407, 20.53272);
case 6: return new CityInfo("Øksfjord", "54", 70.23936, 22.3507);
case 7: return new CityInfo("Mehamn", "54", 71.04137, 27.85133);
case 8: return new CityInfo("Lyngseidet", "54", 69.57629, 20.21887);
case 9: return new CityInfo("Lakselv", "54", 70.05133, 24.97182);
case 10: return new CityInfo("Kvalsund", "54", 70.50271, 23.97974);
case 11: return new CityInfo("Kjøllefjord", "54", 70.94574, 27.3465);
case 12: return new CityInfo("Kirkenes", "54", 69.72706, 30.04578);
case 13: return new CityInfo("Kautokeino", "54", 69.01247, 23.04116);
case 14: return new CityInfo("Kárášjohka", "54", 69.47187, 25.51122);
case 15: return new CityInfo("Honningsvåg", "54", 70.98209, 25.97037);
case 16: return new CityInfo("Ávanuorri", "54", 70.99634, 24.66217);
case 17: return new CityInfo("Hammerfest", "54", 70.66336, 23.68209);
case 18: return new CityInfo("Burfjord", "54", 69.93804, 22.05205);
case 19: return new CityInfo("Bjørnevatn", "54", 69.66745, 29.98722);
case 20: return new CityInfo("Berlevåg", "54", 70.85778, 29.08636);
case 21: return new CityInfo("Båtsfjord", "54", 70.63428, 29.7175);
case 22: return new CityInfo("Alta", "54", 69.96887, 23.27165);
case 23: return new CityInfo("Rypefjord", "54", 70.64126, 23.67213);
case 24: return new CityInfo("Strai", "42", 58.1893, 7.92826);
case 25: return new CityInfo("Skålevik", "42", 58.07955, 8.01602);
case 26: return new CityInfo("Ytre Arna", "46", 60.46175, 5.43265);
case 27: return new CityInfo("Voss", "46", 60.62869, 6.41474);
case 28: return new CityInfo("Volda", "08", 62.146, 6.07108);
case 29: return new CityInfo("Visnes", "14", 59.35657, 5.23812);
case 30: return new CityInfo("Vinstra", "34", 61.59496, 9.75134);
case 31: return new CityInfo("Vikøyri", "46", 61.08707, 6.57914);
case 32: return new CityInfo("Vikeså", "14", 58.63759, 6.09133);
case 33: return new CityInfo("Vikersund", "30", 59.96838, 9.99107);
case 34: return new CityInfo("Vik", "09", 65.31254, 12.16734);
case 35: return new CityInfo("Vigrestad", "14", 58.57103, 5.68182);
case 36: return new CityInfo("Vigeland", "42", 58.08437, 7.30497);
case 37: return new CityInfo("Vevelstad", "09", 65.6978, 12.43706);
case 38: return new CityInfo("Vestbygd", "42", 58.09991, 6.58696);
case 39: return new CityInfo("Vestby", "30", 59.60511, 10.75233);
case 40: return new CityInfo("Verdal", "21", 63.79332, 11.4817);
case 41: return new CityInfo("Vennesla", "42", 58.26856, 7.97314);
case 42: return new CityInfo("Vatne", "08", 62.55826, 6.61708);
case 43: return new CityInfo("Varhaug", "14", 58.6181, 5.65702);
case 44: return new CityInfo("Vanse", "42", 58.09812, 6.69184);
case 45: return new CityInfo("Vangsvika", "54", 69.17057, 17.73416);
case 46: return new CityInfo("Valvatna", "46", 59.76667, 5.41667);
case 47: return new CityInfo("Valle", "42", 59.21259, 7.53559);
case 48: return new CityInfo("Valldal", "08", 62.29782, 7.26374);
case 49: return new CityInfo("Våler", "34", 60.67122, 11.83477);
case 50: return new CityInfo("Vaksdal", "46", 60.47685, 5.7407);
case 51: return new CityInfo("Våge", "46", 60.04349, 5.52274);
case 52: return new CityInfo("Vågåmo", "34", 61.87505, 9.09671);
case 53: return new CityInfo("Utsira", "14", 59.3057, 4.8862);
case 54: return new CityInfo("Uskedalen", "46", 59.933, 5.86339);
case 55: return new CityInfo("Ulvik", "46", 60.56791, 6.91645);
case 56: return new CityInfo("Ulsteinvik", "08", 62.34317, 5.84869);
case 57: return new CityInfo("Ulefoss", "38", 59.28245, 9.26548);
case 58: return new CityInfo("Uggdal", "46", 60.00402, 5.52876);
case 59: return new CityInfo("Tysvær", "14", 59.33204, 5.48981);
case 60: return new CityInfo("Tyssedal", "46", 60.11631, 6.55906);
case 61: return new CityInfo("Tysse", "46", 60.37404, 5.75952);
case 62: return new CityInfo("Tyristrand", "30", 60.08553, 10.09702);
case 63: return new CityInfo("Tynset", "34", 62.27594, 10.78241);
case 64: return new CityInfo("Tveit", "42", 58.23366, 8.12199);
case 65: return new CityInfo("Tvedestrand", "42", 58.62203, 8.93147);
case 66: return new CityInfo("Innbygda", "34", 61.31484, 12.26374);
case 67: return new CityInfo("Trondheim", "21", 63.43049, 10.39506);
case 68: return new CityInfo("Tromsø", "54", 69.6489, 18.95508);
case 69: return new CityInfo("Trofors", "09", 65.53335, 13.40631);
case 70: return new CityInfo("Treungen", "38", 59.02064, 8.5202);
case 71: return new CityInfo("Tretten", "34", 61.31423, 10.30066);
case 72: return new CityInfo("Tranby", "30", 59.8085, 10.26114);
case 73: return new CityInfo("Tonstad", "42", 58.66263, 6.71694);
case 74: return new CityInfo("Tønsberg", "38", 59.26754, 10.40762);
case 75: return new CityInfo("Tomter", "30", 59.6591, 10.99487);
case 76: return new CityInfo("Tomra", "08", 62.58118, 6.93106);
case 77: return new CityInfo("Tolga", "34", 62.40898, 10.99883);
case 78: return new CityInfo("Tofte", "30", 59.54275, 10.56138);
case 79: return new CityInfo("Tjøme", "38", 59.1109, 10.3933);
case 80: return new CityInfo("Tjeldstø", "46", 60.59623, 4.84449);
case 81: return new CityInfo("Tingvatn", "42", 58.3757, 7.2197);
case 82: return new CityInfo("Terråk", "09", 65.087, 12.37148);
case 83: return new CityInfo("Tau", "14", 59.06481, 5.9225);
case 84: return new CityInfo("Tangvall", "42", 58.09781, 7.81529);
case 85: return new CityInfo("Tanem", "21", 63.31667, 10.45);
case 86: return new CityInfo("Tananger", "14", 58.93618, 5.5741);
case 87: return new CityInfo("Syvik", "08", 62.55, 6.3);
case 88: return new CityInfo("Sylling", "30", 59.89303, 10.29105);
case 89: return new CityInfo("Syfteland", "46", 60.23803, 5.45285);
case 90: return new CityInfo("Svolvær", "09", 68.23417, 14.56834);
case 91: return new CityInfo("Svelvik", "30", 59.6137, 10.40872);
case 92: return new CityInfo("Svelgen", "46", 61.76976, 5.29544);
case 93: return new CityInfo("Sveio", "46", 59.5419, 5.35178);
case 94: return new CityInfo("Svarstad", "34", 61.7, 11.21667);
case 95: return new CityInfo("Sunndalsøra", "08", 62.67519, 8.56327);
case 96: return new CityInfo("Sundvollen", "30", 60.06269, 10.30728);
case 97: return new CityInfo("Stryn", "46", 61.90259, 6.7179);
case 98: return new CityInfo("Straumen", "09", 67.34769, 15.60493);
case 99: return new CityInfo("Straumen", "21", 63.87163, 11.29617);
case 100: return new CityInfo("Straume", "09", 68.6888, 14.47205);
case 101: return new CityInfo("Stranda", "08", 62.30864, 6.93717);
case 102: return new CityInfo("Strand", "09", 68.69723, 15.44949);
case 103: return new CityInfo("Storsteinnes", "54", 69.24081, 19.23437);
case 104: return new CityInfo("Storforshei", "09", 66.40478, 14.5286);
case 105: return new CityInfo("Storebø", "46", 60.09485, 5.22705);
case 106: return new CityInfo("Stokmarknes", "09", 68.56462, 14.91075);
case 107: return new CityInfo("Stokke", "38", 59.22255, 10.30055);
case 108: return new CityInfo("Stjørdalshalsen", "21", 63.4681, 10.92618);
case 109: return new CityInfo("Steinshamn", "08", 62.78389, 6.47065);
case 110: return new CityInfo("Steinkjer", "21", 64.01487, 11.49537);
case 111: return new CityInfo("Stavern", "38", 59, 10.03333);
case 112: return new CityInfo("Stavanger", "14", 58.97005, 5.73332);
case 113: return new CityInfo("Stanghelle", "46", 60.55224, 5.73632);
case 114: return new CityInfo("Stange", "34", 60.71803, 11.19417);
case 115: return new CityInfo("Stamsund", "09", 68.13013, 13.84933);
case 116: return new CityInfo("Spydeberg", "30", 59.61709, 11.08559);
case 117: return new CityInfo("Spetalen", "34", 60.18333, 11.9);
case 118: return new CityInfo("Sparbu", "21", 63.91904, 11.43291);
case 119: return new CityInfo("Søvik", "46", 60.21611, 5.38722);
case 120: return new CityInfo("Sørumsand", "30", 59.98621, 11.24154);
case 121: return new CityInfo("Sortland", "09", 68.69569, 15.40498);
case 122: return new CityInfo("Sørland", "09", 67.66564, 12.69784);
case 123: return new CityInfo("Sollsvika", "46", 60.43608, 4.96642);
case 124: return new CityInfo("Solfjellsjøen", "09", 66.11667, 12.48333);
case 125: return new CityInfo("Sola", "14", 58.88854, 5.65285);
case 126: return new CityInfo("Sokna", "30", 60.23885, 9.92806);
case 127: return new CityInfo("Søgne", "42", 58.09328, 7.78294);
case 128: return new CityInfo("Sogndalsfjøra", "46", 61.22575, 7.10178);
case 129: return new CityInfo("Snåase", "21", 64.2457, 12.37779);
case 130: return new CityInfo("Smestad", "30", 59.93333, 10.43333);
case 131: return new CityInfo("Slevik", "30", 59.19608, 10.82466);
case 132: return new CityInfo("Slemmestad", "30", 59.78074, 10.49701);
case 133: return new CityInfo("Skui", "30", 59.92746, 10.4475);
case 134: return new CityInfo("Skudeneshavn", "14", 59.14945, 5.25913);
case 135: return new CityInfo("Skreia", "34", 60.65257, 10.93564);
case 136: return new CityInfo("Skotterud", "34", 59.98281, 12.12825);
case 137: return new CityInfo("Skoppum", "38", 59.38613, 10.41077);
case 138: return new CityInfo("Skogn", "21", 63.70374, 11.19262);
case 139: return new CityInfo("Skoger", "30", 59.71327, 10.25356);
case 140: return new CityInfo("Skodje", "08", 62.50468, 6.69322);
case 141: return new CityInfo("Skjold", "14", 59.50273, 5.58687);
case 142: return new CityInfo("Skjeberg", "30", 59.21148, 11.19025);
case 143: return new CityInfo("Skjærhalden", "30", 59.02526, 11.03685);
case 144: return new CityInfo("Skien", "38", 59.20962, 9.60897);
case 145: return new CityInfo("Ski", "30", 59.71949, 10.83576);
case 146: return new CityInfo("Skaun", "21", 63.25149, 10.05236);
case 147: return new CityInfo("Skarnes", "34", 60.25391, 11.68485);
case 148: return new CityInfo("Skånevik", "46", 59.73288, 5.93762);
case 149: return new CityInfo("Skaland", "54", 69.44456, 17.29832);
case 150: return new CityInfo("Skage", "21", 64.46747, 11.75643);
case 151: return new CityInfo("Sjøvegan", "54", 68.87363, 17.84706);
case 152: return new CityInfo("Skjønhaug", "30", 59.64069, 11.31591);
case 153: return new CityInfo("Sjøholt", "08", 62.48263, 6.81376);
case 154: return new CityInfo("Sistranda", "21", 63.72523, 8.83318);
case 155: return new CityInfo("Sira", "42", 58.42068, 6.66218);
case 156: return new CityInfo("Siljan", "38", 59.28843, 9.71);
case 157: return new CityInfo("Sigerfjord", "09", 68.64373, 15.51157);
case 158: return new CityInfo("Setermoen", "54", 68.86099, 18.34857);
case 159: return new CityInfo("Sesvoll", "30", 60.25, 11.16667);
case 160: return new CityInfo("Sem", "38", 59.2823, 10.33004);
case 161: return new CityInfo("Selvik", "38", 59.56645, 10.26004);
case 162: return new CityInfo("Seljord", "38", 59.48477, 8.63017);
case 163: return new CityInfo("Selje", "46", 62.0444, 5.34739);
case 164: return new CityInfo("Segalstad", "34", 61.23333, 10.23333);
case 165: return new CityInfo("Sauda", "14", 59.65059, 6.35415);
case 166: return new CityInfo("Sarpsborg", "30", 59.28391, 11.10962);
case 167: return new CityInfo("Sandvika", "21", 64.46377, 13.59125);
case 168: return new CityInfo("Sandvika", "30", 59.89073, 10.52774);
case 169: return new CityInfo("Sandnessjøen", "09", 66.02166, 12.63158);
case 170: return new CityInfo("Sandnes", "14", 58.85244, 5.73521);
case 171: return new CityInfo("Sandeid", "14", 59.54441, 5.86229);
case 172: return new CityInfo("Sandefjord", "38", 59.13118, 10.21665);
case 173: return new CityInfo("Sande", "46", 61.32511, 5.79773);
case 174: return new CityInfo("Sande", "38", 59.58679, 10.20809);
case 175: return new CityInfo("Sandane", "46", 61.77277, 6.21496);
case 176: return new CityInfo("Sand", "34", 60.3922, 11.5403);
case 177: return new CityInfo("Sagvåg", "46", 59.78139, 5.38996);
case 178: return new CityInfo("Sæveland", "14", 59.26667, 5.2);
case 179: return new CityInfo("Sætre", "30", 59.68129, 10.52749);
case 180: return new CityInfo("Sæbøvik", "46", 59.79415, 5.7097);
case 181: return new CityInfo("Rykene", "42", 58.40974, 8.63844);
case 182: return new CityInfo("Rygge", "30", 59.37762, 10.75034);
case 183: return new CityInfo("Rubbestadneset", "46", 59.81559, 5.26822);
case 184: return new CityInfo("Røyrvik", "21", 64.88394, 13.56256);
case 185: return new CityInfo("Røyken", "30", 59.74724, 10.38832);
case 186: return new CityInfo("Roverud", "34", 60.25342, 12.05225);
case 187: return new CityInfo("Rotnes", "30", 60.05707, 10.86135);
case 188: return new CityInfo("Røst", "09", 67.51754, 12.1176);
case 189: return new CityInfo("Rosendal", "46", 59.98589, 6.01157);
case 190: return new CityInfo("Rørvik", "21", 64.86185, 11.23969);
case 191: return new CityInfo("Røros", "21", 62.57468, 11.3842);
case 192: return new CityInfo("Rollag", "30", 59.98431, 9.29644);
case 193: return new CityInfo("Rognan", "09", 67.10021, 15.39086);
case 194: return new CityInfo("Roald", "08", 62.58236, 6.12462);
case 195: return new CityInfo("Roa", "30", 60.29093, 10.61585);
case 196: return new CityInfo("Rjukan", "38", 59.87891, 8.59411);
case 197: return new CityInfo("Risør", "42", 58.72057, 9.23422);
case 198: return new CityInfo("Rindal", "21", 63.05547, 9.21151);
case 199: return new CityInfo("Rena", "34", 61.13222, 11.37156);
case 200: return new CityInfo("Reinsvoll", "34", 60.67977, 10.62175);
case 201: return new CityInfo("Rensvik", "08", 63.09843, 7.82026);
case 202: return new CityInfo("Reine", "09", 67.93249, 13.08955);
case 203: return new CityInfo("Raufoss", "34", 60.72604, 10.6133);
case 204: return new CityInfo("Raudeberg", "46", 61.98501, 5.13796);
case 205: return new CityInfo("Ranemsletta", "21", 64.49447, 11.94912);
case 206: return new CityInfo("Randaberg", "14", 58.99955, 5.61871);
case 207: return new CityInfo("Ramberg", "09", 68.08991, 13.22989);
case 208: return new CityInfo("Rakkestad", "30", 59.42513, 11.34535);
case 209: return new CityInfo("Råholt", "30", 60.27513, 11.17901);
case 210: return new CityInfo("Prestfoss", "30", 60.04343, 9.6352);
case 211: return new CityInfo("Prestestranda", "38", 59.09773, 9.05866);
case 212: return new CityInfo("Porsgrunn", "38", 59.14054, 9.6561);
case 213: return new CityInfo("Øystese", "46", 60.38825, 6.19251);
case 214: return new CityInfo("Farnes", "46", 61.3085, 7.79694);
case 215: return new CityInfo("Otta", "34", 61.7712, 9.53529);
case 216: return new CityInfo("Osøyro", "46", 60.18385, 5.4638);
case 217: return new CityInfo("Oslo", "12", 59.91273, 10.74609);
case 218: return new CityInfo("Os", "34", 62.49647, 11.22326);
case 219: return new CityInfo("Ørnes", "09", 66.86878, 13.70579);
case 220: return new CityInfo("Orkanger", "21", 63.30668, 9.85025);
case 221: return new CityInfo("Ørje", "30", 59.48023, 11.66016);
case 222: return new CityInfo("Oppdal", "21", 62.59431, 9.6912);
case 223: return new CityInfo("Oltedal", "14", 58.8286, 6.03687);
case 224: return new CityInfo("Ølen", "14", 59.60437, 5.80799);
case 225: return new CityInfo("Odda", "46", 60.06912, 6.54565);
case 226: return new CityInfo("Notodden", "38", 59.55936, 9.25853);
case 227: return new CityInfo("Norheimsund", "46", 60.37089, 6.14562);
case 228: return new CityInfo("Noresund", "30", 60.17985, 9.62411);
case 229: return new CityInfo("Nordkisa", "30", 60.18578, 11.26302);
case 230: return new CityInfo("Nordfjordeid", "46", 61.9122, 5.98557);
case 231: return new CityInfo("Nodeland", "42", 58.15517, 7.83576);
case 232: return new CityInfo("Nesna", "09", 66.19817, 13.01844);
case 233: return new CityInfo("Nesbyen", "30", 60.56809, 9.10274);
case 234: return new CityInfo("Naustdal", "46", 61.51108, 5.71694);
case 235: return new CityInfo("Narvik", "09", 68.43838, 17.4272);
case 236: return new CityInfo("Namsskogan", "21", 64.92886, 13.15954);
case 237: return new CityInfo("Namsos", "21", 64.46624, 11.49572);
case 238: return new CityInfo("Nærbø", "14", 58.66546, 5.63788);
case 239: return new CityInfo("Mysen", "30", 59.55354, 11.32578);
case 240: return new CityInfo("Myre", "09", 69.10588, 15.96308);
case 241: return new CityInfo("Myra", "42", 58.74921, 8.86254);
case 242: return new CityInfo("Mosterhamn", "46", 59.69919, 5.38585);
case 243: return new CityInfo("Moss", "30", 59.43403, 10.65771);
case 244: return new CityInfo("Mosjøen", "09", 65.83599, 13.19076);
case 245: return new CityInfo("Moldjord", "09", 67.00601, 14.5743);
case 246: return new CityInfo("Molde", "08", 62.73752, 7.15912);
case 247: return new CityInfo("Fyresdal", "38", 59.18343, 8.0921);
case 248: return new CityInfo("Mo i Rana", "09", 66.31278, 14.14278);
case 249: return new CityInfo("Moi", "14", 58.45674, 6.55184);
case 250: return new CityInfo("Moen", "54", 69.13043, 18.61226);
case 251: return new CityInfo("Moelv", "34", 60.93333, 10.7);
case 252: return new CityInfo("Mo", "46", 60.81625, 5.80575);
case 253: return new CityInfo("Mjøndalen", "30", 59.75075, 10.02477);
case 254: return new CityInfo("Midsund", "08", 62.67387, 6.67412);
case 255: return new CityInfo("Meråker", "21", 63.41406, 11.74298);
case 256: return new CityInfo("Melsomvik", "38", 59.22394, 10.33616);
case 257: return new CityInfo("Melhus", "21", 63.28555, 10.27806);
case 258: return new CityInfo("Melbu", "09", 68.50246, 14.79962);
case 259: return new CityInfo("Maura", "30", 60.2583, 11.03192);
case 260: return new CityInfo("Masfjorden", "46", 60.79887, 5.30418);
case 261: return new CityInfo("Manger", "46", 60.64145, 5.04136);
case 262: return new CityInfo("Mandal", "42", 58.0274, 7.45342);
case 263: return new CityInfo("Malvik", "21", 63.43333, 10.68333);
case 264: return new CityInfo("Måløy", "46", 61.93535, 5.11362);
case 265: return new CityInfo("Malm", "21", 64.07534, 11.22398);
case 266: return new CityInfo("Magnor", "34", 59.95092, 12.20151);
case 267: return new CityInfo("Lysaker", "30", 59.90994, 10.63545);
case 268: return new CityInfo("Lyngdal", "42", 58.1376, 7.07002);
case 269: return new CityInfo("Lunde", "38", 59.29832, 9.10268);
case 270: return new CityInfo("Lundamo", "21", 63.15216, 10.28555);
case 271: return new CityInfo("Løten", "34", 60.81941, 11.34209);
case 272: return new CityInfo("Lørenfallet", "30", 60.01976, 11.23003);
case 273: return new CityInfo("Løpsmarka", "09", 67.31343, 14.44934);
case 274: return new CityInfo("Lonevåg", "46", 60.52556, 5.49563);
case 275: return new CityInfo("Fossbergom", "34", 61.83772, 8.56842);
case 276: return new CityInfo("Løkken Verk", "21", 63.12582, 9.70518);
case 277: return new CityInfo("Løken", "30", 59.79553, 11.46597);
case 278: return new CityInfo("Lofthus", "46", 60.33263, 6.66167);
case 279: return new CityInfo("Lødingen", "09", 68.41373, 15.99626);
case 280: return new CityInfo("Løding", "09", 67.30055, 14.73852);
case 281: return new CityInfo("Lindeberg", "30", 60.03831, 11.12421);
case 282: return new CityInfo("Lindås", "46", 60.73639, 5.16102);
case 283: return new CityInfo("Lillestrøm", "30", 59.95597, 11.04918);
case 284: return new CityInfo("Lillesand", "42", 58.24879, 8.3778);
case 285: return new CityInfo("Lillehammer", "34", 61.11514, 10.46628);
case 286: return new CityInfo("Liknes", "42", 58.31216, 6.9618);
case 287: return new CityInfo("Levanger", "21", 63.74644, 11.29963);
case 288: return new CityInfo("Lervik", "30", 59.27119, 10.7461);
case 289: return new CityInfo("Lensvik", "21", 63.51389, 9.80611);
case 290: return new CityInfo("Lena", "34", 60.67391, 10.81317);
case 291: return new CityInfo("Leland", "09", 66.06406, 12.94325);
case 292: return new CityInfo("Leknes", "21", 65.1, 11.7);
case 293: return new CityInfo("Leirvik", "46", 59.77977, 5.50051);
case 294: return new CityInfo("Leirsund", "30", 59.99682, 11.08746);
case 295: return new CityInfo("Leira", "34", 60.97006, 9.29488);
case 296: return new CityInfo("Lauvsnes", "21", 64.50061, 10.89396);
case 297: return new CityInfo("Larvik", "38", 59.05328, 10.03517);
case 298: return new CityInfo("Larsnes", "08", 62.20282, 5.57729);
case 299: return new CityInfo("Larkollen", "30", 59.33196, 10.66687);
case 300: return new CityInfo("Langevåg", "08", 62.44085, 6.19137);
case 301: return new CityInfo("Langevåg", "46", 59.60726, 5.2343);
case 302: return new CityInfo("Langesund", "38", 59.00071, 9.74876);
case 303: return new CityInfo("Langangen", "38", 59.08769, 9.8046);
case 304: return new CityInfo("Lærdalsøyri", "46", 61.10001, 7.47374);
case 305: return new CityInfo("Kyrksæterøra", "21", 63.29057, 9.08909);
case 306: return new CityInfo("Kviteseid", "38", 59.40223, 8.49267);
case 307: return new CityInfo("Kvelde", "38", 59.19241, 9.96886);
case 308: return new CityInfo("Kvam", "34", 61.665, 9.68773);
case 309: return new CityInfo("Krokstadøra", "21", 63.40099, 9.50062);
case 310: return new CityInfo("Kristiansund", "08", 63.11045, 7.72795);
case 311: return new CityInfo("Kristiansand", "42", 58.14671, 7.9956);
case 312: return new CityInfo("Kragerø", "38", 58.8693, 9.41494);
case 313: return new CityInfo("Korgen", "09", 66.07662, 13.8216);
case 314: return new CityInfo("Koppang", "34", 61.57219, 11.04659);
case 315: return new CityInfo("Kopervik", "14", 59.28354, 5.30669);
case 316: return new CityInfo("Konsmo", "42", 58.28529, 7.35598);
case 317: return new CityInfo("Kongsvinger", "34", 60.19049, 11.99772);
case 318: return new CityInfo("Kongsberg", "30", 59.66858, 9.65017);
case 319: return new CityInfo("Kolvereid", "21", 64.86549, 11.60465);
case 320: return new CityInfo("Kolbu", "34", 60.65033, 10.74489);
case 321: return new CityInfo("Kolbotn", "30", 59.81056, 10.80389);
case 322: return new CityInfo("Knarvik", "46", 60.5453, 5.28208);
case 323: return new CityInfo("Knappstad", "30", 59.62424, 11.03274);
case 324: return new CityInfo("Knappskog", "46", 60.37906, 5.05602);
case 325: return new CityInfo("Kløfta", "30", 60.07407, 11.13805);
case 326: return new CityInfo("Kleppestø", "46", 60.40844, 5.2276);
case 327: return new CityInfo("Kjøpsvik", "09", 68.09696, 16.37416);
case 328: return new CityInfo("Kirkenær", "34", 60.4579, 12.05855);
case 329: return new CityInfo("Kil", "38", 58.89159, 9.30078);
case 330: return new CityInfo("Kaupanger", "46", 61.18453, 7.24252);
case 331: return new CityInfo("Karlshus", "30", 59.35195, 10.87226);
case 332: return new CityInfo("Kabelvåg", "09", 68.21066, 14.47554);
case 333: return new CityInfo("Judaberg", "14", 59.17204, 5.87617);
case 334: return new CityInfo("Jørpeland", "14", 59.02251, 6.04078);
case 335: return new CityInfo("Jordtveit", "42", 58.27186, 8.50675);
case 336: return new CityInfo("Jondal", "46", 60.27561, 6.25229);
case 337: return new CityInfo("Jevnaker", "30", 60.23979, 10.38709);
case 338: return new CityInfo("Jessheim", "30", 60.14151, 11.17515);
case 339: return new CityInfo("Jaren", "34", 60.39273, 10.56155);
case 340: return new CityInfo("Ise", "30", 59.30038, 11.2205);
case 341: return new CityInfo("Isdalstø", "46", 60.55519, 5.26942);
case 342: return new CityInfo("Inndyr", "09", 67.03353, 14.02663);
case 343: return new CityInfo("Ilseng", "34", 60.7757, 11.22725);
case 344: return new CityInfo("Ikornnes", "08", 62.38631, 6.55094);
case 345: return new CityInfo("Hyllestad", "46", 61.17109, 5.29603);
case 346: return new CityInfo("Hylkje", "46", 60.51028, 5.35444);
case 347: return new CityInfo("Hvittingfoss", "30", 59.48572, 10.01173);
case 348: return new CityInfo("Hundorp", "34", 61.55523, 9.94069);
case 349: return new CityInfo("Høyanger", "46", 61.22348, 6.08471);
case 350: return new CityInfo("Hovin", "21", 63.10552, 10.22378);
case 351: return new CityInfo("Hovden", "42", 59.56045, 7.3567);
case 352: return new CityInfo("Hov", "34", 60.6987, 10.35193);
case 353: return new CityInfo("Horten", "38", 59.41721, 10.48343);
case 354: return new CityInfo("Hopen", "08", 63.46539, 8.01437);
case 355: return new CityInfo("Hønefoss", "30", 60.16804, 10.25647);
case 356: return new CityInfo("Hommelvik", "21", 63.41083, 10.79424);
case 357: return new CityInfo("Holmestrand", "38", 59.48761, 10.31761);
case 358: return new CityInfo("Holme", "46", 59.65139, 5.16139);
case 359: return new CityInfo("Hol", "54", 68.54902, 16.39218);
case 360: return new CityInfo("Hokksund", "30", 59.77077, 9.90987);
case 361: return new CityInfo("Hof", "34", 60.55281, 12.02192);
case 362: return new CityInfo("Hjelset", "08", 62.7805, 7.49277);
case 363: return new CityInfo("Herre", "38", 59.10351, 9.56195);
case 364: return new CityInfo("Hermansverk", "46", 61.18461, 6.85016);
case 365: return new CityInfo("Hemsedal", "30", 60.86293, 8.55337);
case 366: return new CityInfo("Hemnesberget", "09", 66.22489, 13.61643);
case 367: return new CityInfo("Hemnes", "30", 59.72085, 11.45524);
case 368: return new CityInfo("Hellvik", "14", 58.47818, 5.8782);
case 369: return new CityInfo("Hell", "21", 63.44582, 10.90093);
case 370: return new CityInfo("Heiås", "30", 59.69973, 11.29813);
case 371: return new CityInfo("Hegra", "21", 63.46384, 11.11516);
case 372: return new CityInfo("Heggenes", "34", 61.14383, 9.06942);
case 373: return new CityInfo("Hauknes", "09", 66.28333, 14.06667);
case 374: return new CityInfo("Haugesund", "14", 59.41378, 5.268);
case 375: return new CityInfo("Hauge i Dalane", "14", 58.34361, 6.28121);
case 376: return new CityInfo("Harstad", "54", 68.79833, 16.54165);
case 377: return new CityInfo("Hareid", "08", 62.37041, 6.02902);
case 378: return new CityInfo("Hardbakke", "46", 61.07562, 4.84111);
case 379: return new CityInfo("Hansnes", "54", 69.96701, 19.62752);
case 380: return new CityInfo("Hamnvik", "54", 68.77927, 17.17179);
case 381: return new CityInfo("Hamar", "34", 60.7945, 11.06798);
case 382: return new CityInfo("Hallingby", "30", 60.27143, 10.18451);
case 383: return new CityInfo("Halden", "30", 59.12478, 11.38754);
case 384: return new CityInfo("Ginnasluokta", "09", 68.40521, 17.30832);
case 385: return new CityInfo("Hagavik", "46", 60.18076, 5.40146);
case 386: return new CityInfo("Indra Haga", "46", 60.38778, 5.77056);
case 387: return new CityInfo("Gvarv", "38", 59.38767, 9.1724);
case 388: return new CityInfo("Gullhaug", "38", 59.5013, 10.25224);
case 389: return new CityInfo("Gryllefjord", "54", 69.36304, 17.05284);
case 390: return new CityInfo("Grua", "30", 60.25701, 10.66222);
case 391: return new CityInfo("Grong", "21", 64.46459, 12.31601);
case 392: return new CityInfo("Grøa", "08", 62.64385, 8.72465);
case 393: return new CityInfo("Grimstad", "42", 58.3405, 8.59343);
case 394: return new CityInfo("Gravdal", "09", 68.11832, 13.55339);
case 395: return new CityInfo("Gratangen", "54", 68.65, 17.68333);
case 396: return new CityInfo("Granvin", "46", 60.52408, 6.7194);
case 397: return new CityInfo("Gol", "30", 60.7014, 8.94572);
case 398: return new CityInfo("Glomfjord", "09", 66.81663, 13.94404);
case 399: return new CityInfo("Gladstad", "09", 65.67683, 11.96218);
case 400: return new CityInfo("Justvik", "42", 58.19691, 8.03107);
case 401: return new CityInfo("Gjøvik", "34", 60.79574, 10.69155);
case 402: return new CityInfo("Gjerstad", "42", 58.88083, 9.01861);
case 403: return new CityInfo("Giskemo", "08", 62.48333, 6.86667);
case 404: return new CityInfo("Geilo", "30", 60.53369, 8.20539);
case 405: return new CityInfo("Frogner", "30", 60.02463, 11.10284);
case 406: return new CityInfo("Frekhaug", "46", 60.51321, 5.24252);
case 407: return new CityInfo("Fredrikstad", "30", 59.2181, 10.9298);
case 408: return new CityInfo("Forset", "34", 61.20213, 10.14384);
case 409: return new CityInfo("Fosser", "30", 59.81984, 11.48657);
case 410: return new CityInfo("Fossby", "30", 59.22218, 11.69928);
case 411: return new CityInfo("Fosnavåg", "08", 62.34194, 5.63396);
case 412: return new CityInfo("Førde", "46", 61.45217, 5.85717);
case 413: return new CityInfo("Follebu", "34", 61.21581, 10.28498);
case 414: return new CityInfo("Folldal", "34", 62.13246, 9.9968);
case 415: return new CityInfo("Florø", "46", 61.59957, 5.0328);
case 416: return new CityInfo("Flekkefjord", "42", 58.29705, 6.66069);
case 417: return new CityInfo("Flateby", "30", 59.82951, 11.15345);
case 418: return new CityInfo("Flå", "30", 60.43021, 9.46197);
case 419: return new CityInfo("Fjellstrand", "30", 59.79414, 10.60691);
case 420: return new CityInfo("Fitjar", "46", 59.91803, 5.31674);
case 421: return new CityInfo("Finnsnes", "54", 69.22959, 17.98114);
case 422: return new CityInfo("Fillan", "21", 63.60638, 8.96961);
case 423: return new CityInfo("Fevik", "42", 58.3782, 8.67601);
case 424: return new CityInfo("Fetsund", "30", 59.92463, 11.15711);
case 425: return new CityInfo("Fedje", "46", 60.7789, 4.71485);
case 426: return new CityInfo("Fauske", "09", 67.25883, 15.39181);
case 427: return new CityInfo("Farsund", "42", 58.09479, 6.80468);
case 428: return new CityInfo("Fagerstrand", "30", 59.73746, 10.59404);
case 429: return new CityInfo("Fagernes", "34", 60.98584, 9.23236);
case 430: return new CityInfo("Evjen", "09", 68.26667, 13.73333);
case 431: return new CityInfo("Evje", "42", 58.58569, 7.80363);
case 432: return new CityInfo("Evenskjer", "54", 68.58283, 16.57203);
case 433: return new CityInfo("Etne", "46", 59.66528, 5.93708);
case 434: return new CityInfo("Espeland", "46", 60.38249, 5.4657);
case 435: return new CityInfo("Elverum", "34", 60.88191, 11.56231);
case 436: return new CityInfo("Eivindvik", "46", 60.98133, 5.07497);
case 437: return new CityInfo("Eina", "34", 60.62864, 10.59863);
case 438: return new CityInfo("Eikelandsosen", "46", 60.24175, 5.74433);
case 439: return new CityInfo("Eike", "14", 59.39833, 5.36389);
case 440: return new CityInfo("Eidsvoll", "30", 60.3311, 11.26264);
case 441: return new CityInfo("Eidsvåg", "08", 62.77656, 8.0655);
case 442: return new CityInfo("Eidfjord", "46", 60.4675, 7.07193);
case 443: return new CityInfo("Eide", "08", 62.91735, 7.44669);
case 444: return new CityInfo("Egersund", "14", 58.45133, 5.9997);
case 445: return new CityInfo("Drøbak", "30", 59.66333, 10.62975);
case 446: return new CityInfo("Drammen", "30", 59.74389, 10.20449);
case 447: return new CityInfo("Dovre", "34", 61.9875, 9.25556);
case 448: return new CityInfo("Dombås", "34", 62.07554, 9.12785);
case 449: return new CityInfo("Dokka", "34", 60.835, 10.07362);
case 450: return new CityInfo("Dalen", "38", 59.44499, 8.00492);
case 451: return new CityInfo("Dale", "34", 61.77534, 9.49454);
case 452: return new CityInfo("Dale", "46", 61.36353, 5.40036);
case 453: return new CityInfo("Dale", "46", 60.58639, 5.81888);
case 454: return new CityInfo("Bygland", "42", 58.8285, 7.79616);
case 455: return new CityInfo("Bud", "08", 62.90706, 6.91409);
case 456: return new CityInfo("Bryne", "14", 58.73536, 5.64766);
case 457: return new CityInfo("Brumunddal", "34", 60.88095, 10.93948);
case 458: return new CityInfo("Bruflat", "34", 60.88781, 9.64143);
case 459: return new CityInfo("Brønnøysund", "09", 65.47487, 12.21285);
case 460: return new CityInfo("Svortland", "46", 59.79284, 5.17226);
case 461: return new CityInfo("Brekstad", "21", 63.68697, 9.66541);
case 462: return new CityInfo("Brattvåg", "08", 62.59991, 6.44426);
case 463: return new CityInfo("Botngård", "21", 63.76484, 9.80863);
case 464: return new CityInfo("Borkenes", "54", 68.77261, 16.17115);
case 465: return new CityInfo("Børgen", "30", 60.09394, 11.21292);
case 466: return new CityInfo("Bogen", "09", 68.52647, 16.9928);
case 467: return new CityInfo("Bodø", "09", 67.28, 14.40501);
case 468: return new CityInfo("Bø", "38", 59.41299, 9.0693);
case 469: return new CityInfo("Blakstad", "30", 59.8191, 10.4645);
case 470: return new CityInfo("Bjørkelangen", "30", 59.88357, 11.56396);
case 471: return new CityInfo("Bjerkvik", "09", 68.54917, 17.55709);
case 472: return new CityInfo("Bismoen", "34", 61.88333, 8.26667);
case 473: return new CityInfo("Birkeland", "42", 58.33091, 8.23229);
case 474: return new CityInfo("Berkåk", "21", 62.82496, 10.01177);
case 475: return new CityInfo("Berger", "30", 59.54994, 10.38641);
case 476: return new CityInfo("Bergen", "46", 60.39299, 5.32415);
case 477: return new CityInfo("Beisfjord", "09", 68.37618, 17.59596);
case 478: return new CityInfo("Batnfjordsøra", "08", 62.89463, 7.67251);
case 479: return new CityInfo("Barkåker", "38", 59.31859, 10.38963);
case 480: return new CityInfo("Bangsund", "21", 64.39232, 11.39688);
case 481: return new CityInfo("Ballstad", "09", 68.07431, 13.54515);
case 482: return new CityInfo("Ballangen", "09", 68.34283, 16.83145);
case 483: return new CityInfo("Balestrand", "46", 61.20962, 6.53608);
case 484: return new CityInfo("Bagn", "34", 60.82249, 9.55207);
case 485: return new CityInfo("Austrheim", "46", 60.7774, 4.9323);
case 486: return new CityInfo("Aursmoen", "30", 59.92763, 11.44275);
case 487: return new CityInfo("Aure", "08", 63.2679, 8.52913);
case 488: return new CityInfo("Aurdal", "34", 60.92443, 9.41488);
case 489: return new CityInfo("Auli", "30", 60.0345, 11.36046);
case 490: return new CityInfo("Aukra", "08", 62.78333, 6.9);
case 491: return new CityInfo("Askim", "30", 59.58326, 11.16286);
case 492: return new CityInfo("Asker", "30", 59.83333, 10.43721);
case 493: return new CityInfo("Ask", "30", 60.07131, 11.0362);
case 494: return new CityInfo("Åsgårdstrand", "38", 59.34938, 10.46948);
case 495: return new CityInfo("Aas", "21", 63.05, 11.65);
case 496: return new CityInfo("Ås", "30", 59.66472, 10.79465);
case 497: return new CityInfo("Åros", "30", 59.7061, 10.51092);
case 498: return new CityInfo("Årnes", "21", 63.96114, 10.22601);
case 499: return new CityInfo("Årnes", "30", 60.12237, 11.47005);
case 500: return new CityInfo("Indre Arna", "46", 60.41768, 5.47087);
case 501: return new CityInfo("Arendal", "42", 58.46151, 8.77253);
case 502: return new CityInfo("Årdalstangen", "46", 61.23581, 7.7037);
case 503: return new CityInfo("Åneby", "30", 60.08926, 10.86998);
case 504: return new CityInfo("Andselv", "54", 69.06554, 18.51552);
case 505: return new CityInfo("Andenes", "09", 69.31428, 16.11939);
case 506: return new CityInfo("Åndalsnes", "08", 62.56749, 7.68709);
case 507: return new CityInfo("Åmot", "38", 59.63333, 8.36667);
case 508: return new CityInfo("Åmot", "38", 59.56974, 7.98871);
case 509: return new CityInfo("Åmli", "42", 58.76566, 8.48392);
case 510: return new CityInfo("Indre Ålvik", "46", 60.43274, 6.43164);
case 511: return new CityInfo("Alvdal", "34", 62.10766, 10.63073);
case 512: return new CityInfo("Ålgård", "14", 58.76417, 5.85253);
case 513: return new CityInfo("Ålesund", "08", 62.47225, 6.15492);
case 514: return new CityInfo("Ålen", "21", 62.84185, 11.3013);
case 515: return new CityInfo("Ål", "30", 60.63024, 8.56071);
case 516: return new CityInfo("Åkrehamn", "14", 59.26053, 5.18689);
case 517: return new CityInfo("Ågotnes", "46", 60.40306, 5.01927);
case 518: return new CityInfo("Ådalsbruk", "34", 60.79653, 11.30883);
case 519: return new CityInfo("Å i Åfjord", "21", 63.96068, 10.22468);
case 520: return new CityInfo("Vormedal", "14", 59.35607, 5.31962);
case 521: return new CityInfo("Klokkarvik", "46", 60.22474, 5.15093);
case 522: return new CityInfo("Tingvoll", "08", 62.91318, 8.20526);
case 523: return new CityInfo("Oppeid", "09", 68.08522, 15.60942);
case 524: return new CityInfo("Hommersåk", "14", 58.92556, 5.85104);
case 525: return new CityInfo("Vikevåg", "14", 59.09754, 5.6979);
case 526: return new CityInfo("Årøysund", "38", 59.18321, 10.45743);
case 527: return new CityInfo("Nykirke", "38", 59.42278, 10.38417);
case 528: return new CityInfo("Myre", "09", 68.914, 15.07843);
case 529: return new CityInfo("Årås", "46", 60.77741, 4.93274);
case 530: return new CityInfo("Nesoddtangen", "30", 59.86244, 10.66308);
case 531: return new CityInfo("Askøy", "46", 60.4, 5.18333);
case 532: return new CityInfo("Ørsta", "08", 62.19983, 6.12904);
case 533: return new CityInfo("Ryggebyen", "30", 59.375, 10.75);
case 534: return new CityInfo("Vedavågen", "14", 59.29483, 5.21874);
case 535: return new CityInfo("Vestnes", "08", 62.62544, 7.08696);
case 536: return new CityInfo("Fjellfoten", "30", 60.08967, 11.47222);
case 537: return new CityInfo("Haga", "30", 60.05387, 11.37411);
case 538: return new CityInfo("Tomteråsen", "30", 60.10696, 11.3687);
case 539: return new CityInfo("Neskollen", "30", 60.12159, 11.33926);
case 540: return new CityInfo("Kinsarvik", "46", 60.37567, 6.71948);
case 541: return new CityInfo("Sjølyststranda", "12", 59.92105, 10.68017);
case 542: return new CityInfo("Skei", "46", 61.5715, 6.4791);
case 543: return new CityInfo("Ytrebygda", "46", 60.30504, 5.28236);
case 544: return new CityInfo("Sandsli", "46", 60.30323, 5.28554);
case 545: return new CityInfo("Stjørdal", "21", 63.46803, 10.91776);
case 546: return new CityInfo("Frosta", "21", 63.5891, 10.7423);
case 547: return new CityInfo("Vik", "46", 61.05712, 6.57806);
case 548: return new CityInfo("Sogndal", "46", 61.22908, 7.09674);
case 549: return new CityInfo("Rømskog", "30", 59.7497, 11.8112);
case 550: return new CityInfo("Meieribyen", "30", 59.47453, 11.16083);
case 551: return new CityInfo("Kirkebygda", "30", 59.4921, 10.87432);
case 552: return new CityInfo("Elvestad", "30", 59.62401, 10.9508);
case 553: return new CityInfo("Forsand", "14", 58.9033, 6.1048);
case 554: return new CityInfo("Fjerdingby", "30", 59.92626, 11.06527);
case 555: return new CityInfo("Kirkebygda", "30", 59.76452, 11.14492);
case 556: return new CityInfo("Kjenn", "30", 59.93098, 10.95373);
case 557: return new CityInfo("Teigebyen", "30", 60.22069, 11.0176);
case 558: return new CityInfo("Hurdal", "30", 60.43518, 11.06707);
case 559: return new CityInfo("Flisa", "34", 60.61318, 12.01088);
case 560: return new CityInfo("Bergset", "34", 61.89126, 11.07769);
case 561: return new CityInfo("Engerdal", "34", 61.75904, 11.95937);
case 562: return new CityInfo("Lesja", "34", 62.11837, 8.86424);
case 563: return new CityInfo("Bismo", "34", 61.88406, 8.26665);
case 564: return new CityInfo("Ringebu", "34", 61.52965, 10.13889);
case 565: return new CityInfo("Segalstad bru", "34", 61.22819, 10.22255);
case 566: return new CityInfo("Slidre", "34", 61.08802, 8.98141);
case 567: return new CityInfo("Vang", "34", 61.12529, 8.5729);
case 568: return new CityInfo("Vik", "30", 60.07706, 10.27908);
case 569: return new CityInfo("Trøim", "30", 60.86114, 8.56537);
case 570: return new CityInfo("Hol", "30", 60.61511, 8.29398);
case 571: return new CityInfo("Lierbyen", "30", 59.78651, 10.24447);
case 572: return new CityInfo("Lampeland", "30", 59.83486, 9.57912);
case 573: return new CityInfo("Rødberg", "30", 60.26722, 8.94721);
case 574: return new CityInfo("Revetal", "38", 59.3724, 10.26308);
case 575: return new CityInfo("Andebu", "38", 59.30592, 10.17653);
case 576: return new CityInfo("Borgheim", "38", 59.22629, 10.40745);
case 577: return new CityInfo("Sauland", "38", 59.6161, 8.93755);
case 578: return new CityInfo("Blakstad", "42", 58.5046, 8.64648);
case 579: return new CityInfo("Birketveit", "42", 58.45909, 7.91692);
case 580: return new CityInfo("Helland", "42", 58.19344, 7.52431);
case 581: return new CityInfo("Kyrkjebygda", "42", 58.61523, 7.41391);
case 582: return new CityInfo("Kleppe", "14", 58.77423, 5.62936);
case 583: return new CityInfo("Hjelmelandsvågen", "14", 59.23692, 6.17907);
case 584: return new CityInfo("Sand", "14", 59.48468, 6.25109);
case 585: return new CityInfo("Ydstebøhamn", "14", 59.06227, 5.40249);
case 586: return new CityInfo("Bokn", "14", 59.23062, 5.43524);
case 587: return new CityInfo("Aksdal", "14", 59.42408, 5.44553);
case 588: return new CityInfo("Skogsvågen", "46", 60.25512, 5.10161);
case 589: return new CityInfo("Straume", "46", 60.36131, 5.12199);
case 590: return new CityInfo("Aurlandsvangen", "46", 60.90578, 7.18706);
case 591: return new CityInfo("Gaupne", "46", 61.40472, 7.29458);
case 592: return new CityInfo("Askvoll", "46", 61.34673, 5.06224);
case 593: return new CityInfo("Hornindal", "08", 61.96921, 6.52418);
case 594: return new CityInfo("Fiskå", "08", 62.10059, 5.55788);
case 595: return new CityInfo("Stordal", "08", 62.38203, 6.98629);
case 596: return new CityInfo("Sykkylven", "08", 62.39594, 6.5875);
case 597: return new CityInfo("Valderøy", "08", 62.5007, 6.13472);
case 598: return new CityInfo("Falkhytta", "08", 62.805, 6.88722);
case 599: return new CityInfo("Elnesvågen", "08", 62.85426, 7.13769);
case 600: return new CityInfo("Bruhagen", "08", 63.05259, 7.63416);
case 601: return new CityInfo("Surnadal", "08", 62.97397, 8.72472);
case 602: return new CityInfo("Liabøen", "21", 63.12249, 8.31587);
case 603: return new CityInfo("Rissa", "21", 63.58368, 9.95989);
case 604: return new CityInfo("Roan", "21", 64.17269, 10.22898);
case 605: return new CityInfo("Steinsdalen", "21", 64.29875, 10.51284);
case 606: return new CityInfo("Meldal", "21", 63.04721, 9.71337);
case 607: return new CityInfo("Støren", "21", 63.0391, 10.28501);
case 608: return new CityInfo("Børsa", "21", 63.32672, 10.0692);
case 609: return new CityInfo("Klæbu", "21", 63.29762, 10.48261);
case 610: return new CityInfo("Mebonden", "21", 63.23034, 11.03099);
case 611: return new CityInfo("Leksvik", "21", 63.67274, 10.6232);
case 612: return new CityInfo("Namdalseid", "21", 64.22186, 11.22319);
case 613: return new CityInfo("Høylandet", "21", 64.62887, 12.30206);
case 614: return new CityInfo("Jøa", "21", 64.6591, 11.26535);
case 615: return new CityInfo("Silvalen", "09", 65.9832, 12.28856);
case 616: return new CityInfo("Hattfjelldal", "09", 65.59736, 13.98791);
case 617: return new CityInfo("Lurøy", "09", 66.41887, 12.84248);
case 618: return new CityInfo("Husøya", "09", 66.50159, 12.09645);
case 619: return new CityInfo("Vågaholmen", "09", 66.71367, 13.28711);
case 620: return new CityInfo("Leinesfjorden", "09", 67.77548, 15.01545);
case 621: return new CityInfo("Leknes", "09", 68.14746, 13.61151);
case 622: return new CityInfo("Tennevoll", "54", 68.7471, 17.80621);
case 623: return new CityInfo("Sørreisa", "54", 69.14527, 18.15292);
case 624: return new CityInfo("Brøstadbotn", "54", 69.08873, 17.69489);
case 625: return new CityInfo("Hatteng", "54", 69.27072, 19.95944);
case 626: return new CityInfo("Breivikbotn", "54", 70.58877, 22.28712);
case 627: return new CityInfo("Tana bru", "54", 70.19909, 28.19039);
case 628: return new CityInfo("Ulsteinvik weather pws station", "08", 62.34338, 5.84385);
case 629: return new CityInfo("Billingstad", "30", 59.87548, 10.4823);
case 630: return new CityInfo("Spangereid", "42", 58.04634, 7.14143);
case 631: return new CityInfo("Nordstranda", "08", 62.51384, 6.13166);
default: return new CityInfo("Lyefjell", "14", 58.73539, 5.73615);

                                    }                                        
                                }
                            
                        }
                    }
                