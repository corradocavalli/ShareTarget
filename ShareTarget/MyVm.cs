// -----------------------------------------------------------------------
// <copyright file="MyVm.cs" company="IBV Informatik AG">
//    Copyright (c) IBV Informatik AG All rights reserved.
// </copyright>
// 
//  author: Corrado Cavalli
// created: 2018-03-19 @ 21:48
//  edited: 2018-03-19 @ 21:53
// -----------------------------------------------------------------------

#region Using

using System.Collections.ObjectModel;

#endregion

namespace ShareTarget
{
    public class MyVm
    {
        private static MyVm instance;
        public static MyVm Instance => instance ?? (instance = new MyVm());

        public MyVm()
        {
            this.Values.Add(new MyUnit());
            instance = this;
        }

        public ObservableCollection<MyUnit> Values { get; set; }=new ObservableCollection<MyUnit>();
    }

    public class MyUnit
    {
        public string Value { get; set; }
    }
}