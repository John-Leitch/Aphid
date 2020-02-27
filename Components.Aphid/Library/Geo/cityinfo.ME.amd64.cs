
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
                                    public const string Country = "ME";
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
                            
                                        var cur = (Math.Abs(42.83299 - lat) + Math.Abs(20.16652 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(42.75 - lat) + Math.Abs(19.09111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15423 - lat) + Math.Abs(19.12325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32583 - lat) + Math.Abs(19.29778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.92936 - lat) + Math.Abs(19.22436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.36556 - lat) + Math.Abs(19.33139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43623 - lat) + Math.Abs(18.69361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.14278 - lat) + Math.Abs(19.04667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38472 - lat) + Math.Abs(19.07306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.51944 - lat) + Math.Abs(19.25806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.097 - lat) + Math.Abs(19.136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.515 - lat) + Math.Abs(19.195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95639 - lat) + Math.Abs(19.09667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.515 - lat) + Math.Abs(18.69556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59806 - lat) + Math.Abs(19.95056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.4575 - lat) + Math.Abs(18.74222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.44111 - lat) + Math.Abs(19.26361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15278 - lat) + Math.Abs(18.83944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3567 - lat) + Math.Abs(19.35843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59694 - lat) + Math.Abs(19.94556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.20556 - lat) + Math.Abs(18.9425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.48694 - lat) + Math.Abs(18.69917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43388 - lat) + Math.Abs(18.81018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7731 - lat) + Math.Abs(18.94446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43167 - lat) + Math.Abs(18.7575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.42 - lat) + Math.Abs(18.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.96044 - lat) + Math.Abs(19.5833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34167 - lat) + Math.Abs(19.22139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82917 - lat) + Math.Abs(18.90444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32361 - lat) + Math.Abs(19.27278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49722 - lat) + Math.Abs(18.65806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.74111 - lat) + Math.Abs(19.11917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.42067 - lat) + Math.Abs(18.76825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82229 - lat) + Math.Abs(19.51653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.8425 - lat) + Math.Abs(19.87333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46007 - lat) + Math.Abs(18.50647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45306 - lat) + Math.Abs(18.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.56194 - lat) + Math.Abs(19.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5 - lat) + Math.Abs(19.19583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.33222 - lat) + Math.Abs(19.21194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.335 - lat) + Math.Abs(19.23111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71528 - lat) + Math.Abs(19.12333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.40111 - lat) + Math.Abs(19.19722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.44306 - lat) + Math.Abs(18.68861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45417 - lat) + Math.Abs(18.76833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.04889 - lat) + Math.Abs(19.14389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.41861 - lat) + Math.Abs(19.33889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43694 - lat) + Math.Abs(18.60222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55384 - lat) + Math.Abs(19.14608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.53472 - lat) + Math.Abs(19.1175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.39063 - lat) + Math.Abs(18.91417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.28639 - lat) + Math.Abs(18.84 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.385 - lat) + Math.Abs(19.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03834 - lat) + Math.Abs(19.74758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.30306 - lat) + Math.Abs(19.19806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45333 - lat) + Math.Abs(18.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.28389 - lat) + Math.Abs(18.86917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.0875 - lat) + Math.Abs(19.485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.0937 - lat) + Math.Abs(19.09841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.4425 - lat) + Math.Abs(18.63 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.73389 - lat) + Math.Abs(19.79194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.90889 - lat) + Math.Abs(19.96444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.41861 - lat) + Math.Abs(18.76639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.11556 - lat) + Math.Abs(19.08833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Rožaje", "17", 42.83299, 20.16652);
case 1: return new CityInfo("Zagrad", "12", 42.75, 19.09111);
case 2: return new CityInfo("Žabljak", "21", 43.15423, 19.12325);
case 3: return new CityInfo("Vranj", "16", 42.32583, 19.29778);
case 4: return new CityInfo("Ulcinj", "20", 41.92936, 19.22436);
case 5: return new CityInfo("Tuzi", "24", 42.36556, 19.33139);
case 6: return new CityInfo("Tivat", "19", 42.43623, 18.69361);
case 7: return new CityInfo("Sutomore", "02", 42.14278, 19.04667);
case 8: return new CityInfo("Šula", "14", 43.38472, 19.07306);
case 9: return new CityInfo("Stijena", "16", 42.51944, 19.25806);
case 10: return new CityInfo("Stari Bar", "02", 42.097, 19.136);
case 11: return new CityInfo("Spuž", "07", 42.515, 19.195);
case 12: return new CityInfo("Šavnik", "18", 42.95639, 19.09667);
case 13: return new CityInfo("Risan", "10", 42.515, 18.69556);
case 14: return new CityInfo("Prnjavor", "13", 42.59806, 19.95056);
case 15: return new CityInfo("Prčanj", "10", 42.4575, 18.74222);
case 16: return new CityInfo("Podgorica", "16", 42.44111, 19.26361);
case 17: return new CityInfo("Plužine", "15", 43.15278, 18.83944);
case 18: return new CityInfo("Pljevlja", "14", 43.3567, 19.35843);
case 19: return new CityInfo("Plav", "13", 42.59694, 19.94556);
case 20: return new CityInfo("Petrovac na Moru", "05", 42.20556, 18.9425);
case 21: return new CityInfo("Perast", "10", 42.48694, 18.69917);
case 22: return new CityInfo("Njeguši", "06", 42.43388, 18.81018);
case 23: return new CityInfo("Nikšić", "12", 42.7731, 18.94446);
case 24: return new CityInfo("Muo", "10", 42.43167, 18.7575);
case 25: return new CityInfo("Mrčevac", "19", 42.42, 18.71806);
case 26: return new CityInfo("Mojkovac", "11", 42.96044, 19.5833);
case 27: return new CityInfo("Mojanovići", "16", 42.34167, 19.22139);
case 28: return new CityInfo("Miločani", "12", 42.82917, 18.90444);
case 29: return new CityInfo("Mataguži", "16", 42.32361, 19.27278);
case 30: return new CityInfo("Lipci", "00", 42.49722, 18.65806);
case 31: return new CityInfo("Kuta", "12", 42.74111, 19.11917);
case 32: return new CityInfo("Kotor", "10", 42.42067, 18.76825);
case 33: return new CityInfo("Kolašin", "09", 42.82229, 19.51653);
case 34: return new CityInfo("Berane", "03", 42.8425, 19.87333);
case 35: return new CityInfo("Igalo", "08", 42.46007, 18.50647);
case 36: return new CityInfo("Herceg Novi", "08", 42.45306, 18.5375);
case 37: return new CityInfo("Gusinje", "22", 42.56194, 19.83389);
case 38: return new CityInfo("Grbe", "07", 42.5, 19.19583);
case 39: return new CityInfo("Goričani", "16", 42.33222, 19.21194);
case 40: return new CityInfo("Golubovci", "16", 42.335, 19.23111);
case 41: return new CityInfo("Dučice", "12", 42.71528, 19.12333);
case 42: return new CityInfo("Donji Kokoti", "16", 42.40111, 19.19722);
case 43: return new CityInfo("Donja Lastva", "19", 42.44306, 18.68861);
case 44: return new CityInfo("Dobrota", "10", 42.45417, 18.76833);
case 45: return new CityInfo("Dobra Voda", "02", 42.04889, 19.14389);
case 46: return new CityInfo("Dinoša", "16", 42.41861, 19.33889);
case 47: return new CityInfo("Ðenovići", "08", 42.43694, 18.60222);
case 48: return new CityInfo("Danilovgrad", "07", 42.55384, 19.14608);
case 49: return new CityInfo("Ćurilac", "07", 42.53472, 19.1175);
case 50: return new CityInfo("Cetinje", "06", 42.39063, 18.91417);
case 51: return new CityInfo("Budva", "05", 42.28639, 18.84);
case 52: return new CityInfo("Botun", "16", 42.385, 19.2);
case 53: return new CityInfo("Bijelo Polje", "04", 43.03834, 19.74758);
case 54: return new CityInfo("Bijelo Polje", "16", 42.30306, 19.19806);
case 55: return new CityInfo("Bijela", "08", 42.45333, 18.65556);
case 56: return new CityInfo("Bečići", "00", 42.28389, 18.86917);
case 57: return new CityInfo("Barice", "04", 43.0875, 19.485);
case 58: return new CityInfo("Bar", "02", 42.0937, 19.09841);
case 59: return new CityInfo("Baošići", "08", 42.4425, 18.63);
case 60: return new CityInfo("Andrijevica", "01", 42.73389, 19.79194);
case 61: return new CityInfo("Petnjica", "23", 42.90889, 19.96444);
case 62: return new CityInfo("Škaljari", "10", 42.41861, 18.76639);
default: return new CityInfo("Šušanj", "02", 42.11556, 19.08833);

                                    }                                        
                                }
                            
                        }
                    }
                