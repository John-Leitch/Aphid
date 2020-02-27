
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
                                    public const string Country = "LB";
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
                            
                                        var cur = (Math.Abs(34.39739 - lat) + Math.Abs(35.89493 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(33.84675 - lat) + Math.Abs(35.90203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.43352 - lat) + Math.Abs(35.84415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27333 - lat) + Math.Abs(35.19389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.38528 - lat) + Math.Abs(36.03111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55751 - lat) + Math.Abs(35.37148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.9 - lat) + Math.Abs(35.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.36028 - lat) + Math.Abs(35.59111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.98083 - lat) + Math.Abs(35.61778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.62694 - lat) + Math.Abs(35.78417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.12111 - lat) + Math.Abs(35.64806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.54167 - lat) + Math.Abs(35.58444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.39778 - lat) + Math.Abs(35.685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.01722 - lat) + Math.Abs(35.79244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.54278 - lat) + Math.Abs(36.07972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.40729 - lat) + Math.Abs(35.48169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.25083 - lat) + Math.Abs(36.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.11944 - lat) + Math.Abs(35.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80861 - lat) + Math.Abs(35.65972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.795 - lat) + Math.Abs(35.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69417 - lat) + Math.Abs(35.58083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89332 - lat) + Math.Abs(35.50157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.00583 - lat) + Math.Abs(36.21806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.83389 - lat) + Math.Abs(35.54417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.11023 - lat) + Math.Abs(35.40251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.11806 - lat) + Math.Abs(35.13972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.37889 - lat) + Math.Abs(35.48389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.72778 - lat) + Math.Abs(35.93111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.3 - lat) + Math.Abs(35.80889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89056 - lat) + Math.Abs(35.56639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.39417 - lat) + Math.Abs(36.38472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5175 - lat) + Math.Abs(35.36889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.25528 - lat) + Math.Abs(35.65806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80528 - lat) + Math.Abs(35.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.50089 - lat) + Math.Abs(35.8437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zghartā", "09", 34.39739, 35.89493);
case 1: return new CityInfo("Zahlé", "08", 33.84675, 35.90203);
case 2: return new CityInfo("Tripoli", "09", 34.43352, 35.84415);
case 3: return new CityInfo("Tyre", "06", 33.27333, 35.19389);
case 4: return new CityInfo("Sîr ed Danniyé", "09", 34.38528, 36.03111);
case 5: return new CityInfo("Sidon", "06", 33.55751, 35.37148);
case 6: return new CityInfo("Ra’s Bayrūt", "04", 33.9, 35.48333);
case 7: return new CityInfo("Marjayoûn", "07", 33.36028, 35.59111);
case 8: return new CityInfo("Jounieh", "05", 33.98083, 35.61778);
case 9: return new CityInfo("Joubb Jannîne", "08", 33.62694, 35.78417);
case 10: return new CityInfo("Jbaïl", "05", 34.12111, 35.64806);
case 11: return new CityInfo("Jezzîne", "06", 33.54167, 35.58444);
case 12: return new CityInfo("Hâsbaïya", "07", 33.39778, 35.685);
case 13: return new CityInfo("Hrajel", "05", 34.01722, 35.79244);
case 14: return new CityInfo("Halba", "10", 34.54278, 36.07972);
case 15: return new CityInfo("Habboûch", "07", 33.40729, 35.48169);
case 16: return new CityInfo("Bcharré", "09", 34.25083, 36.01056);
case 17: return new CityInfo("Bent Jbaïl", "07", 33.11944, 35.43333);
case 18: return new CityInfo("Bhamdoûn el Mhatta", "05", 33.80861, 35.65972);
case 19: return new CityInfo("Bhamdoun", "05", 33.795, 35.65111);
case 20: return new CityInfo("Beït ed Dîne", "05", 33.69417, 35.58083);
case 21: return new CityInfo("Beirut", "04", 33.89332, 35.50157);
case 22: return new CityInfo("Baalbek", "11", 34.00583, 36.21806);
case 23: return new CityInfo("Baabda", "05", 33.83389, 35.54417);
case 24: return new CityInfo("Ain Ebel", "07", 33.11023, 35.40251);
case 25: return new CityInfo("En Nâqoûra", "06", 33.11806, 35.13972);
case 26: return new CityInfo("Nabatîyé et Tahta", "07", 33.37889, 35.48389);
case 27: return new CityInfo("Aanjar", "08", 33.72778, 35.93111);
case 28: return new CityInfo("Amioûn", "09", 34.3, 35.80889);
case 29: return new CityInfo("Jdaidet el Matn", "05", 33.89056, 35.56639);
case 30: return new CityInfo("El Hermel", "11", 34.39417, 36.38472);
case 31: return new CityInfo("Ghazieh", "06", 33.5175, 35.36889);
case 32: return new CityInfo("Batroûn", "09", 34.25528, 35.65806);
case 33: return new CityInfo("Aaley", "05", 33.80528, 35.6);
default: return new CityInfo("Râchaïya el Ouadi", "08", 33.50089, 35.8437);

                                    }                                        
                                }
                            
                        }
                    }
                