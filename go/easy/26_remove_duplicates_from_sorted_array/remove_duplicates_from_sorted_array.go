package remove_duplicates_from_sorted_array

func RemoveDuplicates(nums []int) int {
	k := 1

	for i := 1; i < len(nums); i++ {
		if nums[i] != nums[i-1] {
			nums[k] = nums[i]
			k++
		}
	}

	return k
}
