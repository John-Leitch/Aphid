
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
                                    public const string Country = "NP";
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
                            
                                        var cur = (Math.Abs(27.9837 - lat) + Math.Abs(83.75925 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(28.13099 - lat) + Math.Abs(82.29726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.52823 - lat) + Math.Abs(81.11798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.86731 - lat) + Math.Abs(83.5467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.65422 - lat) + Math.Abs(86.20795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.96588 - lat) + Math.Abs(81.82725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.37858 - lat) + Math.Abs(82.1703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.3256 - lat) + Math.Abs(86.08768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.53968 - lat) + Math.Abs(86.74796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.08867 - lat) + Math.Abs(82.88427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.26689 - lat) + Math.Abs(83.96851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.67658 - lat) + Math.Abs(85.31417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.58453 - lat) + Math.Abs(85.51484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.80528 - lat) + Math.Abs(86.71058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.71522 - lat) + Math.Abs(85.52075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.85658 - lat) + Math.Abs(85.5594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.96399 - lat) + Math.Abs(80.17715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.95 - lat) + Math.Abs(86.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.20992 - lat) + Math.Abs(84.3638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.72022 - lat) + Math.Abs(86.48258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.96057 - lat) + Math.Abs(85.95667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.67872 - lat) + Math.Abs(85.2775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.04651 - lat) + Math.Abs(82.15714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.37604 - lat) + Math.Abs(87.20767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.70169 - lat) + Math.Abs(85.3206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.27472 - lat) + Math.Abs(82.18383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.72882 - lat) + Math.Abs(85.92628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.64921 - lat) + Math.Abs(85.80017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.66371 - lat) + Math.Abs(87.27403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.90943 - lat) + Math.Abs(87.92824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.42839 - lat) + Math.Abs(85.03219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.2058 - lat) + Math.Abs(81.34532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.76448 - lat) + Math.Abs(85.27841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.6221 - lat) + Math.Abs(85.54281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.81436 - lat) + Math.Abs(87.27972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.98333 - lat) + Math.Abs(87.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.70137 - lat) + Math.Abs(80.58975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.83 - lat) + Math.Abs(80.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.84434 - lat) + Math.Abs(81.71011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.29842 - lat) + Math.Abs(80.58059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.92786 - lat) + Math.Abs(81.83956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.70055 - lat) + Math.Abs(83.44836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.01709 - lat) + Math.Abs(84.8808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.45505 - lat) + Math.Abs(87.27007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.93565 - lat) + Math.Abs(81.77555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.1715 - lat) + Math.Abs(87.04607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.6768 - lat) + Math.Abs(84.43589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.67298 - lat) + Math.Abs(85.43005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.5 - lat) + Math.Abs(83.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.54404 - lat) + Math.Abs(88.09436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.30058 - lat) + Math.Abs(81.3536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.63245 - lat) + Math.Abs(85.52192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.27189 - lat) + Math.Abs(83.58975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.05 - lat) + Math.Abs(81.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.23417 - lat) + Math.Abs(82.41278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.60194 - lat) + Math.Abs(81.63389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.26083 - lat) + Math.Abs(80.94 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.05 - lat) + Math.Abs(81.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.61465 - lat) + Math.Abs(84.14721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.55369 - lat) + Math.Abs(84.25097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.28216 - lat) + Math.Abs(84.35912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.42673 - lat) + Math.Abs(83.69076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.51746 - lat) + Math.Abs(81.7787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.78436 - lat) + Math.Abs(83.73513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.58466 - lat) + Math.Abs(85.52122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.64831 - lat) + Math.Abs(84.10279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.60675 - lat) + Math.Abs(87.1478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.62881 - lat) + Math.Abs(85.45934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.7919 - lat) + Math.Abs(86.699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.68056 - lat) + Math.Abs(85.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.6289 - lat) + Math.Abs(85.45893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.88333 - lat) + Math.Abs(83.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.87552 - lat) + Math.Abs(83.92759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.88316 - lat) + Math.Abs(83.93274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.67633 - lat) + Math.Abs(86.11662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Wāliṅ", "4", 27.9837, 83.75925);
case 1: return new CityInfo("Tulsīpur", "5", 28.13099, 82.29726);
case 2: return new CityInfo("Ṭikāpur", "7", 28.52823, 81.11798);
case 3: return new CityInfo("Tānsen", "5", 27.86731, 83.5467);
case 4: return new CityInfo("Siraha", "2", 26.65422, 86.20795);
case 5: return new CityInfo("Simikot", "6", 29.96588, 81.82725);
case 6: return new CityInfo("Salyān", "6", 28.37858, 82.1703);
case 7: return new CityInfo("Rāmechhāp", "3", 27.3256, 86.08768);
case 8: return new CityInfo("Rājbirāj", "2", 26.53968, 86.74796);
case 9: return new CityInfo("Pyūthān", "5", 28.08867, 82.88427);
case 10: return new CityInfo("Pokhara", "4", 28.26689, 83.96851);
case 11: return new CityInfo("Pātan", "3", 27.67658, 85.31417);
case 12: return new CityInfo("Panauti̇̄", "3", 27.58453, 85.51484);
case 13: return new CityInfo("Namche Bazar", "1", 27.80528, 86.71058);
case 14: return new CityInfo("Nagarkot", "3", 27.71522, 85.52075);
case 15: return new CityInfo("Malaṅgawā", "2", 26.85658, 85.5594);
case 16: return new CityInfo("Mahendranagar", "7", 28.96399, 80.17715);
case 17: return new CityInfo("Lobujya", "1", 27.95, 86.81667);
case 18: return new CityInfo("Lamjung", "4", 28.20992, 84.3638);
case 19: return new CityInfo("Lahān", "2", 26.72022, 86.48258);
case 20: return new CityInfo("Kothari", "3", 27.96057, 85.95667);
case 21: return new CityInfo("Kirtipur", "3", 27.67872, 85.2775);
case 22: return new CityInfo("Khārpū", "6", 30.04651, 82.15714);
case 23: return new CityInfo("Khanbari", "1", 27.37604, 87.20767);
case 24: return new CityInfo("Kathmandu", "3", 27.70169, 85.3206);
case 25: return new CityInfo("Jumla", "6", 29.27472, 82.18383);
case 26: return new CityInfo("Janakpur", "2", 26.72882, 85.92628);
case 27: return new CityInfo("Jaleshwar", "2", 26.64921, 85.80017);
case 28: return new CityInfo("Titahari", "1", 26.66371, 87.27403);
case 29: return new CityInfo("Ilām", "1", 26.90943, 87.92824);
case 30: return new CityInfo("Hetauda", "3", 27.42839, 85.03219);
case 31: return new CityInfo("Gulariyā", "5", 28.2058, 81.34532);
case 32: return new CityInfo("Gaur", "2", 26.76448, 85.27841);
case 33: return new CityInfo("Dhulikhel", "3", 27.6221, 85.54281);
case 34: return new CityInfo("Dharān", "1", 26.81436, 87.27972);
case 35: return new CityInfo("Dhankutā", "1", 26.98333, 87.33333);
case 36: return new CityInfo("Dhangaḍhi̇̄", "7", 28.70137, 80.58975);
case 37: return new CityInfo("Dārchulā", "7", 29.83, 80.55);
case 38: return new CityInfo("Dailekh", "6", 28.84434, 81.71011);
case 39: return new CityInfo("Dadeldhurā", "7", 29.29842, 80.58059);
case 40: return new CityInfo("Chhibro", "6", 29.92786, 81.83956);
case 41: return new CityInfo("Butwāl", "5", 27.70055, 83.44836);
case 42: return new CityInfo("Birgañj", "2", 27.01709, 84.8808);
case 43: return new CityInfo("Biratnagar", "1", 26.45505, 87.27007);
case 44: return new CityInfo("Bhojpur", "5", 27.93565, 81.77555);
case 45: return new CityInfo("Bhojpur", "1", 27.1715, 87.04607);
case 46: return new CityInfo("Bharatpur", "3", 27.6768, 84.43589);
case 47: return new CityInfo("Bhaktapur", "3", 27.67298, 85.43005);
case 48: return new CityInfo("Siddharthanagar", "5", 27.5, 83.45);
case 49: return new CityInfo("Bhadrapur", "1", 26.54404, 88.09436);
case 50: return new CityInfo("Bardiyā", "5", 28.30058, 81.3536);
case 51: return new CityInfo("Banepā", "3", 27.63245, 85.52192);
case 52: return new CityInfo("Bāglung", "4", 28.27189, 83.58975);
case 53: return new CityInfo("Achhām", "7", 29.05, 81.3);
case 54: return new CityInfo("Besisahar", "6", 28.23417, 82.41278);
case 55: return new CityInfo("Birendranagar", "6", 28.60194, 81.63389);
case 56: return new CityInfo("Dipayal", "7", 29.26083, 80.94);
case 57: return new CityInfo("Nepalgunj", "5", 28.05, 81.61667);
case 58: return new CityInfo("Pisang", "4", 28.61465, 84.14721);
case 59: return new CityInfo("Chame", "4", 28.55369, 84.25097);
case 60: return new CityInfo("Khudi", "4", 28.28216, 84.35912);
case 61: return new CityInfo("Chitre", "4", 28.42673, 83.69076);
case 62: return new CityInfo("Surkhet", "6", 28.51746, 81.7787);
case 63: return new CityInfo("Jomsom", "4", 28.78436, 83.73513);
case 64: return new CityInfo("Panauti", "3", 27.58466, 85.52122);
case 65: return new CityInfo("Nawal", "4", 28.64831, 84.10279);
case 66: return new CityInfo("Inaruwa", "1", 26.60675, 87.1478);
case 67: return new CityInfo("kankrabari Dovan", "3", 27.62881, 85.45934);
case 68: return new CityInfo("Triyuga", "1", 26.7919, 86.699);
case 69: return new CityInfo("Madhyapur Thimi", "3", 27.68056, 85.3875);
case 70: return new CityInfo("Hari Bdr Tamang House", "3", 27.6289, 85.45893);
case 71: return new CityInfo("Bhattarai Danda", "4", 27.88333, 83.93333);
case 72: return new CityInfo("Dihi", "4", 27.87552, 83.92759);
case 73: return new CityInfo("Sundar Basti", "4", 27.88316, 83.93274);
default: return new CityInfo("Chhetrapa1", "3", 27.67633, 86.11662);

                                    }                                        
                                }
                            
                        }
                    }
                