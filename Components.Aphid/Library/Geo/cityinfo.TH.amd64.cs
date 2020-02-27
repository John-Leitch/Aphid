
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
                                    public const string Country = "TH";
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
                            
                                        var cur = (Math.Abs(9.31676 - lat) + Math.Abs(99.69184 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(16.31489 - lat) + Math.Abs(99.83267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42045 - lat) + Math.Abs(99.39517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88481 - lat) + Math.Abs(98.40008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88489 - lat) + Math.Abs(98.38557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27081 - lat) + Math.Abs(99.87203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.72206 - lat) + Math.Abs(99.74878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07228 - lat) + Math.Abs(99.29225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07861 - lat) + Math.Abs(98.035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.36586 - lat) + Math.Abs(99.20187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.11712 - lat) + Math.Abs(98.94176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.02883 - lat) + Math.Abs(99.29833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.11189 - lat) + Math.Abs(99.94467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.34597 - lat) + Math.Abs(99.814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.38622 - lat) + Math.Abs(99.66692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63585 - lat) + Math.Abs(99.3666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.34778 - lat) + Math.Abs(99.50722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.557 - lat) + Math.Abs(98.6425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.88361 - lat) + Math.Abs(99.93314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45407 - lat) + Math.Abs(99.88637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73631 - lat) + Math.Abs(99.3987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.14678 - lat) + Math.Abs(99.61933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.37514 - lat) + Math.Abs(99.89225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01622 - lat) + Math.Abs(98.8627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55633 - lat) + Math.Abs(99.61141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30119 - lat) + Math.Abs(99.36611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11022 - lat) + Math.Abs(99.08306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16453 - lat) + Math.Abs(99.68039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.32106 - lat) + Math.Abs(99.56092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.74345 - lat) + Math.Abs(98.63101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.61289 - lat) + Math.Abs(99.21612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.22708 - lat) + Math.Abs(98.22572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66733 - lat) + Math.Abs(99.93078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66461 - lat) + Math.Abs(99.17281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46063 - lat) + Math.Abs(99.89166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.49964 - lat) + Math.Abs(99.6217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51625 - lat) + Math.Abs(98.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.79014 - lat) + Math.Abs(99.97005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.96118 - lat) + Math.Abs(99.64122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.9 - lat) + Math.Abs(99.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03169 - lat) + Math.Abs(98.33408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39914 - lat) + Math.Abs(98.26061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.26418 - lat) + Math.Abs(99.19218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.57203 - lat) + Math.Abs(99.16586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38373 - lat) + Math.Abs(98.45123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8705 - lat) + Math.Abs(98.34383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.86968 - lat) + Math.Abs(99.12898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14011 - lat) + Math.Abs(99.33311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.00778 - lat) + Math.Abs(99.823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5429 - lat) + Math.Abs(99.33961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.88053 - lat) + Math.Abs(99.337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06506 - lat) + Math.Abs(99.24537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.59922 - lat) + Math.Abs(99.11406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.51692 - lat) + Math.Abs(99.75978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.164 - lat) + Math.Abs(99.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.34907 - lat) + Math.Abs(99.98563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.57158 - lat) + Math.Abs(99.34494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.72136 - lat) + Math.Abs(99.8843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23668 - lat) + Math.Abs(99.10938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.31597 - lat) + Math.Abs(99.83186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58394 - lat) + Math.Abs(99.86089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.71417 - lat) + Math.Abs(99.03528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.84792 - lat) + Math.Abs(99.04508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.62828 - lat) + Math.Abs(98.89572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.74486 - lat) + Math.Abs(99.11953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15553 - lat) + Math.Abs(98.45361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.84806 - lat) + Math.Abs(98.73242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.24331 - lat) + Math.Abs(99.02256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11899 - lat) + Math.Abs(99.142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.46862 - lat) + Math.Abs(99.88843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17911 - lat) + Math.Abs(99.85425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53671 - lat) + Math.Abs(99.81712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96583 - lat) + Math.Abs(98.63476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.38487 - lat) + Math.Abs(99.90157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.82098 - lat) + Math.Abs(99.7841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53278 - lat) + Math.Abs(98.8637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11072 - lat) + Math.Abs(99.23208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89059 - lat) + Math.Abs(98.3981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52333 - lat) + Math.Abs(99.82275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56781 - lat) + Math.Abs(99.24756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.66511 - lat) + Math.Abs(99.58894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69234 - lat) + Math.Abs(99.84969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.38461 - lat) + Math.Abs(98.69028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56036 - lat) + Math.Abs(99.60703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.19203 - lat) + Math.Abs(99.87883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79089 - lat) + Math.Abs(98.77658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13031 - lat) + Math.Abs(99.69858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85475 - lat) + Math.Abs(98.81267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45091 - lat) + Math.Abs(98.52985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.55395 - lat) + Math.Abs(99.74045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.70908 - lat) + Math.Abs(99.3182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.52617 - lat) + Math.Abs(98.93936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17237 - lat) + Math.Abs(99.68624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.37263 - lat) + Math.Abs(99.83938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.36168 - lat) + Math.Abs(98.43973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.80122 - lat) + Math.Abs(98.35933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.16288 - lat) + Math.Abs(99.69723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.364 - lat) + Math.Abs(99.92939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.39147 - lat) + Math.Abs(99.84147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.75678 - lat) + Math.Abs(99.97814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43333 - lat) + Math.Abs(99.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26167 - lat) + Math.Abs(99.59472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.76803 - lat) + Math.Abs(99.5025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46456 - lat) + Math.Abs(99.14026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.13411 - lat) + Math.Abs(99.51389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.65633 - lat) + Math.Abs(99.54367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.71667 - lat) + Math.Abs(98.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.43353 - lat) + Math.Abs(99.87617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.98403 - lat) + Math.Abs(98.51665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.44688 - lat) + Math.Abs(99.1142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27561 - lat) + Math.Abs(99.65045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38181 - lat) + Math.Abs(97.94372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.30029 - lat) + Math.Abs(97.96852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.14675 - lat) + Math.Abs(99.85256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.49926 - lat) + Math.Abs(98.36494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07422 - lat) + Math.Abs(99.83073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.80269 - lat) + Math.Abs(98.95097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11646 - lat) + Math.Abs(98.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.751 - lat) + Math.Abs(99.78925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.59522 - lat) + Math.Abs(99.77431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37097 - lat) + Math.Abs(99.80564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.45289 - lat) + Math.Abs(99.57606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.60003 - lat) + Math.Abs(99.84889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88492 - lat) + Math.Abs(99.78836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94561 - lat) + Math.Abs(99.07847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.58054 - lat) + Math.Abs(99.00745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29232 - lat) + Math.Abs(99.49277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.76789 - lat) + Math.Abs(99.09256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.08283 - lat) + Math.Abs(99.85431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40429 - lat) + Math.Abs(98.77266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07257 - lat) + Math.Abs(98.91052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11013 - lat) + Math.Abs(98.59231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40272 - lat) + Math.Abs(99.94972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.95197 - lat) + Math.Abs(99.97769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53362 - lat) + Math.Abs(99.08647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19225 - lat) + Math.Abs(99.39433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19397 - lat) + Math.Abs(98.41514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.82958 - lat) + Math.Abs(97.93347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.9375 - lat) + Math.Abs(99.14457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.20331 - lat) + Math.Abs(99.31997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.21633 - lat) + Math.Abs(99.71906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.0302 - lat) + Math.Abs(98.95286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.83333 - lat) + Math.Abs(99.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84295 - lat) + Math.Abs(99.19856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.24025 - lat) + Math.Abs(99.82428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26549 - lat) + Math.Abs(99.05124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.0617 - lat) + Math.Abs(99.86058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91779 - lat) + Math.Abs(98.33322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69697 - lat) + Math.Abs(98.40914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58522 - lat) + Math.Abs(98.59611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40542 - lat) + Math.Abs(99.51561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.16611 - lat) + Math.Abs(99.47014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.00412 - lat) + Math.Abs(99.54832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.48344 - lat) + Math.Abs(99.52153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78937 - lat) + Math.Abs(99.63469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.29095 - lat) + Math.Abs(99.61661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.57065 - lat) + Math.Abs(99.95876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19317 - lat) + Math.Abs(98.61039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.68703 - lat) + Math.Abs(98.91939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32883 - lat) + Math.Abs(99.34621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.91689 - lat) + Math.Abs(99.2145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.16242 - lat) + Math.Abs(99.99342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.95286 - lat) + Math.Abs(98.68458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.84183 - lat) + Math.Abs(99.69756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51825 - lat) + Math.Abs(99.95469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4957 - lat) + Math.Abs(99.17971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41742 - lat) + Math.Abs(98.67428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62 - lat) + Math.Abs(99.59169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.90858 - lat) + Math.Abs(99.8325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.79038 - lat) + Math.Abs(98.98468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.36542 - lat) + Math.Abs(98.96453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42614 - lat) + Math.Abs(99.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.38625 - lat) + Math.Abs(99.19861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46222 - lat) + Math.Abs(99.07631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.71267 - lat) + Math.Abs(99.55758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8 - lat) + Math.Abs(99.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.32517 - lat) + Math.Abs(99.51467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.37972 - lat) + Math.Abs(98.44644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.8802 - lat) + Math.Abs(99.6105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.67441 - lat) + Math.Abs(99.26903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.10957 - lat) + Math.Abs(99.75586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00301 - lat) + Math.Abs(99.0278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.92081 - lat) + Math.Abs(99.76553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.04325 - lat) + Math.Abs(99.08128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53567 - lat) + Math.Abs(99.93567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77965 - lat) + Math.Abs(98.32532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08417 - lat) + Math.Abs(99.52108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81629 - lat) + Math.Abs(99.87739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.93558 - lat) + Math.Abs(99.98129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95458 - lat) + Math.Abs(98.58989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07143 - lat) + Math.Abs(98.99933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60784 - lat) + Math.Abs(99.45783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.27613 - lat) + Math.Abs(99.8664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9501 - lat) + Math.Abs(99.93899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.80036 - lat) + Math.Abs(99.36372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88361 - lat) + Math.Abs(99.31014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.01717 - lat) + Math.Abs(99.73283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12713 - lat) + Math.Abs(98.30738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.0515 - lat) + Math.Abs(99.91701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20468 - lat) + Math.Abs(99.97959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93599 - lat) + Math.Abs(98.39664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61501 - lat) + Math.Abs(98.23994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43047 - lat) + Math.Abs(99.40967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82125 - lat) + Math.Abs(98.30703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84769 - lat) + Math.Abs(98.2985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.90742 - lat) + Math.Abs(99.64795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.3275 - lat) + Math.Abs(99.66767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33086 - lat) + Math.Abs(98.81925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.16667 - lat) + Math.Abs(99.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.07535 - lat) + Math.Abs(99.44152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.21259 - lat) + Math.Abs(99.51167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69157 - lat) + Math.Abs(99.92982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46906 - lat) + Math.Abs(99.94021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02689 - lat) + Math.Abs(99.47372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.9609 - lat) + Math.Abs(100.07888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46098 - lat) + Math.Abs(98.77767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.85339 - lat) + Math.Abs(99.41042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.00683 - lat) + Math.Abs(99.57497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0458 - lat) + Math.Abs(98.81035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37803 - lat) + Math.Abs(98.72117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.42436 - lat) + Math.Abs(99.95688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.56778 - lat) + Math.Abs(99.62528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.21006 - lat) + Math.Abs(100.83076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85647 - lat) + Math.Abs(100.98459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.65 - lat) + Math.Abs(103.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.71668 - lat) + Math.Abs(103.22781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.71945 - lat) + Math.Abs(99.99511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.68361 - lat) + Math.Abs(103.10311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4206 - lat) + Math.Abs(102.89282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79583 - lat) + Math.Abs(104.67017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.86322 - lat) + Math.Abs(103.54106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.30868 - lat) + Math.Abs(101.55045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.50528 - lat) + Math.Abs(100.47103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.90851 - lat) + Math.Abs(104.39101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.06507 - lat) + Math.Abs(102.02965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58044 - lat) + Math.Abs(102.59689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.2675 - lat) + Math.Abs(103.22472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.16261 - lat) + Math.Abs(102.57272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.8043 - lat) + Math.Abs(102.33647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.24592 - lat) + Math.Abs(100.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.12356 - lat) + Math.Abs(101.85789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61117 - lat) + Math.Abs(103.99484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.89747 - lat) + Math.Abs(102.14981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.89749 - lat) + Math.Abs(105.29318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87686 - lat) + Math.Abs(98.86592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.95856 - lat) + Math.Abs(100.55683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15951 - lat) + Math.Abs(104.03615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.20411 - lat) + Math.Abs(100.54508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.30154 - lat) + Math.Abs(101.36365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98333 - lat) + Math.Abs(102.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.96039 - lat) + Math.Abs(103.18911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.19648 - lat) + Math.Abs(102.75959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01791 - lat) + Math.Abs(103.30388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.10839 - lat) + Math.Abs(103.17551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.57925 - lat) + Math.Abs(103.54033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.64172 - lat) + Math.Abs(100.83272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.928 - lat) + Math.Abs(101.88382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.82936 - lat) + Math.Abs(100.96431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34917 - lat) + Math.Abs(100.49522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61073 - lat) + Math.Abs(103.07923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.3072 - lat) + Math.Abs(102.18886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.51678 - lat) + Math.Abs(101.651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40297 - lat) + Math.Abs(101.70625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.79408 - lat) + Math.Abs(104.1451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.86617 - lat) + Math.Abs(101.36894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69634 - lat) + Math.Abs(100.54212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.39982 - lat) + Math.Abs(103.36785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26453 - lat) + Math.Abs(104.39769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.75986 - lat) + Math.Abs(101.29339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53995 - lat) + Math.Abs(101.28128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4797 - lat) + Math.Abs(101.132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5945 - lat) + Math.Abs(100.33825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.34586 - lat) + Math.Abs(100.98942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65778 - lat) + Math.Abs(101.10603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.59856 - lat) + Math.Abs(100.74103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74462 - lat) + Math.Abs(102.31863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25987 - lat) + Math.Abs(100.0404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.98114 - lat) + Math.Abs(100.33195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.19319 - lat) + Math.Abs(104.8628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.29409 - lat) + Math.Abs(103.63816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.84523 - lat) + Math.Abs(103.37678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.72229 - lat) + Math.Abs(104.74135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.63391 - lat) + Math.Abs(103.75241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.82458 - lat) + Math.Abs(100.42936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.30097 - lat) + Math.Abs(101.7685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.95294 - lat) + Math.Abs(103.4365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.22689 - lat) + Math.Abs(100.7155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.50325 - lat) + Math.Abs(102.18115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.94783 - lat) + Math.Abs(104.23097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93646 - lat) + Math.Abs(101.52303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.3885 - lat) + Math.Abs(100.53801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.95547 - lat) + Math.Abs(102.5469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8035 - lat) + Math.Abs(102.41614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.62557 - lat) + Math.Abs(100.09421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11161 - lat) + Math.Abs(104.14011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.37939 - lat) + Math.Abs(100.0245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.36278 - lat) + Math.Abs(100.67203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.41567 - lat) + Math.Abs(102.78589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23844 - lat) + Math.Abs(104.84866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.75269 - lat) + Math.Abs(102.63245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.48181 - lat) + Math.Abs(100.11281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.24364 - lat) + Math.Abs(102.51514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61183 - lat) + Math.Abs(105.02147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.47167 - lat) + Math.Abs(103.26033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.725 - lat) + Math.Abs(100.48511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.68508 - lat) + Math.Abs(100.19456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.39247 - lat) + Math.Abs(101.45061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.95772 - lat) + Math.Abs(99.90555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.811 - lat) + Math.Abs(100.50333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.0385 - lat) + Math.Abs(103.74647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.12189 - lat) + Math.Abs(100.81106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.57605 - lat) + Math.Abs(104.59906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3195 - lat) + Math.Abs(103.67542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.93636 - lat) + Math.Abs(104.71039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.64218 - lat) + Math.Abs(100.47839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.56739 - lat) + Math.Abs(100.72598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.79112 - lat) + Math.Abs(100.37611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.16003 - lat) + Math.Abs(100.59656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.02114 - lat) + Math.Abs(100.73433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.16739 - lat) + Math.Abs(101.18008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.62137 - lat) + Math.Abs(102.00481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.07124 - lat) + Math.Abs(101.09801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.62355 - lat) + Math.Abs(101.42099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.93953 - lat) + Math.Abs(103.24586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76142 - lat) + Math.Abs(100.38989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.85003 - lat) + Math.Abs(102.58139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.00308 - lat) + Math.Abs(102.80541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.22095 - lat) + Math.Abs(100.41978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.99689 - lat) + Math.Abs(104.16672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31569 - lat) + Math.Abs(105.15464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.33922 - lat) + Math.Abs(100.11167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77698 - lat) + Math.Abs(100.4567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26336 - lat) + Math.Abs(100.34378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.25947 - lat) + Math.Abs(102.05461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.60348 - lat) + Math.Abs(103.80207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.56292 - lat) + Math.Abs(102.27989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88181 - lat) + Math.Abs(103.49364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.47418 - lat) + Math.Abs(100.12218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8992 - lat) + Math.Abs(101.82075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0494 - lat) + Math.Abs(100.11457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.07239 - lat) + Math.Abs(101.87172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.02977 - lat) + Math.Abs(101.96586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93889 - lat) + Math.Abs(101.77077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0772 - lat) + Math.Abs(103.4432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.22408 - lat) + Math.Abs(100.02094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.19882 - lat) + Math.Abs(100.5951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47204 - lat) + Math.Abs(100.18346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70462 - lat) + Math.Abs(103.74935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.42642 - lat) + Math.Abs(102.46058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.45214 - lat) + Math.Abs(101.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.97361 - lat) + Math.Abs(103.21644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.62745 - lat) + Math.Abs(104.25069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.23137 - lat) + Math.Abs(101.50048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11481 - lat) + Math.Abs(104.32938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79328 - lat) + Math.Abs(104.46922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17372 - lat) + Math.Abs(100.93111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61992 - lat) + Math.Abs(100.14483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88786 - lat) + Math.Abs(100.40464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.49315 - lat) + Math.Abs(105.27624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.96597 - lat) + Math.Abs(101.51303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.94418 - lat) + Math.Abs(103.79704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.89225 - lat) + Math.Abs(101.72314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.79878 - lat) + Math.Abs(102.18466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.95639 - lat) + Math.Abs(102.58667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.96705 - lat) + Math.Abs(102.27607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.03972 - lat) + Math.Abs(104.66939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.327 - lat) + Math.Abs(100.40433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02992 - lat) + Math.Abs(103.93826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.92851 - lat) + Math.Abs(103.95519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.47531 - lat) + Math.Abs(103.45753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.74642 - lat) + Math.Abs(100.32942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62314 - lat) + Math.Abs(100.06676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.29703 - lat) + Math.Abs(103.29192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66644 - lat) + Math.Abs(100.90073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47303 - lat) + Math.Abs(100.43908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.53333 - lat) + Math.Abs(100.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55083 - lat) + Math.Abs(100.84436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.14616 - lat) + Math.Abs(100.24215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2036 - lat) + Math.Abs(103.76054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.04733 - lat) + Math.Abs(100.16178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06389 - lat) + Math.Abs(102.27364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.82649 - lat) + Math.Abs(103.09262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6362 - lat) + Math.Abs(103.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.65864 - lat) + Math.Abs(101.43906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41456 - lat) + Math.Abs(100.00264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54753 - lat) + Math.Abs(100.27362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59934 - lat) + Math.Abs(100.59675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.02258 - lat) + Math.Abs(103.93631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72698 - lat) + Math.Abs(100.21526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73147 - lat) + Math.Abs(100.51414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.50653 - lat) + Math.Abs(100.20497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60735 - lat) + Math.Abs(100.2186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0655 - lat) + Math.Abs(100.52264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75763 - lat) + Math.Abs(100.08992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.16116 - lat) + Math.Abs(104.14725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81411 - lat) + Math.Abs(102.07222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.97915 - lat) + Math.Abs(100.31209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.94495 - lat) + Math.Abs(104.20812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.70131 - lat) + Math.Abs(101.61675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.71236 - lat) + Math.Abs(103.5202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63883 - lat) + Math.Abs(100.42342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6175 - lat) + Math.Abs(100.95189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.39364 - lat) + Math.Abs(101.51847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.33903 - lat) + Math.Abs(100.31736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.26943 - lat) + Math.Abs(103.74689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.0567 - lat) + Math.Abs(103.65309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.05157 - lat) + Math.Abs(104.67709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.68095 - lat) + Math.Abs(101.25798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.13478 - lat) + Math.Abs(100.25647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31788 - lat) + Math.Abs(103.84859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.68219 - lat) + Math.Abs(100.50603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34466 - lat) + Math.Abs(104.15476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77768 - lat) + Math.Abs(100.32134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29678 - lat) + Math.Abs(101.72844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.47862 - lat) + Math.Abs(101.42414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.86978 - lat) + Math.Abs(102.90767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.17503 - lat) + Math.Abs(100.91622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.53319 - lat) + Math.Abs(102.72283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.64039 - lat) + Math.Abs(103.40447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85672 - lat) + Math.Abs(104.03981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60592 - lat) + Math.Abs(103.12081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.43817 - lat) + Math.Abs(102.72558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.04992 - lat) + Math.Abs(101.36864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06442 - lat) + Math.Abs(101.51503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.90575 - lat) + Math.Abs(102.26225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.14931 - lat) + Math.Abs(100.27522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75822 - lat) + Math.Abs(100.51325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.97122 - lat) + Math.Abs(101.21463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.18064 - lat) + Math.Abs(104.52606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58467 - lat) + Math.Abs(101.28403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.65259 - lat) + Math.Abs(102.37555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.54783 - lat) + Math.Abs(103.02467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.4538 - lat) + Math.Abs(101.36231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.64888 - lat) + Math.Abs(101.90097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.1392 - lat) + Math.Abs(101.66392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.88425 - lat) + Math.Abs(101.88467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.3765 - lat) + Math.Abs(102.12853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.03352 - lat) + Math.Abs(100.2019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79086 - lat) + Math.Abs(100.45325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.3293 - lat) + Math.Abs(102.65182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.65855 - lat) + Math.Abs(100.53362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.72526 - lat) + Math.Abs(100.79536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.35167 - lat) + Math.Abs(100.57739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.70185 - lat) + Math.Abs(100.60157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.74833 - lat) + Math.Abs(104.36261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.14589 - lat) + Math.Abs(100.14103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66731 - lat) + Math.Abs(100.40878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.09269 - lat) + Math.Abs(100.26089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.82586 - lat) + Math.Abs(105.26064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.30006 - lat) + Math.Abs(103.97786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48797 - lat) + Math.Abs(103.99642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02106 - lat) + Math.Abs(103.07664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03333 - lat) + Math.Abs(103.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.816 - lat) + Math.Abs(102.59981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.32827 - lat) + Math.Abs(103.77033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.82481 - lat) + Math.Abs(100.25858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.22324 - lat) + Math.Abs(102.49473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.44184 - lat) + Math.Abs(100.34879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.28764 - lat) + Math.Abs(100.0867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.24467 - lat) + Math.Abs(105.22908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.41904 - lat) + Math.Abs(101.16056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.69614 - lat) + Math.Abs(102.90689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.45525 - lat) + Math.Abs(100.13533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.51631 - lat) + Math.Abs(103.19367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61786 - lat) + Math.Abs(100.07792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71466 - lat) + Math.Abs(100.43691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46804 - lat) + Math.Abs(101.09532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74872 - lat) + Math.Abs(101.34888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.67783 - lat) + Math.Abs(104.11025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.35245 - lat) + Math.Abs(103.85032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.39051 - lat) + Math.Abs(103.71692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44581 - lat) + Math.Abs(101.18445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.68231 - lat) + Math.Abs(104.84603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.45736 - lat) + Math.Abs(100.36989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.60003 - lat) + Math.Abs(100.64937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.44914 - lat) + Math.Abs(100.72833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26942 - lat) + Math.Abs(100.17036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.84922 - lat) + Math.Abs(100.15358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.86814 - lat) + Math.Abs(101.25009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.83281 - lat) + Math.Abs(104.38673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.01346 - lat) + Math.Abs(100.53049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.6345 - lat) + Math.Abs(103.34325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.86192 - lat) + Math.Abs(101.49103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48989 - lat) + Math.Abs(100.44847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7226 - lat) + Math.Abs(102.02512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.16308 - lat) + Math.Abs(101.26886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34219 - lat) + Math.Abs(100.31747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35109 - lat) + Math.Abs(100.20195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.91301 - lat) + Math.Abs(100.49883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30556 - lat) + Math.Abs(103.30441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.70802 - lat) + Math.Abs(101.41614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.50489 - lat) + Math.Abs(99.99241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.12117 - lat) + Math.Abs(101.00364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1958 - lat) + Math.Abs(102.07145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86075 - lat) + Math.Abs(100.51477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.18014 - lat) + Math.Abs(102.25695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.8687 - lat) + Math.Abs(102.56642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.97914 - lat) + Math.Abs(102.89369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91666 - lat) + Math.Abs(104.72522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15515 - lat) + Math.Abs(101.37226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.48299 - lat) + Math.Abs(104.34712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13478 - lat) + Math.Abs(100.82503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.16739 - lat) + Math.Abs(102.78081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.49208 - lat) + Math.Abs(100.78431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.49333 - lat) + Math.Abs(102.43339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.31006 - lat) + Math.Abs(104.20247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.99025 - lat) + Math.Abs(101.06183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.68679 - lat) + Math.Abs(102.538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.87847 - lat) + Math.Abs(102.742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.70528 - lat) + Math.Abs(100.34923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.34062 - lat) + Math.Abs(100.86733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.84782 - lat) + Math.Abs(102.68401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.36083 - lat) + Math.Abs(103.10533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.85585 - lat) + Math.Abs(100.86216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84356 - lat) + Math.Abs(101.17803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73947 - lat) + Math.Abs(102.36564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75314 - lat) + Math.Abs(101.76396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.20406 - lat) + Math.Abs(102.44068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.07978 - lat) + Math.Abs(101.80225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.86458 - lat) + Math.Abs(100.58581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.56667 - lat) + Math.Abs(100.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.18314 - lat) + Math.Abs(103.71842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.37167 - lat) + Math.Abs(104.55147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.4897 - lat) + Math.Abs(104.10056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.74192 - lat) + Math.Abs(100.69139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.42639 - lat) + Math.Abs(101.82308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.64113 - lat) + Math.Abs(102.95462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32639 - lat) + Math.Abs(100.71417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6377 - lat) + Math.Abs(102.79138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.78378 - lat) + Math.Abs(100.77899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18931 - lat) + Math.Abs(100.66047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.77036 - lat) + Math.Abs(102.18947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70228 - lat) + Math.Abs(102.85569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.72806 - lat) + Math.Abs(100.68433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.57653 - lat) + Math.Abs(103.78711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.76753 - lat) + Math.Abs(101.66917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.92731 - lat) + Math.Abs(104.51303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.10056 - lat) + Math.Abs(100.83739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.70472 - lat) + Math.Abs(100.13717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.97066 - lat) + Math.Abs(102.10196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.41081 - lat) + Math.Abs(104.77856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8196 - lat) + Math.Abs(100.04427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.20463 - lat) + Math.Abs(101.21295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46281 - lat) + Math.Abs(100.60832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80126 - lat) + Math.Abs(100.18451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.94645 - lat) + Math.Abs(104.50081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.79339 - lat) + Math.Abs(103.03184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.52046 - lat) + Math.Abs(105.24478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.54531 - lat) + Math.Abs(104.72351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.82192 - lat) + Math.Abs(103.72884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.51307 - lat) + Math.Abs(104.72565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81407 - lat) + Math.Abs(100.73135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.38944 - lat) + Math.Abs(104.1572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.71864 - lat) + Math.Abs(101.40983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.30997 - lat) + Math.Abs(100.08283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.13048 - lat) + Math.Abs(102.53712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67292 - lat) + Math.Abs(102.19575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60975 - lat) + Math.Abs(101.66686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.18483 - lat) + Math.Abs(103.30067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.53367 - lat) + Math.Abs(100.52672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.52935 - lat) + Math.Abs(104.23847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.70614 - lat) + Math.Abs(101.0057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79808 - lat) + Math.Abs(100.65397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.77983 - lat) + Math.Abs(101.24225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.88614 - lat) + Math.Abs(101.22894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.2075 - lat) + Math.Abs(104.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.49052 - lat) + Math.Abs(101.72749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03728 - lat) + Math.Abs(100.40486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.16572 - lat) + Math.Abs(100.30789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.65211 - lat) + Math.Abs(100.03892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.0252 - lat) + Math.Abs(102.83894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93226 - lat) + Math.Abs(100.74937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.72205 - lat) + Math.Abs(103.66934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.41142 - lat) + Math.Abs(102.85936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48164 - lat) + Math.Abs(102.07375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17169 - lat) + Math.Abs(102.39489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.79267 - lat) + Math.Abs(104.99814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.03289 - lat) + Math.Abs(104.33936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.4257 - lat) + Math.Abs(102.56692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.08882 - lat) + Math.Abs(103.81875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.33259 - lat) + Math.Abs(104.33147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.10875 - lat) + Math.Abs(103.01487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.541 - lat) + Math.Abs(104.05004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75398 - lat) + Math.Abs(100.50144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.55589 - lat) + Math.Abs(100.07153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6533 - lat) + Math.Abs(100.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.92375 - lat) + Math.Abs(103.30369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61548 - lat) + Math.Abs(100.32842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70672 - lat) + Math.Abs(103.07878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.24858 - lat) + Math.Abs(103.06739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.16389 - lat) + Math.Abs(100.80547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.77972 - lat) + Math.Abs(101.64831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61739 - lat) + Math.Abs(104.42506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2716 - lat) + Math.Abs(103.00167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71358 - lat) + Math.Abs(104.19836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.19138 - lat) + Math.Abs(100.35355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7347 - lat) + Math.Abs(100.00931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84538 - lat) + Math.Abs(100.07148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.38989 - lat) + Math.Abs(104.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.78758 - lat) + Math.Abs(100.07778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36998 - lat) + Math.Abs(104.35231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.93192 - lat) + Math.Abs(102.28103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.61286 - lat) + Math.Abs(101.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.44671 - lat) + Math.Abs(102.833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31856 - lat) + Math.Abs(105.49506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.44393 - lat) + Math.Abs(102.32862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.52541 - lat) + Math.Abs(102.24591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.04507 - lat) + Math.Abs(104.2756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06649 - lat) + Math.Abs(100.72233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73064 - lat) + Math.Abs(101.09619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.37927 - lat) + Math.Abs(100.8187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45467 - lat) + Math.Abs(102.22142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77645 - lat) + Math.Abs(102.88567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73086 - lat) + Math.Abs(100.50903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06467 - lat) + Math.Abs(100.64578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45177 - lat) + Math.Abs(102.29823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.04252 - lat) + Math.Abs(105.21836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70008 - lat) + Math.Abs(104.09019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.35353 - lat) + Math.Abs(102.4355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46125 - lat) + Math.Abs(100.13372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.96083 - lat) + Math.Abs(101.94789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.85231 - lat) + Math.Abs(103.75657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33221 - lat) + Math.Abs(102.17278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.92902 - lat) + Math.Abs(103.63518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65233 - lat) + Math.Abs(104.30861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.57764 - lat) + Math.Abs(104.41956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65558 - lat) + Math.Abs(103.58361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.28053 - lat) + Math.Abs(101.95422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.85053 - lat) + Math.Abs(100.07914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.32719 - lat) + Math.Abs(103.29864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.10323 - lat) + Math.Abs(104.57343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.64056 - lat) + Math.Abs(104.64992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4112 - lat) + Math.Abs(101.27394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0857 - lat) + Math.Abs(101.87959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41536 - lat) + Math.Abs(101.05456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.22553 - lat) + Math.Abs(101.81128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99966 - lat) + Math.Abs(99.98981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.33839 - lat) + Math.Abs(103.57564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.43281 - lat) + Math.Abs(103.50658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58617 - lat) + Math.Abs(100.99758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.10864 - lat) + Math.Abs(102.25808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02397 - lat) + Math.Abs(103.38444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.95114 - lat) + Math.Abs(101.71769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.00787 - lat) + Math.Abs(100.32691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.6971 - lat) + Math.Abs(104.4916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04408 - lat) + Math.Abs(100.30586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.05333 - lat) + Math.Abs(104.02754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.99701 - lat) + Math.Abs(102.64746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.65038 - lat) + Math.Abs(103.91005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.58975 - lat) + Math.Abs(103.23547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.00836 - lat) + Math.Abs(100.47668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98122 - lat) + Math.Abs(100.0147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99948 - lat) + Math.Abs(100.88014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7775 - lat) + Math.Abs(100.51977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.31697 - lat) + Math.Abs(104.92 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.81589 - lat) + Math.Abs(104.538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63497 - lat) + Math.Abs(100.02097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(100.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.90598 - lat) + Math.Abs(105.07836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.98372 - lat) + Math.Abs(100.05217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.28011 - lat) + Math.Abs(101.14686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2085 - lat) + Math.Abs(101.77138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34861 - lat) + Math.Abs(102.74161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34862 - lat) + Math.Abs(103.39217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.5443 - lat) + Math.Abs(102.09924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.08861 - lat) + Math.Abs(102.62178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.18953 - lat) + Math.Abs(100.85958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3622 - lat) + Math.Abs(100.98345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11814 - lat) + Math.Abs(103.60743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.72844 - lat) + Math.Abs(102.16524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16936 - lat) + Math.Abs(100.14469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.41042 - lat) + Math.Abs(103.09767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.27511 - lat) + Math.Abs(100.08689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.29378 - lat) + Math.Abs(100.86169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.26125 - lat) + Math.Abs(100.40461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.89382 - lat) + Math.Abs(101.65997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.52331 - lat) + Math.Abs(100.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96773 - lat) + Math.Abs(99.99985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.84572 - lat) + Math.Abs(103.55719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.56542 - lat) + Math.Abs(101.84547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.27606 - lat) + Math.Abs(100.60022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.23356 - lat) + Math.Abs(105.0005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.60961 - lat) + Math.Abs(102.10447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.09914 - lat) + Math.Abs(101.69353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91542 - lat) + Math.Abs(100.74039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.00508 - lat) + Math.Abs(102.27033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.64878 - lat) + Math.Abs(100.47878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.81047 - lat) + Math.Abs(102.02881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.29447 - lat) + Math.Abs(103.23385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.18636 - lat) + Math.Abs(100.12353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2 - lat) + Math.Abs(101.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6882 - lat) + Math.Abs(101.07156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.99433 - lat) + Math.Abs(103.10392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75639 - lat) + Math.Abs(105.41147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.83024 - lat) + Math.Abs(100.91938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96129 - lat) + Math.Abs(104.04667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36303 - lat) + Math.Abs(103.65194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58552 - lat) + Math.Abs(102.42587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.52814 - lat) + Math.Abs(103.94567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.27825 - lat) + Math.Abs(101.44028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.57283 - lat) + Math.Abs(102.53714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.04179 - lat) + Math.Abs(103.11506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.15029 - lat) + Math.Abs(101.1556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.77434 - lat) + Math.Abs(101.07231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.34147 - lat) + Math.Abs(100.79317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.84228 - lat) + Math.Abs(101.1255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.62161 - lat) + Math.Abs(100.48739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.40506 - lat) + Math.Abs(102.34239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.35964 - lat) + Math.Abs(100.70042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01667 - lat) + Math.Abs(103.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.24158 - lat) + Math.Abs(105.0922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99503 - lat) + Math.Abs(101.22095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.74219 - lat) + Math.Abs(100.09531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78211 - lat) + Math.Abs(101.28133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.68877 - lat) + Math.Abs(102.47878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.64681 - lat) + Math.Abs(100.57617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59864 - lat) + Math.Abs(101.07956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.62824 - lat) + Math.Abs(101.43757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93333 - lat) + Math.Abs(100.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.14272 - lat) + Math.Abs(102.97261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.05997 - lat) + Math.Abs(102.73097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59072 - lat) + Math.Abs(100.10748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96507 - lat) + Math.Abs(104.21534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02061 - lat) + Math.Abs(101.89828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26464 - lat) + Math.Abs(100.18967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.68488 - lat) + Math.Abs(100.7094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06367 - lat) + Math.Abs(105.05994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.78153 - lat) + Math.Abs(101.82256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.78491 - lat) + Math.Abs(104.09082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26638 - lat) + Math.Abs(101.26461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.76384 - lat) + Math.Abs(104.02626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.48536 - lat) + Math.Abs(101.06808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11517 - lat) + Math.Abs(101.78189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.26238 - lat) + Math.Abs(101.07111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.8508 - lat) + Math.Abs(103.56939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.65287 - lat) + Math.Abs(101.20022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61544 - lat) + Math.Abs(100.72731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.04428 - lat) + Math.Abs(100.53681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.66114 - lat) + Math.Abs(101.23958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.88969 - lat) + Math.Abs(100.30589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.84969 - lat) + Math.Abs(100.43725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.60916 - lat) + Math.Abs(102.12928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4183 - lat) + Math.Abs(104.92363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.97738 - lat) + Math.Abs(100.77776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.09398 - lat) + Math.Abs(103.00998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.42313 - lat) + Math.Abs(103.09974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.92419 - lat) + Math.Abs(100.78794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.77772 - lat) + Math.Abs(101.9072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.83824 - lat) + Math.Abs(102.62254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79717 - lat) + Math.Abs(100.3065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02614 - lat) + Math.Abs(101.06772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.79131 - lat) + Math.Abs(101.16353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.89865 - lat) + Math.Abs(100.38885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6535 - lat) + Math.Abs(102.08825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.78261 - lat) + Math.Abs(101.29639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.47486 - lat) + Math.Abs(103.59439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55968 - lat) + Math.Abs(101.53426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.74954 - lat) + Math.Abs(102.25484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.00825 - lat) + Math.Abs(101.90608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.84341 - lat) + Math.Abs(100.36251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.33433 - lat) + Math.Abs(100.30378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.75847 - lat) + Math.Abs(100.11742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73058 - lat) + Math.Abs(100.52388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.892 - lat) + Math.Abs(100.31728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.39604 - lat) + Math.Abs(100.1587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54297 - lat) + Math.Abs(100.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.22783 - lat) + Math.Abs(100.57589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46217 - lat) + Math.Abs(100.54478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.84739 - lat) + Math.Abs(101.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02781 - lat) + Math.Abs(100.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.02188 - lat) + Math.Abs(100.17183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.04704 - lat) + Math.Abs(100.92891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.805 - lat) + Math.Abs(100.47283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.57831 - lat) + Math.Abs(100.30034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72319 - lat) + Math.Abs(100.476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76266 - lat) + Math.Abs(100.47798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66302 - lat) + Math.Abs(100.43416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72144 - lat) + Math.Abs(101.20814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7653 - lat) + Math.Abs(100.647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.91783 - lat) + Math.Abs(100.42403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.57428 - lat) + Math.Abs(100.83533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.37395 - lat) + Math.Abs(100.48528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.45331 - lat) + Math.Abs(102.63892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.699 - lat) + Math.Abs(103.25957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.59175 - lat) + Math.Abs(100.62828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.72543 - lat) + Math.Abs(101.05531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78629 - lat) + Math.Abs(102.82277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01353 - lat) + Math.Abs(102.41289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.311 - lat) + Math.Abs(101.11214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.1712 - lat) + Math.Abs(100.12531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.07147 - lat) + Math.Abs(101.00314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66744 - lat) + Math.Abs(100.64206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08953 - lat) + Math.Abs(100.41075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.42947 - lat) + Math.Abs(100.17803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99904 - lat) + Math.Abs(100.54962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58333 - lat) + Math.Abs(100.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.9727 - lat) + Math.Abs(102.31168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.69476 - lat) + Math.Abs(104.64846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.50189 - lat) + Math.Abs(101.68982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.84308 - lat) + Math.Abs(103.87839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69276 - lat) + Math.Abs(102.50128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58839 - lat) + Math.Abs(100.45283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.85851 - lat) + Math.Abs(104.62883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.59639 - lat) + Math.Abs(103.9816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03143 - lat) + Math.Abs(103.70996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.67639 - lat) + Math.Abs(100.46861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.00781 - lat) + Math.Abs(104.78419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3303 - lat) + Math.Abs(104.04485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.33628 - lat) + Math.Abs(103.47547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.61822 - lat) + Math.Abs(101.4265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.89944 - lat) + Math.Abs(101.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.44575 - lat) + Math.Abs(103.30508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61342 - lat) + Math.Abs(99.03651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8894 - lat) + Math.Abs(98.38523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.75778 - lat) + Math.Abs(100.02914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.09808 - lat) + Math.Abs(99.83809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81003 - lat) + Math.Abs(100.53714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.91392 - lat) + Math.Abs(100.58994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.802 - lat) + Math.Abs(100.32111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71669 - lat) + Math.Abs(100.57159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89607 - lat) + Math.Abs(98.29661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.33695 - lat) + Math.Abs(100.13478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.38786 - lat) + Math.Abs(100.87619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72341 - lat) + Math.Abs(100.78436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69196 - lat) + Math.Abs(100.40691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69347 - lat) + Math.Abs(100.5022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78528 - lat) + Math.Abs(100.66958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82893 - lat) + Math.Abs(100.55985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.67717 - lat) + Math.Abs(100.48407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77678 - lat) + Math.Abs(100.579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82609 - lat) + Math.Abs(100.67933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.83616 - lat) + Math.Abs(100.73524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80349 - lat) + Math.Abs(100.60749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73649 - lat) + Math.Abs(100.5239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78005 - lat) + Math.Abs(100.54275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.759 - lat) + Math.Abs(100.53358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.92068 - lat) + Math.Abs(100.64552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77019 - lat) + Math.Abs(100.68531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7085 - lat) + Math.Abs(100.52619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73028 - lat) + Math.Abs(100.65138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78851 - lat) + Math.Abs(100.33334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62875 - lat) + Math.Abs(100.50964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78546 - lat) + Math.Abs(100.61165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72978 - lat) + Math.Abs(100.58536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.51881 - lat) + Math.Abs(98.26042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84468 - lat) + Math.Abs(98.33897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90963 - lat) + Math.Abs(98.40248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.86338 - lat) + Math.Abs(98.36437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.595 - lat) + Math.Abs(100.83042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00171 - lat) + Math.Abs(102.37267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.74044 - lat) + Math.Abs(98.772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77859 - lat) + Math.Abs(98.30661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.70237 - lat) + Math.Abs(99.66539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62675 - lat) + Math.Abs(99.61656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68439 - lat) + Math.Abs(99.64359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.26628 - lat) + Math.Abs(99.79846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.01328 - lat) + Math.Abs(100.05639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.11297 - lat) + Math.Abs(100.51331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.83353 - lat) + Math.Abs(100.25858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.57881 - lat) + Math.Abs(101.08011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.79003 - lat) + Math.Abs(99.69967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.34458 - lat) + Math.Abs(98.42903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.90364 - lat) + Math.Abs(98.8845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23894 - lat) + Math.Abs(98.97861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42043 - lat) + Math.Abs(98.74967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65789 - lat) + Math.Abs(99.46981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.09631 - lat) + Math.Abs(99.48906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.63131 - lat) + Math.Abs(99.34975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.63186 - lat) + Math.Abs(99.11661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99933 - lat) + Math.Abs(99.92161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97467 - lat) + Math.Abs(99.63353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33911 - lat) + Math.Abs(99.90092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07597 - lat) + Math.Abs(99.86947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37094 - lat) + Math.Abs(99.56249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.77988 - lat) + Math.Abs(99.91073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63194 - lat) + Math.Abs(99.55231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.78164 - lat) + Math.Abs(99.51864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.18728 - lat) + Math.Abs(99.97525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.2705 - lat) + Math.Abs(99.97011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17689 - lat) + Math.Abs(100.03581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75186 - lat) + Math.Abs(100.32481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85428 - lat) + Math.Abs(100.09772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.89152 - lat) + Math.Abs(100.30795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.52314 - lat) + Math.Abs(100.14464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.47065 - lat) + Math.Abs(100.33146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.65211 - lat) + Math.Abs(100.03892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6115 - lat) + Math.Abs(100.90825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.9137 - lat) + Math.Abs(100.94169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.74264 - lat) + Math.Abs(100.79951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.82736 - lat) + Math.Abs(101.20273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41658 - lat) + Math.Abs(101.33458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8878 - lat) + Math.Abs(101.40501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.90517 - lat) + Math.Abs(101.42228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.97586 - lat) + Math.Abs(101.68511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44547 - lat) + Math.Abs(101.61133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.41801 - lat) + Math.Abs(101.86113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06442 - lat) + Math.Abs(101.51503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63739 - lat) + Math.Abs(101.61671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.30181 - lat) + Math.Abs(101.95382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.80481 - lat) + Math.Abs(102.11514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.12894 - lat) + Math.Abs(102.21402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36176 - lat) + Math.Abs(102.19105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.56428 - lat) + Math.Abs(102.00128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.08375 - lat) + Math.Abs(102.399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.32444 - lat) + Math.Abs(102.07829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.56292 - lat) + Math.Abs(102.27989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31353 - lat) + Math.Abs(102.74814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.43817 - lat) + Math.Abs(102.72558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55839 - lat) + Math.Abs(102.92475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3535 - lat) + Math.Abs(102.91803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41061 - lat) + Math.Abs(102.54025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.57361 - lat) + Math.Abs(102.83331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.97439 - lat) + Math.Abs(102.66983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.75269 - lat) + Math.Abs(102.63245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.23824 - lat) + Math.Abs(103.00892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.67544 - lat) + Math.Abs(102.75069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73011 - lat) + Math.Abs(103.16728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.99797 - lat) + Math.Abs(103.48789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.26025 - lat) + Math.Abs(103.45828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.55488 - lat) + Math.Abs(103.17661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.5432 - lat) + Math.Abs(103.07992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.17214 - lat) + Math.Abs(103.15303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.55312 - lat) + Math.Abs(103.05794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29789 - lat) + Math.Abs(103.30689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02106 - lat) + Math.Abs(103.07664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76736 - lat) + Math.Abs(103.87392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23764 - lat) + Math.Abs(103.91333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.00244 - lat) + Math.Abs(103.59154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.99397 - lat) + Math.Abs(103.86264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.16328 - lat) + Math.Abs(103.75359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.13873 - lat) + Math.Abs(103.60388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.45711 - lat) + Math.Abs(103.69558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.99891 - lat) + Math.Abs(103.97347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18188 - lat) + Math.Abs(103.74793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.54744 - lat) + Math.Abs(104.13167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.22929 - lat) + Math.Abs(104.0767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.47156 - lat) + Math.Abs(104.07153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.06645 - lat) + Math.Abs(104.44018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.22122 - lat) + Math.Abs(104.28995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.05751 - lat) + Math.Abs(104.45333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.78536 - lat) + Math.Abs(104.09072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73303 - lat) + Math.Abs(104.90897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58386 - lat) + Math.Abs(104.92481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79583 - lat) + Math.Abs(104.67017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.89224 - lat) + Math.Abs(104.90563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.37903 - lat) + Math.Abs(105.02786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.61604 - lat) + Math.Abs(98.77292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.65791 - lat) + Math.Abs(101.02208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26686 - lat) + Math.Abs(102.02024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.68247 - lat) + Math.Abs(102.28511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.32476 - lat) + Math.Abs(103.13343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.20084 - lat) + Math.Abs(105.39222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.54994 - lat) + Math.Abs(102.56675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56991 - lat) + Math.Abs(99.94353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.86322 - lat) + Math.Abs(103.54106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02058 - lat) + Math.Abs(100.66286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.03193 - lat) + Math.Abs(98.28767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21365 - lat) + Math.Abs(103.17967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24034 - lat) + Math.Abs(99.57621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.28425 - lat) + Math.Abs(98.05683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30232 - lat) + Math.Abs(103.97418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.73136 - lat) + Math.Abs(99.13997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.11783 - lat) + Math.Abs(100.09919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.77681 - lat) + Math.Abs(99.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96209 - lat) + Math.Abs(97.93288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.66548 - lat) + Math.Abs(102.49881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.60222 - lat) + Math.Abs(100.5721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.23903 - lat) + Math.Abs(100.55272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.59903 - lat) + Math.Abs(100.32444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.34286 - lat) + Math.Abs(98.45023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84031 - lat) + Math.Abs(99.91773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56167 - lat) + Math.Abs(99.69483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.87486 - lat) + Math.Abs(102.40406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.65856 - lat) + Math.Abs(102.54197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66185 - lat) + Math.Abs(100.39567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76994 - lat) + Math.Abs(100.55299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76512 - lat) + Math.Abs(100.49864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.96199 - lat) + Math.Abs(100.89715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Don Sak", "60", 9.31676, 99.69184);
case 1: return new CityInfo("Thung Sai", "11", 16.31489, 99.83267);
case 2: return new CityInfo("Tham Phannara", "64", 8.42045, 99.39517);
case 3: return new CityInfo("Ban Talat Yai", "62", 7.88481, 98.40008);
case 4: return new CityInfo("Ban Talat Nua", "62", 7.88489, 98.38557);
case 5: return new CityInfo("Sam Roi Yot", "57", 12.27081, 99.87203);
case 6: return new CityInfo("Nopphitam", "64", 8.72206, 99.74878);
case 7: return new CityInfo("Lam Thap", "63", 8.07228, 99.29225);
case 8: return new CityInfo("Ban Huai I Huak", "01", 18.07861, 98.035);
case 9: return new CityInfo("Phrao", "02", 19.36586, 99.20187);
case 10: return new CityInfo("Mae Taeng", "02", 19.11712, 98.94176);
case 11: return new CityInfo("Mae Ai", "02", 20.02883, 99.29833);
case 12: return new CityInfo("Phetchaburi", "56", 13.11189, 99.94467);
case 13: return new CityInfo("Mae Chai", "41", 19.34597, 99.814);
case 14: return new CityInfo("Yan Ta Khao", "65", 7.38622, 99.66692);
case 15: return new CityInfo("Wiang Sa", "60", 8.63585, 99.3666);
case 16: return new CityInfo("Wiang Pa Pao", "03", 19.34778, 99.50722);
case 17: return new CityInfo("Wiang Haeng", "02", 19.557, 98.6425);
case 18: return new CityInfo("Wiang Chai", "03", 19.88361, 99.93314);
case 19: return new CityInfo("Wat Phleng", "52", 13.45407, 99.88637);
case 20: return new CityInfo("Wang Wiset", "65", 7.73631, 99.3987);
case 21: return new CityInfo("Wang Nuea", "06", 19.14678, 99.61933);
case 22: return new CityInfo("U Thong", "51", 14.37514, 99.89225);
case 23: return new CityInfo("Umphang", "08", 16.01622, 98.8627);
case 24: return new CityInfo("Trang", "65", 7.55633, 99.61141);
case 25: return new CityInfo("Thung Yai", "64", 8.30119, 99.36611);
case 26: return new CityInfo("Thung Tako", "58", 10.11022, 99.08306);
case 27: return new CityInfo("Thung Song", "64", 8.16453, 99.68039);
case 28: return new CityInfo("Thung Saliam", "09", 17.32106, 99.56092);
case 29: return new CityInfo("Thong Pha Phum", "50", 14.74345, 98.63101);
case 30: return new CityInfo("Thoen", "06", 17.61289, 99.21612);
case 31: return new CityInfo("Tha Song Yang", "08", 17.22708, 98.22572);
case 32: return new CityInfo("Tha Sala", "64", 8.66733, 99.93078);
case 33: return new CityInfo("Tha Sae", "58", 10.66461, 99.17281);
case 34: return new CityInfo("Thap Than", "15", 15.46063, 99.89166);
case 35: return new CityInfo("Thap Sakae", "57", 11.49964, 99.6217);
case 36: return new CityInfo("Thap Put", "61", 8.51625, 98.63972);
case 37: return new CityInfo("Tha Phae", "67", 6.79014, 99.97005);
case 38: return new CityInfo("Tha Muang", "50", 13.96118, 99.64122);
case 39: return new CityInfo("Tha Maka", "50", 13.9, 99.76667);
case 40: return new CityInfo("Thalang", "62", 8.03169, 98.33408);
case 41: return new CityInfo("Thai Mueang", "61", 8.39914, 98.26061);
case 42: return new CityInfo("Tha Chang", "60", 9.26418, 99.19218);
case 43: return new CityInfo("Tha Chana", "60", 9.57203, 99.16586);
case 44: return new CityInfo("Takua Thung", "61", 8.38373, 98.45123);
case 45: return new CityInfo("Takua Pa", "61", 8.8705, 98.34383);
case 46: return new CityInfo("Tak", "08", 16.86968, 99.12898);
case 47: return new CityInfo("Surat Thani", "60", 9.14011, 99.33311);
case 48: return new CityInfo("Sukhothai", "09", 17.00778, 99.823);
case 49: return new CityInfo("Suan Phueng", "52", 13.5429, 99.33961);
case 50: return new CityInfo("Sop Prap", "06", 17.88053, 99.337);
case 51: return new CityInfo("Soem Ngam", "06", 18.06506, 99.24537);
case 52: return new CityInfo("Si Sawat", "50", 14.59922, 99.11406);
case 53: return new CityInfo("Si Satchanalai", "09", 17.51692, 99.75978);
case 54: return new CityInfo("Si Samrong", "09", 17.164, 99.86222);
case 55: return new CityInfo("Si Nakhon", "09", 17.34907, 99.98563);
case 56: return new CityInfo("Sikao", "65", 7.57158, 99.34494);
case 57: return new CityInfo("Si Banphot", "66", 7.72136, 99.8843);
case 58: return new CityInfo("Sawi", "58", 10.23668, 99.10938);
case 59: return new CityInfo("Sawankhalok", "09", 17.31597, 99.83186);
case 60: return new CityInfo("Sawang Arom", "15", 15.58394, 99.86089);
case 61: return new CityInfo("Saraphi", "02", 18.71417, 99.03528);
case 62: return new CityInfo("San Sai", "02", 18.84792, 99.04508);
case 63: return new CityInfo("San Pa Tong", "02", 18.62828, 98.89572);
case 64: return new CityInfo("San Kamphaeng", "02", 18.74486, 99.11953);
case 65: return new CityInfo("Sangkhla Buri", "50", 15.15553, 98.45361);
case 66: return new CityInfo("Samoeng", "02", 18.84806, 98.73242);
case 67: return new CityInfo("Sam Ngao", "08", 17.24331, 99.02256);
case 68: return new CityInfo("Sai Yok", "50", 14.11899, 99.142);
case 69: return new CityInfo("Sai Ngam", "11", 16.46862, 99.88843);
case 70: return new CityInfo("Ron Phibun", "64", 8.17911, 99.85425);
case 71: return new CityInfo("Ratchaburi", "52", 13.53671, 99.81712);
case 72: return new CityInfo("Ranong", "59", 9.96583, 98.63476);
case 73: return new CityInfo("Pran Buri", "57", 12.38487, 99.90157);
case 74: return new CityInfo("Prachuap Khiri Khan", "57", 11.82098, 99.7841);
case 75: return new CityInfo("Plai Phraya", "63", 8.53278, 98.8637);
case 76: return new CityInfo("Tha Kham", "60", 9.11072, 99.23208);
case 77: return new CityInfo("Phuket", "62", 7.89059, 98.3981);
case 78: return new CityInfo("Phrom Khiri", "64", 8.52333, 99.82275);
case 79: return new CityInfo("Phrasaeng", "60", 8.56781, 99.24756);
case 80: return new CityInfo("Phran Kratai", "11", 16.66511, 99.58894);
case 81: return new CityInfo("Photharam", "52", 13.69234, 99.84969);
case 82: return new CityInfo("Phop Phra", "08", 16.38461, 98.69028);
case 83: return new CityInfo("Phipun", "64", 8.56036, 99.60703);
case 84: return new CityInfo("Phayao", "41", 19.19203, 99.87883);
case 85: return new CityInfo("Phato", "58", 9.79089, 98.77658);
case 86: return new CityInfo("Phanom Thuan", "50", 14.13031, 99.69858);
case 87: return new CityInfo("Phanom", "60", 8.85475, 98.81267);
case 88: return new CityInfo("Phang Nga", "61", 8.45091, 98.52985);
case 89: return new CityInfo("Phan", "03", 19.55395, 99.74045);
case 90: return new CityInfo("Pathio", "58", 10.70908, 99.3182);
case 91: return new CityInfo("Pa Sang", "05", 18.52617, 98.93936);
case 92: return new CityInfo("Palian", "65", 7.17237, 99.68624);
case 93: return new CityInfo("Pak Tho", "52", 13.37263, 99.83938);
case 94: return new CityInfo("Pai", "02", 19.36168, 98.43973);
case 95: return new CityInfo("Om Koi", "02", 17.80122, 98.35933);
case 96: return new CityInfo("Nong Ya Plong", "56", 13.16288, 99.69723);
case 97: return new CityInfo("Nong Kha Yang", "15", 15.364, 99.92939);
case 98: return new CityInfo("Nong Chang", "15", 15.39147, 99.84147);
case 99: return new CityInfo("Ngao", "06", 18.75678, 99.97814);
case 100: return new CityInfo("Nakhon Si Thammarat", "64", 8.43333, 99.96667);
case 101: return new CityInfo("Na Bon", "64", 8.26167, 99.59472);
case 102: return new CityInfo("Mueang Pan", "06", 18.76803, 99.5025);
case 103: return new CityInfo("Mae Tha", "05", 18.46456, 99.14026);
case 104: return new CityInfo("Mae Tha", "06", 18.13411, 99.51389);
case 105: return new CityInfo("Mae Suai", "03", 19.65633, 99.54367);
case 106: return new CityInfo("Mae Sot", "08", 16.71667, 98.56667);
case 107: return new CityInfo("Mae Sai", "03", 20.43353, 99.87617);
case 108: return new CityInfo("Mae Ramat", "08", 16.98403, 98.51665);
case 109: return new CityInfo("Mae Phrik", "06", 17.44688, 99.1142);
case 110: return new CityInfo("Mae Mo", "06", 18.27561, 99.65045);
case 111: return new CityInfo("Mae La Noi", "01", 18.38181, 97.94372);
case 112: return new CityInfo("Mae Hong Son", "01", 19.30029, 97.96852);
case 113: return new CityInfo("Mae Chan", "03", 20.14675, 99.85256);
case 114: return new CityInfo("Mae Chaem", "02", 18.49926, 98.36494);
case 115: return new CityInfo("Long", "07", 18.07422, 99.83073);
case 116: return new CityInfo("Li", "05", 17.80269, 98.95097);
case 117: return new CityInfo("La-Un", "59", 10.11646, 98.75);
case 118: return new CityInfo("Lat Yao", "16", 15.751, 99.78925);
case 119: return new CityInfo("Lao Khwan", "50", 14.59522, 99.77431);
case 120: return new CityInfo("Lan Saka", "64", 8.37097, 99.80564);
case 121: return new CityInfo("Lan Sak", "15", 15.45289, 99.57606);
case 122: return new CityInfo("Lan Krabue", "11", 16.60003, 99.84889);
case 123: return new CityInfo("La-ngu", "67", 6.88492, 99.78836);
case 124: return new CityInfo("Lang Suan", "58", 9.94561, 99.07847);
case 125: return new CityInfo("Lamphun", "05", 18.58054, 99.00745);
case 126: return new CityInfo("Lampang", "06", 18.29232, 99.49277);
case 127: return new CityInfo("Lamae", "58", 9.76789, 99.09256);
case 128: return new CityInfo("Kui Buri", "57", 12.08283, 99.85431);
case 129: return new CityInfo("Kra Buri", "59", 10.40429, 98.77266);
case 130: return new CityInfo("Krabi", "63", 8.07257, 98.91052);
case 131: return new CityInfo("Ko Yao", "61", 8.11013, 98.59231);
case 132: return new CityInfo("Kong Ra", "66", 7.40272, 99.94972);
case 133: return new CityInfo("Kong Krailat", "09", 16.95197, 99.97769);
case 134: return new CityInfo("Ko Lanta", "63", 7.53362, 99.08647);
case 135: return new CityInfo("Ko Kha", "06", 18.19225, 99.39433);
case 136: return new CityInfo("Khura Buri", "61", 9.19397, 98.41514);
case 137: return new CityInfo("Khun Yuam", "01", 18.82958, 97.93347);
case 138: return new CityInfo("Khlong Thom", "63", 7.9375, 99.14457);
case 139: return new CityInfo("Khlong Lan", "11", 16.20331, 99.31997);
case 140: return new CityInfo("Khlong Khlung", "11", 16.21633, 99.71906);
case 141: return new CityInfo("Tha Khanon", "60", 9.0302, 98.95286);
case 142: return new CityInfo("Khiri Mat", "09", 16.83333, 99.8);
case 143: return new CityInfo("Khian Sa", "60", 8.84295, 99.19856);
case 144: return new CityInfo("Khao Yoi", "56", 13.24025, 99.82428);
case 145: return new CityInfo("Khao Phanom", "63", 8.26549, 99.05124);
case 146: return new CityInfo("Khanu Woralaksaburi", "11", 16.0617, 99.86058);
case 147: return new CityInfo("Kathu", "62", 7.91779, 98.33322);
case 148: return new CityInfo("Kapong", "61", 8.69697, 98.40914);
case 149: return new CityInfo("Kapoe", "59", 9.58522, 98.59611);
case 150: return new CityInfo("Kantang", "65", 7.40542, 99.51561);
case 151: return new CityInfo("Kanchanadit", "60", 9.16611, 99.47014);
case 152: return new CityInfo("Kanchanaburi", "50", 14.00412, 99.54832);
case 153: return new CityInfo("Kamphaeng Phet", "11", 16.48344, 99.52153);
case 154: return new CityInfo("Huai Yot", "65", 7.78937, 99.63469);
case 155: return new CityInfo("Huai Khot", "15", 15.29095, 99.61661);
case 156: return new CityInfo("Hua Hin", "57", 12.57065, 99.95876);
case 157: return new CityInfo("Hot", "02", 18.19317, 98.61039);
case 158: return new CityInfo("Hang Dong", "02", 18.68703, 98.91939);
case 159: return new CityInfo("Hang Chat", "06", 18.32883, 99.34621);
case 160: return new CityInfo("Fang", "02", 19.91689, 99.2145);
case 161: return new CityInfo("Dok Kham Tai", "41", 19.16242, 99.99342);
case 162: return new CityInfo("Doi Tao", "02", 17.95286, 98.68458);
case 163: return new CityInfo("Dan Chang", "51", 14.84183, 99.69756);
case 164: return new CityInfo("Damnoen Saduak", "52", 13.51825, 99.95469);
case 165: return new CityInfo("Chumphon", "58", 10.4957, 99.17971);
case 166: return new CityInfo("Chom Thong", "02", 18.41742, 98.67428);
case 167: return new CityInfo("Chom Bueng", "52", 13.62, 99.59169);
case 168: return new CityInfo("Chiang Rai", "03", 19.90858, 99.8325);
case 169: return new CityInfo("Chiang Mai", "02", 18.79038, 98.98468);
case 170: return new CityInfo("Chiang Dao", "02", 19.36542, 98.96453);
case 171: return new CityInfo("Chawang", "64", 8.42614, 99.50472);
case 172: return new CityInfo("Chaiya", "60", 9.38625, 99.19861);
case 173: return new CityInfo("Chai Buri", "60", 8.46222, 99.07631);
case 174: return new CityInfo("Chae Hom", "06", 18.71267, 99.55758);
case 175: return new CityInfo("Cha-am", "56", 12.8, 99.96667);
case 176: return new CityInfo("Bo Phloi", "50", 14.32517, 99.51467);
case 177: return new CityInfo("Wiang Nuea", "01", 19.37972, 98.44644);
case 178: return new CityInfo("Wang Chin", "07", 17.8802, 99.6105);
case 179: return new CityInfo("Wang Chao", "08", 16.67441, 99.26903);
case 180: return new CityInfo("Thung Wa", "67", 7.10957, 99.75586);
case 181: return new CityInfo("Thung Hua Chang", "05", 18.00301, 99.0278);
case 182: return new CityInfo("Tha Maka", "50", 13.92081, 99.76553);
case 183: return new CityInfo("Ban Tak", "08", 17.04325, 99.08128);
case 184: return new CityInfo("Ko Samui", "60", 9.53567, 99.93567);
case 185: return new CityInfo("Rawai", "62", 7.77965, 98.32532);
case 186: return new CityInfo("Ban Rai", "15", 15.08417, 99.52108);
case 187: return new CityInfo("Ban Pong", "52", 13.81629, 99.87739);
case 188: return new CityInfo("Banphot Phisai", "16", 15.93558, 99.98129);
case 189: return new CityInfo("Ban Phru Nai", "61", 7.95458, 98.58989);
case 190: return new CityInfo("Nuea Khlong", "63", 8.07143, 98.99933);
case 191: return new CityInfo("Nong Prue", "50", 14.60784, 99.45783);
case 192: return new CityInfo("Nong Mamong", "32", 15.27613, 99.8664);
case 193: return new CityInfo("Noen Kham", "32", 14.9501, 99.93899);
case 194: return new CityInfo("Ban Na San", "60", 8.80036, 99.36372);
case 195: return new CityInfo("Ban Na Doem", "60", 8.88361, 99.31014);
case 196: return new CityInfo("Ban Na", "09", 17.01717, 99.73283);
case 197: return new CityInfo("Ban Mai Khao", "62", 8.12713, 98.30738);
case 198: return new CityInfo("Ban Lat", "56", 13.0515, 99.91701);
case 199: return new CityInfo("Ban Laem", "56", 13.20468, 99.97959);
case 200: return new CityInfo("Ban Ko Kaeo", "62", 7.93599, 98.39664);
case 201: return new CityInfo("Ban Khao Lak", "61", 8.61501, 98.23994);
case 202: return new CityInfo("Ban Kha", "52", 13.43047, 99.40967);
case 203: return new CityInfo("Ban Kata", "62", 7.82125, 98.30703);
case 204: return new CityInfo("Ban Karon", "62", 7.84769, 98.2985);
case 205: return new CityInfo("Kaeng Krachan", "56", 12.90742, 99.64795);
case 206: return new CityInfo("Huai Krachao", "50", 14.3275, 99.66767);
case 207: return new CityInfo("Ban Hong", "05", 18.33086, 98.81925);
case 208: return new CityInfo("Ban Ho Mae Salong", "03", 20.16667, 99.63333);
case 209: return new CityInfo("Bang Saphan Noi", "57", 11.07535, 99.44152);
case 210: return new CityInfo("Bang Saphan", "57", 11.21259, 99.51167);
case 211: return new CityInfo("Bang Phae", "52", 13.69157, 99.92982);
case 212: return new CityInfo("Bang Khon Thi", "54", 13.46906, 99.94021);
case 213: return new CityInfo("Bang Khan", "64", 8.02689, 99.47372);
case 214: return new CityInfo("Don Tum", "53", 13.9609, 100.07888);
case 215: return new CityInfo("Doi Lo", "02", 18.46098, 98.77767);
case 216: return new CityInfo("Dan Makham Tia", "50", 13.85339, 99.41042);
case 217: return new CityInfo("Ban Dan Lan Hoi", "09", 17.00683, 99.57497);
case 218: return new CityInfo("Ban Ao Nang", "61", 8.0458, 98.81035);
case 219: return new CityInfo("Ao Luek", "63", 8.37803, 98.72117);
case 220: return new CityInfo("Amphawa", "54", 13.42436, 99.95688);
case 221: return new CityInfo("Ban Ao Makham", "67", 6.56778, 99.62528);
case 222: return new CityInfo("Sa Bot", "34", 15.21006, 100.83076);
case 223: return new CityInfo("Phatthana Nikhom", "34", 14.85647, 100.98459);
case 224: return new CityInfo("Nong Kung Si", "23", 16.65, 103.3);
case 225: return new CityInfo("Na Dun", "24", 15.71668, 103.22781);
case 226: return new CityInfo("Ko Pha Ngan", "60", 9.71945, 99.99511);
case 227: return new CityInfo("Yang Si Surat", "24", 15.68361, 103.10311);
case 228: return new CityInfo("Mueang Yang", "27", 15.4206, 102.89282);
case 229: return new CityInfo("Siao", "30", 14.79583, 104.67017);
case 230: return new CityInfo("Samran", "23", 16.86322, 103.54106);
case 231: return new CityInfo("Thepharak", "27", 15.30868, 101.55045);
case 232: return new CityInfo("Sak Lek", "13", 16.50528, 100.47103);
case 233: return new CityInfo("Phayu", "30", 14.90851, 104.39101);
case 234: return new CityInfo("Pha Khao", "18", 17.06507, 102.02965);
case 235: return new CityInfo("Non Suwan", "28", 14.58044, 102.59689);
case 236: return new CityInfo("Ban Nong Wua So", "76", 17.2675, 103.22472);
case 237: return new CityInfo("Nong Wua So", "76", 17.16261, 102.57272);
case 238: return new CityInfo("Nong Na Kham", "22", 16.8043, 102.33647);
case 239: return new CityInfo("Nong Muang", "34", 15.24592, 100.65556);
case 240: return new CityInfo("Nong Hin", "18", 17.12356, 101.85789);
case 241: return new CityInfo("Nong Hi", "25", 15.61117, 103.99484);
case 242: return new CityInfo("Na Yung", "76", 17.89747, 102.14981);
case 243: return new CityInfo("Na Tan", "75", 15.89749, 105.29318);
case 244: return new CityInfo("Ban Nam Yuen", "58", 9.87686, 98.86592);
case 245: return new CityInfo("Na Mom", "68", 6.95856, 100.55683);
case 246: return new CityInfo("Mueang Chan", "30", 15.15951, 104.03615);
case 247: return new CityInfo("Ban Mai", "68", 7.20411, 100.54508);
case 248: return new CityInfo("Lam Sonthi", "34", 15.30154, 101.36365);
case 249: return new CityInfo("Ban Huai Thalaeng", "27", 14.98333, 102.65);
case 250: return new CityInfo("Huai Rat", "28", 14.96039, 103.18911);
case 251: return new CityInfo("Ban Haet", "22", 16.19648, 102.75959);
case 252: return new CityInfo("Fao Rai", "17", 18.01791, 103.30388);
case 253: return new CityInfo("Ban Dan", "28", 15.10839, 103.17551);
case 254: return new CityInfo("Charoen Sin", "20", 17.57925, 103.54033);
case 255: return new CityInfo("Ban Khlong Bang Sao Thong", "42", 13.64172, 100.83272);
case 256: return new CityInfo("Waeng", "31", 5.928, 101.88382);
case 257: return new CityInfo("Thepha", "68", 6.82936, 100.96431);
case 258: return new CityInfo("Tak Fa", "16", 15.34917, 100.49522);
case 259: return new CityInfo("Prakhon Chai", "28", 14.61073, 103.07923);
case 260: return new CityInfo("Na Klang", "79", 17.3072, 102.18886);
case 261: return new CityInfo("Bacho", "31", 6.51678, 101.651);
case 262: return new CityInfo("Yi-ngo", "31", 6.40297, 101.70625);
case 263: return new CityInfo("Yasothon", "72", 15.79408, 104.1451);
case 264: return new CityInfo("Yaring", "69", 6.86617, 101.36894);
case 265: return new CityInfo("Yan Nawa", "40", 13.69634, 100.54212);
case 266: return new CityInfo("Yang Talat", "23", 16.39982, 103.36785);
case 267: return new CityInfo("Yang Chum Noi", "30", 15.26453, 104.39769);
case 268: return new CityInfo("Yarang", "69", 6.75986, 101.29339);
case 269: return new CityInfo("Yala", "70", 6.53995, 101.28128);
case 270: return new CityInfo("Yaha", "70", 6.4797, 101.132);
case 271: return new CityInfo("Wiset Chaichan", "35", 14.5945, 100.33825);
case 272: return new CityInfo("Wihan Daeng", "37", 14.34586, 100.98942);
case 273: return new CityInfo("Wichian Buri", "14", 15.65778, 101.10603);
case 274: return new CityInfo("Wiang Sa", "04", 18.59856, 100.74103);
case 275: return new CityInfo("Watthana Nakhon", "80", 13.74462, 102.31863);
case 276: return new CityInfo("Wat Sing", "32", 15.25987, 100.0404);
case 277: return new CityInfo("Wat Bot", "12", 16.98114, 100.33195);
case 278: return new CityInfo("Warin Chamrap", "75", 15.19319, 104.8628);
case 279: return new CityInfo("Warichaphum", "20", 17.29409, 103.63816);
case 280: return new CityInfo("Wapi Pathum", "24", 15.84523, 103.37678);
case 281: return new CityInfo("Wan Yai", "78", 16.72229, 104.74135);
case 282: return new CityInfo("Wanon Niwat", "20", 17.63391, 103.75241);
case 283: return new CityInfo("Wang Thong", "12", 16.82458, 100.42936);
case 284: return new CityInfo("Wang Saphung", "18", 17.30097, 101.7685);
case 285: return new CityInfo("Wang Sam Mo", "76", 16.95294, 103.4365);
case 286: return new CityInfo("Wang Noi", "36", 14.22689, 100.7155);
case 287: return new CityInfo("Wang Nam Yen", "80", 13.50325, 102.18115);
case 288: return new CityInfo("Wang Hin", "30", 14.94783, 104.23097);
case 289: return new CityInfo("Wang Chan", "47", 12.93646, 101.52303);
case 290: return new CityInfo("Wang Sai Phun", "13", 16.3885, 100.53801);
case 291: return new CityInfo("Waeng Yai", "22", 15.95547, 102.5469);
case 292: return new CityInfo("Waeng Noi", "22", 15.8035, 102.41614);
case 293: return new CityInfo("Uttaradit", "10", 17.62557, 100.09421);
case 294: return new CityInfo("Uthumphon Phisai", "30", 15.11161, 104.14011);
case 295: return new CityInfo("Uthai Thani", "15", 15.37939, 100.0245);
case 296: return new CityInfo("Uthai", "36", 14.36278, 100.67203);
case 297: return new CityInfo("Udon Thani", "76", 17.41567, 102.78589);
case 298: return new CityInfo("Ubon Ratchathani", "75", 15.23844, 104.84866);
case 299: return new CityInfo("Khuean Ubonrat", "22", 16.75269, 102.63245);
case 300: return new CityInfo("Tron", "10", 17.48181, 100.11281);
case 301: return new CityInfo("Trat", "49", 12.24364, 102.51514);
case 302: return new CityInfo("Trakan Phut Phon", "75", 15.61183, 105.02147);
case 303: return new CityInfo("Thung Fon", "76", 17.47167, 103.26033);
case 304: return new CityInfo("Thon Buri", "40", 13.725, 100.48511);
case 305: return new CityInfo("Thoeng", "03", 19.68508, 100.19456);
case 306: return new CityInfo("Thep Sathit", "26", 15.39247, 101.45061);
case 307: return new CityInfo("Tha Yang", "56", 12.95772, 99.90555);
case 308: return new CityInfo("Tha Wung", "34", 14.811, 100.50333);
case 309: return new CityInfo("Thawat Buri", "25", 16.0385, 103.74647);
case 310: return new CityInfo("Tha Wang Pha", "04", 19.12189, 100.81106);
case 311: return new CityInfo("Tha Uthen", "73", 17.57605, 104.59906);
case 312: return new CityInfo("Tha Tum", "29", 15.3195, 103.67542);
case 313: return new CityInfo("That Phanom", "73", 16.93636, 104.71039);
case 314: return new CityInfo("Tha Tako", "16", 15.64218, 100.47839);
case 315: return new CityInfo("Tha Ruea", "36", 14.56739, 100.72598);
case 316: return new CityInfo("Tha Pla", "10", 17.79112, 100.37611);
case 317: return new CityInfo("Thap Khlo", "13", 16.16003, 100.59656);
case 318: return new CityInfo("Thanyaburi", "39", 14.02114, 100.73433);
case 319: return new CityInfo("Than To", "70", 6.16739, 101.18008);
case 320: return new CityInfo("Tha Mai", "48", 12.62137, 102.00481);
case 321: return new CityInfo("Tha Luang", "34", 15.07124, 101.09801);
case 322: return new CityInfo("Tha Li", "18", 17.62355, 101.42099);
case 323: return new CityInfo("Tha Khantho", "23", 16.93953, 103.24586);
case 324: return new CityInfo("Tha Chang", "33", 14.76142, 100.38989);
case 325: return new CityInfo("Tha Bo", "17", 17.85003, 102.58139);
case 326: return new CityInfo("Ta Phraya", "80", 14.00308, 102.80541);
case 327: return new CityInfo("Taphan Hin", "13", 16.22095, 100.41978);
case 328: return new CityInfo("Tao Ngoi", "20", 16.99689, 104.16672);
case 329: return new CityInfo("Tan Sum", "75", 15.31569, 105.15464);
case 330: return new CityInfo("Tamot", "66", 7.33922, 100.11167);
case 331: return new CityInfo("Taling Chan", "40", 13.77698, 100.4567);
case 332: return new CityInfo("Takhli", "16", 15.26336, 100.34378);
case 333: return new CityInfo("Tak Bai", "31", 6.25947, 102.05461);
case 334: return new CityInfo("Suwannaphum", "25", 15.60348, 103.80207);
case 335: return new CityInfo("Suwannakhuha", "79", 17.56292, 102.27989);
case 336: return new CityInfo("Surin", "29", 14.88181, 103.49364);
case 337: return new CityInfo("Suphan Buri", "51", 14.47418, 100.12218);
case 338: return new CityInfo("Sung Noen", "27", 14.8992, 101.82075);
case 339: return new CityInfo("Sung Men", "07", 18.0494, 100.11457);
case 340: return new CityInfo("Ban Su-ngai Pa Di", "31", 6.07239, 101.87172);
case 341: return new CityInfo("Su-ngai Kolok", "31", 6.02977, 101.96586);
case 342: return new CityInfo("Sukhirin", "31", 5.93889, 101.77077);
case 343: return new CityInfo("So Phisai", "81", 18.0772, 103.4432);
case 344: return new CityInfo("Song Phi Nong", "51", 14.22408, 100.02094);
case 345: return new CityInfo("Songkhla", "68", 7.19882, 100.5951);
case 346: return new CityInfo("Song", "07", 18.47204, 100.18346);
case 347: return new CityInfo("Somdet", "23", 16.70462, 103.74935);
case 348: return new CityInfo("Soeng Sang", "27", 14.42642, 102.46058);
case 349: return new CityInfo("Si Thep", "14", 15.45214, 101.06667);
case 350: return new CityInfo("Si That", "76", 16.97361, 103.21644);
case 351: return new CityInfo("Si Songkhram", "73", 17.62745, 104.25069);
case 352: return new CityInfo("Si Sakhon", "31", 6.23137, 101.50048);
case 353: return new CityInfo("Si Sa Ket", "30", 15.11481, 104.32938);
case 354: return new CityInfo("Si Rattana", "30", 14.79328, 104.46922);
case 355: return new CityInfo("Si Racha", "46", 13.17372, 100.93111);
case 356: return new CityInfo("Si Prachan", "51", 14.61992, 100.14483);
case 357: return new CityInfo("Sing Buri", "33", 14.88786, 100.40464);
case 358: return new CityInfo("Si Mueang Mai", "75", 15.49315, 105.27624);
case 359: return new CityInfo("Si Maha Phot", "74", 13.96597, 101.51303);
case 360: return new CityInfo("Si Khoraphum", "29", 14.94418, 103.79704);
case 361: return new CityInfo("Sikhio", "27", 14.89225, 101.72314);
case 362: return new CityInfo("Si Chomphu", "22", 16.79878, 102.18466);
case 363: return new CityInfo("Si Chiang Mai", "17", 17.95639, 102.58667);
case 364: return new CityInfo("Si Bun Rueang", "79", 16.96705, 102.27607);
case 365: return new CityInfo("Senangkhanikhom", "77", 16.03972, 104.66939);
case 366: return new CityInfo("Sena", "36", 14.327, 100.40433);
case 367: return new CityInfo("Selaphum", "25", 16.02992, 103.93826);
case 368: return new CityInfo("Seka", "81", 17.92851, 103.95519);
case 369: return new CityInfo("Sawang Daen Din", "20", 17.47531, 103.45753);
case 370: return new CityInfo("Sawaeng Ha", "35", 14.74642, 100.32942);
case 371: return new CityInfo("Satun", "67", 6.62314, 100.06676);
case 372: return new CityInfo("Satuek", "28", 15.29703, 103.29192);
case 373: return new CityInfo("Sattahip", "46", 12.66644, 100.90073);
case 374: return new CityInfo("Sathing Phra", "68", 7.47303, 100.43908);
case 375: return new CityInfo("Saraburi", "37", 14.53333, 100.91667);
case 376: return new CityInfo("Sao Hai", "37", 14.55083, 100.84436);
case 377: return new CityInfo("Sapphaya", "32", 15.14616, 100.24215);
case 378: return new CityInfo("Sanom", "29", 15.2036, 103.76054);
case 379: return new CityInfo("Sankhaburi", "32", 15.04733, 100.16178);
case 380: return new CityInfo("Sangkhom", "17", 18.06389, 102.27364);
case 381: return new CityInfo("Sang Khom", "76", 17.82649, 103.09262);
case 382: return new CityInfo("Sangkha", "29", 14.6362, 103.85278);
case 383: return new CityInfo("Sanam Chai Khet", "44", 13.65864, 101.43906);
case 384: return new CityInfo("Samut Songkhram", "54", 13.41456, 100.00264);
case 385: return new CityInfo("Samut Sakhon", "55", 13.54753, 100.27362);
case 386: return new CityInfo("Samut Prakan", "42", 13.59934, 100.59675);
case 387: return new CityInfo("Samrong Thap", "29", 15.02258, 103.93631);
case 388: return new CityInfo("Sam Phran", "53", 13.72698, 100.21526);
case 389: return new CityInfo("Samphanthawong", "40", 13.73147, 100.51414);
case 390: return new CityInfo("Sam Ngam", "13", 16.50653, 100.20497);
case 391: return new CityInfo("Sam Ko", "35", 14.60735, 100.2186);
case 392: return new CityInfo("Sam Khok", "39", 14.0655, 100.52264);
case 393: return new CityInfo("Sam Chuk", "51", 14.75763, 100.08992);
case 394: return new CityInfo("Sakon Nakhon", "20", 17.16116, 104.14725);
case 395: return new CityInfo("Sa Kaeo", "80", 13.81411, 102.07222);
case 396: return new CityInfo("Sai Noi", "38", 13.97915, 100.31209);
case 397: return new CityInfo("Sai Mun", "72", 15.94495, 104.20812);
case 398: return new CityInfo("Sai Buri", "69", 6.70131, 101.61675);
case 399: return new CityInfo("Sahatsakhan", "23", 16.71236, 103.5202);
case 400: return new CityInfo("Sadao", "68", 6.63883, 100.42342);
case 401: return new CityInfo("Saba Yoi", "68", 6.6175, 100.95189);
case 402: return new CityInfo("Rueso", "31", 6.39364, 101.51847);
case 403: return new CityInfo("Rong Kwang", "07", 18.33903, 100.31736);
case 404: return new CityInfo("Rong Kham", "23", 16.26943, 103.74689);
case 405: return new CityInfo("Roi Et", "25", 16.0567, 103.65309);
case 406: return new CityInfo("Renu Nakhon", "73", 17.05157, 104.67709);
case 407: return new CityInfo("Rayong", "47", 12.68095, 101.25798);
case 408: return new CityInfo("Rattaphum", "68", 7.13478, 100.25647);
case 409: return new CityInfo("Rattanaburi", "29", 15.31788, 103.84859);
case 410: return new CityInfo("Rat Burana", "40", 13.68219, 100.50603);
case 411: return new CityInfo("Rasi Salai", "30", 15.34466, 104.15476);
case 412: return new CityInfo("Ranot", "68", 7.77768, 100.32134);
case 413: return new CityInfo("Ra-ngae", "31", 6.29678, 101.72844);
case 414: return new CityInfo("Raman", "70", 6.47862, 101.42414);
case 415: return new CityInfo("Pueai Noi", "22", 15.86978, 102.90767);
case 416: return new CityInfo("Pua", "04", 19.17503, 100.91622);
case 417: return new CityInfo("Prathai", "27", 15.53319, 102.72283);
case 418: return new CityInfo("Prasat", "29", 14.64039, 103.40447);
case 419: return new CityInfo("Prang Ku", "30", 14.85672, 104.03981);
case 420: return new CityInfo("Prakhon Chai", "28", 14.60592, 103.12081);
case 421: return new CityInfo("Pakham", "28", 14.43817, 102.72558);
case 422: return new CityInfo("Prachin Buri", "74", 14.04992, 101.36864);
case 423: return new CityInfo("Prachantakham", "74", 14.06442, 101.51503);
case 424: return new CityInfo("Pong Nam Ron", "48", 12.90575, 102.26225);
case 425: return new CityInfo("Pong", "41", 19.14931, 100.27522);
case 426: return new CityInfo("Pom Prap Sattru Phai", "40", 13.75822, 100.51325);
case 427: return new CityInfo("Pluak Daeng", "47", 12.97122, 101.21463);
case 428: return new CityInfo("Pla Pak", "73", 17.18064, 104.52606);
case 429: return new CityInfo("Plaeng Yao", "44", 13.58467, 101.28403);
case 430: return new CityInfo("Phu Wiang", "22", 16.65259, 102.37555);
case 431: return new CityInfo("Phutthaisong", "28", 15.54783, 103.02467);
case 432: return new CityInfo("Phu Ruea", "18", 17.4538, 101.36231);
case 433: return new CityInfo("Phu Pha Man", "22", 16.64888, 101.90097);
case 434: return new CityInfo("Phu Luang", "18", 17.1392, 101.66392);
case 435: return new CityInfo("Phu Kradueng", "18", 16.88425, 101.88467);
case 436: return new CityInfo("Phu Khiao", "26", 16.3765, 102.12853);
case 437: return new CityInfo("Phrom Phiram", "12", 17.03352, 100.2019);
case 438: return new CityInfo("Phrom Buri", "33", 14.79086, 100.45325);
case 439: return new CityInfo("Phra Yuen", "22", 16.3293, 102.65182);
case 440: return new CityInfo("Phra Pradaeng", "42", 13.65855, 100.53362);
case 441: return new CityInfo("Phra Phutthabat", "37", 14.72526, 100.79536);
case 442: return new CityInfo("Phra Nakhon Si Ayutthaya", "36", 14.35167, 100.57739);
case 443: return new CityInfo("Phra Khanong", "40", 13.70185, 100.60157);
case 444: return new CityInfo("Phrai Bueng", "30", 14.74833, 104.36261);
case 445: return new CityInfo("Phrae", "07", 18.14589, 100.14103);
case 446: return new CityInfo("Pho Thong", "35", 14.66731, 100.40878);
case 447: return new CityInfo("Pho Thale", "13", 16.09269, 100.26089);
case 448: return new CityInfo("Pho Sai", "75", 15.82586, 105.26064);
case 449: return new CityInfo("Waeng", "25", 16.30006, 103.97786);
case 450: return new CityInfo("Phon Sai", "25", 15.48797, 103.99642);
case 451: return new CityInfo("Phon Phisai", "17", 18.02106, 103.07664);
case 452: return new CityInfo("Phon Charoen", "17", 18.03333, 103.16667);
case 453: return new CityInfo("Phon", "22", 15.816, 102.59981);
case 454: return new CityInfo("Pho Chai", "25", 16.32827, 103.77033);
case 455: return new CityInfo("Phitsanulok", "12", 16.82481, 100.25858);
case 456: return new CityInfo("Phimai", "27", 15.22324, 102.49473);
case 457: return new CityInfo("Phichit", "13", 16.44184, 100.34879);
case 458: return new CityInfo("Phichai", "10", 17.28764, 100.0867);
case 459: return new CityInfo("Phibun Mangsahan", "75", 15.24467, 105.22908);
case 460: return new CityInfo("Phetchabun", "14", 16.41904, 101.16056);
case 461: return new CityInfo("Phen", "76", 17.69614, 102.90689);
case 462: return new CityInfo("Phayuha Khiri", "16", 15.45525, 100.13533);
case 463: return new CityInfo("Phayakkhaphum Phisai", "24", 15.51631, 103.19367);
case 464: return new CityInfo("Phatthalung", "66", 7.61786, 100.07792);
case 465: return new CityInfo("Phasi Charoen", "40", 13.71466, 100.43691);
case 466: return new CityInfo("Phan Thong", "46", 13.46804, 101.09532);
case 467: return new CityInfo("Phanom Sarakham", "44", 13.74872, 101.34888);
case 468: return new CityInfo("Phanom Phrai", "25", 15.67783, 104.11025);
case 469: return new CityInfo("Phanna Nikhom", "20", 17.35245, 103.85032);
case 470: return new CityInfo("Phang Khon", "20", 17.39051, 103.71692);
case 471: return new CityInfo("Phanat Nikhom", "46", 13.44581, 101.18445);
case 472: return new CityInfo("Phana", "77", 15.68231, 104.84603);
case 473: return new CityInfo("Phak Hai", "36", 14.45736, 100.36989);
case 474: return new CityInfo("Phai Sali", "16", 15.60003, 100.64937);
case 475: return new CityInfo("Phachi", "36", 14.44914, 100.72833);
case 476: return new CityInfo("Pa Bon", "66", 7.26942, 100.17036);
case 477: return new CityInfo("Phaya Mengrai", "03", 19.84922, 100.15358);
case 478: return new CityInfo("Pattani", "69", 6.86814, 101.25009);
case 479: return new CityInfo("Pa Tio", "72", 15.83281, 104.38673);
case 480: return new CityInfo("Pathum Thani", "39", 14.01346, 100.53049);
case 481: return new CityInfo("Pathum Rat", "25", 15.6345, 103.34325);
case 482: return new CityInfo("Panare", "69", 6.86192, 101.49103);
case 483: return new CityInfo("Pa Mok", "35", 14.48989, 100.44847);
case 484: return new CityInfo("Pak Thong Chai", "27", 14.7226, 102.02512);
case 485: return new CityInfo("Pak Phli", "43", 14.16308, 101.26886);
case 486: return new CityInfo("Pak Phayun", "66", 7.34219, 100.31747);
case 487: return new CityInfo("Pak Phanang", "64", 8.35109, 100.20195);
case 488: return new CityInfo("Pak Kret", "38", 13.91301, 100.49883);
case 489: return new CityInfo("Pak Khat", "81", 18.30556, 103.30441);
case 490: return new CityInfo("Pak Chong", "27", 14.70802, 101.41614);
case 491: return new CityInfo("Pa Daet", "03", 19.50489, 99.99241);
case 492: return new CityInfo("Ongkharak", "43", 14.12117, 101.00364);
case 493: return new CityInfo("Non Thai", "27", 15.1958, 102.07145);
case 494: return new CityInfo("Mueang Nonthaburi", "38", 13.86075, 100.51477);
case 495: return new CityInfo("Non Sung", "27", 15.18014, 102.25695);
case 496: return new CityInfo("Non Sang", "79", 16.8687, 102.56642);
case 497: return new CityInfo("Non Sa-at", "76", 16.97914, 102.89369);
case 498: return new CityInfo("Non Kho", "30", 14.91666, 104.72522);
case 499: return new CityInfo("Nong Yai", "46", 13.15515, 101.37226);
case 500: return new CityInfo("Nong Sung", "78", 16.48299, 104.34712);
case 501: return new CityInfo("Nong Suea", "39", 14.13478, 100.82503);
case 502: return new CityInfo("Nong Saeng", "76", 17.16739, 102.78081);
case 503: return new CityInfo("Nong Saeng", "37", 14.49208, 100.78431);
case 504: return new CityInfo("Nong Ruea", "22", 16.49333, 102.43339);
case 505: return new CityInfo("Nong Phok", "25", 16.31006, 104.20247);
case 506: return new CityInfo("Nong Phai", "14", 15.99025, 101.06183);
case 507: return new CityInfo("Nong Ki", "28", 14.68679, 102.538);
case 508: return new CityInfo("Nong Khai", "17", 17.87847, 102.742);
case 509: return new CityInfo("Nong Khaem", "40", 13.70528, 100.34923);
case 510: return new CityInfo("Nong Khae", "37", 14.34062, 100.86733);
case 511: return new CityInfo("Nong Hong", "28", 14.84782, 102.68401);
case 512: return new CityInfo("Nong Han", "76", 17.36083, 103.10533);
case 513: return new CityInfo("Nong Chok", "40", 13.85585, 100.86216);
case 514: return new CityInfo("Nong Chik", "69", 6.84356, 101.17803);
case 515: return new CityInfo("Nong Bun Nak", "27", 14.73947, 102.36564);
case 516: return new CityInfo("Nong Bua Rawe", "26", 15.75314, 101.76396);
case 517: return new CityInfo("Nong Bua Lamphu", "79", 17.20406, 102.44068);
case 518: return new CityInfo("Nong Bua Daeng", "26", 16.07978, 101.80225);
case 519: return new CityInfo("Nong Bua", "16", 15.86458, 100.58581);
case 520: return new CityInfo("Noen Maprang", "12", 16.56667, 100.63333);
case 521: return new CityInfo("Nikhom Nam Un", "20", 17.18314, 103.71842);
case 522: return new CityInfo("Nikhom Kham Soi", "78", 16.37167, 104.55147);
case 523: return new CityInfo("Na Wa", "73", 17.4897, 104.10056);
case 524: return new CityInfo("Na Thawi", "68", 6.74192, 100.69139);
case 525: return new CityInfo("Narathiwat", "31", 6.42639, 101.82308);
case 526: return new CityInfo("Na Pho", "28", 15.64113, 102.95462);
case 527: return new CityInfo("Na Noi", "04", 18.32639, 100.71417);
case 528: return new CityInfo("Nang Rong", "28", 14.6377, 102.79138);
case 529: return new CityInfo("Nan", "04", 18.78378, 100.77899);
case 530: return new CityInfo("Na Muen", "04", 18.18931, 100.66047);
case 531: return new CityInfo("Nam Som", "76", 17.77036, 102.18947);
case 532: return new CityInfo("Nam Phong", "22", 16.70228, 102.85569);
case 533: return new CityInfo("Nam Pat", "10", 17.72806, 100.68433);
case 534: return new CityInfo("Na Mon", "23", 16.57653, 103.78711);
case 535: return new CityInfo("Nam Nao", "14", 16.76753, 101.66917);
case 536: return new CityInfo("Nam Kliang", "30", 14.92731, 104.51303);
case 537: return new CityInfo("Nakhon Thai", "12", 17.10056, 100.83739);
case 538: return new CityInfo("Nakhon Sawan", "16", 15.70472, 100.13717);
case 539: return new CityInfo("Nakhon Ratchasima", "27", 14.97066, 102.10196);
case 540: return new CityInfo("Nakhon Phanom", "73", 17.41081, 104.77856);
case 541: return new CityInfo("Nakhon Pathom", "53", 13.8196, 100.04427);
case 542: return new CityInfo("Nakhon Nayok", "43", 14.20463, 101.21295);
case 543: return new CityInfo("Nakhon Luang", "36", 14.46281, 100.60832);
case 544: return new CityInfo("Nakhon Chai Si", "53", 13.80126, 100.18451);
case 545: return new CityInfo("Na Kae", "73", 16.94645, 104.50081);
case 546: return new CityInfo("Na Chueak", "24", 15.79339, 103.03184);
case 547: return new CityInfo("Na Chaluai", "75", 14.52046, 105.24478);
case 548: return new CityInfo("Mukdahan", "78", 16.54531, 104.72351);
case 549: return new CityInfo("Mueang Suang", "25", 15.82192, 103.72884);
case 550: return new CityInfo("Muang Sam Sip", "75", 15.51307, 104.72565);
case 551: return new CityInfo("Min Buri", "40", 13.81407, 100.73135);
case 552: return new CityInfo("Moeiwadi", "25", 16.38944, 104.1572);
case 553: return new CityInfo("Mayo", "69", 6.71864, 101.40983);
case 554: return new CityInfo("Manorom", "32", 15.30997, 100.08283);
case 555: return new CityInfo("Mancha Khiri", "22", 16.13048, 102.53712);
case 556: return new CityInfo("Makham", "48", 12.67292, 102.19575);
case 557: return new CityInfo("Mai Kaen", "69", 6.60975, 101.66686);
case 558: return new CityInfo("Maha Sarakham", "24", 16.18483, 103.30067);
case 559: return new CityInfo("Maha Rat", "36", 14.53367, 100.52672);
case 560: return new CityInfo("Maha Chana Chai", "72", 15.52935, 104.23847);
case 561: return new CityInfo("Mae Charim", "04", 18.70614, 101.0057);
case 562: return new CityInfo("Lop Buri", "34", 14.79808, 100.65397);
case 563: return new CityInfo("Lom Sak", "14", 16.77983, 101.24225);
case 564: return new CityInfo("Lom Kao", "14", 16.88614, 101.22894);
case 565: return new CityInfo("Loeng Nok Tha", "72", 16.2075, 104.55528);
case 566: return new CityInfo("Loei", "18", 17.49052, 101.72749);
case 567: return new CityInfo("Lat Lum Kaeo", "39", 14.03728, 100.40486);
case 568: return new CityInfo("Lat Bua Luang", "36", 14.16572, 100.30789);
case 569: return new CityInfo("Lap Lae", "10", 17.65211, 100.03892);
case 570: return new CityInfo("Lam Plai Mat", "28", 15.0252, 102.83894);
case 571: return new CityInfo("Lam Luk Ka", "39", 13.93226, 100.74937);
case 572: return new CityInfo("Lamduan", "29", 14.72205, 103.66934);
case 573: return new CityInfo("Lahan Sai", "28", 14.41142, 102.85936);
case 574: return new CityInfo("Laem Sing", "48", 12.48164, 102.07375);
case 575: return new CityInfo("Laem Ngop", "49", 12.17169, 102.39489);
case 576: return new CityInfo("Kut Khaopun", "75", 15.79267, 104.99814);
case 577: return new CityInfo("Kut Chum", "72", 16.03289, 104.33936);
case 578: return new CityInfo("Kut Chap", "76", 17.4257, 102.56692);
case 579: return new CityInfo("Kut Bak", "20", 17.08882, 103.81875);
case 580: return new CityInfo("Kusuman", "20", 17.33259, 104.33147);
case 581: return new CityInfo("Kumphawapi", "76", 17.10875, 103.01487);
case 582: return new CityInfo("Kuchinarai", "23", 16.541, 104.05004);
case 583: return new CityInfo("Bangkok", "40", 13.75398, 100.50144);
case 584: return new CityInfo("Krok Phra", "16", 15.55589, 100.07153);
case 585: return new CityInfo("Krathum Baen", "55", 13.6533, 100.25972);
case 586: return new CityInfo("Krasang", "28", 14.92375, 103.30369);
case 587: return new CityInfo("Krasae Sin", "68", 7.61548, 100.32842);
case 588: return new CityInfo("Kranuan", "22", 16.70672, 103.07878);
case 589: return new CityInfo("Kosum Phisai", "24", 16.24858, 103.06739);
case 590: return new CityInfo("Ko Si Chang", "46", 13.16389, 100.80547);
case 591: return new CityInfo("Klaeng", "47", 12.77972, 101.64831);
case 592: return new CityInfo("Khun Han", "30", 14.61739, 104.42506);
case 593: return new CityInfo("Khu Mueang", "28", 15.2716, 103.00167);
case 594: return new CityInfo("Khu Khan", "30", 14.71358, 104.19836);
case 595: return new CityInfo("Khuan Niang", "68", 7.19138, 100.35355);
case 596: return new CityInfo("Khuan Khanun", "66", 7.7347, 100.00931);
case 597: return new CityInfo("Khuan Kalong", "67", 6.84538, 100.07148);
case 598: return new CityInfo("Khueang Nai", "75", 15.38989, 104.55083);
case 599: return new CityInfo("Khuan Don", "67", 6.78758, 100.07778);
case 600: return new CityInfo("Kho Wang", "72", 15.36998, 104.35231);
case 601: return new CityInfo("Khon Sawan", "26", 15.93192, 102.28103);
case 602: return new CityInfo("Khon San", "26", 16.61286, 101.91944);
case 603: return new CityInfo("Khon Kaen", "22", 16.44671, 102.833);
case 604: return new CityInfo("Khong Chiam", "75", 15.31856, 105.49506);
case 605: return new CityInfo("Khong", "27", 15.44393, 102.32862);
case 606: return new CityInfo("Khon Buri", "27", 14.52541, 102.24591);
case 607: return new CityInfo("Khok Si Suphan", "20", 17.04507, 104.2756);
case 608: return new CityInfo("Khok Samrong", "34", 15.06649, 100.72233);
case 609: return new CityInfo("Khok Pho", "69", 6.73064, 101.09619);
case 610: return new CityInfo("Khok Charoen", "34", 15.37927, 100.8187);
case 611: return new CityInfo("Khlung", "48", 12.45467, 102.22142);
case 612: return new CityInfo("Khlong Yai", "49", 11.77645, 102.88567);
case 613: return new CityInfo("Khlong San", "40", 13.73086, 100.50903);
case 614: return new CityInfo("Khlong Luang", "39", 14.06467, 100.64578);
case 615: return new CityInfo("Khlong Hat", "80", 13.45177, 102.29823);
case 616: return new CityInfo("Khemarat", "75", 16.04252, 105.21836);
case 617: return new CityInfo("Khao Wong", "23", 16.70008, 104.09019);
case 618: return new CityInfo("Khao Saming", "49", 12.35353, 102.4355);
case 619: return new CityInfo("Khao Chaison", "66", 7.46125, 100.13372);
case 620: return new CityInfo("Kham Thale So", "27", 14.96083, 101.94789);
case 621: return new CityInfo("Kham Ta Kla", "20", 17.85231, 103.75657);
case 622: return new CityInfo("Kham Sakae Saeng", "27", 15.33221, 102.17278);
case 623: return new CityInfo("Kham Muang", "23", 16.92902, 103.63518);
case 624: return new CityInfo("Kham Khuean Kaeo", "72", 15.65233, 104.30861);
case 625: return new CityInfo("Khamcha-i", "78", 16.57764, 104.41956);
case 626: return new CityInfo("Kaset Wisai", "25", 15.65558, 103.58361);
case 627: return new CityInfo("Kaset Sombun", "26", 16.28053, 101.95422);
case 628: return new CityInfo("Kao Liao", "16", 15.85053, 100.07914);
case 629: return new CityInfo("Kantharawichai", "24", 16.32719, 103.29864);
case 630: return new CityInfo("Kanthararom", "30", 15.10323, 104.57343);
case 631: return new CityInfo("Kantharalak", "30", 14.64056, 104.64992);
case 632: return new CityInfo("Krong Pi Nang", "70", 6.4112, 101.27394);
case 633: return new CityInfo("Su-ngai Padi", "31", 6.0857, 101.87959);
case 634: return new CityInfo("Ka Bang", "70", 6.41536, 101.05456);
case 635: return new CityInfo("Cho-airong", "31", 6.22553, 101.81128);
case 636: return new CityInfo("Kamphaeng Saen", "53", 13.99966, 99.98981);
case 637: return new CityInfo("Kamalasai", "23", 16.33839, 103.57564);
case 638: return new CityInfo("Kalasin", "23", 16.43281, 103.50658);
case 639: return new CityInfo("Kaeng Khoi", "37", 14.58617, 100.99758);
case 640: return new CityInfo("Kaeng Khro", "26", 16.10864, 102.25808);
case 641: return new CityInfo("Kae Dam", "24", 16.02397, 103.38444);
case 642: return new CityInfo("Kabin Buri", "74", 13.95114, 101.71769);
case 643: return new CityInfo("In Buri", "33", 15.00787, 100.32691);
case 644: return new CityInfo("Hua Taphan", "77", 15.6971, 104.4916);
case 645: return new CityInfo("Hua Sai", "64", 8.04408, 100.30586);
case 646: return new CityInfo("Huai Thap Than", "30", 15.05333, 104.02754);
case 647: return new CityInfo("Huai Thalaeng", "27", 14.99701, 102.64746);
case 648: return new CityInfo("Huai Phueng", "23", 16.65038, 103.91005);
case 649: return new CityInfo("Huai Mek", "23", 16.58975, 103.23547);
case 650: return new CityInfo("Hat Yai", "68", 7.00836, 100.47668);
case 651: return new CityInfo("Hankha", "32", 14.98122, 100.0147);
case 652: return new CityInfo("Fak Tha", "10", 17.99948, 100.88014);
case 653: return new CityInfo("Dusit", "40", 13.7775, 100.51977);
case 654: return new CityInfo("Don Tan", "78", 16.31697, 104.92);
case 655: return new CityInfo("Dong Luang", "78", 16.81589, 104.538);
case 656: return new CityInfo("Don Chedi", "51", 14.63497, 100.02097);
case 657: return new CityInfo("Doembang Nangbuat", "51", 14.83333, 100.1);
case 658: return new CityInfo("Det Udom", "75", 14.90598, 105.07836);
case 659: return new CityInfo("Den Chai", "07", 17.98372, 100.05217);
case 660: return new CityInfo("Dan Sai", "18", 17.28011, 101.14686);
case 661: return new CityInfo("Dan Khun Thot", "27", 15.2085, 101.77138);
case 662: return new CityInfo("Chum Phuang", "27", 15.34861, 102.74161);
case 663: return new CityInfo("Chumphon Buri", "29", 15.34862, 103.39217);
case 664: return new CityInfo("Chum Phae", "22", 16.5443, 102.09924);
case 665: return new CityInfo("Chonnabot", "22", 16.08861, 102.62178);
case 666: return new CityInfo("Chon Daen", "14", 16.18953, 100.85958);
case 667: return new CityInfo("Chon Buri", "46", 13.3622, 100.98345);
case 668: return new CityInfo("Chom Phra", "29", 15.11814, 103.60743);
case 669: return new CityInfo("Chok Chai", "27", 14.72844, 102.16524);
case 670: return new CityInfo("Chian Yai", "64", 8.16936, 100.14469);
case 671: return new CityInfo("Chiang Yuen", "24", 16.41042, 103.09767);
case 672: return new CityInfo("Chiang Saen", "03", 20.27511, 100.08689);
case 673: return new CityInfo("Chiang Klang", "04", 19.29378, 100.86169);
case 674: return new CityInfo("Chiang Khong", "03", 20.26125, 100.40461);
case 675: return new CityInfo("Chiang Khan", "18", 17.89382, 101.65997);
case 676: return new CityInfo("Chiang Kham", "41", 19.52331, 100.3);
case 677: return new CityInfo("Cha-uat", "64", 7.96773, 99.99985);
case 678: return new CityInfo("Chaturaphak Phiman", "25", 15.84572, 103.55719);
case 679: return new CityInfo("Chatturat", "26", 15.56542, 101.84547);
case 680: return new CityInfo("Chat Trakan", "12", 17.27606, 100.60022);
case 681: return new CityInfo("Chanuman", "77", 16.23356, 105.0005);
case 682: return new CityInfo("Chanthaburi", "48", 12.60961, 102.10447);
case 683: return new CityInfo("Chanae", "31", 6.09914, 101.69353);
case 684: return new CityInfo("Chana", "68", 6.91542, 100.74039);
case 685: return new CityInfo("Chaloem Phra Kiat", "27", 15.00508, 102.27033);
case 686: return new CityInfo("Chaiyo", "35", 14.64878, 100.47878);
case 687: return new CityInfo("Chaiyaphum", "26", 15.81047, 102.02881);
case 688: return new CityInfo("Chaiwan", "76", 17.29447, 103.23385);
case 689: return new CityInfo("Chai Nat", "32", 15.18636, 100.12353);
case 690: return new CityInfo("Chai Badan", "34", 15.2, 101.13333);
case 691: return new CityInfo("Chachoengsao", "44", 13.6882, 101.07156);
case 692: return new CityInfo("Buri Ram", "28", 14.99433, 103.10392);
case 693: return new CityInfo("Buntharik", "75", 14.75639, 105.41147);
case 694: return new CityInfo("Bueng Sam Phan", "14", 15.83024, 100.91938);
case 695: return new CityInfo("Bueng Khong Long", "81", 17.96129, 104.04667);
case 696: return new CityInfo("Bueng Kan", "81", 18.36303, 103.65194);
case 697: return new CityInfo("Bua Yai", "27", 15.58552, 102.42587);
case 698: return new CityInfo("Bua Chet", "29", 14.52814, 103.94567);
case 699: return new CityInfo("Bo Thong", "46", 13.27825, 101.44028);
case 700: return new CityInfo("Bo Rai", "49", 12.57283, 102.53714);
case 701: return new CityInfo("Borabue", "24", 16.04179, 103.11506);
case 702: return new CityInfo("Bo Kluea", "04", 19.15029, 101.1556);
case 703: return new CityInfo("Betong", "70", 5.77434, 101.07231);
case 704: return new CityInfo("Wang Pong", "14", 16.34147, 100.79317);
case 705: return new CityInfo("Wang Muang", "37", 14.84228, 101.1255);
case 706: return new CityInfo("Ban Thai Tan", "35", 14.62161, 100.48739);
case 707: return new CityInfo("Ban Thaen", "26", 16.40506, 102.34239);
case 708: return new CityInfo("Song Khwae", "04", 19.35964, 100.70042);
case 709: return new CityInfo("Ban Selaphum", "25", 16.01667, 103.95);
case 710: return new CityInfo("Sawang Wirawong", "75", 15.24158, 105.0922);
case 711: return new CityInfo("Ban Sang", "74", 13.99503, 101.22095);
case 712: return new CityInfo("Ban Sam Chuk", "51", 14.74219, 100.09531);
case 713: return new CityInfo("Ratchasan", "44", 13.78211, 101.28133);
case 714: return new CityInfo("Ban Phue", "76", 17.68877, 102.47878);
case 715: return new CityInfo("Ban Phraek", "36", 14.64681, 100.57617);
case 716: return new CityInfo("Ban Pho", "44", 13.59864, 101.07956);
case 717: return new CityInfo("Ban Phe", "47", 12.62824, 101.43757);
case 718: return new CityInfo("Pattaya", "46", 12.93333, 100.88333);
case 719: return new CityInfo("Ban Phan Don", "76", 17.14272, 102.97261);
case 720: return new CityInfo("Ban Phai", "22", 16.05997, 102.73097);
case 721: return new CityInfo("Ban Phaeo", "55", 13.59072, 100.10748);
case 722: return new CityInfo("Ban Phaeng", "73", 17.96507, 104.21534);
case 723: return new CityInfo("Pak Chom", "18", 18.02061, 101.89828);
case 724: return new CityInfo("Nong Muang Khai", "07", 18.26464, 100.18967);
case 725: return new CityInfo("Nong Don", "37", 14.68488, 100.7094);
case 726: return new CityInfo("Na Yia", "75", 15.06367, 105.05994);
case 727: return new CityInfo("Na Yai Am", "48", 12.78153, 101.82256);
case 728: return new CityInfo("Na Thom", "73", 17.78491, 104.09082);
case 729: return new CityInfo("Ban Nang Sata", "70", 6.26638, 101.26461);
case 730: return new CityInfo("Na Khu", "23", 16.76384, 104.02626);
case 731: return new CityInfo("Na Haeo", "18", 17.48536, 101.06808);
case 732: return new CityInfo("Na Di", "74", 14.11517, 101.78189);
case 733: return new CityInfo("Ban Na", "43", 14.26238, 101.07111);
case 734: return new CityInfo("Ban Muang", "20", 17.8508, 103.56939);
case 735: return new CityInfo("Muak Lek", "37", 14.65287, 101.20022);
case 736: return new CityInfo("Ban Mo", "37", 14.61544, 100.72731);
case 737: return new CityInfo("Ban Mi", "34", 15.04428, 100.53681);
case 738: return new CityInfo("Mae Lan", "69", 6.66114, 101.23958);
case 739: return new CityInfo("Chiang Muan", "41", 18.88969, 100.30589);
case 740: return new CityInfo("Ban Luang", "04", 18.84969, 100.43725);
case 741: return new CityInfo("Ban Lueam", "27", 15.60916, 102.12928);
case 742: return new CityInfo("Lao Suea Kok", "75", 15.4183, 104.92363);
case 743: return new CityInfo("Ban Lam Luk Ka", "39", 13.97738, 100.77776);
case 744: return new CityInfo("Kut Rang", "24", 16.09398, 103.00998);
case 745: return new CityInfo("Ban Kruat", "28", 14.42313, 103.09974);
case 746: return new CityInfo("Ban Ko Lan", "46", 12.92419, 100.78794);
case 747: return new CityInfo("Ban Khwao", "26", 15.77772, 101.9072);
case 748: return new CityInfo("Khok Sung", "80", 13.83824, 102.62254);
case 749: return new CityInfo("Bang Rachan", "33", 14.79717, 100.3065);
case 750: return new CityInfo("Ban Khok", "10", 18.02614, 101.06772);
case 751: return new CityInfo("Khlong Khuean", "44", 13.79131, 101.16353);
case 752: return new CityInfo("Khlong Hoi Khong", "68", 6.89865, 100.38885);
case 753: return new CityInfo("Khao Chakan", "80", 13.6535, 102.08825);
case 754: return new CityInfo("Ban Khai", "47", 12.78261, 101.29639);
case 755: return new CityInfo("Kap Choeng", "29", 14.47486, 103.59439);
case 756: return new CityInfo("Kapho", "69", 6.55968, 101.53426);
case 757: return new CityInfo("Kaeng Sanam Nang", "27", 15.74954, 102.25484);
case 758: return new CityInfo("Kaeng Hang Maeo", "48", 13.00825, 101.90608);
case 759: return new CityInfo("Bang Yai", "38", 13.84341, 100.36251);
case 760: return new CityInfo("Bang Sai", "36", 14.33433, 100.30378);
case 761: return new CityInfo("Bang Rakam", "12", 16.75847, 100.11742);
case 762: return new CityInfo("Bang Rak", "40", 13.73058, 100.52388);
case 763: return new CityInfo("Bang Racham", "33", 14.892, 100.31728);
case 764: return new CityInfo("Bang Pla Ma", "51", 14.39604, 100.1587);
case 765: return new CityInfo("Bang Pakong", "44", 13.54297, 100.99333);
case 766: return new CityInfo("Bang Pa-in", "36", 14.22783, 100.57589);
case 767: return new CityInfo("Bang Pahan", "36", 14.46217, 100.54478);
case 768: return new CityInfo("Bang Nam Priao", "44", 13.84739, 101.05306);
case 769: return new CityInfo("Bang Mun Nak", "13", 16.02781, 100.37917);
case 770: return new CityInfo("Bang Len", "53", 14.02188, 100.17183);
case 771: return new CityInfo("Bang Lamung", "46", 13.04704, 100.92891);
case 772: return new CityInfo("Bang Kruai", "38", 13.805, 100.47283);
case 773: return new CityInfo("Bang Krathum", "12", 16.57831, 100.30034);
case 774: return new CityInfo("Bangkok Yai", "40", 13.72319, 100.476);
case 775: return new CityInfo("Bangkok Noi", "40", 13.76266, 100.47798);
case 776: return new CityInfo("Bang Khun Thian", "40", 13.66302, 100.43416);
case 777: return new CityInfo("Bang Khla", "44", 13.72144, 101.20814);
case 778: return new CityInfo("Bang Kapi", "40", 13.7653, 100.647);
case 779: return new CityInfo("Bang Bua Thong", "38", 13.91783, 100.42403);
case 780: return new CityInfo("Bang Bo", "42", 13.57428, 100.83533);
case 781: return new CityInfo("Bang Ban", "36", 14.37395, 100.48528);
case 782: return new CityInfo("Ban Fang", "22", 16.45331, 102.63892);
case 783: return new CityInfo("Ban Dung", "76", 17.699, 103.25957);
case 784: return new CityInfo("Don Phut", "37", 14.59175, 100.62828);
case 785: return new CityInfo("Ban Chang", "47", 12.72543, 101.05531);
case 786: return new CityInfo("Chamni", "28", 14.78629, 102.82277);
case 787: return new CityInfo("Chakkarat", "27", 15.01353, 102.41289);
case 788: return new CityInfo("Ban Bueng", "46", 13.311, 101.11214);
case 789: return new CityInfo("Bueng Na Rang", "13", 16.1712, 100.12531);
case 790: return new CityInfo("Ban Talat Bueng", "46", 13.07147, 101.00314);
case 791: return new CityInfo("Bang Na", "40", 13.66744, 100.64206);
case 792: return new CityInfo("Bang Klam", "68", 7.08953, 100.41075);
case 793: return new CityInfo("Bang Kaeo", "66", 7.42947, 100.17803);
case 794: return new CityInfo("Ban Bang Kadi Pathum Thani", "36", 13.99904, 100.54962);
case 795: return new CityInfo("Bang Bo District", "42", 13.58333, 100.81667);
case 796: return new CityInfo("Ban Bang Bao", "49", 11.9727, 102.31168);
case 797: return new CityInfo("Lue Amnat", "77", 15.69476, 104.64846);
case 798: return new CityInfo("Bamnet Narong", "26", 15.50189, 101.68982);
case 799: return new CityInfo("At Samat", "25", 15.84308, 103.87839);
case 800: return new CityInfo("Aranyaprathet", "80", 13.69276, 102.50128);
case 801: return new CityInfo("Ang Thong", "35", 14.58839, 100.45283);
case 802: return new CityInfo("Amnat Charoen", "77", 15.85851, 104.62883);
case 803: return new CityInfo("Akat Amnuai", "20", 17.59639, 103.9816);
case 804: return new CityInfo("Phon Charoen", "81", 18.03143, 103.70996);
case 805: return new CityInfo("Chaiyo", "35", 14.67639, 100.46861);
case 806: return new CityInfo("Samrong", "75", 15.00781, 104.78419);
case 807: return new CityInfo("Bueng Bun", "30", 15.3303, 104.04485);
case 808: return new CityInfo("Song Dao", "20", 17.33628, 103.47547);
case 809: return new CityInfo("Thung Yang Daeng", "69", 6.61822, 101.4265);
case 810: return new CityInfo("Amphoe Sikhiu", "27", 14.89944, 101.70833);
case 811: return new CityInfo("Phanom Dong Rak", "29", 14.44575, 103.30508);
case 812: return new CityInfo("Saladan", "63", 7.61342, 99.03651);
case 813: return new CityInfo("Wichit", "62", 7.8894, 98.38523);
case 814: return new CityInfo("Ko Pha Ngan", "60", 9.75778, 100.02914);
case 815: return new CityInfo("Koh Tao", "60", 10.09808, 99.83809);
case 816: return new CityInfo("Bang Sue", "40", 13.81003, 100.53714);
case 817: return new CityInfo("Don Mueang", "40", 13.91392, 100.58994);
case 818: return new CityInfo("Salaya", "53", 13.802, 100.32111);
case 819: return new CityInfo("Khlong Toei", "40", 13.71669, 100.57159);
case 820: return new CityInfo("Patong", "62", 7.89607, 98.29661);
case 821: return new CityInfo("Chun", "41", 19.33695, 100.13478);
case 822: return new CityInfo("Thung Chang", "04", 19.38786, 100.87619);
case 823: return new CityInfo("Lat Krabang", "40", 13.72341, 100.78436);
case 824: return new CityInfo("Bang Khae", "40", 13.69196, 100.40691);
case 825: return new CityInfo("Bang Kho Laem", "40", 13.69347, 100.5022);
case 826: return new CityInfo("Bueng Kum", "40", 13.78528, 100.66958);
case 827: return new CityInfo("Chatuchak", "40", 13.82893, 100.55985);
case 828: return new CityInfo("Chom Thong", "40", 13.67717, 100.48407);
case 829: return new CityInfo("Huai Khwang", "40", 13.77678, 100.579);
case 830: return new CityInfo("Khan Na Yao", "40", 13.82609, 100.67933);
case 831: return new CityInfo("Khlong Sam Wa", "40", 13.83616, 100.73524);
case 832: return new CityInfo("Lat Phrao", "40", 13.80349, 100.60749);
case 833: return new CityInfo("Pathum Wan", "40", 13.73649, 100.5239);
case 834: return new CityInfo("Phaya Thai", "40", 13.78005, 100.54275);
case 835: return new CityInfo("Ratchathewi", "40", 13.759, 100.53358);
case 836: return new CityInfo("Sai Mai", "40", 13.92068, 100.64552);
case 837: return new CityInfo("Saphan Sung", "40", 13.77019, 100.68531);
case 838: return new CityInfo("Sathon", "40", 13.7085, 100.52619);
case 839: return new CityInfo("Suan Luang", "40", 13.73028, 100.65138);
case 840: return new CityInfo("Thawi Watthana", "40", 13.78851, 100.33334);
case 841: return new CityInfo("Thung Khru", "40", 13.62875, 100.50964);
case 842: return new CityInfo("Wang Thonglang", "40", 13.78546, 100.61165);
case 843: return new CityInfo("Watthana", "40", 13.72978, 100.58536);
case 844: return new CityInfo("Sop Pong", "01", 19.51881, 98.26042);
case 845: return new CityInfo("Ban Chalong", "62", 7.84468, 98.33897);
case 846: return new CityInfo("Ban Ratsada", "62", 7.90963, 98.40248);
case 847: return new CityInfo("Mueang Phuket", "62", 7.86338, 98.36437);
case 848: return new CityInfo("Bang Sao Thong", "42", 13.595, 100.83042);
case 849: return new CityInfo("Ko Chang Tai", "49", 12.00171, 102.37267);
case 850: return new CityInfo("Phi Phi Don", "", 7.74044, 98.772);
case 851: return new CityInfo("Nai Harn", "62", 7.77859, 98.30661);
case 852: return new CityInfo("Ta Lo Wow", "67", 6.70237, 99.66539);
case 853: return new CityInfo("Son", "67", 6.62675, 99.61656);
case 854: return new CityInfo("Pante Malakar", "67", 6.68439, 99.64359);
case 855: return new CityInfo("Mae Fa Luang", "03", 20.26628, 99.79846);
case 856: return new CityInfo("Wiang Chiang Rung", "03", 20.01328, 100.05639);
case 857: return new CityInfo("Wiang Kaen", "03", 20.11297, 100.51331);
case 858: return new CityInfo("Khun Tan", "03", 19.83353, 100.25858);
case 859: return new CityInfo("Chaloem Phra Kiat", "04", 19.57881, 101.08011);
case 860: return new CityInfo("Mae Lao", "03", 19.79003, 99.69967);
case 861: return new CityInfo("Suk Samran", "59", 9.34458, 98.42903);
case 862: return new CityInfo("Ban Takhun", "60", 8.90364, 98.8845);
case 863: return new CityInfo("Takuk Nuea", "60", 9.23894, 98.97861);
case 864: return new CityInfo("Wiang Nong Long", "05", 18.42043, 98.74967);
case 865: return new CityInfo("Mae Poen", "16", 15.65789, 99.46981);
case 866: return new CityInfo("Pang Sila Thong", "11", 16.09631, 99.48906);
case 867: return new CityInfo("Kosamphi Nakhon", "11", 16.63131, 99.34975);
case 868: return new CityInfo("Ban Thi", "05", 18.63186, 99.11661);
case 869: return new CityInfo("Manang", "67", 6.99933, 99.92161);
case 870: return new CityInfo("Ratsada", "65", 7.97467, 99.63353);
case 871: return new CityInfo("Phra Phrom", "64", 8.33911, 99.90092);
case 872: return new CityInfo("Chulabhorn", "64", 8.07597, 99.86947);
case 873: return new CityInfo("Chang Klang", "64", 8.37094, 99.56249);
case 874: return new CityInfo("Nong Yasai", "51", 14.77988, 99.91073);
case 875: return new CityInfo("Chum Ta Bong", "16", 15.63194, 99.55231);
case 876: return new CityInfo("Mae Wong", "16", 15.78164, 99.51864);
case 877: return new CityInfo("Bueng Samakkhi", "11", 16.18728, 99.97525);
case 878: return new CityInfo("Phu Kam Yao", "41", 19.2705, 99.97011);
case 879: return new CityInfo("Chaloem Phra Kiat", "64", 8.17689, 100.03581);
case 880: return new CityInfo("Sawaengha", "35", 14.75186, 100.32481);
case 881: return new CityInfo("Doem Bang Nang Buat", "51", 14.85428, 100.09772);
case 882: return new CityInfo("Chumsaeng", "16", 15.89152, 100.30795);
case 883: return new CityInfo("Wachira Barami", "13", 16.52314, 100.14464);
case 884: return new CityInfo("Thong Saen Khan", "10", 17.47065, 100.33146);
case 885: return new CityInfo("Laplae", "10", 17.65211, 100.03892);
case 886: return new CityInfo("Chaloem Phra Kiat", "37", 14.6115, 100.90825);
case 887: return new CityInfo("Santi Suk", "04", 18.9137, 100.94169);
case 888: return new CityInfo("Phu Phiang", "04", 18.74264, 100.79951);
case 889: return new CityInfo("Nikhom Phattana", "47", 12.82736, 101.20273);
case 890: return new CityInfo("Ko Chan", "46", 13.41658, 101.33458);
case 891: return new CityInfo("Si Mahosot", "74", 13.8878, 101.40501);
case 892: return new CityInfo("Phakdi Chumphon", "26", 15.90517, 101.42228);
case 893: return new CityInfo("Khao Chamao", "47", 12.97586, 101.68511);
case 894: return new CityInfo("Tha Takiap", "44", 13.44547, 101.61133);
case 895: return new CityInfo("Wang Nam Khiao", "27", 14.41801, 101.86113);
case 896: return new CityInfo("Prachamtakham", "74", 14.06442, 101.51503);
case 897: return new CityInfo("Sap Yai", "26", 15.63739, 101.61671);
case 898: return new CityInfo("Erawan", "18", 17.30181, 101.95382);
case 899: return new CityInfo("Khao Khitchakut", "48", 12.80481, 102.11514);
case 900: return new CityInfo("Soi Dao", "48", 13.12894, 102.21402);
case 901: return new CityInfo("Wang Sombun", "80", 13.36176, 102.19105);
case 902: return new CityInfo("Noen Sa-nga", "26", 15.56428, 102.00128);
case 903: return new CityInfo("Khok Pho Chai", "22", 16.08375, 102.399);
case 904: return new CityInfo("Na Wang", "79", 17.32444, 102.07829);
case 905: return new CityInfo("Suwanna Khuha", "79", 17.56292, 102.27989);
case 906: return new CityInfo("Non Din Daeng", "28", 14.31353, 102.74814);
case 907: return new CityInfo("Pa Kham", "28", 14.43817, 102.72558);
case 908: return new CityInfo("Chaloem Phra Kiat", "28", 14.55839, 102.92475);
case 909: return new CityInfo("Lam Thamen Chai", "27", 15.3535, 102.91803);
case 910: return new CityInfo("Non Daeng", "27", 15.41061, 102.54025);
case 911: return new CityInfo("Ban Mai Chaiyaphot", "28", 15.57361, 102.83331);
case 912: return new CityInfo("Non Sila", "22", 15.97439, 102.66983);
case 913: return new CityInfo("Ubonratana", "22", 16.75269, 102.63245);
case 914: return new CityInfo("Ban Na Muang", "76", 17.23824, 103.00892);
case 915: return new CityInfo("Sa Khrai", "17", 17.67544, 102.75069);
case 916: return new CityInfo("Phlapphla Chai", "28", 14.73011, 103.16728);
case 917: return new CityInfo("Si Somdet", "25", 15.99797, 103.48789);
case 918: return new CityInfo("Khong Chai", "23", 16.26025, 103.45828);
case 919: return new CityInfo("Chuen Chom", "24", 16.55488, 103.17661);
case 920: return new CityInfo("Sam Sung", "22", 16.5432, 103.07992);
case 921: return new CityInfo("Ku Kaeo", "76", 17.17214, 103.15303);
case 922: return new CityInfo("Phibun Rak", "76", 17.55312, 103.05794);
case 923: return new CityInfo("Pakkhat", "17", 18.29789, 103.30689);
case 924: return new CityInfo("Phonphisai", "17", 18.02106, 103.07664);
case 925: return new CityInfo("Si Narong", "29", 14.76736, 103.87392);
case 926: return new CityInfo("Non Narai", "29", 15.23764, 103.91333);
case 927: return new CityInfo("Khwao Sinarin", "29", 15.00244, 103.59154);
case 928: return new CityInfo("Thung Khao Luang", "25", 15.99397, 103.86264);
case 929: return new CityInfo("Chiang Khwan", "25", 16.16328, 103.75359);
case 930: return new CityInfo("Changhan", "25", 16.13873, 103.60388);
case 931: return new CityInfo("Don Chan", "23", 16.45711, 103.69558);
case 932: return new CityInfo("Phu Phan", "20", 16.99891, 103.97347);
case 933: return new CityInfo("Si Wilai", "81", 18.18188, 103.74793);
case 934: return new CityInfo("Phu Sing", "30", 14.54744, 104.13167);
case 935: return new CityInfo("Pho Si Suwan", "30", 15.22929, 104.0767);
case 936: return new CityInfo("Sila Lat", "30", 15.47156, 104.07153);
case 937: return new CityInfo("Thai Charoen", "72", 16.06645, 104.44018);
case 938: return new CityInfo("Phon Na Kaeo", "20", 17.22122, 104.28995);
case 939: return new CityInfo("Wang Yang", "73", 17.05751, 104.45333);
case 940: return new CityInfo("Nathom", "73", 17.78536, 104.09072);
case 941: return new CityInfo("Thung Si Udom", "75", 14.73303, 104.90897);
case 942: return new CityInfo("Nam Khun", "75", 14.58386, 104.92481);
case 943: return new CityInfo("Benchalak", "30", 14.79583, 104.67017);
case 944: return new CityInfo("Pathum Ratchawongsa", "77", 15.89224, 104.90563);
case 945: return new CityInfo("Don Mot Daeng", "75", 15.37903, 105.02786);
case 946: return new CityInfo("Mae Wang", "02", 18.61604, 98.77292);
case 947: return new CityInfo("Khao Kho", "14", 16.65791, 101.02208);
case 948: return new CityInfo("Phra Thong Kham", "27", 15.26686, 102.02024);
case 949: return new CityInfo("Wiang Kao", "22", 16.68247, 102.28511);
case 950: return new CityInfo("Khaen Dong", "28", 15.32476, 103.13343);
case 951: return new CityInfo("Sirindhorn", "75", 15.20084, 105.39222);
case 952: return new CityInfo("Sida", "27", 15.54994, 102.56675);
case 953: return new CityInfo("Srinagarindra", "66", 7.56991, 99.94353);
case 954: return new CityInfo("Sam Chai", "23", 16.86322, 103.54106);
case 955: return new CityInfo("Dong Charoen", "13", 16.02058, 100.66286);
case 956: return new CityInfo("Chaem Luang", "02", 19.03193, 98.28767);
case 957: return new CityInfo("Rattanawapi", "17", 18.21365, 103.17967);
case 958: return new CityInfo("Hat Samran", "65", 7.24034, 99.57621);
case 959: return new CityInfo("Ban Pa Pae", "01", 18.28425, 98.05683);
case 960: return new CityInfo("Bung Khla", "81", 18.30232, 103.97418);
case 961: return new CityInfo("Chai Prakan", "02", 19.73136, 99.13997);
case 962: return new CityInfo("Doi Luang", "03", 20.11783, 100.09919);
case 963: return new CityInfo("Mae On", "02", 18.77681, 99.24861);
case 964: return new CityInfo("Sop Moei", "01", 17.96209, 97.93288);
case 965: return new CityInfo("Bua Lai", "27", 15.66548, 102.49881);
case 966: return new CityInfo("Phra Samut Chedi", "42", 13.60222, 100.5721);
case 967: return new CityInfo("Singhanakhon", "68", 7.23903, 100.55272);
case 968: return new CityInfo("Phu Sang", "41", 19.59903, 100.32444);
case 969: return new CityInfo("Mae Hi", "01", 19.34286, 98.45023);
case 970: return new CityInfo("Pa Phayom", "66", 7.84031, 99.91773);
case 971: return new CityInfo("Na Yong", "65", 7.56167, 99.69483);
case 972: return new CityInfo("Pho Tak", "17", 17.87486, 102.40406);
case 973: return new CityInfo("Ko Kut", "49", 11.65856, 102.54197);
case 974: return new CityInfo("Bang Bon", "40", 13.66185, 100.39567);
case 975: return new CityInfo("Din Daeng", "40", 13.76994, 100.55299);
case 976: return new CityInfo("Phra Nakhon", "40", 13.76512, 100.49864);
default: return new CityInfo("Na Kluea", "46", 12.96199, 100.89715);

                                    }                                        
                                }
                            
                        }
                    }
                