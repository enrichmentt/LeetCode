package move_zeroes

func MoveZeroes(nums []int) {
	k := 0

	for i, v := range nums {
		if v == 0 {
			continue
		} else {
			nums[k], nums[i] = nums[i], nums[k]
			k++
		}
	}
}
