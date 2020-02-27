
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
                                    public const string Country = "SV";
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
                            
                                        var cur = (Math.Abs(13.58944 - lat) + Math.Abs(-89.28889 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-88.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.95 - lat) + Math.Abs(-88.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-88.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78111 - lat) + Math.Abs(-89.11861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13333 - lat) + Math.Abs(-89.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.83333 - lat) + Math.Abs(-88.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78917 - lat) + Math.Abs(-89.00528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.90111 - lat) + Math.Abs(-89.92972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93806 - lat) + Math.Abs(-89.02778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71024 - lat) + Math.Abs(-89.13989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73417 - lat) + Math.Abs(-89.71472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71889 - lat) + Math.Abs(-89.72417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71667 - lat) + Math.Abs(-88.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86667 - lat) + Math.Abs(-88.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63333 - lat) + Math.Abs(-88.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.64083 - lat) + Math.Abs(-89.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51667 - lat) + Math.Abs(-88.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-88.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62472 - lat) + Math.Abs(-87.89361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-88.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99417 - lat) + Math.Abs(-89.55972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73333 - lat) + Math.Abs(-88.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.68935 - lat) + Math.Abs(-89.18718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54361 - lat) + Math.Abs(-89.03861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.97556 - lat) + Math.Abs(-89.34 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-88.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78333 - lat) + Math.Abs(-88.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66108 - lat) + Math.Abs(-89.18252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.87611 - lat) + Math.Abs(-89.35972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.18333 - lat) + Math.Abs(-89.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.84306 - lat) + Math.Abs(-90.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7 - lat) + Math.Abs(-88.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71639 - lat) + Math.Abs(-89.73833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43139 - lat) + Math.Abs(-87.96306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-88.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.57528 - lat) + Math.Abs(-89.20889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.83124 - lat) + Math.Abs(-89.27221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28333 - lat) + Math.Abs(-88.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58444 - lat) + Math.Abs(-87.84111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61278 - lat) + Math.Abs(-89.18 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-88.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56972 - lat) + Math.Abs(-89.11722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.64861 - lat) + Math.Abs(-89.26528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.67694 - lat) + Math.Abs(-89.27972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78361 - lat) + Math.Abs(-87.83861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13333 - lat) + Math.Abs(-89.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7775 - lat) + Math.Abs(-89.73667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-88.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.33333 - lat) + Math.Abs(-89.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72397 - lat) + Math.Abs(-89.188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33694 - lat) + Math.Abs(-87.84389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48833 - lat) + Math.Abs(-89.32222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78694 - lat) + Math.Abs(-89.85722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25389 - lat) + Math.Abs(-88.24778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51667 - lat) + Math.Abs(-88.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.84139 - lat) + Math.Abs(-89.74556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61667 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.31667 - lat) + Math.Abs(-88.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74472 - lat) + Math.Abs(-89.67306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.19694 - lat) + Math.Abs(-88.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.70167 - lat) + Math.Abs(-89.10944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.87694 - lat) + Math.Abs(-89.17306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75028 - lat) + Math.Abs(-89.84222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66667 - lat) + Math.Abs(-88.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.49778 - lat) + Math.Abs(-89.02972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.97361 - lat) + Math.Abs(-89.21861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.90889 - lat) + Math.Abs(-89.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72171 - lat) + Math.Abs(-89.16874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72702 - lat) + Math.Abs(-89.18161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81083 - lat) + Math.Abs(-87.97139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30778 - lat) + Math.Abs(-87.86472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.87028 - lat) + Math.Abs(-89.84861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-88.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.71667 - lat) + Math.Abs(-88.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.92861 - lat) + Math.Abs(-89.50417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76667 - lat) + Math.Abs(-88.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.84028 - lat) + Math.Abs(-89.44722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.22028 - lat) + Math.Abs(-88.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63333 - lat) + Math.Abs(-88.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98667 - lat) + Math.Abs(-89.68111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03333 - lat) + Math.Abs(-88.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11667 - lat) + Math.Abs(-89.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76667 - lat) + Math.Abs(-88.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-88.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73538 - lat) + Math.Abs(-89.20221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.97694 - lat) + Math.Abs(-89.7525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74361 - lat) + Math.Abs(-89.49889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80722 - lat) + Math.Abs(-89.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66667 - lat) + Math.Abs(-88.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66492 - lat) + Math.Abs(-89.25319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74056 - lat) + Math.Abs(-87.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.92139 - lat) + Math.Abs(-89.845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.95722 - lat) + Math.Abs(-89.18972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59278 - lat) + Math.Abs(-89.8275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zaragoza", "05", 13.58944, -89.28889);
case 1: return new CityInfo("Zacatecoluca", "06", 13.5, -88.86667);
case 2: return new CityInfo("Victoria", "02", 13.95, -88.63333);
case 3: return new CityInfo("Usulután", "14", 13.35, -88.45);
case 4: return new CityInfo("Tonacatepeque", "10", 13.78111, -89.11861);
case 5: return new CityInfo("Texistepeque", "11", 14.13333, -89.5);
case 6: return new CityInfo("Tenancingo", "04", 13.83333, -88.98333);
case 7: return new CityInfo("Tecoluca", "04", 13.78917, -89.00528);
case 8: return new CityInfo("Tacuba", "01", 13.90111, -89.92972);
case 9: return new CityInfo("Suchitoto", "04", 13.93806, -89.02778);
case 10: return new CityInfo("Soyapango", "10", 13.71024, -89.13989);
case 11: return new CityInfo("Sonzacate", "13", 13.73417, -89.71472);
case 12: return new CityInfo("Sonsonate", "13", 13.71889, -89.72417);
case 13: return new CityInfo("Sociedad", "08", 13.7, -88.01667);
case 14: return new CityInfo("Sesori", "09", 13.71667, -88.36667);
case 15: return new CityInfo("Sensuntepeque", "02", 13.86667, -88.63333);
case 16: return new CityInfo("San Vicente", "12", 13.63333, -88.8);
case 17: return new CityInfo("Santo Tomás", "10", 13.64083, -89.13333);
case 18: return new CityInfo("Santiago Nonualco", "06", 13.51667, -88.95);
case 19: return new CityInfo("Santiago de María", "14", 13.48333, -88.46667);
case 20: return new CityInfo("Santa Rosa de Lima", "07", 13.62472, -87.89361);
case 21: return new CityInfo("Santa Elena", "14", 13.38333, -88.41667);
case 22: return new CityInfo("Santa Ana", "11", 13.99417, -89.55972);
case 23: return new CityInfo("San Sebastián", "12", 13.73333, -88.83333);
case 24: return new CityInfo("San Salvador", "10", 13.68935, -89.18718);
case 25: return new CityInfo("San Rafael Oriente", "09", 13.38333, -88.35);
case 26: return new CityInfo("San Pedro Masahuat", "06", 13.54361, -89.03861);
case 27: return new CityInfo("San Pablo Tacachico", "05", 13.97556, -89.34);
case 28: return new CityInfo("San Miguel", "09", 13.48333, -88.18333);
case 29: return new CityInfo("San Martín", "04", 13.78333, -88.91667);
case 30: return new CityInfo("San Marcos", "10", 13.66108, -89.18252);
case 31: return new CityInfo("San Juan Opico", "05", 13.87611, -89.35972);
case 32: return new CityInfo("San Francisco Morazán", "03", 14.18333, -89.05);
case 33: return new CityInfo("San Francisco Menéndez", "01", 13.84306, -90.01583);
case 34: return new CityInfo("San Francisco", "08", 13.7, -88.1);
case 35: return new CityInfo("San Antonio del Monte", "13", 13.71639, -89.73833);
case 36: return new CityInfo("San Alejo", "07", 13.43139, -87.96306);
case 37: return new CityInfo("San Agustín", "14", 13.43333, -88.6);
case 38: return new CityInfo("Rosario de Mora", "10", 13.57528, -89.20889);
case 39: return new CityInfo("Quezaltepeque", "05", 13.83124, -89.27221);
case 40: return new CityInfo("Puerto El Triunfo", "14", 13.28333, -88.55);
case 41: return new CityInfo("Pasaquina", "07", 13.58444, -87.84111);
case 42: return new CityInfo("Panchimalco", "10", 13.61278, -89.18);
case 43: return new CityInfo("Ozatlán", "14", 13.38333, -88.5);
case 44: return new CityInfo("Olocuilta", "06", 13.56972, -89.11722);
case 45: return new CityInfo("Nuevo Cuscatlán", "05", 13.64861, -89.26528);
case 46: return new CityInfo("Santa Tecla", "05", 13.67694, -89.27972);
case 47: return new CityInfo("Nueva Guadalupe", "09", 13.53333, -88.35);
case 48: return new CityInfo("Nueva Esparta", "07", 13.78361, -87.83861);
case 49: return new CityInfo("Nueva Concepción", "03", 14.13333, -89.3);
case 50: return new CityInfo("Nahuizalco", "13", 13.7775, -89.73667);
case 51: return new CityInfo("Moncagua", "09", 13.53333, -88.25);
case 52: return new CityInfo("Metapán", "11", 14.33333, -89.45);
case 53: return new CityInfo("Mejicanos", "10", 13.72397, -89.188);
case 54: return new CityInfo("Lolotique", "09", 13.55, -88.35);
case 55: return new CityInfo("La Unión", "07", 13.33694, -87.84389);
case 56: return new CityInfo("La Libertad", "05", 13.48833, -89.32222);
case 57: return new CityInfo("Jujutla", "01", 13.78694, -89.85722);
case 58: return new CityInfo("Jucuarán", "14", 13.25389, -88.24778);
case 59: return new CityInfo("Jucuapa", "14", 13.51667, -88.38333);
case 60: return new CityInfo("Juayúa", "13", 13.84139, -89.74556);
case 61: return new CityInfo("Jocoro", "08", 13.61667, -88.01667);
case 62: return new CityInfo("Jiquilisco", "14", 13.31667, -88.58333);
case 63: return new CityInfo("Izalco", "13", 13.74472, -89.67306);
case 64: return new CityInfo("Intipucá", "07", 13.19694, -88.05444);
case 65: return new CityInfo("Ilopango", "10", 13.70167, -89.10944);
case 66: return new CityInfo("Guazapa", "10", 13.87694, -89.17306);
case 67: return new CityInfo("Guaymango", "01", 13.75028, -89.84222);
case 68: return new CityInfo("Guatajiagua", "08", 13.66667, -88.2);
case 69: return new CityInfo("El Tránsito", "09", 13.35, -88.35);
case 70: return new CityInfo("El Rosario", "06", 13.49778, -89.02972);
case 71: return new CityInfo("El Paisnal", "10", 13.97361, -89.21861);
case 72: return new CityInfo("El Congo", "11", 13.90889, -89.49583);
case 73: return new CityInfo("Delgado", "10", 13.72171, -89.16874);
case 74: return new CityInfo("Cuscatancingo", "10", 13.72702, -89.18161);
case 75: return new CityInfo("Corinto", "08", 13.81083, -87.97139);
case 76: return new CityInfo("Conchagua", "07", 13.30778, -87.86472);
case 77: return new CityInfo("Concepción de Ataco", "01", 13.87028, -89.84861);
case 78: return new CityInfo("Concepción Batres", "14", 13.35, -88.36667);
case 79: return new CityInfo("Cojutepeque", "04", 13.71667, -88.93333);
case 80: return new CityInfo("Coatepeque", "11", 13.92861, -89.50417);
case 81: return new CityInfo("Ciudad Barrios", "09", 13.76667, -88.26667);
case 82: return new CityInfo("Ciudad Arce", "05", 13.84028, -89.44722);
case 83: return new CityInfo("Chirilagua", "09", 13.22028, -88.13861);
case 84: return new CityInfo("Chinameca", "09", 13.5, -88.35);
case 85: return new CityInfo("Chapeltique", "09", 13.63333, -88.26667);
case 86: return new CityInfo("Chalchuapa", "11", 13.98667, -89.68111);
case 87: return new CityInfo("Chalatenango", "03", 14.03333, -88.93333);
case 88: return new CityInfo("Candelaria de La Frontera", "11", 14.11667, -89.65);
case 89: return new CityInfo("Cacaopera", "08", 13.76667, -88.08333);
case 90: return new CityInfo("Berlín", "14", 13.5, -88.53333);
case 91: return new CityInfo("Ayutuxtepeque", "10", 13.73538, -89.20221);
case 92: return new CityInfo("Atiquizaya", "01", 13.97694, -89.7525);
case 93: return new CityInfo("Armenia", "13", 13.74361, -89.49889);
case 94: return new CityInfo("Apopa", "10", 13.80722, -89.17917);
case 95: return new CityInfo("Apastepeque", "12", 13.66667, -88.78333);
case 96: return new CityInfo("Antiguo Cuscatlán", "05", 13.66492, -89.25319);
case 97: return new CityInfo("Anamorós", "07", 13.74056, -87.87361);
case 98: return new CityInfo("Ahuachapán", "01", 13.92139, -89.845);
case 99: return new CityInfo("Aguilares", "10", 13.95722, -89.18972);
default: return new CityInfo("Acajutla", "13", 13.59278, -89.8275);

                                    }                                        
                                }
                            
                        }
                    }
                