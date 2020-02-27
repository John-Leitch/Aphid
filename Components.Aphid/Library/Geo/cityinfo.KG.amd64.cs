
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
                                    public const string Country = "KG";
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
                            
                                        var cur = (Math.Abs(39.9026 - lat) + Math.Abs(71.10826 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.93652 - lat) + Math.Abs(69.56779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56559 - lat) + Math.Abs(72.27153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88899 - lat) + Math.Abs(69.93559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94319 - lat) + Math.Abs(71.34184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84434 - lat) + Math.Abs(70.01474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83895 - lat) + Math.Abs(69.5276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55274 - lat) + Math.Abs(72.20518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76849 - lat) + Math.Abs(69.46398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46017 - lat) + Math.Abs(76.18709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22881 - lat) + Math.Abs(72.05924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7276 - lat) + Math.Abs(78.36476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16878 - lat) + Math.Abs(77.44073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84194 - lat) + Math.Abs(75.30149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49948 - lat) + Math.Abs(78.52702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34612 - lat) + Math.Abs(72.21707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52277 - lat) + Math.Abs(72.24274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8982 - lat) + Math.Abs(72.90481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81973 - lat) + Math.Abs(75.28233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63707 - lat) + Math.Abs(73.89608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.85401 - lat) + Math.Abs(74.30257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7362 - lat) + Math.Abs(71.60982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34211 - lat) + Math.Abs(78.00644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76994 - lat) + Math.Abs(73.30068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52828 - lat) + Math.Abs(72.7985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05689 - lat) + Math.Abs(71.66945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42866 - lat) + Math.Abs(75.99111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49298 - lat) + Math.Abs(71.9236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0601 - lat) + Math.Abs(72.63285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88454 - lat) + Math.Abs(74.67819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25684 - lat) + Math.Abs(72.12793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21552 - lat) + Math.Abs(75.75659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03709 - lat) + Math.Abs(72.4832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.61981 - lat) + Math.Abs(71.5891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21218 - lat) + Math.Abs(71.63274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40452 - lat) + Math.Abs(74.02828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49399 - lat) + Math.Abs(71.75826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29513 - lat) + Math.Abs(72.18627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7046 - lat) + Math.Abs(72.86666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49068 - lat) + Math.Abs(78.39362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12209 - lat) + Math.Abs(72.09271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81423 - lat) + Math.Abs(73.84813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76536 - lat) + Math.Abs(71.09181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.89106 - lat) + Math.Abs(74.85077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82469 - lat) + Math.Abs(73.67585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.14107 - lat) + Math.Abs(77.17848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93333 - lat) + Math.Abs(73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88778 - lat) + Math.Abs(75.085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54689 - lat) + Math.Abs(72.20921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26667 - lat) + Math.Abs(72.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3138 - lat) + Math.Abs(73.44418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26597 - lat) + Math.Abs(72.61834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.64944 - lat) + Math.Abs(77.08225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.92768 - lat) + Math.Abs(74.51699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.78611 - lat) + Math.Abs(75.69167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.11769 - lat) + Math.Abs(76.99332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.87 - lat) + Math.Abs(74.59 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82944 - lat) + Math.Abs(74.1083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0376 - lat) + Math.Abs(72.74586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06259 - lat) + Math.Abs(70.81939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26668 - lat) + Math.Abs(74.95698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16951 - lat) + Math.Abs(75.80099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51608 - lat) + Math.Abs(72.4996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2363 - lat) + Math.Abs(71.49899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4105 - lat) + Math.Abs(71.48628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03083 - lat) + Math.Abs(69.81861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87442 - lat) + Math.Abs(72.94192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14724 - lat) + Math.Abs(71.72962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35473 - lat) + Math.Abs(72.65678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76222 - lat) + Math.Abs(73.20033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24428 - lat) + Math.Abs(72.04475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63223 - lat) + Math.Abs(73.59249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10934 - lat) + Math.Abs(70.84636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16169 - lat) + Math.Abs(70.81959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9981 - lat) + Math.Abs(70.54589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31055 - lat) + Math.Abs(71.34966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0517 - lat) + Math.Abs(71.73726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9986 - lat) + Math.Abs(71.07338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24019 - lat) + Math.Abs(71.89983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10635 - lat) + Math.Abs(69.64127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89877 - lat) + Math.Abs(69.3716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84331 - lat) + Math.Abs(69.71355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9599 - lat) + Math.Abs(70.48451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94591 - lat) + Math.Abs(71.26086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87438 - lat) + Math.Abs(70.52211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tayan", "09", 39.9026, 71.10826);
case 1: return new CityInfo("Suluktu", "09", 39.93652, 69.56779);
case 2: return new CityInfo("Kyzyl-Eshme", "08", 39.56559, 72.27153);
case 3: return new CityInfo("Korgon", "09", 39.88899, 69.93559);
case 4: return new CityInfo("Aydarken", "09", 39.94319, 71.34184);
case 5: return new CityInfo("Katran", "09", 39.84434, 70.01474);
case 6: return new CityInfo("Isfana", "09", 39.83895, 69.5276);
case 7: return new CityInfo("Daroot-Korgon", "08", 39.55274, 72.20518);
case 8: return new CityInfo("Andarak", "09", 39.76849, 69.46398);
case 9: return new CityInfo("Balykchy", "07", 42.46017, 76.18709);
case 10: return new CityInfo("Uch-Korgon", "09", 40.22881, 72.05924);
case 11: return new CityInfo("Tyup", "07", 42.7276, 78.36476);
case 12: return new CityInfo("Tossor", "07", 42.16878, 77.44073);
case 13: return new CityInfo("Tokmok", "02", 42.84194, 75.30149);
case 14: return new CityInfo("Ak-Suu", "07", 42.49948, 78.52702);
case 15: return new CityInfo("Tash-Kumyr", "03", 41.34612, 72.21707);
case 16: return new CityInfo("Talas", "06", 42.52277, 72.24274);
case 17: return new CityInfo("Suzak", "03", 40.8982, 72.90481);
case 18: return new CityInfo("Chuy", "02", 42.81973, 75.28233);
case 19: return new CityInfo("Sosnovka", "02", 42.63707, 73.89608);
case 20: return new CityInfo("Sokuluk", "02", 42.85401, 74.30257);
case 21: return new CityInfo("Pokrovka", "06", 42.7362, 71.60982);
case 22: return new CityInfo("Kyzyl-Suu", "07", 42.34211, 78.00644);
case 23: return new CityInfo("Uzgen", "08", 40.76994, 73.30068);
case 24: return new CityInfo("Osh", "08", 40.52828, 72.7985);
case 25: return new CityInfo("Orozbekovo", "09", 40.05689, 71.66945);
case 26: return new CityInfo("Naryn", "04", 41.42866, 75.99111);
case 27: return new CityInfo("Bakai-Ata", "06", 42.49298, 71.9236);
case 28: return new CityInfo("Massy", "03", 41.0601, 72.63285);
case 29: return new CityInfo("Lebedinovka", "02", 42.88454, 74.67819);
case 30: return new CityInfo("Kyzyl-Kyya", "09", 40.25684, 72.12793);
case 31: return new CityInfo("Kochkor", "04", 42.21552, 75.75659);
case 32: return new CityInfo("Kochkor-Ata", "03", 41.03709, 72.4832);
case 33: return new CityInfo("Kyzyl-Adyr", "06", 42.61981, 71.5891);
case 34: return new CityInfo("Khalmion", "09", 40.21218, 71.63274);
case 35: return new CityInfo("Kazarman", "03", 41.40452, 74.02828);
case 36: return new CityInfo("Kerben", "03", 41.49399, 71.75826);
case 37: return new CityInfo("Karavan", "09", 40.29513, 72.18627);
case 38: return new CityInfo("Kara Suu", "08", 40.7046, 72.86666);
case 39: return new CityInfo("Karakol", "07", 42.49068, 78.39362);
case 40: return new CityInfo("Kara-Dzhygach", "09", 40.12209, 72.09271);
case 41: return new CityInfo("Kara-Balta", "02", 42.81423, 73.84813);
case 42: return new CityInfo("Kanysh-Kyya", "03", 41.76536, 71.09181);
case 43: return new CityInfo("Kant", "02", 42.89106, 74.85077);
case 44: return new CityInfo("Kaindy", "02", 42.82469, 73.67585);
case 45: return new CityInfo("Kadzhi-Say", "07", 42.14107, 77.17848);
case 46: return new CityInfo("Jalal-Abad", "03", 40.93333, 73);
case 47: return new CityInfo("Ivanovka", "02", 42.88778, 75.085);
case 48: return new CityInfo("Ivanovo-Alekseyevka", "06", 42.54689, 72.20921);
case 49: return new CityInfo("Iradan", "09", 40.26667, 72.1);
case 50: return new CityInfo("Gul’cha", "08", 40.3138, 73.44418);
case 51: return new CityInfo("Nookat", "08", 40.26597, 72.61834);
case 52: return new CityInfo("Cholpon-Ata", "07", 42.64944, 77.08225);
case 53: return new CityInfo("Chayek", "04", 41.92768, 74.51699);
case 54: return new CityInfo("Kemin", "02", 42.78611, 75.69167);
case 55: return new CityInfo("Bokombayevskoye", "07", 42.11769, 76.99332);
case 56: return new CityInfo("Bishkek", "01", 42.87, 74.59);
case 57: return new CityInfo("Belovodskoye", "02", 42.82944, 74.1083);
case 58: return new CityInfo("Bazar-Korgon", "03", 41.0376, 72.74586);
case 59: return new CityInfo("Batken", "09", 40.06259, 70.81939);
case 60: return new CityInfo("Baetovo", "04", 41.26668, 74.95698);
case 61: return new CityInfo("At-Bashi", "04", 41.16951, 75.80099);
case 62: return new CityInfo("Aravan", "08", 40.51608, 72.4996);
case 63: return new CityInfo("Alga", "09", 40.2363, 71.49899);
case 64: return new CityInfo("Ala-Buka", "03", 41.4105, 71.48628);
case 65: return new CityInfo("Beshkent", "09", 40.03083, 69.81861);
case 66: return new CityInfo("Toktogul", "03", 41.87442, 72.94192);
case 67: return new CityInfo("Pulgon", "09", 40.14724, 71.72962);
case 68: return new CityInfo("Talas", "", 42.35473, 72.65678);
case 69: return new CityInfo("Üch-Terek", "03", 41.76222, 73.20033);
case 70: return new CityInfo("Kara-Dëbë", "09", 40.24428, 72.04475);
case 71: return new CityInfo("Kara-Kulja", "08", 40.63223, 73.59249);
case 72: return new CityInfo("Chek", "09", 40.10934, 70.84636);
case 73: return new CityInfo("Kara-Bak", "09", 40.16169, 70.81959);
case 74: return new CityInfo("Samarkandyk", "09", 39.9981, 70.54589);
case 75: return new CityInfo("Kyrgyz-Kyshtak", "09", 40.31055, 71.34966);
case 76: return new CityInfo("Kyzyl-Bulak", "09", 40.0517, 71.73726);
case 77: return new CityInfo("Boz-Adyr", "09", 39.9986, 71.07338);
case 78: return new CityInfo("Markaz", "09", 40.24019, 71.89983);
case 79: return new CityInfo("Kulundu", "09", 40.10635, 69.64127);
case 80: return new CityInfo("Ak-Suu", "09", 39.89877, 69.3716);
case 81: return new CityInfo("Toguz-Bulak", "09", 39.84331, 69.71355);
case 82: return new CityInfo("Ak-Tatyr", "09", 39.9599, 70.48451);
case 83: return new CityInfo("Ormosh", "09", 39.94591, 71.26086);
default: return new CityInfo("Ak-Say", "09", 39.87438, 70.52211);

                                    }                                        
                                }
                            
                        }
                    }
                