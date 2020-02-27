
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
                                    public const string Country = "AR";
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
                            
                                        var cur = (Math.Abs(-34.09814 - lat) + Math.Abs(-59.02858 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-29.01913 - lat) + Math.Abs(-58.90846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.46914 - lat) + Math.Abs(-56.81841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96879 - lat) + Math.Abs(-54.56285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.71381 - lat) + Math.Abs(-58.65844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.57973 - lat) + Math.Abs(-58.46829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.48752 - lat) + Math.Abs(-59.35515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.66565 - lat) + Math.Abs(-59.90182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.39727 - lat) + Math.Abs(-58.74596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.67907 - lat) + Math.Abs(-58.47263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.23097 - lat) + Math.Abs(-59.98464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.8653 - lat) + Math.Abs(-59.02689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.26394 - lat) + Math.Abs(-56.97304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.62209 - lat) + Math.Abs(-58.67134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.1632 - lat) + Math.Abs(-58.40082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.5108 - lat) + Math.Abs(-58.68059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.79567 - lat) + Math.Abs(-57.91257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.38796 - lat) + Math.Abs(-57.33691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.37679 - lat) + Math.Abs(-54.74312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.68573 - lat) + Math.Abs(-58.89323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.79358 - lat) + Math.Abs(-58.3135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.00641 - lat) + Math.Abs(-55.60471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.47513 - lat) + Math.Abs(-58.75367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.42603 - lat) + Math.Abs(-58.57962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.50616 - lat) + Math.Abs(-56.97488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.32167 - lat) + Math.Abs(-59.13316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.41265 - lat) + Math.Abs(-59.26 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.80135 - lat) + Math.Abs(-59.93477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.7702 - lat) + Math.Abs(-59.68783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.23794 - lat) + Math.Abs(-59.21872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.08671 - lat) + Math.Abs(-58.78777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.0249 - lat) + Math.Abs(-58.42409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.61667 - lat) + Math.Abs(-54.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.54939 - lat) + Math.Abs(-56.04077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.14132 - lat) + Math.Abs(-55.40867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.26318 - lat) + Math.Abs(-58.11891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.9349 - lat) + Math.Abs(-55.40742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.98746 - lat) + Math.Abs(-59.10287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.94432 - lat) + Math.Abs(-59.78832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.17476 - lat) + Math.Abs(-58.78622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.90004 - lat) + Math.Abs(-57.93162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.3674 - lat) + Math.Abs(-55.58091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.62487 - lat) + Math.Abs(-58.50524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.57457 - lat) + Math.Abs(-58.70817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.67918 - lat) + Math.Abs(-59.66633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.62207 - lat) + Math.Abs(-54.10842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.43962 - lat) + Math.Abs(-58.80675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.99585 - lat) + Math.Abs(-57.58964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.5079 - lat) + Math.Abs(-58.55454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.13306 - lat) + Math.Abs(-58.76733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.6766 - lat) + Math.Abs(-58.56058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.44654 - lat) + Math.Abs(-58.43569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.38452 - lat) + Math.Abs(-58.75167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.76979 - lat) + Math.Abs(-55.7826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.57781 - lat) + Math.Abs(-59.9317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.87427 - lat) + Math.Abs(-55.13509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.4721 - lat) + Math.Abs(-58.52708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.25586 - lat) + Math.Abs(-55.5339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.68961 - lat) + Math.Abs(-59.3984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.24262 - lat) + Math.Abs(-58.63039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.37123 - lat) + Math.Abs(-58.51214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.35694 - lat) + Math.Abs(-56.72351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.34653 - lat) + Math.Abs(-59.60954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.74586 - lat) + Math.Abs(-55.89731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.2503 - lat) + Math.Abs(-59.47163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.44721 - lat) + Math.Abs(-59.44451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.63708 - lat) + Math.Abs(-59.77788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.25384 - lat) + Math.Abs(-58.62591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.98333 - lat) + Math.Abs(-55.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.30286 - lat) + Math.Abs(-59.14545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.39794 - lat) + Math.Abs(-59.33271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58191 - lat) + Math.Abs(-58.74497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.36209 - lat) + Math.Abs(-58.2775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.58333 - lat) + Math.Abs(-58.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.46056 - lat) + Math.Abs(-58.98389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.15 - lat) + Math.Abs(-59.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.7745 - lat) + Math.Abs(-59.08973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.51601 - lat) + Math.Abs(-58.3188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.36329 - lat) + Math.Abs(-58.30037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.72904 - lat) + Math.Abs(-58.26374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.53713 - lat) + Math.Abs(-58.01527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.51414 - lat) + Math.Abs(-58.93906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.37218 - lat) + Math.Abs(-59.08206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.79598 - lat) + Math.Abs(-55.02402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.46937 - lat) + Math.Abs(-54.70736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.91958 - lat) + Math.Abs(-54.58229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.98762 - lat) + Math.Abs(-55.16569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.59912 - lat) + Math.Abs(-54.57355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.75305 - lat) + Math.Abs(-59.17762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.02267 - lat) + Math.Abs(-54.61356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.40843 - lat) + Math.Abs(-54.69463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.92739 - lat) + Math.Abs(-58.50917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.22087 - lat) + Math.Abs(-59.38981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.3448 - lat) + Math.Abs(-58.44268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.1409 - lat) + Math.Abs(-59.59541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.00147 - lat) + Math.Abs(-59.84243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.36708 - lat) + Math.Abs(-55.89608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.74785 - lat) + Math.Abs(-58.70072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.73239 - lat) + Math.Abs(-59.10879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.10795 - lat) + Math.Abs(-56.8614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.45866 - lat) + Math.Abs(-58.9142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.00058 - lat) + Math.Abs(-58.14391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.18592 - lat) + Math.Abs(-59.95181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.67069 - lat) + Math.Abs(-55.24585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.34132 - lat) + Math.Abs(-58.61059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.75097 - lat) + Math.Abs(-58.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.71251 - lat) + Math.Abs(-57.08771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.31676 - lat) + Math.Abs(-58.57197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.72369 - lat) + Math.Abs(-54.91515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.04982 - lat) + Math.Abs(-59.93728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.70039 - lat) + Math.Abs(-59.12331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.56332 - lat) + Math.Abs(-59.33781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.94195 - lat) + Math.Abs(-57.90057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.50747 - lat) + Math.Abs(-58.48703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.48706 - lat) + Math.Abs(-55.11994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.84051 - lat) + Math.Abs(-58.8265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.75072 - lat) + Math.Abs(-57.62073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.39387 - lat) + Math.Abs(-59.78953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.5545 - lat) + Math.Abs(-58.73961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.00587 - lat) + Math.Abs(-59.27828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.55622 - lat) + Math.Abs(-58.70739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.6509 - lat) + Math.Abs(-58.61956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.25359 - lat) + Math.Abs(-57.63626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.5662 - lat) + Math.Abs(-54.757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.71165 - lat) + Math.Abs(-55.15631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.61891 - lat) + Math.Abs(-57.96344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.27161 - lat) + Math.Abs(-57.8389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.66627 - lat) + Math.Abs(-58.72927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.65145 - lat) + Math.Abs(-59.43068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.18416 - lat) + Math.Abs(-58.07519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.04532 - lat) + Math.Abs(-58.22835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.42265 - lat) + Math.Abs(-55.37659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.37667 - lat) + Math.Abs(-58.19436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.2616 - lat) + Math.Abs(-58.97219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.57531 - lat) + Math.Abs(-56.68883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.00042 - lat) + Math.Abs(-57.5562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.78233 - lat) + Math.Abs(-58.83777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.34636 - lat) + Math.Abs(-59.96957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.20687 - lat) + Math.Abs(-59.28696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.86274 - lat) + Math.Abs(-57.88094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.08065 - lat) + Math.Abs(-57.51301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.1722 - lat) + Math.Abs(-59.39947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.57028 - lat) + Math.Abs(-59.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.3843 - lat) + Math.Abs(-59.53013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.50316 - lat) + Math.Abs(-58.70596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.55051 - lat) + Math.Abs(-55.07908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.5908 - lat) + Math.Abs(-58.46773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.17548 - lat) + Math.Abs(-58.18774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.76834 - lat) + Math.Abs(-57.27531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.33177 - lat) + Math.Abs(-55.52499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.76088 - lat) + Math.Abs(-58.40632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.73501 - lat) + Math.Abs(-57.9185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.18537 - lat) + Math.Abs(-59.09788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.15574 - lat) + Math.Abs(-58.7913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.043 - lat) + Math.Abs(-57.8202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60341 - lat) + Math.Abs(-55.32491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.12634 - lat) + Math.Abs(-59.37352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.3529 - lat) + Math.Abs(-59.25795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.61802 - lat) + Math.Abs(-59.80135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.01403 - lat) + Math.Abs(-59.09984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.03595 - lat) + Math.Abs(-59.00125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.92145 - lat) + Math.Abs(-57.95453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.74179 - lat) + Math.Abs(-59.64517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.15997 - lat) + Math.Abs(-59.38605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.70252 - lat) + Math.Abs(-58.3955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.03786 - lat) + Math.Abs(-58.70347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.24769 - lat) + Math.Abs(-58.09383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.49565 - lat) + Math.Abs(-59.68083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.10724 - lat) + Math.Abs(-59.44784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.83607 - lat) + Math.Abs(-59.06211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.17443 - lat) + Math.Abs(-56.64326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.26904 - lat) + Math.Abs(-58.10558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.41873 - lat) + Math.Abs(-57.85612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.04346 - lat) + Math.Abs(-55.22698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.65803 - lat) + Math.Abs(-58.66317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58162 - lat) + Math.Abs(-56.68231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.27043 - lat) + Math.Abs(-58.24458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.42573 - lat) + Math.Abs(-57.33758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.21438 - lat) + Math.Abs(-59.85851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.5904 - lat) + Math.Abs(-58.62904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.43401 - lat) + Math.Abs(-58.63177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48705 - lat) + Math.Abs(-58.31198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.56516 - lat) + Math.Abs(-58.25557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.51226 - lat) + Math.Abs(-59.83545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.36816 - lat) + Math.Abs(-56.82869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.52323 - lat) + Math.Abs(-55.16077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.00937 - lat) + Math.Abs(-58.51722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.14156 - lat) + Math.Abs(-59.30966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.13995 - lat) + Math.Abs(-59.26343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.18636 - lat) + Math.Abs(-55.46433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.54453 - lat) + Math.Abs(-59.3548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.91161 - lat) + Math.Abs(-58.93594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.05 - lat) + Math.Abs(-56.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.53499 - lat) + Math.Abs(-58.93135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.93382 - lat) + Math.Abs(-58.6604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.57424 - lat) + Math.Abs(-58.53496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.60838 - lat) + Math.Abs(-58.95253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.45256 - lat) + Math.Abs(-58.64312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.40633 - lat) + Math.Abs(-56.94329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.92682 - lat) + Math.Abs(-58.94667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.99725 - lat) + Math.Abs(-57.13951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.53743 - lat) + Math.Abs(-59.34158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.64074 - lat) + Math.Abs(-57.79174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.72034 - lat) + Math.Abs(-59.39615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.52013 - lat) + Math.Abs(-57.32537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.52311 - lat) + Math.Abs(-58.4049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.76952 - lat) + Math.Abs(-58.49341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.42611 - lat) + Math.Abs(-55.16916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.48171 - lat) + Math.Abs(-55.82921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.81768 - lat) + Math.Abs(-54.95665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.17208 - lat) + Math.Abs(-55.65406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.18489 - lat) + Math.Abs(-58.17313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.41813 - lat) + Math.Abs(-59.02392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.56667 - lat) + Math.Abs(-55.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.82722 - lat) + Math.Abs(-58.39556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.10226 - lat) + Math.Abs(-58.33772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.95465 - lat) + Math.Abs(-58.78326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.00621 - lat) + Math.Abs(-57.89962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.84787 - lat) + Math.Abs(-58.52869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.01476 - lat) + Math.Abs(-59.5289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.98132 - lat) + Math.Abs(-58.5521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.86186 - lat) + Math.Abs(-57.91126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.95178 - lat) + Math.Abs(-58.80584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.29847 - lat) + Math.Abs(-54.19877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.40484 - lat) + Math.Abs(-54.62478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.30808 - lat) + Math.Abs(-59.37291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.71459 - lat) + Math.Abs(-54.81523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.02277 - lat) + Math.Abs(-54.68669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.69946 - lat) + Math.Abs(-55.25207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.49459 - lat) + Math.Abs(-58.62729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.9871 - lat) + Math.Abs(-58.96197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.31321 - lat) + Math.Abs(-57.67918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.79171 - lat) + Math.Abs(-58.0546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.83646 - lat) + Math.Abs(-59.00476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.5 - lat) + Math.Abs(-59.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.46784 - lat) + Math.Abs(-58.8344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.44604 - lat) + Math.Abs(-57.72865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.04837 - lat) + Math.Abs(-59.08435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.39296 - lat) + Math.Abs(-58.02089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.48463 - lat) + Math.Abs(-58.23217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.98311 - lat) + Math.Abs(-55.52031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.39175 - lat) + Math.Abs(-57.88777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.33453 - lat) + Math.Abs(-59.68212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.69825 - lat) + Math.Abs(-59.63154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.93041 - lat) + Math.Abs(-59.51861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.67144 - lat) + Math.Abs(-58.32538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.53556 - lat) + Math.Abs(-57.17435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.33099 - lat) + Math.Abs(-58.94622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.47428 - lat) + Math.Abs(-54.52498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.22312 - lat) + Math.Abs(-58.14426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.57365 - lat) + Math.Abs(-58.44924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.28481 - lat) + Math.Abs(-57.71851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.58041 - lat) + Math.Abs(-59.63094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.95489 - lat) + Math.Abs(-58.57277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.57297 - lat) + Math.Abs(-58.00809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.65503 - lat) + Math.Abs(-59.86291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.75048 - lat) + Math.Abs(-57.97962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.5131 - lat) + Math.Abs(-55.60896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.6331 - lat) + Math.Abs(-55.4962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.43333 - lat) + Math.Abs(-58.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.08949 - lat) + Math.Abs(-57.80393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.60333 - lat) + Math.Abs(-58.56409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.46325 - lat) + Math.Abs(-58.47872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.37743 - lat) + Math.Abs(-59.82395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.60587 - lat) + Math.Abs(-54.78093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.80215 - lat) + Math.Abs(-59.56089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.17238 - lat) + Math.Abs(-59.79048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.92998 - lat) + Math.Abs(-55.06084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.29207 - lat) + Math.Abs(-59.10179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.05379 - lat) + Math.Abs(-58.76205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.4595 - lat) + Math.Abs(-55.74536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.33271 - lat) + Math.Abs(-55.05651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.4549 - lat) + Math.Abs(-55.02122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.2077 - lat) + Math.Abs(-54.97977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.16327 - lat) + Math.Abs(-58.95919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.61315 - lat) + Math.Abs(-58.37723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.16842 - lat) + Math.Abs(-58.23427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.34311 - lat) + Math.Abs(-59.44512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.81708 - lat) + Math.Abs(-57.42974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.48218 - lat) + Math.Abs(-55.47756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.63333 - lat) + Math.Abs(-58.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.55067 - lat) + Math.Abs(-57.5346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.2552 - lat) + Math.Abs(-53.64581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.8735 - lat) + Math.Abs(-57.88303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.76531 - lat) + Math.Abs(-58.21278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.67188 - lat) + Math.Abs(-59.80653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.50752 - lat) + Math.Abs(-59.04149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.5627 - lat) + Math.Abs(-58.45829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.34833 - lat) + Math.Abs(-58.79265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.88539 - lat) + Math.Abs(-59.28245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.48132 - lat) + Math.Abs(-58.93925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.64966 - lat) + Math.Abs(-58.38341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.81105 - lat) + Math.Abs(-59.50807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.84616 - lat) + Math.Abs(-58.25522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.77698 - lat) + Math.Abs(-59.85854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.0616 - lat) + Math.Abs(-55.67797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.15185 - lat) + Math.Abs(-58.48691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.11761 - lat) + Math.Abs(-59.65834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.69748 - lat) + Math.Abs(-55.40376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.09625 - lat) + Math.Abs(-54.89626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.91421 - lat) + Math.Abs(-55.75355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.09683 - lat) + Math.Abs(-56.55043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.50825 - lat) + Math.Abs(-55.40258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.62317 - lat) + Math.Abs(-58.70512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.56978 - lat) + Math.Abs(-54.68262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.9162 - lat) + Math.Abs(-58.38111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.55 - lat) + Math.Abs(-68.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.89916 - lat) + Math.Abs(-70.05442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.64342 - lat) + Math.Abs(-64.47194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.81667 - lat) + Math.Abs(-65.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-51.57321 - lat) + Math.Abs(-72.3508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.22643 - lat) + Math.Abs(-64.23388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.17303 - lat) + Math.Abs(-62.77078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.75 - lat) + Math.Abs(-68.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.75964 - lat) + Math.Abs(-68.20692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.34093 - lat) + Math.Abs(-64.9203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.64757 - lat) + Math.Abs(-60.37516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.41347 - lat) + Math.Abs(-62.78822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.31595 - lat) + Math.Abs(-68.22658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.39552 - lat) + Math.Abs(-64.12241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.21329 - lat) + Math.Abs(-61.87597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.74434 - lat) + Math.Abs(-68.31411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.1879 - lat) + Math.Abs(-64.48027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.1 - lat) + Math.Abs(-67.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.20105 - lat) + Math.Abs(-63.86234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.4933 - lat) + Math.Abs(-68.53838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.50003 - lat) + Math.Abs(-63.69377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.89722 - lat) + Math.Abs(-68.78038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.43293 - lat) + Math.Abs(-63.24763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.31129 - lat) + Math.Abs(-61.05515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.98267 - lat) + Math.Abs(-68.42394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.40751 - lat) + Math.Abs(-63.24016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.95021 - lat) + Math.Abs(-65.05354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.76173 - lat) + Math.Abs(-71.64631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.56667 - lat) + Math.Abs(-68.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.83826 - lat) + Math.Abs(-64.58686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.03333 - lat) + Math.Abs(-64.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.66535 - lat) + Math.Abs(-66.45052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.1431 - lat) + Math.Abs(-62.65248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.97828 - lat) + Math.Abs(-64.55627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.94585 - lat) + Math.Abs(-65.18958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.85523 - lat) + Math.Abs(-64.99947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.90195 - lat) + Math.Abs(-63.72289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.81667 - lat) + Math.Abs(-63.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.44155 - lat) + Math.Abs(-68.39745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.5566 - lat) + Math.Abs(-63.53452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.17667 - lat) + Math.Abs(-64.45543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.70578 - lat) + Math.Abs(-65.01796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.22778 - lat) + Math.Abs(-60.3297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.32259 - lat) + Math.Abs(-62.81354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.32524 - lat) + Math.Abs(-62.03831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.01447 - lat) + Math.Abs(-68.22339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.42414 - lat) + Math.Abs(-64.49778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.00565 - lat) + Math.Abs(-61.60757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.28636 - lat) + Math.Abs(-67.02067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.29174 - lat) + Math.Abs(-60.41263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.49609 - lat) + Math.Abs(-63.81609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.16351 - lat) + Math.Abs(-63.89157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.57383 - lat) + Math.Abs(-60.71526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.29458 - lat) + Math.Abs(-64.29538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.65 - lat) + Math.Abs(-68.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.81345 - lat) + Math.Abs(-62.99668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.91965 - lat) + Math.Abs(-64.39215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.21505 - lat) + Math.Abs(-65.43586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.61841 - lat) + Math.Abs(-60.15478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.74647 - lat) + Math.Abs(-63.09764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.86782 - lat) + Math.Abs(-60.00722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.4593 - lat) + Math.Abs(-60.21261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.74556 - lat) + Math.Abs(-61.96885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-51.5839 - lat) + Math.Abs(-72.21382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.7741 - lat) + Math.Abs(-67.71638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.4323 - lat) + Math.Abs(-60.17271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.49558 - lat) + Math.Abs(-61.54138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.11732 - lat) + Math.Abs(-64.48084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.47604 - lat) + Math.Abs(-64.94822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.67989 - lat) + Math.Abs(-66.16283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-54.81084 - lat) + Math.Abs(-68.31591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.50682 - lat) + Math.Abs(-63.86225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.23073 - lat) + Math.Abs(-64.31615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.15282 - lat) + Math.Abs(-65.94602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.57362 - lat) + Math.Abs(-66.2365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.03203 - lat) + Math.Abs(-63.50666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.37146 - lat) + Math.Abs(-69.14845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.57653 - lat) + Math.Abs(-69.01538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.85814 - lat) + Math.Abs(-65.46704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.0858 - lat) + Math.Abs(-71.46386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.45722 - lat) + Math.Abs(-62.86047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.34067 - lat) + Math.Abs(-60.43207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.37394 - lat) + Math.Abs(-60.27978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.19471 - lat) + Math.Abs(-62.77396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.97035 - lat) + Math.Abs(-62.73432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.69837 - lat) + Math.Abs(-64.13218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.24895 - lat) + Math.Abs(-65.30505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23136 - lat) + Math.Abs(-65.28093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.5844 - lat) + Math.Abs(-61.16852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.23202 - lat) + Math.Abs(-61.76917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.10122 - lat) + Math.Abs(-62.22267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.55574 - lat) + Math.Abs(-64.00947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.67338 - lat) + Math.Abs(-64.3786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.2879 - lat) + Math.Abs(-63.35598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.02687 - lat) + Math.Abs(-62.70643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.06319 - lat) + Math.Abs(-67.56488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.73292 - lat) + Math.Abs(-65.29109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.57817 - lat) + Math.Abs(-65.39516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.6935 - lat) + Math.Abs(-63.43606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.49362 - lat) + Math.Abs(-64.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.43553 - lat) + Math.Abs(-66.94078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.26429 - lat) + Math.Abs(-65.51018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.49489 - lat) + Math.Abs(-70.8102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.51637 - lat) + Math.Abs(-63.80131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.35493 - lat) + Math.Abs(-60.0264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.24309 - lat) + Math.Abs(-63.9807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.45868 - lat) + Math.Abs(-69.422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.50798 - lat) + Math.Abs(-66.5298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.73201 - lat) + Math.Abs(-65.25921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.85275 - lat) + Math.Abs(-65.70983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.61557 - lat) + Math.Abs(-63.26708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.39864 - lat) + Math.Abs(-66.36701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.93357 - lat) + Math.Abs(-63.42938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.94404 - lat) + Math.Abs(-61.56148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.3847 - lat) + Math.Abs(-63.46907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.26272 - lat) + Math.Abs(-65.35647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.60603 - lat) + Math.Abs(-65.35574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.58487 - lat) + Math.Abs(-67.75674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.63761 - lat) + Math.Abs(-65.38692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.46971 - lat) + Math.Abs(-63.53842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.01412 - lat) + Math.Abs(-68.43281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.76776 - lat) + Math.Abs(-62.0477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.95642 - lat) + Math.Abs(-60.12488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.16105 - lat) + Math.Abs(-63.5936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.17442 - lat) + Math.Abs(-66.21177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.70287 - lat) + Math.Abs(-62.48202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.76762 - lat) + Math.Abs(-61.82887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.58815 - lat) + Math.Abs(-69.06996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.66274 - lat) + Math.Abs(-60.7653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.38731 - lat) + Math.Abs(-63.41821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.79511 - lat) + Math.Abs(-64.26149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.25124 - lat) + Math.Abs(-64.96549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.83261 - lat) + Math.Abs(-61.13747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.45166 - lat) + Math.Abs(-65.97452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.15231 - lat) + Math.Abs(-63.40191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.34286 - lat) + Math.Abs(-65.20323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.06905 - lat) + Math.Abs(-64.53631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.61667 - lat) + Math.Abs(-64.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.25407 - lat) + Math.Abs(-68.14937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.69547 - lat) + Math.Abs(-66.04732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.51776 - lat) + Math.Abs(-63.94409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.53987 - lat) + Math.Abs(-68.49503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.22724 - lat) + Math.Abs(-66.9424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.64881 - lat) + Math.Abs(-60.70868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.17659 - lat) + Math.Abs(-63.28281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.30921 - lat) + Math.Abs(-64.66253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.94467 - lat) + Math.Abs(-66.05219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.19457 - lat) + Math.Abs(-65.29712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.13705 - lat) + Math.Abs(-64.32426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.61772 - lat) + Math.Abs(-68.33007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.95386 - lat) + Math.Abs(-65.16651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.23127 - lat) + Math.Abs(-64.86614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.0952 - lat) + Math.Abs(-67.11586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.33425 - lat) + Math.Abs(-60.2108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.82414 - lat) + Math.Abs(-65.2226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.15789 - lat) + Math.Abs(-71.35337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.08103 - lat) + Math.Abs(-68.46814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.42957 - lat) + Math.Abs(-68.50065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.29501 - lat) + Math.Abs(-66.33563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.74341 - lat) + Math.Abs(-60.73613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.78913 - lat) + Math.Abs(-60.59189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.5375 - lat) + Math.Abs(-68.53639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.3544 - lat) + Math.Abs(-63.94871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.24057 - lat) + Math.Abs(-68.74693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.38333 - lat) + Math.Abs(-65.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.89618 - lat) + Math.Abs(-61.85984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46265 - lat) + Math.Abs(-65.72585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.59825 - lat) + Math.Abs(-66.12539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.7883 - lat) + Math.Abs(-63.94411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.42797 - lat) + Math.Abs(-62.08266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46957 - lat) + Math.Abs(-65.78524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.31053 - lat) + Math.Abs(-61.23724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.23071 - lat) + Math.Abs(-61.1157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.72864 - lat) + Math.Abs(-61.09192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.17761 - lat) + Math.Abs(-65.10245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.88618 - lat) + Math.Abs(-65.92941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.41051 - lat) + Math.Abs(-67.09341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.28782 - lat) + Math.Abs(-60.71252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.78371 - lat) + Math.Abs(-60.44156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.49763 - lat) + Math.Abs(-64.31495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.73193 - lat) + Math.Abs(-64.94769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.21804 - lat) + Math.Abs(-66.31877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.21377 - lat) + Math.Abs(-62.63237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.01009 - lat) + Math.Abs(-65.70874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.36753 - lat) + Math.Abs(-65.33471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.63353 - lat) + Math.Abs(-67.46821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.97681 - lat) + Math.Abs(-64.374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.52116 - lat) + Math.Abs(-60.39167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.3839 - lat) + Math.Abs(-64.72211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.29292 - lat) + Math.Abs(-60.25455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.7859 - lat) + Math.Abs(-65.41166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.13725 - lat) + Math.Abs(-64.29589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.31842 - lat) + Math.Abs(-65.09003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.75216 - lat) + Math.Abs(-62.96053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.30262 - lat) + Math.Abs(-64.307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.663 - lat) + Math.Abs(-63.04505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.26827 - lat) + Math.Abs(-62.71262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.98206 - lat) + Math.Abs(-65.57891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.79693 - lat) + Math.Abs(-64.97094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.94682 - lat) + Math.Abs(-60.63932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.89846 - lat) + Math.Abs(-60.90681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.19528 - lat) + Math.Abs(-60.735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.21186 - lat) + Math.Abs(-69.13661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.19051 - lat) + Math.Abs(-68.46081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.55389 - lat) + Math.Abs(-68.6525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.18552 - lat) + Math.Abs(-62.88535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.17301 - lat) + Math.Abs(-64.11405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.6526 - lat) + Math.Abs(-63.9099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.17905 - lat) + Math.Abs(-71.36847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.68573 - lat) + Math.Abs(-70.25797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-53.78769 - lat) + Math.Abs(-67.70946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-51.62261 - lat) + Math.Abs(-69.21813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.13067 - lat) + Math.Abs(-64.34992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.99397 - lat) + Math.Abs(-64.09295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.16486 - lat) + Math.Abs(-64.32241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.44083 - lat) + Math.Abs(-66.16779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.49076 - lat) + Math.Abs(-60.73299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.28184 - lat) + Math.Abs(-65.06096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.03658 - lat) + Math.Abs(-64.2447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.30016 - lat) + Math.Abs(-65.10228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.06862 - lat) + Math.Abs(-64.68107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.48508 - lat) + Math.Abs(-60.00629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.25033 - lat) + Math.Abs(-61.4867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.92462 - lat) + Math.Abs(-67.55424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.86913 - lat) + Math.Abs(-60.21683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.64615 - lat) + Math.Abs(-62.41655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.21397 - lat) + Math.Abs(-64.50063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.05463 - lat) + Math.Abs(-63.56428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.87588 - lat) + Math.Abs(-62.07359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-50.0191 - lat) + Math.Abs(-68.52321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-49.30554 - lat) + Math.Abs(-67.72743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.7692 - lat) + Math.Abs(-65.03851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-47.75034 - lat) + Math.Abs(-65.89382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.23 - lat) + Math.Abs(-66.93635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.14562 - lat) + Math.Abs(-65.91426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.54576 - lat) + Math.Abs(-62.76723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.26667 - lat) + Math.Abs(-68.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.78522 - lat) + Math.Abs(-60.43876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.16607 - lat) + Math.Abs(-64.49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.89682 - lat) + Math.Abs(-60.32359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.0186 - lat) + Math.Abs(-62.91984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.01391 - lat) + Math.Abs(-62.0665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.39455 - lat) + Math.Abs(-66.22052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.68333 - lat) + Math.Abs(-68.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.96667 - lat) + Math.Abs(-68.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.92598 - lat) + Math.Abs(-69.20863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.30158 - lat) + Math.Abs(-63.75788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.12288 - lat) + Math.Abs(-70.72152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.6789 - lat) + Math.Abs(-63.87964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.60509 - lat) + Math.Abs(-62.40333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.04811 - lat) + Math.Abs(-70.0741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.51614 - lat) + Math.Abs(-69.28765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.7949 - lat) + Math.Abs(-67.95731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.58995 - lat) + Math.Abs(-70.92975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.88995 - lat) + Math.Abs(-60.57357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.99835 - lat) + Math.Abs(-60.76791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.26584 - lat) + Math.Abs(-63.1655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.81077 - lat) + Math.Abs(-61.8968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.04681 - lat) + Math.Abs(-66.88231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.86225 - lat) + Math.Abs(-69.04603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.74733 - lat) + Math.Abs(-63.34232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.1255 - lat) + Math.Abs(-63.04084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.146 - lat) + Math.Abs(-64.50089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.73271 - lat) + Math.Abs(-60.52897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23002 - lat) + Math.Abs(-61.83774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.50517 - lat) + Math.Abs(-61.17436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.25647 - lat) + Math.Abs(-65.21163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.97771 - lat) + Math.Abs(-64.30311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.82508 - lat) + Math.Abs(-60.51749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.84057 - lat) + Math.Abs(-62.86552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.91353 - lat) + Math.Abs(-63.68201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.63117 - lat) + Math.Abs(-66.263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.04158 - lat) + Math.Abs(-63.56978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.89272 - lat) + Math.Abs(-60.32254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.78128 - lat) + Math.Abs(-63.41349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.44437 - lat) + Math.Abs(-60.88313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.66914 - lat) + Math.Abs(-68.39023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.19907 - lat) + Math.Abs(-64.23792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.85072 - lat) + Math.Abs(-70.90173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.36597 - lat) + Math.Abs(-62.31126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.95161 - lat) + Math.Abs(-68.0591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.91656 - lat) + Math.Abs(-65.37535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.73333 - lat) + Math.Abs(-60.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.32104 - lat) + Math.Abs(-66.14253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.71164 - lat) + Math.Abs(-61.99862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.5948 - lat) + Math.Abs(-62.83455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.16741 - lat) + Math.Abs(-65.49832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.80565 - lat) + Math.Abs(-62.83019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.20462 - lat) + Math.Abs(-62.60085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.9825 - lat) + Math.Abs(-61.29472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.34312 - lat) + Math.Abs(-63.94437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.91642 - lat) + Math.Abs(-62.45669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.43935 - lat) + Math.Abs(-66.29412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.91859 - lat) + Math.Abs(-62.67814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.72101 - lat) + Math.Abs(-65.00619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.00831 - lat) + Math.Abs(-65.99103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.85398 - lat) + Math.Abs(-63.68842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.49905 - lat) + Math.Abs(-64.97388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.34288 - lat) + Math.Abs(-65.01396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.89084 - lat) + Math.Abs(-68.82717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.26738 - lat) + Math.Abs(-64.30087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.65847 - lat) + Math.Abs(-61.45459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.82803 - lat) + Math.Abs(-62.69355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.48194 - lat) + Math.Abs(-64.17255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.99471 - lat) + Math.Abs(-62.82576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.75029 - lat) + Math.Abs(-70.02367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.6978 - lat) + Math.Abs(-62.10672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.24912 - lat) + Math.Abs(-68.70321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.38194 - lat) + Math.Abs(-64.05545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.47545 - lat) + Math.Abs(-69.58427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.80394 - lat) + Math.Abs(-66.60908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.46467 - lat) + Math.Abs(-64.3584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.97963 - lat) + Math.Abs(-68.78461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.06667 - lat) + Math.Abs(-67.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.62392 - lat) + Math.Abs(-65.40797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.92614 - lat) + Math.Abs(-60.04955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.13598 - lat) + Math.Abs(-63.6665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.9277 - lat) + Math.Abs(-65.33869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.03547 - lat) + Math.Abs(-68.87782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.36674 - lat) + Math.Abs(-65.93642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.93003 - lat) + Math.Abs(-65.87153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.98479 - lat) + Math.Abs(-63.44889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.98454 - lat) + Math.Abs(-62.02191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.84402 - lat) + Math.Abs(-68.08718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46539 - lat) + Math.Abs(-62.10862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.4077 - lat) + Math.Abs(-61.41367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.31983 - lat) + Math.Abs(-64.27751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.92497 - lat) + Math.Abs(-64.50207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.54972 - lat) + Math.Abs(-71.63086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.04845 - lat) + Math.Abs(-65.49945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.46546 - lat) + Math.Abs(-63.62429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.71439 - lat) + Math.Abs(-67.13349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.07284 - lat) + Math.Abs(-70.61609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.86649 - lat) + Math.Abs(-61.5302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.15966 - lat) + Math.Abs(-66.67436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.41074 - lat) + Math.Abs(-65.67586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.80644 - lat) + Math.Abs(-64.78757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.66174 - lat) + Math.Abs(-62.29678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.41225 - lat) + Math.Abs(-71.06797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.46642 - lat) + Math.Abs(-65.5663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.05258 - lat) + Math.Abs(-65.62385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.10996 - lat) + Math.Abs(-60.58719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.87208 - lat) + Math.Abs(-62.71946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.8026 - lat) + Math.Abs(-62.61655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.47661 - lat) + Math.Abs(-61.58041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.72058 - lat) + Math.Abs(-67.28319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.69794 - lat) + Math.Abs(-63.70634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.68478 - lat) + Math.Abs(-61.51637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.98881 - lat) + Math.Abs(-70.74991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.70955 - lat) + Math.Abs(-60.59303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.72762 - lat) + Math.Abs(-64.19335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.52322 - lat) + Math.Abs(-70.36745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.83125 - lat) + Math.Abs(-63.45016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.09231 - lat) + Math.Abs(-64.28899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.54186 - lat) + Math.Abs(-68.93593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.85273 - lat) + Math.Abs(-68.82837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.55534 - lat) + Math.Abs(-70.59491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.08966 - lat) + Math.Abs(-61.08161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.28155 - lat) + Math.Abs(-63.9761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.41105 - lat) + Math.Abs(-66.85067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.10236 - lat) + Math.Abs(-65.59299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.55 - lat) + Math.Abs(-67.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.17036 - lat) + Math.Abs(-65.79015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.54415 - lat) + Math.Abs(-60.79969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.72196 - lat) + Math.Abs(-66.20106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.10002 - lat) + Math.Abs(-63.03088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.46091 - lat) + Math.Abs(-67.54956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.89416 - lat) + Math.Abs(-63.00107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.15195 - lat) + Math.Abs(-65.66029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.31187 - lat) + Math.Abs(-64.96377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.6736 - lat) + Math.Abs(-64.93997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.42304 - lat) + Math.Abs(-65.70208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.34905 - lat) + Math.Abs(-68.01356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.25391 - lat) + Math.Abs(-61.24466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.30391 - lat) + Math.Abs(-60.65894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.77652 - lat) + Math.Abs(-63.80104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.00919 - lat) + Math.Abs(-64.26869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.06684 - lat) + Math.Abs(-71.60384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.40675 - lat) + Math.Abs(-62.63396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.08841 - lat) + Math.Abs(-64.48987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.98201 - lat) + Math.Abs(-64.49139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.73579 - lat) + Math.Abs(-69.12181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.76927 - lat) + Math.Abs(-65.58711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.13333 - lat) + Math.Abs(-60.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.95115 - lat) + Math.Abs(-62.97238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.41993 - lat) + Math.Abs(-63.29769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.12708 - lat) + Math.Abs(-65.0496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.70826 - lat) + Math.Abs(-63.77366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.34377 - lat) + Math.Abs(-64.33529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.60477 - lat) + Math.Abs(-65.38181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.12662 - lat) + Math.Abs(-63.39119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.15319 - lat) + Math.Abs(-62.85661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.73348 - lat) + Math.Abs(-64.24278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.8594 - lat) + Math.Abs(-65.18277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.88411 - lat) + Math.Abs(-62.67788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.95043 - lat) + Math.Abs(-71.06936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.58382 - lat) + Math.Abs(-60.94332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.14765 - lat) + Math.Abs(-68.47899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.05032 - lat) + Math.Abs(-70.46967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.11364 - lat) + Math.Abs(-64.12628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.98153 - lat) + Math.Abs(-64.09424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.1612 - lat) + Math.Abs(-63.46688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.08606 - lat) + Math.Abs(-63.43169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.79237 - lat) + Math.Abs(-63.78199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.24104 - lat) + Math.Abs(-62.40297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.79189 - lat) + Math.Abs(-65.21703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.23383 - lat) + Math.Abs(-63.59205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.94424 - lat) + Math.Abs(-62.23028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.22554 - lat) + Math.Abs(-64.83896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.07146 - lat) + Math.Abs(-67.2379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.38585 - lat) + Math.Abs(-64.46519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.3292 - lat) + Math.Abs(-69.55015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.9 - lat) + Math.Abs(-61.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.81411 - lat) + Math.Abs(-63.03252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.91934 - lat) + Math.Abs(-65.32817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.20544 - lat) + Math.Abs(-65.35048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.84038 - lat) + Math.Abs(-64.3758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.72533 - lat) + Math.Abs(-65.9787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.07524 - lat) + Math.Abs(-64.49063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.66653 - lat) + Math.Abs(-63.63701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.22896 - lat) + Math.Abs(-66.83131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.07189 - lat) + Math.Abs(-71.50811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.00447 - lat) + Math.Abs(-61.8408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.48094 - lat) + Math.Abs(-63.06779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.42657 - lat) + Math.Abs(-63.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.3373 - lat) + Math.Abs(-60.0216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60816 - lat) + Math.Abs(-61.34441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.3 - lat) + Math.Abs(-61.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.09834 - lat) + Math.Abs(-60.0883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.66776 - lat) + Math.Abs(-63.53021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.46149 - lat) + Math.Abs(-62.43844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.01381 - lat) + Math.Abs(-62.41858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.52031 - lat) + Math.Abs(-65.50937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.64934 - lat) + Math.Abs(-65.4383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.85683 - lat) + Math.Abs(-60.71754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.92863 - lat) + Math.Abs(-68.8351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-48.75057 - lat) + Math.Abs(-70.24741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.03016 - lat) + Math.Abs(-60.64045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.04992 - lat) + Math.Abs(-70.59798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.03285 - lat) + Math.Abs(-63.01252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.00014 - lat) + Math.Abs(-61.03508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.97904 - lat) + Math.Abs(-63.60449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.03333 - lat) + Math.Abs(-67.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.73196 - lat) + Math.Abs(-61.91599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.17601 - lat) + Math.Abs(-60.20079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.76459 - lat) + Math.Abs(-61.89093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.31667 - lat) + Math.Abs(-61.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.65662 - lat) + Math.Abs(-63.75682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.67034 - lat) + Math.Abs(-65.04765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.46025 - lat) + Math.Abs(-63.58537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.01472 - lat) + Math.Abs(-63.92413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.72218 - lat) + Math.Abs(-68.59137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.24755 - lat) + Math.Abs(-61.26273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.95297 - lat) + Math.Abs(-67.92489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21667 - lat) + Math.Abs(-62.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.59588 - lat) + Math.Abs(-63.81255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.07891 - lat) + Math.Abs(-67.15807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.10408 - lat) + Math.Abs(-64.45592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.81313 - lat) + Math.Abs(-63.87243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.12246 - lat) + Math.Abs(-62.3063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.30264 - lat) + Math.Abs(-61.30522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.02078 - lat) + Math.Abs(-60.0145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.97696 - lat) + Math.Abs(-67.69116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.37698 - lat) + Math.Abs(-64.60431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.26186 - lat) + Math.Abs(-69.22112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.15321 - lat) + Math.Abs(-63.53935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.49038 - lat) + Math.Abs(-61.67571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.02927 - lat) + Math.Abs(-61.22103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.2897 - lat) + Math.Abs(-65.4929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.91568 - lat) + Math.Abs(-60.80995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.63593 - lat) + Math.Abs(-65.13102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.31369 - lat) + Math.Abs(-65.76002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.79122 - lat) + Math.Abs(-60.72819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.94079 - lat) + Math.Abs(-64.79943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.45937 - lat) + Math.Abs(-61.4832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.67225 - lat) + Math.Abs(-67.6187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.92037 - lat) + Math.Abs(-63.89349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.92264 - lat) + Math.Abs(-67.52016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.05413 - lat) + Math.Abs(-65.40329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.94008 - lat) + Math.Abs(-63.2466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.05504 - lat) + Math.Abs(-60.09218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.91147 - lat) + Math.Abs(-71.31947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.4488 - lat) + Math.Abs(-60.93173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21003 - lat) + Math.Abs(-64.09965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.18 - lat) + Math.Abs(-64.41809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.38633 - lat) + Math.Abs(-64.28092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.2008 - lat) + Math.Abs(-61.7014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.38357 - lat) + Math.Abs(-62.82938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.97167 - lat) + Math.Abs(-64.89544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.21518 - lat) + Math.Abs(-65.8742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.28333 - lat) + Math.Abs(-64.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.04924 - lat) + Math.Abs(-71.16693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.64522 - lat) + Math.Abs(-70.58006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.02872 - lat) + Math.Abs(-63.23197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.38069 - lat) + Math.Abs(-64.65259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.57205 - lat) + Math.Abs(-64.39481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.92685 - lat) + Math.Abs(-68.34208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.0741 - lat) + Math.Abs(-65.49174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.38682 - lat) + Math.Abs(-65.26177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-50.34075 - lat) + Math.Abs(-72.27682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.96051 - lat) + Math.Abs(-71.53336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.7412 - lat) + Math.Abs(-62.89322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.31123 - lat) + Math.Abs(-65.36397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21572 - lat) + Math.Abs(-65.68005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.91501 - lat) + Math.Abs(-64.29448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.30684 - lat) + Math.Abs(-65.70651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.14967 - lat) + Math.Abs(-64.01183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.06641 - lat) + Math.Abs(-60.63837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.40431 - lat) + Math.Abs(-62.30634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.81626 - lat) + Math.Abs(-64.28989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.37659 - lat) + Math.Abs(-64.49504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.42036 - lat) + Math.Abs(-64.34984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.20334 - lat) + Math.Abs(-65.73952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.61072 - lat) + Math.Abs(-63.58038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.6 - lat) + Math.Abs(-61.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.93424 - lat) + Math.Abs(-69.23052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.33349 - lat) + Math.Abs(-64.64331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.72644 - lat) + Math.Abs(-64.80387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.00887 - lat) + Math.Abs(-61.80746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.02873 - lat) + Math.Abs(-60.30658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.6477 - lat) + Math.Abs(-63.75935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.24508 - lat) + Math.Abs(-64.46563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.95374 - lat) + Math.Abs(-60.96928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.02462 - lat) + Math.Abs(-64.19216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.28205 - lat) + Math.Abs(-62.18463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.45467 - lat) + Math.Abs(-61.93343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.98295 - lat) + Math.Abs(-61.35615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.6227 - lat) + Math.Abs(-64.59711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.68038 - lat) + Math.Abs(-60.91462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.71867 - lat) + Math.Abs(-61.28733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.18688 - lat) + Math.Abs(-65.95422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.8477 - lat) + Math.Abs(-64.36107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.97263 - lat) + Math.Abs(-60.91983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.4135 - lat) + Math.Abs(-64.18105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.72423 - lat) + Math.Abs(-68.15284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.59926 - lat) + Math.Abs(-60.94617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.34127 - lat) + Math.Abs(-65.59636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.56009 - lat) + Math.Abs(-65.2427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.86413 - lat) + Math.Abs(-67.49656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-49.98513 - lat) + Math.Abs(-68.91467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.02993 - lat) + Math.Abs(-70.26784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.5278 - lat) + Math.Abs(-62.72436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.23746 - lat) + Math.Abs(-63.06134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.445 - lat) + Math.Abs(-60.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.6 - lat) + Math.Abs(-62.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.15152 - lat) + Math.Abs(-63.85404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.89512 - lat) + Math.Abs(-61.1011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.5744 - lat) + Math.Abs(-64.13108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.93392 - lat) + Math.Abs(-67.99032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.30673 - lat) + Math.Abs(-62.65214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.82225 - lat) + Math.Abs(-68.06293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.8543 - lat) + Math.Abs(-66.235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.37809 - lat) + Math.Abs(-70.27085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.91578 - lat) + Math.Abs(-61.39982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.28941 - lat) + Math.Abs(-65.6606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.89566 - lat) + Math.Abs(-60.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.16482 - lat) + Math.Abs(-66.14236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.48333 - lat) + Math.Abs(-68.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.16195 - lat) + Math.Abs(-67.4974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.10502 - lat) + Math.Abs(-65.53473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.11505 - lat) + Math.Abs(-66.92714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.34363 - lat) + Math.Abs(-66.58894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.07872 - lat) + Math.Abs(-63.27657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.024 - lat) + Math.Abs(-64.04719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.21438 - lat) + Math.Abs(-61.18795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.36002 - lat) + Math.Abs(-66.31399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.64167 - lat) + Math.Abs(-60.47389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.05444 - lat) + Math.Abs(-67.39426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.89833 - lat) + Math.Abs(-65.48706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.881 - lat) + Math.Abs(-61.94504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.82955 - lat) + Math.Abs(-68.1318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.47606 - lat) + Math.Abs(-62.33888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.65179 - lat) + Math.Abs(-68.28105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.40597 - lat) + Math.Abs(-63.42168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.87907 - lat) + Math.Abs(-67.7956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.57952 - lat) + Math.Abs(-65.72696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.94679 - lat) + Math.Abs(-60.61947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.04417 - lat) + Math.Abs(-61.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.87296 - lat) + Math.Abs(-63.11715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.91371 - lat) + Math.Abs(-64.02175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.79828 - lat) + Math.Abs(-62.98097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.39265 - lat) + Math.Abs(-62.42146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.62171 - lat) + Math.Abs(-61.36169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.17668 - lat) + Math.Abs(-62.75792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.85679 - lat) + Math.Abs(-61.15331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.82262 - lat) + Math.Abs(-60.71852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.86088 - lat) + Math.Abs(-64.52515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.77436 - lat) + Math.Abs(-66.04749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.06036 - lat) + Math.Abs(-65.82477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.56542 - lat) + Math.Abs(-62.88927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.73341 - lat) + Math.Abs(-63.72375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.81636 - lat) + Math.Abs(-61.39493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.90982 - lat) + Math.Abs(-65.63656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.80077 - lat) + Math.Abs(-60.84215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.58333 - lat) + Math.Abs(-62.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.12745 - lat) + Math.Abs(-62.09453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.79709 - lat) + Math.Abs(-65.70994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.33394 - lat) + Math.Abs(-69.4208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.77368 - lat) + Math.Abs(-64.77002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.59559 - lat) + Math.Abs(-64.55778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.43929 - lat) + Math.Abs(-67.52814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.88767 - lat) + Math.Abs(-60.28697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.74069 - lat) + Math.Abs(-64.5937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.07286 - lat) + Math.Abs(-65.97766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.12033 - lat) + Math.Abs(-66.16519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.05222 - lat) + Math.Abs(-69.87713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.49918 - lat) + Math.Abs(-64.74206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.75647 - lat) + Math.Abs(-65.25379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.72263 - lat) + Math.Abs(-63.5092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.86589 - lat) + Math.Abs(-62.03742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.24382 - lat) + Math.Abs(-63.95091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.11912 - lat) + Math.Abs(-60.48966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.451 - lat) + Math.Abs(-64.38867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.90459 - lat) + Math.Abs(-63.7424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.02449 - lat) + Math.Abs(-63.58253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.82913 - lat) + Math.Abs(-64.06098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.62591 - lat) + Math.Abs(-62.68873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.03424 - lat) + Math.Abs(-65.30196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.65103 - lat) + Math.Abs(-67.02869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.82344 - lat) + Math.Abs(-69.91564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.8884 - lat) + Math.Abs(-62.266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.83333 - lat) + Math.Abs(-65.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.10564 - lat) + Math.Abs(-65.31884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.0088 - lat) + Math.Abs(-62.66733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.71959 - lat) + Math.Abs(-62.27243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.68532 - lat) + Math.Abs(-60.7292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.03147 - lat) + Math.Abs(-64.28426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.23281 - lat) + Math.Abs(-61.72862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.15489 - lat) + Math.Abs(-60.50863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.49119 - lat) + Math.Abs(-63.40126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.42022 - lat) + Math.Abs(-63.05002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.0639 - lat) + Math.Abs(-60.10357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.04978 - lat) + Math.Abs(-64.22254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.78215 - lat) + Math.Abs(-61.60222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.64411 - lat) + Math.Abs(-62.40272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.58071 - lat) + Math.Abs(-66.7925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.63895 - lat) + Math.Abs(-64.35621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.24252 - lat) + Math.Abs(-60.16107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.43276 - lat) + Math.Abs(-63.99535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.0594 - lat) + Math.Abs(-67.40636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.52567 - lat) + Math.Abs(-64.01025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.35441 - lat) + Math.Abs(-68.7884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58185 - lat) + Math.Abs(-66.31626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.17945 - lat) + Math.Abs(-70.66912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.81247 - lat) + Math.Abs(-65.50145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46064 - lat) + Math.Abs(-62.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.84771 - lat) + Math.Abs(-66.93024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.84405 - lat) + Math.Abs(-62.46701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.23686 - lat) + Math.Abs(-70.9197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.9559 - lat) + Math.Abs(-62.33727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.04105 - lat) + Math.Abs(-70.81982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.3335 - lat) + Math.Abs(-64.11496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.65292 - lat) + Math.Abs(-64.42826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.37704 - lat) + Math.Abs(-63.77445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.19296 - lat) + Math.Abs(-64.25559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.97736 - lat) + Math.Abs(-67.82714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.39968 - lat) + Math.Abs(-67.14511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.60643 - lat) + Math.Abs(-62.62304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.35369 - lat) + Math.Abs(-63.71849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.81667 - lat) + Math.Abs(-65.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.02692 - lat) + Math.Abs(-60.27587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.43722 - lat) + Math.Abs(-68.52556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.56091 - lat) + Math.Abs(-66.80588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.4338 - lat) + Math.Abs(-65.61427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.06661 - lat) + Math.Abs(-64.30017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.63152 - lat) + Math.Abs(-64.02097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.17538 - lat) + Math.Abs(-64.99331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.72049 - lat) + Math.Abs(-65.69697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-49.3299 - lat) + Math.Abs(-72.88605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.61032 - lat) + Math.Abs(-58.39766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.61082 - lat) + Math.Abs(-58.481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.28182 - lat) + Math.Abs(-61.41092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.89882 - lat) + Math.Abs(-64.77331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.16524 - lat) + Math.Abs(-56.89133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.67571 - lat) + Math.Abs(-65.45783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.18368 - lat) + Math.Abs(-66.3127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.91419 - lat) + Math.Abs(-64.73249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.32512 - lat) + Math.Abs(-57.02179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.48658 - lat) + Math.Abs(-64.5715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.66018 - lat) + Math.Abs(-58.36744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.54335 - lat) + Math.Abs(-58.71229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.14557 - lat) + Math.Abs(-71.30822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.38375 - lat) + Math.Abs(-58.70673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-51.53587 - lat) + Math.Abs(-72.33673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.80041 - lat) + Math.Abs(-58.38384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.36847 - lat) + Math.Abs(-59.73634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.02219 - lat) + Math.Abs(-61.18663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-54.51083 - lat) + Math.Abs(-67.1955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.7553 - lat) + Math.Abs(-59.4894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.47775 - lat) + Math.Abs(-58.70652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.39844 - lat) + Math.Abs(-68.92874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.98333 - lat) + Math.Abs(-64.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.51541 - lat) + Math.Abs(-58.76813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zárate", "01", -34.09814, -59.02858);
case 1: return new CityInfo("Yataity Calle", "06", -29.01913, -58.90846);
case 2: return new CityInfo("Yapeyú", "06", -29.46914, -56.81841);
case 3: return new CityInfo("Wanda", "14", -25.96879, -54.56285);
case 4: return new CityInfo("Villa Paranacito", "08", -33.71381, -58.65844);
case 5: return new CityInfo("Villa Ortúzar", "07", -34.57973, -58.46829);
case 6: return new CityInfo("Villa Ocampo", "21", -28.48752, -59.35515);
case 7: return new CityInfo("Villa María Grande", "08", -31.66565, -59.90182);
case 8: return new CityInfo("Villa Mantero", "08", -32.39727, -58.74596);
case 9: return new CityInfo("Villa Lugano", "07", -34.67907, -58.47263);
case 10: return new CityInfo("Villa Hernandarias", "08", -31.23097, -59.98464);
case 11: return new CityInfo("Villaguay", "08", -31.8653, -59.02689);
case 12: return new CityInfo("Villa Gesell", "01", -37.26394, -56.97304);
case 13: return new CityInfo("Villa Escolar", "09", -26.62209, -58.67134);
case 14: return new CityInfo("Villa Elisa", "08", -32.1632, -58.40082);
case 15: return new CityInfo("Villa de Mayo", "01", -34.5108, -58.68059);
case 16: return new CityInfo("Villa del Rosario", "08", -30.79567, -57.91257);
case 17: return new CityInfo("Verónica", "01", -35.38796, -57.33691);
case 18: return new CityInfo("Veinticinco de Mayo", "14", -27.37679, -54.74312);
case 19: return new CityInfo("Urdinarrain", "08", -32.68573, -58.89323);
case 20: return new CityInfo("Ubajay", "08", -31.79358, -58.3135);
case 21: return new CityInfo("Tres Capones", "14", -28.00641, -55.60471);
case 22: return new CityInfo("Tortuguitas", "01", -34.47513, -58.75367);
case 23: return new CityInfo("Tigre", "01", -34.42603, -58.57962);
case 24: return new CityInfo("Tapebicuá", "06", -29.50616, -56.97488);
case 25: return new CityInfo("Tandil", "01", -37.32167, -59.13316);
case 26: return new CityInfo("Tacuarendí", "21", -28.41265, -59.26);
case 27: return new CityInfo("Tabossi", "08", -31.80135, -59.93477);
case 28: return new CityInfo("Suipacha", "01", -34.7702, -59.68783);
case 29: return new CityInfo("Sauce de Luna", "08", -31.23794, -59.21872);
case 30: return new CityInfo("Sauce", "06", -30.08671, -58.78777);
case 31: return new CityInfo("San Vicente", "01", -35.0249, -58.42409);
case 32: return new CityInfo("San Vicente", "14", -26.61667, -54.13333);
case 33: return new CityInfo("Santo Tomé", "06", -28.54939, -56.04077);
case 34: return new CityInfo("Santo Pipó", "14", -27.14132, -55.40867);
case 35: return new CityInfo("Santa Rosa", "06", -28.26318, -58.11891);
case 36: return new CityInfo("Santa María", "14", -27.9349, -55.40742);
case 37: return new CityInfo("Santa Lucía", "06", -28.98746, -59.10287);
case 38: return new CityInfo("Santa Elena", "08", -30.94432, -59.78832);
case 39: return new CityInfo("Santa Anita", "08", -32.17476, -58.78622);
case 40: return new CityInfo("Santa Ana", "08", -30.90004, -57.93162);
case 41: return new CityInfo("Santa Ana", "14", -27.3674, -55.58091);
case 42: return new CityInfo("San Salvador", "08", -31.62487, -58.50524);
case 43: return new CityInfo("San Roque", "06", -28.57457, -58.70817);
case 44: return new CityInfo("San Pedro", "01", -33.67918, -59.66633);
case 45: return new CityInfo("San Pedro", "14", -26.62207, -54.10842);
case 46: return new CityInfo("San Miguel del Monte", "01", -35.43962, -58.80675);
case 47: return new CityInfo("San Miguel", "06", -27.99585, -57.58964);
case 48: return new CityInfo("San Luis del Palmar", "06", -27.5079, -58.55454);
case 49: return new CityInfo("San Lorenzo", "06", -28.13306, -58.76733);
case 50: return new CityInfo("San Justo", "01", -34.6766, -58.56058);
case 51: return new CityInfo("San Justo", "08", -32.44654, -58.43569);
case 52: return new CityInfo("San José de Feliciano", "08", -30.38452, -58.75167);
case 53: return new CityInfo("San José", "14", -27.76979, -55.7826);
case 54: return new CityInfo("San Javier", "21", -30.57781, -59.9317);
case 55: return new CityInfo("San Javier", "14", -27.87427, -55.13509);
case 56: return new CityInfo("San Isidro", "01", -34.4721, -58.52708);
case 57: return new CityInfo("San Ignacio", "14", -27.25586, -55.5339);
case 58: return new CityInfo("San Gustavo", "08", -30.68961, -59.3984);
case 59: return new CityInfo("San Francisco de Laishí", "09", -26.24262, -58.63039);
case 60: return new CityInfo("San Cosme", "06", -27.37123, -58.51214);
case 61: return new CityInfo("San Clemente del Tuyú", "01", -36.35694, -56.72351);
case 62: return new CityInfo("San Cayetano", "01", -38.34653, -59.60954);
case 63: return new CityInfo("San Carlos", "06", -27.74586, -55.89731);
case 64: return new CityInfo("San Antonio de Areco", "01", -34.2503, -59.47163);
case 65: return new CityInfo("San Andrés de Giles", "01", -34.44721, -59.44451);
case 66: return new CityInfo("Saladillo", "01", -35.63708, -59.77788);
case 67: return new CityInfo("Saladas", "06", -28.25384, -58.62591);
case 68: return new CityInfo("Ruiz de Montoya", "14", -26.98333, -55.05);
case 69: return new CityInfo("Rosario del Tala", "08", -32.30286, -59.14545);
case 70: return new CityInfo("Roque Pérez", "01", -35.39794, -59.33271);
case 71: return new CityInfo("Riachuelo", "06", -27.58191, -58.74497);
case 72: return new CityInfo("Riacho Eh-Eh", "09", -25.36209, -58.2775);
case 73: return new CityInfo("Retiro", "07", -34.58333, -58.38333);
case 74: return new CityInfo("Resistencia", "03", -27.46056, -58.98389);
case 75: return new CityInfo("Reconquista", "21", -29.15, -59.65);
case 76: return new CityInfo("Rauch", "01", -36.7745, -59.08973);
case 77: return new CityInfo("Ranchos", "01", -35.51601, -58.3188);
case 78: return new CityInfo("Ramada Paso", "06", -27.36329, -58.30037);
case 79: return new CityInfo("Quilmes", "01", -34.72904, -58.26374);
case 80: return new CityInfo("Puerto Yeruá", "08", -31.53713, -58.01527);
case 81: return new CityInfo("Puerto Vilelas", "03", -27.51414, -58.93906);
case 82: return new CityInfo("Puerto Tirol", "03", -27.37218, -59.08206);
case 83: return new CityInfo("Puerto Rico", "14", -26.79598, -55.02402);
case 84: return new CityInfo("Puerto Piray", "14", -26.46937, -54.70736);
case 85: return new CityInfo("Puerto Libertad", "14", -25.91958, -54.58229);
case 86: return new CityInfo("Puerto Leoni", "14", -26.98762, -55.16569);
case 87: return new CityInfo("Puerto Iguazú", "14", -25.59912, -54.57355);
case 88: return new CityInfo("Puerto Ibicuy", "08", -33.75305, -59.17762);
case 89: return new CityInfo("Puerto Esperanza", "14", -26.02267, -54.61356);
case 90: return new CityInfo("Puerto Eldorado", "14", -26.40843, -54.69463);
case 91: return new CityInfo("Puerto Bermejo", "03", -26.92739, -58.50917);
case 92: return new CityInfo("Pueblo Libertador", "06", -30.22087, -59.38981);
case 93: return new CityInfo("Pronunciamiento", "08", -32.3448, -58.44268);
case 94: return new CityInfo("Presidencia Roca", "03", -26.1409, -59.59541);
case 95: return new CityInfo("Presidencia de la Plaza", "03", -27.00147, -59.84243);
case 96: return new CityInfo("Posadas", "14", -27.36708, -55.89608);
case 97: return new CityInfo("Pontevedra", "01", -34.74785, -58.70072);
case 98: return new CityInfo("Pirané", "09", -25.73239, -59.10879);
case 99: return new CityInfo("Pinamar", "01", -37.10795, -56.8614);
case 100: return new CityInfo("Pilar", "01", -34.45866, -58.9142);
case 101: return new CityInfo("Pila", "01", -36.00058, -58.14391);
case 102: return new CityInfo("Piedras Blancas", "08", -31.18592, -59.95181);
case 103: return new CityInfo("Picada Gobernador López", "14", -27.67069, -55.24585);
case 104: return new CityInfo("Perugorría", "06", -29.34132, -58.61059);
case 105: return new CityInfo("Pedro R. Fernández", "06", -28.75097, -58.65583);
case 106: return new CityInfo("Paso de los Libres", "06", -29.71251, -57.08771);
case 107: return new CityInfo("Paso de la Patria", "06", -27.31676, -58.57197);
case 108: return new CityInfo("Panambí", "14", -27.72369, -54.91515);
case 109: return new CityInfo("Pampa del Indio", "03", -26.04982, -59.93728);
case 110: return new CityInfo("Pampa Almirón", "03", -26.70039, -59.12331);
case 111: return new CityInfo("Palo Santo", "09", -25.56332, -59.33781);
case 112: return new CityInfo("Palmar Grande", "06", -27.94195, -57.90057);
case 113: return new CityInfo("Olivos", "01", -34.50747, -58.48703);
case 114: return new CityInfo("Oberá", "14", -27.48706, -55.11994);
case 115: return new CityInfo("Nueve de Julio", "06", -28.84051, -58.8265);
case 116: return new CityInfo("Nuestra Señora del Rosario de Caa Catí", "06", -27.75072, -57.62073);
case 117: return new CityInfo("Nogoyá", "08", -32.39387, -59.78953);
case 118: return new CityInfo("Necochea", "01", -38.5545, -58.73961);
case 119: return new CityInfo("Navarro", "01", -35.00587, -59.27828);
case 120: return new CityInfo("Muñiz", "01", -34.55622, -58.70739);
case 121: return new CityInfo("Morón", "01", -34.6509, -58.61956);
case 122: return new CityInfo("Monte Caseros", "06", -30.25359, -57.63626);
case 123: return new CityInfo("Montecarlo", "14", -26.5662, -54.757);
case 124: return new CityInfo("Mojón Grande", "14", -27.71165, -55.15631);
case 125: return new CityInfo("Mocoretá", "06", -30.61891, -57.96344);
case 126: return new CityInfo("Miramar", "01", -38.27161, -57.8389);
case 127: return new CityInfo("Merlo", "01", -34.66627, -58.72927);
case 128: return new CityInfo("Mercedes", "01", -34.65145, -59.43068);
case 129: return new CityInfo("Mercedes", "06", -29.18416, -58.07519);
case 130: return new CityInfo("Mburucuyá", "06", -28.04532, -58.22835);
case 131: return new CityInfo("Mártires", "14", -27.42265, -55.37659);
case 132: return new CityInfo("Mariano I. Loza", "06", -29.37667, -58.19436);
case 133: return new CityInfo("Margarita Belén", "03", -27.2616, -58.97219);
case 134: return new CityInfo("Mar del Tuyú", "01", -36.57531, -56.68883);
case 135: return new CityInfo("Mar del Plata", "01", -38.00042, -57.5562);
case 136: return new CityInfo("Marcos Paz", "01", -34.78233, -58.83777);
case 137: return new CityInfo("Malabrigo", "21", -29.34636, -59.96957);
case 138: return new CityInfo("Makallé", "03", -27.20687, -59.28696);
case 139: return new CityInfo("Maipú", "01", -36.86274, -57.88094);
case 140: return new CityInfo("Magdalena", "01", -35.08065, -57.51301);
case 141: return new CityInfo("Maciá", "08", -32.1722, -59.39947);
case 142: return new CityInfo("Luján", "01", -34.57028, -59.105);
case 143: return new CityInfo("Lucas González", "08", -32.3843, -59.53013);
case 144: return new CityInfo("Los Polvorines", "01", -34.50316, -58.70596);
case 145: return new CityInfo("Los Helechos", "14", -27.55051, -55.07908);
case 146: return new CityInfo("Los Conquistadores", "08", -30.5908, -58.46773);
case 147: return new CityInfo("Los Charrúas", "08", -31.17548, -58.18774);
case 148: return new CityInfo("Loreto", "06", -27.76834, -57.27531);
case 149: return new CityInfo("Loreto", "14", -27.33177, -55.52499);
case 150: return new CityInfo("Lomas de Zamora", "01", -34.76088, -58.40632);
case 151: return new CityInfo("Lomas de Vallejos", "06", -27.73501, -57.9185);
case 152: return new CityInfo("Lobos", "01", -35.18537, -59.09788);
case 153: return new CityInfo("Lobería", "01", -38.15574, -58.7913);
case 154: return new CityInfo("Libertad", "06", -30.043, -57.8202);
case 155: return new CityInfo("Leandro N. Alem", "14", -27.60341, -55.32491);
case 156: return new CityInfo("La Verde", "03", -27.12634, -59.37352);
case 157: return new CityInfo("Las Toscas", "21", -28.3529, -59.25795);
case 158: return new CityInfo("Las Garcitas", "03", -26.61802, -59.80135);
case 159: return new CityInfo("Las Flores", "01", -36.01403, -59.09984);
case 160: return new CityInfo("Larroque", "08", -33.03595, -59.00125);
case 161: return new CityInfo("La Plata", "01", -34.92145, -57.95453);
case 162: return new CityInfo("La Paz", "08", -30.74179, -59.64517);
case 163: return new CityInfo("Lapachito", "03", -27.15997, -59.38605);
case 164: return new CityInfo("Lanús", "01", -34.70252, -58.3955);
case 165: return new CityInfo("La Leonesa", "03", -27.03786, -58.70347);
case 166: return new CityInfo("Laguna Naick-Neck", "09", -25.24769, -58.09383);
case 167: return new CityInfo("Laguna Limpia", "03", -26.49565, -59.68083);
case 168: return new CityInfo("La Escondida", "03", -27.10724, -59.44784);
case 169: return new CityInfo("La Eduvigis", "03", -26.83607, -59.06211);
case 170: return new CityInfo("La Cruz", "06", -29.17443, -56.64326);
case 171: return new CityInfo("La Criolla", "08", -31.26904, -58.10558);
case 172: return new CityInfo("Juan Pujol", "06", -30.41873, -57.85612);
case 173: return new CityInfo("Jardín América", "14", -27.04346, -55.22698);
case 174: return new CityInfo("Ituzaingó", "01", -34.65803, -58.66317);
case 175: return new CityInfo("Ituzaingó", "06", -27.58162, -56.68231);
case 176: return new CityInfo("Itatí", "06", -27.27043, -58.24458);
case 177: return new CityInfo("Itá Ibaté", "06", -27.42573, -57.33758);
case 178: return new CityInfo("Ibarreta", "09", -25.21438, -59.85851);
case 179: return new CityInfo("Hurlingham", "01", -34.5904, -58.62904);
case 180: return new CityInfo("Herrera", "08", -32.43401, -58.63177);
case 181: return new CityInfo("Herradura", "09", -26.48705, -58.31198);
case 182: return new CityInfo("Herlitzka", "06", -27.56516, -58.25557);
case 183: return new CityInfo("Hasenkamp", "08", -31.51226, -59.83545);
case 184: return new CityInfo("Guaviraví", "06", -29.36816, -56.82869);
case 185: return new CityInfo("Guaraní", "14", -27.52323, -55.16077);
case 186: return new CityInfo("Gualeguaychú", "08", -33.00937, -58.51722);
case 187: return new CityInfo("Gualeguay", "08", -33.14156, -59.30966);
case 188: return new CityInfo("Goya", "06", -29.13995, -59.26343);
case 189: return new CityInfo("Gobernador Roca", "14", -27.18636, -55.46433);
case 190: return new CityInfo("Gobernador Mansilla", "08", -32.54453, -59.3548);
case 191: return new CityInfo("Gobernador Juan E. Martínez", "06", -28.91161, -58.93594);
case 192: return new CityInfo("Gobernador Virasora", "06", -28.05, -56.03333);
case 193: return new CityInfo("Gilbert", "08", -32.53499, -58.93135);
case 194: return new CityInfo("General Vedia", "03", -26.93382, -58.6604);
case 195: return new CityInfo("General San Martín", "01", -34.57424, -58.53496);
case 196: return new CityInfo("General Rodríguez", "01", -34.60838, -58.95253);
case 197: return new CityInfo("General Pacheco", "01", -34.45256, -58.64312);
case 198: return new CityInfo("General Lavalle", "01", -36.40633, -56.94329);
case 199: return new CityInfo("General Las Heras", "01", -34.92682, -58.94667);
case 200: return new CityInfo("General Juan Madariaga", "01", -36.99725, -57.13951);
case 201: return new CityInfo("General José de San Martín", "03", -26.53743, -59.34158);
case 202: return new CityInfo("General Guido", "01", -36.64074, -57.79174);
case 203: return new CityInfo("General Galarza", "08", -32.72034, -59.39615);
case 204: return new CityInfo("General Conesa", "01", -36.52013, -57.32537);
case 205: return new CityInfo("General Campos", "08", -31.52311, -58.4049);
case 206: return new CityInfo("General Belgrano", "01", -35.76952, -58.49341);
case 207: return new CityInfo("General Alvear", "14", -27.42611, -55.16916);
case 208: return new CityInfo("Garupá", "14", -27.48171, -55.82921);
case 209: return new CityInfo("Garuhapé", "14", -26.81768, -54.95665);
case 210: return new CityInfo("Garruchos", "06", -28.17208, -55.65406);
case 211: return new CityInfo("Formosa", "09", -26.18489, -58.17313);
case 212: return new CityInfo("Fontana", "03", -27.41813, -59.02392);
case 213: return new CityInfo("Florentino Ameghino", "14", -27.56667, -55.13333);
case 214: return new CityInfo("Florencio Varela", "01", -34.82722, -58.39556);
case 215: return new CityInfo("Felipe Yofré", "06", -29.10226, -58.33772);
case 216: return new CityInfo("Federal", "08", -30.95465, -58.78326);
case 217: return new CityInfo("Federación", "08", -31.00621, -57.89962);
case 218: return new CityInfo("José María Ezeiza", "01", -34.84787, -58.52869);
case 219: return new CityInfo("Esquina", "06", -30.01476, -59.5289);
case 220: return new CityInfo("Espinillo", "09", -24.98132, -58.5521);
case 221: return new CityInfo("Ensenada", "01", -34.86186, -57.91126);
case 222: return new CityInfo("Empedrado", "06", -27.95178, -58.80584);
case 223: return new CityInfo("El Soberbio", "14", -27.29847, -54.19877);
case 224: return new CityInfo("Eldorado", "14", -26.40484, -54.62478);
case 225: return new CityInfo("El Colorado", "09", -26.30808, -59.37291);
case 226: return new CityInfo("El Alcázar", "14", -26.71459, -54.81523);
case 227: return new CityInfo("Dos de Mayo", "14", -27.02277, -54.68669);
case 228: return new CityInfo("Dos Arroyos", "14", -27.69946, -55.25207);
case 229: return new CityInfo("Don Torcuato", "01", -34.49459, -58.62729);
case 230: return new CityInfo("Domínguez", "08", -31.9871, -58.96197);
case 231: return new CityInfo("Dolores", "01", -36.31321, -57.67918);
case 232: return new CityInfo("Curuzú Cuatiá", "06", -29.79171, -58.0546);
case 233: return new CityInfo("Cruz de los Milagros", "06", -28.83646, -59.00476);
case 234: return new CityInfo("Coté-Lai", "03", -27.5, -59.6);
case 235: return new CityInfo("Corrientes", "06", -27.46784, -58.8344);
case 236: return new CityInfo("Coronel Vidal", "01", -37.44604, -57.72865);
case 237: return new CityInfo("Conscripto Bernardi", "08", -31.04837, -59.08435);
case 238: return new CityInfo("Concordia", "08", -31.39296, -58.02089);
case 239: return new CityInfo("Concepción del Uruguay", "08", -32.48463, -58.23217);
case 240: return new CityInfo("Concepción de la Sierra", "14", -27.98311, -55.52031);
case 241: return new CityInfo("Concepción", "06", -28.39175, -57.88777);
case 242: return new CityInfo("Comandante Fontana", "09", -25.33453, -59.68212);
case 243: return new CityInfo("Colonias Unidas", "03", -26.69825, -59.63154);
case 244: return new CityInfo("Colonia Elisa", "03", -26.93041, -59.51861);
case 245: return new CityInfo("Colonia Elía", "08", -32.67144, -58.32538);
case 246: return new CityInfo("Colonia Carlos Pellegrini", "06", -28.53556, -57.17435);
case 247: return new CityInfo("Colonia Benítez", "03", -27.33099, -58.94622);
case 248: return new CityInfo("Colonia Aurora", "14", -27.47428, -54.52498);
case 249: return new CityInfo("Colón", "08", -32.22312, -58.14426);
case 250: return new CityInfo("Colegiales", "07", -34.57365, -58.44924);
case 251: return new CityInfo("Clorinda", "09", -25.28481, -57.71851);
case 252: return new CityInfo("Ciervo Petiso", "03", -26.58041, -59.63094);
case 253: return new CityInfo("Chavarría", "06", -28.95489, -58.57277);
case 254: return new CityInfo("Chascomús", "01", -35.57297, -58.00809);
case 255: return new CityInfo("Charadai", "03", -27.65503, -59.86291);
case 256: return new CityInfo("Chajarí", "08", -30.75048, -57.97962);
case 257: return new CityInfo("Cerro Corá", "14", -27.5131, -55.60896);
case 258: return new CityInfo("Cerro Azul", "14", -27.6331, -55.4962);
case 259: return new CityInfo("Ceibas", "08", -33.43333, -58.75);
case 260: return new CityInfo("Castelli", "01", -36.08949, -57.80393);
case 261: return new CityInfo("Caseros", "01", -34.60333, -58.56409);
case 262: return new CityInfo("Caseros", "08", -32.46325, -58.47872);
case 263: return new CityInfo("Carmen de Areco", "01", -34.37743, -59.82395);
case 264: return new CityInfo("Caraguatay", "14", -26.60587, -54.78093);
case 265: return new CityInfo("Capitán Solari", "03", -26.80215, -59.56089);
case 266: return new CityInfo("Capitán Sarmiento", "01", -34.17238, -59.79048);
case 267: return new CityInfo("Capioví", "14", -26.92998, -55.06084);
case 268: return new CityInfo("Capilla del Señor", "01", -34.29207, -59.10179);
case 269: return new CityInfo("Cañuelas", "01", -35.05379, -58.76205);
case 270: return new CityInfo("Candelaria", "14", -27.4595, -55.74536);
case 271: return new CityInfo("Campo Viera", "14", -27.33271, -55.05651);
case 272: return new CityInfo("Campo Ramón", "14", -27.4549, -55.02122);
case 273: return new CityInfo("Campo Grande", "14", -27.2077, -54.97977);
case 274: return new CityInfo("Campana", "01", -34.16327, -58.95919);
case 275: return new CityInfo("Buenos Aires", "07", -34.61315, -58.37723);
case 276: return new CityInfo("Brandsen", "01", -35.16842, -58.23427);
case 277: return new CityInfo("Bovril", "08", -31.34311, -59.44512);
case 278: return new CityInfo("Bonpland", "06", -29.81708, -57.42974);
case 279: return new CityInfo("Bonpland", "14", -27.48218, -55.47756);
case 280: return new CityInfo("Boedo", "07", -34.63333, -58.41667);
case 281: return new CityInfo("Berón de Astrada", "06", -27.55067, -57.5346);
case 282: return new CityInfo("Bernardo de Irigoyen", "14", -26.2552, -53.64581);
case 283: return new CityInfo("Berisso", "01", -34.8735, -57.88303);
case 284: return new CityInfo("Berazategui", "01", -34.76531, -58.21278);
case 285: return new CityInfo("Benito Juárez", "01", -37.67188, -59.80653);
case 286: return new CityInfo("Bella Vista", "06", -28.50752, -59.04149);
case 287: return new CityInfo("Belgrano", "07", -34.5627, -58.45829);
case 288: return new CityInfo("Belén de Escobar", "01", -34.34833, -58.79265);
case 289: return new CityInfo("Basail", "03", -27.88539, -59.28245);
case 290: return new CityInfo("Barranqueras", "03", -27.48132, -58.93925);
case 291: return new CityInfo("Barracas", "07", -34.64966, -58.38341);
case 292: return new CityInfo("Baradero", "01", -33.81105, -59.50807);
case 293: return new CityInfo("Balcarce", "01", -37.84616, -58.25522);
case 294: return new CityInfo("Azul", "01", -36.77698, -59.85854);
case 295: return new CityInfo("Azara", "14", -28.0616, -55.67797);
case 296: return new CityInfo("Ayacucho", "01", -37.15185, -58.48691);
case 297: return new CityInfo("Avellaneda", "21", -29.11761, -59.65834);
case 298: return new CityInfo("Arroyo del Medio", "14", -27.69748, -55.40376);
case 299: return new CityInfo("Aristóbulo del Valle", "14", -27.09625, -54.89626);
case 300: return new CityInfo("Apóstoles", "14", -27.91421, -55.75355);
case 301: return new CityInfo("Alvear", "06", -29.09683, -56.55043);
case 302: return new CityInfo("Almafuerte", "14", -27.50825, -55.40258);
case 303: return new CityInfo("Aldea San Antonio", "08", -32.62317, -58.70512);
case 304: return new CityInfo("Alba Posse", "14", -27.56978, -54.68262);
case 305: return new CityInfo("Guernica", "01", -34.9162, -58.38111);
case 306: return new CityInfo("Villa Basilio Nievas", "18", -31.55, -68.73333);
case 307: return new CityInfo("Zapala", "15", -38.89916, -70.05442);
case 308: return new CityInfo("Yuto", "10", -23.64342, -64.47194);
case 309: return new CityInfo("Yerba Buena", "24", -26.81667, -65.31667);
case 310: return new CityInfo("Yacimiento Río Turbio", "20", -51.57321, -72.3508);
case 311: return new CityInfo("Winifreda", "11", -36.22643, -64.23388);
case 312: return new CityInfo("Wenceslao Escalante", "05", -33.17303, -62.77078);
case 313: return new CityInfo("Vista Alegre", "15", -38.75, -68.18333);
case 314: return new CityInfo("Vinchina", "12", -28.75964, -68.20692);
case 315: return new CityInfo("Villa Valeria", "05", -34.34093, -64.9203);
case 316: return new CityInfo("Villa Urquiza", "08", -31.64757, -60.37516);
case 317: return new CityInfo("Villa Unión", "22", -29.41347, -62.78822);
case 318: return new CityInfo("Villa Unión", "12", -29.31595, -68.22658);
case 319: return new CityInfo("Villa Tulumba", "05", -30.39552, -64.12241);
case 320: return new CityInfo("Villa Trinidad", "21", -30.21329, -61.87597);
case 321: return new CityInfo("Villa Santa Rosa", "18", -31.74434, -68.31411);
case 322: return new CityInfo("Villa Rumipal", "05", -32.1879, -64.48027);
case 323: return new CityInfo("Villa Regina", "16", -39.1, -67.06667);
case 324: return new CityInfo("Villa Reducción", "05", -33.20105, -63.86234);
case 325: return new CityInfo("Villa Paula de Sarmiento", "18", -31.4933, -68.53838);
case 326: return new CityInfo("Villa Ojo de Agua", "22", -29.50003, -63.69377);
case 327: return new CityInfo("Villa Nueva", "13", -32.89722, -68.78038);
case 328: return new CityInfo("Villa Nueva", "05", -32.43293, -63.24763);
case 329: return new CityInfo("Villa Mugueta", "21", -33.31129, -61.05515);
case 330: return new CityInfo("Villa Media Agua", "18", -31.98267, -68.42394);
case 331: return new CityInfo("Villa María", "05", -32.40751, -63.24016);
case 332: return new CityInfo("Villa Las Rosas", "05", -31.95021, -65.05354);
case 333: return new CityInfo("Villa La Angostura", "15", -40.76173, -71.64631);
case 334: return new CityInfo("Villa Krause", "18", -31.56667, -68.53333);
case 335: return new CityInfo("Villa Huidobro", "05", -34.83826, -64.58686);
case 336: return new CityInfo("Villa Giardino", "05", -31.03333, -64.48333);
case 337: return new CityInfo("Villa General Roca", "19", -32.66535, -66.45052);
case 338: return new CityInfo("Villa General Mitre", "22", -29.1431, -62.65248);
case 339: return new CityInfo("Villa General Belgrano", "05", -31.97828, -64.55627);
case 340: return new CityInfo("Villa Dolores", "05", -31.94585, -65.18958);
case 341: return new CityInfo("Villa de Soto", "05", -30.85523, -64.99947);
case 342: return new CityInfo("Villa de María", "05", -29.90195, -63.72289);
case 343: return new CityInfo("Villa del Totoral", "05", -30.81667, -63.71667);
case 344: return new CityInfo("Villa del Salvador", "18", -31.44155, -68.39745);
case 345: return new CityInfo("Villa del Rosario", "05", -31.5566, -63.53452);
case 346: return new CityInfo("Villa del Dique", "05", -32.17667, -64.45543);
case 347: return new CityInfo("Villa Cura Brochero", "05", -31.70578, -65.01796);
case 348: return new CityInfo("Villa Constitución", "21", -33.22778, -60.3297);
case 349: return new CityInfo("Villa Concepción del Tío", "05", -31.32259, -62.81354);
case 350: return new CityInfo("Chañar Ladeado", "21", -33.32524, -62.03831);
case 351: return new CityInfo("Villa Castelli", "12", -29.01447, -68.22339);
case 352: return new CityInfo("Villa Carlos Paz", "05", -31.42414, -64.49778);
case 353: return new CityInfo("Villa Cañás", "21", -34.00565, -61.60757);
case 354: return new CityInfo("Villa Bustos", "12", -29.28636, -67.02067);
case 355: return new CityInfo("Villa Berthet", "03", -27.29174, -60.41263);
case 356: return new CityInfo("Villa Atamisqui", "22", -28.49609, -63.81609);
case 357: return new CityInfo("Villa Ascasubi", "05", -32.16351, -63.89157);
case 358: return new CityInfo("Villa Ángela", "03", -27.57383, -60.71526);
case 359: return new CityInfo("Villa Allende", "05", -31.29458, -64.29538);
case 360: return new CityInfo("Villa Aberastain", "18", -31.65, -68.58333);
case 361: return new CityInfo("Viedma", "16", -40.81345, -62.99668);
case 362: return new CityInfo("Vicuña Mackenna", "05", -33.91965, -64.39215);
case 363: return new CityInfo("Victorica", "11", -36.21505, -65.43586);
case 364: return new CityInfo("Victoria", "08", -32.61841, -60.15478);
case 365: return new CityInfo("Viamonte", "05", -33.74647, -63.09764);
case 366: return new CityInfo("Viale", "08", -31.86782, -60.00722);
case 367: return new CityInfo("Vera", "21", -29.4593, -60.21261);
case 368: return new CityInfo("Venado Tuerto", "21", -33.74556, -61.96885);
case 369: return new CityInfo("28 de Noviembre", "20", -51.5839, -72.21382);
case 370: return new CityInfo("Veinticinco de Mayo", "11", -37.7741, -67.71638);
case 371: return new CityInfo("Veinticinco de Mayo", "01", -35.4323, -60.17271);
case 372: return new CityInfo("Vedia", "01", -34.49558, -61.54138);
case 373: return new CityInfo("Valle Hermoso", "05", -31.11732, -64.48084);
case 374: return new CityInfo("Valle Grande", "10", -23.47604, -64.94822);
case 375: return new CityInfo("Valcheta", "16", -40.67989, -66.16283);
case 376: return new CityInfo("Ushuaia", "23", -54.81084, -68.31591);
case 377: return new CityInfo("Uriburu", "11", -36.50682, -63.86225);
case 378: return new CityInfo("Unquillo", "05", -31.23073, -64.31615);
case 379: return new CityInfo("Unión", "19", -35.15282, -65.94602);
case 380: return new CityInfo("Ulapes", "12", -31.57362, -66.2365);
case 381: return new CityInfo("Ucacha", "05", -33.03203, -63.50666);
case 382: return new CityInfo("Tupungato", "13", -33.37146, -69.14845);
case 383: return new CityInfo("Tunuyán", "13", -33.57653, -69.01538);
case 384: return new CityInfo("Tumbaya", "10", -23.85814, -65.46704);
case 385: return new CityInfo("Trevelin", "04", -43.0858, -71.46386);
case 386: return new CityInfo("Tres Lomas", "01", -36.45722, -62.86047);
case 387: return new CityInfo("Tres Isletas", "03", -26.34067, -60.43207);
case 388: return new CityInfo("Tres Arroyos", "01", -38.37394, -60.27978);
case 389: return new CityInfo("Tres Algarrobos", "01", -35.19471, -62.77396);
case 390: return new CityInfo("Trenque Lauquen", "01", -35.97035, -62.73432);
case 391: return new CityInfo("Trenel", "11", -35.69837, -64.13218);
case 392: return new CityInfo("Trelew", "04", -43.24895, -65.30505);
case 393: return new CityInfo("Trancas", "24", -26.23136, -65.28093);
case 394: return new CityInfo("Totoras", "21", -32.5844, -61.16852);
case 395: return new CityInfo("Tostado", "21", -29.23202, -61.76917);
case 396: return new CityInfo("Tornquist", "01", -38.10122, -62.22267);
case 397: return new CityInfo("Toledo", "05", -31.55574, -64.00947);
case 398: return new CityInfo("Toay", "11", -36.67338, -64.3786);
case 399: return new CityInfo("Tío Pujio", "05", -32.2879, -63.35598);
case 400: return new CityInfo("Tintina", "22", -27.02687, -62.70643);
case 401: return new CityInfo("Tinogasta", "02", -28.06319, -67.56488);
case 402: return new CityInfo("Tilisarao", "19", -32.73292, -65.29109);
case 403: return new CityInfo("Tilcara", "10", -23.57817, -65.39516);
case 404: return new CityInfo("Ticino", "05", -32.6935, -63.43606);
case 405: return new CityInfo("Termas de Río Hondo", "22", -27.49362, -64.85972);
case 406: return new CityInfo("Telsen", "04", -42.43553, -66.94078);
case 407: return new CityInfo("Telén", "11", -36.26429, -65.51018);
case 408: return new CityInfo("Tecka", "04", -43.49489, -70.8102);
case 409: return new CityInfo("Tartagal", "17", -22.51637, -63.80131);
case 410: return new CityInfo("Tapalqué", "01", -36.35493, -60.0264);
case 411: return new CityInfo("Tancacha", "05", -32.24309, -63.9807);
case 412: return new CityInfo("Tamberías", "18", -31.45868, -69.422);
case 413: return new CityInfo("Tama", "12", -30.50798, -66.5298);
case 414: return new CityInfo("Tafí Viejo", "24", -26.73201, -65.25921);
case 415: return new CityInfo("Tafí del Valle", "24", -26.85275, -65.70983);
case 416: return new CityInfo("Taco Pozo", "03", -25.61557, -63.26708);
case 417: return new CityInfo("Susques", "10", -23.39864, -66.36701);
case 418: return new CityInfo("Suncho Corral", "22", -27.93357, -63.42938);
case 419: return new CityInfo("Sunchales", "21", -30.94404, -61.56148);
case 420: return new CityInfo("Sumampa", "22", -29.3847, -63.46907);
case 421: return new CityInfo("Simoca", "24", -27.26272, -65.35647);
case 422: return new CityInfo("Sierra Grande", "16", -41.60603, -65.35574);
case 423: return new CityInfo("Sierra Colorada", "16", -40.58487, -67.75674);
case 424: return new CityInfo("Serrezuela", "05", -30.63761, -65.38692);
case 425: return new CityInfo("Serrano", "05", -34.46971, -63.53842);
case 426: return new CityInfo("Senillosa", "15", -39.01412, -68.43281);
case 427: return new CityInfo("Selva", "22", -29.76776, -62.0477);
case 428: return new CityInfo("Seguí", "08", -31.95642, -60.12488);
case 429: return new CityInfo("Sebastián Elcano", "05", -30.16105, -63.5936);
case 430: return new CityInfo("Saujil", "02", -28.17442, -66.21177);
case 431: return new CityInfo("Saturnino M. Laspiur", "05", -31.70287, -62.48202);
case 432: return new CityInfo("Sastre", "21", -31.76762, -61.82887);
case 433: return new CityInfo("Sarmiento", "04", -45.58815, -69.06996);
case 434: return new CityInfo("Santo Tomé", "21", -31.66274, -60.7653);
case 435: return new CityInfo("Santiago Temple", "05", -31.38731, -63.41821);
case 436: return new CityInfo("Santiago del Estero", "22", -27.79511, -64.26149);
case 437: return new CityInfo("Santa Victoria", "17", -22.25124, -64.96549);
case 438: return new CityInfo("Santa Sylvina", "03", -27.83261, -61.13747);
case 439: return new CityInfo("Santa Rosa de Tastil", "17", -24.45166, -65.97452);
case 440: return new CityInfo("Santa Rosa de Río Primero", "05", -31.15231, -63.40191);
case 441: return new CityInfo("Santa Rosa del Conlara", "19", -32.34286, -65.20323);
case 442: return new CityInfo("Santa Rosa de Calamuchita", "05", -32.06905, -64.53631);
case 443: return new CityInfo("Santa Rosa", "11", -36.61667, -64.28333);
case 444: return new CityInfo("Santa Rosa", "13", -33.25407, -68.14937);
case 445: return new CityInfo("Santa María", "02", -26.69547, -66.04732);
case 446: return new CityInfo("Santa Magdalena", "05", -34.51776, -63.94409);
case 447: return new CityInfo("Santa Lucía", "18", -31.53987, -68.49503);
case 448: return new CityInfo("Santa Isabel", "11", -36.22724, -66.9424);
case 449: return new CityInfo("Santa Fe", "21", -31.64881, -60.70868);
case 450: return new CityInfo("Santa Eufemia", "05", -33.17659, -63.28281);
case 451: return new CityInfo("Santa Clara", "10", -24.30921, -64.66253);
case 452: return new CityInfo("Santa Catalina", "10", -21.94467, -66.05219);
case 453: return new CityInfo("San Salvador de Jujuy", "10", -24.19457, -65.29712);
case 454: return new CityInfo("San Ramón de la Nueva Orán", "17", -23.13705, -64.32426);
case 455: return new CityInfo("San Rafael", "13", -34.61772, -68.33007);
case 456: return new CityInfo("San Pedro", "22", -27.95386, -65.16651);
case 457: return new CityInfo("San Pedro de Jujuy", "10", -24.23127, -64.86614);
case 458: return new CityInfo("Sañogasta", "12", -29.0952, -67.11586);
case 459: return new CityInfo("San Nicolás de los Arroyos", "01", -33.33425, -60.2108);
case 460: return new CityInfo("San Miguel de Tucumán", "24", -26.82414, -65.2226);
case 461: return new CityInfo("San Martín de los Andes", "15", -40.15789, -71.35337);
case 462: return new CityInfo("San Martín", "13", -33.08103, -68.46814);
case 463: return new CityInfo("San Martín", "18", -31.42957, -68.50065);
case 464: return new CityInfo("San Luis", "19", -33.29501, -66.33563);
case 465: return new CityInfo("San Lorenzo", "21", -32.74341, -60.73613);
case 466: return new CityInfo("San Justo", "21", -30.78913, -60.59189);
case 467: return new CityInfo("San Juan", "18", -31.5375, -68.53639);
case 468: return new CityInfo("San José de la Dormida", "05", -30.3544, -63.94871);
case 469: return new CityInfo("San José de Jáchal", "18", -30.24057, -68.74693);
case 470: return new CityInfo("San José", "02", -28.38333, -65.7);
case 471: return new CityInfo("San Jorge", "21", -31.89618, -61.85984);
case 472: return new CityInfo("San Isidro", "02", -28.46265, -65.72585);
case 473: return new CityInfo("San Francisco del Monte de Oro", "19", -32.59825, -66.12539);
case 474: return new CityInfo("San Francisco del Chañar", "05", -29.7883, -63.94411);
case 475: return new CityInfo("San Francisco", "05", -31.42797, -62.08266);
case 476: return new CityInfo("San Fernando del Valle de Catamarca", "02", -28.46957, -65.78524);
case 477: return new CityInfo("San Cristóbal", "21", -30.31053, -61.23724);
case 478: return new CityInfo("San Carlos de Bolívar", "01", -36.23071, -61.1157);
case 479: return new CityInfo("San Carlos Centro", "21", -31.72864, -61.09192);
case 480: return new CityInfo("San Carlos", "05", -31.17761, -65.10245);
case 481: return new CityInfo("San Carlos", "17", -25.88618, -65.92941);
case 482: return new CityInfo("San Blas de los Sauces", "12", -28.41051, -67.09341);
case 483: return new CityInfo("San Bernardo", "03", -27.28782, -60.71252);
case 484: return new CityInfo("San Benito", "08", -31.78371, -60.44156);
case 485: return new CityInfo("San Basilio", "05", -33.49763, -64.31495);
case 486: return new CityInfo("San Antonio Oeste", "16", -40.73193, -64.94769);
case 487: return new CityInfo("San Antonio de los Cobres", "17", -24.21804, -66.31877);
case 488: return new CityInfo("San Antonio de Litín", "05", -32.21377, -62.63237);
case 489: return new CityInfo("San Antonio", "02", -28.01009, -65.70874);
case 490: return new CityInfo("San Antonio", "10", -24.36753, -65.33471);
case 491: return new CityInfo("San Agustín de Valle Fértil", "18", -30.63353, -67.46821);
case 492: return new CityInfo("San Agustín", "05", -31.97681, -64.374);
case 493: return new CityInfo("Samuhú", "03", -27.52116, -60.39167);
case 494: return new CityInfo("Sampacho", "05", -33.3839, -64.72211);
case 495: return new CityInfo("Salto", "01", -34.29292, -60.25455);
case 496: return new CityInfo("Salta", "17", -24.7859, -65.41166);
case 497: return new CityInfo("Salsipuedes", "05", -31.13725, -64.29589);
case 498: return new CityInfo("Salsacate", "05", -31.31842, -65.09003);
case 499: return new CityInfo("Salliqueló", "01", -36.75216, -62.96053);
case 500: return new CityInfo("Saldán", "05", -31.30262, -64.307);
case 501: return new CityInfo("Sacanta", "05", -31.663, -63.04505);
case 502: return new CityInfo("Rufino", "21", -34.26827, -62.71262);
case 503: return new CityInfo("Rosario de Lerma", "17", -24.98206, -65.57891);
case 504: return new CityInfo("Rosario de la Frontera", "17", -25.79693, -64.97094);
case 505: return new CityInfo("Rosario", "21", -32.94682, -60.63932);
case 506: return new CityInfo("Roldán", "21", -32.89846, -60.90681);
case 507: return new CityInfo("Rojas", "01", -34.19528, -60.735);
case 508: return new CityInfo("Rodeo", "18", -30.21186, -69.13661);
case 509: return new CityInfo("Rivadavia", "13", -33.19051, -68.46081);
case 510: return new CityInfo("Rivadavia", "18", -31.55389, -68.6525);
case 511: return new CityInfo("Rivadavia", "17", -24.18552, -62.88535);
case 512: return new CityInfo("Río Tercero", "05", -32.17301, -64.11405);
case 513: return new CityInfo("Río Segundo", "05", -31.6526, -63.9099);
case 514: return new CityInfo("Río Pico", "04", -44.17905, -71.36847);
case 515: return new CityInfo("Río Mayo", "04", -45.68573, -70.25797);
case 516: return new CityInfo("Río Grande", "23", -53.78769, -67.70946);
case 517: return new CityInfo("Río Gallegos", "20", -51.62261, -69.21813);
case 518: return new CityInfo("Río Cuarto", "05", -33.13067, -64.34992);
case 519: return new CityInfo("Río Colorado", "16", -38.99397, -64.09295);
case 520: return new CityInfo("Río Ceballos", "05", -31.16486, -64.32241);
case 521: return new CityInfo("Rinconada", "10", -22.44083, -66.16779);
case 522: return new CityInfo("Recreo", "21", -31.49076, -60.73299);
case 523: return new CityInfo("Recreo", "02", -29.28184, -65.06096);
case 524: return new CityInfo("Realicó", "11", -35.03658, -64.2447);
case 525: return new CityInfo("Rawson", "04", -43.30016, -65.10228);
case 526: return new CityInfo("Rancul", "11", -35.06862, -64.68107);
case 527: return new CityInfo("Ramallo", "01", -33.48508, -60.00629);
case 528: return new CityInfo("Rafaela", "21", -31.25033, -61.4867);
case 529: return new CityInfo("Rada Tilly", "04", -45.92462, -67.55424);
case 530: return new CityInfo("Quitilipi", "03", -26.86913, -60.21683);
case 531: return new CityInfo("Quimilí", "22", -27.64615, -62.41655);
case 532: return new CityInfo("Quilino", "05", -30.21397, -64.50063);
case 533: return new CityInfo("Quemú Quemú", "11", -36.05463, -63.56428);
case 534: return new CityInfo("Punta Alta", "01", -38.87588, -62.07359);
case 535: return new CityInfo("Puerto Santa Cruz", "20", -50.0191, -68.52321);
case 536: return new CityInfo("San Julián", "20", -49.30554, -67.72743);
case 537: return new CityInfo("Puerto Madryn", "04", -42.7692, -65.03851);
case 538: return new CityInfo("Puerto Deseado", "20", -47.75034, -65.89382);
case 539: return new CityInfo("Puerta de Corral Quemado", "02", -27.23, -66.93635);
case 540: return new CityInfo("Puelches", "11", -38.14562, -65.91426);
case 541: return new CityInfo("Puan", "01", -37.54576, -62.76723);
case 542: return new CityInfo("Primero de Mayo", "08", -32.26667, -68.41667);
case 543: return new CityInfo("Presidencia Roque Sáenz Peña", "03", -26.78522, -60.43876);
case 544: return new CityInfo("Pozo Hondo", "22", -27.16607, -64.49);
case 545: return new CityInfo("Pozo del Tigre", "09", -24.89682, -60.32359);
case 546: return new CityInfo("Pozo del Molle", "05", -32.0186, -62.91984);
case 547: return new CityInfo("Porteña", "05", -31.01391, -62.0665);
case 548: return new CityInfo("Pomán", "02", -28.39455, -66.22052);
case 549: return new CityInfo("Pocito", "18", -31.68333, -68.58333);
case 550: return new CityInfo("Plottier", "15", -38.96667, -68.23333);
case 551: return new CityInfo("Plaza Huincul", "15", -38.92598, -69.20863);
case 552: return new CityInfo("Piquillín", "05", -31.30158, -63.75788);
case 553: return new CityInfo("Pilcaniyeu", "16", -41.12288, -70.72152);
case 554: return new CityInfo("Pilar", "05", -31.6789, -63.87964);
case 555: return new CityInfo("Pigüé", "01", -37.60509, -62.40333);
case 556: return new CityInfo("Piedra del Águila", "15", -40.04811, -70.0741);
case 557: return new CityInfo("Picún Leufú", "15", -39.51614, -69.28765);
case 558: return new CityInfo("Pico Truncado", "20", -46.7949, -67.95731);
case 559: return new CityInfo("Perito Moreno", "20", -46.58995, -70.92975);
case 560: return new CityInfo("Pergamino", "01", -33.88995, -60.57357);
case 561: return new CityInfo("Pérez", "21", -32.99835, -60.76791);
case 562: return new CityInfo("Pellegrini", "01", -36.26584, -63.1655);
case 563: return new CityInfo("Pehuajó", "01", -35.81077, -61.8968);
case 564: return new CityInfo("Patquía", "12", -30.04681, -66.88231);
case 565: return new CityInfo("Paso de Indios", "04", -43.86225, -69.04603);
case 566: return new CityInfo("Pasco", "05", -32.74733, -63.34232);
case 567: return new CityInfo("Pascanas", "05", -33.1255, -63.04084);
case 568: return new CityInfo("Parera", "11", -35.146, -64.50089);
case 569: return new CityInfo("Paraná", "08", -31.73271, -60.52897);
case 570: return new CityInfo("Pampa de los Guanacos", "22", -26.23002, -61.83774);
case 571: return new CityInfo("Pampa del Infierno", "03", -26.50517, -61.17436);
case 572: return new CityInfo("Palpalá", "10", -24.25647, -65.21163);
case 573: return new CityInfo("Palma Sola", "10", -23.97771, -64.30311);
case 574: return new CityInfo("Oro Verde", "08", -31.82508, -60.51749);
case 575: return new CityInfo("Ordóñez", "05", -32.84057, -62.86552);
case 576: return new CityInfo("Oncativo", "05", -31.91353, -63.68201);
case 577: return new CityInfo("Olta", "12", -30.63117, -66.263);
case 578: return new CityInfo("Oliva", "05", -32.04158, -63.56978);
case 579: return new CityInfo("Olavarría", "01", -36.89272, -60.32254);
case 580: return new CityInfo("Obispo Trejo", "05", -30.78128, -63.41349);
case 581: return new CityInfo("Nueve de Julio", "01", -35.44437, -60.88313);
case 582: return new CityInfo("Nueve de Julio", "18", -31.66914, -68.39023);
case 583: return new CityInfo("Nueva Esperanza", "22", -26.19907, -64.23792);
case 584: return new CityInfo("Ñorquinco", "16", -41.85072, -70.90173);
case 585: return new CityInfo("Noetinger", "05", -32.36597, -62.31126);
case 586: return new CityInfo("Neuquén", "15", -38.95161, -68.0591);
case 587: return new CityInfo("Naschel", "19", -32.91656, -65.37535);
case 588: return new CityInfo("Napenay", "03", -26.73333, -60.61667);
case 589: return new CityInfo("Mutquín", "02", -28.32104, -66.14253);
case 590: return new CityInfo("Morteros", "05", -30.71164, -61.99862);
case 591: return new CityInfo("Morrison", "05", -32.5948, -62.83455);
case 592: return new CityInfo("Monteros", "24", -27.16741, -65.49832);
case 593: return new CityInfo("Monte Quemado", "22", -25.80565, -62.83019);
case 594: return new CityInfo("Monte Maíz", "05", -33.20462, -62.60085);
case 595: return new CityInfo("Monte Hermoso", "01", -38.9825, -61.29472);
case 596: return new CityInfo("Monte Cristo", "05", -31.34312, -63.94437);
case 597: return new CityInfo("Monte Buey", "05", -32.91642, -62.45669);
case 598: return new CityInfo("Molinos", "17", -25.43935, -66.29412);
case 599: return new CityInfo("Miramar", "05", -30.91859, -62.67814);
case 600: return new CityInfo("Mina Clavero", "05", -31.72101, -65.00619);
case 601: return new CityInfo("Milagro", "12", -31.00831, -65.99103);
case 602: return new CityInfo("Miguel Riglos", "11", -36.85398, -63.68842);
case 603: return new CityInfo("Metán", "17", -25.49905, -64.97388);
case 604: return new CityInfo("Merlo", "19", -32.34288, -65.01396);
case 605: return new CityInfo("Mendoza", "13", -32.89084, -68.82717);
case 606: return new CityInfo("Mendiolaza", "05", -31.26738, -64.30087);
case 607: return new CityInfo("Melincué", "21", -33.65847, -61.45459);
case 608: return new CityInfo("Médanos", "01", -38.82803, -62.69355);
case 609: return new CityInfo("Mattaldi", "05", -34.48194, -64.17255);
case 610: return new CityInfo("Marull", "05", -30.99471, -62.82576);
case 611: return new CityInfo("Mariano Moreno", "15", -38.75029, -70.02367);
case 612: return new CityInfo("Marcos Juárez", "05", -32.6978, -62.10672);
case 613: return new CityInfo("Maquinchao", "16", -41.24912, -68.70321);
case 614: return new CityInfo("Malvinas Argentinas", "05", -31.38194, -64.05545);
case 615: return new CityInfo("Malargüe", "13", -35.47545, -69.58427);
case 616: return new CityInfo("Malanzán", "12", -30.80394, -66.60908);
case 617: return new CityInfo("Malagueño", "05", -31.46467, -64.3584);
case 618: return new CityInfo("Maipú", "13", -32.97963, -68.78461);
case 619: return new CityInfo("Mainque", "16", -39.06667, -67.3);
case 620: return new CityInfo("Maimará", "10", -23.62392, -65.40797);
case 621: return new CityInfo("Machagai", "03", -26.92614, -60.04955);
case 622: return new CityInfo("Macachín", "11", -37.13598, -63.6665);
case 623: return new CityInfo("San Isidro de Lules", "24", -26.9277, -65.33869);
case 624: return new CityInfo("Luján de Cuyo", "13", -33.03547, -68.87782);
case 625: return new CityInfo("Luján", "19", -32.36674, -65.93642);
case 626: return new CityInfo("Los Varela", "02", -27.93003, -65.87153);
case 627: return new CityInfo("Los Telares", "22", -28.98479, -63.44889);
case 628: return new CityInfo("Los Surgentes", "05", -32.98454, -62.02191);
case 629: return new CityInfo("Los Menucos", "16", -40.84402, -68.08718);
case 630: return new CityInfo("Los Juríes", "22", -28.46539, -62.10862);
case 631: return new CityInfo("Los Frentones", "03", -26.4077, -61.41367);
case 632: return new CityInfo("Los Cóndores", "05", -32.31983, -64.27751);
case 633: return new CityInfo("Los Cocos", "05", -30.92497, -64.50207);
case 634: return new CityInfo("Los Antiguos", "20", -46.54972, -71.63086);
case 635: return new CityInfo("Los Altos", "02", -28.04845, -65.49945);
case 636: return new CityInfo("Lonquimay", "11", -36.46546, -63.62429);
case 637: return new CityInfo("Londres", "02", -27.71439, -67.13349);
case 638: return new CityInfo("Loncopué", "15", -38.07284, -70.61609);
case 639: return new CityInfo("Lincoln", "01", -34.86649, -61.5302);
case 640: return new CityInfo("Limay Mahuida", "11", -37.15966, -66.67436);
case 641: return new CityInfo("Libertador General San Martín", "19", -32.41074, -65.67586);
case 642: return new CityInfo("Libertador General San Martín", "10", -23.80644, -64.78757);
case 643: return new CityInfo("Leones", "05", -32.66174, -62.29678);
case 644: return new CityInfo("Leleque", "04", -42.41225, -71.06797);
case 645: return new CityInfo("La Viña", "17", -25.46642, -65.5663);
case 646: return new CityInfo("La Toma", "19", -33.05258, -65.62385);
case 647: return new CityInfo("La Tigra", "03", -27.10996, -60.58719);
case 648: return new CityInfo("Las Varillas", "05", -31.87208, -62.71946);
case 649: return new CityInfo("Las Varas", "05", -31.8026, -62.61655);
case 650: return new CityInfo("Las Rosas", "21", -32.47661, -61.58041);
case 651: return new CityInfo("Las Plumas", "04", -43.72058, -67.28319);
case 652: return new CityInfo("Las Perdices", "05", -32.69794, -63.70634);
case 653: return new CityInfo("Las Parejas", "21", -32.68478, -61.51637);
case 654: return new CityInfo("Las Ovejas", "15", -36.98881, -70.74991);
case 655: return new CityInfo("Las Lomitas", "09", -24.70955, -60.59303);
case 656: return new CityInfo("Las Lajitas", "17", -24.72762, -64.19335);
case 657: return new CityInfo("Las Lajas", "15", -38.52322, -70.36745);
case 658: return new CityInfo("Las Junturas", "05", -31.83125, -63.45016);
case 659: return new CityInfo("Las Higueras", "05", -33.09231, -64.28899);
case 660: return new CityInfo("Las Heras", "20", -46.54186, -68.93593);
case 661: return new CityInfo("Las Heras", "13", -32.85273, -68.82837);
case 662: return new CityInfo("Las Coloradas", "15", -39.55534, -70.59491);
case 663: return new CityInfo("Las Breñas", "03", -27.08966, -61.08161);
case 664: return new CityInfo("Las Acequias", "05", -33.28155, -63.9761);
case 665: return new CityInfo("La Rioja", "12", -29.41105, -66.85067);
case 666: return new CityInfo("La Quiaca", "10", -22.10236, -65.59299);
case 667: return new CityInfo("La Puerta de San José", "02", -27.55, -67.01667);
case 668: return new CityInfo("La Puerta", "02", -28.17036, -65.79015);
case 669: return new CityInfo("Laprida", "01", -37.54415, -60.79969);
case 670: return new CityInfo("La Poma", "17", -24.72196, -66.20106);
case 671: return new CityInfo("La Playosa", "05", -32.10002, -63.03088);
case 672: return new CityInfo("La Paz", "13", -33.46091, -67.54956);
case 673: return new CityInfo("La Para", "05", -30.89416, -63.00107);
case 674: return new CityInfo("La Merced", "02", -28.15195, -65.66029);
case 675: return new CityInfo("La Mendieta", "10", -24.31187, -64.96377);
case 676: return new CityInfo("La Maruja", "11", -35.6736, -64.93997);
case 677: return new CityInfo("Lamarque", "16", -39.42304, -65.70208);
case 678: return new CityInfo("La Humada", "11", -36.34905, -68.01356);
case 679: return new CityInfo("Laguna Yema", "09", -24.25391, -61.24466);
case 680: return new CityInfo("Laguna Paiva", "21", -31.30391, -60.65894);
case 681: return new CityInfo("Laguna Larga", "05", -31.77652, -63.80104);
case 682: return new CityInfo("La Granja", "05", -31.00919, -64.26869);
case 683: return new CityInfo("Lago Puelo", "04", -42.06684, -71.60384);
case 684: return new CityInfo("La Francia", "05", -31.40675, -62.63396);
case 685: return new CityInfo("La Falda", "05", -31.08841, -64.48987);
case 686: return new CityInfo("La Cumbre", "05", -30.98201, -64.49139);
case 687: return new CityInfo("La Consulta", "13", -33.73579, -69.12181);
case 688: return new CityInfo("La Cocha", "24", -27.76927, -65.58711);
case 689: return new CityInfo("La Clotilde", "03", -27.13333, -60.66667);
case 690: return new CityInfo("La Cesira", "05", -33.95115, -62.97238);
case 691: return new CityInfo("La Carlota", "05", -33.41993, -63.29769);
case 692: return new CityInfo("La Candelaria", "17", -26.12708, -65.0496);
case 693: return new CityInfo("La Cañada", "22", -27.70826, -63.77366);
case 694: return new CityInfo("La Calera", "05", -31.34377, -64.33529);
case 695: return new CityInfo("La Caldera", "17", -24.60477, -65.38181);
case 696: return new CityInfo("Laboulaye", "05", -34.12662, -63.39119);
case 697: return new CityInfo("Laborde", "05", -33.15319, -62.85661);
case 698: return new CityInfo("La Banda", "22", -27.73348, -64.24278);
case 699: return new CityInfo("Justo Daract", "19", -33.8594, -65.18277);
case 700: return new CityInfo("Justiniano Posse", "05", -32.88411, -62.67788);
case 701: return new CityInfo("Junín de los Andes", "15", -39.95043, -71.06936);
case 702: return new CityInfo("Junín", "01", -34.58382, -60.94332);
case 703: return new CityInfo("Junín", "13", -33.14765, -68.47899);
case 704: return new CityInfo("José de San Martín", "04", -44.05032, -70.46967);
case 705: return new CityInfo("Joaquín V. González", "17", -25.11364, -64.12628);
case 706: return new CityInfo("Jesús María", "05", -30.98153, -64.09424);
case 707: return new CityInfo("James Craik", "05", -32.1612, -63.46688);
case 708: return new CityInfo("Jacinto Arauz", "11", -38.08606, -63.43169);
case 709: return new CityInfo("Italó", "05", -34.79237, -63.78199);
case 710: return new CityInfo("Isla Verde", "05", -33.24104, -62.40297);
case 711: return new CityInfo("Iruya", "17", -22.79189, -65.21703);
case 712: return new CityInfo("Intendente Alvear", "11", -35.23383, -63.59205);
case 713: return new CityInfo("Inriville", "05", -32.94424, -62.23028);
case 714: return new CityInfo("Ingenio La Esperanza", "10", -24.22554, -64.83896);
case 715: return new CityInfo("Ingeniero Luis A. Huergo", "16", -39.07146, -67.2379);
case 716: return new CityInfo("Ingeniero Luiggi", "11", -35.38585, -64.46519);
case 717: return new CityInfo("Ingeniero Jacobacci", "16", -41.3292, -69.55015);
case 718: return new CityInfo("Ingeniero Guillermo N. Juárez", "09", -23.9, -61.85);
case 719: return new CityInfo("Idiazábal", "05", -32.81411, -63.03252);
case 720: return new CityInfo("Icaño", "02", -28.91934, -65.32817);
case 721: return new CityInfo("Humahuaca", "10", -23.20544, -65.35048);
case 722: return new CityInfo("Huinca Renancó", "05", -34.84038, -64.3758);
case 723: return new CityInfo("Huillapima", "02", -28.72533, -65.9787);
case 724: return new CityInfo("Huerta Grande", "05", -31.07524, -64.49063);
case 725: return new CityInfo("Huanchillas", "05", -33.66653, -63.63701);
case 726: return new CityInfo("Hualfín", "02", -27.22896, -66.83131);
case 727: return new CityInfo("Hoyo de Epuyén", "04", -42.07189, -71.50811);
case 728: return new CityInfo("Hersilia", "21", -30.00447, -61.8408);
case 729: return new CityInfo("Herrera", "22", -28.48094, -63.06779);
case 730: return new CityInfo("Hernando", "05", -32.42657, -63.73333);
case 731: return new CityInfo("Hernández", "08", -32.3373, -60.0216);
case 732: return new CityInfo("Hermoso Campo", "03", -27.60816, -61.34441);
case 733: return new CityInfo("Henderson", "01", -36.3, -61.71667);
case 734: return new CityInfo("Helvecia", "21", -31.09834, -60.0883);
case 735: return new CityInfo("Guatraché", "11", -37.66776, -63.53021);
case 736: return new CityInfo("Guatimozín", "05", -33.46149, -62.43844);
case 737: return new CityInfo("Guaminí", "01", -37.01381, -62.41858);
case 738: return new CityInfo("Guachipas", "17", -25.52031, -65.50937);
case 739: return new CityInfo("Graneros", "24", -27.64934, -65.4383);
case 740: return new CityInfo("Granadero Baigorria", "21", -32.85683, -60.71754);
case 741: return new CityInfo("Godoy Cruz", "13", -32.92863, -68.8351);
case 742: return new CityInfo("Gobernador Gregores", "20", -48.75057, -70.24741);
case 743: return new CityInfo("Gobernador Gálvez", "21", -33.03016, -60.64045);
case 744: return new CityInfo("Gobernador Costa", "04", -44.04992, -70.59798);
case 745: return new CityInfo("General Villegas", "01", -35.03285, -63.01252);
case 746: return new CityInfo("General Viamonte", "01", -35.00014, -61.03508);
case 747: return new CityInfo("General San Martín", "11", -37.97904, -63.60449);
case 748: return new CityInfo("General Roca", "16", -39.03333, -67.58333);
case 749: return new CityInfo("General Roca", "05", -32.73196, -61.91599);
case 750: return new CityInfo("General Ramírez", "08", -32.17601, -60.20079);
case 751: return new CityInfo("General Pinto", "01", -34.76459, -61.89093);
case 752: return new CityInfo("General Pinedo", "03", -27.31667, -61.28333);
case 753: return new CityInfo("General Pico", "11", -35.65662, -63.75682);
case 754: return new CityInfo("General Martín Miguel de Güemes", "17", -24.67034, -65.04765);
case 755: return new CityInfo("General Manuel J. Campos", "11", -37.46025, -63.58537);
case 756: return new CityInfo("General Levalle", "05", -34.01472, -63.92413);
case 757: return new CityInfo("General Lavalle", "13", -32.72218, -68.59137);
case 758: return new CityInfo("General La Madrid", "01", -37.24755, -61.26273);
case 759: return new CityInfo("General Fernández Oro", "16", -38.95297, -67.92489);
case 760: return new CityInfo("General Enrique Mosconi", "09", -23.21667, -62.3);
case 761: return new CityInfo("General Enrique Mosconi", "17", -22.59588, -63.81255);
case 762: return new CityInfo("General Enrique Godoy", "16", -39.07891, -67.15807);
case 763: return new CityInfo("General Conesa", "16", -40.10408, -64.45592);
case 764: return new CityInfo("General Cabrera", "05", -32.81313, -63.87243);
case 765: return new CityInfo("General Baldissera", "05", -33.12246, -62.3063);
case 766: return new CityInfo("General Arenales", "01", -34.30264, -61.30522);
case 767: return new CityInfo("General Alvear", "01", -36.02078, -60.0145);
case 768: return new CityInfo("General Alvear", "13", -34.97696, -67.69116);
case 769: return new CityInfo("General Acha", "11", -37.37698, -64.60431);
case 770: return new CityInfo("Gastre", "04", -42.26186, -69.22112);
case 771: return new CityInfo("Garza", "22", -28.15321, -63.53935);
case 772: return new CityInfo("Gancedo", "03", -27.49038, -61.67571);
case 773: return new CityInfo("Gálvez", "21", -32.02927, -61.22103);
case 774: return new CityInfo("Gaimán", "04", -43.2897, -65.4929);
case 775: return new CityInfo("Funes", "21", -32.91568, -60.80995);
case 776: return new CityInfo("Frías", "22", -28.63593, -65.13102);
case 777: return new CityInfo("Fray Luis Beltrán", "16", -39.31369, -65.76002);
case 778: return new CityInfo("Fray Luis A. Beltrán", "21", -32.79122, -60.72819);
case 779: return new CityInfo("Fraile Pintado", "10", -23.94079, -64.79943);
case 780: return new CityInfo("Firmat", "21", -33.45937, -61.4832);
case 781: return new CityInfo("Fiambalá", "02", -27.67225, -67.6187);
case 782: return new CityInfo("Fernández", "22", -27.92037, -63.89349);
case 783: return new CityInfo("Famatina", "12", -28.92264, -67.52016);
case 784: return new CityInfo("Famaillá", "24", -27.05413, -65.40329);
case 785: return new CityInfo("Etruria", "05", -32.94008, -63.2466);
case 786: return new CityInfo("Estanislao del Campo", "09", -25.05504, -60.09218);
case 787: return new CityInfo("Esquel", "04", -42.91147, -71.31947);
case 788: return new CityInfo("Esperanza", "21", -31.4488, -60.93173);
case 789: return new CityInfo("Embarcación", "17", -23.21003, -64.09965);
case 790: return new CityInfo("Embalse", "05", -32.18, -64.41809);
case 791: return new CityInfo("Embajador Martini", "11", -35.38633, -64.28092);
case 792: return new CityInfo("El Trébol", "21", -32.2008, -61.7014);
case 793: return new CityInfo("El Tío", "05", -31.38357, -62.82938);
case 794: return new CityInfo("El Simbolar", "22", -27.97167, -64.89544);
case 795: return new CityInfo("El Rodeo", "02", -28.21518, -65.8742);
case 796: return new CityInfo("El Quebrachal", "17", -25.28333, -64.06667);
case 797: return new CityInfo("El Maitén", "04", -42.04924, -71.16693);
case 798: return new CityInfo("El Huecú", "15", -37.64522, -70.58006);
case 799: return new CityInfo("El Hoyo", "22", -27.02872, -63.23197);
case 800: return new CityInfo("El Galpón", "17", -25.38069, -64.65259);
case 801: return new CityInfo("Elena", "05", -32.57205, -64.39481);
case 802: return new CityInfo("El Cuy", "16", -39.92685, -68.34208);
case 803: return new CityInfo("El Carril", "17", -25.0741, -65.49174);
case 804: return new CityInfo("El Carmen", "10", -24.38682, -65.26177);
case 805: return new CityInfo("El Calafate", "20", -50.34075, -72.27682);
case 806: return new CityInfo("El Bolsón", "16", -41.96051, -71.53336);
case 807: return new CityInfo("El Arañado", "05", -31.7412, -62.89322);
case 808: return new CityInfo("El Alto", "02", -28.31123, -65.36397);
case 809: return new CityInfo("El Aguilar", "10", -23.21572, -65.68005);
case 810: return new CityInfo("Eduardo Castex", "11", -35.91501, -64.29448);
case 811: return new CityInfo("Dolavón", "04", -43.30684, -65.70651);
case 812: return new CityInfo("Doblas", "11", -37.14967, -64.01183);
case 813: return new CityInfo("Diamante", "08", -32.06641, -60.63837);
case 814: return new CityInfo("Devoto", "05", -31.40431, -62.30634);
case 815: return new CityInfo("Despeñaderos", "05", -31.81626, -64.28989);
case 816: return new CityInfo("Del Campillo", "05", -34.37659, -64.49504);
case 817: return new CityInfo("Deán Funes", "05", -30.42036, -64.34984);
case 818: return new CityInfo("Darwin", "16", -39.20334, -65.73952);
case 819: return new CityInfo("Dalmacio Vélez Sársfield", "05", -32.61072, -63.58038);
case 820: return new CityInfo("Daireaux", "01", -36.6, -61.75);
case 821: return new CityInfo("Cutral-Có", "15", -38.93424, -69.23052);
case 822: return new CityInfo("Cuchillo Có", "11", -38.33349, -64.64331);
case 823: return new CityInfo("Cruz del Eje", "05", -30.72644, -64.80387);
case 824: return new CityInfo("Cruz Alta", "05", -33.00887, -61.80746);
case 825: return new CityInfo("Crespo", "08", -32.02873, -60.30658);
case 826: return new CityInfo("Costa Sacate", "05", -31.6477, -63.75935);
case 827: return new CityInfo("Cosquín", "05", -31.24508, -64.46563);
case 828: return new CityInfo("Corzuela", "03", -26.95374, -60.96928);
case 829: return new CityInfo("Corralito", "05", -32.02462, -64.19216);
case 830: return new CityInfo("Corral de Bustos", "05", -33.28205, -62.18463);
case 831: return new CityInfo("Coronel Suárez", "01", -37.45467, -61.93343);
case 832: return new CityInfo("Coronel Pringles", "01", -37.98295, -61.35615);
case 833: return new CityInfo("Coronel Moldes", "05", -33.6227, -64.59711);
case 834: return new CityInfo("Coronel Du Graty", "03", -27.68038, -60.91462);
case 835: return new CityInfo("Coronel Dorrego", "01", -38.71867, -61.28733);
case 836: return new CityInfo("Coronel Belisle", "16", -39.18688, -65.95422);
case 837: return new CityInfo("Coronel Baigorria", "05", -32.8477, -64.36107);
case 838: return new CityInfo("Coronda", "21", -31.97263, -60.91983);
case 839: return new CityInfo("Córdoba", "05", -31.4135, -64.18105);
case 840: return new CityInfo("Contraalmirante Cordero", "16", -38.72423, -68.15284);
case 841: return new CityInfo("Concepción del Bermejo", "03", -26.59926, -60.94617);
case 842: return new CityInfo("Concepción", "24", -27.34127, -65.59636);
case 843: return new CityInfo("Concarán", "19", -32.56009, -65.2427);
case 844: return new CityInfo("Comodoro Rivadavia", "04", -45.86413, -67.49656);
case 845: return new CityInfo("Comandante Luis Piedra Buena", "20", -49.98513, -68.91467);
case 846: return new CityInfo("Comallo", "16", -41.02993, -70.26784);
case 847: return new CityInfo("Colonia San Bartolomé", "05", -31.5278, -62.72436);
case 848: return new CityInfo("Colonia La Tordilla", "05", -31.23746, -63.06134);
case 849: return new CityInfo("Colonia La Brava", "21", -30.445, -60.14);
case 850: return new CityInfo("Colonia Dora", "22", -28.6, -62.95);
case 851: return new CityInfo("Colonia Barón", "11", -36.15152, -63.85404);
case 852: return new CityInfo("Colón", "01", -33.89512, -61.1011);
case 853: return new CityInfo("Clodomira", "22", -27.5744, -64.13108);
case 854: return new CityInfo("Cipolletti", "16", -38.93392, -67.99032);
case 855: return new CityInfo("Cintra", "05", -32.30673, -62.65214);
case 856: return new CityInfo("Cinco Saltos", "16", -38.82225, -68.06293);
case 857: return new CityInfo("Chumbicha", "02", -28.8543, -66.235);
case 858: return new CityInfo("Chos Malal", "15", -37.37809, -70.27085);
case 859: return new CityInfo("Chorotis", "03", -27.91578, -61.39982);
case 860: return new CityInfo("Choele Choel", "16", -39.28941, -65.6606);
case 861: return new CityInfo("Chivilcoy", "01", -34.89566, -60.01667);
case 862: return new CityInfo("Chimpay", "16", -39.16482, -66.14236);
case 863: return new CityInfo("Chimbas", "18", -31.48333, -68.53333);
case 864: return new CityInfo("Chilecito", "12", -29.16195, -67.4974);
case 865: return new CityInfo("Chicoana", "17", -25.10502, -65.53473);
case 866: return new CityInfo("Chichinales", "16", -39.11505, -66.92714);
case 867: return new CityInfo("Chepes", "12", -31.34363, -66.58894);
case 868: return new CityInfo("Chazón", "05", -33.07872, -63.27657);
case 869: return new CityInfo("Charras", "05", -33.024, -64.04719);
case 870: return new CityInfo("Charata", "03", -27.21438, -61.18795);
case 871: return new CityInfo("Chamical", "12", -30.36002, -66.31399);
case 872: return new CityInfo("Chacabuco", "01", -34.64167, -60.47389);
case 873: return new CityInfo("Cervantes", "16", -39.05444, -67.39426);
case 874: return new CityInfo("Cerrillos", "17", -24.89833, -65.48706);
case 875: return new CityInfo("Ceres", "21", -29.881, -61.94504);
case 876: return new CityInfo("Centenario", "15", -38.82955, -68.1318);
case 877: return new CityInfo("Cavanagh", "05", -33.47606, -62.33888);
case 878: return new CityInfo("Caucete", "18", -31.65179, -68.28105);
case 879: return new CityInfo("Catriló", "11", -36.40597, -63.42168);
case 880: return new CityInfo("Catriel", "16", -37.87907, -67.7956);
case 881: return new CityInfo("Castro Barros", "12", -30.57952, -65.72696);
case 882: return new CityInfo("Castelli", "03", -25.94679, -60.61947);
case 883: return new CityInfo("Casilda", "21", -33.04417, -61.16806);
case 884: return new CityInfo("Carrilobo", "05", -31.87296, -63.11715);
case 885: return new CityInfo("Carnerillo", "05", -32.91371, -64.02175);
case 886: return new CityInfo("Carmen de Patagones", "01", -40.79828, -62.98097);
case 887: return new CityInfo("Carlos Tejedor", "01", -35.39265, -62.42146);
case 888: return new CityInfo("Carlos Casares", "01", -35.62171, -61.36169);
case 889: return new CityInfo("Carhué", "01", -37.17668, -62.75792);
case 890: return new CityInfo("Carcarañá", "21", -32.85679, -61.15331);
case 891: return new CityInfo("Capitán Bermúdez", "21", -32.82262, -60.71852);
case 892: return new CityInfo("Capilla del Monte", "05", -30.86088, -64.52515);
case 893: return new CityInfo("Capayán", "02", -28.77436, -66.04749);
case 894: return new CityInfo("Candelaria", "19", -32.06036, -65.82477);
case 895: return new CityInfo("Canals", "05", -33.56542, -62.88927);
case 896: return new CityInfo("Cañada de Luque", "05", -30.73341, -63.72375);
case 897: return new CityInfo("Cañada de Gómez", "21", -32.81636, -61.39493);
case 898: return new CityInfo("Campo Quijano", "17", -24.90982, -65.63656);
case 899: return new CityInfo("Campo Largo", "03", -26.80077, -60.84215);
case 900: return new CityInfo("Campo Gallo", "22", -26.58333, -62.85);
case 901: return new CityInfo("Camilo Aldao", "05", -33.12745, -62.09453);
case 902: return new CityInfo("Camarones", "04", -44.79709, -65.70994);
case 903: return new CityInfo("Calingasta", "18", -31.33394, -69.4208);
case 904: return new CityInfo("Calilegua", "10", -23.77368, -64.77002);
case 905: return new CityInfo("Caleufú", "11", -35.59559, -64.55778);
case 906: return new CityInfo("Caleta Olivia", "20", -46.43929, -67.52814);
case 907: return new CityInfo("Calchaquí", "21", -29.88767, -60.28697);
case 908: return new CityInfo("Caimancito", "10", -23.74069, -64.5937);
case 909: return new CityInfo("Cafayate", "17", -26.07286, -65.97766);
case 910: return new CityInfo("Cachí", "17", -25.12033, -66.16519);
case 911: return new CityInfo("Buta Ranquil", "15", -37.05222, -69.87713);
case 912: return new CityInfo("Burruyacú", "24", -26.49918, -64.74206);
case 913: return new CityInfo("Buena Esperanza", "19", -34.75647, -65.25379);
case 914: return new CityInfo("Buchardo", "05", -34.72263, -63.5092);
case 915: return new CityInfo("Brinkmann", "05", -30.86589, -62.03742);
case 916: return new CityInfo("Brea Pozo", "22", -28.24382, -63.95091);
case 917: return new CityInfo("Bragado", "01", -35.11912, -60.48966);
case 918: return new CityInfo("Berrotarán", "05", -32.451, -64.38867);
case 919: return new CityInfo("Bernasconi", "11", -37.90459, -63.7424);
case 920: return new CityInfo("Bernardo Larroudé", "11", -35.02449, -63.58253);
case 921: return new CityInfo("Beltrán", "22", -27.82913, -64.06098);
case 922: return new CityInfo("Bell Ville", "05", -32.62591, -62.68873);
case 923: return new CityInfo("Bella Vista", "24", -27.03424, -65.30196);
case 924: return new CityInfo("Belén", "02", -27.65103, -67.02869);
case 925: return new CityInfo("Barrancas", "15", -36.82344, -69.91564);
case 926: return new CityInfo("Bandera", "22", -28.8884, -62.266);
case 927: return new CityInfo("Banda del Río Salí", "24", -26.83333, -65.16667);
case 928: return new CityInfo("Bañado de Ovanta", "02", -28.10564, -65.31884);
case 929: return new CityInfo("Balnearia", "05", -31.0088, -62.66733);
case 930: return new CityInfo("Bahía Blanca", "01", -38.71959, -62.27243);
case 931: return new CityInfo("Aviá Terai", "03", -26.68532, -60.7292);
case 932: return new CityInfo("Ataliva Roca", "11", -37.03147, -64.28426);
case 933: return new CityInfo("Arrufó", "21", -30.23281, -61.72862);
case 934: return new CityInfo("Arroyo Seco", "21", -33.15489, -60.50863);
case 935: return new CityInfo("Arroyo Cabral", "05", -32.49119, -63.40126);
case 936: return new CityInfo("Arroyito", "05", -31.42022, -63.05002);
case 937: return new CityInfo("Arrecifes", "01", -34.0639, -60.10357);
case 938: return new CityInfo("Arraga", "22", -28.04978, -64.22254);
case 939: return new CityInfo("Armstrong", "21", -32.78215, -61.60222);
case 940: return new CityInfo("Arias", "05", -33.64411, -62.40272);
case 941: return new CityInfo("Arauco", "12", -28.58071, -66.7925);
case 942: return new CityInfo("Arata", "11", -35.63895, -64.35621);
case 943: return new CityInfo("Aranguren", "08", -32.24252, -60.16107);
case 944: return new CityInfo("Apolinario Saravia", "17", -24.43276, -63.99535);
case 945: return new CityInfo("Antofagasta de la Sierra", "02", -26.0594, -67.40636);
case 946: return new CityInfo("Anguil", "11", -36.52567, -64.01025);
case 947: return new CityInfo("Añelo", "15", -38.35441, -68.7884);
case 948: return new CityInfo("Andalgalá", "02", -27.58185, -66.31626);
case 949: return new CityInfo("Andacollo", "15", -37.17945, -70.66912);
case 950: return new CityInfo("Ancasti", "02", -28.81247, -65.50145);
case 951: return new CityInfo("Añatuya", "22", -28.46064, -62.83472);
case 952: return new CityInfo("Aminga", "12", -28.84771, -66.93024);
case 953: return new CityInfo("Florentino Ameghino", "01", -34.84405, -62.46701);
case 954: return new CityInfo("Aluminé", "15", -39.23686, -70.9197);
case 955: return new CityInfo("Altos de Chipión", "05", -30.9559, -62.33727);
case 956: return new CityInfo("Alto Río Senguer", "04", -45.04105, -70.81982);
case 957: return new CityInfo("Alta Italia", "11", -35.3335, -64.11496);
case 958: return new CityInfo("Alta Gracia", "05", -31.65292, -64.42826);
case 959: return new CityInfo("Alpachiri", "11", -37.37704, -63.77445);
case 960: return new CityInfo("Almafuerte", "05", -32.19296, -64.25559);
case 961: return new CityInfo("Allen", "16", -38.97736, -67.82714);
case 962: return new CityInfo("Algarrobo del Águila", "11", -36.39968, -67.14511);
case 963: return new CityInfo("Alejo Ledesma", "05", -33.60643, -62.62304);
case 964: return new CityInfo("Alejandro Roca", "05", -33.35369, -63.71849);
case 965: return new CityInfo("Alderetes", "24", -26.81667, -65.13333);
case 966: return new CityInfo("Alberti", "01", -35.02692, -60.27587);
case 967: return new CityInfo("Albardón", "18", -31.43722, -68.52556);
case 968: return new CityInfo("Aimogasta", "12", -28.56091, -66.80588);
case 969: return new CityInfo("Aguilares", "24", -27.4338, -65.61427);
case 970: return new CityInfo("Agua de Oro", "05", -31.06661, -64.30017);
case 971: return new CityInfo("Adelia María", "05", -33.63152, -64.02097);
case 972: return new CityInfo("Achiras", "05", -33.17538, -64.99331);
case 973: return new CityInfo("Abra Pampa", "10", -22.72049, -65.69697);
case 974: return new CityInfo("El Chaltén", "20", -49.3299, -72.88605);
case 975: return new CityInfo("Balvanera", "07", -34.61032, -58.39766);
case 976: return new CityInfo("Villa Santa Rita", "07", -34.61082, -58.481);
case 977: return new CityInfo("Bella Italia", "21", -31.28182, -61.41092);
case 978: return new CityInfo("La Cumbrecita", "05", -31.89882, -64.77331);
case 979: return new CityInfo("Cariló", "01", -37.16524, -56.89133);
case 980: return new CityInfo("Villa Mercedes", "19", -33.67571, -65.45783);
case 981: return new CityInfo("La Punta", "19", -33.18368, -66.3127);
case 982: return new CityInfo("Villa Berna", "05", -31.91419, -64.73249);
case 983: return new CityInfo("Mar de las Pampas", "01", -37.32512, -57.02179);
case 984: return new CityInfo("Cuesta Blanca", "05", -31.48658, -64.5715);
case 985: return new CityInfo("Avellaneda", "01", -34.66018, -58.36744);
case 986: return new CityInfo("San Miguel", "01", -34.54335, -58.71229);
case 987: return new CityInfo("San Carlos de Bariloche", "16", -41.14557, -71.30822);
case 988: return new CityInfo("Santa Catalina - Dique Lujan", "01", -34.38375, -58.70673);
case 989: return new CityInfo("Río Turbio", "20", -51.53587, -72.33673);
case 990: return new CityInfo("Adrogué", "01", -34.80041, -58.38384);
case 991: return new CityInfo("Los Laureles", "21", -29.36847, -59.73634);
case 992: return new CityInfo("Gato Colorado", "21", -28.02219, -61.18663);
case 993: return new CityInfo("Tolhuin", "23", -54.51083, -67.1955);
case 994: return new CityInfo("Villa General Guemes", "09", -24.7553, -59.4894);
case 995: return new CityInfo("Ingeniero Pablo Nogués", "01", -34.47775, -58.70652);
case 996: return new CityInfo("Rincón de Los Sauces", "15", -37.39844, -68.92874);
case 997: return new CityInfo("La Adela", "11", -38.98333, -64.08333);
default: return new CityInfo("José C. Paz", "01", -34.51541, -58.76813);

                                    }                                        
                                }
                            
                        }
                    }
                