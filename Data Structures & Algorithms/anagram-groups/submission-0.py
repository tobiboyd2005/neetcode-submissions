from collections import defaultdict
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # create a dict
        anagram_map = defaultdict(list)
        # create result array
        result = []

        #for loop to go through each string
        for s in strs:
            # sort the characters of each string
            sort_s = tuple(sorted(s)) # use tuple because it is immutable
            # store each word in the dict and use sorted string as key
            anagram_map[sort_s].append(s)
        # for loop to go through the values of anagram_map
        for v in anagram_map.values():
            # append the values to the result array
            result.append(v)
        
        return result