﻿using ResourceSystem;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Until
{
    public static class MyExtensions
    {
        public static ResourceEnum FindTypeResource(int index)
        {
            if (index == 0)
            {
                return ResourceEnum.Diamond;
            }
            if (index == 1)
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
