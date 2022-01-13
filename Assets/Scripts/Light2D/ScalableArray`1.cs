using UnityEngine;

namespace Light2D
{
    public class ScalableArray<T>
    {
        // Fields
        private T[] m_Array;
        private int m_Legnth;
        
        // Properties
        public T[] array { get; set; }
        public T Item { get; set; }
        public int capacity { get; }
        public int length { get; set; }
        
        // Methods
        public T[] get_array()
        {
            return (T[])this;
        }
        private void set_array(T[] value)
        {
            mem[1152921512186327312] = value;
        }
        public T get_Item(int index)
        {
            Light2D.RaycastInfo val_0;
            var val_1 = 24;
            val_1 = X21 + ((long)index * val_1);
            val_0.localPosition.y = ((long)(int)(index) * 24) + X21 + 48;
            val_0.collider = ((long)(int)(index) * 24) + X21 + 32;
            return val_0;
        }
        public void set_Item(int index, T value)
        {
            var val_1 = 24;
            val_1 = X20 + ((long)index * val_1);
            mem2[0] = value.localPosition.y;
            mem2[0] = value.collider;
        }
        public int get_capacity()
        {
            if(X8 == 0)
            {
                    return 0;
            }
            
            return (int)X8 + 24;
        }
        public int get_length()
        {
            return (int)this;
        }
        private void set_length(int value)
        {
            mem[1152921512186956696] = value;
        }
        public ScalableArray<T>(int defaultCapacity)
        {
            mem[1152921512187072784] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public void Clear()
        {
            if(this == null)
            {
                
            }
        
        }
        public void SetLength(int length)
        {
            if(this == null)
            {
                
            }
        
        }
        public void Rescale(int capacity, bool copyOriginals = False)
        {
            var val_2;
            var val_3;
            val_2 = capacity;
            if(this == val_2)
            {
                    return;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192;
            val_2 = val_3;
            mem[1152921512187416976] = val_2;
            if((copyOriginals == false) || (this < 1))
            {
                goto label_6;
            }
            
            var val_3 = 0;
            val_3 = 24;
            label_10:
            if(val_3 >= (__RuntimeMethodHiddenParam + 24 + 192 + 24))
            {
                goto label_6;
            }
            
            var val_1 = X25 + (0 * val_3);
            var val_2 = val_2 + (0 * val_3);
            val_3 = val_3 + 1;
            mem2[0] = (0 * val_3) + X25 + 48;
            mem2[0] = (0 * val_3) + X25 + 32;
            if(val_3 < this)
            {
                goto label_10;
            }
            
            label_6:
            mem[1152921512187416976] = val_2;
        }
        public void Add(T item)
        {
            var val_1 = 24;
            val_1 = X23 + ((-1009240368) * val_1);
            mem2[0] = item.localPosition.y;
            mem2[0] = item.collider;
        }
        public void Insert(T item, int index)
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 40) <= index)
            {
                    int val_1 = index << 1;
            }
            
            var val_3 = 24;
            val_3 = this + ((long)index * val_3);
            mem2[0] = item.localPosition.y;
            mem2[0] = item.collider;
            if(this > index)
            {
                    return;
            }
            
            int val_2 = index + 1;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
    
    }

}
