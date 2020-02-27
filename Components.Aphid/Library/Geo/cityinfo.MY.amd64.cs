
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
                                    public const string Country = "MY";
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
                            
                                        var cur = (Math.Abs(6.35423 - lat) + Math.Abs(99.73404 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(6.42062 - lat) + Math.Abs(99.82199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.32649 - lat) + Math.Abs(99.8432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.936 - lat) + Math.Abs(102.3626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.7899 - lat) + Math.Abs(101.857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.8548 - lat) + Math.Abs(102.9325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.8681 - lat) + Math.Abs(103.1124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.51 - lat) + Math.Abs(103.5141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.4866 - lat) + Math.Abs(103.3896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.4726 - lat) + Math.Abs(103.878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.7381 - lat) + Math.Abs(103.8999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6006 - lat) + Math.Abs(103.6419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6561 - lat) + Math.Abs(103.6032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.53741 - lat) + Math.Abs(103.65779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.4655 - lat) + Math.Abs(103.7578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.03046 - lat) + Math.Abs(103.31689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0136 - lat) + Math.Abs(103.0659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.4312 - lat) + Math.Abs(103.8405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.5148 - lat) + Math.Abs(102.8158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2673 - lat) + Math.Abs(102.5453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0442 - lat) + Math.Abs(102.5689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0441 - lat) + Math.Abs(102.6527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.385 - lat) + Math.Abs(103.021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.249 - lat) + Math.Abs(103.048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.35 - lat) + Math.Abs(101.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.38333 - lat) + Math.Abs(101.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.31667 - lat) + Math.Abs(101.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.08507 - lat) + Math.Abs(101.53281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.03667 - lat) + Math.Abs(101.44333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25 - lat) + Math.Abs(103.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.1842 - lat) + Math.Abs(102.0468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73333 - lat) + Math.Abs(115.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9749 - lat) + Math.Abs(116.0724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.90702 - lat) + Math.Abs(116.10146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9258 - lat) + Math.Abs(116.06094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8231 - lat) + Math.Abs(116.0466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9538 - lat) + Math.Abs(116.6641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.48178 - lat) + Math.Abs(118.61119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28028 - lat) + Math.Abs(115.2475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3473 - lat) + Math.Abs(115.7455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02298 - lat) + Math.Abs(118.32897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8402 - lat) + Math.Abs(118.1179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3378 - lat) + Math.Abs(116.1602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.24482 - lat) + Math.Abs(117.89115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6374 - lat) + Math.Abs(103.4368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.5141 - lat) + Math.Abs(103.4483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.36499 - lat) + Math.Abs(100.56177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.0108 - lat) + Math.Abs(100.54101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72743 - lat) + Math.Abs(100.50876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95 - lat) + Math.Abs(100.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.85 - lat) + Math.Abs(100.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.76667 - lat) + Math.Abs(100.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.5841 - lat) + Math.Abs(101.0829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88441 - lat) + Math.Abs(101.96857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3302 - lat) + Math.Abs(103.1408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.2056 - lat) + Math.Abs(103.2059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.4701 - lat) + Math.Abs(102.2302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.3804 - lat) + Math.Abs(102.2089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2654 - lat) + Math.Abs(102.2801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.269 - lat) + Math.Abs(102.1427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.196 - lat) + Math.Abs(102.2405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.99959 - lat) + Math.Abs(101.39287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8136 - lat) + Math.Abs(101.50185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8724 - lat) + Math.Abs(101.49484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.9516 - lat) + Math.Abs(101.843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.7297 - lat) + Math.Abs(101.9381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.53718 - lat) + Math.Abs(101.80571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.6931 - lat) + Math.Abs(101.7498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8079 - lat) + Math.Abs(102.4049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.7389 - lat) + Math.Abs(102.2487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.5536 - lat) + Math.Abs(102.764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8147 - lat) + Math.Abs(104.1592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.4836 - lat) + Math.Abs(103.3996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.4854 - lat) + Math.Abs(102.3484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.4506 - lat) + Math.Abs(102.4176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4709 - lat) + Math.Abs(100.24529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3991 - lat) + Math.Abs(100.36382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38333 - lat) + Math.Abs(100.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.36301 - lat) + Math.Abs(100.4667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16586 - lat) + Math.Abs(100.47793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.12671 - lat) + Math.Abs(100.49316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.48032 - lat) + Math.Abs(100.49849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.41123 - lat) + Math.Abs(100.33543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.34944 - lat) + Math.Abs(101.82631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.3646 - lat) + Math.Abs(101.6041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.3213 - lat) + Math.Abs(101.5767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.10726 - lat) + Math.Abs(101.60671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.1412 - lat) + Math.Abs(101.68653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.15 - lat) + Math.Abs(101.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.7698 - lat) + Math.Abs(100.9879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.6746 - lat) + Math.Abs(100.9867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.8077 - lat) + Math.Abs(103.326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.46361 - lat) + Math.Abs(101.3763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.46916 - lat) + Math.Abs(101.04107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.3 - lat) + Math.Abs(101.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.16667 - lat) + Math.Abs(101.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.11667 - lat) + Math.Abs(101.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.89435 - lat) + Math.Abs(112.09145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.2323 - lat) + Math.Abs(100.6298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.02219 - lat) + Math.Abs(101.02083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.81717 - lat) + Math.Abs(100.47381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.647 - lat) + Math.Abs(100.48772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51707 - lat) + Math.Abs(100.4265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.95701 - lat) + Math.Abs(102.24817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87133 - lat) + Math.Abs(102.23177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8 - lat) + Math.Abs(102.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.55 - lat) + Math.Abs(110.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.24722 - lat) + Math.Abs(111.45278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.11667 - lat) + Math.Abs(111.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.3 - lat) + Math.Abs(111.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4414 - lat) + Math.Abs(100.19862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4 - lat) + Math.Abs(100.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26812 - lat) + Math.Abs(100.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1 - lat) + Math.Abs(100.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.12104 - lat) + Math.Abs(100.36014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.19775 - lat) + Math.Abs(102.17098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04934 - lat) + Math.Abs(102.13987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.12361 - lat) + Math.Abs(102.24333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.83303 - lat) + Math.Abs(102.55514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.7336 - lat) + Math.Abs(102.4897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88732 - lat) + Math.Abs(116.82364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.351 - lat) + Math.Abs(116.4305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.99546 - lat) + Math.Abs(112.93254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.8 - lat) + Math.Abs(113.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.16667 - lat) + Math.Abs(113.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.8604 - lat) + Math.Abs(115.409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.75 - lat) + Math.Abs(115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.18333 - lat) + Math.Abs(114.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.39928 - lat) + Math.Abs(113.99163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6 - lat) + Math.Abs(103.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46667 - lat) + Math.Abs(100.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46061 - lat) + Math.Abs(100.30742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.6579 - lat) + Math.Abs(101.5629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.65 - lat) + Math.Abs(101.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.455 - lat) + Math.Abs(102.2329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46339 - lat) + Math.Abs(100.38144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03333 - lat) + Math.Abs(102.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.2856 - lat) + Math.Abs(101.519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4557 - lat) + Math.Abs(100.6288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.2594 - lat) + Math.Abs(101.5541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.3594 - lat) + Math.Abs(102.0353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2186 - lat) + Math.Abs(102.1995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6698 - lat) + Math.Abs(103.5327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.4242 - lat) + Math.Abs(101.1849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.32699 - lat) + Math.Abs(100.27348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.8278 - lat) + Math.Abs(103.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91667 - lat) + Math.Abs(102.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.35 - lat) + Math.Abs(102.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6 - lat) + Math.Abs(102.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.21667 - lat) + Math.Abs(101.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2152 - lat) + Math.Abs(102.2851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46948 - lat) + Math.Abs(100.24449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.15 - lat) + Math.Abs(101.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8033 - lat) + Math.Abs(101.7972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.03333 - lat) + Math.Abs(101.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2139 - lat) + Math.Abs(102.3278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.31201 - lat) + Math.Abs(100.44229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2594 - lat) + Math.Abs(102.1838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52229 - lat) + Math.Abs(101.90866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2684 - lat) + Math.Abs(102.3746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2487 - lat) + Math.Abs(102.246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.01667 - lat) + Math.Abs(101.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88434 - lat) + Math.Abs(116.09319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.93527 - lat) + Math.Abs(101.69112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4055 - lat) + Math.Abs(99.8502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36257 - lat) + Math.Abs(99.7832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36759 - lat) + Math.Abs(99.68252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36377 - lat) + Math.Abs(99.71532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.83297 - lat) + Math.Abs(102.55061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03021 - lat) + Math.Abs(102.14126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28883 - lat) + Math.Abs(115.26924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.65465 - lat) + Math.Abs(113.62249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.04384 - lat) + Math.Abs(101.58062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89477 - lat) + Math.Abs(118.04576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.64848 - lat) + Math.Abs(114.78653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.65671 - lat) + Math.Abs(114.73675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.99361 - lat) + Math.Abs(101.57255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29369 - lat) + Math.Abs(99.72786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45212 - lat) + Math.Abs(99.82032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Padang Mat Sirat", "02", 6.35423, 99.73404);
case 1: return new CityInfo("Ayer Hangat", "02", 6.42062, 99.82199);
case 2: return new CityInfo("Kuah", "02", 6.32649, 99.8432);
case 3: return new CityInfo("Jerantut", "06", 3.936, 102.3626);
case 4: return new CityInfo("Raub", "06", 3.7899, 101.857);
case 5: return new CityInfo("Batu Pahat", "01", 1.8548, 102.9325);
case 6: return new CityInfo("Parit Raja", "01", 1.8681, 103.1124);
case 7: return new CityInfo("Pekan Nenas", "01", 1.51, 103.5141);
case 8: return new CityInfo("Pontian Kechil", "01", 1.4866, 103.3896);
case 9: return new CityInfo("Kampung Pasir Gudang Baru", "01", 1.4726, 103.878);
case 10: return new CityInfo("Kota Tinggi", "01", 1.7381, 103.8999);
case 11: return new CityInfo("Taman Senai", "01", 1.6006, 103.6419);
case 12: return new CityInfo("Kulai", "01", 1.6561, 103.6032);
case 13: return new CityInfo("Skudai", "01", 1.53741, 103.65779);
case 14: return new CityInfo("Johor Bahru", "01", 1.4655, 103.7578);
case 15: return new CityInfo("Kluang", "01", 2.03046, 103.31689);
case 16: return new CityInfo("Yong Peng", "01", 2.0136, 103.0659);
case 17: return new CityInfo("Mersing", "01", 2.4312, 103.8405);
case 18: return new CityInfo("Segamat", "01", 2.5148, 102.8158);
case 19: return new CityInfo("Tangkak", "01", 2.2673, 102.5453);
case 20: return new CityInfo("Muar", "01", 2.0442, 102.5689);
case 21: return new CityInfo("Bakri", "01", 2.0441, 102.6527);
case 22: return new CityInfo("Labis", "01", 2.385, 103.021);
case 23: return new CityInfo("Chaah", "01", 2.249, 103.048);
case 24: return new CityInfo("Kuala Selangor", "12", 3.35, 101.25);
case 25: return new CityInfo("Batang Berjuntai", "12", 3.38333, 101.41667);
case 26: return new CityInfo("Batu Arang", "12", 3.31667, 101.46667);
case 27: return new CityInfo("Shah Alam", "12", 3.08507, 101.53281);
case 28: return new CityInfo("Klang", "12", 3.03667, 101.44333);
case 29: return new CityInfo("Cukai", "13", 4.25, 103.41667);
case 30: return new CityInfo("Kuala Lipis", "06", 4.1842, 102.0468);
case 31: return new CityInfo("Papar", "16", 5.73333, 115.93333);
case 32: return new CityInfo("Kota Kinabalu", "16", 5.9749, 116.0724);
case 33: return new CityInfo("Donggongon", "16", 5.90702, 116.10146);
case 34: return new CityInfo("Putatan", "16", 5.9258, 116.06094);
case 35: return new CityInfo("Kinarut", "16", 5.8231, 116.0466);
case 36: return new CityInfo("Ranau", "16", 5.9538, 116.6641);
case 37: return new CityInfo("Semporna", "16", 4.48178, 118.61119);
case 38: return new CityInfo("Labuan", "15", 5.28028, 115.2475);
case 39: return new CityInfo("Beaufort", "16", 5.3473, 115.7455);
case 40: return new CityInfo("Lahad Datu", "16", 5.02298, 118.32897);
case 41: return new CityInfo("Sandakan", "16", 5.8402, 118.1179);
case 42: return new CityInfo("Keningau", "16", 5.3378, 116.1602);
case 43: return new CityInfo("Tawau", "16", 4.24482, 117.89115);
case 44: return new CityInfo("Paka", "13", 4.6374, 103.4368);
case 45: return new CityInfo("Kertih", "13", 4.5141, 103.4483);
case 46: return new CityInfo("Kulim", "02", 5.36499, 100.56177);
case 47: return new CityInfo("Bagan Serai", "07", 5.0108, 100.54101);
case 48: return new CityInfo("Bedong", "02", 5.72743, 100.50876);
case 49: return new CityInfo("Simpang Empat", "07", 4.95, 100.63333);
case 50: return new CityInfo("Taiping", "07", 4.85, 100.73333);
case 51: return new CityInfo("Kuala Kangsar", "07", 4.76667, 100.93333);
case 52: return new CityInfo("Ipoh", "07", 4.5841, 101.0829);
case 53: return new CityInfo("Gua Musang", "03", 4.88441, 101.96857);
case 54: return new CityInfo("Kuala Terengganu", "13", 5.3302, 103.1408);
case 55: return new CityInfo("Marang", "13", 5.2056, 103.2059);
case 56: return new CityInfo("Tampin", "05", 2.4701, 102.2302);
case 57: return new CityInfo("Alor Gajah", "04", 2.3804, 102.2089);
case 58: return new CityInfo("Kampung Ayer Keroh", "04", 2.2654, 102.2801);
case 59: return new CityInfo("Sungai Udang", "04", 2.269, 102.1427);
case 60: return new CityInfo("Malacca", "04", 2.196, 102.2405);
case 61: return new CityInfo("Pelabuhan Klang", "12", 2.99959, 101.39287);
case 62: return new CityInfo("Banting", "12", 2.8136, 101.50185);
case 63: return new CityInfo("Jenjarum", "12", 2.8724, 101.49484);
case 64: return new CityInfo("Semenyih", "12", 2.9516, 101.843);
case 65: return new CityInfo("Seremban", "05", 2.7297, 101.9381);
case 66: return new CityInfo("Port Dickson", "05", 2.53718, 101.80571);
case 67: return new CityInfo("Sepang", "12", 2.6931, 101.7498);
case 68: return new CityInfo("Bahau", "05", 2.8079, 102.4049);
case 69: return new CityInfo("Kuala Pilah", "05", 2.7389, 102.2487);
case 70: return new CityInfo("Buloh Kasap", "01", 2.5536, 102.764);
case 71: return new CityInfo("Kampung Tekek", "06", 2.8147, 104.1592);
case 72: return new CityInfo("Pekan", "06", 3.4836, 103.3996);
case 73: return new CityInfo("Mentekab", "06", 3.4854, 102.3484);
case 74: return new CityInfo("Temerluh", "06", 3.4506, 102.4176);
case 75: return new CityInfo("Batu Feringgi", "09", 5.4709, 100.24529);
case 76: return new CityInfo("Butterworth", "09", 5.3991, 100.36382);
case 77: return new CityInfo("Perai", "09", 5.38333, 100.38333);
case 78: return new CityInfo("Bukit Mertajam", "09", 5.36301, 100.4667);
case 79: return new CityInfo("Nibong Tebal", "09", 5.16586, 100.47793);
case 80: return new CityInfo("Parit Buntar", "07", 5.12671, 100.49316);
case 81: return new CityInfo("Tasek Glugor", "09", 5.48032, 100.49849);
case 82: return new CityInfo("George Town", "09", 5.41123, 100.33543);
case 83: return new CityInfo("Kampung Bukit Tinggi, Bentong", "06", 3.34944, 101.82631);
case 84: return new CityInfo("Serendah", "12", 3.3646, 101.6041);
case 85: return new CityInfo("Rawang", "12", 3.3213, 101.5767);
case 86: return new CityInfo("Petaling Jaya", "12", 3.10726, 101.60671);
case 87: return new CityInfo("Kuala Lumpur", "14", 3.1412, 101.68653);
case 88: return new CityInfo("Ampang", "12", 3.15, 101.76667);
case 89: return new CityInfo("Sabak Bernam", "12", 3.7698, 100.9879);
case 90: return new CityInfo("Sungai Besar", "12", 3.6746, 100.9867);
case 91: return new CityInfo("Kuantan", "06", 3.8077, 103.326);
case 92: return new CityInfo("Tanah Rata", "06", 4.46361, 101.3763);
case 93: return new CityInfo("Batu Gajah", "07", 4.46916, 101.04107);
case 94: return new CityInfo("Kampar", "07", 4.3, 101.15);
case 95: return new CityInfo("Tapah Road", "07", 4.16667, 101.2);
case 96: return new CityInfo("Bidur", "07", 4.11667, 101.28333);
case 97: return new CityInfo("Mukah", "11", 2.89435, 112.09145);
case 98: return new CityInfo("Lumut", "07", 4.2323, 100.6298);
case 99: return new CityInfo("Teluk Intan", "07", 4.02219, 101.02083);
case 100: return new CityInfo("Gurun", "02", 5.81717, 100.47381);
case 101: return new CityInfo("Sungai Petani", "02", 5.647, 100.48772);
case 102: return new CityInfo("Kepala Batas", "09", 5.51707, 100.4265);
case 103: return new CityInfo("Ketereh", "03", 5.95701, 102.24817);
case 104: return new CityInfo("Pulai Chondong", "03", 5.87133, 102.23177);
case 105: return new CityInfo("Tanah Merah", "03", 5.8, 102.15);
case 106: return new CityInfo("Kuching", "11", 1.55, 110.33333);
case 107: return new CityInfo("Simanggang", "11", 1.24722, 111.45278);
case 108: return new CityInfo("Sarikei", "11", 2.11667, 111.51667);
case 109: return new CityInfo("Sibu", "11", 2.3, 111.81667);
case 110: return new CityInfo("Kangar", "08", 6.4414, 100.19862);
case 111: return new CityInfo("Kuala Perlis", "08", 6.4, 100.13333);
case 112: return new CityInfo("Jitra", "02", 6.26812, 100.42167);
case 113: return new CityInfo("Kuala Kedah", "02", 6.1, 100.3);
case 114: return new CityInfo("Alor Setar", "02", 6.12104, 100.36014);
case 115: return new CityInfo("Tumpat", "03", 6.19775, 102.17098);
case 116: return new CityInfo("Pasir Mas", "03", 6.04934, 102.13987);
case 117: return new CityInfo("Kota Bharu", "03", 6.12361, 102.24333);
case 118: return new CityInfo("Kuala Besut", "13", 5.83303, 102.55514);
case 119: return new CityInfo("Jertih", "13", 5.7336, 102.4897);
case 120: return new CityInfo("Kudat", "16", 6.88732, 116.82364);
case 121: return new CityInfo("Kota Belud", "16", 6.351, 116.4305);
case 122: return new CityInfo("Kapit", "11", 1.99546, 112.93254);
case 123: return new CityInfo("Batu Niah", "11", 3.8, 113.75);
case 124: return new CityInfo("Bintulu", "11", 3.16667, 113.03333);
case 125: return new CityInfo("Lawas", "11", 4.8604, 115.409);
case 126: return new CityInfo("Limbang", "11", 4.75, 115);
case 127: return new CityInfo("Marudi", "11", 4.18333, 114.31667);
case 128: return new CityInfo("Miri", "11", 4.39928, 113.99163);
case 129: return new CityInfo("Ulu Tiram", "01", 1.6, 103.81667);
case 130: return new CityInfo("Telaga Batu", "09", 5.46667, 100.23333);
case 131: return new CityInfo("Tanjung Tokong", "09", 5.46061, 100.30742);
case 132: return new CityInfo("Tanjung Sepat", "12", 2.6579, 101.5629);
case 133: return new CityInfo("Sungai Pelek New Village", "12", 2.65, 101.7);
case 134: return new CityInfo("Pulau Sebang", "04", 2.455, 102.2329);
case 135: return new CityInfo("Permatang Kuching", "09", 5.46339, 100.38144);
case 136: return new CityInfo("Peringat", "03", 6.03333, 102.28333);
case 137: return new CityInfo("Ladang Seri Kundang", "12", 3.2856, 101.519);
case 138: return new CityInfo("Pantai Remis", "07", 4.4557, 100.6288);
case 139: return new CityInfo("Kuang", "12", 3.2594, 101.5541);
case 140: return new CityInfo("Kuala Sungai Baru", "04", 2.3594, 102.0353);
case 141: return new CityInfo("Klebang Besar", "04", 2.2186, 102.1995);
case 142: return new CityInfo("Kelapa Sawit", "01", 1.6698, 103.5327);
case 143: return new CityInfo("Kampung Tanjung Karang", "12", 3.4242, 101.1849);
case 144: return new CityInfo("Kampung Sungai Ara", "09", 5.32699, 100.27348);
case 145: return new CityInfo("Kampung Simpang Renggam", "01", 1.8278, 103.3);
case 146: return new CityInfo("Kampong Pangkal Kalong", "03", 5.91667, 102.21667);
case 147: return new CityInfo("Kampong Masjid Tanah", "04", 2.35, 102.11667);
case 148: return new CityInfo("Kampong Kadok", "03", 6, 102.25);
case 149: return new CityInfo("Kampong Dungun", "07", 3.21667, 101.31667);
case 150: return new CityInfo("Kampung Bukit Baharu", "04", 2.2152, 102.2851);
case 151: return new CityInfo("Kampung Batu Feringgi", "09", 5.46948, 100.24449);
case 152: return new CityInfo("Kampung Baru Subang", "12", 3.15, 101.53333);
case 153: return new CityInfo("Kampung Baharu Nilai", "05", 2.8033, 101.7972);
case 154: return new CityInfo("Kampong Baharu Balakong", "12", 3.03333, 101.75);
case 155: return new CityInfo("Kampung Ayer Molek", "04", 2.2139, 102.3278);
case 156: return new CityInfo("Juru", "09", 5.31201, 100.44229);
case 157: return new CityInfo("Bukit Rambai", "04", 2.2594, 102.1838);
case 158: return new CityInfo("Bentong Town", "06", 3.52229, 101.90866);
case 159: return new CityInfo("Bemban", "04", 2.2684, 102.3746);
case 160: return new CityInfo("Batu Berendam", "04", 2.2487, 102.246);
case 161: return new CityInfo("Bagan Pulau Ketam", "12", 3.01667, 101.26667);
case 162: return new CityInfo("Kg Ramayah", "16", 5.88434, 116.09319);
case 163: return new CityInfo("Putrajaya", "17", 2.93527, 101.69112);
case 164: return new CityInfo("Kampung Kilim", "02", 6.4055, 99.8502);
case 165: return new CityInfo("Kampung Bukit Hantu", "02", 6.36257, 99.7832);
case 166: return new CityInfo("Kampung Kok", "02", 6.36759, 99.68252);
case 167: return new CityInfo("Kuala Teriang", "02", 6.36377, 99.71532);
case 168: return new CityInfo("Kampung Kuala Besut", "13", 5.83297, 102.55061);
case 169: return new CityInfo("Kampung Lemal", "03", 6.03021, 102.14126);
case 170: return new CityInfo("Bandar Labuan", "16", 5.28883, 115.26924);
case 171: return new CityInfo("Data Kakus", "11", 2.65465, 113.62249);
case 172: return new CityInfo("Subang Jaya", "12", 3.04384, 101.58062);
case 173: return new CityInfo("Taman Rajawali", "16", 5.89477, 118.04576);
case 174: return new CityInfo("Lidung Jelo", "11", 2.64848, 114.78653);
case 175: return new CityInfo("Long Ampan Aing or Abanang", "11", 2.65671, 114.73675);
case 176: return new CityInfo("Putra Heights", "12", 2.99361, 101.57255);
case 177: return new CityInfo("Pantai Cenang", "08", 6.29369, 99.72786);
default: return new CityInfo("Tanjung Rhu", "02", 6.45212, 99.82032);

                                    }                                        
                                }
                            
                        }
                    }
                