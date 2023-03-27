using ResourceSystem;
using System.Collections.Generic;
using UnityEngine;
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
            if (dropdown.value == 1)
            {
                return ResourceEnum.Gold;
            }

            return ResourceEnum.Iron;
        }

        public static ResourceController FindResource(List<ResourceController> resources, ResourceEnum resourceIndex)
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
