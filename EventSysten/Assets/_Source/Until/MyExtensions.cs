using ResourceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Until
{
    public static class MyExtensions
    {
        public static ResourceEnum FindTypeResource(Dropdown dropdown)
        {
            if (dropdown.value == 0)
            {
                return ResourceEnum.Diamond;
            }
            else if (dropdown.value == 1)
            {
                return ResourceEnum.Gold;
            }

            return ResourceEnum.Iron;
        }

        public static Resource FindResource(Resource[] resources, ResourceEnum resourceIndex)
        {
            foreach (var result in resources)
            {
                if (result.GetTypeResource() == resourceIndex)
                {
                    return result;
                }
            }

            return null;
        }
    }
}
