
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
                                    public const string Country = "KM";
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
                            
                                        var cur = (Math.Abs(-12.3375 - lat) + Math.Abs(43.7975 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-12.24417 - lat) + Math.Abs(44.37444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23194 - lat) + Math.Abs(44.3425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.61139 - lat) + Math.Abs(43.25306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.20583 - lat) + Math.Abs(44.46472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.84784 - lat) + Math.Abs(43.31731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19556 - lat) + Math.Abs(44.27667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.8115 - lat) + Math.Abs(43.26823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15556 - lat) + Math.Abs(44.43722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.87482 - lat) + Math.Abs(43.3931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.26722 - lat) + Math.Abs(44.47972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.585 - lat) + Math.Abs(43.26722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.91375 - lat) + Math.Abs(43.49804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.39028 - lat) + Math.Abs(43.33194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13554 - lat) + Math.Abs(44.42493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.17028 - lat) + Math.Abs(44.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66077 - lat) + Math.Abs(43.27157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.46583 - lat) + Math.Abs(43.26278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36139 - lat) + Math.Abs(43.71528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.33222 - lat) + Math.Abs(44.51917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.16672 - lat) + Math.Abs(44.39944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.60694 - lat) + Math.Abs(43.38056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.30833 - lat) + Math.Abs(44.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.34639 - lat) + Math.Abs(44.52861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.30967 - lat) + Math.Abs(44.43685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.70216 - lat) + Math.Abs(43.25506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.82701 - lat) + Math.Abs(43.45436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19167 - lat) + Math.Abs(44.37028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19361 - lat) + Math.Abs(44.31 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.81209 - lat) + Math.Abs(43.28043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.38472 - lat) + Math.Abs(43.28444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.29667 - lat) + Math.Abs(43.63528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.55139 - lat) + Math.Abs(43.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.83642 - lat) + Math.Abs(43.31388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.50139 - lat) + Math.Abs(43.3775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23083 - lat) + Math.Abs(44.31333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.22972 - lat) + Math.Abs(44.48167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.21583 - lat) + Math.Abs(44.48 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.17139 - lat) + Math.Abs(44.44167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.34278 - lat) + Math.Abs(43.82 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.32102 - lat) + Math.Abs(44.4727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.39157 - lat) + Math.Abs(43.39454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.67638 - lat) + Math.Abs(43.26466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36417 - lat) + Math.Abs(43.86778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.54389 - lat) + Math.Abs(43.37972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.25083 - lat) + Math.Abs(43.67472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.84472 - lat) + Math.Abs(43.31583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.86537 - lat) + Math.Abs(43.49529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.28759 - lat) + Math.Abs(43.74344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.18333 - lat) + Math.Abs(44.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85287 - lat) + Math.Abs(43.34987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.25694 - lat) + Math.Abs(44.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.30587 - lat) + Math.Abs(43.77425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.87361 - lat) + Math.Abs(43.39778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.64306 - lat) + Math.Abs(43.38583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19111 - lat) + Math.Abs(44.3525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.92328 - lat) + Math.Abs(43.49109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.4314 - lat) + Math.Abs(43.39625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.195 - lat) + Math.Abs(44.46472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.8233 - lat) + Math.Abs(43.29429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.48694 - lat) + Math.Abs(43.38833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.20556 - lat) + Math.Abs(44.29944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.18833 - lat) + Math.Abs(44.23556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.20325 - lat) + Math.Abs(44.51638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23306 - lat) + Math.Abs(44.31972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.35639 - lat) + Math.Abs(44.5225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.27444 - lat) + Math.Abs(43.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.26111 - lat) + Math.Abs(43.70361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.3325 - lat) + Math.Abs(43.7775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.37306 - lat) + Math.Abs(43.83833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19056 - lat) + Math.Abs(44.2525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19806 - lat) + Math.Abs(44.26389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19194 - lat) + Math.Abs(44.26944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.19167 - lat) + Math.Abs(44.28694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.18583 - lat) + Math.Abs(44.33556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.12434 - lat) + Math.Abs(44.48881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13861 - lat) + Math.Abs(44.43026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15108 - lat) + Math.Abs(44.49828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15667 - lat) + Math.Abs(44.40806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.16972 - lat) + Math.Abs(44.38806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23944 - lat) + Math.Abs(44.50528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.25583 - lat) + Math.Abs(44.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.27806 - lat) + Math.Abs(44.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.2925 - lat) + Math.Abs(44.49722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.32583 - lat) + Math.Abs(44.48861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.405 - lat) + Math.Abs(43.28222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.41806 - lat) + Math.Abs(43.29528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.42111 - lat) + Math.Abs(43.28889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.42083 - lat) + Math.Abs(43.27639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.43178 - lat) + Math.Abs(43.41102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.47278 - lat) + Math.Abs(43.38444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.47861 - lat) + Math.Abs(43.37722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.49861 - lat) + Math.Abs(43.3575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.50944 - lat) + Math.Abs(43.37611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.51778 - lat) + Math.Abs(43.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.5725 - lat) + Math.Abs(43.27722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.6075 - lat) + Math.Abs(43.27611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.62833 - lat) + Math.Abs(43.26 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.63972 - lat) + Math.Abs(43.28417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.64583 - lat) + Math.Abs(43.26583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66167 - lat) + Math.Abs(43.26639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.65722 - lat) + Math.Abs(43.27556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.65361 - lat) + Math.Abs(43.28056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.67139 - lat) + Math.Abs(43.405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.69806 - lat) + Math.Abs(43.26194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.71611 - lat) + Math.Abs(43.26472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.71639 - lat) + Math.Abs(43.2525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.75444 - lat) + Math.Abs(43.43611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78444 - lat) + Math.Abs(43.26083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.82167 - lat) + Math.Abs(43.27806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85461 - lat) + Math.Abs(43.44607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.8524 - lat) + Math.Abs(43.3416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.87583 - lat) + Math.Abs(43.47222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.88639 - lat) + Math.Abs(43.41083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Ouanani", "03", -12.3375, 43.7975);
case 1: return new CityInfo("Vouani", "01", -12.24417, 44.37444);
case 2: return new CityInfo("Vassy", "01", -12.23194, 44.3425);
case 3: return new CityInfo("Vanambouani", "02", -11.61139, 43.25306);
case 4: return new CityInfo("Tsimbeo", "01", -12.20583, 44.46472);
case 5: return new CityInfo("Singani", "02", -11.84784, 43.31731);
case 6: return new CityInfo("Sima", "01", -12.19556, 44.27667);
case 7: return new CityInfo("Salimani", "02", -11.8115, 43.26823);
case 8: return new CityInfo("Patsi", "01", -12.15556, 44.43722);
case 9: return new CityInfo("Panda", "02", -11.87482, 43.3931);
case 10: return new CityInfo("Ouzini", "01", -12.26722, 44.47972);
case 11: return new CityInfo("Oussivo", "02", -11.585, 43.26722);
case 12: return new CityInfo("Ourovéni", "02", -11.91375, 43.49804);
case 13: return new CityInfo("Ouellah", "02", -11.39028, 43.33194);
case 14: return new CityInfo("Ouani", "01", -12.13554, 44.42493);
case 15: return new CityInfo("Ongoni", "01", -12.17028, 44.50694);
case 16: return new CityInfo("Ntsoudjini", "02", -11.66077, 43.27157);
case 17: return new CityInfo("Ntsaouéni", "02", -11.46583, 43.26278);
case 18: return new CityInfo("Nioumachoua", "03", -12.36139, 43.71528);
case 19: return new CityInfo("Kyo", "01", -12.33222, 44.51917);
case 20: return new CityInfo("Moutsamoudou", "01", -12.16672, 44.39944);
case 21: return new CityInfo("Mtsamdou", "02", -11.60694, 43.38056);
case 22: return new CityInfo("Mrémani", "01", -12.30833, 44.49861);
case 23: return new CityInfo("Mramani", "01", -12.34639, 44.52861);
case 24: return new CityInfo("Moya", "01", -12.30967, 44.43685);
case 25: return new CityInfo("Moroni", "02", -11.70216, 43.25506);
case 26: return new CityInfo("Mohoro", "02", -11.82701, 43.45436);
case 27: return new CityInfo("Mjimandra", "01", -12.19167, 44.37028);
case 28: return new CityInfo("Mjamaoué", "01", -12.19361, 44.31);
case 29: return new CityInfo("Mitsoudjé", "02", -11.81209, 43.28043);
case 30: return new CityInfo("Mitsamiouli", "02", -11.38472, 43.28444);
case 31: return new CityInfo("Miringoni", "03", -12.29667, 43.63528);
case 32: return new CityInfo("Milévani", "02", -11.55139, 43.29028);
case 33: return new CityInfo("Mdjoyézi", "02", -11.83642, 43.31388);
case 34: return new CityInfo("Mbéni", "02", -11.50139, 43.3775);
case 35: return new CityInfo("Maraharé", "01", -12.23083, 44.31333);
case 36: return new CityInfo("Koni-Djodjo", "01", -12.22972, 44.48167);
case 37: return new CityInfo("Koni-Ngani", "01", -12.21583, 44.48);
case 38: return new CityInfo("Koki", "01", -12.17139, 44.44167);
case 39: return new CityInfo("Kangani", "03", -12.34278, 43.82);
case 40: return new CityInfo("Kangani", "01", -12.32102, 44.4727);
case 41: return new CityInfo("Ivouani", "02", -11.39157, 43.39454);
case 42: return new CityInfo("Itsandra", "02", -11.67638, 43.26466);
case 43: return new CityInfo("Itsamia", "03", -12.36417, 43.86778);
case 44: return new CityInfo("Héroumbili", "02", -11.54389, 43.37972);
case 45: return new CityInfo("Hoani", "03", -12.25083, 43.67472);
case 46: return new CityInfo("Hetsa", "02", -11.84472, 43.31583);
case 47: return new CityInfo("Foumbouni", "02", -11.86537, 43.49529);
case 48: return new CityInfo("Fomboni", "03", -12.28759, 43.74344);
case 49: return new CityInfo("Dziani", "01", -12.18333, 44.48333);
case 50: return new CityInfo("Dzahadjou", "02", -11.85287, 43.34987);
case 51: return new CityInfo("Domoni", "01", -12.25694, 44.53194);
case 52: return new CityInfo("Djoyézi", "03", -12.30587, 43.77425);
case 53: return new CityInfo("Dembéni", "02", -11.87361, 43.39778);
case 54: return new CityInfo("Chomoni", "02", -11.64306, 43.38583);
case 55: return new CityInfo("Chironkamba", "01", -12.19111, 44.3525);
case 56: return new CityInfo("Chindini", "02", -11.92328, 43.49109);
case 57: return new CityInfo("Chezani", "02", -11.4314, 43.39625);
case 58: return new CityInfo("Chandra", "01", -12.195, 44.46472);
case 59: return new CityInfo("Chouani", "02", -11.8233, 43.29429);
case 60: return new CityInfo("Bouni", "02", -11.48694, 43.38833);
case 61: return new CityInfo("Boungouéni", "01", -12.20556, 44.29944);
case 62: return new CityInfo("Bimbini", "01", -12.18833, 44.23556);
case 63: return new CityInfo("Bambao", "01", -12.20325, 44.51638);
case 64: return new CityInfo("Assimpao", "01", -12.23306, 44.31972);
case 65: return new CityInfo("Antsahé", "01", -12.35639, 44.5225);
case 66: return new CityInfo("Hamba", "03", -12.27444, 43.63194);
case 67: return new CityInfo("Mtakoudja", "03", -12.26111, 43.70361);
case 68: return new CityInfo("Ziroudani", "03", -12.3325, 43.7775);
case 69: return new CityInfo("Hamavouna", "03", -12.37306, 43.83833);
case 70: return new CityInfo("Mirongani", "01", -12.19056, 44.2525);
case 71: return new CityInfo("Milembéni", "01", -12.19806, 44.26389);
case 72: return new CityInfo("Kavani", "01", -12.19194, 44.26944);
case 73: return new CityInfo("Bandajou", "01", -12.19167, 44.28694);
case 74: return new CityInfo("Chitrouni", "01", -12.18583, 44.33556);
case 75: return new CityInfo("Hajoho", "01", -12.12434, 44.48881);
case 76: return new CityInfo("Barakani", "01", -12.13861, 44.43026);
case 77: return new CityInfo("Harembo", "01", -12.15108, 44.49828);
case 78: return new CityInfo("Mirontsi", "01", -12.15667, 44.40806);
case 79: return new CityInfo("Pajé", "01", -12.16972, 44.38806);
case 80: return new CityInfo("Limbi", "01", -12.23944, 44.50528);
case 81: return new CityInfo("Lingoni", "01", -12.25583, 44.41833);
case 82: return new CityInfo("Magnassini-Nindri", "01", -12.27806, 44.41583);
case 83: return new CityInfo("Adda-Douéni", "01", -12.2925, 44.49722);
case 84: return new CityInfo("Daji", "01", -12.32583, 44.48861);
case 85: return new CityInfo("Ouhozi", "02", -11.405, 43.28222);
case 86: return new CityInfo("Mandza", "02", -11.41806, 43.29528);
case 87: return new CityInfo("Douniani", "02", -11.42111, 43.28889);
case 88: return new CityInfo("Koua", "02", -11.42083, 43.27639);
case 89: return new CityInfo("Hantsindzi", "02", -11.43178, 43.41102);
case 90: return new CityInfo("Itsandzéni", "02", -11.47278, 43.38444);
case 91: return new CityInfo("Bambadjani", "02", -11.47861, 43.37722);
case 92: return new CityInfo("Batou", "02", -11.49861, 43.3575);
case 93: return new CityInfo("Sada-Chihoué", "02", -11.50944, 43.37611);
case 94: return new CityInfo("Mnoungou", "02", -11.51778, 43.37389);
case 95: return new CityInfo("Bibavou", "02", -11.5725, 43.27722);
case 96: return new CityInfo("Vanadjou", "02", -11.6075, 43.27611);
case 97: return new CityInfo("Batsa", "02", -11.62833, 43.26);
case 98: return new CityInfo("Bahani", "02", -11.63972, 43.28417);
case 99: return new CityInfo("Zivandani", "02", -11.64583, 43.26583);
case 100: return new CityInfo("Milembéni", "02", -11.66167, 43.26639);
case 101: return new CityInfo("Dzahani", "02", -11.65722, 43.27556);
case 102: return new CityInfo("Wela", "02", -11.65361, 43.28056);
case 103: return new CityInfo("Sidjou", "02", -11.67139, 43.405);
case 104: return new CityInfo("Tsidjé", "02", -11.69806, 43.26194);
case 105: return new CityInfo("Mvouni", "02", -11.71611, 43.26472);
case 106: return new CityInfo("Mavingouni", "02", -11.71639, 43.2525);
case 107: return new CityInfo("Oungoni", "02", -11.75444, 43.43611);
case 108: return new CityInfo("Séléa", "02", -11.78444, 43.26083);
case 109: return new CityInfo("Madjeouéni", "02", -11.82167, 43.27806);
case 110: return new CityInfo("Nioumamilima", "02", -11.85461, 43.44607);
case 111: return new CityInfo("Mbambani", "02", -11.8524, 43.3416);
case 112: return new CityInfo("Kové", "02", -11.87583, 43.47222);
default: return new CityInfo("Dima", "02", -11.88639, 43.41083);

                                    }                                        
                                }
                            
                        }
                    }
                