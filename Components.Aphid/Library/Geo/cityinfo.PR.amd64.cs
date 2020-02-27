
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
                                    public const string Country = "PR";
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
                            
                                        var cur = (Math.Abs(18.44328 - lat) + Math.Abs(-67.0649 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.16274 - lat) + Math.Abs(-66.72212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37939 - lat) + Math.Abs(-67.18824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42745 - lat) + Math.Abs(-67.15407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2569 - lat) + Math.Abs(-66.10294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25273 - lat) + Math.Abs(-65.6535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0233 - lat) + Math.Abs(-66.53462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.13996 - lat) + Math.Abs(-66.266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.28273 - lat) + Math.Abs(-67.13962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4455 - lat) + Math.Abs(-66.6349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18524 - lat) + Math.Abs(-65.8085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47245 - lat) + Math.Abs(-66.71573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.9658 - lat) + Math.Abs(-66.06128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25912 - lat) + Math.Abs(-66.04044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42661 - lat) + Math.Abs(-66.68323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.15774 - lat) + Math.Abs(-65.78155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35134 - lat) + Math.Abs(-66.44545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4505 - lat) + Math.Abs(-66.53851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18662 - lat) + Math.Abs(-66.30628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36134 - lat) + Math.Abs(-65.8385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39856 - lat) + Math.Abs(-66.15572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17774 - lat) + Math.Abs(-66.11322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27357 - lat) + Math.Abs(-65.87905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02857 - lat) + Math.Abs(-67.1349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02691 - lat) + Math.Abs(-67.16907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20746 - lat) + Math.Abs(-65.8485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46717 - lat) + Math.Abs(-66.341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99635 - lat) + Math.Abs(-66.05183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41828 - lat) + Math.Abs(-66.57323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44328 - lat) + Math.Abs(-67.13601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08663 - lat) + Math.Abs(-67.14573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43661 - lat) + Math.Abs(-66.93712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23412 - lat) + Math.Abs(-66.0485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42134 - lat) + Math.Abs(-66.23683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33717 - lat) + Math.Abs(-65.89794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48383 - lat) + Math.Abs(-66.8449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.40411 - lat) + Math.Abs(-66.20878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41717 - lat) + Math.Abs(-66.21739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.10191 - lat) + Math.Abs(-65.83683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3751 - lat) + Math.Abs(-65.89934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01454 - lat) + Math.Abs(-66.53372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38078 - lat) + Math.Abs(-65.95739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48189 - lat) + Math.Abs(-66.7899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44134 - lat) + Math.Abs(-66.11822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.11191 - lat) + Math.Abs(-66.166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29106 - lat) + Math.Abs(-66.73934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26412 - lat) + Math.Abs(-65.6485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44634 - lat) + Math.Abs(-66.35073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27162 - lat) + Math.Abs(-65.966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.95358 - lat) + Math.Abs(-66.22294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33606 - lat) + Math.Abs(-66.46878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17579 - lat) + Math.Abs(-66.16128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07996 - lat) + Math.Abs(-66.35795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00719 - lat) + Math.Abs(-66.25933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21801 - lat) + Math.Abs(-66.226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08719 - lat) + Math.Abs(-65.84377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.97413 - lat) + Math.Abs(-66.22711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99274 - lat) + Math.Abs(-66.08489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45856 - lat) + Math.Abs(-66.77629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34106 - lat) + Math.Abs(-66.31684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04969 - lat) + Math.Abs(-66.55128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43078 - lat) + Math.Abs(-66.43989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30301 - lat) + Math.Abs(-65.30099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22635 - lat) + Math.Abs(-65.68322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45883 - lat) + Math.Abs(-66.26767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23669 - lat) + Math.Abs(-65.74172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23412 - lat) + Math.Abs(-65.87961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03747 - lat) + Math.Abs(-65.85127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00385 - lat) + Math.Abs(-66.39156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00052 - lat) + Math.Abs(-65.88266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.09719 - lat) + Math.Abs(-65.47071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27634 - lat) + Math.Abs(-67.11935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36662 - lat) + Math.Abs(-66.56962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32579 - lat) + Math.Abs(-65.65238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36245 - lat) + Math.Abs(-66.56128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34023 - lat) + Math.Abs(-66.42767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98774 - lat) + Math.Abs(-66.91601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.12746 - lat) + Math.Abs(-66.10405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36245 - lat) + Math.Abs(-66.25878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45356 - lat) + Math.Abs(-66.56628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.97163 - lat) + Math.Abs(-66.90795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08135 - lat) + Math.Abs(-66.50128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98413 - lat) + Math.Abs(-66.11378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01913 - lat) + Math.Abs(-66.79184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35745 - lat) + Math.Abs(-66.111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2544 - lat) + Math.Abs(-65.97294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34773 - lat) + Math.Abs(-66.27378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48633 - lat) + Math.Abs(-66.82545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35578 - lat) + Math.Abs(-67.03407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37439 - lat) + Math.Abs(-65.78711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.13968 - lat) + Math.Abs(-67.1274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43689 - lat) + Math.Abs(-66.55239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99413 - lat) + Math.Abs(-66.81934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44217 - lat) + Math.Abs(-66.226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.14968 - lat) + Math.Abs(-65.82738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.14913 - lat) + Math.Abs(-65.44266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.50078 - lat) + Math.Abs(-67.02435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16163 - lat) + Math.Abs(-65.99544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96913 - lat) + Math.Abs(-66.36572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21857 - lat) + Math.Abs(-66.59156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.95524 - lat) + Math.Abs(-66.16544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05246 - lat) + Math.Abs(-66.50656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.31384 - lat) + Math.Abs(-66.91907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22746 - lat) + Math.Abs(-65.921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39745 - lat) + Math.Abs(-66.6024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3755 - lat) + Math.Abs(-65.85572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17551 - lat) + Math.Abs(-65.8535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44884 - lat) + Math.Abs(-66.50989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.97497 - lat) + Math.Abs(-67.04657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.28745 - lat) + Math.Abs(-67.18685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04663 - lat) + Math.Abs(-66.20461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04996 - lat) + Math.Abs(-67.05934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98136 - lat) + Math.Abs(-65.98572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29467 - lat) + Math.Abs(-66.87712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29328 - lat) + Math.Abs(-67.14629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2519 - lat) + Math.Abs(-66.99212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98469 - lat) + Math.Abs(-66.31795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03302 - lat) + Math.Abs(-66.42434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18301 - lat) + Math.Abs(-65.86627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44995 - lat) + Math.Abs(-66.18156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04302 - lat) + Math.Abs(-66.9424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0383 - lat) + Math.Abs(-66.90462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43134 - lat) + Math.Abs(-65.88016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26857 - lat) + Math.Abs(-65.90878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05524 - lat) + Math.Abs(-66.40573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05691 - lat) + Math.Abs(-66.52684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29968 - lat) + Math.Abs(-65.63849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37245 - lat) + Math.Abs(-65.71655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36439 - lat) + Math.Abs(-67.1574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01746 - lat) + Math.Abs(-66.76906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42745 - lat) + Math.Abs(-66.49212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.9783 - lat) + Math.Abs(-66.88934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0233 - lat) + Math.Abs(-66.33239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18079 - lat) + Math.Abs(-66.9799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07607 - lat) + Math.Abs(-65.89822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05772 - lat) + Math.Abs(-66.65603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00719 - lat) + Math.Abs(-65.89933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38662 - lat) + Math.Abs(-66.38378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39467 - lat) + Math.Abs(-67.11324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43661 - lat) + Math.Abs(-66.35961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08746 - lat) + Math.Abs(-67.1074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.463 - lat) + Math.Abs(-67.03268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32578 - lat) + Math.Abs(-66.40656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39078 - lat) + Math.Abs(-66.216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20107 - lat) + Math.Abs(-67.13962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21162 - lat) + Math.Abs(-65.73488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30079 - lat) + Math.Abs(-66.24489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00191 - lat) + Math.Abs(-66.10822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2269 - lat) + Math.Abs(-66.391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36856 - lat) + Math.Abs(-66.21683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38217 - lat) + Math.Abs(-66.55573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06802 - lat) + Math.Abs(-66.32545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04024 - lat) + Math.Abs(-67.07685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98719 - lat) + Math.Abs(-66.02544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37051 - lat) + Math.Abs(-65.77405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00747 - lat) + Math.Abs(-65.93683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23246 - lat) + Math.Abs(-66.25628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01358 - lat) + Math.Abs(-66.87323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17079 - lat) + Math.Abs(-66.18822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.14024 - lat) + Math.Abs(-66.17239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99885 - lat) + Math.Abs(-66.34128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.11774 - lat) + Math.Abs(-66.25878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00635 - lat) + Math.Abs(-66.01572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21551 - lat) + Math.Abs(-65.82211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05635 - lat) + Math.Abs(-66.72156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43411 - lat) + Math.Abs(-66.88768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37967 - lat) + Math.Abs(-65.74516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96052 - lat) + Math.Abs(-66.28961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04469 - lat) + Math.Abs(-65.90738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98497 - lat) + Math.Abs(-66.43906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.97496 - lat) + Math.Abs(-67.18518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01031 - lat) + Math.Abs(-66.62398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99135 - lat) + Math.Abs(-66.49656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22801 - lat) + Math.Abs(-65.86294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07496 - lat) + Math.Abs(-67.18712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16635 - lat) + Math.Abs(-65.74822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35662 - lat) + Math.Abs(-66.83212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47383 - lat) + Math.Abs(-66.93851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.40717 - lat) + Math.Abs(-66.78212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42745 - lat) + Math.Abs(-66.78684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47133 - lat) + Math.Abs(-67.07907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33967 - lat) + Math.Abs(-65.71266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34023 - lat) + Math.Abs(-67.2499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21829 - lat) + Math.Abs(-65.7885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0383 - lat) + Math.Abs(-66.46767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38023 - lat) + Math.Abs(-65.83127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39467 - lat) + Math.Abs(-66.26767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06163 - lat) + Math.Abs(-65.9135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46078 - lat) + Math.Abs(-66.3585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08607 - lat) + Math.Abs(-67.08101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07774 - lat) + Math.Abs(-66.96045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43384 - lat) + Math.Abs(-66.61378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42689 - lat) + Math.Abs(-66.18461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.97747 - lat) + Math.Abs(-66.29795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.49217 - lat) + Math.Abs(-67.09851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44884 - lat) + Math.Abs(-66.30267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45161 - lat) + Math.Abs(-66.94962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08163 - lat) + Math.Abs(-67.0449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39217 - lat) + Math.Abs(-65.88544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39828 - lat) + Math.Abs(-66.25572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46633 - lat) + Math.Abs(-66.10572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.1894 - lat) + Math.Abs(-65.961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33662 - lat) + Math.Abs(-66.99018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39356 - lat) + Math.Abs(-65.91878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21857 - lat) + Math.Abs(-66.12878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96608 - lat) + Math.Abs(-66.40489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0633 - lat) + Math.Abs(-66.7524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32189 - lat) + Math.Abs(-67.24685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43022 - lat) + Math.Abs(-65.8535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21857 - lat) + Math.Abs(-66.12878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99497 - lat) + Math.Abs(-66.71629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05107 - lat) + Math.Abs(-66.70017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43161 - lat) + Math.Abs(-66.58073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46189 - lat) + Math.Abs(-66.4885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38828 - lat) + Math.Abs(-66.24822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44384 - lat) + Math.Abs(-66.25961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35467 - lat) + Math.Abs(-66.00739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26551 - lat) + Math.Abs(-66.70045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0658 - lat) + Math.Abs(-66.2385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41217 - lat) + Math.Abs(-66.33128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44439 - lat) + Math.Abs(-66.38767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42495 - lat) + Math.Abs(-65.83294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.12718 - lat) + Math.Abs(-66.49212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05052 - lat) + Math.Abs(-65.87933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03496 - lat) + Math.Abs(-66.8499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02691 - lat) + Math.Abs(-66.05711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Aceitunas", "099", 18.44328, -67.0649);
case 1: return new CityInfo("Adjuntas", "001", 18.16274, -66.72212);
case 2: return new CityInfo("Aguada", "003", 18.37939, -67.18824);
case 3: return new CityInfo("Aguadilla", "005", 18.42745, -67.15407);
case 4: return new CityInfo("Aguas Buenas", "007", 18.2569, -66.10294);
case 5: return new CityInfo("Aguas Claras", "037", 18.25273, -65.6535);
case 6: return new CityInfo("Aguilita", "075", 18.0233, -66.53462);
case 7: return new CityInfo("Aibonito", "009", 18.13996, -66.266);
case 8: return new CityInfo("Añasco", "011", 18.28273, -67.13962);
case 9: return new CityInfo("Animas", "013", 18.4455, -66.6349);
case 10: return new CityInfo("Antón Ruiz", "069", 18.18524, -65.8085);
case 11: return new CityInfo("Arecibo", "013", 18.47245, -66.71573);
case 12: return new CityInfo("Arroyo", "015", 17.9658, -66.06128);
case 13: return new CityInfo("Bairoa", "025", 18.25912, -66.04044);
case 14: return new CityInfo("Bajadero", "013", 18.42661, -66.68323);
case 15: return new CityInfo("Bajandas", "069", 18.15774, -65.78155);
case 16: return new CityInfo("Barahona", "101", 18.35134, -66.44545);
case 17: return new CityInfo("Barceloneta", "017", 18.4505, -66.53851);
case 18: return new CityInfo("Barranquitas", "019", 18.18662, -66.30628);
case 19: return new CityInfo("Bartolo", "119", 18.36134, -65.8385);
case 20: return new CityInfo("Bayamón", "021", 18.39856, -66.15572);
case 21: return new CityInfo("Bayamon", "041", 18.17774, -66.11322);
case 22: return new CityInfo("Benitez", "029", 18.27357, -65.87905);
case 23: return new CityInfo("Betances", "023", 18.02857, -67.1349);
case 24: return new CityInfo("Boquerón", "023", 18.02691, -67.16907);
case 25: return new CityInfo("Boqueron", "085", 18.20746, -65.8485);
case 26: return new CityInfo("Brenas", "143", 18.46717, -66.341);
case 27: return new CityInfo("Buena Vista", "015", 17.99635, -66.05183);
case 28: return new CityInfo("Bufalo", "017", 18.41828, -66.57323);
case 29: return new CityInfo("Caban", "005", 18.44328, -67.13601);
case 30: return new CityInfo("Cabo Rojo", "023", 18.08663, -67.14573);
case 31: return new CityInfo("Cacao", "115", 18.43661, -66.93712);
case 32: return new CityInfo("Caguas", "025", 18.23412, -66.0485);
case 33: return new CityInfo("Campanilla", "137", 18.42134, -66.23683);
case 34: return new CityInfo("Campo Rico", "029", 18.33717, -65.89794);
case 35: return new CityInfo("Camuy", "027", 18.48383, -66.8449);
case 36: return new CityInfo("Candelaria", "137", 18.40411, -66.20878);
case 37: return new CityInfo("Candelaria Arenas", "137", 18.41717, -66.21739);
case 38: return new CityInfo("Candelero Arriba", "069", 18.10191, -65.83683);
case 39: return new CityInfo("Canovanas", "029", 18.3751, -65.89934);
case 40: return new CityInfo("Capitanejo", "075", 18.01454, -66.53372);
case 41: return new CityInfo("Carolina", "031", 18.38078, -65.95739);
case 42: return new CityInfo("Carrizales", "065", 18.48189, -66.7899);
case 43: return new CityInfo("Cataño", "033", 18.44134, -66.11822);
case 44: return new CityInfo("Cayey", "035", 18.11191, -66.166);
case 45: return new CityInfo("Cayuco", "141", 18.29106, -66.73934);
case 46: return new CityInfo("Ceiba", "037", 18.26412, -65.6485);
case 47: return new CityInfo("Ceiba", "143", 18.44634, -66.35073);
case 48: return new CityInfo("Celada", "063", 18.27162, -65.966);
case 49: return new CityInfo("Central Aguirre", "123", 17.95358, -66.22294);
case 50: return new CityInfo("Ciales", "039", 18.33606, -66.46878);
case 51: return new CityInfo("Cidra", "041", 18.17579, -66.16128);
case 52: return new CityInfo("Coamo", "043", 18.07996, -66.35795);
case 53: return new CityInfo("Coco", "123", 18.00719, -66.25933);
case 54: return new CityInfo("Comerío", "045", 18.21801, -66.226);
case 55: return new CityInfo("Comunas", "151", 18.08719, -65.84377);
case 56: return new CityInfo("Coquí", "123", 17.97413, -66.22711);
case 57: return new CityInfo("Corazón", "057", 17.99274, -66.08489);
case 58: return new CityInfo("Corcovado", "065", 18.45856, -66.77629);
case 59: return new CityInfo("Corozal", "047", 18.34106, -66.31684);
case 60: return new CityInfo("Coto Laurel", "113", 18.04969, -66.55128);
case 61: return new CityInfo("Coto Norte", "145", 18.43078, -66.43989);
case 62: return new CityInfo("Culebra", "049", 18.30301, -65.30099);
case 63: return new CityInfo("Daguao", "103", 18.22635, -65.68322);
case 64: return new CityInfo("Dorado", "051", 18.45883, -66.26767);
case 65: return new CityInfo("Duque", "103", 18.23669, -65.74172);
case 66: return new CityInfo("El Mangó", "077", 18.23412, -65.87961);
case 67: return new CityInfo("El Negro", "151", 18.03747, -65.85127);
case 68: return new CityInfo("El Ojo", "133", 18.00385, -66.39156);
case 69: return new CityInfo("Emajagua", "095", 18.00052, -65.88266);
case 70: return new CityInfo("Esperanza", "147", 18.09719, -65.47071);
case 71: return new CityInfo("Espino", "011", 18.27634, -67.11935);
case 72: return new CityInfo("Estancias de Florida", "054", 18.36662, -66.56962);
case 73: return new CityInfo("Fajardo", "053", 18.32579, -65.65238);
case 74: return new CityInfo("Florida", "054", 18.36245, -66.56128);
case 75: return new CityInfo("Franquez", "101", 18.34023, -66.42767);
case 76: return new CityInfo("Fuig", "055", 17.98774, -66.91601);
case 77: return new CityInfo("G. L. Garcia", "035", 18.12746, -66.10405);
case 78: return new CityInfo("Galateo", "135", 18.36245, -66.25878);
case 79: return new CityInfo("Garrochales", "017", 18.45356, -66.56628);
case 80: return new CityInfo("Guánica", "055", 17.97163, -66.90795);
case 81: return new CityInfo("Guayabal", "075", 18.08135, -66.50128);
case 82: return new CityInfo("Guayama", "057", 17.98413, -66.11378);
case 83: return new CityInfo("Guayanilla", "059", 18.01913, -66.79184);
case 84: return new CityInfo("Guaynabo", "061", 18.35745, -66.111);
case 85: return new CityInfo("Gurabo", "063", 18.2544, -65.97294);
case 86: return new CityInfo("H. Rivera Colon", "135", 18.34773, -66.27378);
case 87: return new CityInfo("Hatillo", "065", 18.48633, -66.82545);
case 88: return new CityInfo("Hato Arriba", "131", 18.35578, -67.03407);
case 89: return new CityInfo("Hato Candal", "119", 18.37439, -65.78711);
case 90: return new CityInfo("Hormigueros", "067", 18.13968, -67.1274);
case 91: return new CityInfo("Imbery", "017", 18.43689, -66.55239);
case 92: return new CityInfo("Indios", "059", 17.99413, -66.81934);
case 93: return new CityInfo("Ingenio", "137", 18.44217, -66.226);
case 94: return new CityInfo("Humacao", "069", 18.14968, -65.82738);
case 95: return new CityInfo("Isabel Segunda", "147", 18.14913, -65.44266);
case 96: return new CityInfo("Isabela", "071", 18.50078, -67.02435);
case 97: return new CityInfo("Jagual", "129", 18.16163, -65.99544);
case 98: return new CityInfo("Jauca", "133", 17.96913, -66.36572);
case 99: return new CityInfo("Jayuya", "073", 18.21857, -66.59156);
case 100: return new CityInfo("Jobos", "057", 17.95524, -66.16544);
case 101: return new CityInfo("Juana Díaz", "075", 18.05246, -66.50656);
case 102: return new CityInfo("Juncal", "131", 18.31384, -66.91907);
case 103: return new CityInfo("Juncos", "077", 18.22746, -65.921);
case 104: return new CityInfo("La Alianza", "013", 18.39745, -66.6024);
case 105: return new CityInfo("La Dolores", "119", 18.3755, -65.85572);
case 106: return new CityInfo("La Fermina", "085", 18.17551, -65.8535);
case 107: return new CityInfo("La Luisa", "091", 18.44884, -66.50989);
case 108: return new CityInfo("La Parguera", "079", 17.97497, -67.04657);
case 109: return new CityInfo("La Playa", "011", 18.28745, -67.18685);
case 110: return new CityInfo("La Plena", "123", 18.04663, -66.20461);
case 111: return new CityInfo("Lajas", "079", 18.04996, -67.05934);
case 112: return new CityInfo("Lamboglia", "109", 17.98136, -65.98572);
case 113: return new CityInfo("Lares", "081", 18.29467, -66.87712);
case 114: return new CityInfo("Las Marias", "011", 18.29328, -67.14629);
case 115: return new CityInfo("Las Marías", "083", 18.2519, -66.99212);
case 116: return new CityInfo("Las Ochenta", "123", 17.98469, -66.31795);
case 117: return new CityInfo("Las Ollas", "133", 18.03302, -66.42434);
case 118: return new CityInfo("Las Piedras", "085", 18.18301, -65.86627);
case 119: return new CityInfo("Levittown", "137", 18.44995, -66.18156);
case 120: return new CityInfo("Liborio Negron Torres", "121", 18.04302, -66.9424);
case 121: return new CityInfo("Lluveras", "121", 18.0383, -66.90462);
case 122: return new CityInfo("Loíza", "087", 18.43134, -65.88016);
case 123: return new CityInfo("Lomas", "029", 18.26857, -65.90878);
case 124: return new CityInfo("Los Llanos", "043", 18.05524, -66.40573);
case 125: return new CityInfo("Luis Llorens Torres", "075", 18.05691, -66.52684);
case 126: return new CityInfo("Luis M. Cintron", "053", 18.29968, -65.63849);
case 127: return new CityInfo("Luquillo", "089", 18.37245, -65.71655);
case 128: return new CityInfo("Luyando", "003", 18.36439, -67.1574);
case 129: return new CityInfo("Magas Arriba", "059", 18.01746, -66.76906);
case 130: return new CityInfo("Manatí", "091", 18.42745, -66.49212);
case 131: return new CityInfo("Maria Antonia", "055", 17.9783, -66.88934);
case 132: return new CityInfo("Mariano Colón", "043", 18.0233, -66.33239);
case 133: return new CityInfo("Maricao", "093", 18.18079, -66.9799);
case 134: return new CityInfo("Martorell", "151", 18.07607, -65.89822);
case 135: return new CityInfo("Marueño", "113", 18.05772, -66.65603);
case 136: return new CityInfo("Maunabo", "095", 18.00719, -65.89933);
case 137: return new CityInfo("Miranda", "145", 18.38662, -66.38378);
case 138: return new CityInfo("Moca", "099", 18.39467, -67.11324);
case 139: return new CityInfo("Monserrate", "145", 18.43661, -66.35961);
case 140: return new CityInfo("Monte Grande", "023", 18.08746, -67.1074);
case 141: return new CityInfo("Mora", "071", 18.463, -67.03268);
case 142: return new CityInfo("Morovis", "101", 18.32578, -66.40656);
case 143: return new CityInfo("Mucarabones", "135", 18.39078, -66.216);
case 144: return new CityInfo("Mayagüez", "097", 18.20107, -67.13962);
case 145: return new CityInfo("Naguabo", "103", 18.21162, -65.73488);
case 146: return new CityInfo("Naranjito", "105", 18.30079, -66.24489);
case 147: return new CityInfo("Olimpo", "057", 18.00191, -66.10822);
case 148: return new CityInfo("Orocovis", "107", 18.2269, -66.391);
case 149: return new CityInfo("Pájaros", "135", 18.36856, -66.21683);
case 150: return new CityInfo("Pajonal", "054", 18.38217, -66.55573);
case 151: return new CityInfo("Palmarejo", "043", 18.06802, -66.32545);
case 152: return new CityInfo("Palmarejo", "079", 18.04024, -67.07685);
case 153: return new CityInfo("Palmas", "015", 17.98719, -66.02544);
case 154: return new CityInfo("Palmer", "119", 18.37051, -65.77405);
case 155: return new CityInfo("Palo Seco", "095", 18.00747, -65.93683);
case 156: return new CityInfo("Palomas", "045", 18.23246, -66.25628);
case 157: return new CityInfo("Palomas", "153", 18.01358, -66.87323);
case 158: return new CityInfo("Parcelas La Milagrosa", "041", 18.17079, -66.18822);
case 159: return new CityInfo("Parcelas Nuevas", "041", 18.14024, -66.17239);
case 160: return new CityInfo("Parcelas Peñuelas", "133", 17.99885, -66.34128);
case 161: return new CityInfo("Pastos", "009", 18.11774, -66.25878);
case 162: return new CityInfo("Patillas", "109", 18.00635, -66.01572);
case 163: return new CityInfo("Peña Pobre", "103", 18.21551, -65.82211);
case 164: return new CityInfo("Peñuelas", "111", 18.05635, -66.72156);
case 165: return new CityInfo("Piedra Gorda", "027", 18.43411, -66.88768);
case 166: return new CityInfo("Playa Fortuna", "089", 18.37967, -65.74516);
case 167: return new CityInfo("Playita", "123", 17.96052, -66.28961);
case 168: return new CityInfo("Playita", "151", 18.04469, -65.90738);
case 169: return new CityInfo("Playita Cortada", "133", 17.98497, -66.43906);
case 170: return new CityInfo("Pole Ojea", "023", 17.97496, -67.18518);
case 171: return new CityInfo("Ponce", "113", 18.01031, -66.62398);
case 172: return new CityInfo("Potala Pastillo", "075", 17.99135, -66.49656);
case 173: return new CityInfo("Pueblito del Rio", "085", 18.22801, -65.86294);
case 174: return new CityInfo("Puerto Real", "023", 18.07496, -67.18712);
case 175: return new CityInfo("Punta Santiago", "069", 18.16635, -65.74822);
case 176: return new CityInfo("Quebrada", "027", 18.35662, -66.83212);
case 177: return new CityInfo("Quebradillas", "115", 18.47383, -66.93851);
case 178: return new CityInfo("Rafael Capo", "065", 18.40717, -66.78212);
case 179: return new CityInfo("Rafael Gonzalez", "065", 18.42745, -66.78684);
case 180: return new CityInfo("Rafael Hernandez", "005", 18.47133, -67.07907);
case 181: return new CityInfo("Ramos", "089", 18.33967, -65.71266);
case 182: return new CityInfo("Rincón", "117", 18.34023, -67.2499);
case 183: return new CityInfo("Río Blanco", "103", 18.21829, -65.7885);
case 184: return new CityInfo("Río Cañas Abajo", "075", 18.0383, -66.46767);
case 185: return new CityInfo("Río Grande", "119", 18.38023, -65.83127);
case 186: return new CityInfo("Río Lajas", "051", 18.39467, -66.26767);
case 187: return new CityInfo("Rosa Sanchez", "151", 18.06163, -65.9135);
case 188: return new CityInfo("Sabana", "145", 18.46078, -66.3585);
case 189: return new CityInfo("Sabana Eneas", "125", 18.08607, -67.08101);
case 190: return new CityInfo("Sabana Grande", "121", 18.07774, -66.96045);
case 191: return new CityInfo("Sabana Hoyos", "013", 18.43384, -66.61378);
case 192: return new CityInfo("Sabana Seca", "137", 18.42689, -66.18461);
case 193: return new CityInfo("Salinas", "123", 17.97747, -66.29795);
case 194: return new CityInfo("San Antonio", "005", 18.49217, -67.09851);
case 195: return new CityInfo("San Antonio", "051", 18.44884, -66.30267);
case 196: return new CityInfo("San Antonio", "115", 18.45161, -66.94962);
case 197: return new CityInfo("San Germán", "125", 18.08163, -67.0449);
case 198: return new CityInfo("San Isidro", "029", 18.39217, -65.88544);
case 199: return new CityInfo("San José", "137", 18.39828, -66.25572);
case 200: return new CityInfo("San Juan", "127", 18.46633, -66.10572);
case 201: return new CityInfo("San Lorenzo", "129", 18.1894, -65.961);
case 202: return new CityInfo("San Sebastián", "131", 18.33662, -66.99018);
case 203: return new CityInfo("Santa Barbara", "029", 18.39356, -65.91878);
case 204: return new CityInfo("Santa Clara", "007", 18.21857, -66.12878);
case 205: return new CityInfo("Santa Isabel", "133", 17.96608, -66.40489);
case 206: return new CityInfo("Santo Domingo", "111", 18.0633, -66.7524);
case 207: return new CityInfo("Stella", "117", 18.32189, -67.24685);
case 208: return new CityInfo("Suárez", "087", 18.43022, -65.8535);
case 209: return new CityInfo("Sumidero", "007", 18.21857, -66.12878);
case 210: return new CityInfo("Tallaboa", "111", 17.99497, -66.71629);
case 211: return new CityInfo("Tallaboa Alta", "111", 18.05107, -66.70017);
case 212: return new CityInfo("Tiburones", "017", 18.43161, -66.58073);
case 213: return new CityInfo("Tierras Nuevas Poniente", "091", 18.46189, -66.4885);
case 214: return new CityInfo("Toa Alta", "135", 18.38828, -66.24822);
case 215: return new CityInfo("Toa Baja", "137", 18.44384, -66.25961);
case 216: return new CityInfo("Trujillo Alto", "139", 18.35467, -66.00739);
case 217: return new CityInfo("Utuado", "141", 18.26551, -66.70045);
case 218: return new CityInfo("Vázquez", "123", 18.0658, -66.2385);
case 219: return new CityInfo("Vega Alta", "143", 18.41217, -66.33128);
case 220: return new CityInfo("Vega Baja", "145", 18.44439, -66.38767);
case 221: return new CityInfo("Vieques", "087", 18.42495, -65.83294);
case 222: return new CityInfo("Villalba", "149", 18.12718, -66.49212);
case 223: return new CityInfo("Yabucoa", "151", 18.05052, -65.87933);
case 224: return new CityInfo("Yauco", "153", 18.03496, -66.8499);
default: return new CityInfo("Yaurel", "015", 18.02691, -66.05711);

                                    }                                        
                                }
                            
                        }
                    }
                