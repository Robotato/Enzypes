using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network.Scripting
{
    public abstract class Action
    {
        public double InitTime { get; private set; }
        
        public int TargetIndex { get; private set; }

        public enum ActionTargetProperty { A_k, N_k }
        public ActionTargetProperty TargetProperty { get; private set; }

        private double _value;
        public double Value
        {
            get { return _value; }
            private set
            {
                switch (TargetProperty)
                {
                    case ActionTargetProperty.A_k:
                        if (value <= 1 && value >= 0)
                        {
                            _value = value;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("A_k must be on interval [0,1]");
                        }
                        break;

                    case ActionTargetProperty.N_k:
                        if (value >= 0)
                        {
                            _value = value;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("N_k must be >= 0");
                        }
                        break;
                }
            }
        }

        public Action(double initTime, int targetIndex, ActionTargetProperty targetProperty, double value)
        {
            InitTime = initTime;
            TargetIndex = targetIndex;
            TargetProperty = targetProperty;

            Value = value;
        }
    }

    public class HeldAction : Action
    {
        public double StopTime { get; private set; }

        public HeldAction(double initTime, int targetIndex, ActionTargetProperty targetProperty, double value, double stopTime)
            : base(initTime, targetIndex, targetProperty, value)
        {
            StopTime = stopTime;
        }
    }

    public class StepAction : Action
    {
        public StepAction(double initTime, int targetIndex, ActionTargetProperty targetProperty, double value)
            : base(initTime, targetIndex, targetProperty, value)
        {
        }
    }
}