package intersection_of_two_arrays

import "sort"

func Intersection(nums1 []int, nums2 []int) []int {
	sort.Ints(nums1)
	sort.Ints(nums2)

	intersectionMap := make(map[int]bool)

	for i, j := 0, 0; i < len(nums1) && j < len(nums2); {
		if nums1[i] < nums2[j] {
			i++
		} else if nums1[i] > nums2[j] {
			j++
		} else {
			intersectionMap[nums1[i]] = true
			i++
			j++
		}
	}

	result := []int{}
	for num := range intersectionMap {
		result = append(result, num)
	}

	return result
}
