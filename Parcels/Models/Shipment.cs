using System;
using System.Collections.Generic;
namespace Parcels.Models
{
    public class Shipment
    {
        private double _length;
        private double _height;
        private double _width;
        private double _weight;
        private double _volume;
        private double _shippingCost;
        private int _shipmentNumber;
        private static List<Shipment> _shipmentList = new List<Shipment>() { };

        public Shipment(string newLength, string newHeight, string newWidth, string newWeight)
        {
            _length = double.Parse(newLength);
            _height = double.Parse(newHeight);
            _width = double.Parse(newWidth);
            _weight = double.Parse(newWeight);
            SetVolume();
        }
        public int GetNumber()
        {
            return _shipmentNumber;
        }

        public void SetShipmentNumber()
        {
            _shipmentNumber = _shipmentList.Count;
        }

        public double GetLength()
        {
            return _length;
        }

        public void SetLength(string newLength)
        {
            _length = double.Parse(newLength);
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(string newHeight)
        {
            _height = double.Parse(newHeight);
        }

        public double GetWidth()
        {
            return _width;
        }

        public void SetWidth(string newWidth)
        {
            _width = double.Parse(newWidth);
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(string newWeight)
        {
            _weight = double.Parse(newWeight);
        }

        public double GetVolume()
        {
            return _volume;
        }

        public void SetVolume()
        {
            _volume = _length * _width *_height;
        }

        public double GetShippingCost()
        {
            return _shippingCost;
        }

        public double CalcVolumeCost()
        {
            if (_volume <= 400)
            {
                return 5;
            }
            else if (_volume >= 401 && _volume <= 500)
            {
                return 10;
            }
            else if (_volume >= 501 && _volume <= 600)
            {
                return 15;
            }
            else if (_volume >= 601 && _volume <= 800)
            {
                return 20;
            }
            else
            {
                return 20 + ((_volume - 800) * 0.05);
            }
        }

        public double CalcWeightCost()
        {
            if (_weight <= 10)
            {
                return 10;
            }
            else if (_weight >= 11 && _weight <=20)
            {
                return 15;
            }
            else if (_weight >= 21 && _weight <= 30)
            {
                return 20;
            }
            else
            {
                return 25 + ((_weight - 31) * 0.05);    
            }
        }

        public void SetShippingCost()
        {
            _shippingCost = CalcVolumeCost() + CalcWeightCost();
        }

        public void Save()
        {
            _shipmentList.Add(this);
            SetShipmentNumber();
        }

        public List<Shipment> GetShipmentList()
        {
            return _shipmentList;
        }
    }
}
