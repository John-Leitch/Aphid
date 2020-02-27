
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
                                    public const string Country = "WS";
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
                            
                                        var cur = (Math.Abs(-13.80781 - lat) + Math.Abs(-171.81205 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-14.03602 - lat) + Math.Abs(-171.67951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.82678 - lat) + Math.Abs(-171.79333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.51439 - lat) + Math.Abs(-172.67522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.86417 - lat) + Math.Abs(-171.76126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.82369 - lat) + Math.Abs(-171.79484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.75551 - lat) + Math.Abs(-172.30698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.80496 - lat) + Math.Abs(-171.91602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.794 - lat) + Math.Abs(-172.5111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87504 - lat) + Math.Abs(-171.64181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.72099 - lat) + Math.Abs(-172.59541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.84432 - lat) + Math.Abs(-171.81397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.75602 - lat) + Math.Abs(-172.37733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.76593 - lat) + Math.Abs(-172.32686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.0276 - lat) + Math.Abs(-171.43022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.51742 - lat) + Math.Abs(-172.69436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83535 - lat) + Math.Abs(-171.97963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.46995 - lat) + Math.Abs(-172.4492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.80472 - lat) + Math.Abs(-171.92229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68726 - lat) + Math.Abs(-172.1918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.00122 - lat) + Math.Abs(-171.42635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.89964 - lat) + Math.Abs(-172.05706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.93375 - lat) + Math.Abs(-171.53122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.50098 - lat) + Math.Abs(-172.30015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.80358 - lat) + Math.Abs(-171.89432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.02882 - lat) + Math.Abs(-171.6984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.44894 - lat) + Math.Abs(-172.33521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.00873 - lat) + Math.Abs(-171.42559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14 - lat) + Math.Abs(-171.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.62921 - lat) + Math.Abs(-172.1979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68733 - lat) + Math.Abs(-172.61864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.67147 - lat) + Math.Abs(-172.17768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.45132 - lat) + Math.Abs(-172.40177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63714 - lat) + Math.Abs(-172.1942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.52463 - lat) + Math.Abs(-172.30678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.91107 - lat) + Math.Abs(-172.02181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.8217 - lat) + Math.Abs(-171.95873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83183 - lat) + Math.Abs(-172.03602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.03208 - lat) + Math.Abs(-171.64768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.03831 - lat) + Math.Abs(-171.67763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.80044 - lat) + Math.Abs(-171.8469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87449 - lat) + Math.Abs(-171.59857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.04288 - lat) + Math.Abs(-171.57036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.97643 - lat) + Math.Abs(-171.85781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.91361 - lat) + Math.Abs(-172.01095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.82297 - lat) + Math.Abs(-171.96127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.85252 - lat) + Math.Abs(-171.72167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83575 - lat) + Math.Abs(-171.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.61749 - lat) + Math.Abs(-172.19919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.04454 - lat) + Math.Abs(-171.43925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.7736 - lat) + Math.Abs(-172.38802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.88645 - lat) + Math.Abs(-171.6218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.81163 - lat) + Math.Abs(-171.94063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.92067 - lat) + Math.Abs(-171.58658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.79457 - lat) + Math.Abs(-171.83126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87761 - lat) + Math.Abs(-171.59235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.88695 - lat) + Math.Abs(-171.58805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.82885 - lat) + Math.Abs(-171.97895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.5167 - lat) + Math.Abs(-172.65245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83333 - lat) + Math.Abs(-171.76666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.79726 - lat) + Math.Abs(-171.85308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.51963 - lat) + Math.Abs(-172.63784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Toamua", "00", -13.80781, -171.81205);
case 1: return new CityInfo("Vaovai", "00", -14.03602, -171.67951);
case 2: return new CityInfo("Vaiusu", "10", -13.82678, -171.79333);
case 3: return new CityInfo("Vaisala", "11", -13.51439, -172.67522);
case 4: return new CityInfo("Vailima", "10", -13.86417, -171.76126);
case 5: return new CityInfo("Vaigaga", "00", -13.82369, -171.79484);
case 6: return new CityInfo("Vailoa", "08", -13.75551, -172.30698);
case 7: return new CityInfo("Tufulele", "00", -13.80496, -171.91602);
case 8: return new CityInfo("Taga", "08", -13.794, -172.5111);
case 9: return new CityInfo("Solosolo", "03", -13.87504, -171.64181);
case 10: return new CityInfo("Siutu", "00", -13.72099, -172.59541);
case 11: return new CityInfo("Siusega", "00", -13.84432, -171.81397);
case 12: return new CityInfo("Sili", "08", -13.75602, -172.37733);
case 13: return new CityInfo("Satupa‘itea", "09", -13.76593, -172.32686);
case 14: return new CityInfo("Satitoa", "03", -14.0276, -171.43022);
case 15: return new CityInfo("Sataua", "11", -13.51742, -172.69436);
case 16: return new CityInfo("Satapuala", "01", -13.83535, -171.97963);
case 17: return new CityInfo("Sasina", "07", -13.46995, -172.4492);
case 18: return new CityInfo("Sapulu", "00", -13.80472, -171.92229);
case 19: return new CityInfo("Sapapali’i", "04", -13.68726, -172.1918);
case 20: return new CityInfo("Samusu", "00", -14.00122, -171.42635);
case 21: return new CityInfo("Samatau", "01", -13.89964, -172.05706);
case 22: return new CityInfo("Samamea", "06", -13.93375, -171.53122);
case 23: return new CityInfo("Samalaeulu", "05", -13.50098, -172.30015);
case 24: return new CityInfo("Salepou‘a‘e", "00", -13.80358, -171.89432);
case 25: return new CityInfo("Saleilua", "00", -14.02882, -171.6984);
case 26: return new CityInfo("Sale’aula", "09", -13.44894, -172.33521);
case 27: return new CityInfo("Sale’a’aumua", "00", -14.00873, -171.42559);
case 28: return new CityInfo("Salani", "03", -14, -171.56667);
case 29: return new CityInfo("Saipipi", "04", -13.62921, -172.1979);
case 30: return new CityInfo("Sagone", "09", -13.68733, -172.61864);
case 31: return new CityInfo("Safotulafai", "04", -13.67147, -172.17768);
case 32: return new CityInfo("Safotu", "07", -13.45132, -172.40177);
case 33: return new CityInfo("Sa’asa’ai", "04", -13.63714, -172.1942);
case 34: return new CityInfo("Patamea", "05", -13.52463, -172.30678);
case 35: return new CityInfo("Pata", "00", -13.91107, -172.02181);
case 36: return new CityInfo("Nofoali‘i", "01", -13.8217, -171.95873);
case 37: return new CityInfo("Mulifanua", "02", -13.83183, -172.03602);
case 38: return new CityInfo("Matavai", "07", -14.03208, -171.64768);
case 39: return new CityInfo("Matautu", "03", -14.03831, -171.67763);
case 40: return new CityInfo("Malie", "10", -13.80044, -171.8469);
case 41: return new CityInfo("Lufilufi", "03", -13.87449, -171.59857);
case 42: return new CityInfo("Lotofaga", "03", -14.04288, -171.57036);
case 43: return new CityInfo("Lotofagā", "03", -13.97643, -171.85781);
case 44: return new CityInfo("Levī", "00", -13.91361, -172.01095);
case 45: return new CityInfo("Leulumoega", "01", -13.82297, -171.96127);
case 46: return new CityInfo("Letogo", "10", -13.85252, -171.72167);
case 47: return new CityInfo("Lepea", "10", -13.83575, -171.79);
case 48: return new CityInfo("Lano", "00", -13.61749, -172.19919);
case 49: return new CityInfo("Lalomanu", "03", -14.04454, -171.43925);
case 50: return new CityInfo("Gataivai", "08", -13.7736, -172.38802);
case 51: return new CityInfo("Fusi", "00", -13.88645, -171.6218);
case 52: return new CityInfo("Fasito‘outa", "01", -13.81163, -171.94063);
case 53: return new CityInfo("Falevao", "00", -13.92067, -171.58658);
case 54: return new CityInfo("Faleula", "00", -13.79457, -171.83126);
case 55: return new CityInfo("Faleapuna", "03", -13.87761, -171.59235);
case 56: return new CityInfo("Falefa", "03", -13.88695, -171.58805);
case 57: return new CityInfo("Faleatiu", "01", -13.82885, -171.97895);
case 58: return new CityInfo("Auala", "11", -13.5167, -172.65245);
case 59: return new CityInfo("Apia", "10", -13.83333, -171.76666);
case 60: return new CityInfo("Afega", "10", -13.79726, -171.85308);
default: return new CityInfo("Asau", "11", -13.51963, -172.63784);

                                    }                                        
                                }
                            
                        }
                    }
                