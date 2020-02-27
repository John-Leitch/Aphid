
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
                                    public const string Country = "SK";
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
                            
                                        var cur = (Math.Abs(48.9796 - lat) + Math.Abs(20.7917 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(49.271 - lat) + Math.Abs(20.26239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13637 - lat) + Math.Abs(20.24386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30387 - lat) + Math.Abs(20.56558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08764 - lat) + Math.Abs(20.4253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88836 - lat) + Math.Abs(21.68479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80965 - lat) + Math.Abs(21.96757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.62858 - lat) + Math.Abs(21.71954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16616 - lat) + Math.Abs(20.28128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06014 - lat) + Math.Abs(20.20695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30819 - lat) + Math.Abs(21.5703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20211 - lat) + Math.Abs(21.65216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05913 - lat) + Math.Abs(20.07975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8735 - lat) + Math.Abs(21.83668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13905 - lat) + Math.Abs(20.22034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.29859 - lat) + Math.Abs(20.6862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.00088 - lat) + Math.Abs(20.75307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94464 - lat) + Math.Abs(20.56153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18725 - lat) + Math.Abs(20.45948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.74455 - lat) + Math.Abs(22.18136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.98857 - lat) + Math.Abs(22.15099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70074 - lat) + Math.Abs(21.66104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10309 - lat) + Math.Abs(21.0988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66009 - lat) + Math.Abs(20.53758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38284 - lat) + Math.Abs(20.02239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68346 - lat) + Math.Abs(20.11734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.99839 - lat) + Math.Abs(21.23393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06144 - lat) + Math.Abs(20.29798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.25869 - lat) + Math.Abs(20.536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12253 - lat) + Math.Abs(20.26737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61428 - lat) + Math.Abs(20.99957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75434 - lat) + Math.Abs(21.9195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.27195 - lat) + Math.Abs(21.90073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70041 - lat) + Math.Abs(20.89367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11667 - lat) + Math.Abs(20.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15376 - lat) + Math.Abs(20.96382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.02173 - lat) + Math.Abs(20.59212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91447 - lat) + Math.Abs(20.87514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71395 - lat) + Math.Abs(21.25808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13571 - lat) + Math.Abs(20.43352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77592 - lat) + Math.Abs(21.20587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93707 - lat) + Math.Abs(21.91625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11398 - lat) + Math.Abs(21.51731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85584 - lat) + Math.Abs(20.93713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82073 - lat) + Math.Abs(20.36988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41704 - lat) + Math.Abs(22.08865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88628 - lat) + Math.Abs(21.9393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.02378 - lat) + Math.Abs(20.7994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70275 - lat) + Math.Abs(20.50805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.29175 - lat) + Math.Abs(21.27271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57442 - lat) + Math.Abs(19.15324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38553 - lat) + Math.Abs(18.40063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22315 - lat) + Math.Abs(18.73941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.59184 - lat) + Math.Abs(18.84958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05075 - lat) + Math.Abs(18.65421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48123 - lat) + Math.Abs(18.71565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11328 - lat) + Math.Abs(18.91714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61973 - lat) + Math.Abs(17.7226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24371 - lat) + Math.Abs(18.30846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46054 - lat) + Math.Abs(18.6992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85798 - lat) + Math.Abs(17.76884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21059 - lat) + Math.Abs(19.35043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.69138 - lat) + Math.Abs(18.59944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.337 - lat) + Math.Abs(19.556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.40429 - lat) + Math.Abs(18.62258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86225 - lat) + Math.Abs(18.86048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36101 - lat) + Math.Abs(19.61249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37741 - lat) + Math.Abs(17.58723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.89452 - lat) + Math.Abs(18.04436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91063 - lat) + Math.Abs(18.16691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56361 - lat) + Math.Abs(18.16712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28926 - lat) + Math.Abs(18.53152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67738 - lat) + Math.Abs(19.94364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.25895 - lat) + Math.Abs(19.02935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91054 - lat) + Math.Abs(18.49967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05 - lat) + Math.Abs(19.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25216 - lat) + Math.Abs(17.21539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41923 - lat) + Math.Abs(18.9401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08613 - lat) + Math.Abs(18.18447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79495 - lat) + Math.Abs(18.7175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27474 - lat) + Math.Abs(17.03173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22578 - lat) + Math.Abs(18.90782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77721 - lat) + Math.Abs(17.69433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50478 - lat) + Math.Abs(17.43067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20137 - lat) + Math.Abs(17.63852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8449 - lat) + Math.Abs(17.22635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67922 - lat) + Math.Abs(17.36697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21951 - lat) + Math.Abs(17.40043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03015 - lat) + Math.Abs(17.30972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15127 - lat) + Math.Abs(17.88062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07408 - lat) + Math.Abs(18.94946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0748 - lat) + Math.Abs(19.30751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08899 - lat) + Math.Abs(18.64007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12494 - lat) + Math.Abs(18.32597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77446 - lat) + Math.Abs(18.6275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0995 - lat) + Math.Abs(19.79427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12153 - lat) + Math.Abs(18.42169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43094 - lat) + Math.Abs(19.79408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.59479 - lat) + Math.Abs(17.82591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28986 - lat) + Math.Abs(17.26664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.62861 - lat) + Math.Abs(18.38455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19416 - lat) + Math.Abs(19.19761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.25939 - lat) + Math.Abs(19.3569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98544 - lat) + Math.Abs(18.16195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75763 - lat) + Math.Abs(17.8309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71106 - lat) + Math.Abs(18.53389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93479 - lat) + Math.Abs(18.14632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.42305 - lat) + Math.Abs(18.64037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.31046 - lat) + Math.Abs(19.52428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.30763 - lat) + Math.Abs(18.08453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96702 - lat) + Math.Abs(18.11892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.4079 - lat) + Math.Abs(19.48032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85171 - lat) + Math.Abs(19.63247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75876 - lat) + Math.Abs(17.56866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33397 - lat) + Math.Abs(17.30711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06651 - lat) + Math.Abs(18.92399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24903 - lat) + Math.Abs(17.064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43604 - lat) + Math.Abs(17.02188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12944 - lat) + Math.Abs(19.40228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33249 - lat) + Math.Abs(19.66708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12038 - lat) + Math.Abs(19.54709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08061 - lat) + Math.Abs(19.62218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03962 - lat) + Math.Abs(19.72335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14309 - lat) + Math.Abs(19.51421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21563 - lat) + Math.Abs(18.60705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44575 - lat) + Math.Abs(17.76458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.3 - lat) + Math.Abs(18.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.37523 - lat) + Math.Abs(19.33876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3554 - lat) + Math.Abs(19.06474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70519 - lat) + Math.Abs(18.91834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21491 - lat) + Math.Abs(18.88718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.60148 - lat) + Math.Abs(19.10252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(18.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76356 - lat) + Math.Abs(18.12263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92294 - lat) + Math.Abs(17.98467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18675 - lat) + Math.Abs(17.2554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.99769 - lat) + Math.Abs(18.2353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04439 - lat) + Math.Abs(19.82895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86984 - lat) + Math.Abs(18.19233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65567 - lat) + Math.Abs(19.31284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57787 - lat) + Math.Abs(19.52574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81105 - lat) + Math.Abs(17.16238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43174 - lat) + Math.Abs(17.8031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7276 - lat) + Math.Abs(18.76012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.718 - lat) + Math.Abs(17.11628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19001 - lat) + Math.Abs(17.72747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.89211 - lat) + Math.Abs(17.57884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26757 - lat) + Math.Abs(19.82473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20563 - lat) + Math.Abs(17.20759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.99268 - lat) + Math.Abs(17.61211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17135 - lat) + Math.Abs(18.88782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.95981 - lat) + Math.Abs(18.16634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20983 - lat) + Math.Abs(19.30341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56082 - lat) + Math.Abs(19.41954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.74722 - lat) + Math.Abs(19.65125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43503 - lat) + Math.Abs(18.78895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71226 - lat) + Math.Abs(17.78704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22404 - lat) + Math.Abs(18.55878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66349 - lat) + Math.Abs(17.53905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80431 - lat) + Math.Abs(19.63631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14816 - lat) + Math.Abs(17.10674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.78511 - lat) + Math.Abs(18.5864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10021 - lat) + Math.Abs(19.43472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44858 - lat) + Math.Abs(18.91003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73946 - lat) + Math.Abs(19.15349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7213 - lat) + Math.Abs(18.25754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20711 - lat) + Math.Abs(16.9786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36672 - lat) + Math.Abs(19.18093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85141 - lat) + Math.Abs(18.052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08347 - lat) + Math.Abs(17.26072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31142 - lat) + Math.Abs(17.29042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Žehra", "03", 48.9796, 20.7917);
case 1: return new CityInfo("Ždiar", "05", 49.271, 20.26239);
case 2: return new CityInfo("Vysoké Tatry", "05", 49.13637, 20.24386);
case 3: return new CityInfo("Vyšné Ružbachy", "05", 49.30387, 20.56558);
case 4: return new CityInfo("Vrbov", "05", 49.08764, 20.4253);
case 5: return new CityInfo("Vranov nad Topľou", "05", 48.88836, 21.68479);
case 6: return new CityInfo("Vinné", "03", 48.80965, 21.96757);
case 7: return new CityInfo("Trebišov", "03", 48.62858, 21.71954);
case 8: return new CityInfo("Tatranská Lomnica", "05", 49.16616, 20.28128);
case 9: return new CityInfo("Svit", "05", 49.06014, 20.20695);
case 10: return new CityInfo("Svidník", "05", 49.30819, 21.5703);
case 11: return new CityInfo("Stropkov", "05", 49.20211, 21.65216);
case 12: return new CityInfo("Štrba", "05", 49.05913, 20.07975);
case 13: return new CityInfo("Strážske", "03", 48.8735, 21.83668);
case 14: return new CityInfo("Starý Smokovec", "05", 49.13905, 20.22034);
case 15: return new CityInfo("Stará Ľubovňa", "05", 49.29859, 20.6862);
case 16: return new CityInfo("Spišské Podhradie", "05", 49.00088, 20.75307);
case 17: return new CityInfo("Spišská Nová Ves", "03", 48.94464, 20.56153);
case 18: return new CityInfo("Spišská Belá", "05", 49.18725, 20.45948);
case 19: return new CityInfo("Sobrance", "03", 48.74455, 22.18136);
case 20: return new CityInfo("Snina", "05", 48.98857, 22.15099);
case 21: return new CityInfo("Sečovce", "03", 48.70074, 21.66104);
case 22: return new CityInfo("Sabinov", "05", 49.10309, 21.0988);
case 23: return new CityInfo("Rožňava", "03", 48.66009, 20.53758);
case 24: return new CityInfo("Rimavská Sobota", "01", 48.38284, 20.02239);
case 25: return new CityInfo("Revúca", "01", 48.68346, 20.11734);
case 26: return new CityInfo("Prešov", "05", 48.99839, 21.23393);
case 27: return new CityInfo("Poprad", "05", 49.06144, 20.29798);
case 28: return new CityInfo("Podolínec", "05", 49.25869, 20.536);
case 29: return new CityInfo("Nová Lesná", "05", 49.12253, 20.26737);
case 30: return new CityInfo("Moldava nad Bodvou", "03", 48.61428, 20.99957);
case 31: return new CityInfo("Michalovce", "03", 48.75434, 21.9195);
case 32: return new CityInfo("Medzilaborce", "05", 49.27195, 21.90073);
case 33: return new CityInfo("Medzev", "03", 48.70041, 20.89367);
case 34: return new CityInfo("Ľubica", "05", 49.11667, 20.45);
case 35: return new CityInfo("Lipany", "05", 49.15376, 20.96382);
case 36: return new CityInfo("Levoča", "05", 49.02173, 20.59212);
case 37: return new CityInfo("Krompachy", "03", 48.91447, 20.87514);
case 38: return new CityInfo("Košice", "03", 48.71395, 21.25808);
case 39: return new CityInfo("Kežmarok", "05", 49.13571, 20.43352);
case 40: return new CityInfo("Kavečany", "03", 48.77592, 21.20587);
case 41: return new CityInfo("Humenné", "05", 48.93707, 21.91625);
case 42: return new CityInfo("Giraltovce", "05", 49.11398, 21.51731);
case 43: return new CityInfo("Gelnica", "03", 48.85584, 20.93713);
case 44: return new CityInfo("Dobšiná", "03", 48.82073, 20.36988);
case 45: return new CityInfo("Čierna nad Tisou", "03", 48.41704, 22.08865);
case 46: return new CityInfo("Chlmec", "05", 48.88628, 21.9393);
case 47: return new CityInfo("Bijacovce", "05", 49.02378, 20.7994);
case 48: return new CityInfo("Betliar", "03", 48.70275, 20.50805);
case 49: return new CityInfo("Bardejov", "05", 49.29175, 21.27271);
case 50: return new CityInfo("Zvolen", "01", 48.57442, 19.15324);
case 51: return new CityInfo("Zlaté Moravce", "04", 48.38553, 18.40063);
case 52: return new CityInfo("Žilina", "08", 49.22315, 18.73941);
case 53: return new CityInfo("Žiar nad Hronom", "01", 48.59184, 18.84958);
case 54: return new CityInfo("Želiezovce", "04", 48.05075, 18.65421);
case 55: return new CityInfo("Žarnovica", "01", 48.48123, 18.71565);
case 56: return new CityInfo("Vrútky", "08", 49.11328, 18.91714);
case 57: return new CityInfo("Vrbové", "07", 48.61973, 17.7226);
case 58: return new CityInfo("Vráble", "04", 48.24371, 18.30846);
case 59: return new CityInfo("Voznica", "01", 48.46054, 18.6992);
case 60: return new CityInfo("Veľký Meder", "07", 47.85798, 17.76884);
case 61: return new CityInfo("Veľký Krtíš", "01", 48.21059, 19.35043);
case 62: return new CityInfo("Lehota pod Vtáčnikom", "06", 48.69138, 18.59944);
case 63: return new CityInfo("Tvrdošín", "08", 49.337, 19.556);
case 64: return new CityInfo("Turzovka", "08", 49.40429, 18.62258);
case 65: return new CityInfo("Turčianske Teplice", "08", 48.86225, 18.86048);
case 66: return new CityInfo("Trstená", "08", 49.36101, 19.61249);
case 67: return new CityInfo("Trnava", "07", 48.37741, 17.58723);
case 68: return new CityInfo("Trenčín", "06", 48.89452, 18.04436);
case 69: return new CityInfo("Trenčianske Teplice", "06", 48.91063, 18.16691);
case 70: return new CityInfo("Topoľčany", "04", 48.56361, 18.16712);
case 71: return new CityInfo("Tlmače", "04", 48.28926, 18.53152);
case 72: return new CityInfo("Tisovec", "01", 48.67738, 19.94364);
case 73: return new CityInfo("Terchová", "08", 49.25895, 19.02935);
case 74: return new CityInfo("Svodín", "04", 47.91054, 18.49967);
case 75: return new CityInfo("Svätý Kríž", "08", 49.05, 19.53333);
case 76: return new CityInfo("Svätý Jur", "02", 48.25216, 17.21539);
case 77: return new CityInfo("Svätý Anton", "01", 48.41923, 18.9401);
case 78: return new CityInfo("Šurany", "04", 48.08613, 18.18447);
case 79: return new CityInfo("Štúrovo", "04", 47.79495, 18.7175);
case 80: return new CityInfo("Stupava", "02", 48.27474, 17.03173);
case 81: return new CityInfo("Stráža", "08", 49.22578, 18.90782);
case 82: return new CityInfo("Stará Turá", "06", 48.77721, 17.69433);
case 83: return new CityInfo("Smolenice", "07", 48.50478, 17.43067);
case 84: return new CityInfo("Sládkovičovo", "07", 48.20137, 17.63852);
case 85: return new CityInfo("Skalica", "07", 48.8449, 17.22635);
case 86: return new CityInfo("Senica", "07", 48.67922, 17.36697);
case 87: return new CityInfo("Senec", "02", 48.21951, 17.40043);
case 88: return new CityInfo("Šamorín", "07", 48.03015, 17.30972);
case 89: return new CityInfo("Šaľa", "04", 48.15127, 17.88062);
case 90: return new CityInfo("Šahy", "04", 48.07408, 18.94946);
case 91: return new CityInfo("Ružomberok", "08", 49.0748, 19.30751);
case 92: return new CityInfo("Rajec", "08", 49.08899, 18.64007);
case 93: return new CityInfo("Púchov", "06", 49.12494, 18.32597);
case 94: return new CityInfo("Prievidza", "06", 48.77446, 18.6275);
case 95: return new CityInfo("Pribylina", "08", 49.0995, 19.79427);
case 96: return new CityInfo("Považská Bystrica", "06", 49.12153, 18.42169);
case 97: return new CityInfo("Poltár", "01", 48.43094, 19.79408);
case 98: return new CityInfo("Piešťany", "07", 48.59479, 17.82591);
case 99: return new CityInfo("Pezinok", "02", 48.28986, 17.26664);
case 100: return new CityInfo("Partizánske", "06", 48.62861, 18.38455);
case 101: return new CityInfo("Párnica", "08", 49.19416, 19.19761);
case 102: return new CityInfo("Oravský Podzámok", "08", 49.25939, 19.3569);
case 103: return new CityInfo("Nové Zámky", "04", 47.98544, 18.16195);
case 104: return new CityInfo("Nové Mesto nad Váhom", "06", 48.75763, 17.8309);
case 105: return new CityInfo("Nováky", "06", 48.71106, 18.53389);
case 106: return new CityInfo("Nová Dubnica", "06", 48.93479, 18.14632);
case 107: return new CityInfo("Nová Baňa", "01", 48.42305, 18.64037);
case 108: return new CityInfo("Nižná", "08", 49.31046, 19.52428);
case 109: return new CityInfo("Nitra", "04", 48.30763, 18.08453);
case 110: return new CityInfo("Nemšová", "06", 48.96702, 18.11892);
case 111: return new CityInfo("Námestovo", "08", 49.4079, 19.48032);
case 112: return new CityInfo("Mýto pod Ďumbierom", "01", 48.85171, 19.63247);
case 113: return new CityInfo("Myjava", "06", 48.75876, 17.56866);
case 114: return new CityInfo("Modra", "02", 48.33397, 17.30711);
case 115: return new CityInfo("Martin", "08", 49.06651, 18.92399);
case 116: return new CityInfo("Marianka", "02", 48.24903, 17.064);
case 117: return new CityInfo("Malacky", "02", 48.43604, 17.02188);
case 118: return new CityInfo("Lúčky", "08", 49.12944, 19.40228);
case 119: return new CityInfo("Lučenec", "01", 48.33249, 19.66708);
case 120: return new CityInfo("Liptovský Trnovec", "08", 49.12038, 19.54709);
case 121: return new CityInfo("Liptovský Mikuláš", "08", 49.08061, 19.62218);
case 122: return new CityInfo("Liptovský Hrádok", "08", 49.03962, 19.72335);
case 123: return new CityInfo("Liptovská Sielnica", "08", 49.14309, 19.51421);
case 124: return new CityInfo("Levice", "04", 48.21563, 18.60705);
case 125: return new CityInfo("Leopoldov", "07", 48.44575, 17.76458);
case 126: return new CityInfo("Kysucké Nové Mesto", "08", 49.3, 18.78333);
case 127: return new CityInfo("Krušetnica", "08", 49.37523, 19.33876);
case 128: return new CityInfo("Krupina", "01", 48.3554, 19.06474);
case 129: return new CityInfo("Kremnica", "01", 48.70519, 18.91834);
case 130: return new CityInfo("Krasňany", "08", 49.21491, 18.88718);
case 131: return new CityInfo("Kováčová", "01", 48.60148, 19.10252);
case 132: return new CityInfo("Komárno", "04", 48.11667, 18.31667);
case 133: return new CityInfo("Komárno", "04", 47.76356, 18.12263);
case 134: return new CityInfo("Kolárovo", "04", 47.92294, 17.98467);
case 135: return new CityInfo("Ivanka pri Dunaji", "02", 48.18675, 17.2554);
case 136: return new CityInfo("Ilava", "06", 48.99769, 18.2353);
case 137: return new CityInfo("Hybe", "08", 49.04439, 19.82895);
case 138: return new CityInfo("Hurbanovo", "04", 47.86984, 18.19233);
case 139: return new CityInfo("Hrochoť,Slovakia", "01", 48.65567, 19.31284);
case 140: return new CityInfo("Hriňová", "01", 48.57787, 19.52574);
case 141: return new CityInfo("Holíč", "07", 48.81105, 17.16238);
case 142: return new CityInfo("Hlohovec", "07", 48.43174, 17.8031);
case 143: return new CityInfo("Handlová", "06", 48.7276, 18.76012);
case 144: return new CityInfo("Gbely", "07", 48.718, 17.11628);
case 145: return new CityInfo("Galanta", "07", 48.19001, 17.72747);
case 146: return new CityInfo("Gabčíkovo", "07", 47.89211, 17.57884);
case 147: return new CityInfo("Fiľakovo", "01", 48.26757, 19.82473);
case 148: return new CityInfo("Bratislava - Vajnory", "02", 48.20563, 17.20759);
case 149: return new CityInfo("Dunajská Streda", "07", 47.99268, 17.61211);
case 150: return new CityInfo("Dudince", "01", 48.17135, 18.88782);
case 151: return new CityInfo("Dubnica nad Váhom", "06", 48.95981, 18.16634);
case 152: return new CityInfo("Dolný Kubín", "08", 49.20983, 19.30341);
case 153: return new CityInfo("Detva", "01", 48.56082, 19.41954);
case 154: return new CityInfo("Čierny Balog", "01", 48.74722, 19.65125);
case 155: return new CityInfo("Čadca", "08", 49.43503, 18.78895);
case 156: return new CityInfo("Čachtice", "06", 48.71226, 17.78704);
case 157: return new CityInfo("Bytča", "08", 49.22404, 18.55878);
case 158: return new CityInfo("Brezová pod Bradlom", "06", 48.66349, 17.53905);
case 159: return new CityInfo("Brezno", "01", 48.80431, 19.63631);
case 160: return new CityInfo("Bratislava", "02", 48.14816, 17.10674);
case 161: return new CityInfo("Bojnice", "06", 48.78511, 18.5864);
case 162: return new CityInfo("Bešeňová", "08", 49.10021, 19.43472);
case 163: return new CityInfo("Banská Štiavnica", "01", 48.44858, 18.91003);
case 164: return new CityInfo("Banská Bystrica", "01", 48.73946, 19.15349);
case 165: return new CityInfo("Bánovce nad Bebravou", "06", 48.7213, 18.25754);
case 166: return new CityInfo("Devínska Nová Ves", "02", 48.20711, 16.9786);
case 167: return new CityInfo("Oravská Lesná", "08", 49.36672, 19.18093);
case 168: return new CityInfo("Vágfüzes", "04", 47.85141, 18.052);
case 169: return new CityInfo("Dunajská Lužná", "02", 48.08347, 17.26072);
default: return new CityInfo("Vinosady", "02", 48.31142, 17.29042);

                                    }                                        
                                }
                            
                        }
                    }
                