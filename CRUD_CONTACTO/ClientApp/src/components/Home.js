import React from 'react'
import { Icon, Label, Menu, Table, Button } from 'semantic-ui-react'


const Contacto = (props) => {
  return (
    <div>
      <Button content="Crear" primary/>
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Nombre</Table.HeaderCell>
            <Table.HeaderCell>Apellido</Table.HeaderCell>
            <Table.HeaderCell>Fecha nacimiento</Table.HeaderCell>
            <Table.HeaderCell>Correo</Table.HeaderCell>
            <Table.HeaderCell>Dirección Principal</Table.HeaderCell>
            <Table.HeaderCell>Acción</Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {/* <Table.Row>
            <Table.Cell>Natanael</Table.Cell>
            <Table.Cell>Medina</Table.Cell>
            <Table.Cell>Dejesus</Table.Cell>
          </Table.Row>
          <Table.Row>
            <Table.Cell>Cell</Table.Cell>
            <Table.Cell>Cell</Table.Cell>
            <Table.Cell>Cell</Table.Cell>
          </Table.Row>
          <Table.Row>
            <Table.Cell>Cell</Table.Cell>
            <Table.Cell>Cell</Table.Cell>
            <Table.Cell>Cell</Table.Cell>
          </Table.Row> */}
        </Table.Body>
      </Table>
    </div>
  )
}

export default Contacto
