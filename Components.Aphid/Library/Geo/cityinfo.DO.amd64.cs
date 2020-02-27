
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
                                    public const string Country = "DO";
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
                            
                                        var cur = (Math.Abs(18.6071 - lat) + Math.Abs(-70.92753 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.77315 - lat) + Math.Abs(-70.02583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3353 - lat) + Math.Abs(-70.18113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.7411 - lat) + Math.Abs(-71.4464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.30084 - lat) + Math.Abs(-70.42199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.6586 - lat) + Math.Abs(-71.03916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.18069 - lat) + Math.Abs(-69.91319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.49077 - lat) + Math.Abs(-71.48377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.81564 - lat) + Math.Abs(-71.06056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.54057 - lat) + Math.Abs(-70.78853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48278 - lat) + Math.Abs(-69.88914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.6856 - lat) + Math.Abs(-71.27007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48333 - lat) + Math.Abs(-69.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.56378 - lat) + Math.Abs(-70.87582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.67297 - lat) + Math.Abs(-70.17095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38443 - lat) + Math.Abs(-71.18009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.58333 - lat) + Math.Abs(-70.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.65354 - lat) + Math.Abs(-71.33431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.93537 - lat) + Math.Abs(-70.6885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.37439 - lat) + Math.Abs(-70.35087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.48538 - lat) + Math.Abs(-70.61104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3947 - lat) + Math.Abs(-71.2029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.56999 - lat) + Math.Abs(-70.87978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.7522 - lat) + Math.Abs(-70.51995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.47741 - lat) + Math.Abs(-70.53585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47186 - lat) + Math.Abs(-69.89232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.4517 - lat) + Math.Abs(-70.69703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.76559 - lat) + Math.Abs(-69.03886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20854 - lat) + Math.Abs(-71.10077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.20561 - lat) + Math.Abs(-69.33685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42993 - lat) + Math.Abs(-68.6739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4539 - lat) + Math.Abs(-69.30864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.80588 - lat) + Math.Abs(-71.22991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54661 - lat) + Math.Abs(-70.50631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.33915 - lat) + Math.Abs(-70.93819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38333 - lat) + Math.Abs(-70.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.30099 - lat) + Math.Abs(-70.25259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.84826 - lat) + Math.Abs(-71.64597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.79344 - lat) + Math.Abs(-70.6884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.2281 - lat) + Math.Abs(-69.6137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48333 - lat) + Math.Abs(-69.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.61501 - lat) + Math.Abs(-68.70798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.40552 - lat) + Math.Abs(-70.37985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.37762 - lat) + Math.Abs(-70.41762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.47793 - lat) + Math.Abs(-71.34125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.71667 - lat) + Math.Abs(-71.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.32114 - lat) + Math.Abs(-70.75992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26256 - lat) + Math.Abs(-70.14821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.94498 - lat) + Math.Abs(-69.79331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.06667 - lat) + Math.Abs(-70.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.05934 - lat) + Math.Abs(-69.38843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27351 - lat) + Math.Abs(-70.52352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.31583 - lat) + Math.Abs(-70.56643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.64385 - lat) + Math.Abs(-70.07635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.24513 - lat) + Math.Abs(-71.53077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66667 - lat) + Math.Abs(-70.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.11938 - lat) + Math.Abs(-70.40632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.31532 - lat) + Math.Abs(-71.69239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54224 - lat) + Math.Abs(-69.17979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.55542 - lat) + Math.Abs(-69.40814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.58182 - lat) + Math.Abs(-68.40431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4 - lat) + Math.Abs(-70.76765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54374 - lat) + Math.Abs(-71.63561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07873 - lat) + Math.Abs(-71.28723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29935 - lat) + Math.Abs(-70.22648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.18416 - lat) + Math.Abs(-70.10884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.84431 - lat) + Math.Abs(-70.31688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26766 - lat) + Math.Abs(-71.16612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.58164 - lat) + Math.Abs(-70.77029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.69841 - lat) + Math.Abs(-71.74513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.10515 - lat) + Math.Abs(-71.69498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.86375 - lat) + Math.Abs(-69.10868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.59202 - lat) + Math.Abs(-70.65256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.84856 - lat) + Math.Abs(-71.41041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03838 - lat) + Math.Abs(-71.74403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26196 - lat) + Math.Abs(-70.2956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.48403 - lat) + Math.Abs(-71.5473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99172 - lat) + Math.Abs(-71.16526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29656 - lat) + Math.Abs(-70.58635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.53957 - lat) + Math.Abs(-70.73826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.73172 - lat) + Math.Abs(-70.93917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.80136 - lat) + Math.Abs(-71.401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.65017 - lat) + Math.Abs(-68.66281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24697 - lat) + Math.Abs(-70.21053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48137 - lat) + Math.Abs(-71.41965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.3832 - lat) + Math.Abs(-69.8474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.807 - lat) + Math.Abs(-69.78399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.7346 - lat) + Math.Abs(-70.59915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.41083 - lat) + Math.Abs(-71.15257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.39352 - lat) + Math.Abs(-70.52598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.98364 - lat) + Math.Abs(-69.0476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35871 - lat) + Math.Abs(-71.41716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.89036 - lat) + Math.Abs(-71.59459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24297 - lat) + Math.Abs(-70.41768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.55186 - lat) + Math.Abs(-71.07813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.04134 - lat) + Math.Abs(-69.83616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63655 - lat) + Math.Abs(-71.02734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.89131 - lat) + Math.Abs(-70.96204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.52131 - lat) + Math.Abs(-71.59106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.62035 - lat) + Math.Abs(-69.49581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.73333 - lat) + Math.Abs(-71.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.73226 - lat) + Math.Abs(-69.99536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.43333 - lat) + Math.Abs(-71.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.43333 - lat) + Math.Abs(-70.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36186 - lat) + Math.Abs(-71.21046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.31102 - lat) + Math.Abs(-69.5428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27485 - lat) + Math.Abs(-71.31596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.67119 - lat) + Math.Abs(-71.50471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.87309 - lat) + Math.Abs(-71.51656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.1931 - lat) + Math.Abs(-70.20835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45026 - lat) + Math.Abs(-70.61724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.42733 - lat) + Math.Abs(-68.97285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.27676 - lat) + Math.Abs(-70.17173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46667 - lat) + Math.Abs(-69.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.65043 - lat) + Math.Abs(-71.08429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.55367 - lat) + Math.Abs(-69.90762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.57053 - lat) + Math.Abs(-71.72967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.06858 - lat) + Math.Abs(-71.10651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.69981 - lat) + Math.Abs(-71.12084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.47341 - lat) + Math.Abs(-70.81629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5 - lat) + Math.Abs(-69.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.2199 - lat) + Math.Abs(-70.81905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.70342 - lat) + Math.Abs(-71.58971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.43333 - lat) + Math.Abs(-70.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.87402 - lat) + Math.Abs(-71.2383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.85782 - lat) + Math.Abs(-71.29311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.76365 - lat) + Math.Abs(-70.33732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.46954 - lat) + Math.Abs(-70.45253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.56667 - lat) + Math.Abs(-70.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.49169 - lat) + Math.Abs(-71.85022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.13292 - lat) + Math.Abs(-70.37607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.64955 - lat) + Math.Abs(-70.94927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.11683 - lat) + Math.Abs(-70.63595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.31173 - lat) + Math.Abs(-71.16145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63552 - lat) + Math.Abs(-70.44664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.61169 - lat) + Math.Abs(-71.14847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.75371 - lat) + Math.Abs(-70.82906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.18043 - lat) + Math.Abs(-70.02046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.71599 - lat) + Math.Abs(-71.69511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.76278 - lat) + Math.Abs(-69.25681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66256 - lat) + Math.Abs(-71.19406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.55892 - lat) + Math.Abs(-69.70103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.58793 - lat) + Math.Abs(-68.97867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.65 - lat) + Math.Abs(-69.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5981 - lat) + Math.Abs(-71.64184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.50705 - lat) + Math.Abs(-70.91713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.72693 - lat) + Math.Abs(-70.92294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.95147 - lat) + Math.Abs(-69.75114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.62748 - lat) + Math.Abs(-70.27772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.50228 - lat) + Math.Abs(-71.34271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.28668 - lat) + Math.Abs(-71.18147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.12148 - lat) + Math.Abs(-70.29972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.82712 - lat) + Math.Abs(-71.17411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4577 - lat) + Math.Abs(-70.6435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.58469 - lat) + Math.Abs(-70.98489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.81509 - lat) + Math.Abs(-70.03557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5 - lat) + Math.Abs(-69.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.9 - lat) + Math.Abs(-71.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.97567 - lat) + Math.Abs(-69.37827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.36966 - lat) + Math.Abs(-71.06964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.78333 - lat) + Math.Abs(-69.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.43537 - lat) + Math.Abs(-71.4754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29643 - lat) + Math.Abs(-71.1841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41139 - lat) + Math.Abs(-71.24558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.81667 - lat) + Math.Abs(-71.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.7496 - lat) + Math.Abs(-70.8369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.31834 - lat) + Math.Abs(-69.88827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44905 - lat) + Math.Abs(-70.02785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.52719 - lat) + Math.Abs(-70.29585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37839 - lat) + Math.Abs(-71.52469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.82774 - lat) + Math.Abs(-69.94629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.54878 - lat) + Math.Abs(-71.70829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5 - lat) + Math.Abs(-69.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29405 - lat) + Math.Abs(-71.29298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.05272 - lat) + Math.Abs(-70.14939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.90919 - lat) + Math.Abs(-70.74499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.22207 - lat) + Math.Abs(-70.52956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.8775 - lat) + Math.Abs(-71.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.46707 - lat) + Math.Abs(-69.89339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.00449 - lat) + Math.Abs(-69.97896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.72681 - lat) + Math.Abs(-71.51742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.2545 - lat) + Math.Abs(-70.368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.34413 - lat) + Math.Abs(-70.48342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.20824 - lat) + Math.Abs(-70.02726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.71387 - lat) + Math.Abs(-71.49876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.35499 - lat) + Math.Abs(-71.15851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.60703 - lat) + Math.Abs(-71.25734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45458 - lat) + Math.Abs(-70.19907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24833 - lat) + Math.Abs(-71.18912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.6426 - lat) + Math.Abs(-69.90489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25 - lat) + Math.Abs(-71.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.74982 - lat) + Math.Abs(-70.40829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.93687 - lat) + Math.Abs(-70.40923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.77515 - lat) + Math.Abs(-70.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.37825 - lat) + Math.Abs(-68.609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45 - lat) + Math.Abs(-69.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41667 - lat) + Math.Abs(-70.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45539 - lat) + Math.Abs(-69.9454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.75031 - lat) + Math.Abs(-69.63525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.08239 - lat) + Math.Abs(-71.7054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27964 - lat) + Math.Abs(-70.33185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41538 - lat) + Math.Abs(-70.03317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.32512 - lat) + Math.Abs(-70.70357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45319 - lat) + Math.Abs(-70.7349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.5 - lat) + Math.Abs(-69.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.18732 - lat) + Math.Abs(-69.85917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.54813 - lat) + Math.Abs(-70.99599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.6773 - lat) + Math.Abs(-70.84428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.15072 - lat) + Math.Abs(-69.80069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5 - lat) + Math.Abs(-70 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48847 - lat) + Math.Abs(-69.85707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.01667 - lat) + Math.Abs(-70.26661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yayas de Viajama", "01", 18.6071, -70.92753);
case 1: return new CityInfo("Yamasá", "32", 18.77315, -70.02583);
case 2: return new CityInfo("Yaguate", "33", 18.3353, -70.18113);
case 3: return new CityInfo("Villa Vásquez", "15", 19.7411, -71.4464);
case 4: return new CityInfo("Villa Tapia", "19", 19.30084, -70.42199);
case 5: return new CityInfo("Villarpando", "01", 18.6586, -71.03916);
case 6: return new CityInfo("Villa Riva", "06", 19.18069, -69.91319);
case 7: return new CityInfo("Villa Jaragua", "02", 18.49077, -71.48377);
case 8: return new CityInfo("Villa Isabela", "18", 19.81564, -71.06056);
case 9: return new CityInfo("Villa González", "25", 19.54057, -70.78853);
case 10: return new CityInfo("Villa Francisca", "34", 18.48278, -69.88914);
case 11: return new CityInfo("Villa Elisa", "15", 19.6856, -71.27007);
case 12: return new CityInfo("Villa Consuelo", "34", 18.48333, -69.9);
case 13: return new CityInfo("Villa Bisonó", "25", 19.56378, -70.87582);
case 14: return new CityInfo("Villa Altagracia", "33", 18.67297, -70.17095);
case 15: return new CityInfo("Vicente Noble", "03", 18.38443, -71.18009);
case 16: return new CityInfo("Veragua Arriba", "08", 19.58333, -70.33333);
case 17: return new CityInfo("Vallejuelo", "23", 18.65354, -71.33431);
case 18: return new CityInfo("Tireo Arriba", "30", 18.93537, -70.6885);
case 19: return new CityInfo("Tenares", "19", 19.37439, -70.35087);
case 20: return new CityInfo("Tamboril", "25", 19.48538, -70.61104);
case 21: return new CityInfo("Tamayo", "02", 18.3947, -71.2029);
case 22: return new CityInfo("Tábara Arriba", "01", 18.56999, -70.87978);
case 23: return new CityInfo("Sosúa", "18", 19.7522, -70.51995);
case 24: return new CityInfo("San Víctor Arriba", "08", 19.47741, -70.53585);
case 25: return new CityInfo("Santo Domingo", "34", 18.47186, -69.89232);
case 26: return new CityInfo("Santiago de los Caballeros", "25", 19.4517, -70.69703);
case 27: return new CityInfo("Santa Cruz de El Seibo", "28", 18.76559, -69.03886);
case 28: return new CityInfo("Santa Cruz de Barahona", "03", 18.20854, -71.10077);
case 29: return new CityInfo("Samaná", "20", 19.20561, -69.33685);
case 30: return new CityInfo("San Rafael del Yuma", "10", 18.42993, -68.6739);
case 31: return new CityInfo("San Pedro de Macorís", "24", 18.4539, -69.30864);
case 32: return new CityInfo("San Juan de la Maguana", "23", 18.80588, -71.22991);
case 33: return new CityInfo("San José de Ocoa", "36", 18.54661, -70.50631);
case 34: return new CityInfo("San José de Las Matas", "25", 19.33915, -70.93819);
case 35: return new CityInfo("San Gregorio de Nigua", "33", 18.38333, -70.08333);
case 36: return new CityInfo("San Francisco de Macorís", "06", 19.30099, -70.25259);
case 37: return new CityInfo("San Fernando de Monte Cristi", "15", 19.84826, -71.64597);
case 38: return new CityInfo("Puerto Plata", "18", 19.79344, -70.6884);
case 39: return new CityInfo("Sánchez", "20", 19.2281, -69.6137);
case 40: return new CityInfo("San Carlos", "34", 18.48333, -69.9);
case 41: return new CityInfo("Salvaleón de Higüey", "10", 18.61501, -68.70798);
case 42: return new CityInfo("Salsipuedes", "19", 19.40552, -70.37985);
case 43: return new CityInfo("Salcedo", "19", 19.37762, -70.41762);
case 44: return new CityInfo("Sabaneta", "26", 19.47793, -71.34125);
case 45: return new CityInfo("Sabana Yegua", "01", 18.71667, -71.01667);
case 46: return new CityInfo("Sabana Iglesia", "25", 19.32114, -70.75992);
case 47: return new CityInfo("Sabana Grande de Palenque", "33", 18.26256, -70.14821);
case 48: return new CityInfo("Sabana Grande de Boyá", "32", 18.94498, -69.79331);
case 49: return new CityInfo("Sabana del Puerto", "31", 19.06667, -70.41667);
case 50: return new CityInfo("Sabana de la Mar", "29", 19.05934, -69.38843);
case 51: return new CityInfo("Sabana Buey", "35", 18.27351, -70.52352);
case 52: return new CityInfo("Río Verde Arriba", "30", 19.31583, -70.56643);
case 53: return new CityInfo("Río San Juan", "14", 19.64385, -70.07635);
case 54: return new CityInfo("Río Limpio", "11", 19.24513, -71.53077);
case 55: return new CityInfo("Río Grande", "18", 19.66667, -70.76667);
case 56: return new CityInfo("Rincón", "30", 19.11938, -70.40632);
case 57: return new CityInfo("Restauración", "04", 19.31532, -71.69239);
case 58: return new CityInfo("Ramón Santana", "24", 18.54224, -69.17979);
case 59: return new CityInfo("Quisqueya", "24", 18.55542, -69.40814);
case 60: return new CityInfo("Punta Cana", "10", 18.58182, -68.40431);
case 61: return new CityInfo("Pueblo Viejo", "01", 18.4, -70.76765);
case 62: return new CityInfo("Postrer Río", "09", 18.54374, -71.63561);
case 63: return new CityInfo("Polo", "03", 18.07873, -71.28723);
case 64: return new CityInfo("Pizarrete", "35", 18.29935, -70.22648);
case 65: return new CityInfo("Pimentel", "06", 19.18416, -70.10884);
case 66: return new CityInfo("Piedra Blanca", "31", 18.84431, -70.31688);
case 67: return new CityInfo("Pescadería", "03", 18.26766, -71.16612);
case 68: return new CityInfo("Peralta", "01", 18.58164, -70.77029);
case 69: return new CityInfo("Pepillo Salcedo", "15", 19.69841, -71.74513);
case 70: return new CityInfo("Pedro Santana", "11", 19.10515, -71.69498);
case 71: return new CityInfo("Pedro Sánchez", "28", 18.86375, -69.10868);
case 72: return new CityInfo("Pedro García", "25", 19.59202, -70.65256);
case 73: return new CityInfo("Pedro Corto", "23", 18.84856, -71.41041);
case 74: return new CityInfo("Pedernales", "16", 18.03838, -71.74403);
case 75: return new CityInfo("Paya", "35", 18.26196, -70.2956);
case 76: return new CityInfo("Partido", "04", 19.48403, -71.5473);
case 77: return new CityInfo("Paraíso", "03", 17.99172, -71.16526);
case 78: return new CityInfo("Palmar de Ocoa", "01", 18.29656, -70.58635);
case 79: return new CityInfo("Palmar Arriba", "25", 19.53957, -70.73826);
case 80: return new CityInfo("Padre Las Casas", "01", 18.73172, -70.93917);
case 81: return new CityInfo("Oviedo", "16", 17.80136, -71.401);
case 82: return new CityInfo("Otra Banda", "10", 18.65017, -68.66281);
case 83: return new CityInfo("Nizao", "35", 18.24697, -70.21053);
case 84: return new CityInfo("Neiba", "02", 18.48137, -71.41965);
case 85: return new CityInfo("Nagua", "14", 19.3832, -69.8474);
case 86: return new CityInfo("Monte Plata", "32", 18.807, -69.78399);
case 87: return new CityInfo("Monte Llano", "18", 19.7346, -70.59915);
case 88: return new CityInfo("Monción", "26", 19.41083, -71.15257);
case 89: return new CityInfo("Moca", "08", 19.39352, -70.52598);
case 90: return new CityInfo("Miches", "28", 18.98364, -69.0476);
case 91: return new CityInfo("Mella", "09", 18.35871, -71.41716);
case 92: return new CityInfo("Matayaya", "23", 18.89036, -71.59459);
case 93: return new CityInfo("Matanzas", "35", 18.24297, -70.41768);
case 94: return new CityInfo("Mao", "27", 19.55186, -71.07813);
case 95: return new CityInfo("Majagual", "32", 19.04134, -69.83616);
case 96: return new CityInfo("Maizal", "27", 19.63655, -71.02734);
case 97: return new CityInfo("Luperón", "18", 19.89131, -70.96204);
case 98: return new CityInfo("Los Ríos", "02", 18.52131, -71.59106);
case 99: return new CityInfo("Los Llanos", "24", 18.62035, -69.49581);
case 100: return new CityInfo("Los Hidalgos", "18", 19.73333, -71.03333);
case 101: return new CityInfo("Los Botados", "32", 18.73226, -69.99536);
case 102: return new CityInfo("Loma de Cabrera", "04", 19.43333, -71.6);
case 103: return new CityInfo("Licey al Medio", "25", 19.43333, -70.6);
case 104: return new CityInfo("La Uvilla", "02", 18.36186, -71.21046);
case 105: return new CityInfo("Las Terrenas", "20", 19.31102, -69.5428);
case 106: return new CityInfo("Las Salinas", "03", 18.27485, -71.31596);
case 107: return new CityInfo("Las Matas de Santa Cruz", "15", 19.67119, -71.50471);
case 108: return new CityInfo("Las Matas de Farfán", "23", 18.87309, -71.51656);
case 109: return new CityInfo("Las Guáranas", "06", 19.1931, -70.20835);
case 110: return new CityInfo("Las Charcas", "01", 18.45026, -70.61724);
case 111: return new CityInfo("La Romana", "12", 18.42733, -68.97285);
case 112: return new CityInfo("La Peña", "06", 19.27676, -70.17173);
case 113: return new CityInfo("La Julia", "34", 18.46667, -69.93333);
case 114: return new CityInfo("Laguna Salada", "27", 19.65043, -71.08429);
case 115: return new CityInfo("La Entrada", "14", 19.55367, -69.90762);
case 116: return new CityInfo("La Descubierta", "09", 18.57053, -71.72967);
case 117: return new CityInfo("La Ciénaga", "03", 18.06858, -71.10651);
case 118: return new CityInfo("La Caya", "27", 19.69981, -71.12084);
case 119: return new CityInfo("La Canela", "25", 19.47341, -70.81629);
case 120: return new CityInfo("La Agustina", "34", 18.5, -69.93333);
case 121: return new CityInfo("Juncalito Abajo", "25", 19.2199, -70.81905);
case 122: return new CityInfo("Juan Santiago", "11", 18.70342, -71.58971);
case 123: return new CityInfo("Juan López Abajo", "08", 19.43333, -70.5);
case 124: return new CityInfo("Juan de Herrera", "23", 18.87402, -71.2383);
case 125: return new CityInfo("Juancho", "16", 17.85782, -71.29311);
case 126: return new CityInfo("Juan Adrián", "31", 18.76365, -70.33732);
case 127: return new CityInfo("José Contreras", "08", 19.46954, -70.45253);
case 128: return new CityInfo("Joba Arriba", "08", 19.56667, -70.26667);
case 129: return new CityInfo("Jimaní", "09", 18.49169, -71.85022);
case 130: return new CityInfo("Jima Abajo", "30", 19.13292, -70.37607);
case 131: return new CityInfo("Jicomé", "27", 19.64955, -70.94927);
case 132: return new CityInfo("Jarabacoa", "30", 19.11683, -70.63595);
case 133: return new CityInfo("Jaquimeyes", "03", 18.31173, -71.16145);
case 134: return new CityInfo("Jamao al Norte", "08", 19.63552, -70.44664);
case 135: return new CityInfo("Jaibón", "27", 19.61169, -71.14847);
case 136: return new CityInfo("Imbert", "18", 19.75371, -70.82906);
case 137: return new CityInfo("Hostos", "06", 19.18043, -70.02046);
case 138: return new CityInfo("Hondo Valle", "11", 18.71599, -71.69511);
case 139: return new CityInfo("Hato Mayor del Rey", "29", 18.76278, -69.25681);
case 140: return new CityInfo("Hatillo Palma", "15", 19.66256, -71.19406);
case 141: return new CityInfo("Guerra", "37", 18.55892, -69.70103);
case 142: return new CityInfo("Guaymate", "12", 18.58793, -68.97867);
case 143: return new CityInfo("Guayabo Dulce", "29", 18.65, -69.28333);
case 144: return new CityInfo("Guayabal", "09", 18.5981, -71.64184);
case 145: return new CityInfo("Guatapanal", "27", 19.50705, -70.91713);
case 146: return new CityInfo("Guananico", "18", 19.72693, -70.92294);
case 147: return new CityInfo("Gonzalo", "32", 18.95147, -69.75114);
case 148: return new CityInfo("Gaspar Hernández", "08", 19.62748, -70.27772);
case 149: return new CityInfo("Galván", "02", 18.50228, -71.34271);
case 150: return new CityInfo("Fundación", "03", 18.28668, -71.18147);
case 151: return new CityInfo("Fantino", "21", 19.12148, -70.29972);
case 152: return new CityInfo("Estero Hondo", "18", 19.82712, -71.17411);
case 153: return new CityInfo("Estebanía", "01", 18.4577, -70.6435);
case 154: return new CityInfo("Esperanza", "27", 19.58469, -70.98489);
case 155: return new CityInfo("Esperalvillo", "32", 18.81509, -70.03557);
case 156: return new CityInfo("Ensanche Luperón", "34", 18.5, -69.9);
case 157: return new CityInfo("Enriquillo", "03", 17.9, -71.23333);
case 158: return new CityInfo("El Valle", "29", 18.97567, -69.37827);
case 159: return new CityInfo("El Rubio", "25", 19.36966, -71.06964);
case 160: return new CityInfo("El Puerto", "24", 18.78333, -69.46667);
case 161: return new CityInfo("El Pino", "04", 19.43537, -71.4754);
case 162: return new CityInfo("El Peñón", "03", 18.29643, -71.1841);
case 163: return new CityInfo("El Palmar", "02", 18.41139, -71.24558);
case 164: return new CityInfo("El Llano", "11", 18.81667, -71.63333);
case 165: return new CityInfo("El Guayabal", "01", 18.7496, -70.8369);
case 166: return new CityInfo("El Factor", "14", 19.31834, -69.88827);
case 167: return new CityInfo("El Carril", "33", 18.44905, -70.02785);
case 168: return new CityInfo("El Cacao", "33", 18.52719, -70.29585);
case 169: return new CityInfo("Duvergé", "09", 18.37839, -71.52469);
case 170: return new CityInfo("Don Juan", "32", 18.82774, -69.94629);
case 171: return new CityInfo("Dajabón", "04", 19.54878, -71.70829);
case 172: return new CityInfo("Cristo Rey", "34", 18.5, -69.93333);
case 173: return new CityInfo("Cristóbal", "09", 18.29405, -71.29298);
case 174: return new CityInfo("Cotuí", "21", 19.05272, -70.14939);
case 175: return new CityInfo("Constanza", "30", 18.90919, -70.74499);
case 176: return new CityInfo("Concepción de La Vega", "30", 19.22207, -70.52956);
case 177: return new CityInfo("Comendador", "11", 18.8775, -71.70278);
case 178: return new CityInfo("Ciudad Nueva", "34", 18.46707, -69.89339);
case 179: return new CityInfo("Cevicos", "21", 19.00449, -69.97896);
case 180: return new CityInfo("Cercado Abajo", "23", 18.72681, -71.51742);
case 181: return new CityInfo("Cenoví", "06", 19.2545, -70.368);
case 182: return new CityInfo("Cayetano Germosén", "08", 19.34413, -70.48342);
case 183: return new CityInfo("Castillo", "06", 19.20824, -70.02726);
case 184: return new CityInfo("Castañuelas", "15", 19.71387, -71.49876);
case 185: return new CityInfo("Canoa", "03", 18.35499, -71.15851);
case 186: return new CityInfo("Cana Chapetón", "15", 19.60703, -71.25734);
case 187: return new CityInfo("Cambita Garabitos", "33", 18.45458, -70.19907);
case 188: return new CityInfo("Cachón", "03", 18.24833, -71.18912);
case 189: return new CityInfo("Cabrera", "14", 19.6426, -69.90489);
case 190: return new CityInfo("Cabral", "03", 18.25, -71.21667);
case 191: return new CityInfo("Cabarete", "18", 19.74982, -70.40829);
case 192: return new CityInfo("Bonao", "31", 18.93687, -70.40923);
case 193: return new CityInfo("Bohechío", "23", 18.77515, -70.98889);
case 194: return new CityInfo("Boca de Yuma", "10", 18.37825, -68.609);
case 195: return new CityInfo("Boca Chica", "37", 18.45, -69.6);
case 196: return new CityInfo("San Cristóbal", "33", 18.41667, -70.1);
case 197: return new CityInfo("Bella Vista", "34", 18.45539, -69.9454);
case 198: return new CityInfo("Bayaguana", "32", 18.75031, -69.63525);
case 199: return new CityInfo("Bánica", "11", 19.08239, -71.7054);
case 200: return new CityInfo("Baní", "35", 18.27964, -70.33185);
case 201: return new CityInfo("Bajos de Haina", "33", 18.41538, -70.03317);
case 202: return new CityInfo("Baitoa", "25", 19.32512, -70.70357);
case 203: return new CityInfo("Azua", "01", 18.45319, -70.7349);
case 204: return new CityInfo("Arroyo Salado", "14", 19.5, -69.9);
case 205: return new CityInfo("Arenoso", "06", 19.18732, -69.85917);
case 206: return new CityInfo("Amina", "27", 19.54813, -70.99599);
case 207: return new CityInfo("Altamira", "18", 19.6773, -70.84428);
case 208: return new CityInfo("Agua Santa del Yuna", "06", 19.15072, -69.80069);
case 209: return new CityInfo("Santo Domingo Oeste", "37", 18.5, -70);
case 210: return new CityInfo("Santo Domingo Este", "37", 18.48847, -69.85707);
default: return new CityInfo("Villa La Mata", "21", 19.01667, -70.26661);

                                    }                                        
                                }
                            
                        }
                    }
                