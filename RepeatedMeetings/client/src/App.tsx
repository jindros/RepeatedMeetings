import { AddIcon } from "@chakra-ui/icons"
import { Box, Button, Flex, Heading, Table, TableCaption, TableContainer, Tbody, Td, Th, Thead, Tr } from "@chakra-ui/react"
import axios from "axios"
import { BASE_URL } from "./constant"
import { Member } from "./types/member";
import { useEffect, useState } from "react";

function App() {
    
    const [data, setData] = useState<Member[]>([]);

    const [isLoading, setIsLoading] = useState<boolean>(false);

    useEffect(() => {
        fetchData();
    }, [])

    const fetchData = () => {
        setIsLoading(true);
        axios.get(BASE_URL + "member").then((response) => {
            setData(response.data);
        }).catch((error) => {
            console.log(error)
        }).finally(() => {
        setIsLoading(false)
        })
    }

  return (

      <Box
          shadow={'md'}
          rounded={'md'}
          m={32}
          >

          <Flex px="5"
              justifyContent={'space-between'} mb='5' alignItems={'center'}>
              

              <Heading>
              Memberss
              </Heading>
              <Button colorScheme='blue' leftIcon={<AddIcon/>}> Add Member </Button>


          </Flex>

      <TableContainer>
          <Table variant='simple'>
              <TableCaption>Imperial to metric conversion factors</TableCaption>
              <Thead>
                  <Tr>
                      <Th>ID  </Th>
                      <Th>Name</Th>
                  </Tr>
              </Thead>
                  <Tbody>

                      {data.map((member: Member) => ( 

                          <Tr key={member.id}>
                              <Td>{member.id}</Td>
                              <Td>{member.fullName}</Td>
                  </Tr>

                      ))}

              </Tbody>
          </Table>
      </TableContainer>
      </Box>

  )
}

export default App
