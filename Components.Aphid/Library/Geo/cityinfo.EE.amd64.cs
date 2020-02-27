
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
                                    public const string Country = "EE";
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
                            
                                        var cur = (Math.Abs(58.64806 - lat) + Math.Abs(25.03611 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(57.83389 - lat) + Math.Abs(27.01944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.27833 - lat) + Math.Abs(27.04806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40776 - lat) + Math.Abs(27.58263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.46667 - lat) + Math.Abs(24.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.62833 - lat) + Math.Abs(25.92056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.62833 - lat) + Math.Abs(25.54833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.17028 - lat) + Math.Abs(26.60028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.57 - lat) + Math.Abs(23.52389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.29583 - lat) + Math.Abs(26.43222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36389 - lat) + Math.Abs(25.59 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36 - lat) + Math.Abs(25.63722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50502 - lat) + Math.Abs(24.84807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.00417 - lat) + Math.Abs(27.35194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.24417 - lat) + Math.Abs(24.29 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72972 - lat) + Math.Abs(27.29361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.16778 - lat) + Math.Abs(26.92861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.95806 - lat) + Math.Abs(27.63806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.39056 - lat) + Math.Abs(25.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.76972 - lat) + Math.Abs(24.27361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.86611 - lat) + Math.Abs(26.53222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.40611 - lat) + Math.Abs(22.80111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.47297 - lat) + Math.Abs(25.32321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.77781 - lat) + Math.Abs(26.0473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.89083 - lat) + Math.Abs(27.01889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.12639 - lat) + Math.Abs(26.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28546 - lat) + Math.Abs(24.97897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.88556 - lat) + Math.Abs(25.44639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.28361 - lat) + Math.Abs(24.58722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.93944 - lat) + Math.Abs(23.58944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3162 - lat) + Math.Abs(26.72517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.81583 - lat) + Math.Abs(25.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.80861 - lat) + Math.Abs(25.4325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.08306 - lat) + Math.Abs(24.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.86 - lat) + Math.Abs(26.19694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.3325 - lat) + Math.Abs(23.99972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.00278 - lat) + Math.Abs(25.935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.81278 - lat) + Math.Abs(26.73833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.47889 - lat) + Math.Abs(24.82417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.57806 - lat) + Math.Abs(24.7925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42127 - lat) + Math.Abs(27.50807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.14528 - lat) + Math.Abs(25.04417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.18027 - lat) + Math.Abs(22.24646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38062 - lat) + Math.Abs(26.72509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.26056 - lat) + Math.Abs(25.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.15861 - lat) + Math.Abs(26.11528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43696 - lat) + Math.Abs(24.75353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.95389 - lat) + Math.Abs(23.75222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42607 - lat) + Math.Abs(24.5533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.53611 - lat) + Math.Abs(25.47056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.34361 - lat) + Math.Abs(26.83639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.40056 - lat) + Math.Abs(24.6675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39697 - lat) + Math.Abs(27.76331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.72972 - lat) + Math.Abs(26.33944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.4272 - lat) + Math.Abs(24.49496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32258 - lat) + Math.Abs(24.54967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.79 - lat) + Math.Abs(25.42806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.16139 - lat) + Math.Abs(22.26222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30354 - lat) + Math.Abs(24.66382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53528 - lat) + Math.Abs(24.79972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.80028 - lat) + Math.Abs(23.24833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72778 - lat) + Math.Abs(26.90972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.14528 - lat) + Math.Abs(26.24806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.56056 - lat) + Math.Abs(23.83944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.11417 - lat) + Math.Abs(24.31056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.00722 - lat) + Math.Abs(24.79278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09806 - lat) + Math.Abs(27.46361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50823 - lat) + Math.Abs(24.90655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.34639 - lat) + Math.Abs(26.35583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.98167 - lat) + Math.Abs(26.25444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36639 - lat) + Math.Abs(25.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.57833 - lat) + Math.Abs(26.27528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.54696 - lat) + Math.Abs(24.80206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36 - lat) + Math.Abs(27.04972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.04972 - lat) + Math.Abs(26.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.34194 - lat) + Math.Abs(26.31472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.53459 - lat) + Math.Abs(24.79726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.06028 - lat) + Math.Abs(27.06944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.6525 - lat) + Math.Abs(25.97056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39468 - lat) + Math.Abs(24.81452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.61052 - lat) + Math.Abs(24.50689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38588 - lat) + Math.Abs(24.49711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.97028 - lat) + Math.Abs(23.90333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35667 - lat) + Math.Abs(24.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.685 - lat) + Math.Abs(26.57889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.27444 - lat) + Math.Abs(26.42333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.37917 - lat) + Math.Abs(24.63444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.88556 - lat) + Math.Abs(25.55722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.55917 - lat) + Math.Abs(23.08262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.92861 - lat) + Math.Abs(24.42889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.55361 - lat) + Math.Abs(25.56278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.10333 - lat) + Math.Abs(25.56278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.27556 - lat) + Math.Abs(26.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.45889 - lat) + Math.Abs(28.04083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.37722 - lat) + Math.Abs(28.19028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.84861 - lat) + Math.Abs(26.93972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13417 - lat) + Math.Abs(25.10028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.09222 - lat) + Math.Abs(25.18639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.90389 - lat) + Math.Abs(24.43056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.06667 - lat) + Math.Abs(27.04528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.22972 - lat) + Math.Abs(27.27222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.46529 - lat) + Math.Abs(24.98215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.35583 - lat) + Math.Abs(26.88083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32723 - lat) + Math.Abs(24.77613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43123 - lat) + Math.Abs(24.94949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.57639 - lat) + Math.Abs(25.72139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.36917 - lat) + Math.Abs(26.79806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.13722 - lat) + Math.Abs(23.97444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.60194 - lat) + Math.Abs(23.24694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.68139 - lat) + Math.Abs(23.84528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2925 - lat) + Math.Abs(24.31139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.51139 - lat) + Math.Abs(24.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40417 - lat) + Math.Abs(24.93892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.44389 - lat) + Math.Abs(25.44139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.24806 - lat) + Math.Abs(22.50389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.31861 - lat) + Math.Abs(26.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.73667 - lat) + Math.Abs(26.5225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.49861 - lat) + Math.Abs(26.52611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.48333 - lat) + Math.Abs(26.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.42734 - lat) + Math.Abs(25.09719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.2 - lat) + Math.Abs(25.10528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.46001 - lat) + Math.Abs(24.87824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.17889 - lat) + Math.Abs(25.17306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.42417 - lat) + Math.Abs(26.78222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.52 - lat) + Math.Abs(27.07417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39861 - lat) + Math.Abs(27.27306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35167 - lat) + Math.Abs(27.175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.16806 - lat) + Math.Abs(24.7575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.96306 - lat) + Math.Abs(26.03083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.31972 - lat) + Math.Abs(24.21139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35306 - lat) + Math.Abs(26.97111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.15028 - lat) + Math.Abs(24.96417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.44778 - lat) + Math.Abs(25.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23694 - lat) + Math.Abs(24.68889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30775 - lat) + Math.Abs(24.83776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.30361 - lat) + Math.Abs(24.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.93028 - lat) + Math.Abs(24.87806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33611 - lat) + Math.Abs(25.32111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.33583 - lat) + Math.Abs(22.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.11722 - lat) + Math.Abs(25.58778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.99778 - lat) + Math.Abs(22.74917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.98306 - lat) + Math.Abs(26.75639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.66312 - lat) + Math.Abs(27.16164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.82848 - lat) + Math.Abs(22.77711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.96556 - lat) + Math.Abs(24.84361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.33472 - lat) + Math.Abs(26.145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.06472 - lat) + Math.Abs(24.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35417 - lat) + Math.Abs(24.89417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35917 - lat) + Math.Abs(27.42111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.74667 - lat) + Math.Abs(26.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.40583 - lat) + Math.Abs(27.31111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.77889 - lat) + Math.Abs(24.82583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.03861 - lat) + Math.Abs(25.88639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.38639 - lat) + Math.Abs(26.54667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.10139 - lat) + Math.Abs(27.30806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.99004 - lat) + Math.Abs(23.24441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35222 - lat) + Math.Abs(26.21417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.07694 - lat) + Math.Abs(27.07417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.1325 - lat) + Math.Abs(24.37111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.43361 - lat) + Math.Abs(26.26139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.94306 - lat) + Math.Abs(23.54139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.08114 - lat) + Math.Abs(24.49719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.51358 - lat) + Math.Abs(24.82225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.2225 - lat) + Math.Abs(26.42111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.98222 - lat) + Math.Abs(26.86417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.40861 - lat) + Math.Abs(24.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.34361 - lat) + Math.Abs(22.45889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.45256 - lat) + Math.Abs(26.87163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36686 - lat) + Math.Abs(25.07618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.10056 - lat) + Math.Abs(25.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.14167 - lat) + Math.Abs(25.76139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.82556 - lat) + Math.Abs(26.54056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.0225 - lat) + Math.Abs(24.76083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.59806 - lat) + Math.Abs(27.13361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.20389 - lat) + Math.Abs(27.07333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.28583 - lat) + Math.Abs(25.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.70611 - lat) + Math.Abs(25.89917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.12528 - lat) + Math.Abs(25.34972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.23995 - lat) + Math.Abs(24.51599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.32 - lat) + Math.Abs(25.35694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35556 - lat) + Math.Abs(25.99528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.36111 - lat) + Math.Abs(26.4375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.39528 - lat) + Math.Abs(28.12528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.30583 - lat) + Math.Abs(25.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.20806 - lat) + Math.Abs(26.41139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.22056 - lat) + Math.Abs(26.70611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.81278 - lat) + Math.Abs(27.03694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.90972 - lat) + Math.Abs(26.98306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.38641 - lat) + Math.Abs(24.57176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.35083 - lat) + Math.Abs(24.61418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.50086 - lat) + Math.Abs(24.86254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vändra", "11", 58.64806, 25.03611);
case 1: return new CityInfo("Võru", "21", 57.83389, 27.01944);
case 2: return new CityInfo("Võnnu", "18", 58.27833, 27.04806);
case 3: return new CityInfo("Voka", "03", 59.40776, 27.58263);
case 4: return new CityInfo("Võiste", "11", 58.46667, 24.48333);
case 5: return new CityInfo("Võisiku", "05", 58.62833, 25.92056);
case 6: return new CityInfo("Võhma", "20", 58.62833, 25.54833);
case 7: return new CityInfo("Roela", "08", 59.17028, 26.60028);
case 8: return new CityInfo("Virtsu", "11", 58.57, 23.52389);
case 9: return new CityInfo("Vinni", "08", 59.29583, 26.43222);
case 10: return new CityInfo("Viljandi", "20", 58.36389, 25.59);
case 11: return new CityInfo("Viiratsi", "20", 58.36, 25.63722);
case 12: return new CityInfo("Viimsi", "01", 59.50502, 24.84807);
case 13: return new CityInfo("Veriora", "12", 58.00417, 27.35194);
case 14: return new CityInfo("Vasalemma", "01", 59.24417, 24.29);
case 15: return new CityInfo("Vastseliina", "21", 57.72972, 27.29361);
case 16: return new CityInfo("Vastse-Kuuste", "12", 58.16778, 26.92861);
case 17: return new CityInfo("Värska", "21", 57.95806, 27.63806);
case 18: return new CityInfo("Vana-Võidu", "20", 58.39056, 25.65417);
case 19: return new CityInfo("Vana-Vigala", "13", 58.76972, 24.27361);
case 20: return new CityInfo("Vana-Antsla", "21", 57.86611, 26.53222);
case 21: return new CityInfo("Valjala", "14", 58.40611, 22.80111);
case 22: return new CityInfo("Valkla", "01", 59.47297, 25.32321);
case 23: return new CityInfo("Valga", "19", 57.77781, 26.0473);
case 24: return new CityInfo("Väimela", "21", 57.89083, 27.01889);
case 25: return new CityInfo("Väike-Maarja", "08", 59.12639, 26.25);
case 26: return new CityInfo("Vaida", "01", 59.28546, 24.97897);
case 27: return new CityInfo("Vyatsa", "04", 58.88556, 25.44639);
case 28: return new CityInfo("Uulu", "11", 58.28361, 24.58722);
case 29: return new CityInfo("Uuemõisa", "07", 58.93944, 23.58944);
case 30: return new CityInfo("Ülenurme", "18", 58.3162, 26.72517);
case 31: return new CityInfo("Türi-Alliku", "04", 58.81583, 25.45389);
case 32: return new CityInfo("Türi", "04", 58.80861, 25.4325);
case 33: return new CityInfo("Turba", "01", 59.08306, 24.225);
case 34: return new CityInfo("Tsirguliina", "19", 57.86, 26.19694);
case 35: return new CityInfo("Tõstamaa", "11", 58.3325, 23.99972);
case 36: return new CityInfo("Tõrva", "19", 58.00278, 25.935);
case 37: return new CityInfo("Torma", "05", 58.81278, 26.73833);
case 38: return new CityInfo("Tori", "11", 58.47889, 24.82417);
case 39: return new CityInfo("Tootsi", "11", 58.57806, 24.7925);
case 40: return new CityInfo("Toila", "03", 59.42127, 27.50807);
case 41: return new CityInfo("Tihemetsa", "11", 58.14528, 25.04417);
case 42: return new CityInfo("Tehumardi", "14", 58.18027, 22.24646);
case 43: return new CityInfo("Tartu", "18", 58.38062, 26.72509);
case 44: return new CityInfo("Tapa", "08", 59.26056, 25.95861);
case 45: return new CityInfo("Tamsalu", "08", 59.15861, 26.11528);
case 46: return new CityInfo("Tallinn", "01", 59.43696, 24.75353);
case 47: return new CityInfo("Taebla", "07", 58.95389, 23.75222);
case 48: return new CityInfo("Tabasalu", "01", 59.42607, 24.5533);
case 49: return new CityInfo("Suure-Jaani", "20", 58.53611, 25.47056);
case 50: return new CityInfo("Sonda", "03", 59.34361, 26.83639);
case 51: return new CityInfo("Sindi", "11", 58.40056, 24.6675);
case 52: return new CityInfo("Sillamäe", "03", 59.39697, 27.76331);
case 53: return new CityInfo("Siimusti", "05", 58.72972, 26.33944);
case 54: return new CityInfo("Sauga", "11", 58.4272, 24.49496);
case 55: return new CityInfo("Saue", "01", 59.32258, 24.54967);
case 56: return new CityInfo("Särevere", "04", 58.79, 25.42806);
case 57: return new CityInfo("Salme", "14", 58.16139, 22.26222);
case 58: return new CityInfo("Saku", "01", 59.30354, 24.66382);
case 59: return new CityInfo("Rummu", "01", 59.53528, 24.79972);
case 60: return new CityInfo("Ruhnu", "14", 57.80028, 23.24833);
case 61: return new CityInfo("Rõuge", "21", 57.72778, 26.90972);
case 62: return new CityInfo("Rõngu", "18", 58.14528, 26.24806);
case 63: return new CityInfo("Risti", "11", 58.56056, 23.83944);
case 64: return new CityInfo("Riisipere", "01", 59.11417, 24.31056);
case 65: return new CityInfo("Rapla", "13", 59.00722, 24.79278);
case 66: return new CityInfo("Räpina", "12", 58.09806, 27.46361);
case 67: return new CityInfo("Randvere", "01", 59.50823, 24.90655);
case 68: return new CityInfo("Rakvere", "08", 59.34639, 26.35583);
case 69: return new CityInfo("Rakke", "08", 58.98167, 26.25444);
case 70: return new CityInfo("Raasiku", "01", 59.36639, 25.18306);
case 71: return new CityInfo("Puurmani", "05", 58.57833, 26.27528);
case 72: return new CityInfo("Pyuyunsi", "01", 59.54696, 24.80206);
case 73: return new CityInfo("Püssi", "03", 59.36, 27.04972);
case 74: return new CityInfo("Puka", "19", 58.04972, 26.22639);
case 75: return new CityInfo("Puhja", "18", 58.34194, 26.31472);
case 76: return new CityInfo("Pringi", "01", 59.53459, 24.79726);
case 77: return new CityInfo("Põlva", "12", 58.06028, 27.06944);
case 78: return new CityInfo("Põltsamaa", "05", 58.6525, 25.97056);
case 79: return new CityInfo("Peetri", "01", 59.39468, 24.81452);
case 80: return new CityInfo("Pärnu-Jaagupi", "11", 58.61052, 24.50689);
case 81: return new CityInfo("Pärnu", "11", 58.38588, 24.49711);
case 82: return new CityInfo("Palivere", "07", 58.97028, 23.90333);
case 83: return new CityInfo("Paldiski", "01", 59.35667, 24.05306);
case 84: return new CityInfo("Palamuse", "05", 58.685, 26.57889);
case 85: return new CityInfo("Pajusti", "08", 59.27444, 26.42333);
case 86: return new CityInfo("Paikuse", "11", 58.37917, 24.63444);
case 87: return new CityInfo("Paide", "04", 58.88556, 25.55722);
case 88: return new CityInfo("Orissaare", "14", 58.55917, 23.08262);
case 89: return new CityInfo("Orgita", "13", 58.92861, 24.42889);
case 90: return new CityInfo("Olustvere", "20", 58.55361, 25.56278);
case 91: return new CityInfo("Karksi-Nuia", "20", 58.10333, 25.56278);
case 92: return new CityInfo("Nõo", "18", 58.27556, 26.5375);
case 93: return new CityInfo("Narva-Jõesuu", "03", 59.45889, 28.04083);
case 94: return new CityInfo("Narva", "03", 59.37722, 28.19028);
case 95: return new CityInfo("Mustvee", "05", 58.84861, 26.93972);
case 96: return new CityInfo("Mustla", "11", 58.13417, 25.10028);
case 97: return new CityInfo("Mõisaküla", "20", 58.09222, 25.18639);
case 98: return new CityInfo("Märjamaa", "13", 58.90389, 24.43056);
case 99: return new CityInfo("Mammaste", "12", 58.06667, 27.04528);
case 100: return new CityInfo("Mäetaguse", "03", 59.22972, 27.27222);
case 101: return new CityInfo("Maardu", "01", 59.46529, 24.98215);
case 102: return new CityInfo("Luunja", "18", 58.35583, 26.88083);
case 103: return new CityInfo("Luige", "01", 59.32723, 24.77613);
case 104: return new CityInfo("Loo", "01", 59.43123, 24.94949);
case 105: return new CityInfo("Loksa", "01", 59.57639, 25.72139);
case 106: return new CityInfo("Lohkva", "18", 58.36917, 26.79806);
case 107: return new CityInfo("Linaküla", "11", 58.13722, 23.97444);
case 108: return new CityInfo("Liiva", "14", 58.60194, 23.24694);
case 109: return new CityInfo("Lihula", "11", 58.68139, 23.84528);
case 110: return new CityInfo("Lehola", "01", 59.2925, 24.31139);
case 111: return new CityInfo("Lavassaare", "11", 58.51139, 24.38889);
case 112: return new CityInfo("Lagedi", "01", 59.40417, 24.93892);
case 113: return new CityInfo("Kuusalu", "01", 59.44389, 25.44139);
case 114: return new CityInfo("Kuressaare", "14", 58.24806, 22.50389);
case 115: return new CityInfo("Kurepalu", "18", 58.31861, 26.84083);
case 116: return new CityInfo("Kuremaa", "05", 58.73667, 26.5225);
case 117: return new CityInfo("Kunda", "08", 59.49861, 26.52611);
case 118: return new CityInfo("Kunda", "08", 59.48333, 26.53333);
case 119: return new CityInfo("Kostivere", "01", 59.42734, 25.09719);
case 120: return new CityInfo("Kose-Uuemõisa", "01", 59.2, 25.10528);
case 121: return new CityInfo("Kose", "01", 59.46001, 24.87824);
case 122: return new CityInfo("Kose", "01", 59.17889, 25.17306);
case 123: return new CityInfo("Kõrveküla", "18", 58.42417, 26.78222);
case 124: return new CityInfo("Koosa", "18", 58.52, 27.07417);
case 125: return new CityInfo("Kohtla-Järve", "03", 59.39861, 27.27306);
case 126: return new CityInfo("Kohtla-Nõmme", "03", 59.35167, 27.175);
case 127: return new CityInfo("Kohila", "13", 59.16806, 24.7575);
case 128: return new CityInfo("Koeru", "04", 58.96306, 26.03083);
case 129: return new CityInfo("Klooga", "01", 59.31972, 24.21139);
case 130: return new CityInfo("Kiviõli", "03", 59.35306, 26.97111);
case 131: return new CityInfo("Kilingi-Nõmme", "11", 58.15028, 24.96417);
case 132: return new CityInfo("Kiiu", "01", 59.44778, 25.37944);
case 133: return new CityInfo("Kiisa", "01", 59.23694, 24.68889);
case 134: return new CityInfo("Kiili", "01", 59.30775, 24.83776);
case 135: return new CityInfo("Keila", "01", 59.30361, 24.41306);
case 136: return new CityInfo("Kehtna", "13", 58.93028, 24.87806);
case 137: return new CityInfo("Kehra", "01", 59.33611, 25.32111);
case 138: return new CityInfo("Kärla", "14", 58.33583, 22.25972);
case 139: return new CityInfo("Karksi", "20", 58.11722, 25.58778);
case 140: return new CityInfo("Kärdla", "02", 58.99778, 22.74917);
case 141: return new CityInfo("Kanepi", "12", 57.98306, 26.75639);
case 142: return new CityInfo("Kallaste", "18", 58.66312, 27.16164);
case 143: return new CityInfo("Käina", "02", 58.82848, 22.77711);
case 144: return new CityInfo("Kaerepere", "13", 58.96556, 24.84361);
case 145: return new CityInfo("Kadrina", "08", 59.33472, 26.145);
case 146: return new CityInfo("Juuru", "13", 59.06472, 24.95028);
case 147: return new CityInfo("Jüri", "01", 59.35417, 24.89417);
case 148: return new CityInfo("Jõhvi", "03", 59.35917, 27.42111);
case 149: return new CityInfo("Jõgeva", "05", 58.74667, 26.39389);
case 150: return new CityInfo("Järve", "03", 59.40583, 27.31111);
case 151: return new CityInfo("Järvakandi", "13", 58.77889, 24.82583);
case 152: return new CityInfo("Järva-Jaani", "04", 59.03861, 25.88639);
case 153: return new CityInfo("Ilmatsalu", "18", 58.38639, 26.54667);
case 154: return new CityInfo("Iisaku", "03", 59.10139, 27.30806);
case 155: return new CityInfo("Hullo", "07", 58.99004, 23.24441);
case 156: return new CityInfo("Hulja", "08", 59.35222, 26.21417);
case 157: return new CityInfo("Himmaste", "12", 58.07694, 27.07417);
case 158: return new CityInfo("Harku", "01", 59.1325, 24.37111);
case 159: return new CityInfo("Haljala", "08", 59.43361, 26.26139);
case 160: return new CityInfo("Haapsalu", "07", 58.94306, 23.54139);
case 161: return new CityInfo("Häädemeeste", "11", 58.08114, 24.49719);
case 162: return new CityInfo("Haabneeme", "01", 59.51358, 24.82225);
case 163: return new CityInfo("Elva", "18", 58.2225, 26.42111);
case 164: return new CityInfo("Avinurme", "05", 58.98222, 26.86417);
case 165: return new CityInfo("Audru", "11", 58.40861, 24.37389);
case 166: return new CityInfo("Aste", "14", 58.34361, 22.45889);
case 167: return new CityInfo("Aseri", "08", 59.45256, 26.87163);
case 168: return new CityInfo("Aruküla", "01", 59.36686, 25.07618);
case 169: return new CityInfo("Ardu", "01", 59.10056, 25.37083);
case 170: return new CityInfo("Aravete", "04", 59.14167, 25.76139);
case 171: return new CityInfo("Antsla", "21", 57.82556, 26.54056);
case 172: return new CityInfo("Alu", "13", 59.0225, 24.76083);
case 173: return new CityInfo("Alatskivi", "18", 58.59806, 27.13361);
case 174: return new CityInfo("Ahja", "12", 58.20389, 27.07333);
case 175: return new CityInfo("Aegviidu", "01", 59.28583, 25.61417);
case 176: return new CityInfo("Adavere", "05", 58.70611, 25.89917);
case 177: return new CityInfo("Abja-Paluoja", "20", 58.12528, 25.34972);
case 178: return new CityInfo("Ääsmäe", "01", 59.23995, 24.51599);
case 179: return new CityInfo("Lehtmetsa", "01", 59.32, 25.35694);
case 180: return new CityInfo("Vaiatu", "08", 59.35556, 25.99528);
case 181: return new CityInfo("Sõmeru", "08", 59.36111, 26.4375);
case 182: return new CityInfo("Olgina", "03", 59.39528, 28.12528);
case 183: return new CityInfo("Ramsi", "20", 58.30583, 25.53528);
case 184: return new CityInfo("Käärdi", "18", 58.20806, 26.41139);
case 185: return new CityInfo("Suure-Kambja", "18", 58.22056, 26.70611);
case 186: return new CityInfo("Kose", "21", 57.81278, 27.03694);
case 187: return new CityInfo("Parksepa", "21", 57.90972, 26.98306);
case 188: return new CityInfo("Harku", "01", 59.38641, 24.57176);
case 189: return new CityInfo("Laagri", "01", 59.35083, 24.61418);
default: return new CityInfo("Viimsi", "01", 59.50086, 24.86254);

                                    }                                        
                                }
                            
                        }
                    }
                