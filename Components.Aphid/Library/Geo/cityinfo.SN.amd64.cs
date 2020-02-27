
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
                                    public const string Country = "SN";
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
                            
                                        var cur = (Math.Abs(12.56801 - lat) + Math.Abs(-16.27326 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.15 - lat) + Math.Abs(-14.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85 - lat) + Math.Abs(-15.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.78556 - lat) + Math.Abs(-16.52167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63333 - lat) + Math.Abs(-16.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.41667 - lat) + Math.Abs(-16.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-16.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78944 - lat) + Math.Abs(-16.92602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77073 - lat) + Math.Abs(-13.66734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.88333 - lat) + Math.Abs(-16.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.19422 - lat) + Math.Abs(-12.94482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.70806 - lat) + Math.Abs(-15.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01793 - lat) + Math.Abs(-16.48962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.42028 - lat) + Math.Abs(-15.79834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.4625 - lat) + Math.Abs(-15.70083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3 - lat) + Math.Abs(-13.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.77099 - lat) + Math.Abs(-17.06107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.35 - lat) + Math.Abs(-16.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76457 - lat) + Math.Abs(-17.39071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98333 - lat) + Math.Abs(-16.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.485 - lat) + Math.Abs(-16.54694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.60588 - lat) + Math.Abs(-13.3223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26367 - lat) + Math.Abs(-12.86821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75 - lat) + Math.Abs(-15.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51255 - lat) + Math.Abs(-17.00447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.91667 - lat) + Math.Abs(-15.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.51293 - lat) + Math.Abs(-14.64706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3338 - lat) + Math.Abs(-15.4766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1097 - lat) + Math.Abs(-16.6218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.79032 - lat) + Math.Abs(-15.90803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65587 - lat) + Math.Abs(-13.25544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8275 - lat) + Math.Abs(-15.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61867 - lat) + Math.Abs(-16.22436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98333 - lat) + Math.Abs(-14.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8939 - lat) + Math.Abs(-14.94125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76667 - lat) + Math.Abs(-16.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10877 - lat) + Math.Abs(-16.719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.55561 - lat) + Math.Abs(-12.18076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91893 - lat) + Math.Abs(-17.11978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.15197 - lat) + Math.Abs(-16.07259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4916 - lat) + Math.Abs(-13.17627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10594 - lat) + Math.Abs(-15.5508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.16667 - lat) + Math.Abs(-16.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.26667 - lat) + Math.Abs(-15.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.25575 - lat) + Math.Abs(-14.10165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.23333 - lat) + Math.Abs(-16.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13333 - lat) + Math.Abs(-16.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.33236 - lat) + Math.Abs(-16.40513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.64792 - lat) + Math.Abs(-16.24363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.18333 - lat) + Math.Abs(-16.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.02196 - lat) + Math.Abs(-12.54374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34844 - lat) + Math.Abs(-15.47993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6937 - lat) + Math.Abs(-17.44406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.81028 - lat) + Math.Abs(-16.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.63 - lat) + Math.Abs(-16.01694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.37349 - lat) + Math.Abs(-16.94366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10898 - lat) + Math.Abs(-16.71909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.70649 - lat) + Math.Abs(-17.47581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78148 - lat) + Math.Abs(-17.3841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Ziguinchor", "12", 12.56801, -16.27326);
case 1: return new CityInfo("Vélingara", "11", 13.15, -14.11667);
case 2: return new CityInfo("Touba", "03", 14.85, -15.88333);
case 3: return new CityInfo("Tionk Essil", "12", 12.78556, -16.52167);
case 4: return new CityInfo("Tiébo", "03", 14.63333, -16.23333);
case 5: return new CityInfo("Tiadiaye", "07", 14.41667, -16.7);
case 6: return new CityInfo("Thiès Nones", "07", 14.78333, -16.96667);
case 7: return new CityInfo("Thiès", "07", 14.78944, -16.92602);
case 8: return new CityInfo("Tambacounda", "05", 13.77073, -13.66734);
case 9: return new CityInfo("Sokone", "09", 13.88333, -16.36667);
case 10: return new CityInfo("Sémé", "15", 15.19422, -12.94482);
case 11: return new CityInfo("Sédhiou", "18", 12.70806, -15.55694);
case 12: return new CityInfo("Saint-Louis", "14", 16.01793, -16.48962);
case 13: return new CityInfo("Rosso", "14", 16.42028, -15.79834);
case 14: return new CityInfo("Richard-Toll", "14", 16.4625, -15.70083);
case 15: return new CityInfo("Ranérou", "15", 15.3, -13.96667);
case 16: return new CityInfo("Pout", "07", 14.77099, -17.06107);
case 17: return new CityInfo("Pourham", "09", 14.35, -16.41667);
case 18: return new CityInfo("Polel Diaoubé", "14", 15.26667, -13);
case 19: return new CityInfo("Pikine", "01", 14.76457, -17.39071);
case 20: return new CityInfo("Passi", "09", 13.98333, -16.26667);
case 21: return new CityInfo("Oussouye", "12", 12.485, -16.54694);
case 22: return new CityInfo("Ouro Sogui", "15", 15.60588, -13.3223);
case 23: return new CityInfo("Waoundé", "15", 15.26367, -12.86821);
case 24: return new CityInfo("Nioro du Rip", "10", 13.75, -15.8);
case 25: return new CityInfo("Nguékhokh", "07", 14.51255, -17.00447);
case 26: return new CityInfo("Ndofane", "10", 13.91667, -15.93333);
case 27: return new CityInfo("Ndioum", "14", 16.51293, -14.64706);
case 28: return new CityInfo("Ndibène Dahra", "13", 15.3338, -15.4766);
case 29: return new CityInfo("Mékhé", "07", 15.1097, -16.6218);
case 30: return new CityInfo("Mbaké", "03", 14.79032, -15.90803);
case 31: return new CityInfo("Matam", "15", 15.65587, -13.25544);
case 32: return new CityInfo("Marsassoum", "11", 12.8275, -15.98056);
case 33: return new CityInfo("Louga", "13", 15.61867, -16.22436);
case 34: return new CityInfo("Koungheul", "16", 13.98333, -14.8);
case 35: return new CityInfo("Kolda", "11", 12.8939, -14.94125);
case 36: return new CityInfo("Khombole", "07", 14.76667, -16.7);
case 37: return new CityInfo("Keur Babakar Toumbou", "09", 14.10877, -16.719);
case 38: return new CityInfo("Kédougou", "17", 12.55561, -12.18076);
case 39: return new CityInfo("Kayar", "07", 14.91893, -17.11978);
case 40: return new CityInfo("Kaolack", "10", 14.15197, -16.07259);
case 41: return new CityInfo("Kanel", "15", 15.4916, -13.17627);
case 42: return new CityInfo("Kaffrine", "16", 14.10594, -15.5508);
case 43: return new CityInfo("Joal-Fadiout", "07", 14.16667, -16.83333);
case 44: return new CityInfo("Guinguinéo", "09", 14.26667, -15.95);
case 45: return new CityInfo("Guéoul", "13", 15.48333, -16.35);
case 46: return new CityInfo("Goléré", "14", 16.25575, -14.10165);
case 47: return new CityInfo("Gandiaye", "10", 14.23333, -16.26667);
case 48: return new CityInfo("Foundiougne", "09", 14.13333, -16.46667);
case 49: return new CityInfo("Fatick", "09", 14.33236, -16.40513);
case 50: return new CityInfo("Diourbel", "03", 14.64792, -16.24363);
case 51: return new CityInfo("Diofior", "09", 14.18333, -16.66667);
case 52: return new CityInfo("Diawara", "15", 15.02196, -12.54374);
case 53: return new CityInfo("Dara", "13", 15.34844, -15.47993);
case 54: return new CityInfo("Dakar", "01", 14.6937, -17.44406);
case 55: return new CityInfo("Bignona", "12", 12.81028, -16.22639);
case 56: return new CityInfo("Adéane", "12", 12.63, -16.01694);
case 57: return new CityInfo("Warang", "07", 14.37349, -16.94366);
case 58: return new CityInfo("Baboucar Toumbou", "09", 14.10898, -16.71909);
case 59: return new CityInfo("Mermoz Boabab", "01", 14.70649, -17.47581);
default: return new CityInfo("N’diareme limamoulaye", "01", 14.78148, -17.3841);

                                    }                                        
                                }
                            
                        }
                    }
                