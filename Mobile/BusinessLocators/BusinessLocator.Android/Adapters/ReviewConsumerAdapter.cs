﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BusinessLocator.Android.Models;
using Refractored.Controls;

namespace BusinessLocator.Android.Adapters
{
    class ReviewConsumerAdapter : BaseAdapter<Review>
    {
        Activity context;
        List<Review> list;

        public ReviewConsumerAdapter(Activity _context, List<Review> _list) : base()

        {
            this.context = _context;
            this.list = _list;

        }
        public override Review this[int position]
        {
            get
            {
                return list[position];
            }
        }


        public override int Count
        {
            get
            {
                return list.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;


            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.ReviewConsumerItem, parent, false);

            Review item = this[position];

            view.FindViewById<TextView>(Resource.Id.name).Text = item.review;
            view.FindViewById<TextView>(Resource.Id.lbltime).Text = item.time;
            view.FindViewById<ImageView>(Resource.Id.profile).SetImageResource(item.image);

            return view;
        }
    }
}