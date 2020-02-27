
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
                                    public const string Country = "BR";
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
                            
                                        var cur = (Math.Abs(-4.04238 - lat) + Math.Abs(-45.23777 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-3.46222 - lat) + Math.Abs(-44.87056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11806 - lat) + Math.Abs(-35.29139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.19667 - lat) + Math.Abs(-46.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.25972 - lat) + Math.Abs(-34.9075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.85833 - lat) + Math.Abs(-48.14167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.56222 - lat) + Math.Abs(-41.09222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.37139 - lat) + Math.Abs(-36.24083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.65694 - lat) + Math.Abs(-35.32667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.22028 - lat) + Math.Abs(-45.00361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.35 - lat) + Math.Abs(-40.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.19444 - lat) + Math.Abs(-40.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.54306 - lat) + Math.Abs(-43.91583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4075 - lat) + Math.Abs(-41.74556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.12845 - lat) + Math.Abs(-58.15856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.22944 - lat) + Math.Abs(-44.55611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.53639 - lat) + Math.Abs(-57.76 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.625 - lat) + Math.Abs(-39.50833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.20778 - lat) + Math.Abs(-43.40361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.64194 - lat) + Math.Abs(-37.25778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.16278 - lat) + Math.Abs(-36.03194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.58583 - lat) + Math.Abs(-42.86417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.67722 - lat) + Math.Abs(-39.35028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.69556 - lat) + Math.Abs(-35.66361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.99056 - lat) + Math.Abs(-37.81444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.51833 - lat) + Math.Abs(-38.41222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.85444 - lat) + Math.Abs(-40.92111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.84139 - lat) + Math.Abs(-39.48167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.76194 - lat) + Math.Abs(-42.27444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.66333 - lat) + Math.Abs(-45.37167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.75333 - lat) + Math.Abs(-37.33972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.25806 - lat) + Math.Abs(-44.64889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.76585 - lat) + Math.Abs(-49.67923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.18333 - lat) + Math.Abs(-50.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.56667 - lat) + Math.Abs(-38.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.76194 - lat) + Math.Abs(-40.26778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.27778 - lat) + Math.Abs(-39.26889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.97056 - lat) + Math.Abs(-37.00333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.19889 - lat) + Math.Abs(-35.46083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.00667 - lat) + Math.Abs(-36.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.41889 - lat) + Math.Abs(-48.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.09417 - lat) + Math.Abs(-42.83667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.25528 - lat) + Math.Abs(-43.94056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.50528 - lat) + Math.Abs(-35.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.73222 - lat) + Math.Abs(-40.99167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.10417 - lat) + Math.Abs(-56.48694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.08917 - lat) + Math.Abs(-42.80194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.22278 - lat) + Math.Abs(-37.25417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.63583 - lat) + Math.Abs(-37.87833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6 - lat) + Math.Abs(-40.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.90306 - lat) + Math.Abs(-36.04417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.645 - lat) + Math.Abs(-36.49722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2075 - lat) + Math.Abs(-36.82667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.19944 - lat) + Math.Abs(-35.80167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.83222 - lat) + Math.Abs(-40.32056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.75632 - lat) + Math.Abs(-35.09995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.62167 - lat) + Math.Abs(-35.59667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.59083 - lat) + Math.Abs(-37.53944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.83306 - lat) + Math.Abs(-35.75472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.67167 - lat) + Math.Abs(-36.88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75917 - lat) + Math.Abs(-38.22806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.71667 - lat) + Math.Abs(-48.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.05722 - lat) + Math.Abs(-36.36278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.755 - lat) + Math.Abs(-35.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.68611 - lat) + Math.Abs(-40.34972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.59083 - lat) + Math.Abs(-35.11611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.85389 - lat) + Math.Abs(-41.91028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.59889 - lat) + Math.Abs(-40.81778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.77722 - lat) + Math.Abs(-37.95778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.07361 - lat) + Math.Abs(-37.26444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.99194 - lat) + Math.Abs(-38.29833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.53333 - lat) + Math.Abs(-38.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.58806 - lat) + Math.Abs(-39.37167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.59083 - lat) + Math.Abs(-51.95417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.56333 - lat) + Math.Abs(-35.82444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.9725 - lat) + Math.Abs(-36.07528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.93361 - lat) + Math.Abs(-36.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.01528 - lat) + Math.Abs(-42.69944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.02194 - lat) + Math.Abs(-45.48111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.92944 - lat) + Math.Abs(-42.71861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.895 - lat) + Math.Abs(-35.76278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.50361 - lat) + Math.Abs(-41.32333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.78111 - lat) + Math.Abs(-36.09361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.62667 - lat) + Math.Abs(-47.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.46667 - lat) + Math.Abs(-35.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.04167 - lat) + Math.Abs(-44.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.31833 - lat) + Math.Abs(-35.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.52972 - lat) + Math.Abs(-44.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.00222 - lat) + Math.Abs(-35.01833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.47889 - lat) + Math.Abs(-37.27444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.31556 - lat) + Math.Abs(-35.71389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.86139 - lat) + Math.Abs(-38.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.56194 - lat) + Math.Abs(-44.05417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.12056 - lat) + Math.Abs(-38.50194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.07472 - lat) + Math.Abs(-35.23778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.55833 - lat) + Math.Abs(-37.38111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.00972 - lat) + Math.Abs(-36.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.89778 - lat) + Math.Abs(-35.14778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.4325 - lat) + Math.Abs(-35.80444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.495 - lat) + Math.Abs(-43.70222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35806 - lat) + Math.Abs(-42.24667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.77472 - lat) + Math.Abs(-47.17722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.95528 - lat) + Math.Abs(-44.80694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.87556 - lat) + Math.Abs(-36.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.79333 - lat) + Math.Abs(-35.32944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.60722 - lat) + Math.Abs(-38.96833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.40056 - lat) + Math.Abs(-48.555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.64472 - lat) + Math.Abs(-51.995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.57583 - lat) + Math.Abs(-44.38528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.75 - lat) + Math.Abs(-48.02 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36139 - lat) + Math.Abs(-42.41778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.28333 - lat) + Math.Abs(-37.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.69583 - lat) + Math.Abs(-44.82139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.33361 - lat) + Math.Abs(-43.52833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.15194 - lat) + Math.Abs(-48.12944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.31056 - lat) + Math.Abs(-35.47889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.11389 - lat) + Math.Abs(-34.97806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.86358 - lat) + Math.Abs(-43.85999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.44306 - lat) + Math.Abs(-54.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.51556 - lat) + Math.Abs(-42.54667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.33194 - lat) + Math.Abs(-40.15667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.16806 - lat) + Math.Abs(-36.22222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.9575 - lat) + Math.Abs(-36.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.37833 - lat) + Math.Abs(-37.24528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.46056 - lat) + Math.Abs(-40.21222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.35028 - lat) + Math.Abs(-47.57556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.80778 - lat) + Math.Abs(-39.82556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.64265 - lat) + Math.Abs(-47.21738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.87222 - lat) + Math.Abs(-36.91861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.66667 - lat) + Math.Abs(-45.38 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.23111 - lat) + Math.Abs(-45.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.9575 - lat) + Math.Abs(-36.20472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.22944 - lat) + Math.Abs(-36.02278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.61361 - lat) + Math.Abs(-47.35611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.07417 - lat) + Math.Abs(-39.11917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.35694 - lat) + Math.Abs(-35.44056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.94028 - lat) + Math.Abs(-37.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.80306 - lat) + Math.Abs(-35.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.47833 - lat) + Math.Abs(-35.85333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.66877 - lat) + Math.Abs(-35.16277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.51444 - lat) + Math.Abs(-35.37778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.36194 - lat) + Math.Abs(-46.61722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.14167 - lat) + Math.Abs(-40.58222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.94646 - lat) + Math.Abs(-35.78039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.23122 - lat) + Math.Abs(-42.68691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.22583 - lat) + Math.Abs(-38.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.05389 - lat) + Math.Abs(-34.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.51667 - lat) + Math.Abs(-44.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.07417 - lat) + Math.Abs(-37.98861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.19917 - lat) + Math.Abs(-39.29278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.97139 - lat) + Math.Abs(-39.01528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.82778 - lat) + Math.Abs(-36.01167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.31889 - lat) + Math.Abs(-36.47111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.16111 - lat) + Math.Abs(-35.96056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.73667 - lat) + Math.Abs(-37.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.29 - lat) + Math.Abs(-44.49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.8 - lat) + Math.Abs(-53.48 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.05833 - lat) + Math.Abs(-51.18167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.33833 - lat) + Math.Abs(-47.39917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.74833 - lat) + Math.Abs(-52.23833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.91722 - lat) + Math.Abs(-37.27833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.045 - lat) + Math.Abs(-35.39833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.89333 - lat) + Math.Abs(-42.71 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.93556 - lat) + Math.Abs(-50.82111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.14139 - lat) + Math.Abs(-35.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.77028 - lat) + Math.Abs(-37.80167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.3125 - lat) + Math.Abs(-37.28556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.62278 - lat) + Math.Abs(-35.66278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.07667 - lat) + Math.Abs(-36.06111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.66667 - lat) + Math.Abs(-44.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.47056 - lat) + Math.Abs(-34.80861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.78 - lat) + Math.Abs(-35.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.27333 - lat) + Math.Abs(-41.77694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.72667 - lat) + Math.Abs(-44.22333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.92806 - lat) + Math.Abs(-41.70917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.8325 - lat) + Math.Abs(-45.1525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.8375 - lat) + Math.Abs(-40.57917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.52139 - lat) + Math.Abs(-45.0825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.60833 - lat) + Math.Abs(-45.34333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.24528 - lat) + Math.Abs(-41.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.59722 - lat) + Math.Abs(-35.95667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.26722 - lat) + Math.Abs(-35.26 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.51056 - lat) + Math.Abs(-36.34694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.07694 - lat) + Math.Abs(-41.46694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.19806 - lat) + Math.Abs(-37.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.39861 - lat) + Math.Abs(-40.50083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.18306 - lat) + Math.Abs(-38.26889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35778 - lat) + Math.Abs(-36.69639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.79278 - lat) + Math.Abs(-39.27028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.26 - lat) + Math.Abs(-36.72222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.29417 - lat) + Math.Abs(-45.17361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.43917 - lat) + Math.Abs(-35.22139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.42472 - lat) + Math.Abs(-41.45861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.40194 - lat) + Math.Abs(-35.11639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.45417 - lat) + Math.Abs(-39.71722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.49694 - lat) + Math.Abs(-36.94083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21667 - lat) + Math.Abs(-45.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.40611 - lat) + Math.Abs(-38.21472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.94083 - lat) + Math.Abs(-34.87306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.59389 - lat) + Math.Abs(-37.62417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.11 - lat) + Math.Abs(-37.63667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.02444 - lat) + Math.Abs(-37.28 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.60167 - lat) + Math.Abs(-44.07667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.995 - lat) + Math.Abs(-35.58056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.17972 - lat) + Math.Abs(-43.78361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.68167 - lat) + Math.Abs(-43.09333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.09056 - lat) + Math.Abs(-39.57833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.91556 - lat) + Math.Abs(-35.26278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.90472 - lat) + Math.Abs(-41.77667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.62833 - lat) + Math.Abs(-56.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.68778 - lat) + Math.Abs(-36.6575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.21111 - lat) + Math.Abs(-40.69444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.43944 - lat) + Math.Abs(-39.14833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.43306 - lat) + Math.Abs(-43.98361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.96667 - lat) + Math.Abs(-47.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.41 - lat) + Math.Abs(-39.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.74833 - lat) + Math.Abs(-37.43667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.97778 - lat) + Math.Abs(-43.06333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.68333 - lat) + Math.Abs(-35.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.98417 - lat) + Math.Abs(-38.62028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.1725 - lat) + Math.Abs(-38.46056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.8825 - lat) + Math.Abs(-40.08167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.55194 - lat) + Math.Abs(-47.11444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.24444 - lat) + Math.Abs(-38.91361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.745 - lat) + Math.Abs(-35.60222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.76556 - lat) + Math.Abs(-55.86611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.51861 - lat) + Math.Abs(-37.19056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.00889 - lat) + Math.Abs(-34.85528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.00306 - lat) + Math.Abs(-49.85444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.02528 - lat) + Math.Abs(-42.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.49083 - lat) + Math.Abs(-38.59667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.9175 - lat) + Math.Abs(-55.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.53444 - lat) + Math.Abs(-40.77417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.915 - lat) + Math.Abs(-35.64667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.70667 - lat) + Math.Abs(-40.56306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.89174 - lat) + Math.Abs(-59.09542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.45528 - lat) + Math.Abs(-36.20333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.47806 - lat) + Math.Abs(-35.43389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.09111 - lat) + Math.Abs(-35.20861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.18611 - lat) + Math.Abs(-56.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.74167 - lat) + Math.Abs(-35.22778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.64139 - lat) + Math.Abs(-35.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.795 - lat) + Math.Abs(-35.20944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.30667 - lat) + Math.Abs(-35.94333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.02444 - lat) + Math.Abs(-35.46194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.52833 - lat) + Math.Abs(-49.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.44667 - lat) + Math.Abs(-46.30028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11861 - lat) + Math.Abs(-35.09222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.10667 - lat) + Math.Abs(-38.3725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.83333 - lat) + Math.Abs(-47.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.88944 - lat) + Math.Abs(-37.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.88972 - lat) + Math.Abs(-36.30139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.00082 - lat) + Math.Abs(-54.08102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.48583 - lat) + Math.Abs(-35.2875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.56417 - lat) + Math.Abs(-42.60778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.49167 - lat) + Math.Abs(-45.25111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.74306 - lat) + Math.Abs(-39.6275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.88389 - lat) + Math.Abs(-48.76889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.29944 - lat) + Math.Abs(-35.47944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.1875 - lat) + Math.Abs(-37.34417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.58417 - lat) + Math.Abs(-49.50722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.24972 - lat) + Math.Abs(-39.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.37083 - lat) + Math.Abs(-44.36306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.56722 - lat) + Math.Abs(-48.39167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.30528 - lat) + Math.Abs(-36.86472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.31333 - lat) + Math.Abs(-38.94556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.16556 - lat) + Math.Abs(-42.89528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.38333 - lat) + Math.Abs(-35.84167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.115 - lat) + Math.Abs(-51.28944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.38361 - lat) + Math.Abs(-57.71861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.15167 - lat) + Math.Abs(-35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.10056 - lat) + Math.Abs(-45.03361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.71583 - lat) + Math.Abs(-42.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.1175 - lat) + Math.Abs(-37.73222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.20028 - lat) + Math.Abs(-35.78917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.57722 - lat) + Math.Abs(-36.30528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.06 - lat) + Math.Abs(-35.31944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.71028 - lat) + Math.Abs(-35.895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.12389 - lat) + Math.Abs(-40.14667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.7175 - lat) + Math.Abs(-47.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.7825 - lat) + Math.Abs(-35.80889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.01222 - lat) + Math.Abs(-35.2225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.87667 - lat) + Math.Abs(-38.62556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.76614 - lat) + Math.Abs(-47.45371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.04278 - lat) + Math.Abs(-45.95917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.38146 - lat) + Math.Abs(-49.13232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.70611 - lat) + Math.Abs(-38.15444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.83861 - lat) + Math.Abs(-35.12611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.53222 - lat) + Math.Abs(-36.985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.66583 - lat) + Math.Abs(-35.73528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.115 - lat) + Math.Abs(-36.63444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.55472 - lat) + Math.Abs(-35.45306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.03889 - lat) + Math.Abs(-51.06639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85833 - lat) + Math.Abs(-35.35389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.45778 - lat) + Math.Abs(-42.37028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.87917 - lat) + Math.Abs(-41.66694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.14556 - lat) + Math.Abs(-38.09806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.89528 - lat) + Math.Abs(-49.38056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.74056 - lat) + Math.Abs(-36.50278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.87472 - lat) + Math.Abs(-35.45028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75333 - lat) + Math.Abs(-38.96444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.66361 - lat) + Math.Abs(-36.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.28674 - lat) + Math.Abs(-45.23824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.17083 - lat) + Math.Abs(-35.85361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.1 - lat) + Math.Abs(-36.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.93611 - lat) + Math.Abs(-35.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.82972 - lat) + Math.Abs(-36.73778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.15222 - lat) + Math.Abs(-56.09222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.53694 - lat) + Math.Abs(-37.81861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.37333 - lat) + Math.Abs(-35.23806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.92528 - lat) + Math.Abs(-36.47583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.93472 - lat) + Math.Abs(-35.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.03389 - lat) + Math.Abs(-37.02028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.52528 - lat) + Math.Abs(-39.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.21306 - lat) + Math.Abs(-39.31528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.81667 - lat) + Math.Abs(-38.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.53333 - lat) + Math.Abs(-41.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.75639 - lat) + Math.Abs(-42.57556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.62444 - lat) + Math.Abs(-35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.115 - lat) + Math.Abs(-34.86306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.5375 - lat) + Math.Abs(-35.81972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.85583 - lat) + Math.Abs(-35.58833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.88417 - lat) + Math.Abs(-36.82889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.58444 - lat) + Math.Abs(-36.77444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.37861 - lat) + Math.Abs(-37.35194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.46444 - lat) + Math.Abs(-39.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.35917 - lat) + Math.Abs(-41.13778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.83389 - lat) + Math.Abs(-37.78111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.89056 - lat) + Math.Abs(-38.62194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.22222 - lat) + Math.Abs(-57.75278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.61222 - lat) + Math.Abs(-35.29278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.18028 - lat) + Math.Abs(-35.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.13472 - lat) + Math.Abs(-49.32667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.60333 - lat) + Math.Abs(-43.02556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.375 - lat) + Math.Abs(-35.62833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.66778 - lat) + Math.Abs(-35.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.14306 - lat) + Math.Abs(-58.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.30444 - lat) + Math.Abs(-38.15028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.77639 - lat) + Math.Abs(-34.89222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.49444 - lat) + Math.Abs(-39.57861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.3925 - lat) + Math.Abs(-44.35861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.68667 - lat) + Math.Abs(-39.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.74778 - lat) + Math.Abs(-34.82556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.27611 - lat) + Math.Abs(-55.98361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.96944 - lat) + Math.Abs(-38.52806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.44694 - lat) + Math.Abs(-41.47833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.9475 - lat) + Math.Abs(-37.42278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.32861 - lat) + Math.Abs(-35.3325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.77111 - lat) + Math.Abs(-47.43806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.74611 - lat) + Math.Abs(-39.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.03333 - lat) + Math.Abs(-40.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.65194 - lat) + Math.Abs(-40.14889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.32222 - lat) + Math.Abs(-40.71083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.39889 - lat) + Math.Abs(-35.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.49833 - lat) + Math.Abs(-36.855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.66833 - lat) + Math.Abs(-41.70778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.22139 - lat) + Math.Abs(-37.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.28083 - lat) + Math.Abs(-35.60444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.39639 - lat) + Math.Abs(-40.30861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.52639 - lat) + Math.Abs(-47.49167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.38972 - lat) + Math.Abs(-37.50917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.35944 - lat) + Math.Abs(-39.29861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.975 - lat) + Math.Abs(-48.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.12889 - lat) + Math.Abs(-47.62 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.83417 - lat) + Math.Abs(-34.90639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.53694 - lat) + Math.Abs(-36.63361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.40111 - lat) + Math.Abs(-38.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.77583 - lat) + Math.Abs(-44.06583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.54056 - lat) + Math.Abs(-37.69028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.92333 - lat) + Math.Abs(-40.88944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.9725 - lat) + Math.Abs(-35.93944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.59833 - lat) + Math.Abs(-43.46111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.1 - lat) + Math.Abs(-38.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.40806 - lat) + Math.Abs(-40.43778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.405 - lat) + Math.Abs(-51.64 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.12389 - lat) + Math.Abs(-35.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.16694 - lat) + Math.Abs(-40.7475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.85472 - lat) + Math.Abs(-35.49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.96667 - lat) + Math.Abs(-57.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.03972 - lat) + Math.Abs(-38.63722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.41667 - lat) + Math.Abs(-35.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.20111 - lat) + Math.Abs(-35.56472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.12028 - lat) + Math.Abs(-40.82611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.81944 - lat) + Math.Abs(-46.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.45889 - lat) + Math.Abs(-37.52083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.26472 - lat) + Math.Abs(-35.2125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.56056 - lat) + Math.Abs(-35.0025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.00167 - lat) + Math.Abs(-35.29278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.83167 - lat) + Math.Abs(-45.34389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.9675 - lat) + Math.Abs(-37.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.88202 - lat) + Math.Abs(-36.50216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.58444 - lat) + Math.Abs(-35.38667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.73333 - lat) + Math.Abs(-44.15833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.71722 - lat) + Math.Abs(-38.54306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.79833 - lat) + Math.Abs(-40.26056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.76694 - lat) + Math.Abs(-43.0225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.60111 - lat) + Math.Abs(-38.56861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.86806 - lat) + Math.Abs(-37.97472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.1975 - lat) + Math.Abs(-35.78083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.95083 - lat) + Math.Abs(-35.38917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.93056 - lat) + Math.Abs(-39.56556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.355 - lat) + Math.Abs(-35.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.51194 - lat) + Math.Abs(-39.72417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.89 - lat) + Math.Abs(-38.45056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.70556 - lat) + Math.Abs(-35.30722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.78333 - lat) + Math.Abs(-43.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.86667 - lat) + Math.Abs(-44.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.90167 - lat) + Math.Abs(-42.23361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.03306 - lat) + Math.Abs(-35.85722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35917 - lat) + Math.Abs(-35.22361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.20194 - lat) + Math.Abs(-42.14028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.61354 - lat) + Math.Abs(-35.62654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.03749 - lat) + Math.Abs(-44.43857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.3925 - lat) + Math.Abs(-37.10056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.29056 - lat) + Math.Abs(-37.09389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.35833 - lat) + Math.Abs(-42.67639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.38861 - lat) + Math.Abs(-37.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.0875 - lat) + Math.Abs(-37.64306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.82833 - lat) + Math.Abs(-44.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.72889 - lat) + Math.Abs(-47.84806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.26083 - lat) + Math.Abs(-36.51778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.99028 - lat) + Math.Abs(-39.90944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.61667 - lat) + Math.Abs(-35.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.00611 - lat) + Math.Abs(-35.69722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.48361 - lat) + Math.Abs(-36.15361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.14 - lat) + Math.Abs(-35.08639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.9211 - lat) + Math.Abs(-40.17589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.23417 - lat) + Math.Abs(-39.40944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.17833 - lat) + Math.Abs(-40.6775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.13 - lat) + Math.Abs(-44.12417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.01444 - lat) + Math.Abs(-37.94583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.53333 - lat) + Math.Abs(-40.65667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.58583 - lat) + Math.Abs(-35.10583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.26441 - lat) + Math.Abs(-49.26982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.90889 - lat) + Math.Abs(-35.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.02583 - lat) + Math.Abs(-44.24917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.63222 - lat) + Math.Abs(-36.57861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.25667 - lat) + Math.Abs(-43.01278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.45528 - lat) + Math.Abs(-43.88556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.47194 - lat) + Math.Abs(-41.5575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.30028 - lat) + Math.Abs(-38.49778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.74167 - lat) + Math.Abs(-43.36028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.23833 - lat) + Math.Abs(-35.46167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.04556 - lat) + Math.Abs(-36.34583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.60667 - lat) + Math.Abs(-39.06222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.63444 - lat) + Math.Abs(-35.42556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.85889 - lat) + Math.Abs(-43.35611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.73611 - lat) + Math.Abs(-38.65306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.34389 - lat) + Math.Abs(-37.74667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.66667 - lat) + Math.Abs(-35.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.32222 - lat) + Math.Abs(-41.5525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.29389 - lat) + Math.Abs(-47.92639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.13306 - lat) + Math.Abs(-38.24194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.195 - lat) + Math.Abs(-46.02 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.28333 - lat) + Math.Abs(-35.97611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.85083 - lat) + Math.Abs(-35.25472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.33561 - lat) + Math.Abs(-47.46218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.7 - lat) + Math.Abs(-37.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.04222 - lat) + Math.Abs(-39.28361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.95056 - lat) + Math.Abs(-40.47333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.19695 - lat) + Math.Abs(-59.82674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.7925 - lat) + Math.Abs(-37.55667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.73472 - lat) + Math.Abs(-36.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.74639 - lat) + Math.Abs(-47.05944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.4075 - lat) + Math.Abs(-36.07361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.19583 - lat) + Math.Abs(-47.18083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11 - lat) + Math.Abs(-42.94444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.63333 - lat) + Math.Abs(-44.37667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.66 - lat) + Math.Abs(-37.78944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.35889 - lat) + Math.Abs(-39.31167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.88222 - lat) + Math.Abs(-36.19111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.38 - lat) + Math.Abs(-35.12889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.44667 - lat) + Math.Abs(-45.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.07444 - lat) + Math.Abs(-40.37611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.82778 - lat) + Math.Abs(-42.16861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.78194 - lat) + Math.Abs(-36.35083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.23056 - lat) + Math.Abs(-35.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35861 - lat) + Math.Abs(-35.76194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.90222 - lat) + Math.Abs(-40.84111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.24444 - lat) + Math.Abs(-49.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.71667 - lat) + Math.Abs(-36.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.89028 - lat) + Math.Abs(-38.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.45833 - lat) + Math.Abs(-37.09778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.77306 - lat) + Math.Abs(-36.6225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.40028 - lat) + Math.Abs(-36.99028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.64167 - lat) + Math.Abs(-35.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.48639 - lat) + Math.Abs(-36.23306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.51417 - lat) + Math.Abs(-39.31 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.28333 - lat) + Math.Abs(-35.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.98111 - lat) + Math.Abs(-34.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.51556 - lat) + Math.Abs(-34.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.175 - lat) + Math.Abs(-41.86694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.83722 - lat) + Math.Abs(-43.83361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.515 - lat) + Math.Abs(-48.04472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.62306 - lat) + Math.Abs(-37.15583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.68222 - lat) + Math.Abs(-50.48028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.49333 - lat) + Math.Abs(-38.98722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.14583 - lat) + Math.Abs(-36.37111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.68444 - lat) + Math.Abs(-42.75028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.19083 - lat) + Math.Abs(-35.35667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.05361 - lat) + Math.Abs(-46.76556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.39143 - lat) + Math.Abs(-59.58864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.48237 - lat) + Math.Abs(-36.13422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.47028 - lat) + Math.Abs(-35.72861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.07444 - lat) + Math.Abs(-44.35861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.79583 - lat) + Math.Abs(-35.58722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.01667 - lat) + Math.Abs(-46.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.16972 - lat) + Math.Abs(-36.67972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.1275 - lat) + Math.Abs(-39.73222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.23333 - lat) + Math.Abs(-35.79694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.44889 - lat) + Math.Abs(-44.7825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.36139 - lat) + Math.Abs(-48.24472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.45 - lat) + Math.Abs(-42.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.33556 - lat) + Math.Abs(-36.42417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.18861 - lat) + Math.Abs(-37.53583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.75389 - lat) + Math.Abs(-38.96583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.69167 - lat) + Math.Abs(-35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.45583 - lat) + Math.Abs(-48.50444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.05056 - lat) + Math.Abs(-40.16778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.17972 - lat) + Math.Abs(-38.13056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.125 - lat) + Math.Abs(-34.93222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.32861 - lat) + Math.Abs(-38.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.67778 - lat) + Math.Abs(-37.12472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.025 - lat) + Math.Abs(-42.075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.01889 - lat) + Math.Abs(-41.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.71667 - lat) + Math.Abs(-38.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.81833 - lat) + Math.Abs(-35.18639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.75556 - lat) + Math.Abs(-42.82591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.79333 - lat) + Math.Abs(-57.07 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.24444 - lat) + Math.Abs(-42.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.50556 - lat) + Math.Abs(-45.24333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.40472 - lat) + Math.Abs(-35.50722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.50583 - lat) + Math.Abs(-48.62583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.31111 - lat) + Math.Abs(-39.30417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.08 - lat) + Math.Abs(-37.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75 - lat) + Math.Abs(-35.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.5325 - lat) + Math.Abs(-46.03556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.79056 - lat) + Math.Abs(-49.67167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.29167 - lat) + Math.Abs(-44.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.57972 - lat) + Math.Abs(-59.13056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.9425 - lat) + Math.Abs(-38.9675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.02167 - lat) + Math.Abs(-46.635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.50194 - lat) + Math.Abs(-36.02278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.87444 - lat) + Math.Abs(-39.875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.54528 - lat) + Math.Abs(-35.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.19444 - lat) + Math.Abs(-35.16028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.95611 - lat) + Math.Abs(-37.13694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.96333 - lat) + Math.Abs(-35.69167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.41889 - lat) + Math.Abs(-37.05389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.55833 - lat) + Math.Abs(-35.74167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.57611 - lat) + Math.Abs(-40.49833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.21337 - lat) + Math.Abs(-40.137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.45361 - lat) + Math.Abs(-44.78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.82833 - lat) + Math.Abs(-35.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.7525 - lat) + Math.Abs(-36.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.89 - lat) + Math.Abs(-41.90306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.19111 - lat) + Math.Abs(-48.20722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.79028 - lat) + Math.Abs(-35.09083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.37111 - lat) + Math.Abs(-38.81417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.56167 - lat) + Math.Abs(-37.76972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.90139 - lat) + Math.Abs(-38.39111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.66417 - lat) + Math.Abs(-37.79889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.66556 - lat) + Math.Abs(-36.60111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.36556 - lat) + Math.Abs(-48.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.26444 - lat) + Math.Abs(-44.61972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.68444 - lat) + Math.Abs(-36.30417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36167 - lat) + Math.Abs(-39.83167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.56667 - lat) + Math.Abs(-46.74222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.24316 - lat) + Math.Abs(-42.84544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.38306 - lat) + Math.Abs(-35.4525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.03806 - lat) + Math.Abs(-42.46 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.25111 - lat) + Math.Abs(-42.21028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.48972 - lat) + Math.Abs(-36.05944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.20333 - lat) + Math.Abs(-52.20639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.52333 - lat) + Math.Abs(-52.58167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.43861 - lat) + Math.Abs(-34.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4125 - lat) + Math.Abs(-38.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.94167 - lat) + Math.Abs(-54.73833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.4041 - lat) + Math.Abs(-44.41669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.95 - lat) + Math.Abs(-35.545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.07083 - lat) + Math.Abs(-35.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.15833 - lat) + Math.Abs(-35.63 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.11139 - lat) + Math.Abs(-37.12306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.7075 - lat) + Math.Abs(-35.53056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.26083 - lat) + Math.Abs(-37.93611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.89222 - lat) + Math.Abs(-42.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.45806 - lat) + Math.Abs(-35.94472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.15667 - lat) + Math.Abs(-50.38667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.49833 - lat) + Math.Abs(-36.50556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.75083 - lat) + Math.Abs(-37.63917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.57667 - lat) + Math.Abs(-36.90861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.09528 - lat) + Math.Abs(-39.4525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.88556 - lat) + Math.Abs(-40.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.96083 - lat) + Math.Abs(-48.19667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.91167 - lat) + Math.Abs(-34.90278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.71806 - lat) + Math.Abs(-48.8825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.82294 - lat) + Math.Abs(-42.72815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.03889 - lat) + Math.Abs(-49.70944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.87694 - lat) + Math.Abs(-52.40417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.42278 - lat) + Math.Abs(-49.97278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.54667 - lat) + Math.Abs(-47.43778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.52306 - lat) + Math.Abs(-44.10417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.86611 - lat) + Math.Abs(-40.83944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.31944 - lat) + Math.Abs(-40.33778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.01028 - lat) + Math.Abs(-42.84056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.87306 - lat) + Math.Abs(-48.29694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.02972 - lat) + Math.Abs(-46.97528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.32972 - lat) + Math.Abs(-40.2925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.00833 - lat) + Math.Abs(-51.15167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.75389 - lat) + Math.Abs(-42.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.74194 - lat) + Math.Abs(-48.51639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.39028 - lat) + Math.Abs(-40.49611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.08111 - lat) + Math.Abs(-51.02333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.69194 - lat) + Math.Abs(-43.92333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.93611 - lat) + Math.Abs(-51.54944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.63333 - lat) + Math.Abs(-41.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.87389 - lat) + Math.Abs(-49.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.60639 - lat) + Math.Abs(-52.19194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.98694 - lat) + Math.Abs(-46.90778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.40389 - lat) + Math.Abs(-43.6625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.70139 - lat) + Math.Abs(-44.0275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21139 - lat) + Math.Abs(-46.82833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.64667 - lat) + Math.Abs(-56.1325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5976 - lat) + Math.Abs(-44.73367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.55139 - lat) + Math.Abs(-45.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.83222 - lat) + Math.Abs(-46.89361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.67139 - lat) + Math.Abs(-41.00694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.22778 - lat) + Math.Abs(-50.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.97056 - lat) + Math.Abs(-46.99583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.41222 - lat) + Math.Abs(-39.46194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.24556 - lat) + Math.Abs(-43.70028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.37028 - lat) + Math.Abs(-39.07306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.51222 - lat) + Math.Abs(-50.93389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.51778 - lat) + Math.Abs(-49.32083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.20167 - lat) + Math.Abs(-49.29 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.75472 - lat) + Math.Abs(-57.08833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.59306 - lat) + Math.Abs(-39.28444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.5036 - lat) + Math.Abs(-49.68266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.52472 - lat) + Math.Abs(-49.14083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23 - lat) + Math.Abs(-51.08639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.3575 - lat) + Math.Abs(-46.90611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.29333 - lat) + Math.Abs(-39.07528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.76639 - lat) + Math.Abs(-53.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.38333 - lat) + Math.Abs(-37.65778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.91861 - lat) + Math.Abs(-48.27722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.74833 - lat) + Math.Abs(-47.93194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.43389 - lat) + Math.Abs(-45.07111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.20906 - lat) + Math.Abs(-39.52641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.3125 - lat) + Math.Abs(-39.32333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.26806 - lat) + Math.Abs(-39.66278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.12 - lat) + Math.Abs(-42.94278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.28556 - lat) + Math.Abs(-42.73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.38111 - lat) + Math.Abs(-51.57056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.08056 - lat) + Math.Abs(-53.83583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.59222 - lat) + Math.Abs(-48.705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.93472 - lat) + Math.Abs(-50.51361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.95817 - lat) + Math.Abs(-38.79084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.46667 - lat) + Math.Abs(-49.00694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.94333 - lat) + Math.Abs(-51.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.64944 - lat) + Math.Abs(-49.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.11667 - lat) + Math.Abs(-43.20917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.36667 - lat) + Math.Abs(-45.5125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.45556 - lat) + Math.Abs(-53.93194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.78765 - lat) + Math.Abs(-51.70338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.77333 - lat) + Math.Abs(-54.24 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.51694 - lat) + Math.Abs(-50.77778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.69694 - lat) + Math.Abs(-45.25333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.10639 - lat) + Math.Abs(-50.32222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.95833 - lat) + Math.Abs(-45.54944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.97583 - lat) + Math.Abs(-41.41083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.98472 - lat) + Math.Abs(-50.13361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.33528 - lat) + Math.Abs(-49.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.37333 - lat) + Math.Abs(-37.84056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.71361 - lat) + Math.Abs(-53.74306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.175 - lat) + Math.Abs(-43.01778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.18389 - lat) + Math.Abs(-37.99833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.11028 - lat) + Math.Abs(-44.17806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.58106 - lat) + Math.Abs(-42.64953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.82333 - lat) + Math.Abs(-49.27167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.24139 - lat) + Math.Abs(-48.63361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10194 - lat) + Math.Abs(-47.71472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.50944 - lat) + Math.Abs(-50.41361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.44806 - lat) + Math.Abs(-51.80639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.85571 - lat) + Math.Abs(-50.0314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.70944 - lat) + Math.Abs(-52.61694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36667 - lat) + Math.Abs(-40.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.76806 - lat) + Math.Abs(-52.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4167 - lat) + Math.Abs(-42.97822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.44222 - lat) + Math.Abs(-54.86028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.8575 - lat) + Math.Abs(-41.50528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.5325 - lat) + Math.Abs(-52.1675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.32389 - lat) + Math.Abs(-50.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.02639 - lat) + Math.Abs(-45.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.35556 - lat) + Math.Abs(-47.85694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74667 - lat) + Math.Abs(-50.57722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.53306 - lat) + Math.Abs(-49.24444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.40611 - lat) + Math.Abs(-48.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.79972 - lat) + Math.Abs(-51.86444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.65056 - lat) + Math.Abs(-50.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.84722 - lat) + Math.Abs(-40.79139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.67333 - lat) + Math.Abs(-51.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53806 - lat) + Math.Abs(-39.09861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.06806 - lat) + Math.Abs(-52.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.73306 - lat) + Math.Abs(-52.87333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.02139 - lat) + Math.Abs(-41.24806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73028 - lat) + Math.Abs(-42.71417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.62639 - lat) + Math.Abs(-49.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.705 - lat) + Math.Abs(-47.27444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.80778 - lat) + Math.Abs(-42.23306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.40389 - lat) + Math.Abs(-46.43611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.62611 - lat) + Math.Abs(-46.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.71667 - lat) + Math.Abs(-48.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5425 - lat) + Math.Abs(-46.31083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.82194 - lat) + Math.Abs(-47.26694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.50167 - lat) + Math.Abs(-47.45806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.11389 - lat) + Math.Abs(-49.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.81833 - lat) + Math.Abs(-52.51028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.59139 - lat) + Math.Abs(-46.52889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.83333 - lat) + Math.Abs(-39.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.68889 - lat) + Math.Abs(-49.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.73833 - lat) + Math.Abs(-37.81111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.65889 - lat) + Math.Abs(-48.60806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.65083 - lat) + Math.Abs(-42.39167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93194 - lat) + Math.Abs(-54.96139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.59778 - lat) + Math.Abs(-49.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.80944 - lat) + Math.Abs(-48.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.46583 - lat) + Math.Abs(-44.24667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13778 - lat) + Math.Abs(-47.99028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.05861 - lat) + Math.Abs(-51.03639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.60472 - lat) + Math.Abs(-43.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66417 - lat) + Math.Abs(-39.0075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.61222 - lat) + Math.Abs(-46.70056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.21139 - lat) + Math.Abs(-47.59556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.12861 - lat) + Math.Abs(-40.30778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74389 - lat) + Math.Abs(-43.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.46139 - lat) + Math.Abs(-40.18944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.11335 - lat) + Math.Abs(-49.46315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.70806 - lat) + Math.Abs(-49.09306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.41713 - lat) + Math.Abs(-41.77049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.4125 - lat) + Math.Abs(-49.07306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.7375 - lat) + Math.Abs(-38.76861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03528 - lat) + Math.Abs(-44.14472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.94389 - lat) + Math.Abs(-52.92306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.44361 - lat) + Math.Abs(-51.87389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.92 - lat) + Math.Abs(-42.51028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.83333 - lat) + Math.Abs(-51.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.995 - lat) + Math.Abs(-42.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.63806 - lat) + Math.Abs(-51.00694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.96306 - lat) + Math.Abs(-46.39194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.47917 - lat) + Math.Abs(-47.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.16056 - lat) + Math.Abs(-53.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.5125 - lat) + Math.Abs(-38.49528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.91694 - lat) + Math.Abs(-46.99139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.58667 - lat) + Math.Abs(-51.37556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.76 - lat) + Math.Abs(-45.40972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.52917 - lat) + Math.Abs(-47.13528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.62056 - lat) + Math.Abs(-54.17889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.83917 - lat) + Math.Abs(-42.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.54861 - lat) + Math.Abs(-47.91389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5475 - lat) + Math.Abs(-46.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.34806 - lat) + Math.Abs(-54.23778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.275 - lat) + Math.Abs(-50.16278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.87417 - lat) + Math.Abs(-50.38278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.72011 - lat) + Math.Abs(-39.85891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.97111 - lat) + Math.Abs(-51.06806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73111 - lat) + Math.Abs(-48.57056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.40833 - lat) + Math.Abs(-54.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.525 - lat) + Math.Abs(-50.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.36528 - lat) + Math.Abs(-51.97833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.35917 - lat) + Math.Abs(-52.85111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.8525 - lat) + Math.Abs(-46.9425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.11639 - lat) + Math.Abs(-45.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.76028 - lat) + Math.Abs(-51.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.5302 - lat) + Math.Abs(-49.20836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.17944 - lat) + Math.Abs(-45.88694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.81972 - lat) + Math.Abs(-49.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.59556 - lat) + Math.Abs(-46.88861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.02528 - lat) + Math.Abs(-41.65444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.21171 - lat) + Math.Abs(-49.1632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.04917 - lat) + Math.Abs(-44.27389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58139 - lat) + Math.Abs(-47.85472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.29389 - lat) + Math.Abs(-49.93167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.54 - lat) + Math.Abs(-43.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.54778 - lat) + Math.Abs(-42.76333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.31361 - lat) + Math.Abs(-42.01444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.80389 - lat) + Math.Abs(-43.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13556 - lat) + Math.Abs(-44.26167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.92917 - lat) + Math.Abs(-44.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.96917 - lat) + Math.Abs(-46.79806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.64028 - lat) + Math.Abs(-41.05111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.27611 - lat) + Math.Abs(-48.84944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.95917 - lat) + Math.Abs(-51.72222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.31111 - lat) + Math.Abs(-46.04889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.43333 - lat) + Math.Abs(-38.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.89222 - lat) + Math.Abs(-45.59528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.82694 - lat) + Math.Abs(-43.05389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.33639 - lat) + Math.Abs(-54.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.24333 - lat) + Math.Abs(-48.63806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.6275 - lat) + Math.Abs(-38.68 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.44806 - lat) + Math.Abs(-50.58361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.55028 - lat) + Math.Abs(-55.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.94861 - lat) + Math.Abs(-44.86444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.64611 - lat) + Math.Abs(-41.74694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.8386 - lat) + Math.Abs(-41.39174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.865 - lat) + Math.Abs(-42.96833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.39833 - lat) + Math.Abs(-46.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36333 - lat) + Math.Abs(-44.97333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.01472 - lat) + Math.Abs(-37.20639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.0175 - lat) + Math.Abs(-47.89083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.62306 - lat) + Math.Abs(-46.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.66056 - lat) + Math.Abs(-56.00444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.69389 - lat) + Math.Abs(-46.565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.25028 - lat) + Math.Abs(-49.37861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.45667 - lat) + Math.Abs(-43.5525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.96083 - lat) + Math.Abs(-46.33361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.43028 - lat) + Math.Abs(-39.25139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.85083 - lat) + Math.Abs(-53.77722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.07361 - lat) + Math.Abs(-53.72528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.08722 - lat) + Math.Abs(-45.29361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.86556 - lat) + Math.Abs(-56.07667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.94639 - lat) + Math.Abs(-44.91889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.60611 - lat) + Math.Abs(-46.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53944 - lat) + Math.Abs(-42.18028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.96889 - lat) + Math.Abs(-39.26139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.295 - lat) + Math.Abs(-50.07722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.29917 - lat) + Math.Abs(-54.26306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.66389 - lat) + Math.Abs(-46.53833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.83833 - lat) + Math.Abs(-51.61028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.78889 - lat) + Math.Abs(-37.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.68806 - lat) + Math.Abs(-48.77861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.54667 - lat) + Math.Abs(-38.71194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.19167 - lat) + Math.Abs(-54.86722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.51889 - lat) + Math.Abs(-53.36806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.83861 - lat) + Math.Abs(-50.12139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.47059 - lat) + Math.Abs(-50.51359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.93556 - lat) + Math.Abs(-40.60028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.47278 - lat) + Math.Abs(-47.36306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.87083 - lat) + Math.Abs(-54.48139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.25222 - lat) + Math.Abs(-45.70333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.71028 - lat) + Math.Abs(-47.47806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.36361 - lat) + Math.Abs(-42.56861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.89083 - lat) + Math.Abs(-55.53278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.44417 - lat) + Math.Abs(-46.91778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.46667 - lat) + Math.Abs(-41.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.19028 - lat) + Math.Abs(-42.41417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.38814 - lat) + Math.Abs(-44.19868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.68417 - lat) + Math.Abs(-53.80694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.76972 - lat) + Math.Abs(-43.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.25583 - lat) + Math.Abs(-39.37472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10056 - lat) + Math.Abs(-40.52972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.31556 - lat) + Math.Abs(-46.22139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.29222 - lat) + Math.Abs(-39.81889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.81361 - lat) + Math.Abs(-50.59694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.45667 - lat) + Math.Abs(-47.53028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21111 - lat) + Math.Abs(-50.92583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.7175 - lat) + Math.Abs(-52.42583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.89889 - lat) + Math.Abs(-49.6325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.82694 - lat) + Math.Abs(-47.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.27806 - lat) + Math.Abs(-39.02472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.96083 - lat) + Math.Abs(-50.42694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.39667 - lat) + Math.Abs(-45.88389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.75361 - lat) + Math.Abs(-47.41361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.24278 - lat) + Math.Abs(-48.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.94972 - lat) + Math.Abs(-51.80667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.97111 - lat) + Math.Abs(-38.51083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.64889 - lat) + Math.Abs(-47.57333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.20083 - lat) + Math.Abs(-47.28694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.17028 - lat) + Math.Abs(-42.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.03194 - lat) + Math.Abs(-37.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.86528 - lat) + Math.Abs(-47.44 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.66611 - lat) + Math.Abs(-43.08389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.28389 - lat) + Math.Abs(-40.49389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.16444 - lat) + Math.Abs(-49.80333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.83611 - lat) + Math.Abs(-56.4275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.25833 - lat) + Math.Abs(-54.91417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.47083 - lat) + Math.Abs(-54.63556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.65056 - lat) + Math.Abs(-50.57583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.30972 - lat) + Math.Abs(-51.36917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.92278 - lat) + Math.Abs(-49.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.91806 - lat) + Math.Abs(-54.84417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.79806 - lat) + Math.Abs(-50.92806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.64529 - lat) + Math.Abs(-48.47486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.48472 - lat) + Math.Abs(-37.93278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.27472 - lat) + Math.Abs(-43.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.92917 - lat) + Math.Abs(-43.17417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.60972 - lat) + Math.Abs(-42.53972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.98972 - lat) + Math.Abs(-52.37806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.8625 - lat) + Math.Abs(-40.93639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.47703 - lat) + Math.Abs(-43.12589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.10583 - lat) + Math.Abs(-49.7975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.25444 - lat) + Math.Abs(-49.51833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.98083 - lat) + Math.Abs(-49.68194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.74417 - lat) + Math.Abs(-46.39833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.035 - lat) + Math.Abs(-52.09861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.21417 - lat) + Math.Abs(-49.64306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.90642 - lat) + Math.Abs(-43.18223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.84333 - lat) + Math.Abs(-47.60611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.52694 - lat) + Math.Abs(-41.945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.72306 - lat) + Math.Abs(-44.13556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.41139 - lat) + Math.Abs(-47.56139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.22611 - lat) + Math.Abs(-42.65083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.80194 - lat) + Math.Abs(-54.54639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.19 - lat) + Math.Abs(-49.31417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.70861 - lat) + Math.Abs(-42.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.265 - lat) + Math.Abs(-40.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.53944 - lat) + Math.Abs(-37.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.1775 - lat) + Math.Abs(-47.81028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.71056 - lat) + Math.Abs(-46.41333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.76694 - lat) + Math.Abs(-44.08667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.69934 - lat) + Math.Abs(-48.53219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.22083 - lat) + Math.Abs(-48.76556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.06667 - lat) + Math.Abs(-48.17611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.83444 - lat) + Math.Abs(-38.53583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.44306 - lat) + Math.Abs(-53.75917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.315 - lat) + Math.Abs(-49.58444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.60917 - lat) + Math.Abs(-42.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.80694 - lat) + Math.Abs(-39.38556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.06889 - lat) + Math.Abs(-37.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.74611 - lat) + Math.Abs(-44.91 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.32556 - lat) + Math.Abs(-41.25528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.65028 - lat) + Math.Abs(-50.85056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.46889 - lat) + Math.Abs(-44.44667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.4875 - lat) + Math.Abs(-47.84361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.22139 - lat) + Math.Abs(-51.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.525 - lat) + Math.Abs(-42.46917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.76889 - lat) + Math.Abs(-53.5325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.96722 - lat) + Math.Abs(-43.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.22917 - lat) + Math.Abs(-50.89306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.44833 - lat) + Math.Abs(-50.45167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.7525 - lat) + Math.Abs(-39.20917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.71611 - lat) + Math.Abs(-43.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.97833 - lat) + Math.Abs(-39.62639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.36556 - lat) + Math.Abs(-49.07694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.40722 - lat) + Math.Abs(-44.25806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.2475 - lat) + Math.Abs(-50.69833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.3875 - lat) + Math.Abs(-56.45139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.21306 - lat) + Math.Abs(-50.97778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.21111 - lat) + Math.Abs(-36.84028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53667 - lat) + Math.Abs(-49.85806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.87611 - lat) + Math.Abs(-51.84389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.12556 - lat) + Math.Abs(-51.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.41778 - lat) + Math.Abs(-46.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.76333 - lat) + Math.Abs(-52.11556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.00611 - lat) + Math.Abs(-51.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.30722 - lat) + Math.Abs(-48.92417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.00583 - lat) + Math.Abs(-46.40278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.35944 - lat) + Math.Abs(-48.06556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.34111 - lat) + Math.Abs(-39.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.83722 - lat) + Math.Abs(-54.38917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.23 - lat) + Math.Abs(-45.93639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09306 - lat) + Math.Abs(-46.36944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23806 - lat) + Math.Abs(-51.07833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.44972 - lat) + Math.Abs(-39.06472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.18583 - lat) + Math.Abs(-36.84 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.41972 - lat) + Math.Abs(-44.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.69889 - lat) + Math.Abs(-57.8825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.85389 - lat) + Math.Abs(-47.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21472 - lat) + Math.Abs(-47.52389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.15778 - lat) + Math.Abs(-48.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.96667 - lat) + Math.Abs(-53.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.03283 - lat) + Math.Abs(-51.23019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.74333 - lat) + Math.Abs(-43.02833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.70167 - lat) + Math.Abs(-51.24194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.75583 - lat) + Math.Abs(-51.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.96278 - lat) + Math.Abs(-42.04083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.44083 - lat) + Math.Abs(-49.14861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.17583 - lat) + Math.Abs(-48.125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.86278 - lat) + Math.Abs(-40.13361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.22611 - lat) + Math.Abs(-59.33528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.41639 - lat) + Math.Abs(-42.90861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.53611 - lat) + Math.Abs(-55.72556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.525 - lat) + Math.Abs(-49.44722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.0225 - lat) + Math.Abs(-48.03722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.095 - lat) + Math.Abs(-50.16194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.22444 - lat) + Math.Abs(-44.93528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.10861 - lat) + Math.Abs(-50.17167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.74056 - lat) + Math.Abs(-49.17694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.70833 - lat) + Math.Abs(-38.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.78778 - lat) + Math.Abs(-46.56139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.25667 - lat) + Math.Abs(-56.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.52972 - lat) + Math.Abs(-40.36528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.52806 - lat) + Math.Abs(-46.34472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.45278 - lat) + Math.Abs(-47.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.83778 - lat) + Math.Abs(-40.72194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46528 - lat) + Math.Abs(-45.95806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.68278 - lat) + Math.Abs(-44.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.00944 - lat) + Math.Abs(-48.22167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.75722 - lat) + Math.Abs(-51.76139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73028 - lat) + Math.Abs(-40.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.29972 - lat) + Math.Abs(-48.27944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.85072 - lat) + Math.Abs(-48.96087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.44227 - lat) + Math.Abs(-49.06795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.27528 - lat) + Math.Abs(-51.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.39694 - lat) + Math.Abs(-47.00222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.345 - lat) + Math.Abs(-44.94194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.42694 - lat) + Math.Abs(-51.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.99861 - lat) + Math.Abs(-49.45722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.19361 - lat) + Math.Abs(-49.38389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.52611 - lat) + Math.Abs(-49.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.62917 - lat) + Math.Abs(-43.89806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.99611 - lat) + Math.Abs(-47.42583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.72528 - lat) + Math.Abs(-47.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.30278 - lat) + Math.Abs(-49.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.05389 - lat) + Math.Abs(-46.35806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.61361 - lat) + Math.Abs(-45.17611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.78333 - lat) + Math.Abs(-52.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.57833 - lat) + Math.Abs(-53.38111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.51278 - lat) + Math.Abs(-44.00056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.69556 - lat) + Math.Abs(-51.65972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.11583 - lat) + Math.Abs(-46.68278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.18583 - lat) + Math.Abs(-48.90722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.74167 - lat) + Math.Abs(-40.36083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.92389 - lat) + Math.Abs(-45.46167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.81306 - lat) + Math.Abs(-47.71639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.71194 - lat) + Math.Abs(-47.42778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.40556 - lat) + Math.Abs(-36.43444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.505 - lat) + Math.Abs(-43.17861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.095 - lat) + Math.Abs(-49.33806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.32 - lat) + Math.Abs(-46.99833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.63833 - lat) + Math.Abs(-51.10917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.09083 - lat) + Math.Abs(-45.09139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.76944 - lat) + Math.Abs(-48.64583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.29028 - lat) + Math.Abs(-36.58639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.41972 - lat) + Math.Abs(-50.0775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.76997 - lat) + Math.Abs(-52.34101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.61806 - lat) + Math.Abs(-44.04306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74194 - lat) + Math.Abs(-46.90139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25694 - lat) + Math.Abs(-47.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.00528 - lat) + Math.Abs(-41.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.35167 - lat) + Math.Abs(-48.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.54861 - lat) + Math.Abs(-42.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.91278 - lat) + Math.Abs(-52.34306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.76111 - lat) + Math.Abs(-47.15417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.46417 - lat) + Math.Abs(-39.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.94389 - lat) + Math.Abs(-46.9925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.57889 - lat) + Math.Abs(-46.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.22861 - lat) + Math.Abs(-52.67056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.42861 - lat) + Math.Abs(-43.41861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88828 - lat) + Math.Abs(-39.85593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.71889 - lat) + Math.Abs(-46.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.26278 - lat) + Math.Abs(-52.40667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.39028 - lat) + Math.Abs(-44.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.62861 - lat) + Math.Abs(-50.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.715 - lat) + Math.Abs(-47.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.6875 - lat) + Math.Abs(-37.86167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.94778 - lat) + Math.Abs(-50.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.69056 - lat) + Math.Abs(-43.18417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.21778 - lat) + Math.Abs(-44.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.89278 - lat) + Math.Abs(-55.43111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.07306 - lat) + Math.Abs(-52.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.3863 - lat) + Math.Abs(-48.72441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.67722 - lat) + Math.Abs(-51.19083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.51626 - lat) + Math.Abs(-48.52537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.4425 - lat) + Math.Abs(-42.23889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.55417 - lat) + Math.Abs(-45.78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.01639 - lat) + Math.Abs(-48.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.0175 - lat) + Math.Abs(-53.01222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.15847 - lat) + Math.Abs(-43.29321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.41278 - lat) + Math.Abs(-50.57583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.54722 - lat) + Math.Abs(-45.7375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.86028 - lat) + Math.Abs(-44.60833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.22222 - lat) + Math.Abs(-46.87472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.60829 - lat) + Math.Abs(-43.7084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.44917 - lat) + Math.Abs(-44.74778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.77972 - lat) + Math.Abs(-48.50861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.35639 - lat) + Math.Abs(-51.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.225 - lat) + Math.Abs(-40.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.2925 - lat) + Math.Abs(-53.50167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.28389 - lat) + Math.Abs(-53.84 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.78889 - lat) + Math.Abs(-50.2175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.805 - lat) + Math.Abs(-49.92583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.89944 - lat) + Math.Abs(-53.31361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.42944 - lat) + Math.Abs(-50.00639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26722 - lat) + Math.Abs(-43.16194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48417 - lat) + Math.Abs(-51.99056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.25778 - lat) + Math.Abs(-50.50972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.64528 - lat) + Math.Abs(-48.66778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.4575 - lat) + Math.Abs(-52.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.07417 - lat) + Math.Abs(-41.48444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.16595 - lat) + Math.Abs(-48.28281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.45333 - lat) + Math.Abs(-36.65139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.56222 - lat) + Math.Abs(-51.26056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.39484 - lat) + Math.Abs(-43.50517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.52334 - lat) + Math.Abs(-43.69486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.97889 - lat) + Math.Abs(-49.87056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.48306 - lat) + Math.Abs(-50.12194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.79667 - lat) + Math.Abs(-50.87861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.88667 - lat) + Math.Abs(-50.26972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5325 - lat) + Math.Abs(-46.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.20833 - lat) + Math.Abs(-50.94944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.35889 - lat) + Math.Abs(-49.29139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.72028 - lat) + Math.Abs(-47.88667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.03139 - lat) + Math.Abs(-48.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.31694 - lat) + Math.Abs(-42.89611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.69639 - lat) + Math.Abs(-44.82722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.36667 - lat) + Math.Abs(-38.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.73722 - lat) + Math.Abs(-48.91472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.73095 - lat) + Math.Abs(-47.75177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.46806 - lat) + Math.Abs(-49.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.67833 - lat) + Math.Abs(-51.13056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.46806 - lat) + Math.Abs(-41.87528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.89194 - lat) + Math.Abs(-39.37194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.71056 - lat) + Math.Abs(-40.40056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.23333 - lat) + Math.Abs(-38.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.78389 - lat) + Math.Abs(-51.61 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.37639 - lat) + Math.Abs(-51.11444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.79722 - lat) + Math.Abs(-57.28806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.7775 - lat) + Math.Abs(-47.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.76583 - lat) + Math.Abs(-52.985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.98556 - lat) + Math.Abs(-43.84667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.75917 - lat) + Math.Abs(-43.45111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.53389 - lat) + Math.Abs(-49.31417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.28194 - lat) + Math.Abs(-42.53111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.75 - lat) + Math.Abs(-43.0375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.86667 - lat) + Math.Abs(-52.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.855 - lat) + Math.Abs(-37.12611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.49167 - lat) + Math.Abs(-37.19333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.21833 - lat) + Math.Abs(-37.42028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.45472 - lat) + Math.Abs(-56.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.72028 - lat) + Math.Abs(-56.3275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.88333 - lat) + Math.Abs(-43.10361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.47389 - lat) + Math.Abs(-48.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.8075 - lat) + Math.Abs(-43.41389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.6897 - lat) + Math.Abs(-50.0407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.40639 - lat) + Math.Abs(-49.21861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.23342 - lat) + Math.Abs(-45.23488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.32 - lat) + Math.Abs(-36.57944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.035 - lat) + Math.Abs(-39.01444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.065 - lat) + Math.Abs(-54.19056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.89889 - lat) + Math.Abs(-48.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.04222 - lat) + Math.Abs(-41.97333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.45917 - lat) + Math.Abs(-52.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.83917 - lat) + Math.Abs(-40.35389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.37583 - lat) + Math.Abs(-46.52556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.8 - lat) + Math.Abs(-41.43833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.22861 - lat) + Math.Abs(-39.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.91667 - lat) + Math.Abs(-39.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13056 - lat) + Math.Abs(-42.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46417 - lat) + Math.Abs(-41.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85889 - lat) + Math.Abs(-40.4725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.09333 - lat) + Math.Abs(-40.51583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.08639 - lat) + Math.Abs(-39.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.74472 - lat) + Math.Abs(-50.57056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.54852 - lat) + Math.Abs(-41.15804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.65083 - lat) + Math.Abs(-49.21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.73139 - lat) + Math.Abs(-48.05778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.73111 - lat) + Math.Abs(-49.09944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.06222 - lat) + Math.Abs(-53.00694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4325 - lat) + Math.Abs(-46.5725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.735 - lat) + Math.Abs(-43.86167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.18972 - lat) + Math.Abs(-46.98028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.43778 - lat) + Math.Abs(-39.33278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.68861 - lat) + Math.Abs(-51.46111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.94667 - lat) + Math.Abs(-47.31583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.72472 - lat) + Math.Abs(-47.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.90722 - lat) + Math.Abs(-48.64139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.155 - lat) + Math.Abs(-42.87472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.7725 - lat) + Math.Abs(-49.71417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.26111 - lat) + Math.Abs(-48.49639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.02722 - lat) + Math.Abs(-37.56222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.87056 - lat) + Math.Abs(-48.88083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.12694 - lat) + Math.Abs(-40.36333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.09306 - lat) + Math.Abs(-46.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.5775 - lat) + Math.Abs(-37.34278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.43194 - lat) + Math.Abs(-46.95778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.3677 - lat) + Math.Abs(-46.94552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.52278 - lat) + Math.Abs(-46.18833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.46778 - lat) + Math.Abs(-47.00472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.29194 - lat) + Math.Abs(-51.90639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13361 - lat) + Math.Abs(-51.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.24056 - lat) + Math.Abs(-56.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.19528 - lat) + Math.Abs(-42.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.41222 - lat) + Math.Abs(-42.19667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.28139 - lat) + Math.Abs(-47.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.26278 - lat) + Math.Abs(-44.16444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.56944 - lat) + Math.Abs(-52.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.21861 - lat) + Math.Abs(-42.59028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.06417 - lat) + Math.Abs(-41.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.45389 - lat) + Math.Abs(-43.46889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.17944 - lat) + Math.Abs(-48.03194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.42889 - lat) + Math.Abs(-40.595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.52667 - lat) + Math.Abs(-43.73278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2225 - lat) + Math.Abs(-41.47694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.29528 - lat) + Math.Abs(-54.09389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.37389 - lat) + Math.Abs(-40.22056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.66778 - lat) + Math.Abs(-46.46139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.55778 - lat) + Math.Abs(-44.08139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.39722 - lat) + Math.Abs(-42.86639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28389 - lat) + Math.Abs(-42.34111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.86917 - lat) + Math.Abs(-43.31944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.98639 - lat) + Math.Abs(-44.42778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.24083 - lat) + Math.Abs(-53.99639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.60333 - lat) + Math.Abs(-48.36583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.53028 - lat) + Math.Abs(-38.29917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.56306 - lat) + Math.Abs(-39.3025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.7375 - lat) + Math.Abs(-37.08167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.14583 - lat) + Math.Abs(-51.17083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.33167 - lat) + Math.Abs(-45.23694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.42528 - lat) + Math.Abs(-51.93861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.21389 - lat) + Math.Abs(-49.94583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.41278 - lat) + Math.Abs(-40.54167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.91944 - lat) + Math.Abs(-42.81861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.37778 - lat) + Math.Abs(-43.41611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.485 - lat) + Math.Abs(-51.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.41278 - lat) + Math.Abs(-40.68306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.55611 - lat) + Math.Abs(-54.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.86722 - lat) + Math.Abs(-43.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.44917 - lat) + Math.Abs(-52.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.10395 - lat) + Math.Abs(-39.0149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.04333 - lat) + Math.Abs(-40.82444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.77778 - lat) + Math.Abs(-38.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.44111 - lat) + Math.Abs(-40.43083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.61444 - lat) + Math.Abs(-55.16833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.61056 - lat) + Math.Abs(-50.66722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.8625 - lat) + Math.Abs(-41.12278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.35778 - lat) + Math.Abs(-41.95806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25806 - lat) + Math.Abs(-42.03361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.95972 - lat) + Math.Abs(-44.04056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.75583 - lat) + Math.Abs(-43.93222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5475 - lat) + Math.Abs(-51.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.34722 - lat) + Math.Abs(-52.09528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.65778 - lat) + Math.Abs(-37.30472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.84222 - lat) + Math.Abs(-42.07667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.31861 - lat) + Math.Abs(-46.58667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.54583 - lat) + Math.Abs(-47.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.71139 - lat) + Math.Abs(-40.14889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.11139 - lat) + Math.Abs(-49.80528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.74083 - lat) + Math.Abs(-38.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.67472 - lat) + Math.Abs(-45.91972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.01944 - lat) + Math.Abs(-42.69861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.50222 - lat) + Math.Abs(-48.71139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.38484 - lat) + Math.Abs(-41.78324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2525 - lat) + Math.Abs(-47.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.80139 - lat) + Math.Abs(-45.68556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.72028 - lat) + Math.Abs(-51.01889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.33333 - lat) + Math.Abs(-55.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.08639 - lat) + Math.Abs(-46.95056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73083 - lat) + Math.Abs(-45.12472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.31028 - lat) + Math.Abs(-51.16278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.92306 - lat) + Math.Abs(-53.13722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.65145 - lat) + Math.Abs(-41.84564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.67861 - lat) + Math.Abs(-49.7425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.39111 - lat) + Math.Abs(-40.07222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.56472 - lat) + Math.Abs(-47.40167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.8425 - lat) + Math.Abs(-43.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53194 - lat) + Math.Abs(-42.64306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.59861 - lat) + Math.Abs(-48.80028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.18556 - lat) + Math.Abs(-47.39028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.24528 - lat) + Math.Abs(-44.99972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.39278 - lat) + Math.Abs(-49.39667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.40778 - lat) + Math.Abs(-52.41611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.80639 - lat) + Math.Abs(-37.17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.04972 - lat) + Math.Abs(-47.83667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.89889 - lat) + Math.Abs(-41.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.38333 - lat) + Math.Abs(-41.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.76972 - lat) + Math.Abs(-49.71583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.97556 - lat) + Math.Abs(-45.35028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.15139 - lat) + Math.Abs(-41.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.81611 - lat) + Math.Abs(-50.32611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.46694 - lat) + Math.Abs(-51.96139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.18708 - lat) + Math.Abs(-40.97076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.4825 - lat) + Math.Abs(-48.78083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.20861 - lat) + Math.Abs(-51.52583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.63006 - lat) + Math.Abs(-43.9009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.77861 - lat) + Math.Abs(-46.4075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.0225 - lat) + Math.Abs(-45.54361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60491 - lat) + Math.Abs(-48.46713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.91722 - lat) + Math.Abs(-37.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.00472 - lat) + Math.Abs(-57.60167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.93167 - lat) + Math.Abs(-47.06833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.32083 - lat) + Math.Abs(-47.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.51472 - lat) + Math.Abs(-51.43361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.18639 - lat) + Math.Abs(-46.88417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.22694 - lat) + Math.Abs(-53.68167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.76417 - lat) + Math.Abs(-43.35028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.95194 - lat) + Math.Abs(-44.34278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.05278 - lat) + Math.Abs(-49.68833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.30444 - lat) + Math.Abs(-48.84556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.7425 - lat) + Math.Abs(-46.1725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.7575 - lat) + Math.Abs(-40.38556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.81 - lat) + Math.Abs(-43.17361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.93028 - lat) + Math.Abs(-46.27556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.65417 - lat) + Math.Abs(-41.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.17806 - lat) + Math.Abs(-51.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.01274 - lat) + Math.Abs(-39.89833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.02069 - lat) + Math.Abs(-40.68145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.78944 - lat) + Math.Abs(-41.395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.075 - lat) + Math.Abs(-38.48083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.43389 - lat) + Math.Abs(-41.00333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.85875 - lat) + Math.Abs(-40.08512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.29639 - lat) + Math.Abs(-48.55778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.25417 - lat) + Math.Abs(-50.98 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.87939 - lat) + Math.Abs(-51.72166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10139 - lat) + Math.Abs(-46.72833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.01778 - lat) + Math.Abs(-47.76389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.48028 - lat) + Math.Abs(-56.13806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48611 - lat) + Math.Abs(-49.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.75694 - lat) + Math.Abs(-49.33444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.34667 - lat) + Math.Abs(-36.80111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.64306 - lat) + Math.Abs(-43.65333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.59333 - lat) + Math.Abs(-36.94028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.48866 - lat) + Math.Abs(-44.35988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5275 - lat) + Math.Abs(-46.9025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.60306 - lat) + Math.Abs(-51.64333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.8025 - lat) + Math.Abs(-43.30889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.26889 - lat) + Math.Abs(-50.54583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.62145 - lat) + Math.Abs(-49.02529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.70556 - lat) + Math.Abs(-46.98583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.24423 - lat) + Math.Abs(-49.70932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.26389 - lat) + Math.Abs(-40.19583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.56611 - lat) + Math.Abs(-53.37583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53056 - lat) + Math.Abs(-39.97083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.28556 - lat) + Math.Abs(-46.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.6925 - lat) + Math.Abs(-48.00222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.18143 - lat) + Math.Abs(-40.51372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.96528 - lat) + Math.Abs(-54.96833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.16056 - lat) + Math.Abs(-49.96944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.30528 - lat) + Math.Abs(-45.96583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.25472 - lat) + Math.Abs(-48.32222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.59111 - lat) + Math.Abs(-51.16056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.34583 - lat) + Math.Abs(-41.53583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.33944 - lat) + Math.Abs(-47.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.72806 - lat) + Math.Abs(-50.19556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.15306 - lat) + Math.Abs(-47.05778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.41917 - lat) + Math.Abs(-49.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.97428 - lat) + Math.Abs(-49.46212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.73538 - lat) + Math.Abs(-39.14785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.81333 - lat) + Math.Abs(-41.29667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.26417 - lat) + Math.Abs(-47.29917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.11694 - lat) + Math.Abs(-40.07028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53167 - lat) + Math.Abs(-40.15028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.25278 - lat) + Math.Abs(-47.82278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.61306 - lat) + Math.Abs(-41.76528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.07528 - lat) + Math.Abs(-44.57639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.73944 - lat) + Math.Abs(-46.75222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10167 - lat) + Math.Abs(-48.61583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.00583 - lat) + Math.Abs(-46.83889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.49611 - lat) + Math.Abs(-44.56333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.1125 - lat) + Math.Abs(-49.33167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.65972 - lat) + Math.Abs(-40.06556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.87389 - lat) + Math.Abs(-40.87528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.12528 - lat) + Math.Abs(-56.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.48611 - lat) + Math.Abs(-46.34833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.56222 - lat) + Math.Abs(-49.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.23333 - lat) + Math.Abs(-48.71917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.70778 - lat) + Math.Abs(-49.48972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.59556 - lat) + Math.Abs(-48.81278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.82333 - lat) + Math.Abs(-50.61333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.43611 - lat) + Math.Abs(-46.82167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.31667 - lat) + Math.Abs(-38.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.54889 - lat) + Math.Abs(-46.93417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.98222 - lat) + Math.Abs(-48.87556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.59167 - lat) + Math.Abs(-48.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.24889 - lat) + Math.Abs(-40.24778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.205 - lat) + Math.Abs(-41.88778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.22 - lat) + Math.Abs(-49.34778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.01111 - lat) + Math.Abs(-40.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.09028 - lat) + Math.Abs(-48.61139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.71694 - lat) + Math.Abs(-46.84917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.4725 - lat) + Math.Abs(-45.12556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.88833 - lat) + Math.Abs(-38.67861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.95083 - lat) + Math.Abs(-49.54944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.66917 - lat) + Math.Abs(-42.07611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.16639 - lat) + Math.Abs(-40.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.29583 - lat) + Math.Abs(-44.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.18306 - lat) + Math.Abs(-46.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.245 - lat) + Math.Abs(-40.62444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.03111 - lat) + Math.Abs(-41.685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.85722 - lat) + Math.Abs(-42.85889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.03917 - lat) + Math.Abs(-39.53111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.67806 - lat) + Math.Abs(-39.375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.42556 - lat) + Math.Abs(-45.45278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.31806 - lat) + Math.Abs(-49.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.28361 - lat) + Math.Abs(-39.84278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.90778 - lat) + Math.Abs(-48.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.41778 - lat) + Math.Abs(-49.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.85222 - lat) + Math.Abs(-43.77528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.80194 - lat) + Math.Abs(-40.85556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16278 - lat) + Math.Abs(-40.00611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2789 - lat) + Math.Abs(-38.99584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.10222 - lat) + Math.Abs(-44.09194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.78556 - lat) + Math.Abs(-39.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74444 - lat) + Math.Abs(-42.85944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25333 - lat) + Math.Abs(-43.80139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.61917 - lat) + Math.Abs(-43.22694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.02028 - lat) + Math.Abs(-49.81028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.5275 - lat) + Math.Abs(-40.30694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.86194 - lat) + Math.Abs(-49.13722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.27389 - lat) + Math.Abs(-37.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.685 - lat) + Math.Abs(-37.42528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.34528 - lat) + Math.Abs(-41.64111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.30417 - lat) + Math.Abs(-41.85583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.46722 - lat) + Math.Abs(-50.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.05 - lat) + Math.Abs(-38.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.24861 - lat) + Math.Abs(-41.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.58056 - lat) + Math.Abs(-47.51861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.43806 - lat) + Math.Abs(-48.01222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.00306 - lat) + Math.Abs(-53.70417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.44194 - lat) + Math.Abs(-51.11778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15833 - lat) + Math.Abs(-39.73722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.13449 - lat) + Math.Abs(-39.73948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.35028 - lat) + Math.Abs(-47.68861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.05667 - lat) + Math.Abs(-49.62639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.46833 - lat) + Math.Abs(-42.53667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.72194 - lat) + Math.Abs(-48.15972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.41361 - lat) + Math.Abs(-42.41944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.35778 - lat) + Math.Abs(-49.49611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.54917 - lat) + Math.Abs(-42.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78444 - lat) + Math.Abs(-38.35306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.51917 - lat) + Math.Abs(-37.51167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.08842 - lat) + Math.Abs(-47.2119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.89778 - lat) + Math.Abs(-49.23167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.23 - lat) + Math.Abs(-50.60444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.24 - lat) + Math.Abs(-48.67028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.79364 - lat) + Math.Abs(-39.03949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.43278 - lat) + Math.Abs(-51.3425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.77806 - lat) + Math.Abs(-45.35806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.38778 - lat) + Math.Abs(-53.91472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.68028 - lat) + Math.Abs(-54.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.70806 - lat) + Math.Abs(-47.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.75639 - lat) + Math.Abs(-40.08917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.83917 - lat) + Math.Abs(-42.22889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.57444 - lat) + Math.Abs(-50.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.12528 - lat) + Math.Abs(-36.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.07028 - lat) + Math.Abs(-44.30167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03833 - lat) + Math.Abs(-47.74694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.50917 - lat) + Math.Abs(-48.55778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.79306 - lat) + Math.Abs(-40.81111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.71333 - lat) + Math.Abs(-49.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.18528 - lat) + Math.Abs(-43.22056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.65639 - lat) + Math.Abs(-47.2225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.75778 - lat) + Math.Abs(-48.82889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.6275 - lat) + Math.Abs(-53.08972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.02194 - lat) + Math.Abs(-44.05889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.06694 - lat) + Math.Abs(-39.64056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16417 - lat) + Math.Abs(-39.37361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.05694 - lat) + Math.Abs(-49.51778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.83194 - lat) + Math.Abs(-40.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.26917 - lat) + Math.Abs(-51.04806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.64083 - lat) + Math.Abs(-42.01111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.84167 - lat) + Math.Abs(-39.98667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.865 - lat) + Math.Abs(-39.5875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.47833 - lat) + Math.Abs(-46.53889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.23389 - lat) + Math.Abs(-41.51056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.95472 - lat) + Math.Abs(-47.99667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.84861 - lat) + Math.Abs(-50.18778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.76722 - lat) + Math.Abs(-40.21167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09583 - lat) + Math.Abs(-46.63167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.85833 - lat) + Math.Abs(-47.22 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.62583 - lat) + Math.Abs(-54.30778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.96222 - lat) + Math.Abs(-49.22806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.02361 - lat) + Math.Abs(-53.39556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.72917 - lat) + Math.Abs(-49.06861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.34534 - lat) + Math.Abs(-53.76177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.45778 - lat) + Math.Abs(-56.11417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.30528 - lat) + Math.Abs(-46.71278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.46278 - lat) + Math.Abs(-46.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.99306 - lat) + Math.Abs(-46.25639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.36 - lat) + Math.Abs(-48.22833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.88278 - lat) + Math.Abs(-48.57472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.81639 - lat) + Math.Abs(-45.1925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.58564 - lat) + Math.Abs(-39.78189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.415 - lat) + Math.Abs(-46.035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.26083 - lat) + Math.Abs(-50.64278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.39048 - lat) + Math.Abs(-51.46541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.67182 - lat) + Math.Abs(-40.50196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.10083 - lat) + Math.Abs(-52.87806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.29917 - lat) + Math.Abs(-46.8025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.47306 - lat) + Math.Abs(-49.00278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.42833 - lat) + Math.Abs(-47.82417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.84556 - lat) + Math.Abs(-51.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.83056 - lat) + Math.Abs(-49.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.53722 - lat) + Math.Abs(-42.98194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.795 - lat) + Math.Abs(-49.22028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.775 - lat) + Math.Abs(-42.9325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.22333 - lat) + Math.Abs(-42.78139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.31833 - lat) + Math.Abs(-48.31056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.77556 - lat) + Math.Abs(-41.67944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.94218 - lat) + Math.Abs(-50.99278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.85111 - lat) + Math.Abs(-41.94944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.0125 - lat) + Math.Abs(-49.35472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.93444 - lat) + Math.Abs(-50.14028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.49611 - lat) + Math.Abs(-49.42639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.67861 - lat) + Math.Abs(-49.25389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.3175 - lat) + Math.Abs(-49.1175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.51056 - lat) + Math.Abs(-49.02389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.02833 - lat) + Math.Abs(-54.34972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.64833 - lat) + Math.Abs(-50.36056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.93139 - lat) + Math.Abs(-48.95889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.25611 - lat) + Math.Abs(-51.53361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.21056 - lat) + Math.Abs(-49.65611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.74389 - lat) + Math.Abs(-39.48667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.93408 - lat) + Math.Abs(-40.40473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.02472 - lat) + Math.Abs(-48.94056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.54944 - lat) + Math.Abs(-37.53444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.35917 - lat) + Math.Abs(-53.39444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.32167 - lat) + Math.Abs(-46.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.47583 - lat) + Math.Abs(-43.48833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.28167 - lat) + Math.Abs(-46.74528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.08111 - lat) + Math.Abs(-53.055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.53861 - lat) + Math.Abs(-47.40083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.54778 - lat) + Math.Abs(-54.58806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.7475 - lat) + Math.Abs(-49.47222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.04833 - lat) + Math.Abs(-45.19306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.53722 - lat) + Math.Abs(-47.33444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46444 - lat) + Math.Abs(-45.42639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.6 - lat) + Math.Abs(-51.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.59667 - lat) + Math.Abs(-48.54917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.86333 - lat) + Math.Abs(-51.38722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.02889 - lat) + Math.Abs(-51.18167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.58194 - lat) + Math.Abs(-50.305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.54083 - lat) + Math.Abs(-46.36861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28389 - lat) + Math.Abs(-50.24639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.26667 - lat) + Math.Abs(-38.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.00028 - lat) + Math.Abs(-51.31944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.38833 - lat) + Math.Abs(-49.51 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.225 - lat) + Math.Abs(-51.34778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.85472 - lat) + Math.Abs(-46.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.3775 - lat) + Math.Abs(-39.58028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.5075 - lat) + Math.Abs(-39.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.06111 - lat) + Math.Abs(-50.93833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.86139 - lat) + Math.Abs(-51.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.64833 - lat) + Math.Abs(-51.17389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.26833 - lat) + Math.Abs(-37.43833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.72472 - lat) + Math.Abs(-52.84972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.79611 - lat) + Math.Abs(-37.945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.92611 - lat) + Math.Abs(-42.81917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.65028 - lat) + Math.Abs(-41.90722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.7625 - lat) + Math.Abs(-44.31389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.63461 - lat) + Math.Abs(-52.2754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.94194 - lat) + Math.Abs(-38.08444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.79722 - lat) + Math.Abs(-52.26917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.54389 - lat) + Math.Abs(-52.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.53139 - lat) + Math.Abs(-40.90944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.23611 - lat) + Math.Abs(-51.86972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.83222 - lat) + Math.Abs(-46.81139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.64889 - lat) + Math.Abs(-46.85222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.61 - lat) + Math.Abs(-45.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.04278 - lat) + Math.Abs(-47.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.78694 - lat) + Math.Abs(-54.28361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.33833 - lat) + Math.Abs(-49.93139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.37333 - lat) + Math.Abs(-40.83056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.78556 - lat) + Math.Abs(-43.31167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.41444 - lat) + Math.Abs(-49.40389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.22111 - lat) + Math.Abs(-54.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.46333 - lat) + Math.Abs(-45.60167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.98278 - lat) + Math.Abs(-54.67306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36333 - lat) + Math.Abs(-40.65917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.73361 - lat) + Math.Abs(-53.05722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.36611 - lat) + Math.Abs(-48.38028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14355 - lat) + Math.Abs(-44.89065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.77778 - lat) + Math.Abs(-41.47972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.40861 - lat) + Math.Abs(-56.44611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.24692 - lat) + Math.Abs(-43.60345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.68611 - lat) + Math.Abs(-46.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.90389 - lat) + Math.Abs(-47.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.75639 - lat) + Math.Abs(-44.43083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.28278 - lat) + Math.Abs(-50.58444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.42778 - lat) + Math.Abs(-49.27306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.07444 - lat) + Math.Abs(-44.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.59611 - lat) + Math.Abs(-56.09667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.895 - lat) + Math.Abs(-46.42528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.83861 - lat) + Math.Abs(-44.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.785 - lat) + Math.Abs(-53.07333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.57316 - lat) + Math.Abs(-44.97108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.67 - lat) + Math.Abs(-39.10194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.64397 - lat) + Math.Abs(-53.60633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.54889 - lat) + Math.Abs(-49.96917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.47556 - lat) + Math.Abs(-37.75528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.76769 - lat) + Math.Abs(-47.6153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.6775 - lat) + Math.Abs(-49.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.34028 - lat) + Math.Abs(-47.72944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.50667 - lat) + Math.Abs(-54.76 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.60389 - lat) + Math.Abs(-46.91917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.41667 - lat) + Math.Abs(-54.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.64583 - lat) + Math.Abs(-47.19611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.12556 - lat) + Math.Abs(-36.17556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.42528 - lat) + Math.Abs(-49.24306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.00917 - lat) + Math.Abs(-57.65333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.34333 - lat) + Math.Abs(-44.63667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58472 - lat) + Math.Abs(-50.36111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.97972 - lat) + Math.Abs(-52.56778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.51861 - lat) + Math.Abs(-42.62889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.47333 - lat) + Math.Abs(-47.20028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.18111 - lat) + Math.Abs(-50.64667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.38083 - lat) + Math.Abs(-44.45639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.48194 - lat) + Math.Abs(-47.45667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.02861 - lat) + Math.Abs(-42.36083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.79889 - lat) + Math.Abs(-53.30667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23333 - lat) + Math.Abs(-38.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.68528 - lat) + Math.Abs(-44.365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.93167 - lat) + Math.Abs(-44.05361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.17222 - lat) + Math.Abs(-41.47222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.66028 - lat) + Math.Abs(-43.78611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.50525 - lat) + Math.Abs(-43.8588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.81361 - lat) + Math.Abs(-37.61056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.23417 - lat) + Math.Abs(-52.02778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.01528 - lat) + Math.Abs(-48.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.33028 - lat) + Math.Abs(-47.1725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.88083 - lat) + Math.Abs(-45.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.03722 - lat) + Math.Abs(-43.425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.56389 - lat) + Math.Abs(-39.28278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36833 - lat) + Math.Abs(-41.24389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.77944 - lat) + Math.Abs(-39.17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.31667 - lat) + Math.Abs(-38.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.91472 - lat) + Math.Abs(-48.38833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.50583 - lat) + Math.Abs(-38.99861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.59333 - lat) + Math.Abs(-39.73222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.8375 - lat) + Math.Abs(-51.97306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.29167 - lat) + Math.Abs(-49.22417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.53944 - lat) + Math.Abs(-40.63056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.60321 - lat) + Math.Abs(-49.32767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.64083 - lat) + Math.Abs(-39.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.39583 - lat) + Math.Abs(-52.47083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.44333 - lat) + Math.Abs(-44.76583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.09972 - lat) + Math.Abs(-38.51361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.18111 - lat) + Math.Abs(-50.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.6 - lat) + Math.Abs(-38.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.66333 - lat) + Math.Abs(-52.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.69111 - lat) + Math.Abs(-53.45667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.85583 - lat) + Math.Abs(-52.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.66463 - lat) + Math.Abs(-52.35558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.95472 - lat) + Math.Abs(-51.62528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.50972 - lat) + Math.Abs(-47.77806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.09639 - lat) + Math.Abs(-52.61833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.46056 - lat) + Math.Abs(-55.74972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.14861 - lat) + Math.Abs(-54.73806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.165 - lat) + Math.Abs(-47.74361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.03556 - lat) + Math.Abs(-49.16611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.30833 - lat) + Math.Abs(-49.59833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.58389 - lat) + Math.Abs(-49.19944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.82111 - lat) + Math.Abs(-51.59528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.63444 - lat) + Math.Abs(-51.33639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.16806 - lat) + Math.Abs(-51.17944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.97722 - lat) + Math.Abs(-44.9325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.7975 - lat) + Math.Abs(-47.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.35306 - lat) + Math.Abs(-38.37889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13778 - lat) + Math.Abs(-48.97278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.16583 - lat) + Math.Abs(-47.94639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.38917 - lat) + Math.Abs(-42.69667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.76556 - lat) + Math.Abs(-39.42833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.78927 - lat) + Math.Abs(-50.01225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.87222 - lat) + Math.Abs(-51.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.60361 - lat) + Math.Abs(-41.18472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.11333 - lat) + Math.Abs(-51.73417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58306 - lat) + Math.Abs(-46.92194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.48056 - lat) + Math.Abs(-42.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.95583 - lat) + Math.Abs(-53.45528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.77389 - lat) + Math.Abs(-47.08639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.35361 - lat) + Math.Abs(-49.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.97194 - lat) + Math.Abs(-46.11889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.00083 - lat) + Math.Abs(-46.31611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.18417 - lat) + Math.Abs(-44.77111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.93361 - lat) + Math.Abs(-42.60861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.70306 - lat) + Math.Abs(-40.76639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.2975 - lat) + Math.Abs(-51.50361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.36083 - lat) + Math.Abs(-37.70111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30472 - lat) + Math.Abs(-43.765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.08194 - lat) + Math.Abs(-49.91417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.28389 - lat) + Math.Abs(-52.78639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.78972 - lat) + Math.Abs(-42.13917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.63417 - lat) + Math.Abs(-54.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.52272 - lat) + Math.Abs(-46.835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.73306 - lat) + Math.Abs(-42.02944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.95361 - lat) + Math.Abs(-43.80639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.9526 - lat) + Math.Abs(-50.1159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.18889 - lat) + Math.Abs(-41.69472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.62028 - lat) + Math.Abs(-45.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.995 - lat) + Math.Abs(-47.50778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.61528 - lat) + Math.Abs(-46.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.34361 - lat) + Math.Abs(-51.61194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.68194 - lat) + Math.Abs(-49.56972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.38111 - lat) + Math.Abs(-40.01278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.69139 - lat) + Math.Abs(-42.51583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.47056 - lat) + Math.Abs(-47.73472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.50333 - lat) + Math.Abs(-37.05278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.74556 - lat) + Math.Abs(-50.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.00583 - lat) + Math.Abs(-48.34944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.98111 - lat) + Math.Abs(-42.36806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.17722 - lat) + Math.Abs(-50.39 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.91778 - lat) + Math.Abs(-51.18361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.395 - lat) + Math.Abs(-52.67556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.35622 - lat) + Math.Abs(-50.81357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74639 - lat) + Math.Abs(-50.38694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.56694 - lat) + Math.Abs(-51.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.66917 - lat) + Math.Abs(-52.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.675 - lat) + Math.Abs(-38.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.68472 - lat) + Math.Abs(-41.76889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.01472 - lat) + Math.Abs(-47.92667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.41667 - lat) + Math.Abs(-54.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.40167 - lat) + Math.Abs(-51.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.235 - lat) + Math.Abs(-45.75861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73944 - lat) + Math.Abs(-45.59139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.03667 - lat) + Math.Abs(-46.77167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.69611 - lat) + Math.Abs(-46.17139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.75227 - lat) + Math.Abs(-41.33044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.04309 - lat) + Math.Abs(-52.37929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.45955 - lat) + Math.Abs(-49.53014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.44278 - lat) + Math.Abs(-54.64639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.23333 - lat) + Math.Abs(-36.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.5075 - lat) + Math.Abs(-40.32139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.73333 - lat) + Math.Abs(-37.49333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.89722 - lat) + Math.Abs(-45.27722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.53791 - lat) + Math.Abs(-49.48813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.90556 - lat) + Math.Abs(-47.06083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.30556 - lat) + Math.Abs(-49.05528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.71111 - lat) + Math.Abs(-46.24639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.83611 - lat) + Math.Abs(-45.40056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.85222 - lat) + Math.Abs(-45.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.61222 - lat) + Math.Abs(-46.0575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.57528 - lat) + Math.Abs(-41.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.27583 - lat) + Math.Abs(-51.27833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.04639 - lat) + Math.Abs(-50.07361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.85111 - lat) + Math.Abs(-51.81222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.53139 - lat) + Math.Abs(-54.04389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.75528 - lat) + Math.Abs(-46.14472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.94472 - lat) + Math.Abs(-39.10389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.6975 - lat) + Math.Abs(-38.32417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.74431 - lat) + Math.Abs(-48.62789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.27528 - lat) + Math.Abs(-47.30417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.73611 - lat) + Math.Abs(-48.12278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.35611 - lat) + Math.Abs(-46.87694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.36417 - lat) + Math.Abs(-46.74056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.95667 - lat) + Math.Abs(-51.81028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.8025 - lat) + Math.Abs(-49.61 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.69361 - lat) + Math.Abs(-41.46833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.06944 - lat) + Math.Abs(-42.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.88 - lat) + Math.Abs(-43.66972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.50333 - lat) + Math.Abs(-42.22222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.55667 - lat) + Math.Abs(-51.13083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.52944 - lat) + Math.Abs(-46.64389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.84889 - lat) + Math.Abs(-41.11278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.95111 - lat) + Math.Abs(-51.09389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4625 - lat) + Math.Abs(-42.65306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.03917 - lat) + Math.Abs(-52.89389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.60139 - lat) + Math.Abs(-38.96576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.88361 - lat) + Math.Abs(-54.825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.51436 - lat) + Math.Abs(-53.48496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10083 - lat) + Math.Abs(-45.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.77528 - lat) + Math.Abs(-51.015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.3075 - lat) + Math.Abs(-47.13278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.88717 - lat) + Math.Abs(-42.02622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.11972 - lat) + Math.Abs(-51.96222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35111 - lat) + Math.Abs(-44.96222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61778 - lat) + Math.Abs(-46.42333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.14 - lat) + Math.Abs(-49.04028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.06611 - lat) + Math.Abs(-50.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.7975 - lat) + Math.Abs(-48.59278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.14694 - lat) + Math.Abs(-37.62056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.95944 - lat) + Math.Abs(-39.29972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.44083 - lat) + Math.Abs(-46.35083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.09795 - lat) + Math.Abs(-48.91281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.20361 - lat) + Math.Abs(-41.66528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14333 - lat) + Math.Abs(-44.19972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.28417 - lat) + Math.Abs(-48.12667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.99139 - lat) + Math.Abs(-47.65861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.20639 - lat) + Math.Abs(-44.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.77972 - lat) + Math.Abs(-47.92972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.9527 - lat) + Math.Abs(-46.54418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.275 - lat) + Math.Abs(-49.16556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.88583 - lat) + Math.Abs(-48.445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.63333 - lat) + Math.Abs(-46.395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.27417 - lat) + Math.Abs(-46.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.61972 - lat) + Math.Abs(-49.07361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.19306 - lat) + Math.Abs(-48.77889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.82306 - lat) + Math.Abs(-42.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.12111 - lat) + Math.Abs(-56.48194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.03306 - lat) + Math.Abs(-44.75806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.135 - lat) + Math.Abs(-46.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13389 - lat) + Math.Abs(-41.67972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.82889 - lat) + Math.Abs(-42.31611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.255 - lat) + Math.Abs(-43.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.73639 - lat) + Math.Abs(-45.25222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.28333 - lat) + Math.Abs(-47.67222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.10778 - lat) + Math.Abs(-43.815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.9925 - lat) + Math.Abs(-48.39083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.09 - lat) + Math.Abs(-45.56583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.54 - lat) + Math.Abs(-40.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.91944 - lat) + Math.Abs(-49.06611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.5725 - lat) + Math.Abs(-46.03861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.28861 - lat) + Math.Abs(-50.34 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.49417 - lat) + Math.Abs(-48.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.72528 - lat) + Math.Abs(-43.05944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.96778 - lat) + Math.Abs(-44.19833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.85444 - lat) + Math.Abs(-46.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.01306 - lat) + Math.Abs(-49.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.17139 - lat) + Math.Abs(-51.51917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.22 - lat) + Math.Abs(-42.48361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.92083 - lat) + Math.Abs(-43.93778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.86126 - lat) + Math.Abs(-38.87982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.76417 - lat) + Math.Abs(-43.39944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.99667 - lat) + Math.Abs(-51.19056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.97278 - lat) + Math.Abs(-48.95333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.10889 - lat) + Math.Abs(-56.52111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.94944 - lat) + Math.Abs(-48.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.31472 - lat) + Math.Abs(-49.06056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.89111 - lat) + Math.Abs(-47.585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.29528 - lat) + Math.Abs(-53.27111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.92194 - lat) + Math.Abs(-50.73389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.51056 - lat) + Math.Abs(-46.87611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.18694 - lat) + Math.Abs(-43.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.97083 - lat) + Math.Abs(-48.91583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.76083 - lat) + Math.Abs(-41.91167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.19361 - lat) + Math.Abs(-48.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.55722 - lat) + Math.Abs(-48.56778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61532 - lat) + Math.Abs(-43.59187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15278 - lat) + Math.Abs(-44.99 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.63222 - lat) + Math.Abs(-48.68472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.54417 - lat) + Math.Abs(-44.17139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.90889 - lat) + Math.Abs(-37.03861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.47 - lat) + Math.Abs(-43.82556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.89 - lat) + Math.Abs(-52.25667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.0725 - lat) + Math.Abs(-57.18111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.755 - lat) + Math.Abs(-40.89083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.62611 - lat) + Math.Abs(-41.32694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.49472 - lat) + Math.Abs(-48.55806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.08944 - lat) + Math.Abs(-43.14167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.07444 - lat) + Math.Abs(-48.74028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.22583 - lat) + Math.Abs(-43.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.19444 - lat) + Math.Abs(-55.9675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.94583 - lat) + Math.Abs(-43.48722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.11 - lat) + Math.Abs(-50.3675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.00639 - lat) + Math.Abs(-45.97694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.99056 - lat) + Math.Abs(-48.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.51889 - lat) + Math.Abs(-41.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.10599 - lat) + Math.Abs(-37.69413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.95972 - lat) + Math.Abs(-40.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.33139 - lat) + Math.Abs(-54.10694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.95889 - lat) + Math.Abs(-44.89 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.91806 - lat) + Math.Abs(-49.44528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.09861 - lat) + Math.Abs(-48.92583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.68556 - lat) + Math.Abs(-50.55472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.11694 - lat) + Math.Abs(-46.55028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.2325 - lat) + Math.Abs(-51.66556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.31528 - lat) + Math.Abs(-42.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.66167 - lat) + Math.Abs(-50.41222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.37333 - lat) + Math.Abs(-50.84139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.39611 - lat) + Math.Abs(-46.32083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.57306 - lat) + Math.Abs(-47.1725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.2375 - lat) + Math.Abs(-53.08694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.07722 - lat) + Math.Abs(-51.72917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.40111 - lat) + Math.Abs(-51.945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93139 - lat) + Math.Abs(-46.93833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.96611 - lat) + Math.Abs(-42.02778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.74694 - lat) + Math.Abs(-41.88167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.74963 - lat) + Math.Abs(-48.50713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.91694 - lat) + Math.Abs(-46.10556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.45028 - lat) + Math.Abs(-56.84611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.75778 - lat) + Math.Abs(-37.31528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.23056 - lat) + Math.Abs(-43.10556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.35861 - lat) + Math.Abs(-46.14556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28194 - lat) + Math.Abs(-45.53944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.59333 - lat) + Math.Abs(-46.94056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.59306 - lat) + Math.Abs(-49.41028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.26222 - lat) + Math.Abs(-37.61972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.87278 - lat) + Math.Abs(-42.34306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.35694 - lat) + Math.Abs(-47.38417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.79444 - lat) + Math.Abs(-48.17556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.93575 - lat) + Math.Abs(-49.49538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.41944 - lat) + Math.Abs(-51.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.64722 - lat) + Math.Abs(-48.18722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.73389 - lat) + Math.Abs(-51.83139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.8975 - lat) + Math.Abs(-52.25083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.84972 - lat) + Math.Abs(-42.07028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.82028 - lat) + Math.Abs(-40.27333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.50528 - lat) + Math.Abs(-47.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.33333 - lat) + Math.Abs(-38.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.20889 - lat) + Math.Abs(-50.43278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.91111 - lat) + Math.Abs(-37.07167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.47111 - lat) + Math.Abs(-55.78722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.28139 - lat) + Math.Abs(-37.01861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.55083 - lat) + Math.Abs(-51.46083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.50944 - lat) + Math.Abs(-48.8425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.08667 - lat) + Math.Abs(-51.09361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.84694 - lat) + Math.Abs(-45.22972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.42861 - lat) + Math.Abs(-48.71194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.90194 - lat) + Math.Abs(-49.12861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.46111 - lat) + Math.Abs(-49.96167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15111 - lat) + Math.Abs(-39.24639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.00667 - lat) + Math.Abs(-44.31806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.48972 - lat) + Math.Abs(-48.41278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.73972 - lat) + Math.Abs(-44.30917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.89611 - lat) + Math.Abs(-51.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.06806 - lat) + Math.Abs(-46.56917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.48361 - lat) + Math.Abs(-55.80694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.32667 - lat) + Math.Abs(-48.95278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.61222 - lat) + Math.Abs(-41.13556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.915 - lat) + Math.Abs(-53.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.70111 - lat) + Math.Abs(-46.76444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.72444 - lat) + Math.Abs(-48.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.73917 - lat) + Math.Abs(-47.33139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.45528 - lat) + Math.Abs(-41.43611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.03028 - lat) + Math.Abs(-39.60472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.48 - lat) + Math.Abs(-49.12472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10667 - lat) + Math.Abs(-43.04889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.07944 - lat) + Math.Abs(-51.47194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.02806 - lat) + Math.Abs(-53.44056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.12889 - lat) + Math.Abs(-52.31889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.87444 - lat) + Math.Abs(-53.90167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.31472 - lat) + Math.Abs(-53.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.02556 - lat) + Math.Abs(-47.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.24917 - lat) + Math.Abs(-46.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.86361 - lat) + Math.Abs(-46.38806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.32472 - lat) + Math.Abs(-49.31 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.18361 - lat) + Math.Abs(-40.69444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.635 - lat) + Math.Abs(-40.74972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.42917 - lat) + Math.Abs(-45.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.88778 - lat) + Math.Abs(-42.70444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.78306 - lat) + Math.Abs(-55.79194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.76361 - lat) + Math.Abs(-41.53306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13556 - lat) + Math.Abs(-38.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.49583 - lat) + Math.Abs(-41.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.98306 - lat) + Math.Abs(-40.74028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.46917 - lat) + Math.Abs(-48.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.74722 - lat) + Math.Abs(-41.46 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.08222 - lat) + Math.Abs(-40.93583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.47639 - lat) + Math.Abs(-46.63278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.05944 - lat) + Math.Abs(-46.97861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.07417 - lat) + Math.Abs(-41.12389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.68528 - lat) + Math.Abs(-51.0725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.07306 - lat) + Math.Abs(-42.54639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66222 - lat) + Math.Abs(-38.01722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.16 - lat) + Math.Abs(-45.44583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.20417 - lat) + Math.Abs(-48.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.11389 - lat) + Math.Abs(-51.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.16745 - lat) + Math.Abs(-48.32766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.67361 - lat) + Math.Abs(-48.51111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.99 - lat) + Math.Abs(-65.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.87306 - lat) + Math.Abs(-67.80222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36841 - lat) + Math.Abs(-64.72054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.94111 - lat) + Math.Abs(-72.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.16139 - lat) + Math.Abs(-70.76556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.23116 - lat) + Math.Abs(-69.93858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.06341 - lat) + Math.Abs(-68.67245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.37833 - lat) + Math.Abs(-68.8725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.1181 - lat) + Math.Abs(-67.08527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.10222 - lat) + Math.Abs(-67.93972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.41389 - lat) + Math.Abs(-65.01917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.97472 - lat) + Math.Abs(-67.81 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.26861 - lat) + Math.Abs(-72.74389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76194 - lat) + Math.Abs(-63.90389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.71361 - lat) + Math.Abs(-66.97639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.12056 - lat) + Math.Abs(-60.37972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.82403 - lat) + Math.Abs(-65.35883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.83889 - lat) + Math.Abs(-69.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.80917 - lat) + Math.Abs(-61.30028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.61417 - lat) + Math.Abs(-72.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.10194 - lat) + Math.Abs(-60.025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.31667 - lat) + Math.Abs(-60.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.29972 - lat) + Math.Abs(-60.62056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.18333 - lat) + Math.Abs(-68.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.51651 - lat) + Math.Abs(-63.03105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.51389 - lat) + Math.Abs(-66.09167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.1654 - lat) + Math.Abs(-70.35486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.3 - lat) + Math.Abs(-70.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.66028 - lat) + Math.Abs(-69.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.62759 - lat) + Math.Abs(-72.67756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.83667 - lat) + Math.Abs(-62.05694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.085 - lat) + Math.Abs(-63.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.88278 - lat) + Math.Abs(-66.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.53389 - lat) + Math.Abs(-64.38306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.75222 - lat) + Math.Abs(-67.39778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.81972 - lat) + Math.Abs(-60.67333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.37555 - lat) + Math.Abs(-70.03179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.97357 - lat) + Math.Abs(-62.9269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.91333 - lat) + Math.Abs(-63.04083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.16667 - lat) + Math.Abs(-60.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.77278 - lat) + Math.Abs(-61.64417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.22083 - lat) + Math.Abs(-64.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.28472 - lat) + Math.Abs(-60.18611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.65167 - lat) + Math.Abs(-68.50444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.74056 - lat) + Math.Abs(-60.14583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.1497 - lat) + Math.Abs(-67.73741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.17528 - lat) + Math.Abs(-61.90139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.08271 - lat) + Math.Abs(-62.27726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.33528 - lat) + Math.Abs(-67.18556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.6725 - lat) + Math.Abs(-61.19361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.74806 - lat) + Math.Abs(-62.21583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.88528 - lat) + Math.Abs(-61.95167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.43889 - lat) + Math.Abs(-62.46639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.78356 - lat) + Math.Abs(-65.33552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.43861 - lat) + Math.Abs(-61.44722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.01611 - lat) + Math.Abs(-68.74806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.87556 - lat) + Math.Abs(-56.08611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.82333 - lat) + Math.Abs(-49.24389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.94639 - lat) + Math.Abs(-45.66098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.59444 - lat) + Math.Abs(-48.60694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.20639 - lat) + Math.Abs(-46.78444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.84028 - lat) + Math.Abs(-32.41083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11278 - lat) + Math.Abs(-35.01472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.61304 - lat) + Math.Abs(-44.98009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.89444 - lat) + Math.Abs(-38.32722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.07045 - lat) + Math.Abs(-55.9235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53306 - lat) + Math.Abs(-48.22 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.86417 - lat) + Math.Abs(-46.035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75472 - lat) + Math.Abs(-51.08389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.0675 - lat) + Math.Abs(-49.90222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.44389 - lat) + Math.Abs(-45.24056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.44472 - lat) + Math.Abs(-49.1925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35361 - lat) + Math.Abs(-52.67861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.02861 - lat) + Math.Abs(-50.03139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.69795 - lat) + Math.Abs(-59.70172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.02745 - lat) + Math.Abs(-40.74336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78444 - lat) + Math.Abs(-38.40389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.86417 - lat) + Math.Abs(-55.5025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.535 - lat) + Math.Abs(-39.74194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.7475 - lat) + Math.Abs(-51.16111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.60333 - lat) + Math.Abs(-47.02639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.09829 - lat) + Math.Abs(-49.9435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.62092 - lat) + Math.Abs(-38.82913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.15236 - lat) + Math.Abs(-44.23164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.56675 - lat) + Math.Abs(-46.66439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58315 - lat) + Math.Abs(-48.49503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60141 - lat) + Math.Abs(-48.50593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.59137 - lat) + Math.Abs(-48.50756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.59898 - lat) + Math.Abs(-48.52618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.58612 - lat) + Math.Abs(-48.52335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.5849 - lat) + Math.Abs(-48.53562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60864 - lat) + Math.Abs(-48.53605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.60985 - lat) + Math.Abs(-48.51648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.63586 - lat) + Math.Abs(-48.5212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.66088 - lat) + Math.Abs(-48.54318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.68528 - lat) + Math.Abs(-48.55124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.78146 - lat) + Math.Abs(-48.52653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.76315 - lat) + Math.Abs(-48.57193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.71773 - lat) + Math.Abs(-48.56266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.57017 - lat) + Math.Abs(-42.74229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.90967 - lat) + Math.Abs(-49.36547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.25438 - lat) + Math.Abs(-42.75529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.07115 - lat) + Math.Abs(-54.88533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.84206 - lat) + Math.Abs(-45.69789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61791 - lat) + Math.Abs(-47.64874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.77136 - lat) + Math.Abs(-66.35583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.25139 - lat) + Math.Abs(-34.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.57563 - lat) + Math.Abs(-46.6507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.42313 - lat) + Math.Abs(-42.96612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2035;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vitorino Freire", "13", -4.04238, -45.23777);
case 1: return new CityInfo("Vitória do Mearim", "13", -3.46222, -44.87056);
case 2: return new CityInfo("Vitória de Santo Antão", "30", -8.11806, -35.29139);
case 3: return new CityInfo("Viseu", "16", -1.19667, -46.14);
case 4: return new CityInfo("Conde", "17", -7.25972, -34.9075);
case 5: return new CityInfo("Vigia", "16", -0.85833, -48.14167);
case 6: return new CityInfo("Viçosa do Ceará", "06", -3.56222, -41.09222);
case 7: return new CityInfo("Viçosa", "02", -9.37139, -36.24083);
case 8: return new CityInfo("Vicência", "30", -7.65694, -35.32667);
case 9: return new CityInfo("Viana", "13", -3.22028, -45.00361);
case 10: return new CityInfo("Várzea Alegre", "06", -5.35, -40.38333);
case 11: return new CityInfo("Varjota", "06", -4.19444, -40.47667);
case 12: return new CityInfo("Vargem Grande", "13", -3.54306, -43.91583);
case 13: return new CityInfo("Valença do Piauí", "20", -6.4075, -41.74556);
case 14: return new CityInfo("Urucurituba", "04", -3.12845, -58.15856);
case 15: return new CityInfo("Uruçuí", "20", -7.22944, -44.55611);
case 16: return new CityInfo("Urucará", "04", -2.53639, -57.76);
case 17: return new CityInfo("Uruburetama", "06", -3.625, -39.50833);
case 18: return new CityInfo("Urbano Santos", "13", -3.20778, -43.40361);
case 19: return new CityInfo("Upanema", "22", -5.64194, -37.25778);
case 20: return new CityInfo("União dos Palmares", "02", -9.16278, -36.03194);
case 21: return new CityInfo("União", "20", -4.58583, -42.86417);
case 22: return new CityInfo("Umirim", "06", -3.67722, -39.35028);
case 23: return new CityInfo("Umbuzeiro", "17", -7.69556, -35.66361);
case 24: return new CityInfo("Umarizal", "22", -5.99056, -37.81444);
case 25: return new CityInfo("Uiraúna", "17", -6.51833, -38.41222);
case 26: return new CityInfo("Ubajara", "06", -3.85444, -40.92111);
case 27: return new CityInfo("Uauá", "05", -9.84139, -39.48167);
case 28: return new CityInfo("Tutóia", "13", -2.76194, -42.27444);
case 29: return new CityInfo("Turiaçu", "13", -1.66333, -45.37167);
case 30: return new CityInfo("Tupanatinga", "30", -8.75333, -37.33972);
case 31: return new CityInfo("Tuntum", "13", -5.25806, -44.64889);
case 32: return new CityInfo("Tucuruí", "16", -3.76585, -49.67923);
case 33: return new CityInfo("Tucumã", "16", -0.18333, -50.05);
case 34: return new CityInfo("Triunfo", "17", -6.56667, -38.6);
case 35: return new CityInfo("Trindade", "30", -7.76194, -40.26778);
case 36: return new CityInfo("Trairi", "06", -3.27778, -39.26889);
case 37: return new CityInfo("Traipu", "02", -9.97056, -37.00333);
case 38: return new CityInfo("Touros", "22", -5.19889, -35.46083);
case 39: return new CityInfo("Toritama", "30", -8.00667, -36.05667);
case 40: return new CityInfo("Tomé Açu", "16", -2.41889, -48.15222);
case 41: return new CityInfo("Timon", "13", -5.09417, -42.83667);
case 42: return new CityInfo("Timbiras", "13", -4.25528, -43.94056);
case 43: return new CityInfo("Timbaúba", "30", -7.50528, -35.31833);
case 44: return new CityInfo("Tianguá", "06", -3.73222, -40.99167);
case 45: return new CityInfo("Terra Santa", "16", -2.10417, -56.48694);
case 46: return new CityInfo("Teresina", "20", -5.08917, -42.80194);
case 47: return new CityInfo("Teixeira", "17", -7.22278, -37.25417);
case 48: return new CityInfo("Tavares", "17", -7.63583, -37.87833);
case 49: return new CityInfo("São João dos Inhamuns", "06", -6, -40.28333);
case 50: return new CityInfo("Taquaritinga do Norte", "30", -7.90306, -36.04417);
case 51: return new CityInfo("Taquarana", "02", -9.645, -36.49722);
case 52: return new CityInfo("Taperoá", "17", -7.2075, -36.82667);
case 53: return new CityInfo("Tangará", "22", -6.19944, -35.80167);
case 54: return new CityInfo("Tamboril", "06", -4.83222, -40.32056);
case 55: return new CityInfo("Tamandaré", "30", -8.75632, -35.09995);
case 56: return new CityInfo("Taipu", "22", -5.62167, -35.59667);
case 57: return new CityInfo("Tabira", "30", -7.59083, -37.53944);
case 58: return new CityInfo("Surubim", "30", -7.83306, -35.75472);
case 59: return new CityInfo("Sumé", "17", -7.67167, -36.88);
case 60: return new CityInfo("Sousa", "17", -6.75917, -38.22806);
case 61: return new CityInfo("Soure", "16", -0.71667, -48.52333);
case 62: return new CityInfo("Soledade", "17", -7.05722, -36.36278);
case 63: return new CityInfo("Solânea", "17", -6.755, -35.54);
case 64: return new CityInfo("Sobral", "06", -3.68611, -40.34972);
case 65: return new CityInfo("Sirinhaém", "30", -8.59083, -35.11611);
case 66: return new CityInfo("Simplício Mendes", "20", -7.85389, -41.91028);
case 67: return new CityInfo("Simões", "20", -7.59889, -40.81778);
case 68: return new CityInfo("Severiano Melo", "22", -5.77722, -37.95778);
case 69: return new CityInfo("Sertânia", "30", -8.07361, -37.26444);
case 70: return new CityInfo("Serra Talhada", "30", -7.99194, -38.29833);
case 71: return new CityInfo("Serra Branca", "17", -6.53333, -38.26667);
case 72: return new CityInfo("Senador Pompeu", "06", -5.58806, -39.37167);
case 73: return new CityInfo("Senador José Porfírio", "16", -2.59083, -51.95417);
case 74: return new CityInfo("Satuba", "02", -9.56333, -35.82444);
case 75: return new CityInfo("São Tomé", "22", -5.9725, -36.07528);
case 76: return new CityInfo("São Sebastião", "02", -9.93361, -36.55417);
case 77: return new CityInfo("São Raimundo Nonato", "20", -9.01528, -42.69944);
case 78: return new CityInfo("São Raimundo das Mangabeiras", "13", -7.02194, -45.48111);
case 79: return new CityInfo("São Pedro do Piauí", "20", -5.92944, -42.71861);
case 80: return new CityInfo("São Paulo do Potengi", "22", -5.895, -35.76278);
case 81: return new CityInfo("São Miguel do Tapuio", "20", -5.50361, -41.32333);
case 82: return new CityInfo("São Miguel dos Campos", "02", -9.78111, -36.09361);
case 83: return new CityInfo("São Miguel do Guamá", "16", -1.62667, -47.48333);
case 84: return new CityInfo("São Miguel", "22", -5.46667, -35.36667);
case 85: return new CityInfo("São Mateus do Maranhão", "13", -4.04167, -44.475);
case 86: return new CityInfo("São Luís do Quitunde", "02", -9.31833, -35.56111);
case 87: return new CityInfo("São Luís", "13", -2.52972, -44.30278);
case 88: return new CityInfo("São Lourenço da Mata", "30", -8.00222, -35.01833);
case 89: return new CityInfo("São José do Egito", "30", -7.47889, -37.27444);
case 90: return new CityInfo("São José do Campestre", "22", -6.31556, -35.71389);
case 91: return new CityInfo("São José do Belmonte", "30", -7.86139, -38.75972);
case 92: return new CityInfo("São José de Ribamar", "13", -2.56194, -44.05417);
case 93: return new CityInfo("São José de Piranhas", "17", -7.12056, -38.50194);
case 94: return new CityInfo("São José de Mipibu", "22", -6.07472, -35.23778);
case 95: return new CityInfo("São José da Tapera", "02", -9.55833, -37.38111);
case 96: return new CityInfo("São José da Laje", "02", -9.00972, -36.05833);
case 97: return new CityInfo("São José da Coroa Grande", "30", -8.89778, -35.14778);
case 98: return new CityInfo("São Joaquim do Monte", "30", -8.4325, -35.80444);
case 99: return new CityInfo("São João dos Patos", "13", -6.495, -43.70222);
case 100: return new CityInfo("São João do Piauí", "20", -8.35806, -42.24667);
case 101: return new CityInfo("São João de Pirabas", "16", -0.77472, -47.17722);
case 102: return new CityInfo("São João Batista", "13", -2.95528, -44.80694);
case 103: return new CityInfo("São João", "30", -8.87556, -36.36667);
case 104: return new CityInfo("São Gonçalo do Amarante", "22", -5.79333, -35.32944);
case 105: return new CityInfo("São Gonçalo do Amarante", "06", -3.60722, -38.96833);
case 106: return new CityInfo("São Geraldo do Araguaia", "16", -6.40056, -48.555);
case 107: return new CityInfo("São Félix do Xingu", "16", -6.64472, -51.995);
case 108: return new CityInfo("São Domingos do Maranhão", "13", -5.57583, -44.38528);
case 109: return new CityInfo("São Caetano de Odivelas", "16", -0.75, -48.02);
case 110: return new CityInfo("São Bernardo", "13", -3.36139, -42.41778);
case 111: return new CityInfo("São Bento", "17", -6.28333, -37.75);
case 112: return new CityInfo("São Bento", "13", -2.69583, -44.82139);
case 113: return new CityInfo("São Benedito do Rio Preto", "13", -3.33361, -43.52833);
case 114: return new CityInfo("Santo Antônio do Tauá", "16", -1.15194, -48.12944);
case 115: return new CityInfo("Santo Antônio", "22", -6.31056, -35.47889);
case 116: return new CityInfo("Santa Rita", "17", -7.11389, -34.97806);
case 117: return new CityInfo("Santa Rita", "13", -3.86358, -43.85999);
case 118: return new CityInfo("Santarém", "16", -2.44306, -54.70833);
case 119: return new CityInfo("Santa Quitéria do Maranhão", "13", -3.51556, -42.54667);
case 120: return new CityInfo("Santa Quitéria", "06", -4.33194, -40.15667);
case 121: return new CityInfo("Santana do Mundaú", "02", -9.16806, -36.22222);
case 122: return new CityInfo("Santana do Matos", "22", -5.9575, -36.65556);
case 123: return new CityInfo("Santana do Ipanema", "02", -9.37833, -37.24528);
case 124: return new CityInfo("Santana do Acaraú", "06", -3.46056, -40.21222);
case 125: return new CityInfo("Santa Maria do Pará", "16", -1.35028, -47.57556);
case 126: return new CityInfo("Santa Maria da Boa Vista", "30", -8.80778, -39.82556);
case 127: return new CityInfo("Santa Luzia", "13", -7.64265, -47.21738);
case 128: return new CityInfo("Santa Luzia", "17", -6.87222, -36.91861);
case 129: return new CityInfo("Santa Inês", "13", -3.66667, -45.38);
case 130: return new CityInfo("Santa Helena", "13", -2.23111, -45.3);
case 131: return new CityInfo("Santa Cruz do Capibaribe", "30", -7.9575, -36.20472);
case 132: return new CityInfo("Santa Cruz", "22", -6.22944, -36.02278);
case 133: return new CityInfo("Salinópolis", "16", -0.61361, -47.35611);
case 134: return new CityInfo("Salgueiro", "30", -8.07417, -39.11917);
case 135: return new CityInfo("Salgado de São Félix", "17", -7.35694, -35.44056);
case 136: return new CityInfo("Russas", "06", -4.94028, -37.97583);
case 137: return new CityInfo("Rio Tinto", "17", -6.80306, -35.08056);
case 138: return new CityInfo("Rio Largo", "02", -9.47833, -35.85333);
case 139: return new CityInfo("Rio Formoso", "30", -8.66877, -35.16277);
case 140: return new CityInfo("Ribeirão", "30", -8.51444, -35.37778);
case 141: return new CityInfo("Riachão", "13", -7.36194, -46.61722);
case 142: return new CityInfo("Reriutaba", "06", -4.14167, -40.58222);
case 143: return new CityInfo("Remígio", "17", -6.94646, -35.78039);
case 144: return new CityInfo("Regeneração", "20", -6.23122, -42.68691);
case 145: return new CityInfo("Redenção", "06", -4.22583, -38.73056);
case 146: return new CityInfo("Recife", "30", -8.05389, -34.88111);
case 147: return new CityInfo("Raposa", "13", -6.51667, -44.18333);
case 148: return new CityInfo("Quixeré", "06", -5.07417, -37.98861);
case 149: return new CityInfo("Quixeramobim", "06", -5.19917, -39.29278);
case 150: return new CityInfo("Quixadá", "06", -4.97139, -39.01528);
case 151: return new CityInfo("Quipapá", "30", -8.82778, -36.01167);
case 152: return new CityInfo("Quebrangulo", "02", -9.31889, -36.47111);
case 153: return new CityInfo("Puxinanã", "17", -7.16111, -35.96056);
case 154: return new CityInfo("Princesa Isabel", "17", -7.73667, -37.99333);
case 155: return new CityInfo("Presidente Dutra", "13", -5.29, -44.49);
case 156: return new CityInfo("Prainha", "16", -1.8, -53.48);
case 157: return new CityInfo("Santana", "03", -0.05833, -51.18167);
case 158: return new CityInfo("Porto Franco", "13", -6.33833, -47.39917);
case 159: return new CityInfo("Porto de Moz", "16", -1.74833, -52.23833);
case 160: return new CityInfo("Porto da Folha", "28", -9.91722, -37.27833);
case 161: return new CityInfo("Porto Calvo", "02", -9.045, -35.39833);
case 162: return new CityInfo("Porto", "20", -3.89333, -42.71);
case 163: return new CityInfo("Portel", "16", -1.93556, -50.82111);
case 164: return new CityInfo("Pombos", "30", -8.14139, -35.39583);
case 165: return new CityInfo("Pombal", "17", -6.77028, -37.80167);
case 166: return new CityInfo("Poço das Trincheiras", "02", -9.3125, -37.28556);
case 167: return new CityInfo("Poço Branco", "22", -5.62278, -35.66278);
case 168: return new CityInfo("Pocinhos", "17", -7.07667, -36.06111);
case 169: return new CityInfo("Poção de Pedras", "13", -4.66667, -44.85);
case 170: return new CityInfo("Pitimbu", "17", -7.47056, -34.80861);
case 171: return new CityInfo("Pirpirituba", "17", -6.78, -35.49861);
case 172: return new CityInfo("Piripiri", "20", -4.27333, -41.77694);
case 173: return new CityInfo("Pirapemas", "13", -3.72667, -44.22333);
case 174: return new CityInfo("Piracuruca", "20", -3.92806, -41.70917);
case 175: return new CityInfo("Pio XII", "13", -3.8325, -45.1525);
case 176: return new CityInfo("Pio IX", "20", -6.8375, -40.57917);
case 177: return new CityInfo("Pinheiro", "13", -2.52139, -45.0825);
case 178: return new CityInfo("Pindaré Mirim", "13", -3.60833, -45.34333);
case 179: return new CityInfo("Pimenteiras", "20", -6.24528, -41.41917);
case 180: return new CityInfo("Pilar", "02", -9.59722, -35.95667);
case 181: return new CityInfo("Pilar", "17", -7.26722, -35.26);
case 182: return new CityInfo("Picuí", "17", -6.51056, -36.34694);
case 183: return new CityInfo("Picos", "20", -7.07694, -41.46694);
case 184: return new CityInfo("Piancó", "17", -7.19806, -37.92917);
case 185: return new CityInfo("Petrolina", "30", -9.39861, -40.50083);
case 186: return new CityInfo("Jatobá", "30", -9.18306, -38.26889);
case 187: return new CityInfo("Pesqueira", "30", -8.35778, -36.69639);
case 188: return new CityInfo("Pentecoste", "06", -3.79278, -39.27028);
case 189: return new CityInfo("Pendências", "22", -5.26, -36.72222);
case 190: return new CityInfo("Penalva", "13", -3.29417, -45.17361);
case 191: return new CityInfo("Pedro Velho", "22", -6.43917, -35.22139);
case 192: return new CityInfo("Pedro II", "20", -4.42472, -41.45861);
case 193: return new CityInfo("Pedras de Fogo", "17", -7.40194, -35.11639);
case 194: return new CityInfo("Pedra Branca", "06", -5.45417, -39.71722);
case 195: return new CityInfo("Pedra", "30", -8.49694, -36.94083);
case 196: return new CityInfo("Paulo Ramos", "13", -4.21667, -45.18333);
case 197: return new CityInfo("Paulo Afonso", "05", -9.40611, -38.21472);
case 198: return new CityInfo("Paulista", "30", -7.94083, -34.87306);
case 199: return new CityInfo("Paulista", "17", -6.59389, -37.62417);
case 200: return new CityInfo("Patu", "22", -6.11, -37.63667);
case 201: return new CityInfo("Patos", "17", -7.02444, -37.28);
case 202: return new CityInfo("Pastos Bons", "13", -6.60167, -44.07667);
case 203: return new CityInfo("Passira", "30", -7.995, -35.58056);
case 204: return new CityInfo("Passagem Franca", "13", -6.17972, -43.78361);
case 205: return new CityInfo("Parnarama", "13", -5.68167, -43.09333);
case 206: return new CityInfo("Parnamirim", "30", -8.09056, -39.57833);
case 207: return new CityInfo("Parnamirim", "22", -5.91556, -35.26278);
case 208: return new CityInfo("Parnaíba", "20", -2.90472, -41.77667);
case 209: return new CityInfo("Parintins", "04", -2.62833, -56.73583);
case 210: return new CityInfo("Parelhas", "22", -6.68778, -36.6575);
case 211: return new CityInfo("Parambu", "06", -6.21111, -40.69444);
case 212: return new CityInfo("Paraipaba", "06", -3.43944, -39.14833);
case 213: return new CityInfo("Paraibano", "13", -6.43306, -43.98361);
case 214: return new CityInfo("Paragominas", "16", -2.96667, -47.48333);
case 215: return new CityInfo("Paracuru", "06", -3.41, -39.03056);
case 216: return new CityInfo("Pão de Açúcar", "02", -9.74833, -37.43667);
case 217: return new CityInfo("Palmeirais", "20", -5.97778, -43.06333);
case 218: return new CityInfo("Palmares", "30", -8.68333, -35.59167);
case 219: return new CityInfo("Pacatuba", "06", -3.98417, -38.62028);
case 220: return new CityInfo("Pacajus", "06", -4.1725, -38.46056);
case 221: return new CityInfo("Ouricuri", "30", -7.8825, -40.08167);
case 222: return new CityInfo("Ourém", "16", -1.55194, -47.11444);
case 223: return new CityInfo("Orós", "06", -6.24444, -38.91361);
case 224: return new CityInfo("Orobó", "30", -7.745, -35.60222);
case 225: return new CityInfo("Oriximiná", "16", -1.76556, -55.86611);
case 226: return new CityInfo("Olivença", "02", -9.51861, -37.19056);
case 227: return new CityInfo("Olinda", "30", -8.00889, -34.85528);
case 228: return new CityInfo("Oeiras do Pará", "16", -2.00306, -49.85444);
case 229: return new CityInfo("Oeiras", "20", -7.02528, -42.13111);
case 230: return new CityInfo("Ocara", "06", -4.49083, -38.59667);
case 231: return new CityInfo("Óbidos", "16", -1.9175, -55.51806);
case 232: return new CityInfo("Novo Oriente", "06", -5.53444, -40.77417);
case 233: return new CityInfo("Novo Lino", "02", -8.915, -35.64667);
case 234: return new CityInfo("Nova Russas", "06", -4.70667, -40.56306);
case 235: return new CityInfo("Nova Olinda do Norte", "04", -3.89174, -59.09542);
case 236: return new CityInfo("Nova Floresta", "17", -6.45528, -36.20333);
case 237: return new CityInfo("Nova Cruz", "22", -6.47806, -35.43389);
case 238: return new CityInfo("Nísia Floresta", "22", -6.09111, -35.20861);
case 239: return new CityInfo("Nhamundá", "04", -2.18611, -56.71306);
case 240: return new CityInfo("Nazaré da Mata", "30", -7.74167, -35.22778);
case 241: return new CityInfo("Natuba", "17", -7.64139, -35.55);
case 242: return new CityInfo("Natal", "22", -5.795, -35.20944);
case 243: return new CityInfo("Murici", "02", -9.30667, -35.94333);
case 244: return new CityInfo("Mulungu", "17", -7.02444, -35.46194);
case 245: return new CityInfo("Muaná", "16", -1.52833, -49.21667);
case 246: return new CityInfo("Morros", "13", -9.44667, -46.30028);
case 247: return new CityInfo("Moreno", "30", -8.11861, -35.09222);
case 248: return new CityInfo("Morada Nova", "06", -5.10667, -38.3725);
case 249: return new CityInfo("Montes Altos", "13", -5.83333, -47.06667);
case 250: return new CityInfo("Monteiro", "17", -7.88944, -37.12);
case 251: return new CityInfo("Monte Alegre", "22", -5.88972, -36.30139);
case 252: return new CityInfo("Monte Alegre", "16", -2.00082, -54.08102);
case 253: return new CityInfo("Montanhas", "22", -6.48583, -35.2875);
case 254: return new CityInfo("Monsenhor Gil", "20", -5.56417, -42.60778);
case 255: return new CityInfo("Monção", "13", -3.49167, -45.25111);
case 256: return new CityInfo("Mombaça", "06", -5.74306, -39.6275);
case 257: return new CityInfo("Moju", "16", -1.88389, -48.76889);
case 258: return new CityInfo("Mogeiro", "17", -7.29944, -35.47944);
case 259: return new CityInfo("Mossoró", "22", -5.1875, -37.34417);
case 260: return new CityInfo("Mocajuba", "16", -2.58417, -49.50722);
case 261: return new CityInfo("Missão Velha", "06", -7.24972, -39.14306);
case 262: return new CityInfo("Mirador", "13", -6.37083, -44.36306);
case 263: return new CityInfo("Miracema do Tocantins", "31", -9.56722, -48.39167);
case 264: return new CityInfo("Minador do Negrão", "02", -9.30528, -36.86472);
case 265: return new CityInfo("Milagres", "06", -7.31333, -38.94556);
case 266: return new CityInfo("Miguel Alves", "20", -4.16556, -42.89528);
case 267: return new CityInfo("Messias", "02", -9.38333, -35.84167);
case 268: return new CityInfo("Mazagão", "03", -0.115, -51.28944);
case 269: return new CityInfo("Maués", "04", -3.38361, -57.71861);
case 270: return new CityInfo("Matriz de Camaragibe", "02", -9.15167, -35.53333);
case 271: return new CityInfo("Matinha", "13", -3.10056, -45.03361);
case 272: return new CityInfo("Matias Olímpio", "20", -3.71583, -42.55556);
case 273: return new CityInfo("Mata Grande", "02", -9.1175, -37.73222);
case 274: return new CityInfo("Massaranduba", "17", -7.20028, -35.78917);
case 275: return new CityInfo("Maribondo", "02", -9.57722, -36.30528);
case 276: return new CityInfo("Mari", "17", -7.06, -35.31944);
case 277: return new CityInfo("Marechal Deodoro", "02", -9.71028, -35.895);
case 278: return new CityInfo("Marco", "06", -3.12389, -40.14667);
case 279: return new CityInfo("Marapanim", "16", -0.7175, -47.69972);
case 280: return new CityInfo("Maraial", "30", -8.7825, -35.80889);
case 281: return new CityInfo("Maragogi", "02", -9.01222, -35.2225);
case 282: return new CityInfo("Maracanaú", "06", -3.87667, -38.62556);
case 283: return new CityInfo("Maracanã", "16", -0.76614, -47.45371);
case 284: return new CityInfo("Maracaçumé", "13", -2.04278, -45.95917);
case 285: return new CityInfo("Marabá", "16", -5.38146, -49.13232);
case 286: return new CityInfo("Manaíra", "17", -7.70611, -38.15444);
case 287: return new CityInfo("Mamanguape", "17", -6.83861, -35.12611);
case 288: return new CityInfo("Major Isidoro", "02", -9.53222, -36.985);
case 289: return new CityInfo("Maceió", "02", -9.66583, -35.73528);
case 290: return new CityInfo("Macau", "22", -5.115, -36.63444);
case 291: return new CityInfo("Macaparana", "30", -7.55472, -35.45306);
case 292: return new CityInfo("Macapá", "03", 0.03889, -51.06639);
case 293: return new CityInfo("Macaíba", "22", -5.85833, -35.35389);
case 294: return new CityInfo("Luzilândia", "20", -3.45778, -42.37028);
case 295: return new CityInfo("Luís Correia", "20", -2.87917, -41.66694);
case 296: return new CityInfo("Limoeiro do Norte", "06", -5.14556, -38.09806);
case 297: return new CityInfo("Limoeiro do Ajuru", "16", -1.89528, -49.38056);
case 298: return new CityInfo("Limoeiro de Anadia", "02", -9.74056, -36.50278);
case 299: return new CityInfo("Limoeiro", "30", -7.87472, -35.45028);
case 300: return new CityInfo("Lavras da Mangabeira", "06", -6.75333, -38.96444);
case 301: return new CityInfo("Lajedo", "30", -8.66361, -36.32);
case 302: return new CityInfo("Lago da Pedra", "13", -4.28674, -45.23824);
case 303: return new CityInfo("Lagoa Seca", "17", -7.17083, -35.85361);
case 304: return new CityInfo("Lagoa Nova", "22", -6.1, -36.48333);
case 305: return new CityInfo("Lagoa do Itaenga", "30", -7.93611, -35.29028);
case 306: return new CityInfo("Lagoa da Canoa", "02", -9.82972, -36.73778);
case 307: return new CityInfo("Juruti", "16", -2.15222, -56.09222);
case 308: return new CityInfo("Juru", "17", -7.53694, -37.81861);
case 309: return new CityInfo("Juripiranga", "17", -7.37333, -35.23806);
case 310: return new CityInfo("Junqueiro", "02", -9.92528, -36.47583);
case 311: return new CityInfo("Jundiá", "02", -8.93472, -35.57361);
case 312: return new CityInfo("Jucurutu", "22", -6.03389, -37.02028);
case 313: return new CityInfo("Jucás", "06", -6.52528, -39.5275);
case 314: return new CityInfo("Juazeiro do Norte", "06", -7.21306, -39.31528);
case 315: return new CityInfo("Juàzeirinho", "17", -6.81667, -38.05);
case 316: return new CityInfo("Juá dos Vieiras", "06", -3.53333, -41.3);
case 317: return new CityInfo("José de Freitas", "20", -4.75639, -42.57556);
case 318: return new CityInfo("Joaquim Nabuco", "30", -8.62444, -35.53333);
case 319: return new CityInfo("João Pessoa", "17", -7.115, -34.86306);
case 320: return new CityInfo("João Câmara", "22", -5.5375, -35.81972);
case 321: return new CityInfo("João Alfredo", "30", -7.85583, -35.58833);
case 322: return new CityInfo("Girau do Ponciano", "02", -9.88417, -36.82889);
case 323: return new CityInfo("Jardim do Seridó", "22", -6.58444, -36.77444);
case 324: return new CityInfo("Jardim de Piranhas", "22", -6.37861, -37.35194);
case 325: return new CityInfo("Jardim", "06", -3.46444, -39.05667);
case 326: return new CityInfo("Jaicós", "20", -7.35917, -41.13778);
case 327: return new CityInfo("Jaguaruana", "06", -4.83389, -37.78111);
case 328: return new CityInfo("Jaguaribe", "06", -5.89056, -38.62194);
case 329: return new CityInfo("Jacareacanga", "16", -6.22222, -57.75278);
case 330: return new CityInfo("Jacaraú", "17", -6.61222, -35.29278);
case 331: return new CityInfo("Jaboatão", "30", -8.18028, -35.00139);
case 332: return new CityInfo("Itupiranga", "16", -5.13472, -49.32667);
case 333: return new CityInfo("Itaueira", "20", -7.60333, -43.02556);
case 334: return new CityInfo("Itatuba", "17", -7.375, -35.62833);
case 335: return new CityInfo("Itaquitinga", "30", -7.66778, -35.10167);
case 336: return new CityInfo("Itacoatiara", "04", -3.14306, -58.44417);
case 337: return new CityInfo("Itaporanga", "17", -7.30444, -38.15028);
case 338: return new CityInfo("Itapissuma", "30", -7.77639, -34.89222);
case 339: return new CityInfo("Itapipoca", "06", -3.49444, -39.57861);
case 340: return new CityInfo("Itapecuru Mirim", "13", -3.3925, -44.35861);
case 341: return new CityInfo("Itapagé", "06", -3.68667, -39.58611);
case 342: return new CityInfo("Itamaracá", "30", -7.74778, -34.82556);
case 343: return new CityInfo("Itaituba", "16", -4.27611, -55.98361);
case 344: return new CityInfo("Itaitinga", "06", -3.96944, -38.52806);
case 345: return new CityInfo("Itainópolis", "20", -7.44694, -41.47833);
case 346: return new CityInfo("Itaíba", "30", -8.9475, -37.42278);
case 347: return new CityInfo("Itabaiana", "17", -7.32861, -35.3325);
case 348: return new CityInfo("Irituia", "16", -1.77111, -47.43806);
case 349: return new CityInfo("Irauçuba", "06", -3.74611, -39.78333);
case 350: return new CityInfo("Ipueiras", "20", -7.03333, -40.45);
case 351: return new CityInfo("Ipubi", "30", -7.65194, -40.14889);
case 352: return new CityInfo("Ipu", "06", -4.32222, -40.71083);
case 353: return new CityInfo("Ipojuca", "30", -8.39889, -35.06389);
case 354: return new CityInfo("Ipanguaçu", "22", -5.49833, -36.855);
case 355: return new CityInfo("Inhuma", "20", -6.66833, -41.70778);
case 356: return new CityInfo("Inhapi", "02", -9.22139, -37.74861);
case 357: return new CityInfo("Ingá", "17", -7.28083, -35.60444);
case 358: return new CityInfo("Independência", "06", -5.39639, -40.30861);
case 359: return new CityInfo("Imperatriz", "13", -5.52639, -47.49167);
case 360: return new CityInfo("Imaculada", "17", -7.38972, -37.50917);
case 361: return new CityInfo("Iguatu", "06", -6.35944, -39.29861);
case 362: return new CityInfo("Igarapé Miri", "16", -1.975, -48.95972);
case 363: return new CityInfo("Igarapé Açu", "16", -1.12889, -47.62);
case 364: return new CityInfo("Igarassu", "30", -7.83417, -34.90639);
case 365: return new CityInfo("Igaci", "02", -9.53694, -36.63361);
case 366: return new CityInfo("Icó", "06", -6.40111, -38.86222);
case 367: return new CityInfo("Icatu", "13", -2.77583, -44.06583);
case 368: return new CityInfo("Ibimirim", "30", -8.54056, -37.69028);
case 369: return new CityInfo("Ibiapina", "06", -3.92333, -40.88944);
case 370: return new CityInfo("Ibateguara", "02", -8.9725, -35.93944);
case 371: return new CityInfo("Humberto de Campos", "13", -2.59833, -43.46111);
case 372: return new CityInfo("Horizonte", "06", -4.1, -38.48333);
case 373: return new CityInfo("Hidrolândia", "06", -4.40806, -40.43778);
case 374: return new CityInfo("Gurupá", "16", -1.405, -51.64);
case 375: return new CityInfo("Gurinhém", "17", -7.12389, -35.42444);
case 376: return new CityInfo("Guaraciaba do Norte", "06", -4.16694, -40.7475);
case 377: return new CityInfo("Guarabira", "17", -6.85472, -35.49);
case 378: return new CityInfo("Guajará", "04", -2.96667, -57.66667);
case 379: return new CityInfo("Guaiúba", "06", -4.03972, -38.63722);
case 380: return new CityInfo("Guabiraba", "30", -8.41667, -35.66667);
case 381: return new CityInfo("Gravatá", "30", -8.20111, -35.56472);
case 382: return new CityInfo("Granja", "06", -3.12028, -40.82611);
case 383: return new CityInfo("Grajaú", "13", -5.81944, -46.13861);
case 384: return new CityInfo("Governador Dix Sept Rosado", "22", -5.45889, -37.52083);
case 385: return new CityInfo("Goianinha", "22", -6.26472, -35.2125);
case 386: return new CityInfo("Goiana", "30", -7.56056, -35.0025);
case 387: return new CityInfo("Glória do Goitá", "30", -8.00167, -35.29278);
case 388: return new CityInfo("Gilbués", "20", -9.83167, -45.34389);
case 389: return new CityInfo("Gararu", "28", -9.9675, -37.08333);
case 390: return new CityInfo("Garanhuns", "30", -8.88202, -36.50216);
case 391: return new CityInfo("Gameleira", "30", -8.58444, -35.38667);
case 392: return new CityInfo("Fortuna", "13", -5.73333, -44.15833);
case 393: return new CityInfo("Fortaleza", "06", -3.71722, -38.54306);
case 394: return new CityInfo("Forquilha", "06", -3.79833, -40.26056);
case 395: return new CityInfo("Floriano", "20", -6.76694, -43.0225);
case 396: return new CityInfo("Floresta", "30", -8.60111, -38.56861);
case 397: return new CityInfo("Flores", "30", -7.86806, -37.97472);
case 398: return new CityInfo("Flexeiras", "02", -9.1975, -35.78083);
case 399: return new CityInfo("Feira Nova", "30", -7.95083, -35.38917);
case 400: return new CityInfo("Farias Brito", "06", -6.93056, -39.56556);
case 401: return new CityInfo("Fagundes", "17", -7.355, -35.775);
case 402: return new CityInfo("Exu", "30", -7.51194, -39.72417);
case 403: return new CityInfo("Eusébio", "06", -3.89, -38.45056);
case 404: return new CityInfo("Extremoz", "22", -5.70556, -35.30722);
case 405: return new CityInfo("Estreito", "13", -5.78333, -43.25);
case 406: return new CityInfo("Esperantinópolis", "13", -4.86667, -44.70833);
case 407: return new CityInfo("Esperantina", "20", -3.90167, -42.23361);
case 408: return new CityInfo("Esperança", "17", -7.03306, -35.85722);
case 409: return new CityInfo("Escada", "30", -8.35917, -35.22361);
case 410: return new CityInfo("Elesbão Veloso", "20", -6.20194, -42.14028);
case 411: return new CityInfo("Dona Inês", "17", -6.61354, -35.62654);
case 412: return new CityInfo("Dom Pedro", "13", -5.03749, -44.43857);
case 413: return new CityInfo("Dois Riachos", "02", -9.3925, -37.10056);
case 414: return new CityInfo("Desterro", "17", -7.29056, -37.09389);
case 415: return new CityInfo("Demerval Lobão", "20", -5.35833, -42.67639);
case 416: return new CityInfo("Delmiro Gouveia", "02", -9.38861, -37.99917);
case 417: return new CityInfo("Custódia", "30", -8.0875, -37.64306);
case 418: return new CityInfo("Cururupu", "13", -1.82833, -44.86833);
case 419: return new CityInfo("Curuçá", "16", -0.72889, -47.84806);
case 420: return new CityInfo("Currais Novos", "22", -6.26083, -36.51778);
case 421: return new CityInfo("Curaçá", "05", -8.99028, -39.90944);
case 422: return new CityInfo("Cupira", "30", -8.61667, -35.95);
case 423: return new CityInfo("Cumaru", "30", -8.00611, -35.69722);
case 424: return new CityInfo("Cuité", "17", -6.48361, -36.15361);
case 425: return new CityInfo("Cruz do Espírito Santo", "17", -7.14, -35.08639);
case 426: return new CityInfo("Cruz", "06", -2.9211, -40.17589);
case 427: return new CityInfo("Crato", "06", -7.23417, -39.40944);
case 428: return new CityInfo("Crateús", "06", -5.17833, -40.6775);
case 429: return new CityInfo("Coroatá", "13", -4.13, -44.12417);
case 430: return new CityInfo("Coremas", "17", -7.01444, -37.94583);
case 431: return new CityInfo("Coreaú", "06", -3.53333, -40.65667);
case 432: return new CityInfo("Condado", "30", -7.58583, -35.10583);
case 433: return new CityInfo("Conceição do Araguaia", "16", -8.26441, -49.26982);
case 434: return new CityInfo("Colônia Leopoldina", "30", -8.90889, -35.725);
case 435: return new CityInfo("Colinas", "13", -6.02583, -44.24917);
case 436: return new CityInfo("Coité do Nóia", "02", -9.63222, -36.57861);
case 437: return new CityInfo("Coelho Neto", "13", -4.25667, -43.01278);
case 438: return new CityInfo("Codó", "13", -4.45528, -43.88556);
case 439: return new CityInfo("Cocal", "20", -3.47194, -41.5575);
case 440: return new CityInfo("Chorozinho", "06", -4.30028, -38.49778);
case 441: return new CityInfo("Chapadinha", "13", -3.74167, -43.36028);
case 442: return new CityInfo("Chã Grande", "30", -8.23833, -35.46167);
case 443: return new CityInfo("Cerro Corá", "22", -6.04556, -36.34583);
case 444: return new CityInfo("Cedro", "06", -6.60667, -39.06222);
case 445: return new CityInfo("Ceará Mirim", "22", -5.63444, -35.42556);
case 446: return new CityInfo("Caxias", "13", -4.85889, -43.35611);
case 447: return new CityInfo("Caucaia", "06", -3.73611, -38.65306);
case 448: return new CityInfo("Catolé do Rocha", "17", -6.34389, -37.74667);
case 449: return new CityInfo("Catende", "30", -8.66667, -35.71667);
case 450: return new CityInfo("Castelo do Piauí", "20", -5.32222, -41.5525);
case 451: return new CityInfo("Castanhal", "16", -1.29389, -47.92639);
case 452: return new CityInfo("Cascavel", "06", -4.13306, -38.24194);
case 453: return new CityInfo("Carutapera", "13", -1.195, -46.02);
case 454: return new CityInfo("Caruaru", "30", -8.28333, -35.97611);
case 455: return new CityInfo("Carpina", "30", -7.85083, -35.25472);
case 456: return new CityInfo("Carolina", "13", -7.33561, -47.46218);
case 457: return new CityInfo("Carnaíba", "30", -8.7, -37.66667);
case 458: return new CityInfo("Caririaçu", "06", -7.04222, -39.28361);
case 459: return new CityInfo("Cariré", "06", -3.95056, -40.47333);
case 460: return new CityInfo("Careiro da Várzea", "04", -3.19695, -59.82674);
case 461: return new CityInfo("Caraúbas", "22", -5.7925, -37.55667);
case 462: return new CityInfo("Capoeiras", "30", -8.73472, -36.62667);
case 463: return new CityInfo("Capitão Poço", "16", -1.74639, -47.05944);
case 464: return new CityInfo("Capela", "02", -9.4075, -36.07361);
case 465: return new CityInfo("Capanema", "16", -1.19583, -47.18083);
case 466: return new CityInfo("Canto do Buriti", "20", -8.11, -42.94444);
case 467: return new CityInfo("Cantanhede", "13", -3.63333, -44.37667);
case 468: return new CityInfo("Canindé de São Francisco", "28", -9.66, -37.78944);
case 469: return new CityInfo("Canindé", "06", -4.35889, -39.31167);
case 470: return new CityInfo("Canhotinho", "30", -8.88222, -36.19111);
case 471: return new CityInfo("Canguaretama", "22", -6.38, -35.12889);
case 472: return new CityInfo("Cândido Mendes", "13", -1.44667, -45.71667);
case 473: return new CityInfo("Campos Sales", "06", -7.07444, -40.37611);
case 474: return new CityInfo("Campo Maior", "20", -4.82778, -42.16861);
case 475: return new CityInfo("Campo Alegre", "02", -9.78194, -36.35083);
case 476: return new CityInfo("Campina Grande", "17", -7.23056, -35.88111);
case 477: return new CityInfo("Camocim de São Félix", "30", -8.35861, -35.76194);
case 478: return new CityInfo("Camocim", "06", -2.90222, -40.84111);
case 479: return new CityInfo("Cametá", "16", -2.24444, -49.49583);
case 480: return new CityInfo("Cajueiro", "02", -9.71667, -36.45);
case 481: return new CityInfo("Cajazeiras", "17", -6.89028, -38.55528);
case 482: return new CityInfo("Caicó", "22", -6.45833, -37.09778);
case 483: return new CityInfo("Caetés", "30", -8.77306, -36.6225);
case 484: return new CityInfo("Cacimbinhas", "02", -9.40028, -36.99028);
case 485: return new CityInfo("Cacimba de Dentro", "17", -6.64167, -35.79);
case 486: return new CityInfo("Cachoeirinha", "30", -8.48639, -36.23306);
case 487: return new CityInfo("Cabrobó", "30", -8.51417, -39.31);
case 488: return new CityInfo("Cabo", "30", -8.28333, -35.03333);
case 489: return new CityInfo("Cabedelo", "17", -6.98111, -34.83389);
case 490: return new CityInfo("Caaporã", "17", -7.51556, -34.90833);
case 491: return new CityInfo("Buriti dos Lopes", "20", -3.175, -41.86694);
case 492: return new CityInfo("Buriti Bravo", "13", -5.83722, -43.83361);
case 493: return new CityInfo("Bujaru", "16", -1.515, -48.04472);
case 494: return new CityInfo("Buíque", "30", -8.62306, -37.15583);
case 495: return new CityInfo("Breves", "16", -1.68222, -50.48028);
case 496: return new CityInfo("Brejo Santo", "06", -7.49333, -38.98722);
case 497: return new CityInfo("Brejo da Madre de Deus", "30", -8.14583, -36.37111);
case 498: return new CityInfo("Brejo", "13", -3.68444, -42.75028);
case 499: return new CityInfo("Brejinho", "22", -6.19083, -35.35667);
case 500: return new CityInfo("Bragança", "16", -1.05361, -46.76556);
case 501: return new CityInfo("Borba", "04", -4.39143, -59.58864);
case 502: return new CityInfo("Boqueirão", "17", -7.48237, -36.13422);
case 503: return new CityInfo("Bonito", "30", -8.47028, -35.72861);
case 504: return new CityInfo("Bom Jesus", "20", -9.07444, -44.35861);
case 505: return new CityInfo("Bom Jardim", "30", -7.79583, -35.58722);
case 506: return new CityInfo("Bom Jardim", "13", -7.01667, -46.48333);
case 507: return new CityInfo("Bom Conselho", "30", -9.16972, -36.67972);
case 508: return new CityInfo("Boa Viagem", "06", -5.1275, -39.73222);
case 509: return new CityInfo("Bezerros", "30", -8.23333, -35.79694);
case 510: return new CityInfo("Bequimão", "13", -2.44889, -44.7825);
case 511: return new CityInfo("Benevides", "16", -1.36139, -48.24472);
case 512: return new CityInfo("Beneditinos", "20", -5.45, -42.36667);
case 513: return new CityInfo("Belo Jardim", "30", -8.33556, -36.42417);
case 514: return new CityInfo("Belém do Brejo do Cruz", "17", -6.18861, -37.53583);
case 515: return new CityInfo("Belém de São Francisco", "30", -8.75389, -38.96583);
case 516: return new CityInfo("Belém", "17", -6.69167, -35.53333);
case 517: return new CityInfo("Belém", "16", -1.45583, -48.50444);
case 518: return new CityInfo("Bela Cruz", "06", -3.05056, -40.16778);
case 519: return new CityInfo("Beberibe", "06", -4.17972, -38.13056);
case 520: return new CityInfo("Bayeux", "17", -7.125, -34.93222);
case 521: return new CityInfo("Baturité", "06", -4.32861, -38.88472);
case 522: return new CityInfo("Batalha", "02", -9.67778, -37.12472);
case 523: return new CityInfo("Batalha", "20", -4.025, -42.075);
case 524: return new CityInfo("Barroquinha", "06", -3.01889, -41.13611);
case 525: return new CityInfo("Barro", "06", -6.71667, -38.86667);
case 526: return new CityInfo("Barreiros", "30", -8.81833, -35.18639);
case 527: return new CityInfo("Barreirinhas", "13", -2.75556, -42.82591);
case 528: return new CityInfo("Barreirinha", "04", -2.79333, -57.07);
case 529: return new CityInfo("Barras", "20", -4.24444, -42.29444);
case 530: return new CityInfo("Barra do Corda", "13", -5.50556, -45.24333);
case 531: return new CityInfo("Barra de Santo Antônio", "02", -9.40472, -35.50722);
case 532: return new CityInfo("Barcarena", "16", -1.50583, -48.62583);
case 533: return new CityInfo("Barbalha", "06", -7.31111, -39.30417);
case 534: return new CityInfo("Baraúna", "22", -5.08, -37.61667);
case 535: return new CityInfo("Bananeiras", "17", -6.75, -35.63333);
case 536: return new CityInfo("Balsas", "13", -7.5325, -46.03556);
case 537: return new CityInfo("Baião", "16", -2.79056, -49.67167);
case 538: return new CityInfo("Bacabal", "13", -4.29167, -44.79167);
case 539: return new CityInfo("Autazes", "04", -3.57972, -59.13056);
case 540: return new CityInfo("Aurora", "06", -6.9425, -38.9675);
case 541: return new CityInfo("Augusto Corrêa", "16", -1.02167, -46.635);
case 542: return new CityInfo("Atalaia", "02", -9.50194, -36.02278);
case 543: return new CityInfo("Assaré", "06", -6.87444, -39.875);
case 544: return new CityInfo("Aroeiras", "17", -7.54528, -35.7075);
case 545: return new CityInfo("Arês", "22", -6.19444, -35.16028);
case 546: return new CityInfo("Areia Branca", "22", -4.95611, -37.13694);
case 547: return new CityInfo("Areia", "17", -6.96333, -35.69167);
case 548: return new CityInfo("Arcoverde", "30", -8.41889, -37.05389);
case 549: return new CityInfo("Araruna", "17", -6.55833, -35.74167);
case 550: return new CityInfo("Araripina", "30", -7.57611, -40.49833);
case 551: return new CityInfo("Araripe", "06", -7.21337, -40.137);
case 552: return new CityInfo("Arari", "13", -3.45361, -44.78);
case 553: return new CityInfo("Arara", "17", -6.82833, -35.75833);
case 554: return new CityInfo("Arapiraca", "02", -9.7525, -36.66111);
case 555: return new CityInfo("Araioses", "13", -2.89, -41.90306);
case 556: return new CityInfo("Araguaína", "31", -7.19111, -48.20722);
case 557: return new CityInfo("Araçoiaba", "30", -7.79028, -35.09083);
case 558: return new CityInfo("Aracoiaba", "06", -4.37111, -38.81417);
case 559: return new CityInfo("Aracati", "06", -4.56167, -37.76972);
case 560: return new CityInfo("Aquiraz", "06", -3.90139, -38.39111);
case 561: return new CityInfo("Apodi", "22", -5.66417, -37.79889);
case 562: return new CityInfo("Angicos", "22", -5.66556, -36.60111);
case 563: return new CityInfo("Ananindeua", "16", -1.36556, -48.37222);
case 564: return new CityInfo("Anajatuba", "13", -3.26444, -44.61972);
case 565: return new CityInfo("Anadia", "02", -9.68444, -36.30417);
case 566: return new CityInfo("Amontada", "06", -3.36167, -39.83167);
case 567: return new CityInfo("Amarante do Maranhão", "13", -5.56667, -46.74222);
case 568: return new CityInfo("Amarante", "20", -6.24316, -42.84544);
case 569: return new CityInfo("Amaraji", "30", -8.38306, -35.4525);
case 570: return new CityInfo("Altos", "20", -5.03806, -42.46);
case 571: return new CityInfo("Alto Longá", "20", -5.25111, -42.21028);
case 572: return new CityInfo("Altinho", "30", -8.48972, -36.05944);
case 573: return new CityInfo("Altamira", "16", -3.20333, -52.20639);
case 574: return new CityInfo("Almeirim", "16", -1.52333, -52.58167);
case 575: return new CityInfo("Alhandra", "17", -7.43861, -34.91444);
case 576: return new CityInfo("Alexandria", "22", -6.4125, -38.01583);
case 577: return new CityInfo("Alenquer", "16", -1.94167, -54.73833);
case 578: return new CityInfo("Alcântara", "13", -2.4041, -44.41669);
case 579: return new CityInfo("Alagoinha", "17", -6.95, -35.545);
case 580: return new CityInfo("Alagoa Nova", "17", -7.07083, -35.75833);
case 581: return new CityInfo("Alagoa Grande", "17", -7.15833, -35.63);
case 582: return new CityInfo("Águas Belas", "30", -9.11139, -37.12306);
case 583: return new CityInfo("Água Preta", "30", -8.7075, -35.53056);
case 584: return new CityInfo("Água Branca", "02", -9.26083, -37.93611);
case 585: return new CityInfo("Água Branca", "20", -5.89222, -42.63611);
case 586: return new CityInfo("Agrestina", "30", -8.45806, -35.94472);
case 587: return new CityInfo("Afuá", "16", -0.15667, -50.38667);
case 588: return new CityInfo("Afonso Bezerra", "22", -5.49833, -36.50556);
case 589: return new CityInfo("Afogados da Ingazeira", "30", -7.75083, -37.63917);
case 590: return new CityInfo("Açu", "22", -5.57667, -36.90861);
case 591: return new CityInfo("Acopiara", "06", -6.09528, -39.4525);
case 592: return new CityInfo("Acaraú", "06", -2.88556, -40.12);
case 593: return new CityInfo("Acará", "16", -1.96083, -48.19667);
case 594: return new CityInfo("Abreu e Lima", "30", -7.91167, -34.90278);
case 595: return new CityInfo("Abaetetuba", "16", -1.71806, -48.8825);
case 596: return new CityInfo("Xique Xique", "05", -10.82294, -42.72815);
case 597: return new CityInfo("Chavantes", "27", -23.03889, -49.70944);
case 598: return new CityInfo("Xanxerê", "26", -26.87694, -52.40417);
case 599: return new CityInfo("Votuporanga", "27", -20.42278, -49.97278);
case 600: return new CityInfo("Votorantim", "27", -23.54667, -47.43778);
case 601: return new CityInfo("Volta Redonda", "21", -22.52306, -44.10417);
case 602: return new CityInfo("Vitória da Conquista", "05", -14.86611, -40.83944);
case 603: return new CityInfo("Vitória", "08", -20.31944, -40.33778);
case 604: return new CityInfo("Visconde do Rio Branco", "15", -21.01028, -42.84056);
case 605: return new CityInfo("Viradouro", "27", -20.87306, -48.29694);
case 606: return new CityInfo("Vinhedo", "27", -23.02972, -46.97528);
case 607: return new CityInfo("Vila Velha", "08", -20.32972, -40.2925);
case 608: return new CityInfo("Videira", "26", -27.00833, -51.15167);
case 609: return new CityInfo("Viçosa", "15", -20.75389, -42.88194);
case 610: return new CityInfo("Vianópolis", "29", -16.74194, -48.51639);
case 611: return new CityInfo("Viana", "08", -20.39028, -40.49611);
case 612: return new CityInfo("Viamão", "23", -30.08111, -51.02333);
case 613: return new CityInfo("Vespasiano", "15", -19.69194, -43.92333);
case 614: return new CityInfo("Veranópolis", "23", -28.93611, -51.54944);
case 615: return new CityInfo("Vera Cruz", "05", -12.63333, -41.03333);
case 616: return new CityInfo("Wenceslau Braz", "18", -23.87389, -49.80278);
case 617: return new CityInfo("Venâncio Aires", "23", -29.60639, -52.19194);
case 618: return new CityInfo("Vazante", "15", -17.98694, -46.90778);
case 619: return new CityInfo("Vassouras", "21", -22.40389, -43.6625);
case 620: return new CityInfo("Varzelândia", "15", -15.70139, -44.0275);
case 621: return new CityInfo("Várzea Paulista", "27", -23.21139, -46.82833);
case 622: return new CityInfo("Várzea Grande", "14", -15.64667, -56.1325);
case 623: return new CityInfo("Várzea da Palma", "15", -17.5976, -44.73367);
case 624: return new CityInfo("Varginha", "15", -21.55139, -45.43028);
case 625: return new CityInfo("Vargem Grande do Sul", "27", -21.83222, -46.89361);
case 626: return new CityInfo("Vargem Alta", "08", -20.67139, -41.00694);
case 627: return new CityInfo("Valparaíso", "27", -21.22778, -50.86833);
case 628: return new CityInfo("Valinhos", "27", -22.97056, -46.99583);
case 629: return new CityInfo("Valente", "05", -11.41222, -39.46194);
case 630: return new CityInfo("Valença", "21", -22.24556, -43.70028);
case 631: return new CityInfo("Valença", "05", -13.37028, -39.07306);
case 632: return new CityInfo("Vacaria", "23", -28.51222, -50.93389);
case 633: return new CityInfo("Urussanga", "26", -28.51778, -49.32083);
case 634: return new CityInfo("Urupês", "27", -21.20167, -49.29);
case 635: return new CityInfo("Uruguaiana", "23", -29.75472, -57.08833);
case 636: return new CityInfo("Uruçuca", "05", -14.59306, -39.28444);
case 637: return new CityInfo("Uruana", "29", -15.5036, -49.68266);
case 638: return new CityInfo("Uruaçu", "29", -14.52472, -49.14083);
case 639: return new CityInfo("União da Vitória", "18", -26.23, -51.08639);
case 640: return new CityInfo("Unaí", "15", -16.3575, -46.90611);
case 641: return new CityInfo("Una", "05", -15.29333, -39.07528);
case 642: return new CityInfo("Umuarama", "18", -23.76639, -53.325);
case 643: return new CityInfo("Umbaúba", "28", -11.38333, -37.65778);
case 644: return new CityInfo("Uberlândia", "15", -18.91861, -48.27722);
case 645: return new CityInfo("Uberaba", "15", -19.74833, -47.93194);
case 646: return new CityInfo("Ubatuba", "27", -23.43389, -45.07111);
case 647: return new CityInfo("Ubatã", "05", -14.20906, -39.52641);
case 648: return new CityInfo("Ubaitaba", "05", -14.3125, -39.32333);
case 649: return new CityInfo("Ubaíra", "05", -13.26806, -39.66278);
case 650: return new CityInfo("Ubá", "15", -21.12, -42.94278);
case 651: return new CityInfo("Turmalina", "15", -17.28556, -42.73);
case 652: return new CityInfo("Tupi Paulista", "27", -21.38111, -51.57056);
case 653: return new CityInfo("Tupanciretã", "23", -29.08056, -53.83583);
case 654: return new CityInfo("Tupaciguara", "15", -18.59222, -48.705);
case 655: return new CityInfo("Tupã", "27", -21.93472, -50.51361);
case 656: return new CityInfo("Tucano", "05", -10.95817, -38.79084);
case 657: return new CityInfo("Tubarão", "26", -28.46667, -49.00694);
case 658: return new CityInfo("Triunfo", "23", -29.94333, -51.71806);
case 659: return new CityInfo("Trindade", "29", -16.64944, -49.48889);
case 660: return new CityInfo("Três Rios", "21", -22.11667, -43.20917);
case 661: return new CityInfo("Três Pontas", "15", -21.36667, -45.5125);
case 662: return new CityInfo("Três Passos", "23", -27.45556, -53.93194);
case 663: return new CityInfo("Três Lagoas", "11", -20.78765, -51.70338);
case 664: return new CityInfo("Três de Maio", "23", -27.77333, -54.24);
case 665: return new CityInfo("Três Coroas", "23", -29.51694, -50.77778);
case 666: return new CityInfo("Três Corações", "15", -21.69694, -45.25333);
case 667: return new CityInfo("Três Barras", "26", -26.10639, -50.32222);
case 668: return new CityInfo("Tremembé", "27", -22.95833, -45.54944);
case 669: return new CityInfo("Tremedal", "05", -14.97583, -41.41083);
case 670: return new CityInfo("Tramandaí", "23", -29.98472, -50.13361);
case 671: return new CityInfo("Torres", "23", -29.33528, -49.72694);
case 672: return new CityInfo("Tomar do Geru", "28", -11.37333, -37.84056);
case 673: return new CityInfo("Toledo", "18", -24.71361, -53.74306);
case 674: return new CityInfo("Tocantins", "15", -21.175, -43.01778);
case 675: return new CityInfo("Tobias Barreto", "28", -11.18389, -37.99833);
case 676: return new CityInfo("Tiradentes", "15", -21.11028, -44.17806);
case 677: return new CityInfo("Timóteo", "15", -19.58106, -42.64953);
case 678: return new CityInfo("Timbó", "26", -26.82333, -49.27167);
case 679: return new CityInfo("Tijucas", "26", -27.24139, -48.63361);
case 680: return new CityInfo("Tietê", "27", -23.10194, -47.71472);
case 681: return new CityInfo("Tibagi", "18", -24.50944, -50.41361);
case 682: return new CityInfo("Teutônia", "23", -29.44806, -51.80639);
case 683: return new CityInfo("Terra Roxa", "18", -23.85571, -50.0314);
case 684: return new CityInfo("Terra Rica", "18", -22.70944, -52.61694);
case 685: return new CityInfo("Terra Nova", "05", -12.36667, -40.66667);
case 686: return new CityInfo("Terra Boa", "18", -23.76806, -52.44417);
case 687: return new CityInfo("Teresópolis", "21", -22.4167, -42.97822);
case 688: return new CityInfo("Terenos", "11", -20.44222, -54.86028);
case 689: return new CityInfo("Teófilo Otoni", "15", -17.8575, -41.50528);
case 690: return new CityInfo("Teodoro Sampaio", "27", -22.5325, -52.1675);
case 691: return new CityInfo("Telêmaco Borba", "18", -24.32389, -50.61556);
case 692: return new CityInfo("Taubaté", "27", -23.02639, -45.55528);
case 693: return new CityInfo("Tatuí", "27", -23.35556, -47.85694);
case 694: return new CityInfo("Tarumã", "27", -22.74667, -50.57722);
case 695: return new CityInfo("Taquarituba", "27", -23.53306, -49.24444);
case 696: return new CityInfo("Taquaritinga", "27", -21.40611, -48.50472);
case 697: return new CityInfo("Taquari", "23", -29.79972, -51.86444);
case 698: return new CityInfo("Taquara", "23", -29.65056, -50.78056);
case 699: return new CityInfo("Tapiramutá", "05", -11.84722, -40.79139);
case 700: return new CityInfo("Tapes", "23", -30.67333, -51.39583);
case 701: return new CityInfo("Taperoá", "05", -13.53806, -39.09861);
case 702: return new CityInfo("Tapejara", "23", -28.06806, -52.01389);
case 703: return new CityInfo("Tapejara", "18", -23.73306, -52.87333);
case 704: return new CityInfo("Tanhaçu", "05", -14.02139, -41.24806);
case 705: return new CityInfo("Tanguá", "21", -22.73028, -42.71417);
case 706: return new CityInfo("Tanabi", "27", -20.62639, -49.64917);
case 707: return new CityInfo("Tambaú", "27", -21.705, -47.27444);
case 708: return new CityInfo("Taiobeiras", "15", -15.80778, -42.23306);
case 709: return new CityInfo("Taguatinga", "31", -12.40389, -46.43611);
case 710: return new CityInfo("Taboão da Serra", "27", -23.62611, -46.79167);
case 711: return new CityInfo("Tabatinga", "27", -21.71667, -48.6875);
case 712: return new CityInfo("Suzano", "27", -23.5425, -46.31083);
case 713: return new CityInfo("Sumaré", "27", -22.82194, -47.26694);
case 714: return new CityInfo("Sorocaba", "27", -23.50167, -47.45806);
case 715: return new CityInfo("Sombrio", "26", -29.11389, -49.61667);
case 716: return new CityInfo("Soledade", "23", -28.81833, -52.51028);
case 717: return new CityInfo("Socorro", "27", -22.59139, -46.52889);
case 718: return new CityInfo("Sobradinho", "05", -12.83333, -39.1);
case 719: return new CityInfo("Siqueira Campos", "18", -23.68889, -49.83389);
case 720: return new CityInfo("Simão Dias", "28", -10.73833, -37.81111);
case 721: return new CityInfo("Silvânia", "29", -16.65889, -48.60806);
case 722: return new CityInfo("Silva Jardim", "21", -22.65083, -42.39167);
case 723: return new CityInfo("Sidrolândia", "11", -20.93194, -54.96139);
case 724: return new CityInfo("Siderópolis", "26", -28.59778, -49.42444);
case 725: return new CityInfo("Severínia", "27", -20.80944, -48.80278);
case 726: return new CityInfo("Sete Lagoas", "15", -19.46583, -44.24667);
case 727: return new CityInfo("Sertãozinho", "27", -21.13778, -47.99028);
case 728: return new CityInfo("Sertanópolis", "18", -23.05861, -51.03639);
case 729: return new CityInfo("Serro", "15", -18.60472, -43.37944);
case 730: return new CityInfo("Serrinha", "05", -11.66417, -39.0075);
case 731: return new CityInfo("Serra Negra", "27", -22.61222, -46.70056);
case 732: return new CityInfo("Serrana", "27", -21.21139, -47.59556);
case 733: return new CityInfo("Serra", "08", -20.12861, -40.30778);
case 734: return new CityInfo("Seropédica", "21", -22.74389, -43.7075);
case 735: return new CityInfo("Senhor do Bonfim", "05", -10.46139, -40.18944);
case 736: return new CityInfo("Sengés", "18", -24.11335, -49.46315);
case 737: return new CityInfo("Senador Canedo", "29", -16.70806, -49.09306);
case 738: return new CityInfo("Seabra", "05", -12.41713, -41.77049);
case 739: return new CityInfo("Schroeder", "26", -26.4125, -49.07306);
case 740: return new CityInfo("Saubara", "05", -12.7375, -38.76861);
case 741: return new CityInfo("Sarzedo", "15", -20.03528, -44.14472);
case 742: return new CityInfo("Sarandi", "23", -27.94389, -52.92306);
case 743: return new CityInfo("Sarandi", "18", -23.44361, -51.87389);
case 744: return new CityInfo("Saquarema", "21", -22.92, -42.51028);
case 745: return new CityInfo("Sapucaia", "23", -29.83333, -51.15);
case 746: return new CityInfo("Sapucaia", "21", -21.995, -42.91444);
case 747: return new CityInfo("Sapiranga", "23", -29.63806, -51.00694);
case 748: return new CityInfo("São Vicente", "27", -23.96306, -46.39194);
case 749: return new CityInfo("São Simão", "27", -21.47917, -47.55083);
case 750: return new CityInfo("São Sepé", "23", -30.16056, -53.56528);
case 751: return new CityInfo("São Sebastião do Passé", "05", -12.5125, -38.49528);
case 752: return new CityInfo("São Sebastião do Paraíso", "15", -20.91694, -46.99139);
case 753: return new CityInfo("São Sebastião do Caí", "23", -29.58667, -51.37556);
case 754: return new CityInfo("São Sebastião", "27", -23.76, -45.40972);
case 755: return new CityInfo("São Roque", "27", -23.52917, -47.13528);
case 756: return new CityInfo("São Pedro do Sul", "23", -29.62056, -54.17889);
case 757: return new CityInfo("São Pedro da Aldeia", "21", -22.83917, -42.10278);
case 758: return new CityInfo("São Pedro", "27", -22.54861, -47.91389);
case 759: return new CityInfo("São Paulo", "27", -23.5475, -46.63611);
case 760: return new CityInfo("São Miguel do Iguaçu", "18", -25.34806, -54.23778);
case 761: return new CityInfo("São Miguel do Araguaia", "29", -13.275, -50.16278);
case 762: return new CityInfo("São Mateus do Sul", "18", -25.87417, -50.38278);
case 763: return new CityInfo("São Mateus", "08", -18.72011, -39.85891);
case 764: return new CityInfo("São Marcos", "23", -28.97111, -51.06806);
case 765: return new CityInfo("São Manuel", "27", -22.73111, -48.57056);
case 766: return new CityInfo("São Luiz Gonzaga", "23", -28.40833, -54.96083);
case 767: return new CityInfo("São Luís de Montes Belos", "29", -16.525, -50.37222);
case 768: return new CityInfo("São Lourenço do Sul", "23", -31.36528, -51.97833);
case 769: return new CityInfo("São Lourenço do Oeste", "26", -26.35917, -52.85111);
case 770: return new CityInfo("São Lourenço da Serra", "27", -23.8525, -46.9425);
case 771: return new CityInfo("São Lourenço", "15", -22.11639, -45.05444);
case 772: return new CityInfo("São Leopoldo", "23", -29.76028, -51.14722);
case 773: return new CityInfo("São José dos Pinhais", "18", -25.5302, -49.20836);
case 774: return new CityInfo("São José dos Campos", "27", -23.17944, -45.88694);
case 775: return new CityInfo("São José do Rio Preto", "27", -20.81972, -49.37944);
case 776: return new CityInfo("São José do Rio Pardo", "27", -21.59556, -46.88861);
case 777: return new CityInfo("São José do Calçado", "08", -21.02528, -41.65444);
case 778: return new CityInfo("São José", "26", -28.21171, -49.1632);
case 779: return new CityInfo("São Joaquim de Bicas", "15", -20.04917, -44.27389);
case 780: return new CityInfo("São Joaquim da Barra", "27", -20.58139, -47.85472);
case 781: return new CityInfo("São Joaquim", "26", -28.29389, -49.93167);
case 782: return new CityInfo("São João Nepomuceno", "15", -21.54, -43.01056);
case 783: return new CityInfo("São João Evangelista", "15", -18.54778, -42.76333);
case 784: return new CityInfo("São João do Paraíso", "15", -15.31361, -42.01444);
case 785: return new CityInfo("São João de Meriti", "21", -22.80389, -43.37222);
case 786: return new CityInfo("São João del Rei", "15", -21.13556, -44.26167);
case 787: return new CityInfo("São João da Ponte", "15", -15.92917, -44.00778);
case 788: return new CityInfo("São João da Boa Vista", "27", -21.96917, -46.79806);
case 789: return new CityInfo("São João da Barra", "21", -21.64028, -41.05111);
case 790: return new CityInfo("São João Batista", "26", -27.27611, -48.84944);
case 791: return new CityInfo("São Jerônimo", "23", -29.95917, -51.72222);
case 792: return new CityInfo("São Gotardo", "15", -19.31111, -46.04889);
case 793: return new CityInfo("São Gonçalo dos Campos", "05", -12.43333, -38.96667);
case 794: return new CityInfo("São Gonçalo do Sapucaí", "15", -21.89222, -45.59528);
case 795: return new CityInfo("São Gonçalo", "21", -22.82694, -43.05389);
case 796: return new CityInfo("São Gabriel", "23", -30.33639, -54.32);
case 797: return new CityInfo("São Francisco do Sul", "26", -26.24333, -48.63806);
case 798: return new CityInfo("São Francisco do Conde", "05", -12.6275, -38.68);
case 799: return new CityInfo("São Francisco de Paula", "23", -29.44806, -50.58361);
case 800: return new CityInfo("São Francisco de Assis", "23", -29.55028, -55.13111);
case 801: return new CityInfo("São Francisco", "15", -15.94861, -44.86444);
case 802: return new CityInfo("São Fidélis", "21", -21.64611, -41.74694);
case 803: return new CityInfo("São Felipe", "05", -14.8386, -41.39174);
case 804: return new CityInfo("São Domingos do Prata", "15", -19.865, -42.96833);
case 805: return new CityInfo("São Domingos", "29", -13.39833, -46.31833);
case 806: return new CityInfo("São Desidério", "05", -12.36333, -44.97333);
case 807: return new CityInfo("São Cristóvão", "28", -11.01472, -37.20639);
case 808: return new CityInfo("São Carlos", "27", -22.0175, -47.89083);
case 809: return new CityInfo("São Caetano do Sul", "27", -23.62306, -46.55111);
case 810: return new CityInfo("São Borja", "23", -28.66056, -56.00444);
case 811: return new CityInfo("São Bernardo do Campo", "27", -23.69389, -46.565);
case 812: return new CityInfo("São Bento do Sul", "26", -26.25028, -49.37861);
case 813: return new CityInfo("Santos Dumont", "15", -21.45667, -43.5525);
case 814: return new CityInfo("Santos", "27", -23.96083, -46.33361);
case 815: return new CityInfo("Santo Estêvão", "05", -12.43028, -39.25139);
case 816: return new CityInfo("Santo Augusto", "23", -27.85083, -53.77722);
case 817: return new CityInfo("Santo Antônio do Sudoeste", "18", -26.07361, -53.72528);
case 818: return new CityInfo("Santo Antônio do Monte", "15", -20.08722, -45.29361);
case 819: return new CityInfo("Santo Antônio do Leverger", "14", -15.86556, -56.07667);
case 820: return new CityInfo("Santo Antônio do Amparo", "15", -20.94639, -44.91889);
case 821: return new CityInfo("Santo Antônio de Posse", "27", -22.60611, -46.91944);
case 822: return new CityInfo("Santo Antônio de Pádua", "21", -21.53944, -42.18028);
case 823: return new CityInfo("Santo Antônio de Jesus", "05", -12.96889, -39.26139);
case 824: return new CityInfo("Santo Antônio da Platina", "18", -23.295, -50.07722);
case 825: return new CityInfo("Santo Ângelo", "23", -28.29917, -54.26306);
case 826: return new CityInfo("Santo André", "27", -23.66389, -46.53833);
case 827: return new CityInfo("Santo Anastácio", "27", -21.83833, -51.61028);
case 828: return new CityInfo("Santo Amaro das Brotas", "28", -10.78889, -37.05444);
case 829: return new CityInfo("Santo Amaro da Imperatriz", "26", -27.68806, -48.77861);
case 830: return new CityInfo("Santo Amaro", "05", -12.54667, -38.71194);
case 831: return new CityInfo("Santiago", "23", -29.19167, -54.86722);
case 832: return new CityInfo("Santa Vitória do Palmar", "23", -33.51889, -53.36806);
case 833: return new CityInfo("Santa Vitória", "15", -18.83861, -50.12139);
case 834: return new CityInfo("Santa Terezinha", "14", -10.47059, -50.51359);
case 835: return new CityInfo("Santa Teresa", "08", -19.93556, -40.60028);
case 836: return new CityInfo("Santa Rosa de Viterbo", "27", -21.47278, -47.36306);
case 837: return new CityInfo("Santa Rosa", "23", -27.87083, -54.48139);
case 838: return new CityInfo("Santa Rita do Sapucaí", "15", -22.25222, -45.70333);
case 839: return new CityInfo("Santa Rita do Passa Quatro", "27", -21.71028, -47.47806);
case 840: return new CityInfo("Santana do Paraíso", "15", -19.36361, -42.56861);
case 841: return new CityInfo("Santana do Livramento", "23", -30.89083, -55.53278);
case 842: return new CityInfo("Santana de Parnaíba", "27", -23.44417, -46.91778);
case 843: return new CityInfo("Santana", "05", -14.46667, -41.8);
case 844: return new CityInfo("Santa Maria do Suaçuí", "15", -18.19028, -42.41417);
case 845: return new CityInfo("Santa Maria da Vitória", "05", -13.38814, -44.19868);
case 846: return new CityInfo("Santa Maria", "23", -29.68417, -53.80694);
case 847: return new CityInfo("Santa Luzia", "15", -19.76972, -43.85139);
case 848: return new CityInfo("Santaluz", "05", -11.25583, -39.37472);
case 849: return new CityInfo("Santa Leopoldina", "08", -20.10056, -40.52972);
case 850: return new CityInfo("Santa Isabel", "27", -23.31556, -46.22139);
case 851: return new CityInfo("Santa Inês", "05", -13.29222, -39.81889);
case 852: return new CityInfo("Santa Helena de Goiás", "29", -17.81361, -50.59694);
case 853: return new CityInfo("Santa Gertrudes", "27", -22.45667, -47.53028);
case 854: return new CityInfo("Santa Fé do Sul", "27", -20.21111, -50.92583);
case 855: return new CityInfo("Santa Cruz do Sul", "23", -29.7175, -52.42583);
case 856: return new CityInfo("Santa Cruz do Rio Pardo", "27", -22.89889, -49.6325);
case 857: return new CityInfo("Santa Cruz das Palmeiras", "27", -21.82694, -47.24861);
case 858: return new CityInfo("Santa Cruz Cabrália", "05", -16.27806, -39.02472);
case 859: return new CityInfo("Santa Cecília", "26", -26.96083, -50.42694);
case 860: return new CityInfo("Santa Branca", "27", -23.39667, -45.88389);
case 861: return new CityInfo("Santa Bárbara d'Oeste", "27", -22.75361, -47.41361);
case 862: return new CityInfo("Santa Adélia", "27", -21.24278, -48.80417);
case 863: return new CityInfo("Sananduva", "23", -27.94972, -51.80667);
case 864: return new CityInfo("Salvador", "05", -12.97111, -38.51083);
case 865: return new CityInfo("Salto de Pirapora", "27", -23.64889, -47.57333);
case 866: return new CityInfo("Salto", "27", -23.20083, -47.28694);
case 867: return new CityInfo("Salinas", "15", -16.17028, -42.29028);
case 868: return new CityInfo("Salgado", "28", -11.03194, -37.475);
case 869: return new CityInfo("Sacramento", "15", -19.86528, -47.44);
case 870: return new CityInfo("Sabinópolis", "15", -18.66611, -43.08389);
case 871: return new CityInfo("Ruy Barbosa", "05", -12.28389, -40.49389);
case 872: return new CityInfo("Rubiataba", "29", -15.16444, -49.80333);
case 873: return new CityInfo("Rosário Oeste", "14", -14.83611, -56.4275);
case 874: return new CityInfo("Rosário do Sul", "23", -30.25833, -54.91417);
case 875: return new CityInfo("Rondonópolis", "14", -16.47083, -54.63556);
case 876: return new CityInfo("Rolante", "23", -29.65056, -50.57583);
case 877: return new CityInfo("Rolândia", "18", -23.30972, -51.36917);
case 878: return new CityInfo("Rodeio", "26", -26.92278, -49.36639);
case 879: return new CityInfo("Rio Verde de Mato Grosso", "11", -18.91806, -54.84417);
case 880: return new CityInfo("Rio Verde", "29", -17.79806, -50.92806);
case 881: return new CityInfo("Rio Tavares", "26", -27.64529, -48.47486);
case 882: return new CityInfo("Rio Real", "05", -11.48472, -37.93278);
case 883: return new CityInfo("Rio Pomba", "15", -21.27472, -43.17917);
case 884: return new CityInfo("Rio Piracicaba", "15", -19.92917, -43.17417);
case 885: return new CityInfo("Rio Pardo de Minas", "15", -15.60972, -42.53972);
case 886: return new CityInfo("Rio Pardo", "23", -29.98972, -52.37806);
case 887: return new CityInfo("Rio Novo do Sul", "08", -20.8625, -40.93639);
case 888: return new CityInfo("Rio Novo", "15", -21.47703, -43.12589);
case 889: return new CityInfo("Rio Negro", "18", -26.10583, -49.7975);
case 890: return new CityInfo("Rio Negrinho", "26", -26.25444, -49.51833);
case 891: return new CityInfo("Riolândia", "27", -19.98083, -49.68194);
case 892: return new CityInfo("Rio Grande da Serra", "27", -23.74417, -46.39833);
case 893: return new CityInfo("Rio Grande", "23", -32.035, -52.09861);
case 894: return new CityInfo("Rio do Sul", "26", -27.21417, -49.64306);
case 895: return new CityInfo("Rio de Janeiro", "21", -22.90642, -43.18223);
case 896: return new CityInfo("Rio das Pedras", "27", -22.84333, -47.60611);
case 897: return new CityInfo("Rio das Ostras", "21", -22.52694, -41.945);
case 898: return new CityInfo("Rio Claro", "21", -22.72306, -44.13556);
case 899: return new CityInfo("Rio Claro", "27", -22.41139, -47.56139);
case 900: return new CityInfo("Rio Casca", "15", -20.22611, -42.65083);
case 901: return new CityInfo("Rio Brilhante", "11", -21.80194, -54.54639);
case 902: return new CityInfo("Rio Branco do Sul", "18", -25.19, -49.31417);
case 903: return new CityInfo("Rio Bonito", "21", -22.70861, -42.60972);
case 904: return new CityInfo("Rio Bananal", "08", -19.265, -40.33333);
case 905: return new CityInfo("Ribeirópolis", "28", -10.53944, -37.41667);
case 906: return new CityInfo("Ribeirão Preto", "27", -21.1775, -47.81028);
case 907: return new CityInfo("Ribeirão Pires", "27", -23.71056, -46.41333);
case 908: return new CityInfo("Ribeirão das Neves", "15", -19.76694, -44.08667);
case 909: return new CityInfo("Ribeirão da Ilha", "26", -27.69934, -48.53219);
case 910: return new CityInfo("Ribeirão Branco", "27", -24.22083, -48.76556);
case 911: return new CityInfo("Ribeirão Bonito", "27", -22.06667, -48.17611);
case 912: return new CityInfo("Ribeira do Pombal", "05", -10.83444, -38.53583);
case 913: return new CityInfo("Ribas do Rio Pardo", "11", -20.44306, -53.75917);
case 914: return new CityInfo("Rialma", "29", -15.315, -49.58444);
case 915: return new CityInfo("Riacho de Santana", "05", -13.60917, -42.93889);
case 916: return new CityInfo("Riachão do Jacuípe", "05", -11.80694, -39.38556);
case 917: return new CityInfo("Riachão do Dantas", "28", -11.06889, -37.725);
case 918: return new CityInfo("Riachão das Neves", "05", -11.74611, -44.91);
case 919: return new CityInfo("Resplendor", "15", -19.32556, -41.25528);
case 920: return new CityInfo("Reserva", "18", -24.65028, -50.85056);
case 921: return new CityInfo("Resende", "21", -22.46889, -44.44667);
case 922: return new CityInfo("Registro", "27", -24.4875, -47.84361);
case 923: return new CityInfo("Regente Feijó", "27", -22.22139, -51.30278);
case 924: return new CityInfo("Recreio", "15", -21.525, -42.46917);
case 925: return new CityInfo("Realeza", "18", -25.76889, -53.5325);
case 926: return new CityInfo("Raposos", "15", -19.96722, -43.80417);
case 927: return new CityInfo("Rancharia", "27", -22.22917, -50.89306);
case 928: return new CityInfo("Quirinópolis", "29", -18.44833, -50.45167);
case 929: return new CityInfo("Quijingue", "05", -10.7525, -39.20917);
case 930: return new CityInfo("Queimados", "21", -22.71611, -43.55528);
case 931: return new CityInfo("Queimadas", "05", -10.97833, -39.62639);
case 932: return new CityInfo("Quatro Barras", "18", -25.36556, -49.07694);
case 933: return new CityInfo("Quatis", "21", -22.40722, -44.25806);
case 934: return new CityInfo("Quatá", "27", -22.2475, -50.69833);
case 935: return new CityInfo("Quaraí", "23", -30.3875, -56.45139);
case 936: return new CityInfo("Prudentópolis", "18", -25.21306, -50.97778);
case 937: return new CityInfo("Propriá", "28", -10.21111, -36.84028);
case 938: return new CityInfo("Promissão", "27", -21.53667, -49.85806);
case 939: return new CityInfo("Presidente Venceslau", "27", -21.87611, -51.84389);
case 940: return new CityInfo("Presidente Prudente", "27", -22.12556, -51.38889);
case 941: return new CityInfo("Presidente Olegário", "15", -18.41778, -46.41806);
case 942: return new CityInfo("Presidente Epitácio", "27", -21.76333, -52.11556);
case 943: return new CityInfo("Presidente Bernardes", "27", -22.00611, -51.55306);
case 944: return new CityInfo("Prata", "15", -19.30722, -48.92417);
case 945: return new CityInfo("Praia Grande", "27", -24.00583, -46.40278);
case 946: return new CityInfo("Pradópolis", "27", -21.35944, -48.06556);
case 947: return new CityInfo("Prado", "05", -17.34111, -39.22083);
case 948: return new CityInfo("Poxoréo", "14", -15.83722, -54.38917);
case 949: return new CityInfo("Pouso Alegre", "15", -22.23, -45.93639);
case 950: return new CityInfo("Posse", "29", -14.09306, -46.36944);
case 951: return new CityInfo("Porto União", "26", -26.23806, -51.07833);
case 952: return new CityInfo("Porto Seguro", "05", -16.44972, -39.06472);
case 953: return new CityInfo("Porto Real do Colégio", "02", -10.18583, -36.84);
case 954: return new CityInfo("Porto Real", "21", -22.41972, -44.29028);
case 955: return new CityInfo("Porto Murtinho", "11", -21.69889, -57.8825);
case 956: return new CityInfo("Porto Ferreira", "27", -21.85389, -47.47917);
case 957: return new CityInfo("Porto Feliz", "27", -23.21472, -47.52389);
case 958: return new CityInfo("Porto Belo", "26", -27.15778, -48.55306);
case 959: return new CityInfo("Pôrto Barra do Ivinheima", "11", -22.96667, -53.66667);
case 960: return new CityInfo("Porto Alegre", "23", -30.03283, -51.23019);
case 961: return new CityInfo("Porteirinha", "15", -15.74333, -43.02833);
case 962: return new CityInfo("Portão", "23", -29.70167, -51.24194);
case 963: return new CityInfo("Porecatu", "18", -22.75583, -51.37917);
case 964: return new CityInfo("Porciúncula", "21", -20.96278, -42.04083);
case 965: return new CityInfo("Porangatu", "29", -13.44083, -49.14861);
case 966: return new CityInfo("Porangaba", "27", -23.17583, -48.125);
case 967: return new CityInfo("Ponto Novo", "05", -10.86278, -40.13361);
case 968: return new CityInfo("Pontes e Lacerda", "14", -15.22611, -59.33528);
case 969: return new CityInfo("Ponte Nova", "15", -20.41639, -42.90861);
case 970: return new CityInfo("Ponta Porã", "11", -22.53611, -55.72556);
case 971: return new CityInfo("Pontalina", "29", -17.525, -49.44722);
case 972: return new CityInfo("Pontal", "27", -21.0225, -48.03722);
case 973: return new CityInfo("Ponta Grossa", "18", -25.095, -50.16194);
case 974: return new CityInfo("Pompéu", "15", -19.22444, -44.93528);
case 975: return new CityInfo("Pompéia", "27", -22.10861, -50.17167);
case 976: return new CityInfo("Pomerode", "26", -26.74056, -49.17694);
case 977: return new CityInfo("Poço Verde", "28", -10.70833, -38.18333);
case 978: return new CityInfo("Poços de Caldas", "15", -21.78778, -46.56139);
case 979: return new CityInfo("Poconé", "14", -16.25667, -56.62278);
case 980: return new CityInfo("Poções", "05", -14.52972, -40.36528);
case 981: return new CityInfo("Poá", "27", -23.52806, -46.34472);
case 982: return new CityInfo("Planaltina", "29", -15.45278, -47.61417);
case 983: return new CityInfo("Piúma", "08", -20.83778, -40.72194);
case 984: return new CityInfo("Piuí", "15", -20.46528, -45.95806);
case 985: return new CityInfo("Pitangui", "15", -19.68278, -44.89028);
case 986: return new CityInfo("Pitangueiras", "27", -21.00944, -48.22167);
case 987: return new CityInfo("Pitanga", "18", -24.75722, -51.76139);
case 988: return new CityInfo("Piritiba", "05", -11.73028, -40.55528);
case 989: return new CityInfo("Pires do Rio", "29", -17.29972, -48.27944);
case 990: return new CityInfo("Pirenópolis", "29", -15.85072, -48.96087);
case 991: return new CityInfo("Piraquara", "18", -25.44227, -49.06795);
case 992: return new CityInfo("Pirapozinho", "27", -22.27528, -51.5);
case 993: return new CityInfo("Pirapora do Bom Jesus", "27", -23.39694, -47.00222);
case 994: return new CityInfo("Pirapora", "15", -17.345, -44.94194);
case 995: return new CityInfo("Piranhas", "29", -16.42694, -51.82222);
case 996: return new CityInfo("Pirajuí", "27", -21.99861, -49.45722);
case 997: return new CityInfo("Piraju", "27", -23.19361, -49.38389);
case 998: return new CityInfo("Piraí do Sul", "18", -24.52611, -49.94861);
case 999: return new CityInfo("Piraí", "21", -22.62917, -43.89806);
case 1000: return new CityInfo("Pirassununga", "27", -21.99611, -47.42583);
case 1001: return new CityInfo("Piracicaba", "27", -22.72528, -47.64917);
case 1002: return new CityInfo("Piracanjuba", "29", -17.30278, -49.01667);
case 1003: return new CityInfo("Piracaia", "27", -23.05389, -46.35806);
case 1004: return new CityInfo("Piquete", "27", -22.61361, -45.17611);
case 1005: return new CityInfo("Pinheiros", "23", -29.78333, -52.73333);
case 1006: return new CityInfo("Pinheiro Machado", "23", -31.57833, -53.38111);
case 1007: return new CityInfo("Pinheiral", "21", -22.51278, -44.00056);
case 1008: return new CityInfo("Pinhão", "18", -25.69556, -51.65972);
case 1009: return new CityInfo("Espírito Santo do Pinhal", "27", -22.11583, -46.68278);
case 1010: return new CityInfo("Pindorama", "27", -21.18583, -48.90722);
case 1011: return new CityInfo("Pindobaçu", "05", -10.74167, -40.36083);
case 1012: return new CityInfo("Pindamonhangaba", "27", -22.92389, -45.46167);
case 1013: return new CityInfo("Pilar do Sul", "27", -23.81306, -47.71639);
case 1014: return new CityInfo("Piedade", "27", -23.71194, -47.42778);
case 1015: return new CityInfo("Piaçabuçu", "02", -10.40556, -36.43444);
case 1016: return new CityInfo("Petrópolis", "21", -22.505, -43.17861);
case 1017: return new CityInfo("Petrolina de Goiás", "29", -16.095, -49.33806);
case 1018: return new CityInfo("Peruíbe", "27", -24.32, -46.99833);
case 1019: return new CityInfo("Pereira Barreto", "27", -20.63833, -51.10917);
case 1020: return new CityInfo("Perdões", "15", -21.09083, -45.09139);
case 1021: return new CityInfo("Penha", "26", -26.76944, -48.64583);
case 1022: return new CityInfo("Penedo", "02", -10.29028, -36.58639);
case 1023: return new CityInfo("Penápolis", "27", -21.41972, -50.0775);
case 1024: return new CityInfo("Pelotas", "23", -31.76997, -52.34101);
case 1025: return new CityInfo("Pedro Leopoldo", "15", -19.61806, -44.04306);
case 1026: return new CityInfo("Pedreira", "27", -22.74194, -46.90139);
case 1027: return new CityInfo("Pedregulho", "27", -20.25694, -47.47667);
case 1028: return new CityInfo("Pedra Azul", "15", -16.00528, -41.29722);
case 1029: return new CityInfo("Pederneiras", "27", -22.35167, -48.775);
case 1030: return new CityInfo("Peçanha", "15", -18.54861, -42.55694);
case 1031: return new CityInfo("Peabiru", "18", -23.91278, -52.34306);
case 1032: return new CityInfo("Paulínia", "27", -22.76111, -47.15417);
case 1033: return new CityInfo("Pau Brasil", "05", -15.46417, -39.65111);
case 1034: return new CityInfo("Patrocínio", "15", -18.94389, -46.9925);
case 1035: return new CityInfo("Patos de Minas", "15", -18.57889, -46.51806);
case 1036: return new CityInfo("Pato Branco", "18", -26.22861, -52.67056);
case 1037: return new CityInfo("Paty do Alferes", "21", -22.42861, -43.41861);
case 1038: return new CityInfo("Posto da Mata", "05", -17.88828, -39.85593);
case 1039: return new CityInfo("Passos", "15", -20.71889, -46.60972);
case 1040: return new CityInfo("Passo Fundo", "23", -28.26278, -52.40667);
case 1041: return new CityInfo("Passa Quatro", "15", -22.39028, -44.96667);
case 1042: return new CityInfo("Parobé", "23", -29.62861, -50.83472);
case 1043: return new CityInfo("Pariquera Açu", "27", -24.715, -47.88111);
case 1044: return new CityInfo("Paripiranga", "05", -10.6875, -37.86167);
case 1045: return new CityInfo("Paraúna", "29", -16.94778, -50.44861);
case 1046: return new CityInfo("Paratinga", "05", -12.69056, -43.18417);
case 1047: return new CityInfo("Paraty", "21", -23.21778, -44.71306);
case 1048: return new CityInfo("Paranhos", "11", -23.89278, -55.43111);
case 1049: return new CityInfo("Paranavaí", "18", -23.07306, -52.46528);
case 1050: return new CityInfo("Paranapanema", "27", -23.3863, -48.72441);
case 1051: return new CityInfo("Paranaíba", "11", -19.67722, -51.19083);
case 1052: return new CityInfo("Paranaguá", "18", -25.51626, -48.52537);
case 1053: return new CityInfo("Paramirim", "05", -13.4425, -42.23889);
case 1054: return new CityInfo("Paraisópolis", "15", -22.55417, -45.78);
case 1055: return new CityInfo("Paraíso", "27", -21.01639, -48.77361);
case 1056: return new CityInfo("Paraíso das Águas", "11", -19.0175, -53.01222);
case 1057: return new CityInfo("Paraíba do Sul", "21", -22.15847, -43.29321);
case 1058: return new CityInfo("Paraguaçu Paulista", "27", -22.41278, -50.57583);
case 1059: return new CityInfo("Paraguaçu", "15", -21.54722, -45.7375);
case 1060: return new CityInfo("Pará de Minas", "15", -19.86028, -44.60833);
case 1061: return new CityInfo("Paracatu", "15", -17.22222, -46.87472);
case 1062: return new CityInfo("Paracambi", "21", -22.60829, -43.7084);
case 1063: return new CityInfo("Papagaios", "15", -19.44917, -44.74778);
case 1064: return new CityInfo("Pantano do Sul", "26", -27.77972, -48.50861);
case 1065: return new CityInfo("Panorama", "27", -21.35639, -51.85972);
case 1066: return new CityInfo("Pancas", "08", -19.225, -40.85139);
case 1067: return new CityInfo("Panambi", "23", -28.2925, -53.50167);
case 1068: return new CityInfo("Palotina", "18", -24.28389, -53.84);
case 1069: return new CityInfo("Palmital", "27", -22.78889, -50.2175);
case 1070: return new CityInfo("Palmeiras de Goiás", "29", -16.805, -49.92583);
case 1071: return new CityInfo("Palmeira das Missões", "23", -27.89944, -53.31361);
case 1072: return new CityInfo("Palmeira", "18", -25.42944, -50.00639);
case 1073: return new CityInfo("Palmas de Monte Alto", "05", -14.26722, -43.16194);
case 1074: return new CityInfo("Palmas", "18", -26.48417, -51.99056);
case 1075: return new CityInfo("Palmares do Sul", "23", -30.25778, -50.50972);
case 1076: return new CityInfo("Palhoça", "26", -27.64528, -48.66778);
case 1077: return new CityInfo("Paiçandu", "18", -23.4575, -52.04861);
case 1078: return new CityInfo("Padre Paraíso", "15", -17.07417, -41.48444);
case 1079: return new CityInfo("Padre Bernardo", "29", -15.16595, -48.28281);
case 1080: return new CityInfo("Pacatuba", "28", -10.45333, -36.65139);
case 1081: return new CityInfo("Pacaembu", "27", -21.56222, -51.26056);
case 1082: return new CityInfo("Ouro Preto", "15", -20.39484, -43.50517);
case 1083: return new CityInfo("Ouro Branco", "15", -20.52334, -43.69486);
case 1084: return new CityInfo("Ourinhos", "27", -22.97889, -49.87056);
case 1085: return new CityInfo("Otacílio Costa", "26", -27.48306, -50.12194);
case 1086: return new CityInfo("Osvaldo Cruz", "27", -21.79667, -50.87861);
case 1087: return new CityInfo("Osório", "23", -29.88667, -50.26972);
case 1088: return new CityInfo("Osasco", "27", -23.5325, -46.79167);
case 1089: return new CityInfo("Ortigueira", "18", -24.20833, -50.94944);
case 1090: return new CityInfo("Orleans", "26", -28.35889, -49.29139);
case 1091: return new CityInfo("Orlândia", "27", -20.72028, -47.88667);
case 1092: return new CityInfo("Orizona", "29", -17.03139, -48.29583);
case 1093: return new CityInfo("Oliveira dos Brejinhos", "05", -12.31694, -42.89611);
case 1094: return new CityInfo("Oliveira", "15", -20.69639, -44.82722);
case 1095: return new CityInfo("Olindina", "05", -11.36667, -38.33333);
case 1096: return new CityInfo("Olímpia", "27", -20.73722, -48.91472);
case 1097: return new CityInfo("Nuporanga", "27", -20.73095, -47.75177);
case 1098: return new CityInfo("Novo Horizonte", "27", -21.46806, -49.22083);
case 1099: return new CityInfo("Novo Hamburgo", "23", -29.67833, -51.13056);
case 1100: return new CityInfo("Novo Cruzeiro", "15", -17.46806, -41.87528);
case 1101: return new CityInfo("Nova Viçosa", "05", -17.89194, -39.37194);
case 1102: return new CityInfo("Nova Venécia", "08", -18.71056, -40.40056);
case 1103: return new CityInfo("Nova Soure", "05", -11.23333, -38.48333);
case 1104: return new CityInfo("Nova Prata", "23", -28.78389, -51.61);
case 1105: return new CityInfo("Nova Petrópolis", "23", -29.37639, -51.11444);
case 1106: return new CityInfo("Nova Olímpia", "14", -14.79722, -57.28806);
case 1107: return new CityInfo("Nova Odessa", "27", -22.7775, -47.29583);
case 1108: return new CityInfo("Nova Londrina", "18", -22.76583, -52.985);
case 1109: return new CityInfo("Nova Lima", "15", -19.98556, -43.84667);
case 1110: return new CityInfo("Nova Iguaçu", "21", -22.75917, -43.45111);
case 1111: return new CityInfo("Nova Granada", "27", -20.53389, -49.31417);
case 1112: return new CityInfo("Nova Friburgo", "21", -22.28194, -42.53111);
case 1113: return new CityInfo("Nova Era", "15", -19.75, -43.0375);
case 1114: return new CityInfo("Nova Aurora", "18", -22.86667, -52.56667);
case 1115: return new CityInfo("Nossa Senhora do Socorro", "28", -10.855, -37.12611);
case 1116: return new CityInfo("Nossa Senhora das Dores", "28", -10.49167, -37.19333);
case 1117: return new CityInfo("Nossa Senhora da Glória", "28", -10.21833, -37.42028);
case 1118: return new CityInfo("Nortelândia", "14", -14.45472, -56.80278);
case 1119: return new CityInfo("Nobres", "14", -14.72028, -56.3275);
case 1120: return new CityInfo("Niterói", "21", -22.88333, -43.10361);
case 1121: return new CityInfo("Niquelândia", "29", -14.47389, -48.45972);
case 1122: return new CityInfo("Nilópolis", "21", -22.8075, -43.41389);
case 1123: return new CityInfo("Nhandeara", "27", -20.6897, -50.0407);
case 1124: return new CityInfo("Nerópolis", "29", -16.40639, -49.21861);
case 1125: return new CityInfo("Nepomuceno", "15", -21.23342, -45.23488);
case 1126: return new CityInfo("Neópolis", "28", -10.32, -36.57944);
case 1127: return new CityInfo("Nazaré", "05", -13.035, -39.01444);
case 1128: return new CityInfo("Naviraí", "11", -23.065, -54.19056);
case 1129: return new CityInfo("Navegantes", "26", -26.89889, -48.65417);
case 1130: return new CityInfo("Natividade", "21", -21.04222, -41.97333);
case 1131: return new CityInfo("Não Me Toque", "23", -28.45917, -52.82083);
case 1132: return new CityInfo("Nanuque", "15", -17.83917, -40.35389);
case 1133: return new CityInfo("Muzambinho", "15", -21.37583, -46.52556);
case 1134: return new CityInfo("Mutum", "15", -19.8, -41.43833);
case 1135: return new CityInfo("Mutuípe", "05", -13.22861, -39.50472);
case 1136: return new CityInfo("Muritiba", "05", -12.91667, -39.25);
case 1137: return new CityInfo("Muriaé", "15", -21.13056, -42.36639);
case 1138: return new CityInfo("Muniz Freire", "08", -20.46417, -41.41306);
case 1139: return new CityInfo("Mundo Novo", "05", -11.85889, -40.4725);
case 1140: return new CityInfo("Mucurici", "08", -18.09333, -40.51583);
case 1141: return new CityInfo("Mucuri", "05", -18.08639, -39.55083);
case 1142: return new CityInfo("Mozarlândia", "29", -14.74472, -50.57056);
case 1143: return new CityInfo("Morro do Chapéu", "05", -11.54852, -41.15804);
case 1144: return new CityInfo("Morro da Fumaça", "26", -28.65083, -49.21);
case 1145: return new CityInfo("Morro Agudo", "27", -20.73139, -48.05778);
case 1146: return new CityInfo("Morrinhos", "29", -17.73111, -49.09944);
case 1147: return new CityInfo("Moreira Sales", "18", -24.06222, -53.00694);
case 1148: return new CityInfo("Monte Sião", "15", -22.4325, -46.5725);
case 1149: return new CityInfo("Montes Claros", "15", -16.735, -43.86167);
case 1150: return new CityInfo("Monte Santo de Minas", "15", -21.18972, -46.98028);
case 1151: return new CityInfo("Monte Santo", "05", -10.43778, -39.33278);
case 1152: return new CityInfo("Montenegro", "23", -29.68861, -51.46111);
case 1153: return new CityInfo("Monte Mor", "27", -22.94667, -47.31583);
case 1154: return new CityInfo("Monte Carmelo", "15", -18.72472, -47.49861);
case 1155: return new CityInfo("Monte Azul Paulista", "27", -20.90722, -48.64139);
case 1156: return new CityInfo("Monte Azul", "15", -15.155, -42.87472);
case 1157: return new CityInfo("Monte Aprazível", "27", -20.7725, -49.71417);
case 1158: return new CityInfo("Monte Alto", "27", -21.26111, -48.49639);
case 1159: return new CityInfo("Monte Alegre de Sergipe", "28", -10.02722, -37.56222);
case 1160: return new CityInfo("Monte Alegre de Minas", "15", -18.87056, -48.88083);
case 1161: return new CityInfo("Montanha", "08", -18.12694, -40.36333);
case 1162: return new CityInfo("Mongaguá", "27", -24.09306, -46.62083);
case 1163: return new CityInfo("Moita Bonita", "28", -10.5775, -37.34278);
case 1164: return new CityInfo("Mogi Mirim", "27", -22.43194, -46.95778);
case 1165: return new CityInfo("Mogi Guaçu", "27", -22.3677, -46.94552);
case 1166: return new CityInfo("Mogi das Cruzes", "27", -23.52278, -46.18833);
case 1167: return new CityInfo("Mococa", "27", -21.46778, -47.00472);
case 1168: return new CityInfo("Mirante do Paranapanema", "27", -22.29194, -51.90639);
case 1169: return new CityInfo("Mirandopólis", "27", -21.13361, -51.10167);
case 1170: return new CityInfo("Miranda", "11", -20.24056, -56.37833);
case 1171: return new CityInfo("Miraí", "15", -21.19528, -42.61417);
case 1172: return new CityInfo("Miracema", "21", -21.41222, -42.19667);
case 1173: return new CityInfo("Miracatu", "27", -24.28139, -47.45972);
case 1174: return new CityInfo("Mirabela", "15", -16.26278, -44.16444);
case 1175: return new CityInfo("Mineiros", "29", -17.56944, -52.55111);
case 1176: return new CityInfo("Minas Novas", "15", -17.21861, -42.59028);
case 1177: return new CityInfo("Mimoso do Sul", "08", -21.06417, -41.36639);
case 1178: return new CityInfo("Miguel Pereira", "21", -22.45389, -43.46889);
case 1179: return new CityInfo("Miguelópolis", "27", -20.17944, -48.03194);
case 1180: return new CityInfo("Miguel Calmon", "05", -11.42889, -40.595);
case 1181: return new CityInfo("Mendes", "21", -22.52667, -43.73278);
case 1182: return new CityInfo("Medina", "15", -16.2225, -41.47694);
case 1183: return new CityInfo("Medianeira", "18", -25.29528, -54.09389);
case 1184: return new CityInfo("Medeiros Neto", "05", -17.37389, -40.22056);
case 1185: return new CityInfo("Mauá", "27", -23.66778, -46.46139);
case 1186: return new CityInfo("Matozinhos", "15", -19.55778, -44.08139);
case 1187: return new CityInfo("Mato Verde", "15", -15.39722, -42.86639);
case 1188: return new CityInfo("Matipó", "15", -20.28389, -42.34111);
case 1189: return new CityInfo("Matias Barbosa", "15", -21.86917, -43.31944);
case 1190: return new CityInfo("Mateus Leme", "15", -19.98639, -44.42778);
case 1191: return new CityInfo("Matelândia", "18", -25.24083, -53.99639);
case 1192: return new CityInfo("Matão", "27", -21.60333, -48.36583);
case 1193: return new CityInfo("Mata de São João", "05", -12.53028, -38.29917);
case 1194: return new CityInfo("Mascote", "05", -15.56306, -39.3025);
case 1195: return new CityInfo("Maruim", "28", -10.7375, -37.08167);
case 1196: return new CityInfo("Martinópolis", "27", -22.14583, -51.17083);
case 1197: return new CityInfo("Martinho Campos", "15", -19.33167, -45.23694);
case 1198: return new CityInfo("Maringá", "18", -23.42528, -51.93861);
case 1199: return new CityInfo("Marília", "27", -22.21389, -49.94583);
case 1200: return new CityInfo("Marilândia", "08", -19.41278, -40.54167);
case 1201: return new CityInfo("Maricá", "21", -22.91944, -42.81861);
case 1202: return new CityInfo("Mariana", "15", -20.37778, -43.41611);
case 1203: return new CityInfo("Marialva", "18", -23.485, -51.79167);
case 1204: return new CityInfo("Marechal Floriano", "08", -20.41278, -40.68306);
case 1205: return new CityInfo("Marechal Cândido Rondon", "18", -24.55611, -54.05667);
case 1206: return new CityInfo("Mar de Espanha", "15", -21.86722, -43.00972);
case 1207: return new CityInfo("Marau", "23", -28.44917, -52.2);
case 1208: return new CityInfo("Maraú", "05", -14.10395, -39.0149);
case 1209: return new CityInfo("Marataizes", "08", -21.04333, -40.82444);
case 1210: return new CityInfo("Maragogipe", "05", -12.77778, -38.91944);
case 1211: return new CityInfo("Maracás", "05", -13.44111, -40.43083);
case 1212: return new CityInfo("Maracaju", "11", -21.61444, -55.16833);
case 1213: return new CityInfo("Maracaí", "27", -22.61056, -50.66722);
case 1214: return new CityInfo("Mantenópolis", "08", -18.8625, -41.12278);
case 1215: return new CityInfo("Manhumirim", "15", -20.35778, -41.95806);
case 1216: return new CityInfo("Manhuaçu", "15", -20.25806, -42.03361);
case 1217: return new CityInfo("Mangaratiba", "21", -22.95972, -44.04056);
case 1218: return new CityInfo("Manga", "15", -14.75583, -43.93222);
case 1219: return new CityInfo("Mandaguari", "18", -23.5475, -51.67083);
case 1220: return new CityInfo("Mandaguaçu", "18", -23.34722, -52.09528);
case 1221: return new CityInfo("Malhador", "28", -10.65778, -37.30472);
case 1222: return new CityInfo("Malacacheta", "15", -17.84222, -42.07667);
case 1223: return new CityInfo("Mairiporã", "27", -23.31861, -46.58667);
case 1224: return new CityInfo("Mairinque", "27", -23.54583, -47.18333);
case 1225: return new CityInfo("Mairi", "05", -11.71139, -40.14889);
case 1226: return new CityInfo("Mafra", "26", -26.11139, -49.80528);
case 1227: return new CityInfo("Madre de Deus", "05", -12.74083, -38.62083);
case 1228: return new CityInfo("Machado", "15", -21.67472, -45.91972);
case 1229: return new CityInfo("Macaúbas", "05", -13.01944, -42.69861);
case 1230: return new CityInfo("Macatuba", "27", -22.50222, -48.71139);
case 1231: return new CityInfo("Macaé", "21", -22.38484, -41.78324);
case 1232: return new CityInfo("Luziânia", "29", -16.2525, -47.95028);
case 1233: return new CityInfo("Luz", "15", -19.80139, -45.68556);
case 1234: return new CityInfo("Lucélia", "27", -21.72028, -51.01889);
case 1235: return new CityInfo("Lucas", "14", -16.33333, -55.93333);
case 1236: return new CityInfo("Louveira", "27", -23.08639, -46.95056);
case 1237: return new CityInfo("Lorena", "27", -22.73083, -45.12472);
case 1238: return new CityInfo("Londrina", "18", -23.31028, -51.16278);
case 1239: return new CityInfo("Loanda", "18", -22.92306, -53.13722);
case 1240: return new CityInfo("Livramento do Brumado", "05", -13.65145, -41.84564);
case 1241: return new CityInfo("Lins", "27", -21.67861, -49.7425);
case 1242: return new CityInfo("Linhares", "08", -19.39111, -40.07222);
case 1243: return new CityInfo("Limeira", "27", -22.56472, -47.40167);
case 1244: return new CityInfo("Lima Duarte", "15", -21.8425, -43.79306);
case 1245: return new CityInfo("Leopoldina", "15", -21.53194, -42.64306);
case 1246: return new CityInfo("Lençóis Paulista", "27", -22.59861, -48.80028);
case 1247: return new CityInfo("Leme", "27", -22.18556, -47.39028);
case 1248: return new CityInfo("Lavras", "15", -21.24528, -44.99972);
case 1249: return new CityInfo("Lauro Muller", "26", -28.39278, -49.39667);
case 1250: return new CityInfo("Laranjeiras do Sul", "18", -25.40778, -52.41611);
case 1251: return new CityInfo("Laranjeiras", "28", -10.80639, -37.17);
case 1252: return new CityInfo("Laranjal Paulista", "27", -23.04972, -47.83667);
case 1253: return new CityInfo("Laranja da Terra", "08", -19.89889, -41.05667);
case 1254: return new CityInfo("Lapão", "05", -11.38333, -41.83194);
case 1255: return new CityInfo("Lapa", "18", -25.76972, -49.71583);
case 1256: return new CityInfo("Lambari", "15", -21.97556, -45.35028);
case 1257: return new CityInfo("Lajinha", "15", -20.15139, -41.62278);
case 1258: return new CityInfo("Lages", "26", -27.81611, -50.32611);
case 1259: return new CityInfo("Lajeado", "23", -29.46694, -51.96139);
case 1260: return new CityInfo("Laje", "05", -10.18708, -40.97076);
case 1261: return new CityInfo("Laguna", "26", -28.4825, -48.78083);
case 1262: return new CityInfo("Lagoa Vermelha", "23", -28.20861, -51.52583);
case 1263: return new CityInfo("Lagoa Santa", "15", -19.63006, -43.9009);
case 1264: return new CityInfo("Lagoa Formosa", "15", -18.77861, -46.4075);
case 1265: return new CityInfo("Lagoa da Prata", "15", -20.0225, -45.54361);
case 1266: return new CityInfo("Lagoa", "26", -27.60491, -48.46713);
case 1267: return new CityInfo("Lagarto", "28", -10.91722, -37.65);
case 1268: return new CityInfo("Ladário", "11", -19.00472, -57.60167);
case 1269: return new CityInfo("Juquitiba", "27", -23.93167, -47.06833);
case 1270: return new CityInfo("Juquiá", "27", -24.32083, -47.63472);
case 1271: return new CityInfo("Junqueirópolis", "27", -21.51472, -51.43361);
case 1272: return new CityInfo("Jundiaí", "27", -23.18639, -46.88417);
case 1273: return new CityInfo("Júlio de Castilhos", "23", -29.22694, -53.68167);
case 1274: return new CityInfo("Juiz de Fora", "15", -21.76417, -43.35028);
case 1275: return new CityInfo("Juatuba", "15", -19.95194, -44.34278);
case 1276: return new CityInfo("José Bonifácio", "27", -21.05278, -49.68833);
case 1277: return new CityInfo("Joinville", "26", -26.30444, -48.84556);
case 1278: return new CityInfo("João Pinheiro", "15", -17.7425, -46.1725);
case 1279: return new CityInfo("João Neiva", "08", -19.7575, -40.38556);
case 1280: return new CityInfo("João Monlevade", "15", -19.81, -43.17361);
case 1281: return new CityInfo("Joanópolis", "27", -22.93028, -46.27556);
case 1282: return new CityInfo("Joaíma", "15", -16.65417, -41.03056);
case 1283: return new CityInfo("Joaçaba", "26", -27.17806, -51.50472);
case 1284: return new CityInfo("Jitaúna", "05", -14.01274, -39.89833);
case 1285: return new CityInfo("Jetibá", "08", -20.02069, -40.68145);
case 1286: return new CityInfo("Jerônimo Monteiro", "08", -20.78944, -41.395);
case 1287: return new CityInfo("Jeremoabo", "05", -10.075, -38.48083);
case 1288: return new CityInfo("Jequitinhonha", "15", -16.43389, -41.00333);
case 1289: return new CityInfo("Jequié", "05", -13.85875, -40.08512);
case 1290: return new CityInfo("Jaú", "27", -22.29639, -48.55778);
case 1291: return new CityInfo("Jataizinho", "18", -23.25417, -50.98);
case 1292: return new CityInfo("Jataí", "29", -17.87939, -51.72166);
case 1293: return new CityInfo("Jarinu", "27", -23.10139, -46.72833);
case 1294: return new CityInfo("Jardinópolis", "27", -21.01778, -47.76389);
case 1295: return new CityInfo("Jardim", "11", -21.48028, -56.13806);
case 1296: return new CityInfo("Jaraguá do Sul", "26", -26.48611, -49.06667);
case 1297: return new CityInfo("Jaraguá", "29", -15.75694, -49.33444);
case 1298: return new CityInfo("Japoatã", "28", -10.34667, -36.80111);
case 1299: return new CityInfo("Japeri", "21", -22.64306, -43.65333);
case 1300: return new CityInfo("Japaratuba", "28", -10.59333, -36.94028);
case 1301: return new CityInfo("Januária", "15", -15.48866, -44.35988);
case 1302: return new CityInfo("Jandira", "27", -23.5275, -46.9025);
case 1303: return new CityInfo("Jandaia do Sul", "18", -23.60306, -51.64333);
case 1304: return new CityInfo("Janaúba", "15", -15.8025, -43.30889);
case 1305: return new CityInfo("Jales", "27", -20.26889, -50.54583);
case 1306: return new CityInfo("Jaguaruna", "26", -28.62145, -49.02529);
case 1307: return new CityInfo("Jaguariúna", "27", -22.70556, -46.98583);
case 1308: return new CityInfo("Jaguariaíva", "18", -24.24423, -49.70932);
case 1309: return new CityInfo("Jaguarari", "05", -10.26389, -40.19583);
case 1310: return new CityInfo("Jaguarão", "23", -32.56611, -53.37583);
case 1311: return new CityInfo("Jaguaquara", "05", -13.53056, -39.97083);
case 1312: return new CityInfo("Jacutinga", "15", -22.28556, -46.61222);
case 1313: return new CityInfo("Jacupiranga", "27", -24.6925, -48.00222);
case 1314: return new CityInfo("Jacobina", "05", -11.18143, -40.51372);
case 1315: return new CityInfo("Jaciara", "14", -15.96528, -54.96833);
case 1316: return new CityInfo("Jacarezinho", "18", -23.16056, -49.96944);
case 1317: return new CityInfo("Jacareí", "27", -23.30528, -45.96583);
case 1318: return new CityInfo("Jaboticabal", "27", -21.25472, -48.32222);
case 1319: return new CityInfo("Ivoti", "23", -29.59111, -51.16056);
case 1320: return new CityInfo("Iúna", "08", -20.34583, -41.53583);
case 1321: return new CityInfo("Ituverava", "27", -20.33944, -47.78056);
case 1322: return new CityInfo("Iturama", "15", -19.72806, -50.19556);
case 1323: return new CityInfo("Itupeva", "27", -23.15306, -47.05778);
case 1324: return new CityInfo("Itumbiara", "29", -18.41917, -49.21528);
case 1325: return new CityInfo("Ituiutaba", "15", -18.97428, -49.46212);
case 1326: return new CityInfo("Ituberá", "05", -13.73538, -39.14785);
case 1327: return new CityInfo("Ituaçu", "05", -13.81333, -41.29667);
case 1328: return new CityInfo("Itu", "27", -23.26417, -47.29917);
case 1329: return new CityInfo("Itororó", "05", -15.11694, -40.07028);
case 1330: return new CityInfo("Itiruçu", "05", -13.53167, -40.15028);
case 1331: return new CityInfo("Itirapina", "27", -22.25278, -47.82278);
case 1332: return new CityInfo("Itinga", "15", -16.61306, -41.76528);
case 1333: return new CityInfo("Itaúna", "15", -20.07528, -44.57639);
case 1334: return new CityInfo("Itaú de Minas", "15", -20.73944, -46.75222);
case 1335: return new CityInfo("Itatinga", "27", -23.10167, -48.61583);
case 1336: return new CityInfo("Itatiba", "27", -23.00583, -46.83889);
case 1337: return new CityInfo("Itatiaia", "21", -22.49611, -44.56333);
case 1338: return new CityInfo("Itararé", "27", -24.1125, -49.33167);
case 1339: return new CityInfo("Itarantim", "05", -15.65972, -40.06556);
case 1340: return new CityInfo("Itarana", "08", -19.87389, -40.87528);
case 1341: return new CityInfo("Itaqui", "23", -29.12528, -56.55306);
case 1342: return new CityInfo("Itaquaquecetuba", "27", -23.48611, -46.34833);
case 1343: return new CityInfo("Itapuranga", "29", -15.56222, -49.94861);
case 1344: return new CityInfo("Itapuí", "27", -22.23333, -48.71917);
case 1345: return new CityInfo("Itaporanga", "27", -23.70778, -49.48972);
case 1346: return new CityInfo("Itápolis", "27", -21.59556, -48.81278);
case 1347: return new CityInfo("Itapirapuã", "29", -15.82333, -50.61333);
case 1348: return new CityInfo("Itapira", "27", -22.43611, -46.82167);
case 1349: return new CityInfo("Itapicuru", "05", -11.31667, -38.23333);
case 1350: return new CityInfo("Itapevi", "27", -23.54889, -46.93417);
case 1351: return new CityInfo("Itapeva", "27", -23.98222, -48.87556);
case 1352: return new CityInfo("Itapetininga", "27", -23.59167, -48.05306);
case 1353: return new CityInfo("Itapetinga", "05", -15.24889, -40.24778);
case 1354: return new CityInfo("Itaperuna", "21", -21.205, -41.88778);
case 1355: return new CityInfo("Itaperuçu", "18", -25.22, -49.34778);
case 1356: return new CityInfo("Itapemirim", "08", -21.01111, -40.83389);
case 1357: return new CityInfo("Itapema", "26", -27.09028, -48.61139);
case 1358: return new CityInfo("Itapecerica da Serra", "27", -23.71694, -46.84917);
case 1359: return new CityInfo("Itapecerica", "15", -20.4725, -45.12556);
case 1360: return new CityInfo("Itaparica", "05", -12.88833, -38.67861);
case 1361: return new CityInfo("Itapaci", "29", -14.95083, -49.54944);
case 1362: return new CityInfo("Itaocara", "21", -21.66917, -42.07611);
case 1363: return new CityInfo("Itanhém", "05", -17.16639, -40.33);
case 1364: return new CityInfo("Itanhandu", "15", -22.29583, -44.93472);
case 1365: return new CityInfo("Itanhaém", "27", -24.18306, -46.78889);
case 1366: return new CityInfo("Itambé", "05", -15.245, -40.62444);
case 1367: return new CityInfo("Itambacuri", "15", -18.03111, -41.685);
case 1368: return new CityInfo("Itamarandiba", "15", -17.85722, -42.85889);
case 1369: return new CityInfo("Itamaraju", "05", -17.03917, -39.53111);
case 1370: return new CityInfo("Itajuípe", "05", -14.67806, -39.375);
case 1371: return new CityInfo("Itajubá", "15", -22.42556, -45.45278);
case 1372: return new CityInfo("Itajobi", "27", -21.31806, -49.05444);
case 1373: return new CityInfo("Itagibá", "05", -14.28361, -39.84278);
case 1374: return new CityInfo("Itajaí", "26", -26.90778, -48.66194);
case 1375: return new CityInfo("Itaí", "27", -23.41778, -49.09056);
case 1376: return new CityInfo("Itaguaí", "21", -22.85222, -43.77528);
case 1377: return new CityInfo("Itaguaçu", "08", -19.80194, -40.85556);
case 1378: return new CityInfo("Itagi", "05", -14.16278, -40.00611);
case 1379: return new CityInfo("Itacaré", "05", -14.2789, -38.99584);
case 1380: return new CityInfo("Itacarambi", "15", -15.10222, -44.09194);
case 1381: return new CityInfo("Itabuna", "05", -14.78556, -39.28028);
case 1382: return new CityInfo("Itaboraí", "21", -22.74444, -42.85944);
case 1383: return new CityInfo("Itabirito", "15", -20.25333, -43.80139);
case 1384: return new CityInfo("Itabira", "15", -19.61917, -43.22694);
case 1385: return new CityInfo("Itaberaí", "29", -16.02028, -49.81028);
case 1386: return new CityInfo("Itaberaba", "05", -12.5275, -40.30694);
case 1387: return new CityInfo("Itaberá", "27", -23.86194, -49.13722);
case 1388: return new CityInfo("Itabaianinha", "28", -11.27389, -37.79);
case 1389: return new CityInfo("Itabaiana", "28", -10.685, -37.42528);
case 1390: return new CityInfo("Irupi", "08", -20.34528, -41.64111);
case 1391: return new CityInfo("Irecê", "05", -11.30417, -41.85583);
case 1392: return new CityInfo("Irati", "18", -25.46722, -50.65111);
case 1393: return new CityInfo("Irará", "05", -12.05, -38.76667);
case 1394: return new CityInfo("Iraquara", "05", -12.24861, -41.61944);
case 1395: return new CityInfo("Iracemápolis", "27", -22.58056, -47.51861);
case 1396: return new CityInfo("Ipuã", "27", -20.43806, -48.01222);
case 1397: return new CityInfo("Iporã", "18", -24.00306, -53.70417);
case 1398: return new CityInfo("Iporá", "29", -16.44194, -51.11778);
case 1399: return new CityInfo("Ipirá", "05", -12.15833, -39.73722);
case 1400: return new CityInfo("Ipiaú", "05", -14.13449, -39.73948);
case 1401: return new CityInfo("Iperó", "27", -23.35028, -47.68861);
case 1402: return new CityInfo("Ipauçu", "27", -23.05667, -49.62639);
case 1403: return new CityInfo("Ipatinga", "15", -19.46833, -42.53667);
case 1404: return new CityInfo("Ipameri", "29", -17.72194, -48.15972);
case 1405: return new CityInfo("Ipaba", "15", -19.41361, -42.41944);
case 1406: return new CityInfo("Inhumas", "29", -16.35778, -49.49611);
case 1407: return new CityInfo("Inhapim", "15", -19.54917, -42.12);
case 1408: return new CityInfo("Inhambupe", "05", -11.78444, -38.35306);
case 1409: return new CityInfo("Indiaroba", "28", -11.51917, -37.51167);
case 1410: return new CityInfo("Indaiatuba", "27", -23.08842, -47.2119);
case 1411: return new CityInfo("Indaial", "26", -26.89778, -49.23167);
case 1412: return new CityInfo("Imbituva", "18", -25.23, -50.60444);
case 1413: return new CityInfo("Imbituba", "26", -28.24, -48.67028);
case 1414: return new CityInfo("Ilhéus", "05", -14.79364, -39.03949);
case 1415: return new CityInfo("Ilha Solteira", "27", -20.43278, -51.3425);
case 1416: return new CityInfo("Ilhabela", "27", -23.77806, -45.35806);
case 1417: return new CityInfo("Ijuí", "23", -28.38778, -53.91472);
case 1418: return new CityInfo("Iguatemi", "11", -23.68028, -54.56111);
case 1419: return new CityInfo("Iguape", "27", -24.70806, -47.55528);
case 1420: return new CityInfo("Iguaí", "05", -14.75639, -40.08917);
case 1421: return new CityInfo("Iguaba Grande", "21", -22.83917, -42.22889);
case 1422: return new CityInfo("Igrejinha", "23", -29.57444, -50.79028);
case 1423: return new CityInfo("Igreja Nova", "02", -10.12528, -36.66194);
case 1424: return new CityInfo("Igarapé", "15", -20.07028, -44.30167);
case 1425: return new CityInfo("Igarapava", "27", -20.03833, -47.74694);
case 1426: return new CityInfo("Igaraçu do Tietê", "27", -22.50917, -48.55778);
case 1427: return new CityInfo("Iconha", "08", -20.79306, -40.81111);
case 1428: return new CityInfo("Içara", "26", -28.71333, -49.3);
case 1429: return new CityInfo("Ibotirama", "05", -12.18528, -43.22056);
case 1430: return new CityInfo("Ibiúna", "27", -23.65639, -47.2225);
case 1431: return new CityInfo("Ibitinga", "27", -21.75778, -48.82889);
case 1432: return new CityInfo("Ibirubá", "23", -28.6275, -53.08972);
case 1433: return new CityInfo("Ibirité", "15", -20.02194, -44.05889);
case 1434: return new CityInfo("Ibirataia", "05", -14.06694, -39.64056);
case 1435: return new CityInfo("Ibirapitanga", "05", -14.16417, -39.37361);
case 1436: return new CityInfo("Ibirama", "26", -27.05694, -49.51778);
case 1437: return new CityInfo("Ibiraçu", "08", -19.83194, -40.36972);
case 1438: return new CityInfo("Ibiporã", "18", -23.26917, -51.04806);
case 1439: return new CityInfo("Ibipeba", "05", -11.64083, -42.01111);
case 1440: return new CityInfo("Ibicuí", "05", -14.84167, -39.98667);
case 1441: return new CityInfo("Ibicaraí", "05", -14.865, -39.5875);
case 1442: return new CityInfo("Ibiá", "15", -19.47833, -46.53889);
case 1443: return new CityInfo("Ibatiba", "08", -20.23389, -41.51056);
case 1444: return new CityInfo("Ibaté", "27", -21.95472, -47.99667);
case 1445: return new CityInfo("Ibaiti", "18", -23.84861, -50.18778);
case 1446: return new CityInfo("Iaçu", "05", -12.76722, -40.21167);
case 1447: return new CityInfo("Iaciara", "29", -14.09583, -46.63167);
case 1448: return new CityInfo("Hortolândia", "27", -22.85833, -47.22);
case 1449: return new CityInfo("Horizontina", "23", -27.62583, -54.30778);
case 1450: return new CityInfo("Hidrolândia", "29", -16.96222, -49.22806);
case 1451: return new CityInfo("Herval", "23", -32.02361, -53.39556);
case 1452: return new CityInfo("Gurupi", "31", -11.72917, -49.06861);
case 1453: return new CityInfo("Guiratinga", "14", -16.34534, -53.76177);
case 1454: return new CityInfo("Guia Lopes da Laguna", "11", -21.45778, -56.11417);
case 1455: return new CityInfo("Guaxupé", "15", -21.30528, -46.71278);
case 1456: return new CityInfo("Guarulhos", "27", -23.46278, -46.53333);
case 1457: return new CityInfo("Guarujá", "27", -23.99306, -46.25639);
case 1458: return new CityInfo("Guariba", "27", -21.36, -48.22833);
case 1459: return new CityInfo("Guaratuba", "18", -25.88278, -48.57472);
case 1460: return new CityInfo("Guaratinguetá", "27", -22.81639, -45.1925);
case 1461: return new CityInfo("Guaratinga", "05", -16.58564, -39.78189);
case 1462: return new CityInfo("Guararema", "27", -23.415, -46.035);
case 1463: return new CityInfo("Guararapes", "27", -21.26083, -50.64278);
case 1464: return new CityInfo("Guarapuava", "18", -25.39048, -51.46541);
case 1465: return new CityInfo("Guarapari", "08", -20.67182, -40.50196);
case 1466: return new CityInfo("Guaraniaçu", "18", -25.10083, -52.87806);
case 1467: return new CityInfo("Guaranésia", "15", -21.29917, -46.8025);
case 1468: return new CityInfo("Guaramirim", "26", -26.47306, -49.00278);
case 1469: return new CityInfo("Guará", "27", -20.42833, -47.82417);
case 1470: return new CityInfo("Guaporé", "23", -28.84556, -51.89028);
case 1471: return new CityInfo("Guapó", "29", -16.83056, -49.53194);
case 1472: return new CityInfo("Guapimirim", "21", -22.53722, -42.98194);
case 1473: return new CityInfo("Guapiaçu", "27", -20.795, -49.22028);
case 1474: return new CityInfo("Guanhães", "15", -18.775, -42.9325);
case 1475: return new CityInfo("Guanambi", "05", -14.22333, -42.78139);
case 1476: return new CityInfo("Guaíra", "27", -20.31833, -48.31056);
case 1477: return new CityInfo("Guaçuí", "08", -20.77556, -41.67944);
case 1478: return new CityInfo("Gravataí", "23", -29.94218, -50.99278);
case 1479: return new CityInfo("Governador Valadares", "15", -18.85111, -41.94944);
case 1480: return new CityInfo("Goiatuba", "29", -18.0125, -49.35472);
case 1481: return new CityInfo("Goiás", "29", -15.93444, -50.14028);
case 1482: return new CityInfo("Goianira", "29", -16.49611, -49.42639);
case 1483: return new CityInfo("Goiânia", "29", -16.67861, -49.25389);
case 1484: return new CityInfo("Goianésia", "29", -15.3175, -49.1175);
case 1485: return new CityInfo("Goianápolis", "29", -16.51056, -49.02389);
case 1486: return new CityInfo("Giruá", "23", -28.02833, -54.34972);
case 1487: return new CityInfo("General Salgado", "27", -20.64833, -50.36056);
case 1488: return new CityInfo("Gaspar", "26", -26.93139, -48.95889);
case 1489: return new CityInfo("Garibaldi", "23", -29.25611, -51.53361);
case 1490: return new CityInfo("Garça", "27", -22.21056, -49.65611);
case 1491: return new CityInfo("Gandu", "05", -13.74389, -39.48667);
case 1492: return new CityInfo("Fundão", "08", -19.93408, -40.40473);
case 1493: return new CityInfo("Frutal", "15", -20.02472, -48.94056);
case 1494: return new CityInfo("Frei Paulo", "28", -10.54944, -37.53444);
case 1495: return new CityInfo("Frederico Westphalen", "23", -27.35917, -53.39444);
case 1496: return new CityInfo("Franco da Rocha", "27", -23.32167, -46.72694);
case 1497: return new CityInfo("Francisco Sá", "15", -16.47583, -43.48833);
case 1498: return new CityInfo("Francisco Morato", "27", -23.28167, -46.74528);
case 1499: return new CityInfo("Francisco Beltrão", "18", -26.08111, -53.055);
case 1500: return new CityInfo("Franca", "27", -20.53861, -47.40083);
case 1501: return new CityInfo("Foz do Iguaçu", "18", -25.54778, -54.58806);
case 1502: return new CityInfo("Forquilhinha", "26", -28.7475, -49.47222);
case 1503: return new CityInfo("Formosa do Rio Preto", "05", -11.04833, -45.19306);
case 1504: return new CityInfo("Formosa", "29", -15.53722, -47.33444);
case 1505: return new CityInfo("Formiga", "15", -20.46444, -45.42639);
case 1506: return new CityInfo("Paulista Flórida", "27", -21.6, -51.2);
case 1507: return new CityInfo("Florianópolis", "26", -27.59667, -48.54917);
case 1508: return new CityInfo("Florestópolis", "18", -22.86333, -51.38722);
case 1509: return new CityInfo("Flores da Cunha", "23", -29.02889, -51.18167);
case 1510: return new CityInfo("Firminópolis", "29", -16.58194, -50.305);
case 1511: return new CityInfo("Ferraz de Vasconcelos", "27", -23.54083, -46.36861);
case 1512: return new CityInfo("Fernandópolis", "27", -20.28389, -50.24639);
case 1513: return new CityInfo("Feira de Santana", "05", -12.26667, -38.96667);
case 1514: return new CityInfo("Faxinal", "18", -24.00028, -51.31944);
case 1515: return new CityInfo("Fartura", "27", -23.38833, -49.51);
case 1516: return new CityInfo("Farroupilha", "23", -29.225, -51.34778);
case 1517: return new CityInfo("Extrema", "15", -22.85472, -46.31833);
case 1518: return new CityInfo("Eunápolis", "05", -16.3775, -39.58028);
case 1519: return new CityInfo("Euclides da Cunha", "05", -10.5075, -39.01583);
case 1520: return new CityInfo("Estrela", "23", -28.06111, -50.93833);
case 1521: return new CityInfo("Esteio", "23", -29.86139, -51.17917);
case 1522: return new CityInfo("Estância Velha", "23", -29.64833, -51.17389);
case 1523: return new CityInfo("Estância", "28", -11.26833, -37.43833);
case 1524: return new CityInfo("Espumoso", "23", -28.72472, -52.84972);
case 1525: return new CityInfo("Esplanada", "05", -11.79611, -37.945);
case 1526: return new CityInfo("Espinosa", "15", -14.92611, -42.81917);
case 1527: return new CityInfo("Espera Feliz", "15", -20.65028, -41.90722);
case 1528: return new CityInfo("Esmeraldas", "15", -19.7625, -44.31389);
case 1529: return new CityInfo("Erechim", "23", -27.63461, -52.2754);
case 1530: return new CityInfo("Entre Rios", "05", -11.94194, -38.08444);
case 1531: return new CityInfo("Engenheiro Beltrão", "18", -23.79722, -52.26917);
case 1532: return new CityInfo("Encruzilhada do Sul", "23", -30.54389, -52.52194);
case 1533: return new CityInfo("Encruzilhada", "05", -15.53139, -40.90944);
case 1534: return new CityInfo("Encantado", "23", -29.23611, -51.86972);
case 1535: return new CityInfo("Embu Guaçu", "27", -23.83222, -46.81139);
case 1536: return new CityInfo("Embu", "27", -23.64889, -46.85222);
case 1537: return new CityInfo("Elói Mendes", "15", -21.61, -45.56528);
case 1538: return new CityInfo("Elias Fausto", "27", -23.04278, -47.37389);
case 1539: return new CityInfo("Eldorado", "11", -23.78694, -54.28361);
case 1540: return new CityInfo("Edéia", "29", -17.33833, -49.93139);
case 1541: return new CityInfo("Ecoporanga", "08", -18.37333, -40.83056);
case 1542: return new CityInfo("Duque de Caxias", "21", -22.78556, -43.31167);
case 1543: return new CityInfo("Duartina", "27", -22.41444, -49.40389);
case 1544: return new CityInfo("Dourados", "11", -22.22111, -54.80556);
case 1545: return new CityInfo("Dores do Indaiá", "15", -19.46333, -45.60167);
case 1546: return new CityInfo("Dom Pedrito", "23", -30.98278, -54.67306);
case 1547: return new CityInfo("Domingos Martins", "08", -20.36333, -40.65917);
case 1548: return new CityInfo("Dois Vizinhos", "18", -25.73361, -53.05722);
case 1549: return new CityInfo("Dois Córregos", "27", -22.36611, -48.38028);
case 1550: return new CityInfo("Divinópolis", "15", -20.14355, -44.89065);
case 1551: return new CityInfo("Divino das Laranjeiras", "15", -18.77778, -41.47972);
case 1552: return new CityInfo("Diamantino", "14", -14.40861, -56.44611);
case 1553: return new CityInfo("Diamantina", "15", -18.24692, -43.60345);
case 1554: return new CityInfo("Diadema", "27", -23.68611, -46.62278);
case 1555: return new CityInfo("Descalvado", "27", -21.90389, -47.61944);
case 1556: return new CityInfo("Curvelo", "15", -18.75639, -44.43083);
case 1557: return new CityInfo("Curitibanos", "26", -27.28278, -50.58444);
case 1558: return new CityInfo("Curitiba", "18", -25.42778, -49.27306);
case 1559: return new CityInfo("Cunha", "27", -23.07444, -44.95972);
case 1560: return new CityInfo("Cuiabá", "14", -15.59611, -56.09667);
case 1561: return new CityInfo("Cubatão", "27", -23.895, -46.42528);
case 1562: return new CityInfo("Cruzília", "15", -21.83861, -44.80833);
case 1563: return new CityInfo("Cruzeiro do Oeste", "18", -23.785, -53.07333);
case 1564: return new CityInfo("Cruzeiro", "27", -22.57316, -44.97108);
case 1565: return new CityInfo("Cruz das Almas", "05", -12.67, -39.10194);
case 1566: return new CityInfo("Cruz Alta", "23", -28.64397, -53.60633);
case 1567: return new CityInfo("Crixás", "29", -14.54889, -49.96917);
case 1568: return new CityInfo("Cristinápolis", "28", -11.47556, -37.75528);
case 1569: return new CityInfo("Cristalina", "29", -16.76769, -47.6153);
case 1570: return new CityInfo("Criciúma", "26", -28.6775, -49.36972);
case 1571: return new CityInfo("Cravinhos", "27", -21.34028, -47.72944);
case 1572: return new CityInfo("Coxim", "11", -18.50667, -54.76);
case 1573: return new CityInfo("Cotia", "27", -23.60389, -46.91917);
case 1574: return new CityInfo("Costa Rica", "11", -23.41667, -54.65);
case 1575: return new CityInfo("Cosmópolis", "27", -22.64583, -47.19611);
case 1576: return new CityInfo("Coruripe", "02", -10.12556, -36.17556);
case 1577: return new CityInfo("Corupá", "26", -26.42528, -49.24306);
case 1578: return new CityInfo("Corumbá", "11", -19.00917, -57.65333);
case 1579: return new CityInfo("Correntina", "05", -13.34333, -44.63667);
case 1580: return new CityInfo("Correia Pinto", "26", -27.58472, -50.36111);
case 1581: return new CityInfo("Coronel Vivida", "18", -25.97972, -52.56778);
case 1582: return new CityInfo("Coronel Fabriciano", "15", -19.51861, -42.62889);
case 1583: return new CityInfo("Coromandel", "15", -18.47333, -47.20028);
case 1584: return new CityInfo("Cornélio Procópio", "18", -23.18111, -50.64667);
case 1585: return new CityInfo("Corinto", "15", -18.38083, -44.45639);
case 1586: return new CityInfo("Cordeirópolis", "27", -22.48194, -47.45667);
case 1587: return new CityInfo("Cordeiro", "21", -22.02861, -42.36083);
case 1588: return new CityInfo("Corbélia", "18", -24.79889, -53.30667);
case 1589: return new CityInfo("Coração de Maria", "05", -12.23333, -38.75);
case 1590: return new CityInfo("Coração de Jesus", "15", -16.68528, -44.365);
case 1591: return new CityInfo("Contagem", "15", -19.93167, -44.05361);
case 1592: return new CityInfo("Conselheiro Pena", "15", -19.17222, -41.47222);
case 1593: return new CityInfo("Conselheiro Lafaiete", "15", -20.66028, -43.78611);
case 1594: return new CityInfo("Congonhas", "15", -20.50525, -43.8588);
case 1595: return new CityInfo("Conde", "05", -11.81361, -37.61056);
case 1596: return new CityInfo("Concórdia", "26", -27.23417, -52.02778);
case 1597: return new CityInfo("Conchas", "27", -23.01528, -48.01056);
case 1598: return new CityInfo("Conchal", "27", -22.33028, -47.1725);
case 1599: return new CityInfo("Conceição do Rio Verde", "15", -21.88083, -45.08528);
case 1600: return new CityInfo("Conceição do Mato Dentro", "15", -19.03722, -43.425);
case 1601: return new CityInfo("Conceição do Coité", "05", -11.56389, -39.28278);
case 1602: return new CityInfo("Conceição do Castelo", "08", -20.36833, -41.24389);
case 1603: return new CityInfo("Conceição do Almeida", "05", -12.77944, -39.17);
case 1604: return new CityInfo("Conceição do Jacuípe", "05", -12.31667, -38.76667);
case 1605: return new CityInfo("Conceição das Alagoas", "15", -19.91472, -48.38833);
case 1606: return new CityInfo("Conceição da Feira", "05", -12.50583, -38.99861);
case 1607: return new CityInfo("Conceição da Barra", "08", -18.59333, -39.73222);
case 1608: return new CityInfo("Colorado", "18", -22.8375, -51.97306);
case 1609: return new CityInfo("Colombo", "18", -25.29167, -49.22417);
case 1610: return new CityInfo("Colatina", "08", -19.53944, -40.63056);
case 1611: return new CityInfo("Cocal", "26", -28.60321, -49.32767);
case 1612: return new CityInfo("Coaraci", "05", -14.64083, -39.55111);
case 1613: return new CityInfo("Clevelândia", "18", -26.39583, -52.47083);
case 1614: return new CityInfo("Cláudio", "15", -20.44333, -44.76583);
case 1615: return new CityInfo("Cipó", "05", -11.09972, -38.51361);
case 1616: return new CityInfo("Cidreira", "23", -30.18111, -50.20556);
case 1617: return new CityInfo("Cícero Dantas", "05", -10.6, -38.38333);
case 1618: return new CityInfo("Cianorte", "18", -23.66333, -52.605);
case 1619: return new CityInfo("Chuí", "23", -33.69111, -53.45667);
case 1620: return new CityInfo("Chopinzinho", "18", -25.85583, -52.52333);
case 1621: return new CityInfo("Nova Xavantina", "14", -14.66463, -52.35558);
case 1622: return new CityInfo("Charqueadas", "23", -29.95472, -51.62528);
case 1623: return new CityInfo("Charqueada", "27", -22.50972, -47.77806);
case 1624: return new CityInfo("Chapecó", "26", -27.09639, -52.61833);
case 1625: return new CityInfo("Chapada dos Guimarães", "14", -15.46056, -55.74972);
case 1626: return new CityInfo("Cerro Largo", "23", -28.14861, -54.73806);
case 1627: return new CityInfo("Cerquilho", "27", -23.165, -47.74361);
case 1628: return new CityInfo("Cerqueira César", "27", -23.03556, -49.16611);
case 1629: return new CityInfo("Ceres", "29", -15.30833, -49.59833);
case 1630: return new CityInfo("Centralina", "15", -18.58389, -49.19944);
case 1631: return new CityInfo("Centenário do Sul", "18", -22.82111, -51.59528);
case 1632: return new CityInfo("Celso Ramos", "26", -27.63444, -51.33639);
case 1633: return new CityInfo("Caxias do Sul", "23", -29.16806, -51.17944);
case 1634: return new CityInfo("Caxambu", "15", -21.97722, -44.9325);
case 1635: return new CityInfo("Cavalcante", "29", -13.7975, -47.45833);
case 1636: return new CityInfo("Catu", "05", -12.35306, -38.37889);
case 1637: return new CityInfo("Catanduva", "27", -21.13778, -48.97278);
case 1638: return new CityInfo("Catalão", "29", -18.16583, -47.94639);
case 1639: return new CityInfo("Cataguases", "15", -21.38917, -42.69667);
case 1640: return new CityInfo("Castro Alves", "05", -12.76556, -39.42833);
case 1641: return new CityInfo("Castro", "18", -24.78927, -50.01225);
case 1642: return new CityInfo("Castilho", "27", -20.87222, -51.4875);
case 1643: return new CityInfo("Castelo", "08", -20.60361, -41.18472);
case 1644: return new CityInfo("Cassilândia", "11", -19.11333, -51.73417);
case 1645: return new CityInfo("Cássia", "15", -20.58306, -46.92194);
case 1646: return new CityInfo("Casimiro de Abreu", "21", -22.48056, -42.20417);
case 1647: return new CityInfo("Cascavel", "18", -24.95583, -53.45528);
case 1648: return new CityInfo("Casa Branca", "27", -21.77389, -47.08639);
case 1649: return new CityInfo("Carmo do Rio Verde", "29", -15.35361, -49.7075);
case 1650: return new CityInfo("Carmo do Rio Claro", "15", -20.97194, -46.11889);
case 1651: return new CityInfo("Carmo do Paranaíba", "15", -19.00083, -46.31611);
case 1652: return new CityInfo("Carmo do Cajuru", "15", -20.18417, -44.77111);
case 1653: return new CityInfo("Carmo", "21", -21.93361, -42.60861);
case 1654: return new CityInfo("Carlos Chagas", "15", -17.70306, -40.76639);
case 1655: return new CityInfo("Carlos Barbosa", "23", -29.2975, -51.50361);
case 1656: return new CityInfo("Carira", "28", -10.36083, -37.70111);
case 1657: return new CityInfo("Carinhanha", "05", -14.30472, -43.765);
case 1658: return new CityInfo("Cardoso", "27", -20.08194, -49.91417);
case 1659: return new CityInfo("Carazinho", "23", -28.28389, -52.78639);
case 1660: return new CityInfo("Caratinga", "15", -19.78972, -42.13917);
case 1661: return new CityInfo("Caarapó", "11", -22.63417, -54.82222);
case 1662: return new CityInfo("Carapicuíba", "27", -23.52272, -46.835);
case 1663: return new CityInfo("Carangola", "15", -20.73306, -42.02944);
case 1664: return new CityInfo("Carandaí", "15", -20.95361, -43.80639);
case 1665: return new CityInfo("Carambeí", "18", -24.9526, -50.1159);
case 1666: return new CityInfo("Caraí", "15", -17.18889, -41.69472);
case 1667: return new CityInfo("Caraguatatuba", "27", -23.62028, -45.41306);
case 1668: return new CityInfo("Capivari", "27", -22.995, -47.50778);
case 1669: return new CityInfo("Capitólio", "15", -20.61528, -46.05);
case 1670: return new CityInfo("Capinzal", "26", -27.34361, -51.61194);
case 1671: return new CityInfo("Capinópolis", "15", -18.68194, -49.56972);
case 1672: return new CityInfo("Capim Grosso", "05", -11.38111, -40.01278);
case 1673: return new CityInfo("Capelinha", "15", -17.69139, -42.51583);
case 1674: return new CityInfo("Capela do Alto", "27", -23.47056, -47.73472);
case 1675: return new CityInfo("Capela", "28", -10.50333, -37.05278);
case 1676: return new CityInfo("Capão da Canoa", "23", -29.74556, -50.00972);
case 1677: return new CityInfo("Capâo Bonito", "27", -24.00583, -48.34944);
case 1678: return new CityInfo("Cantagalo", "21", -21.98111, -42.36806);
case 1679: return new CityInfo("Canoinhas", "26", -26.17722, -50.39);
case 1680: return new CityInfo("Canoas", "23", -29.91778, -51.18361);
case 1681: return new CityInfo("Canguçu", "23", -31.395, -52.67556);
case 1682: return new CityInfo("Canela", "23", -29.35622, -50.81357);
case 1683: return new CityInfo("Cândido Mota", "27", -22.74639, -50.38694);
case 1684: return new CityInfo("Cândido de Abreu", "18", -24.56694, -51.33333);
case 1685: return new CityInfo("Candelária", "23", -29.66917, -52.78889);
case 1686: return new CityInfo("Canavieiras", "05", -15.675, -38.94722);
case 1687: return new CityInfo("Canarana", "05", -11.68472, -41.76889);
case 1688: return new CityInfo("Cananéia", "27", -25.01472, -47.92667);
case 1689: return new CityInfo("Campo Verde", "11", -20.41667, -54.06667);
case 1690: return new CityInfo("Campos Novos", "26", -27.40167, -51.225);
case 1691: return new CityInfo("Campos Gerais", "15", -21.235, -45.75861);
case 1692: return new CityInfo("Campos do Jordão", "27", -22.73944, -45.59139);
case 1693: return new CityInfo("Campos Belos", "29", -13.03667, -46.77167);
case 1694: return new CityInfo("Campos Altos", "15", -19.69611, -46.17139);
case 1695: return new CityInfo("Campos dos Goytacazes", "21", -21.75227, -41.33044);
case 1696: return new CityInfo("Campo Mourão", "18", -24.04309, -52.37929);
case 1697: return new CityInfo("Campo Largo", "18", -25.45955, -49.53014);
case 1698: return new CityInfo("Campo Grande", "11", -20.44278, -54.64639);
case 1699: return new CityInfo("Campo Grande", "02", -10.23333, -36.5);
case 1700: return new CityInfo("Campo Formoso", "05", -10.5075, -40.32139);
case 1701: return new CityInfo("Campo do Brito", "28", -10.73333, -37.49333);
case 1702: return new CityInfo("Campo Belo", "15", -20.89722, -45.27722);
case 1703: return new CityInfo("Campina Verde", "15", -19.53791, -49.48813);
case 1704: return new CityInfo("Campinas", "27", -22.90556, -47.06083);
case 1705: return new CityInfo("Campina Grande do Sul", "18", -25.30556, -49.05528);
case 1706: return new CityInfo("Campestre", "15", -21.71111, -46.24639);
case 1707: return new CityInfo("Campanha", "15", -21.83611, -45.40056);
case 1708: return new CityInfo("Cambuquira", "15", -21.85222, -45.29583);
case 1709: return new CityInfo("Cambuí", "15", -22.61222, -46.0575);
case 1710: return new CityInfo("Cambuci", "21", -21.57528, -41.91111);
case 1711: return new CityInfo("Cambé", "18", -23.27583, -51.27833);
case 1712: return new CityInfo("Cambará", "18", -23.04639, -50.07361);
case 1713: return new CityInfo("Camaquã", "23", -30.85111, -51.81222);
case 1714: return new CityInfo("Camapuã", "11", -19.53139, -54.04389);
case 1715: return new CityInfo("Camanducaia", "15", -22.75528, -46.14472);
case 1716: return new CityInfo("Camamu", "05", -13.94472, -39.10389);
case 1717: return new CityInfo("Camaçari", "05", -12.6975, -38.32417);
case 1718: return new CityInfo("Caldas Novas", "29", -17.74431, -48.62789);
case 1719: return new CityInfo("Cajuru", "27", -21.27528, -47.30417);
case 1720: return new CityInfo("Cajati", "27", -24.73611, -48.12278);
case 1721: return new CityInfo("Cajamar", "27", -23.35611, -46.87694);
case 1722: return new CityInfo("Caieiras", "27", -23.36417, -46.74056);
case 1723: return new CityInfo("Caiapônia", "29", -16.95667, -51.81028);
case 1724: return new CityInfo("Cafelândia", "27", -21.8025, -49.61);
case 1725: return new CityInfo("Cafarnaum", "05", -11.69361, -41.46833);
case 1726: return new CityInfo("Caetité", "05", -14.06944, -42.475);
case 1727: return new CityInfo("Caeté", "15", -19.88, -43.66972);
case 1728: return new CityInfo("Caculé", "05", -14.50333, -42.22222);
case 1729: return new CityInfo("Caçu", "29", -18.55667, -51.13083);
case 1730: return new CityInfo("Caconde", "27", -21.52944, -46.64389);
case 1731: return new CityInfo("Cachoeiro de Itapemirim", "08", -20.84889, -41.11278);
case 1732: return new CityInfo("Cachoeirinha", "23", -29.95111, -51.09389);
case 1733: return new CityInfo("Cachoeiras de Macacu", "21", -22.4625, -42.65306);
case 1734: return new CityInfo("Cachoeira do Sul", "23", -30.03917, -52.89389);
case 1735: return new CityInfo("Cachoeira", "05", -12.60139, -38.96576);
case 1736: return new CityInfo("Cacequi", "23", -29.88361, -54.825);
case 1737: return new CityInfo("Caçapava do Sul", "23", -30.51436, -53.48496);
case 1738: return new CityInfo("Caçapava", "27", -23.10083, -45.70694);
case 1739: return new CityInfo("Caçador", "26", -26.77528, -51.015);
case 1740: return new CityInfo("Cabreúva", "27", -23.3075, -47.13278);
case 1741: return new CityInfo("Cabo Frio", "21", -22.88717, -42.02622);
case 1742: return new CityInfo("Butiá", "23", -30.11972, -51.96222);
case 1743: return new CityInfo("Buritizeiro", "15", -17.35111, -44.96222);
case 1744: return new CityInfo("Buritis", "15", -15.61778, -46.42333);
case 1745: return new CityInfo("Buriti Alegre", "29", -18.14, -49.04028);
case 1746: return new CityInfo("Buritama", "27", -21.06611, -50.14722);
case 1747: return new CityInfo("Buri", "27", -23.7975, -48.59278);
case 1748: return new CityInfo("Boquim", "28", -11.14694, -37.62056);
case 1749: return new CityInfo("Buerarema", "05", -14.95944, -39.29972);
case 1750: return new CityInfo("Bueno Brandão", "15", -22.44083, -46.35083);
case 1751: return new CityInfo("Brusque", "26", -27.09795, -48.91281);
case 1752: return new CityInfo("Brumado", "05", -14.20361, -41.66528);
case 1753: return new CityInfo("Brumadinho", "15", -20.14333, -44.19972);
case 1754: return new CityInfo("Brotas", "27", -22.28417, -48.12667);
case 1755: return new CityInfo("Brodósqui", "27", -20.99139, -47.65861);
case 1756: return new CityInfo("Brasília de Minas", "15", -16.20639, -44.43333);
case 1757: return new CityInfo("Brasília", "07", -15.77972, -47.92972);
case 1758: return new CityInfo("Bragança Paulista", "27", -22.9527, -46.54418);
case 1759: return new CityInfo("Braço do Norte", "26", -28.275, -49.16556);
case 1760: return new CityInfo("Botucatu", "27", -22.88583, -48.445);
case 1761: return new CityInfo("Botelhos", "15", -21.63333, -46.395);
case 1762: return new CityInfo("Borda da Mata", "15", -22.27417, -46.16528);
case 1763: return new CityInfo("Borborema", "27", -21.61972, -49.07361);
case 1764: return new CityInfo("Boracéia", "27", -22.19306, -48.77889);
case 1765: return new CityInfo("Boquira", "05", -12.82306, -42.73056);
case 1766: return new CityInfo("Bonito", "11", -21.12111, -56.48194);
case 1767: return new CityInfo("Bom Sucesso", "15", -21.03306, -44.75806);
case 1768: return new CityInfo("Bom Jesus dos Perdões", "27", -23.135, -46.46528);
case 1769: return new CityInfo("Bom Jesus do Itabapoana", "21", -21.13389, -41.67972);
case 1770: return new CityInfo("Bom Jesus do Galho", "15", -19.82889, -42.31611);
case 1771: return new CityInfo("Bom Jesus da Lapa", "05", -13.255, -43.41806);
case 1772: return new CityInfo("Bom Despacho", "15", -19.73639, -45.25222);
case 1773: return new CityInfo("Boituva", "27", -23.28333, -47.67222);
case 1774: return new CityInfo("Bocaiúva", "15", -17.10778, -43.815);
case 1775: return new CityInfo("Boa Esperança do Sul", "27", -21.9925, -48.39083);
case 1776: return new CityInfo("Boa Esperança", "15", -21.09, -45.56583);
case 1777: return new CityInfo("Boa Esperança", "08", -18.54, -40.29583);
case 1778: return new CityInfo("Blumenau", "26", -26.91944, -49.06611);
case 1779: return new CityInfo("Biritiba Mirim", "27", -23.5725, -46.03861);
case 1780: return new CityInfo("Birigui", "27", -21.28861, -50.34);
case 1781: return new CityInfo("Biguaçu", "26", -27.49417, -48.65556);
case 1782: return new CityInfo("Bicas", "15", -21.72528, -43.05944);
case 1783: return new CityInfo("Betim", "15", -19.96778, -44.19833);
case 1784: return new CityInfo("Bertioga", "27", -23.85444, -46.13861);
case 1785: return new CityInfo("Bernardino de Campos", "27", -23.01306, -49.47417);
case 1786: return new CityInfo("Bento Gonçalves", "23", -29.17139, -51.51917);
case 1787: return new CityInfo("Belo Oriente", "15", -19.22, -42.48361);
case 1788: return new CityInfo("Belo Horizonte", "15", -19.92083, -43.93778);
case 1789: return new CityInfo("Belmonte", "05", -15.86126, -38.87982);
case 1790: return new CityInfo("Belford Roxo", "21", -22.76417, -43.39944);
case 1791: return new CityInfo("Bela Vista do Paraíso", "18", -22.99667, -51.19056);
case 1792: return new CityInfo("Bela Vista de Goiás", "29", -16.97278, -48.95333);
case 1793: return new CityInfo("Bela Vista", "11", -22.10889, -56.52111);
case 1794: return new CityInfo("Bebedouro", "27", -20.94944, -48.47917);
case 1795: return new CityInfo("Bauru", "27", -22.31472, -49.06056);
case 1796: return new CityInfo("Batatais", "27", -20.89111, -47.585);
case 1797: return new CityInfo("Bataiporã", "11", -22.29528, -53.27111);
case 1798: return new CityInfo("Bastos", "27", -21.92194, -50.73389);
case 1799: return new CityInfo("Barueri", "27", -23.51056, -46.87611);
case 1800: return new CityInfo("Barroso", "15", -21.18694, -43.97583);
case 1801: return new CityInfo("Barro Alto", "29", -14.97083, -48.91583);
case 1802: return new CityInfo("Barro Alto", "05", -11.76083, -41.91167);
case 1803: return new CityInfo("Barrinha", "27", -21.19361, -48.16389);
case 1804: return new CityInfo("Barretos", "27", -20.55722, -48.56778);
case 1805: return new CityInfo("Barreiro do Jaíba", "15", -15.61532, -43.59187);
case 1806: return new CityInfo("Barreiras", "05", -12.15278, -44.99);
case 1807: return new CityInfo("Barra Velha", "26", -26.63222, -48.68472);
case 1808: return new CityInfo("Barra Mansa", "21", -22.54417, -44.17139);
case 1809: return new CityInfo("Barra dos Coqueiros", "28", -10.90889, -37.03861);
case 1810: return new CityInfo("Barra do Piraí", "21", -22.47, -43.82556);
case 1811: return new CityInfo("Barra do Garças", "14", -15.89, -52.25667);
case 1812: return new CityInfo("Barra do Bugres", "14", -15.0725, -57.18111);
case 1813: return new CityInfo("Barra de São Francisco", "08", -18.755, -40.89083);
case 1814: return new CityInfo("Barra da Estiva", "05", -13.62611, -41.32694);
case 1815: return new CityInfo("Barra Bonita", "27", -22.49472, -48.55806);
case 1816: return new CityInfo("Barra", "05", -11.08944, -43.14167);
case 1817: return new CityInfo("Bariri", "27", -22.07444, -48.74028);
case 1818: return new CityInfo("Barbacena", "15", -21.22583, -43.77361);
case 1819: return new CityInfo("Barão de Melgaço", "14", -16.19444, -55.9675);
case 1820: return new CityInfo("Barão de Cocais", "15", -19.94583, -43.48722);
case 1821: return new CityInfo("Bandeirantes", "18", -23.11, -50.3675);
case 1822: return new CityInfo("Bambuí", "15", -20.00639, -45.97694);
case 1823: return new CityInfo("Balneário Camboriú", "26", -26.99056, -48.63472);
case 1824: return new CityInfo("Baixo Guandu", "08", -19.51889, -41.01583);
case 1825: return new CityInfo("Praia do Baixio", "05", -12.10599, -37.69413);
case 1826: return new CityInfo("Baixa Grande", "05", -11.95972, -40.16806);
case 1827: return new CityInfo("Bagé", "23", -31.33139, -54.10694);
case 1828: return new CityInfo("Baependi", "15", -21.95889, -44.89);
case 1829: return new CityInfo("Bady Bassitt", "27", -20.91806, -49.44528);
case 1830: return new CityInfo("Avaré", "27", -23.09861, -48.92583);
case 1831: return new CityInfo("Auriflama", "27", -20.68556, -50.55472);
case 1832: return new CityInfo("Atibaia", "27", -23.11694, -46.55028);
case 1833: return new CityInfo("Astorga", "18", -23.2325, -51.66556);
case 1834: return new CityInfo("Astolfo Dutra", "15", -21.31528, -42.86222);
case 1835: return new CityInfo("Assis", "27", -22.66167, -50.41222);
case 1836: return new CityInfo("Assaí", "18", -23.37333, -50.84139);
case 1837: return new CityInfo("Arujá", "27", -23.39611, -46.32083);
case 1838: return new CityInfo("Artur Nogueira", "27", -22.57306, -47.1725);
case 1839: return new CityInfo("Arroio Grande", "23", -32.2375, -53.08694);
case 1840: return new CityInfo("Arroio dos Ratos", "23", -30.07722, -51.72917);
case 1841: return new CityInfo("Arroio do Meio", "23", -29.40111, -51.945);
case 1842: return new CityInfo("Arraias", "31", -12.93139, -46.93833);
case 1843: return new CityInfo("Arraial do Cabo", "21", -22.96611, -42.02778);
case 1844: return new CityInfo("Armação de Búzios", "21", -22.74694, -41.88167);
case 1845: return new CityInfo("Armação", "26", -27.74963, -48.50713);
case 1846: return new CityInfo("Arinos", "15", -15.91694, -46.10556);
case 1847: return new CityInfo("Arenápolis", "14", -14.45028, -56.84611);
case 1848: return new CityInfo("Areia Branca", "28", -10.75778, -37.31528);
case 1849: return new CityInfo("Areal", "21", -22.23056, -43.10556);
case 1850: return new CityInfo("Areado", "15", -21.35861, -46.14556);
case 1851: return new CityInfo("Arcos", "15", -20.28194, -45.53944);
case 1852: return new CityInfo("Araxá", "15", -19.59333, -46.94056);
case 1853: return new CityInfo("Araucária", "18", -25.59306, -49.41028);
case 1854: return new CityInfo("Arauá", "28", -11.26222, -37.61972);
case 1855: return new CityInfo("Araruama", "21", -22.87278, -42.34306);
case 1856: return new CityInfo("Araras", "27", -22.35694, -47.38417);
case 1857: return new CityInfo("Araraquara", "27", -21.79444, -48.17556);
case 1858: return new CityInfo("Araranguá", "26", -28.93575, -49.49538);
case 1859: return new CityInfo("Arapongas", "18", -23.41944, -51.42444);
case 1860: return new CityInfo("Araguari", "15", -18.64722, -48.18722);
case 1861: return new CityInfo("Araguaiana", "14", -15.73389, -51.83139);
case 1862: return new CityInfo("Aragarças", "29", -15.8975, -52.25083);
case 1863: return new CityInfo("Araçuaí", "15", -16.84972, -42.07028);
case 1864: return new CityInfo("Aracruz", "08", -19.82028, -40.27333);
case 1865: return new CityInfo("Araçoiaba da Serra", "27", -23.50528, -47.61417);
case 1866: return new CityInfo("Araci", "05", -11.33333, -38.96667);
case 1867: return new CityInfo("Araçatuba", "27", -21.20889, -50.43278);
case 1868: return new CityInfo("Aracaju", "28", -10.91111, -37.07167);
case 1869: return new CityInfo("Aquidauana", "11", -20.47111, -55.78722);
case 1870: return new CityInfo("Aquidabã", "28", -10.28139, -37.01861);
case 1871: return new CityInfo("Apucarana", "18", -23.55083, -51.46083);
case 1872: return new CityInfo("Apiaí", "27", -24.50944, -48.8425);
case 1873: return new CityInfo("Aparecida do Taboado", "11", -20.08667, -51.09361);
case 1874: return new CityInfo("Aparecida", "27", -22.84694, -45.22972);
case 1875: return new CityInfo("Antonina", "18", -25.42861, -48.71194);
case 1876: return new CityInfo("Anitápolis", "26", -27.90194, -49.12861);
case 1877: return new CityInfo("Anicuns", "29", -16.46111, -49.96167);
case 1878: return new CityInfo("Anguera", "05", -12.15111, -39.24639);
case 1879: return new CityInfo("Angra dos Reis", "21", -23.00667, -44.31806);
case 1880: return new CityInfo("Angatuba", "27", -23.48972, -48.41278);
case 1881: return new CityInfo("Andrelândia", "15", -21.73972, -44.30917);
case 1882: return new CityInfo("Andradina", "27", -20.89611, -51.37944);
case 1883: return new CityInfo("Andradas", "15", -22.06806, -46.56917);
case 1884: return new CityInfo("Anastácio", "11", -20.48361, -55.80694);
case 1885: return new CityInfo("Anápolis", "29", -16.32667, -48.95278);
case 1886: return new CityInfo("Anagé", "05", -14.61222, -41.13556);
case 1887: return new CityInfo("Ampére", "18", -25.915, -53.47278);
case 1888: return new CityInfo("Amparo", "27", -22.70111, -46.76444);
case 1889: return new CityInfo("Américo Brasiliense", "27", -21.72444, -48.10167);
case 1890: return new CityInfo("Americana", "27", -22.73917, -47.33139);
case 1891: return new CityInfo("América Dourada", "05", -11.45528, -41.43611);
case 1892: return new CityInfo("Amargosa", "05", -13.03028, -39.60472);
case 1893: return new CityInfo("Alvorada", "31", -12.48, -49.12472);
case 1894: return new CityInfo("Alvinópolis", "15", -20.10667, -43.04889);
case 1895: return new CityInfo("Álvares Machado", "27", -22.07944, -51.47194);
case 1896: return new CityInfo("Alto Piquiri", "18", -24.02806, -53.44056);
case 1897: return new CityInfo("Alto Paraná", "18", -23.12889, -52.31889);
case 1898: return new CityInfo("Altãnia", "18", -23.87444, -53.90167);
case 1899: return new CityInfo("Alto Araguaia", "14", -17.31472, -53.21528);
case 1900: return new CityInfo("Altinópolis", "27", -21.02556, -47.37389);
case 1901: return new CityInfo("Alterosa", "15", -21.24917, -46.14306);
case 1902: return new CityInfo("Alpinópolis", "15", -20.86361, -46.38806);
case 1903: return new CityInfo("Almirante Tamandaré", "18", -25.32472, -49.31);
case 1904: return new CityInfo("Almenara", "15", -16.18361, -40.69444);
case 1905: return new CityInfo("Alfredo Chaves", "08", -20.635, -40.74972);
case 1906: return new CityInfo("Alfenas", "15", -21.42917, -45.94722);
case 1907: return new CityInfo("Além Paraíba", "15", -21.88778, -42.70444);
case 1908: return new CityInfo("Alegrete", "23", -29.78306, -55.79194);
case 1909: return new CityInfo("Alegre", "08", -20.76361, -41.53306);
case 1910: return new CityInfo("Alagoinhas", "05", -12.13556, -38.41917);
case 1911: return new CityInfo("Aimorés", "15", -19.49583, -41.06389);
case 1912: return new CityInfo("Águia Branca", "08", -18.98306, -40.74028);
case 1913: return new CityInfo("Agudos", "27", -22.46917, -48.9875);
case 1914: return new CityInfo("Águas Vermelhas", "15", -15.74722, -41.46);
case 1915: return new CityInfo("Águas Formosas", "15", -17.08222, -40.93583);
case 1916: return new CityInfo("Águas de Lindóia", "27", -22.47639, -46.63278);
case 1917: return new CityInfo("Aguaí", "27", -22.05944, -46.97861);
case 1918: return new CityInfo("Afonso Cláudio", "08", -20.07417, -41.12389);
case 1919: return new CityInfo("Adamantina", "27", -21.68528, -51.0725);
case 1920: return new CityInfo("Açucena", "15", -19.07306, -42.54639);
case 1921: return new CityInfo("Acajutiba", "05", -11.66222, -38.01722);
case 1922: return new CityInfo("Abaeté", "15", -19.16, -45.44583);
case 1923: return new CityInfo("Abadiânia", "29", -16.20417, -48.70694);
case 1924: return new CityInfo("Guaíba", "23", -30.11389, -51.325);
case 1925: return new CityInfo("Palmas", "31", -10.16745, -48.32766);
case 1926: return new CityInfo("Pontal do Paraná", "18", -25.67361, -48.51111);
case 1927: return new CityInfo("Uarini", "04", -2.99, -65.10833);
case 1928: return new CityInfo("Tonantins", "04", -2.87306, -67.80222);
case 1929: return new CityInfo("Tefé", "04", -3.36841, -64.72054);
case 1930: return new CityInfo("Marechal Thaumaturgo", "01", -8.94111, -72.79167);
case 1931: return new CityInfo("Tarauacá", "01", -8.16139, -70.76556);
case 1932: return new CityInfo("Tabatinga", "04", -4.23116, -69.93858);
case 1933: return new CityInfo("Sena Madureira", "01", -9.06341, -68.67245);
case 1934: return new CityInfo("São Paulo de Olivença", "04", -3.37833, -68.8725);
case 1935: return new CityInfo("São Gabriel da Cachoeira", "04", -0.1181, -67.08527);
case 1936: return new CityInfo("Santo Antônio do Içá", "04", -3.10222, -67.93972);
case 1937: return new CityInfo("Santa Isabel do Rio Negro", "04", -0.41389, -65.01917);
case 1938: return new CityInfo("Rio Branco", "01", -9.97472, -67.81);
case 1939: return new CityInfo("Porto Walter", "01", -8.26861, -72.74389);
case 1940: return new CityInfo("Porto Velho", "24", -8.76194, -63.90389);
case 1941: return new CityInfo("Pauini", "04", -7.71361, -66.97639);
case 1942: return new CityInfo("Novo Aripuanã", "04", -5.12056, -60.37972);
case 1943: return new CityInfo("Maraã", "04", -1.82403, -65.35883);
case 1944: return new CityInfo("Manoel Urbano", "01", -8.83889, -69.25972);
case 1945: return new CityInfo("Manicoré", "04", -5.80917, -61.30028);
case 1946: return new CityInfo("Mâncio Lima", "01", -7.61417, -72.89583);
case 1947: return new CityInfo("Manaus", "04", -3.10194, -60.025);
case 1948: return new CityInfo("Manaquiri", "04", -3.31667, -60.35);
case 1949: return new CityInfo("Manacapuru", "04", -3.29972, -60.62056);
case 1950: return new CityInfo("Jutaí", "04", -5.18333, -68.9);
case 1951: return new CityInfo("Humaitá", "04", -7.51651, -63.03105);
case 1952: return new CityInfo("Fonte Boa", "04", -2.51389, -66.09167);
case 1953: return new CityInfo("Feijó", "01", -8.1654, -70.35486);
case 1954: return new CityInfo("Envira", "04", -7.3, -70.21667);
case 1955: return new CityInfo("Eirunepé", "04", -6.66028, -69.87361);
case 1956: return new CityInfo("Cruzeiro do Sul", "01", -7.62759, -72.67756);
case 1957: return new CityInfo("Codajás", "04", -3.83667, -62.05694);
case 1958: return new CityInfo("Coari", "04", -4.085, -63.14139);
case 1959: return new CityInfo("Carauari", "04", -4.88278, -66.89583);
case 1960: return new CityInfo("Canutama", "04", -6.53389, -64.38306);
case 1961: return new CityInfo("Boca do Acre", "04", -8.75222, -67.39778);
case 1962: return new CityInfo("Boa Vista", "25", 2.81972, -60.67333);
case 1963: return new CityInfo("Benjamin Constant", "04", -4.37555, -70.03179);
case 1964: return new CityInfo("Barcelos", "04", -0.97357, -62.9269);
case 1965: return new CityInfo("Ariquemes", "24", -9.91333, -63.04083);
case 1966: return new CityInfo("Aripuanã", "14", -9.16667, -60.63333);
case 1967: return new CityInfo("Anori", "04", -3.77278, -61.64417);
case 1968: return new CityInfo("Alvarães", "04", -3.22083, -64.80417);
case 1969: return new CityInfo("Iranduba", "04", -3.28472, -60.18611);
case 1970: return new CityInfo("Xapuri", "01", -10.65167, -68.50444);
case 1971: return new CityInfo("Vilhena", "24", -12.74056, -60.14583);
case 1972: return new CityInfo("Senador Guiomard", "01", -10.1497, -67.73741);
case 1973: return new CityInfo("Presidente Médici", "24", -11.17528, -61.90139);
case 1974: return new CityInfo("Pôsto Fiscal Rolim de Moura", "24", -13.08271, -62.27726);
case 1975: return new CityInfo("Plácido de Castro", "01", -10.33528, -67.18556);
case 1976: return new CityInfo("Pimenta Bueno", "24", -11.6725, -61.19361);
case 1977: return new CityInfo("Ouro Preto do Oeste", "24", -10.74806, -62.21583);
case 1978: return new CityInfo("Ji Paraná", "24", -10.88528, -61.95167);
case 1979: return new CityInfo("Jaru", "24", -10.43889, -62.46639);
case 1980: return new CityInfo("Guajará Mirim", "24", -10.78356, -65.33552);
case 1981: return new CityInfo("Cacoal", "24", -11.43861, -61.44722);
case 1982: return new CityInfo("Brasiléia", "01", -11.01611, -68.74806);
case 1983: return new CityInfo("Alta Floresta", "14", -9.87556, -56.08611);
case 1984: return new CityInfo("Aparecida de Goiânia", "29", -16.82333, -49.24389);
case 1985: return new CityInfo("Araguanã", "13", -2.94639, -45.66098);
case 1986: return new CityInfo("Campinas", "26", -27.59444, -48.60694);
case 1987: return new CityInfo("Campo Limpo Paulista", "27", -23.20639, -46.78444);
case 1988: return new CityInfo("Fernando de Noronha (Distrito Estadual)", "30", -3.84028, -32.41083);
case 1989: return new CityInfo("Jaboatão dos Guararapes", "30", -8.11278, -35.01472);
case 1990: return new CityInfo("Lago dos Rodrigues", "13", -4.61304, -44.98009);
case 1991: return new CityInfo("Lauro de Freitas", "05", -12.89444, -38.32722);
case 1992: return new CityInfo("Lucas do Rio Verde", "14", -13.07045, -55.9235);
case 1993: return new CityInfo("Minaçu", "29", -13.53306, -48.22);
case 1994: return new CityInfo("Monte Verde", "15", -22.86417, -46.035);
case 1995: return new CityInfo("Ourilândia do Norte", "16", -6.75472, -51.08389);
case 1996: return new CityInfo("Parauapebas", "16", -6.0675, -49.90222);
case 1997: return new CityInfo("Paulo Ramos", "13", -4.44389, -45.24056);
case 1998: return new CityInfo("Pinhais", "18", -25.44472, -49.1925);
case 1999: return new CityInfo("Portelândia", "29", -17.35361, -52.67861);
case 2000: return new CityInfo("Redenção", "16", -8.02861, -50.03139);
case 2001: return new CityInfo("Rio Preto da Eva", "04", -2.69795, -59.70172);
case 2002: return new CityInfo("Santa Maria de Jetibá", "08", -20.02745, -40.74336);
case 2003: return new CityInfo("Simões Filho", "05", -12.78444, -38.40389);
case 2004: return new CityInfo("Sinop", "14", -11.86417, -55.5025);
case 2005: return new CityInfo("Teixeira de Freitas", "05", -17.535, -39.74194);
case 2006: return new CityInfo("Tucumã", "16", -6.7475, -51.16111);
case 2007: return new CityInfo("Vargem Grande Paulista", "27", -23.60333, -47.02639);
case 2008: return new CityInfo("Xinguara", "16", -7.09829, -49.9435);
case 2009: return new CityInfo("Cambebba", "06", -3.62092, -38.82913);
case 2010: return new CityInfo("Ilha Grande", "21", -23.15236, -44.23164);
case 2011: return new CityInfo("Jardim Paulista", "27", -23.56675, -46.66439);
case 2012: return new CityInfo("Itacorubi", "26", -27.58315, -48.49503);
case 2013: return new CityInfo("Corrego Grande", "26", -27.60141, -48.50593);
case 2014: return new CityInfo("Santa Monica", "26", -27.59137, -48.50756);
case 2015: return new CityInfo("Carvoeira", "26", -27.59898, -48.52618);
case 2016: return new CityInfo("Trindade", "26", -27.58612, -48.52335);
case 2017: return new CityInfo("Morro da Cruz", "26", -27.5849, -48.53562);
case 2018: return new CityInfo("Saco dos Limoes", "26", -27.60864, -48.53605);
case 2019: return new CityInfo("Pantanal", "26", -27.60985, -48.51648);
case 2020: return new CityInfo("Costeira do Pirajubae", "26", -27.63586, -48.5212);
case 2021: return new CityInfo("Carianos", "26", -27.66088, -48.54318);
case 2022: return new CityInfo("Tapera", "26", -27.68528, -48.55124);
case 2023: return new CityInfo("Acores", "26", -27.78146, -48.52653);
case 2024: return new CityInfo("Caiacanga da Barra do Sul", "26", -27.76315, -48.57193);
case 2025: return new CityInfo("Freguesia do Ribeirao da Ilha", "26", -27.71773, -48.56266);
case 2026: return new CityInfo("Atins", "13", -2.57017, -42.74229);
case 2027: return new CityInfo("Residencia Moacir PU5BHV", "26", -26.90967, -49.36547);
case 2028: return new CityInfo("Beira Rio", "05", -12.25438, -42.75529);
case 2029: return new CityInfo("Butia Inferior", "23", -28.07115, -54.88533);
case 2030: return new CityInfo("Nova Olina do Marnhao", "13", -2.84206, -45.69789);
case 2031: return new CityInfo("Planaltina", "07", -15.61791, -47.64874);
case 2032: return new CityInfo("Extrema", "24", -9.77136, -66.35583);
case 2033: return new CityInfo("Ciceroândia", "17", -7.25139, -34.98333);
case 2034: return new CityInfo("Paraíso", "27", -23.57563, -46.6507);
default: return new CityInfo("São Pedro", "21", -22.42313, -42.96612);

                                    }                                        
                                }
                            
                        }
                    }
                