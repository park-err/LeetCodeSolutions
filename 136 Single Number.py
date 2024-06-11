def permute(nums):

    permutations = []
    for i in range(len(nums)):
        for j in range(len(nums)):
            if i != j:
                t = nums
                temp = t[i]
                t[i] = t[j]
                t[j] = temp
                permutations.append(t)
            
        
    
    return permutations

nums = [1,2,3]
print(permute(nums))
