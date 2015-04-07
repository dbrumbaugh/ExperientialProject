module dll_test
    contains
    
    subroutine test_routine(a)
        !DEC$ ATTRIBUTES DLLEXPORT, DECORATE, ALIAS : "test_routine" :: test_routine
        !DEC$ ATTRIBUTES REFERENCE :: a
    
        integer, intent(inout) :: a
        a = a + 5
    end subroutine test_routine
end module dll_test
    
module radioactive_decay
    contains
    
    subroutine radioactive_decay_mod(results, nuclei, decayconst, timestep, maxtime)
        !DEC$ ATTRIBUTES DLLEXPORT, DECORATE, ALIAS : "radioactive_decay_mod" :: radioactive_decay_mod
        !DEC$ ATTRIBUTES REFERENCE :: results,nuclei,decayconst,timestep,maxtime
    
        integer, intent(in) :: nuclei
        integer :: stepno, i
        real, intent(in)    :: decayconst, timestep, maxtime
        real, allocatable, dimension(:,:), intent(out) :: results
    
        stepno = maxtime/timestep
    
        allocate(results(0:stepno, 0:stepno))
    
        results(0,0) = 0
        results(1,0) = nuclei
    
        do i = 1, stepno
            results(0, i) = results(0, i-1) + timestep
            results(1,i)  = results(0, i-1) + (radioactive_model_dev(nuclei, decayconst)*timestep)
        end do
    end subroutine radioactive_decay_mod
    
    function radioactive_model_dev(n, t)
        real, intent(in) :: t
        integer, intent(in) :: n
        real :: radioactive_model_dev
        
        radioactive_model_dev = n * t
    end function radioactive_model_dev
    
end module
    