
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
                                    public const string Country = "LV";
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
                            
                                        var cur = (Math.Abs(57.54108 - lat) + Math.Abs(25.42751 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(56.38616 - lat) + Math.Abs(28.12165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.45167 - lat) + Math.Abs(23.35194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.18458 - lat) + Math.Abs(27.6722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55253 - lat) + Math.Abs(26.92449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.34751 - lat) + Math.Abs(25.55514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.60608 - lat) + Math.Abs(24.52232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.39485 - lat) + Math.Abs(21.56121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19838 - lat) + Math.Abs(26.50811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.0609 - lat) + Math.Abs(25.81624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.60826 - lat) + Math.Abs(26.75377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.09358 - lat) + Math.Abs(24.54468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.7752 - lat) + Math.Abs(26.01013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.37068 - lat) + Math.Abs(22.59188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41848 - lat) + Math.Abs(21.85405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9363 - lat) + Math.Abs(24.30387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.96764 - lat) + Math.Abs(23.15554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.83991 - lat) + Math.Abs(23.58902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.47989 - lat) + Math.Abs(23.38895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.24562 - lat) + Math.Abs(22.58137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0062 - lat) + Math.Abs(25.90756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.62574 - lat) + Math.Abs(25.68535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.14497 - lat) + Math.Abs(22.53482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.37065 - lat) + Math.Abs(25.03106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.83579 - lat) + Math.Abs(24.74706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.42444 - lat) + Math.Abs(25.90164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9542 - lat) + Math.Abs(23.33736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.67749 - lat) + Math.Abs(22.01649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.645 - lat) + Math.Abs(25.12058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75284 - lat) + Math.Abs(26.78508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.15375 - lat) + Math.Abs(24.85953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.65042 - lat) + Math.Abs(25.75089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.26224 - lat) + Math.Abs(24.41471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.66363 - lat) + Math.Abs(22.48807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.86014 - lat) + Math.Abs(24.36544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.75312 - lat) + Math.Abs(24.35895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.50675 - lat) + Math.Abs(25.76423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04577 - lat) + Math.Abs(22.57261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.42503 - lat) + Math.Abs(23.987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.89752 - lat) + Math.Abs(25.33155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.00325 - lat) + Math.Abs(27.13371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16314 - lat) + Math.Abs(21.16156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04486 - lat) + Math.Abs(24.41951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9747 - lat) + Math.Abs(24.63295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.50146 - lat) + Math.Abs(22.80881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.946 - lat) + Math.Abs(24.10589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.3428 - lat) + Math.Abs(26.79995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.51028 - lat) + Math.Abs(27.34 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.33173 - lat) + Math.Abs(25.60947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.18074 - lat) + Math.Abs(24.70731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.02226 - lat) + Math.Abs(23.49561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.315 - lat) + Math.Abs(25.36147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.44679 - lat) + Math.Abs(21.58968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.29444 - lat) + Math.Abs(26.72459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6178 - lat) + Math.Abs(25.72552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.94189 - lat) + Math.Abs(23.91365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.22426 - lat) + Math.Abs(21.67439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41812 - lat) + Math.Abs(24.01625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.88791 - lat) + Math.Abs(21.18593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.68986 - lat) + Math.Abs(23.7761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.79472 - lat) + Math.Abs(23.9358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.8162 - lat) + Math.Abs(24.61401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.34601 - lat) + Math.Abs(21.06401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.20279 - lat) + Math.Abs(25.30752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.88349 - lat) + Math.Abs(25.45609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.47312 - lat) + Math.Abs(25.49174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.97752 - lat) + Math.Abs(23.22583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.00008 - lat) + Math.Abs(24.15997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.33535 - lat) + Math.Abs(23.12455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.86329 - lat) + Math.Abs(25.05475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.69892 - lat) + Math.Abs(25.15886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.0101 - lat) + Math.Abs(24.95783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.85329 - lat) + Math.Abs(26.21698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.53958 - lat) + Math.Abs(27.71891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.90425 - lat) + Math.Abs(26.71606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.15336 - lat) + Math.Abs(24.6433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.35431 - lat) + Math.Abs(26.17579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.51287 - lat) + Math.Abs(24.71941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.23429 - lat) + Math.Abs(25.04059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.50474 - lat) + Math.Abs(21.01085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.72066 - lat) + Math.Abs(24.80743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.58173 - lat) + Math.Abs(21.33399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.97399 - lat) + Math.Abs(21.95721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.51068 - lat) + Math.Abs(25.86117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.89514 - lat) + Math.Abs(27.16799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.65163 - lat) + Math.Abs(25.43637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.52057 - lat) + Math.Abs(25.33821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.82662 - lat) + Math.Abs(24.23 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.7451 - lat) + Math.Abs(24.72439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.78405 - lat) + Math.Abs(27.68829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.55128 - lat) + Math.Abs(21.01287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04087 - lat) + Math.Abs(22.77466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.07909 - lat) + Math.Abs(24.15924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.968 - lat) + Math.Abs(23.77038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.67613 - lat) + Math.Abs(24.9721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.65 - lat) + Math.Abs(23.71278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.49903 - lat) + Math.Abs(25.85735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.73137 - lat) + Math.Abs(23.01247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.17745 - lat) + Math.Abs(26.0284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.61319 - lat) + Math.Abs(25.08316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.0391 - lat) + Math.Abs(24.17413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16066 - lat) + Math.Abs(27.00714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.09867 - lat) + Math.Abs(24.6863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97754 - lat) + Math.Abs(26.29655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.83399 - lat) + Math.Abs(24.49679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.59766 - lat) + Math.Abs(24.20763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.17767 - lat) + Math.Abs(26.75291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.53521 - lat) + Math.Abs(21.16782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.5498 - lat) + Math.Abs(27.8837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.89752 - lat) + Math.Abs(25.63668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16061 - lat) + Math.Abs(23.22527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.02065 - lat) + Math.Abs(21.69113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.50498 - lat) + Math.Abs(22.35041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.24316 - lat) + Math.Abs(25.27748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.62372 - lat) + Math.Abs(23.2751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.88333 - lat) + Math.Abs(26.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.04315 - lat) + Math.Abs(24.03613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09512 - lat) + Math.Abs(27.53723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.96754 - lat) + Math.Abs(26.30764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.31188 - lat) + Math.Abs(25.27456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.12935 - lat) + Math.Abs(24.28423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6789 - lat) + Math.Abs(22.56945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.03132 - lat) + Math.Abs(24.05571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98639 - lat) + Math.Abs(24.29917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.40794 - lat) + Math.Abs(24.19443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.1313 - lat) + Math.Abs(27.26583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.94394 - lat) + Math.Abs(27.64401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.74451 - lat) + Math.Abs(24.40078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.45981 - lat) + Math.Abs(22.90169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.53928 - lat) + Math.Abs(26.69291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.42162 - lat) + Math.Abs(27.04662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.98194 - lat) + Math.Abs(21.55938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.76723 - lat) + Math.Abs(24.87743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16152 - lat) + Math.Abs(25.74783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.72108 - lat) + Math.Abs(21.60156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.60477 - lat) + Math.Abs(25.25534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.86348 - lat) + Math.Abs(24.35853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13274 - lat) + Math.Abs(27.00682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.07045 - lat) + Math.Abs(24.33713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.87643 - lat) + Math.Abs(24.11825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.90544 - lat) + Math.Abs(24.05113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Valmiera", "31", 57.54108, 25.42751);
case 1: return new CityInfo("Zilupe", "E9", 56.38616, 28.12165);
case 2: return new CityInfo("Zelmeņi", "D5", 56.45167, 23.35194);
case 3: return new CityInfo("Viļaka", "E7", 57.18458, 27.6722);
case 4: return new CityInfo("Viļāni", "E8", 56.55253, 26.92449);
case 5: return new CityInfo("Viesīte", "E6", 56.34751, 25.55514);
case 6: return new CityInfo("Vecumnieki", "E4", 56.60608, 24.52232);
case 7: return new CityInfo("Ventspils", "32", 57.39485, 21.56121);
case 8: return new CityInfo("Vecvārkava", "E2", 56.19838, 26.50811);
case 9: return new CityInfo("Vecpiebalga", "E3", 57.0609, 25.81624);
case 10: return new CityInfo("Varakļāni", "E1", 56.60826, 26.75377);
case 11: return new CityInfo("Vangaži", "70", 57.09358, 24.54468);
case 12: return new CityInfo("Valka", "30", 57.7752, 26.01013);
case 13: return new CityInfo("Valdemārpils", "28", 57.37068, 22.59188);
case 14: return new CityInfo("Vaiņode", "D7", 56.41848, 21.85405);
case 15: return new CityInfo("Ulbroka", "D2", 56.9363, 24.30387);
case 16: return new CityInfo("Tukums", "29", 56.96764, 23.15554);
case 17: return new CityInfo("Tīreļi", "12", 56.83991, 23.58902);
case 18: return new CityInfo("Tērvete", "D5", 56.47989, 23.38895);
case 19: return new CityInfo("Talsi", "28", 57.24562, 22.58137);
case 20: return new CityInfo("Subate", "07", 56.0062, 25.90756);
case 21: return new CityInfo("Strenči", "D3", 57.62574, 25.68535);
case 22: return new CityInfo("Stende", "28", 57.14497, 22.53482);
case 23: return new CityInfo("Stalbe", "A4", 57.37065, 25.03106);
case 24: return new CityInfo("Staicele", "39", 57.83579, 24.74706);
case 25: return new CityInfo("Smiltene", "D1", 57.42444, 25.90164);
case 26: return new CityInfo("Smārde", "62", 56.9542, 23.33736);
case 27: return new CityInfo("Skrunda", "C9", 56.67749, 22.01649);
case 28: return new CityInfo("Skrīveri", "C8", 56.645, 25.12058);
case 29: return new CityInfo("Silene", "07", 55.75284, 26.78508);
case 30: return new CityInfo("Sigulda", "C7", 57.15375, 24.85953);
case 31: return new CityInfo("Seda", "D3", 57.65042, 25.75089);
case 32: return new CityInfo("Saulkrasti", "C5", 57.26224, 24.41471);
case 33: return new CityInfo("Saldus", "27", 56.66363, 22.48807);
case 34: return new CityInfo("Salaspils", "C3", 56.86014, 24.36544);
case 35: return new CityInfo("Salacgrīva", "C1", 57.75312, 24.35895);
case 36: return new CityInfo("Sala", "C2", 56.50675, 25.76423);
case 37: return new CityInfo("Sabile", "28", 57.04577, 22.57261);
case 38: return new CityInfo("Pilsrundāle", "B9", 56.42503, 23.987);
case 39: return new CityInfo("Rūjiena", "B8", 57.89752, 25.33155);
case 40: return new CityInfo("Rugāji", "B7", 57.00325, 27.13371);
case 41: return new CityInfo("Rucava", "B6", 56.16314, 21.16156);
case 42: return new CityInfo("Garkalne", "64", 57.04486, 24.41951);
case 43: return new CityInfo("Ropaži", "B5", 56.9747, 24.63295);
case 44: return new CityInfo("Roja", "B4", 57.50146, 22.80881);
case 45: return new CityInfo("Riga", "25", 56.946, 24.10589);
case 46: return new CityInfo("Riebiņi", "B3", 56.3428, 26.79995);
case 47: return new CityInfo("Rēzekne", "23", 56.51028, 27.34);
case 48: return new CityInfo("Rauna", "B1", 57.33173, 25.60947);
case 49: return new CityInfo("Ragana", "84", 57.18074, 24.70731);
case 50: return new CityInfo("Ragaciems", "62", 57.02226, 23.49561);
case 51: return new CityInfo("Priekuļi", "A9", 57.315, 25.36147);
case 52: return new CityInfo("Priekule", "A8", 56.44679, 21.58968);
case 53: return new CityInfo("Preiļi", "22", 56.29444, 26.72459);
case 54: return new CityInfo("Pļaviņas", "A6", 56.6178, 25.72552);
case 55: return new CityInfo("Piņķi", "45", 56.94189, 23.91365);
case 56: return new CityInfo("Piltene", "33", 57.22426, 21.67439);
case 57: return new CityInfo("Pilsrundāle", "B9", 56.41812, 24.01625);
case 58: return new CityInfo("Pāvilosta", "A5", 56.88791, 21.18593);
case 59: return new CityInfo("Ozolnieki", "A3", 56.68986, 23.7761);
case 60: return new CityInfo("Olaine", "A2", 56.79472, 23.9358);
case 61: return new CityInfo("Ogre", "21", 56.8162, 24.61401);
case 62: return new CityInfo("Nīca", "99", 56.34601, 21.06401);
case 63: return new CityInfo("Nereta", "98", 56.20279, 25.30752);
case 64: return new CityInfo("Naukšēni", "97", 57.88349, 25.45609);
case 65: return new CityInfo("Mūrmuiža", "50", 57.47312, 25.49174);
case 66: return new CityInfo("Milzkalne", "62", 56.97752, 23.22583);
case 67: return new CityInfo("Mežaparks", "25", 57.00008, 24.15997);
case 68: return new CityInfo("Mērsrags", "F1", 57.33535, 23.12455);
case 69: return new CityInfo("Mazsalaca", "96", 57.86329, 25.05475);
case 70: return new CityInfo("Matīši", "52", 57.69892, 25.15886);
case 71: return new CityInfo("Mālpils", "94", 57.0101, 24.95783);
case 72: return new CityInfo("Madona", "20", 56.85329, 26.21698);
case 73: return new CityInfo("Ludza", "19", 56.53958, 27.71891);
case 74: return new CityInfo("Lubāna", "91", 56.90425, 26.71606);
case 75: return new CityInfo("Loja", "C6", 57.15336, 24.6433);
case 76: return new CityInfo("Līvāni", "90", 56.35431, 26.17579);
case 77: return new CityInfo("Limbaži", "18", 57.51287, 24.71941);
case 78: return new CityInfo("Līgatne", "88", 57.23429, 25.04059);
case 79: return new CityInfo("Liepāja", "16", 56.50474, 21.01085);
case 80: return new CityInfo("Lielvārde", "87", 56.72066, 24.80743);
case 81: return new CityInfo("Lieģi", "61", 56.58173, 21.33399);
case 82: return new CityInfo("Kuldīga", "15", 56.97399, 21.95721);
case 83: return new CityInfo("Krustpils", "10", 56.51068, 25.86117);
case 84: return new CityInfo("Krāslava", "14", 55.89514, 27.16799);
case 85: return new CityInfo("Koknese", "82", 56.65163, 25.43637);
case 86: return new CityInfo("Kocēni", "81", 57.52057, 25.33821);
case 87: return new CityInfo("Ķekava", "80", 56.82662, 24.23);
case 88: return new CityInfo("Ķegums", "79", 56.7451, 24.72439);
case 89: return new CityInfo("Kārsava", "78", 56.78405, 27.68829);
case 90: return new CityInfo("Karosta", "16", 56.55128, 21.01287);
case 91: return new CityInfo("Kandava", "77", 57.04087, 22.77466);
case 92: return new CityInfo("Kalngale", "53", 57.07909, 24.15924);
case 93: return new CityInfo("Jūrmala", "13", 56.968, 23.77038);
case 94: return new CityInfo("Jumprava", "21", 56.67613, 24.9721);
case 95: return new CityInfo("Jelgava", "11", 56.65, 23.71278);
case 96: return new CityInfo("Jēkabpils", "10", 56.49903, 25.85735);
case 97: return new CityInfo("Jaunpils", "73", 56.73137, 23.01247);
case 98: return new CityInfo("Jaunpiebalga", "72", 57.17745, 26.0284);
case 99: return new CityInfo("Jaunjelgava", "71", 56.61319, 25.08316);
case 100: return new CityInfo("Jaunciems", "25", 57.0391, 24.17413);
case 101: return new CityInfo("Jaunaglona", "22", 56.16066, 27.00714);
case 102: return new CityInfo("Inčukalns", "70", 57.09867, 24.6863);
case 103: return new CityInfo("Ilūkste", "69", 55.97754, 26.29655);
case 104: return new CityInfo("Ikšķile", "68", 56.83399, 24.49679);
case 105: return new CityInfo("Iecava", "67", 56.59766, 24.20763);
case 106: return new CityInfo("Gulbene", "09", 57.17767, 26.75291);
case 107: return new CityInfo("Grobiņa", "65", 56.53521, 21.16782);
case 108: return new CityInfo("Cibla", "56", 56.5498, 27.8837);
case 109: return new CityInfo("Ērgļi", "63", 56.89752, 25.63668);
case 110: return new CityInfo("Engure", "29", 57.16061, 23.22527);
case 111: return new CityInfo("Ēdole", "15", 57.02065, 21.69113);
case 112: return new CityInfo("Dundaga", "60", 57.50498, 22.35041);
case 113: return new CityInfo("Drabeši", "42", 57.24316, 25.27748);
case 114: return new CityInfo("Dobele", "08", 56.62372, 23.2751);
case 115: return new CityInfo("Daugavpils", "07", 55.88333, 26.53333);
case 116: return new CityInfo("Daugavgrīva", "25", 57.04315, 24.03613);
case 117: return new CityInfo("Dagda", "57", 56.09512, 27.53723);
case 118: return new CityInfo("Cesvaine", "55", 56.96754, 26.30764);
case 119: return new CityInfo("Cēsis", "05", 57.31188, 25.27456);
case 120: return new CityInfo("Carnikava", "53", 57.12935, 24.28423);
case 121: return new CityInfo("Brocēni", "51", 56.6789, 22.56945);
case 122: return new CityInfo("Bolderaja", "25", 57.03132, 24.05571);
case 123: return new CityInfo("Berģi", "25", 56.98639, 24.29917);
case 124: return new CityInfo("Bauska", "04", 56.40794, 24.19443);
case 125: return new CityInfo("Balvi", "03", 57.1313, 27.26583);
case 126: return new CityInfo("Baltinava", "47", 56.94394, 27.64401);
case 127: return new CityInfo("Baldone", "46", 56.74451, 24.40078);
case 128: return new CityInfo("Auce", "44", 56.45981, 22.90169);
case 129: return new CityInfo("Ape", "43", 57.53928, 26.69291);
case 130: return new CityInfo("Alūksne", "02", 57.42162, 27.04662);
case 131: return new CityInfo("Alsunga", "40", 56.98194, 21.55938);
case 132: return new CityInfo("Aloja", "39", 57.76723, 24.87743);
case 133: return new CityInfo("Aknīste", "38", 56.16152, 25.74783);
case 134: return new CityInfo("Aizpute", "37", 56.72108, 21.60156);
case 135: return new CityInfo("Aizkraukle", "01", 56.60477, 25.25534);
case 136: return new CityInfo("Ainaži", "C1", 57.86348, 24.35853);
case 137: return new CityInfo("Aglona", "35", 56.13274, 27.00682);
case 138: return new CityInfo("Ādaži", "34", 57.07045, 24.33713);
case 139: return new CityInfo("Baloži", "80", 56.87643, 24.11825);
default: return new CityInfo("Mārupe", "95", 56.90544, 24.05113);

                                    }                                        
                                }
                            
                        }
                    }
                