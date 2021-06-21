/*
 * Copyright (C) 2021 PatrickKR
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using HarmonyLib;

namespace RDPerfectOnly.Patch
{
    [HarmonyPatch(typeof(scnGame), "OnMistakeOrHeal")]
    internal static class MainPatch
    {
        private static bool Prefix(scnGame __instance)
        {
            if (__instance.levelIdentifier != Level.BeansHopper.ToString())
            {
                __instance.Restart();
            }

            return false;
        }
    }
}