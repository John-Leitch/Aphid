
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
                                    public const string Country = "CL";
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
                            
                                        var cur = (Math.Abs(-37.0982 - lat) + Math.Abs(-72.56084 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-33.02457 - lat) + Math.Abs(-71.55183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.28569 - lat) + Math.Abs(-72.2279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.04222 - lat) + Math.Abs(-71.37333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.66875 - lat) + Math.Abs(-72.22565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.03541 - lat) + Math.Abs(-70.71274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.23291 - lat) + Math.Abs(-72.33292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.036 - lat) + Math.Abs(-71.62963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.57617 - lat) + Math.Abs(-70.75938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.81422 - lat) + Math.Abs(-73.24589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.2496 - lat) + Math.Abs(-72.67027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.61756 - lat) + Math.Abs(-72.95593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.09198 - lat) + Math.Abs(-70.19792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.87055 - lat) + Math.Abs(-71.16219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.73965 - lat) + Math.Abs(-72.59842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.40713 - lat) + Math.Abs(-70.48554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.72494 - lat) + Math.Abs(-73.11684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.4264 - lat) + Math.Abs(-71.65542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.66386 - lat) + Math.Abs(-70.92734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.43859 - lat) + Math.Abs(-71.07751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.43333 - lat) + Math.Abs(-71.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.45694 - lat) + Math.Abs(-70.64827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.63881 - lat) + Math.Abs(-71.36576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.9111 - lat) + Math.Abs(-68.20113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.5952 - lat) + Math.Abs(-71.72924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.74976 - lat) + Math.Abs(-70.72584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.53777 - lat) + Math.Abs(-71.487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.42477 - lat) + Math.Abs(-71.958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.59217 - lat) + Math.Abs(-70.6996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.59473 - lat) + Math.Abs(-71.60746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.77922 - lat) + Math.Abs(-70.96389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.33494 - lat) + Math.Abs(-72.95564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.40639 - lat) + Math.Abs(-70.85834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.92546 - lat) + Math.Abs(-71.31722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.17083 - lat) + Math.Abs(-70.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.27998 - lat) + Math.Abs(-72.54118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.04752 - lat) + Math.Abs(-71.44249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.88341 - lat) + Math.Abs(-71.24882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.65944 - lat) + Math.Abs(-72.60172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.19821 - lat) + Math.Abs(-69.56071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.91305 - lat) + Math.Abs(-73.15913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-53.15483 - lat) + Math.Abs(-70.91129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-54.93355 - lat) + Math.Abs(-67.60963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.31946 - lat) + Math.Abs(-72.98538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.11819 - lat) + Math.Abs(-73.61661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-51.72987 - lat) + Math.Abs(-72.50603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.4693 - lat) + Math.Abs(-72.94237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.74736 - lat) + Math.Abs(-72.69695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.40303 - lat) + Math.Abs(-72.69184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.61169 - lat) + Math.Abs(-70.57577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.28223 - lat) + Math.Abs(-71.95427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.43107 - lat) + Math.Abs(-70.60454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25585 - lat) + Math.Abs(-69.7863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-53.296 - lat) + Math.Abs(-70.36629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.98635 - lat) + Math.Abs(-72.63721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.49128 - lat) + Math.Abs(-69.33118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.74075 - lat) + Math.Abs(-72.99528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.60627 - lat) + Math.Abs(-70.87649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.14311 - lat) + Math.Abs(-71.82605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.64355 - lat) + Math.Abs(-72.33269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.61876 - lat) + Math.Abs(-71.80434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.80796 - lat) + Math.Abs(-70.74109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.60106 - lat) + Math.Abs(-71.19901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.57395 - lat) + Math.Abs(-73.13348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.74451 - lat) + Math.Abs(-72.95025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.50253 - lat) + Math.Abs(-72.67307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.71893 - lat) + Math.Abs(-72.24099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.69496 - lat) + Math.Abs(-70.9577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.11428 - lat) + Math.Abs(-71.28232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.68909 - lat) + Math.Abs(-71.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.18082 - lat) + Math.Abs(-70.64933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.08994 - lat) + Math.Abs(-73.1577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.46973 - lat) + Math.Abs(-72.35366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.83369 - lat) + Math.Abs(-70.59827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.96496 - lat) + Math.Abs(-71.6836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.36708 - lat) + Math.Abs(-72.63087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.84043 - lat) + Math.Abs(-70.95623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.84667 - lat) + Math.Abs(-71.59308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.01667 - lat) + Math.Abs(-71.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.60825 - lat) + Math.Abs(-73.65356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.53066 - lat) + Math.Abs(-72.43652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.29313 - lat) + Math.Abs(-73.08167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.90453 - lat) + Math.Abs(-71.24894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.2863 - lat) + Math.Abs(-70.87561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.45242 - lat) + Math.Abs(-71.23106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.28415 - lat) + Math.Abs(-72.71105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.20746 - lat) + Math.Abs(-72.5384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21326 - lat) + Math.Abs(-70.15027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.63349 - lat) + Math.Abs(-71.16967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.78333 - lat) + Math.Abs(-71.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.06863 - lat) + Math.Abs(-70.72747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.18492 - lat) + Math.Abs(-71.86722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.95252 - lat) + Math.Abs(-72.62653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.45 - lat) + Math.Abs(-71.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.67969 - lat) + Math.Abs(-70.98482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.36667 - lat) + Math.Abs(-70.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.37845 - lat) + Math.Abs(-73.65011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.98279 - lat) + Math.Abs(-71.23943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.47793 - lat) + Math.Abs(-73.34495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.8873 - lat) + Math.Abs(-73.43101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.03386 - lat) + Math.Abs(-73.14019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.95332 - lat) + Math.Abs(-71.33947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.36679 - lat) + Math.Abs(-70.3314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.33321 - lat) + Math.Abs(-72.41156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.82699 - lat) + Math.Abs(-73.04977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.95453 - lat) + Math.Abs(-72.43438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.20443 - lat) + Math.Abs(-70.67474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.69494 - lat) + Math.Abs(-71.40568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.62785 - lat) + Math.Abs(-71.83068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.57524 - lat) + Math.Abs(-72.06619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-47.2557 - lat) + Math.Abs(-72.5695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.62387 - lat) + Math.Abs(-73.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.71247 - lat) + Math.Abs(-71.0434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.60664 - lat) + Math.Abs(-72.10344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.541 - lat) + Math.Abs(-71.72375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.9256 - lat) + Math.Abs(-73.02841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.28379 - lat) + Math.Abs(-70.65333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.34298 - lat) + Math.Abs(-70.61648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.91596 - lat) + Math.Abs(-72.70632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.9671 - lat) + Math.Abs(-72.32248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.4721 - lat) + Math.Abs(-73.77319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.55384 - lat) + Math.Abs(-71.60761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.71122 - lat) + Math.Abs(-73.16101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.80128 - lat) + Math.Abs(-73.39616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-53.63988 - lat) + Math.Abs(-69.64693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.77338 - lat) + Math.Abs(-73.13049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.45667 - lat) + Math.Abs(-68.92371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.03394 - lat) + Math.Abs(-72.40468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.74232 - lat) + Math.Abs(-72.29854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.73257 - lat) + Math.Abs(-70.74281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.4746 - lat) + Math.Abs(-70.29792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.2463 - lat) + Math.Abs(-73.31752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.65236 - lat) + Math.Abs(-70.3954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.79519 - lat) + Math.Abs(-72.71636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.8707 - lat) + Math.Abs(-73.81622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.46667 - lat) + Math.Abs(-72.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.97434 - lat) + Math.Abs(-72.40554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.15253 - lat) + Math.Abs(-109.42438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.86653 - lat) + Math.Abs(-73.18834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.80867 - lat) + Math.Abs(-73.21821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.83892 - lat) + Math.Abs(-73.23538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.17625 - lat) + Math.Abs(-72.56058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.58331 - lat) + Math.Abs(-70.63419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.4443 - lat) + Math.Abs(-70.72552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.46069 - lat) + Math.Abs(-70.58024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.51576 - lat) + Math.Abs(-70.25551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yumbel", "06", -37.0982, -72.56084);
case 1: return new CityInfo("Viña del Mar", "01", -33.02457, -71.55183);
case 2: return new CityInfo("Villarrica", "04", -39.28569, -72.2279);
case 3: return new CityInfo("Villa Alemana", "01", -33.04222, -71.37333);
case 4: return new CityInfo("Vilcún", "04", -38.66875, -72.22565);
case 5: return new CityInfo("Vicuña", "07", -30.03541, -70.71274);
case 6: return new CityInfo("Victoria", "04", -38.23291, -72.33292);
case 7: return new CityInfo("Valparaíso", "01", -33.036, -71.62963);
case 8: return new CityInfo("Vallenar", "05", -28.57617, -70.75938);
case 9: return new CityInfo("Valdivia", "17", -39.81422, -73.24589);
case 10: return new CityInfo("Traiguén", "04", -38.2496, -72.67027);
case 11: return new CityInfo("Tomé", "06", -36.61756, -72.95593);
case 12: return new CityInfo("Tocopilla", "03", -22.09198, -70.19792);
case 13: return new CityInfo("Teno", "11", -34.87055, -71.16219);
case 14: return new CityInfo("Temuco", "04", -38.73965, -72.59842);
case 15: return new CityInfo("Taltal", "03", -25.40713, -70.48554);
case 16: return new CityInfo("Talcahuano", "06", -36.72494, -73.11684);
case 17: return new CityInfo("Talca", "11", -35.4264, -71.65542);
case 18: return new CityInfo("Talagante", "12", -33.66386, -70.92734);
case 19: return new CityInfo("San Vicente de Tagua Tagua", "08", -34.43859, -71.07751);
case 20: return new CityInfo("San Vicente", "08", -34.43333, -71.08333);
case 21: return new CityInfo("Santiago", "12", -33.45694, -70.64827);
case 22: return new CityInfo("Santa Cruz", "08", -34.63881, -71.36576);
case 23: return new CityInfo("San Pedro de Atacama", "03", -22.9111, -68.20113);
case 24: return new CityInfo("San Javier", "11", -35.5952, -71.72924);
case 25: return new CityInfo("San Felipe", "01", -32.74976, -70.72584);
case 26: return new CityInfo("San Clemente", "11", -35.53777, -71.487);
case 27: return new CityInfo("San Carlos", "18", -36.42477, -71.958);
case 28: return new CityInfo("San Bernardo", "12", -33.59217, -70.6996);
case 29: return new CityInfo("San Antonio", "01", -33.59473, -71.60746);
case 30: return new CityInfo("Salamanca", "07", -31.77922, -70.96389);
case 31: return new CityInfo("Río Bueno", "17", -40.33494, -72.95564);
case 32: return new CityInfo("Rengo", "08", -34.40639, -70.85834);
case 33: return new CityInfo("Rauco", "11", -34.92546, -71.31722);
case 34: return new CityInfo("Rancagua", "08", -34.17083, -70.74444);
case 35: return new CityInfo("Quirihue", "18", -36.27998, -72.54118);
case 36: return new CityInfo("Quilpué", "01", -33.04752, -71.44249);
case 37: return new CityInfo("Quillota", "01", -32.88341, -71.24882);
case 38: return new CityInfo("Puyehue", "17", -40.65944, -72.60172);
case 39: return new CityInfo("Putre", "16", -18.19821, -69.56071);
case 40: return new CityInfo("Purranque", "14", -40.91305, -73.15913);
case 41: return new CityInfo("Punta Arenas", "10", -53.15483, -70.91129);
case 42: return new CityInfo("Puerto Williams", "10", -54.93355, -67.60963);
case 43: return new CityInfo("Puerto Varas", "14", -41.31946, -72.98538);
case 44: return new CityInfo("Quellón", "14", -43.11819, -73.61661);
case 45: return new CityInfo("Puerto Natales", "10", -51.72987, -72.50603);
case 46: return new CityInfo("Puerto Montt", "14", -41.4693, -72.94237);
case 47: return new CityInfo("Puerto Cisnes", "02", -44.74736, -72.69695);
case 48: return new CityInfo("Puerto Aysén", "02", -45.40303, -72.69184);
case 49: return new CityInfo("Puente Alto", "12", -33.61169, -70.57577);
case 50: return new CityInfo("Pucón", "04", -39.28223, -71.95427);
case 51: return new CityInfo("Providencia", "12", -33.43107, -70.60454);
case 52: return new CityInfo("Pozo Almonte", "15", -20.25585, -69.7863);
case 53: return new CityInfo("Porvenir", "10", -53.296, -70.36629);
case 54: return new CityInfo("Pitrufquén", "04", -38.98635, -72.63721);
case 55: return new CityInfo("Pica", "15", -20.49128, -69.33118);
case 56: return new CityInfo("Penco", "06", -36.74075, -72.99528);
case 57: return new CityInfo("Peñaflor", "12", -33.60627, -70.87649);
case 58: return new CityInfo("Parral", "11", -36.14311, -71.82605);
case 59: return new CityInfo("Panguipulli", "17", -39.64355, -72.33269);
case 60: return new CityInfo("Palena", "14", -43.61876, -71.80434);
case 61: return new CityInfo("Paine", "12", -33.80796, -70.74109);
case 62: return new CityInfo("Ovalle", "07", -30.60106, -71.19901);
case 63: return new CityInfo("Osorno", "14", -40.57395, -73.13348);
case 64: return new CityInfo("Nueva Imperial", "04", -38.74451, -72.95025);
case 65: return new CityInfo("Nacimiento", "06", -37.50253, -72.67307);
case 66: return new CityInfo("Mulchén", "06", -37.71893, -72.24099);
case 67: return new CityInfo("Monte Patria", "07", -30.69496, -70.9577);
case 68: return new CityInfo("Molina", "11", -35.11428, -71.28232);
case 69: return new CityInfo("Melipilla", "12", -33.68909, -71.21528);
case 70: return new CityInfo("Machalí", "08", -34.18082, -70.64933);
case 71: return new CityInfo("Lota", "06", -37.08994, -73.1577);
case 72: return new CityInfo("Los Ángeles", "06", -37.46973, -72.35366);
case 73: return new CityInfo("Los Andes", "01", -32.83369, -70.59827);
case 74: return new CityInfo("Longaví", "11", -35.96496, -71.6836);
case 75: return new CityInfo("Loncoche", "04", -39.36708, -72.63087);
case 76: return new CityInfo("Llaillay", "01", -32.84043, -70.95623);
case 77: return new CityInfo("Linares", "11", -35.84667, -71.59308);
case 78: return new CityInfo("Limache", "01", -33.01667, -71.26667);
case 79: return new CityInfo("Lebu", "06", -37.60825, -73.65356);
case 80: return new CityInfo("Lautaro", "04", -38.53066, -72.43652);
case 81: return new CityInfo("La Unión", "17", -40.29313, -73.08167);
case 82: return new CityInfo("La Serena", "07", -29.90453, -71.24894);
case 83: return new CityInfo("Lampa", "12", -33.2863, -70.87561);
case 84: return new CityInfo("La Ligua", "01", -32.45242, -71.23106);
case 85: return new CityInfo("Laja", "06", -37.28415, -72.71105);
case 86: return new CityInfo("La Ensenada", "14", -41.20746, -72.5384);
case 87: return new CityInfo("Iquique", "15", -20.21326, -70.15027);
case 88: return new CityInfo("Illapel", "07", -31.63349, -71.16967);
case 89: return new CityInfo("Hacienda La Calera", "01", -32.78333, -71.21667);
case 90: return new CityInfo("Graneros", "08", -34.06863, -70.72747);
case 91: return new CityInfo("Futaleufú", "14", -43.18492, -71.86722);
case 92: return new CityInfo("Freire", "04", -38.95252, -72.62653);
case 93: return new CityInfo("El Tabo", "01", -33.45, -71.66667);
case 94: return new CityInfo("El Monte", "12", -33.67969, -70.98482);
case 95: return new CityInfo("Diego de Almagro", "05", -26.36667, -70.05);
case 96: return new CityInfo("Dalcahue", "14", -42.37845, -73.65011);
case 97: return new CityInfo("Curicó", "11", -34.98279, -71.23943);
case 98: return new CityInfo("Curanilahue", "06", -37.47793, -73.34495);
case 99: return new CityInfo("Corral", "17", -39.8873, -73.43101);
case 100: return new CityInfo("Coronel", "06", -37.03386, -73.14019);
case 101: return new CityInfo("Coquimbo", "07", -29.95332, -71.33947);
case 102: return new CityInfo("Copiapó", "05", -27.36679, -70.3314);
case 103: return new CityInfo("Constitución", "11", -35.33321, -72.41156);
case 104: return new CityInfo("Concepción", "06", -36.82699, -73.04977);
case 105: return new CityInfo("Collipulli", "04", -37.95453, -72.43438);
case 106: return new CityInfo("Colina", "12", -33.20443, -70.67474);
case 107: return new CityInfo("Colbún", "11", -35.69494, -71.40568);
case 108: return new CityInfo("Coihueco", "18", -36.62785, -71.83068);
case 109: return new CityInfo("Coyhaique", "02", -45.57524, -72.06619);
case 110: return new CityInfo("Cochrane", "02", -47.2557, -72.5695);
case 111: return new CityInfo("Chonchi", "14", -42.62387, -73.775);
case 112: return new CityInfo("Chimbarongo", "08", -34.71247, -71.0434);
case 113: return new CityInfo("Chillán", "18", -36.60664, -72.10344);
case 114: return new CityInfo("Chile Chico", "02", -46.541, -71.72375);
case 115: return new CityInfo("Chiguayante", "06", -36.9256, -73.02841);
case 116: return new CityInfo("Chicureo Abajo", "12", -33.28379, -70.65333);
case 117: return new CityInfo("Chañaral", "05", -26.34298, -70.61648);
case 118: return new CityInfo("Chaitén", "14", -42.91596, -72.70632);
case 119: return new CityInfo("Cauquenes", "11", -35.9671, -72.32248);
case 120: return new CityInfo("Castro", "14", -42.4721, -73.77319);
case 121: return new CityInfo("Cartagena", "01", -33.55384, -71.60761);
case 122: return new CityInfo("Carahue", "04", -38.71122, -73.16101);
case 123: return new CityInfo("Cañete", "06", -37.80128, -73.39616);
case 124: return new CityInfo("Cámeron", "10", -53.63988, -69.64693);
case 125: return new CityInfo("Calbuco", "14", -41.77338, -73.13049);
case 126: return new CityInfo("Calama", "03", -22.45667, -68.92371);
case 127: return new CityInfo("Cabrero", "06", -37.03394, -72.40468);
case 128: return new CityInfo("Bulnes", "18", -36.74232, -72.29854);
case 129: return new CityInfo("Buin", "12", -33.73257, -70.74281);
case 130: return new CityInfo("Arica", "16", -18.4746, -70.29792);
case 131: return new CityInfo("Arauco", "06", -37.2463, -73.31752);
case 132: return new CityInfo("Antofagasta", "03", -23.65236, -70.3954);
case 133: return new CityInfo("Angol", "04", -37.79519, -72.71636);
case 134: return new CityInfo("Ancud", "14", -41.8707, -73.81622);
case 135: return new CityInfo("Puerto Chacabuco", "02", -45.46667, -72.81667);
case 136: return new CityInfo("La Junta", "02", -43.97434, -72.40554);
case 137: return new CityInfo("Hanga Roa", "01", -27.15253, -109.42438);
case 138: return new CityInfo("Las Gaviotas", "17", -39.86653, -73.18834);
case 139: return new CityInfo("Las Animas", "17", -39.80867, -73.21821);
case 140: return new CityInfo("Villa Europa", "17", -39.83892, -73.23538);
case 141: return new CityInfo("Santa Rosa", "17", -40.17625, -72.56058);
case 142: return new CityInfo("La Pintana", "12", -33.58331, -70.63419);
case 143: return new CityInfo("Lo Prado", "12", -33.4443, -70.72552);
case 144: return new CityInfo("Villa Presidente Frei, Ñuñoa, Santiago, Chile", "12", -33.46069, -70.58024);
default: return new CityInfo("Vallenar", "05", -28.51576, -70.25551);

                                    }                                        
                                }
                            
                        }
                    }
                